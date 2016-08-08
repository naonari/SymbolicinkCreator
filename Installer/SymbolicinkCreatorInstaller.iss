; -- SymbolicinkCreatorInstaller.iss --
[Setup]
AppName=SymbolicinkCreator
AppId=Growup_Consultant/Software/SymbolicinkCreator
AppPublisher=Growup Consultant
AppCopyright=Growup Consultant
AppVerName=SymbolicinkCreator 1.0.0.0
AppVersion=1.0.0.0
ArchitecturesInstallIn64BitMode=x64
ArchitecturesAllowed=x64
DefaultDirName={pf}\SymbolicinkCreator
DefaultGroupName=SymbolicinkCreator
UninstallDisplayIcon={app}\SymbolicinkCreator.exe
ShowLanguageDialog=no
VersionInfoVersion=1.0.0.0
VersionInfoDescription=SymbolicinkCreatorセットアッププログラム

OutputBaseFilename=SymbolicinkCreatorInstaller
OutputDir="."
SetupIconFile="..\SymbolicinkCreator\SymbolicinkCreator.ico"

[Tasks]
Name: desktopicon; Description: "デスクトップにショートカットアイコンを作成する";

[Files]
Source: "..\SymbolicinkCreator\bin\Release\SymbolicinkCreator.exe";    DestDir: "{app}"; Flags: ignoreversion
Source: "..\SymbolicinkCreator\bin\Release\NexFx.dll";                 DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\SymbolicinkCreator";         Filename: "{app}\SymbolicinkCreator.exe"
Name: "{commondesktop}\SymbolicinkCreator"; Filename: "{app}\SymbolicinkCreator.exe"; WorkingDir: "{app}"; Tasks: desktopicon

[Languages]
Name: japanese; MessagesFile: compiler:Languages\Japanese.isl

