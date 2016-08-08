using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace SymbolicinkCreator.Services
{
    public class SymbolicinkCreatorSingletonService
    {
        // 単一のインスタンス。
        public static SymbolicinkCreatorSingletonService _singleton = new SymbolicinkCreatorSingletonService();

        /// <summary>
        /// 単一のインスタンスを取得します。
        /// </summary>
        /// <returns>単一のインスタンスを返します。</returns>
        public static SymbolicinkCreatorSingletonService GetInstance()
        {
            return _singleton;
        }

        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        private SymbolicinkCreatorSingletonService()
        {
        }

        // 実行するコマンドのテンプレート。
        private static readonly string COMMAND_TMP = @"mklink /d  ""{0}"" ""{1}""";

        // バッチファイルのパス。
        private static readonly string BATCH_FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SymbolicinkCreate.bat");

        // バッチ処理成功時の終了コード。
        private static readonly int SUCCESS_RESULT = 0;

        // バッチ処理失敗時の終了コード。
        private static readonly int ERROR_RESULT = 1;

        /// <summary>
        /// シンボリックリンクを作成します。
        /// </summary>
        /// <param name="linkPath">リンク先のパス。</param>
        /// <param name="symboliclinkPath">作成するシンボリックリンクのパス。</param>
        /// <returns>作成の成否を返します。</returns>
        public bool CreateSymboliclink(string linkPath, string symboliclinkPath)
        {
            // バッチファイルのコマンドを取得します。
            var command = string.Format(COMMAND_TMP, symboliclinkPath, linkPath);

            // バッチファイルを作成し、作成出来ない場合は処理を終了します。
            if (!this.CreateFile(BATCH_FILE_PATH, command)) return false;

            // 終了コード取得用の変数。
            int processResult = ERROR_RESULT;

            try
            {
                // プロセスに渡す設定値クラスをインスタンス化します。
                var psi = new ProcessStartInfo();

                // バッチファイルのパスを設定します。
                psi.FileName = BATCH_FILE_PATH;

                // ウィンドウを非表示にします。
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;

                // プロセスをインスタンス化します。
                using (var p = Process.Start(psi))
                {
                    // プロセスの終了まで待機します。
                    p.WaitForExit();

                    // 終了コードを取得します。
                    processResult = p.ExitCode;

                    // プロセスを閉じます。
                    p.Close();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                // バッチファイルが存在する場合は削除します。
                if (File.Exists(BATCH_FILE_PATH))
                    this.ForceDelete(BATCH_FILE_PATH);
            }

            return SUCCESS_RESULT.Equals(processResult);
        }

        /// <summary>
        /// 対象の文字列に特定の文字が含まれているかを判定します。
        /// </summary>
        /// <param name="str">対象の文字列。</param>
        /// <param name="chars">特定の文字群。</param>
        /// <returns>判定値を返します。</returns>
        public bool ContainChars(string str, params char[] chars)
        {
            var result = false;

            // 文字群にて走査します。
            foreach (var c in chars)
            {
                // 文字が含まれているかを判定します。
                result = str.Contains(c.ToString());
                if (result) return result;
            }

            return false;
        }

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        /// <param name="filePath">作成するファイルのパス。</param>
        /// <param name="textString">出力するファイルのテキスト。</param>
        /// <returns>作成の成否を返します。</returns>
        private bool CreateFile(string filePath, string textString)
        {
            // ファイルを作成します。
            return this.CreateFile(filePath, textString, Encoding.GetEncoding("shift_jis"));
        }

        /// <summary>
        /// ファイルを作成します。
        /// </summary>
        /// <param name="filePath">作成するファイルのパス。</param>
        /// <param name="textString">出力するファイルのテキスト。</param>
        /// <param name="enc">出力するファイルのエンコード。</param>
        /// <returns>作成の成否を返します。</returns>
        private bool CreateFile(string filePath, string textString, Encoding enc)
        {
            try
            {
                // ストリームライターをインスタンス化します。
                using (var sw = new StreamWriter(filePath, false, enc))
                {
                    // ファイルを出力します。
                    sw.WriteLine(textString);
                    sw.Close();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// ファイルを削除します。
        /// </summary>
        /// <param name="filePath">削除するファイルのパス。</param>
        private void ForceDelete(string filePath)
        {
            // ファイル情報クラスをインスタンス化します。
            var fi = new FileInfo(filePath);

            // ファイルが存在するかを判定します。
            if (fi.Exists)
            {
                // 読み取り専用属性がある場合は、読み取り専用属性を解除します。
                if ((fi.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    fi.Attributes = FileAttributes.Normal;
                }

                // ファイルを削除します。
                fi.Delete();
            }
        }
    }
}
