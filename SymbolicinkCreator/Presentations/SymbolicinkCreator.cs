using System;
using System.IO;
using System.Windows.Forms;
using NexFx.Controls;
using SymbolicinkCreator.Resources;
using SymbolicinkCreator.Services;

namespace SymbolicinkCreator.Presentations
{
    /// <summary>
    /// SymbolicinkCreatorの画面クラス。
    /// </summary>
    public partial class SymbolicinkCreator : ExForm
    {
        /// <summary>
        /// コンストラクタ定義。
        /// </summary>
        public SymbolicinkCreator()
        {
            // 初期設定を行います。
            InitializeComponent();
        }

        /// <summary>
        /// 画面読込時の処理を行います。
        /// </summary>
        private void SymbolicinkCreator_Load(object sender, EventArgs e)
        {
            // 初期化処理を行います。
            this.SymbolicinkCreator_Initialize();
        }

        /// <summary>
        /// 初期化処理を行います。
        /// </summary>
        private void SymbolicinkCreator_Initialize()
        {
            // 各コントローラを初期化します。
            this.txtLinkPath.Clear();
            this.txtCreate.Clear();
            this.txtName.Clear();

            // 初期フォーカスを設定します。
            this.btnLinkPath.Focus();
        }

        /// <summary>
        /// リンク先ボタン押下時の処理を行います。
        /// </summary>
        private void btnLinkPath_Click(object sender, EventArgs e)
        {
            // ディレクトリ選択ダイアログをインスタン化します。
            using (var ofd = new FolderBrowserDialog())
            {
                // ダイアログの結果を判定し、テキストボックスにパスを設定します。
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.txtLinkPath.Text = ofd.SelectedPath;
            }
        }

        /// <summary>
        /// 作成元ボタン押下時の処理を行います。
        /// </summary>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // ディレクトリ選択ダイアログをインスタン化します。
            using (var ofd = new FolderBrowserDialog())
            {
                // ダイアログの結果を判定し、テキストボックスにパスを設定します。
                if (ofd.ShowDialog() == DialogResult.OK)
                    this.txtCreate.Text = ofd.SelectedPath;
            }
        }

        /// <summary>
        /// 作成ボタン押下時の処理を行います。
        /// </summary>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            // リンク先ディレクトリが未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtLinkPath.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "リンク先");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // リンク先ディレクトリが存在するかを判定します。
            if (!Directory.Exists(this.txtLinkPath.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0002, "リンク先");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 作成元ディレクトリが未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtCreate.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "作成元");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 作成元ディレクトリが存在するかを判定します。
            if (!Directory.Exists(this.txtCreate.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0002, "作成元");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 名称が未入力かを判定します。
            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                // エラーメッセージを表示します。
                var message = string.Format(Messages.E0001, "名称");
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // サービスを取得します。
            var scss = SymbolicinkCreatorSingletonService.GetInstance();

            // 名称にファイル禁則文字が含まれているかを判定します。
            if (scss.ContainChars(this.txtName.Text, Path.GetInvalidFileNameChars()))
            {
                // エラーメッセージを表示します。
                MessageBox.Show(Messages.E0004, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 名称にパス禁則文字が含まれているかを判定します。
            if (scss.ContainChars(this.txtName.Text, Path.GetInvalidPathChars()))
            {
                // エラーメッセージを表示します。
                MessageBox.Show(Messages.E0004, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // シンボリックリンクのパスを取得します。
            var symboliclinkPath = Path.Combine(this.txtCreate.Text, this.txtName.Text);

            // 作成元にディレクトリまたはファイルが存在するかを判定します。
            if (Directory.Exists(symboliclinkPath) || File.Exists(symboliclinkPath))
            {
                // エラーメッセージを表示します。
                MessageBox.Show(Messages.E0003, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // シンボリックリンクを作成します。
            var result = scss.CreateSymboliclink(this.txtLinkPath.Text, symboliclinkPath);

            // シンボリックリンク作成の成否を判定します。
            if (result)
            { 
                // 完了メッセージを表示します。
                MessageBox.Show(Messages.N0001, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 初期化処理を行います。
                this.SymbolicinkCreator_Initialize();
            }
            else
            { 
                // エラーメッセージを表示します。
                MessageBox.Show(Messages.E0005, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
