// Type: MTSP.OptionForm
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using CppImplementationDetails;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class OptionForm : Form
  {
    private Button buttonOK;
    private Button buttonApply;
    private Button buttonCancel;
    private OpenFileDialog openFileDialog1;
    private FolderBrowserDialog folderBrowserDialog1;
    private ColorDialog colorDialog1;
    private TabPage tabPageSound;
    private TabPage tabPagePath;
    private TextBox textBoxGameExe;
    private Button buttonReplayFolder;
    private Button buttonGameExe;
    private TextBox textBoxReplayFolder;
    private TextBox textBoxVSSound;
    private Button buttonNoticeSound;
    private Button buttonVSSound;
    private TextBox textBoxNoticeSound;
    private TabControl tabControlOption;
    private TabPage tabPageGame;
    private GroupBox groupBoxRun;
    private CheckBox checkBoxWindowSize;
    private CheckBox checkBoxHitJudge;
    private GroupBox groupBoxNet;
    private NumericUpDown numericUpDownMaxConnection;
    private Label label5;
    private GroupBox groupBoxView;
    private CheckBox checkBoxVersus;
    private CheckBox checkBoxName;
    private CheckBox checkBoxFramerate;
    private CheckBox checkBoxRand;
    private GroupBox groupBoxSetting;
    private NumericUpDown numericUpDownMaxStage;
    private Label labelMaxStage;
    private Label labelStageSelect;
    private NumericUpDown numericUpDownStageSelect;
    private CheckBox checkBoxDivide;
    private RadioButton radioButtonReplayVersion2;
    private RadioButton radioButtonReplayVersion1;
    private TabPage tabPageColor;
    private GroupBox groupBoxMessageColor;
    private Button buttonDebugMessage;
    private Button buttonErrorMessage;
    private Button buttonSystemMessage;
    private GroupBox groupBoxOthersColor;
    private Button buttonSecret;
    private Button buttonCommentBack;
    private Button buttonNoticeBack;
    private GroupBox groupBoxStateColor;
    private Button buttonWatchState;
    private Button buttonVSState;
    private Button buttonRestState;
    private GroupBox groupBoxNameColor;
    private Button buttonClientName;
    private Button buttonHostName;
    private Button buttonServerName;
    private GroupBox groupBoxNoticeSound;
    private GroupBox groupBoxVSSound;
    private GroupBox groupBoxEnterSound;
    private TextBox textBoxEnterSound;
    private Button buttonEnterSound;
    private GroupBox groupBoxReplayFolder;
    private GroupBox groupBoxGameExe;
    private GroupBox groupBoxSimulate;
    private NumericUpDown numericUpDownSimDelay;
    private Label labelSimDelay;
    private GroupBox groupBoxSave;
    private NumericUpDown numericUpDownRound;
    private Label labelRound;
    private Label labelTimer;
    private NumericUpDown numericUpDownTimer;
    private TabPage tabPageVolume;
    private GroupBox groupBoxSE;
    private Label labelSE;
    private TrackBar trackBarSE;
    private GroupBox groupBoxBGM;
    private Label labelBGM;
    private TrackBar trackBarBGM;
    private GroupBox groupBoxMidi;
    private Label labelMidi;
    private TrackBar trackBarMidi;
    private TabPage tabFiMOpts;
    private GroupBox groupBox1;
    private Label label4;
    private ComboBox comboBoxFaveIcon;
    private Label label6;
    private Button button1;
    private RadioButton radioButtonUseNoIcons;
    private RadioButton radioButtonUseTrampStamp;
    private RadioButton radioButtonUseNormalIcons;
    private TabPage Performance;
    private GroupBox groupBox3;
    private CheckBox checkBoxReduceGUIDrawingOnMatch;
    private GroupBox groupBox2;
    private Label label7;
    private Label label3;
    private Label label2;
    private ComboBox comboBoxGameThreadPriority;
    private Label label1;
    private GroupBox groupBox4;
    private Label label9;
    private NumericUpDown numericUpDownLagReductionMS;
    private CheckBox checkBoxLagReduction1;
    private Label label10;
    private NumericUpDown numericUpDownLagThreshold;
    private Button buttonFindGameIni;
    private CheckBox AltNetcodeCheckBox;
    private CheckBox CHK_ColorCodedChat;
    private Container components;
    protected unsafe HMIXER__* hMixer;
    protected uint MixerControlID;
    protected uint MixerVolumeMin;
    protected uint MixerVolumeMax;
    public bool GameExePathError;

    public OptionForm()
    {
      // ISSUE: fault handler
      try
      {
        this.InitializeComponent();
      }
      __fault
      {
        base.Dispose(true);
      }
    }

    private void OptionForm()
    {
      if (this.components == null)
        return;
      IDisposable disposable = (IDisposable) this.components;
      int num;
      if (disposable != null)
      {
        disposable.Dispose();
        num = 0;
      }
      else
        num = 0;
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (OptionForm));
      this.buttonOK = new Button();
      this.buttonApply = new Button();
      this.buttonCancel = new Button();
      this.openFileDialog1 = new OpenFileDialog();
      this.folderBrowserDialog1 = new FolderBrowserDialog();
      this.colorDialog1 = new ColorDialog();
      this.tabPageSound = new TabPage();
      this.groupBoxEnterSound = new GroupBox();
      this.textBoxEnterSound = new TextBox();
      this.buttonEnterSound = new Button();
      this.groupBoxNoticeSound = new GroupBox();
      this.textBoxNoticeSound = new TextBox();
      this.buttonNoticeSound = new Button();
      this.groupBoxVSSound = new GroupBox();
      this.textBoxVSSound = new TextBox();
      this.buttonVSSound = new Button();
      this.tabPagePath = new TabPage();
      this.groupBoxReplayFolder = new GroupBox();
      this.button1 = new Button();
      this.textBoxReplayFolder = new TextBox();
      this.buttonReplayFolder = new Button();
      this.checkBoxDivide = new CheckBox();
      this.groupBoxNet = new GroupBox();
      this.numericUpDownMaxConnection = new NumericUpDown();
      this.label5 = new Label();
      this.groupBoxGameExe = new GroupBox();
      this.buttonFindGameIni = new Button();
      this.textBoxGameExe = new TextBox();
      this.buttonGameExe = new Button();
      this.groupBoxSave = new GroupBox();
      this.radioButtonReplayVersion1 = new RadioButton();
      this.radioButtonReplayVersion2 = new RadioButton();
      this.tabControlOption = new TabControl();
      this.Performance = new TabPage();
      this.groupBox4 = new GroupBox();
      this.AltNetcodeCheckBox = new CheckBox();
      this.label10 = new Label();
      this.numericUpDownLagThreshold = new NumericUpDown();
      this.label9 = new Label();
      this.numericUpDownLagReductionMS = new NumericUpDown();
      this.checkBoxLagReduction1 = new CheckBox();
      this.groupBox3 = new GroupBox();
      this.checkBoxReduceGUIDrawingOnMatch = new CheckBox();
      this.groupBox2 = new GroupBox();
      this.label7 = new Label();
      this.label3 = new Label();
      this.label2 = new Label();
      this.comboBoxGameThreadPriority = new ComboBox();
      this.label1 = new Label();
      this.tabPageGame = new TabPage();
      this.groupBoxSimulate = new GroupBox();
      this.numericUpDownSimDelay = new NumericUpDown();
      this.labelSimDelay = new Label();
      this.groupBoxRun = new GroupBox();
      this.checkBoxWindowSize = new CheckBox();
      this.checkBoxHitJudge = new CheckBox();
      this.groupBoxView = new GroupBox();
      this.checkBoxVersus = new CheckBox();
      this.checkBoxName = new CheckBox();
      this.checkBoxFramerate = new CheckBox();
      this.checkBoxRand = new CheckBox();
      this.groupBoxSetting = new GroupBox();
      this.numericUpDownRound = new NumericUpDown();
      this.labelRound = new Label();
      this.labelTimer = new Label();
      this.numericUpDownTimer = new NumericUpDown();
      this.numericUpDownMaxStage = new NumericUpDown();
      this.labelMaxStage = new Label();
      this.labelStageSelect = new Label();
      this.numericUpDownStageSelect = new NumericUpDown();
      this.tabPageColor = new TabPage();
      this.groupBoxMessageColor = new GroupBox();
      this.buttonDebugMessage = new Button();
      this.buttonErrorMessage = new Button();
      this.buttonSystemMessage = new Button();
      this.groupBoxOthersColor = new GroupBox();
      this.buttonSecret = new Button();
      this.buttonCommentBack = new Button();
      this.buttonNoticeBack = new Button();
      this.groupBoxStateColor = new GroupBox();
      this.buttonWatchState = new Button();
      this.buttonVSState = new Button();
      this.buttonRestState = new Button();
      this.groupBoxNameColor = new GroupBox();
      this.buttonClientName = new Button();
      this.buttonHostName = new Button();
      this.buttonServerName = new Button();
      this.tabPageVolume = new TabPage();
      this.groupBoxMidi = new GroupBox();
      this.labelMidi = new Label();
      this.trackBarMidi = new TrackBar();
      this.groupBoxSE = new GroupBox();
      this.labelSE = new Label();
      this.trackBarSE = new TrackBar();
      this.groupBoxBGM = new GroupBox();
      this.labelBGM = new Label();
      this.trackBarBGM = new TrackBar();
      this.tabFiMOpts = new TabPage();
      this.groupBox1 = new GroupBox();
      this.CHK_ColorCodedChat = new CheckBox();
      this.radioButtonUseNoIcons = new RadioButton();
      this.radioButtonUseTrampStamp = new RadioButton();
      this.radioButtonUseNormalIcons = new RadioButton();
      this.label6 = new Label();
      this.label4 = new Label();
      this.comboBoxFaveIcon = new ComboBox();
      this.tabPageSound.SuspendLayout();
      this.groupBoxEnterSound.SuspendLayout();
      this.groupBoxNoticeSound.SuspendLayout();
      this.groupBoxVSSound.SuspendLayout();
      this.tabPagePath.SuspendLayout();
      this.groupBoxReplayFolder.SuspendLayout();
      this.groupBoxNet.SuspendLayout();
      this.numericUpDownMaxConnection.BeginInit();
      this.groupBoxGameExe.SuspendLayout();
      this.groupBoxSave.SuspendLayout();
      this.tabControlOption.SuspendLayout();
      this.Performance.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.numericUpDownLagThreshold.BeginInit();
      this.numericUpDownLagReductionMS.BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.tabPageGame.SuspendLayout();
      this.groupBoxSimulate.SuspendLayout();
      this.numericUpDownSimDelay.BeginInit();
      this.groupBoxRun.SuspendLayout();
      this.groupBoxView.SuspendLayout();
      this.groupBoxSetting.SuspendLayout();
      this.numericUpDownRound.BeginInit();
      this.numericUpDownTimer.BeginInit();
      this.numericUpDownMaxStage.BeginInit();
      this.numericUpDownStageSelect.BeginInit();
      this.tabPageColor.SuspendLayout();
      this.groupBoxMessageColor.SuspendLayout();
      this.groupBoxOthersColor.SuspendLayout();
      this.groupBoxStateColor.SuspendLayout();
      this.groupBoxNameColor.SuspendLayout();
      this.tabPageVolume.SuspendLayout();
      this.groupBoxMidi.SuspendLayout();
      this.trackBarMidi.BeginInit();
      this.groupBoxSE.SuspendLayout();
      this.trackBarSE.BeginInit();
      this.groupBoxBGM.SuspendLayout();
      this.trackBarBGM.BeginInit();
      this.tabFiMOpts.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.buttonOK.Location = new Point(152, 295);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new Size(64, 26);
      this.buttonOK.TabIndex = 7;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
      this.buttonApply.Location = new Point(224, 295);
      this.buttonApply.Name = "buttonApply";
      this.buttonApply.Size = new Size(64, 26);
      this.buttonApply.TabIndex = 8;
      this.buttonApply.Text = "Apply";
      this.buttonApply.UseVisualStyleBackColor = true;
      this.buttonApply.Click += new EventHandler(this.buttonApply_Click);
      this.buttonCancel.Location = new Point(296, 295);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new Size(64, 26);
      this.buttonCancel.TabIndex = 9;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
      this.openFileDialog1.FileOk += new CancelEventHandler(this.openFileDialog1_FileOk);
      this.folderBrowserDialog1.Description = "リプレイ保存フォルダ";
      this.folderBrowserDialog1.HelpRequest += new EventHandler(this.folderBrowserDialog1_HelpRequest);
      this.colorDialog1.FullOpen = true;
      this.tabPageSound.Controls.Add((Control) this.groupBoxEnterSound);
      this.tabPageSound.Controls.Add((Control) this.groupBoxNoticeSound);
      this.tabPageSound.Controls.Add((Control) this.groupBoxVSSound);
      this.tabPageSound.Location = new Point(4, 22);
      this.tabPageSound.Name = "tabPageSound";
      this.tabPageSound.Padding = new Padding(3);
      this.tabPageSound.Size = new Size(369, 264);
      this.tabPageSound.TabIndex = 3;
      this.tabPageSound.Text = "Sounds";
      this.tabPageSound.UseVisualStyleBackColor = true;
      this.groupBoxEnterSound.Controls.Add((Control) this.textBoxEnterSound);
      this.groupBoxEnterSound.Controls.Add((Control) this.buttonEnterSound);
      this.groupBoxEnterSound.Location = new Point(8, 139);
      this.groupBoxEnterSound.Name = "groupBoxEnterSound";
      this.groupBoxEnterSound.Size = new Size(352, 56);
      this.groupBoxEnterSound.TabIndex = 3;
      this.groupBoxEnterSound.TabStop = false;
      this.groupBoxEnterSound.Text = "Room entry notification sound";
      this.textBoxEnterSound.AllowDrop = true;
      this.textBoxEnterSound.Location = new Point(16, 22);
      this.textBoxEnterSound.Name = "textBoxEnterSound";
      this.textBoxEnterSound.Size = new Size(304, 20);
      this.textBoxEnterSound.TabIndex = 1;
      this.textBoxEnterSound.TextChanged += new EventHandler(this.ApplyButtonEnable);
      this.textBoxEnterSound.DragDrop += new DragEventHandler(this.textBoxEnterSound_DragDrop);
      this.textBoxEnterSound.DragEnter += new DragEventHandler(this.textBoxSound_DragEnter);
      this.buttonEnterSound.Location = new Point(320, 22);
      this.buttonEnterSound.Name = "buttonEnterSound";
      this.buttonEnterSound.Size = new Size(24, 22);
      this.buttonEnterSound.TabIndex = 2;
      this.buttonEnterSound.Text = "...";
      this.buttonEnterSound.UseVisualStyleBackColor = true;
      this.buttonEnterSound.Click += new EventHandler(this.buttonEnterSound_Click);
      this.groupBoxNoticeSound.Controls.Add((Control) this.textBoxNoticeSound);
      this.groupBoxNoticeSound.Controls.Add((Control) this.buttonNoticeSound);
      this.groupBoxNoticeSound.Location = new Point(8, 74);
      this.groupBoxNoticeSound.Name = "groupBoxNoticeSound";
      this.groupBoxNoticeSound.Size = new Size(352, 56);
      this.groupBoxNoticeSound.TabIndex = 2;
      this.groupBoxNoticeSound.TabStop = false;
      this.groupBoxNoticeSound.Text = "Chat notification sound";
      this.textBoxNoticeSound.AllowDrop = true;
      this.textBoxNoticeSound.Location = new Point(16, 22);
      this.textBoxNoticeSound.Name = "textBoxNoticeSound";
      this.textBoxNoticeSound.Size = new Size(304, 20);
      this.textBoxNoticeSound.TabIndex = 1;
      this.textBoxNoticeSound.TextChanged += new EventHandler(this.ApplyButtonEnable);
      this.textBoxNoticeSound.DragDrop += new DragEventHandler(this.textBoxNoticeSound_DragDrop);
      this.textBoxNoticeSound.DragEnter += new DragEventHandler(this.textBoxSound_DragEnter);
      this.buttonNoticeSound.Location = new Point(320, 22);
      this.buttonNoticeSound.Name = "buttonNoticeSound";
      this.buttonNoticeSound.Size = new Size(24, 22);
      this.buttonNoticeSound.TabIndex = 2;
      this.buttonNoticeSound.Text = "...";
      this.buttonNoticeSound.UseVisualStyleBackColor = true;
      this.buttonNoticeSound.Click += new EventHandler(this.buttonNoticeSound_Click);
      this.groupBoxVSSound.Controls.Add((Control) this.textBoxVSSound);
      this.groupBoxVSSound.Controls.Add((Control) this.buttonVSSound);
      this.groupBoxVSSound.Location = new Point(8, 9);
      this.groupBoxVSSound.Name = "groupBoxVSSound";
      this.groupBoxVSSound.Size = new Size(352, 56);
      this.groupBoxVSSound.TabIndex = 1;
      this.groupBoxVSSound.TabStop = false;
      this.groupBoxVSSound.Text = "Challenge notification sound";
      this.textBoxVSSound.AllowDrop = true;
      this.textBoxVSSound.Location = new Point(16, 22);
      this.textBoxVSSound.Name = "textBoxVSSound";
      this.textBoxVSSound.Size = new Size(304, 20);
      this.textBoxVSSound.TabIndex = 1;
      this.textBoxVSSound.TextChanged += new EventHandler(this.ApplyButtonEnable);
      this.textBoxVSSound.DragDrop += new DragEventHandler(this.textBoxVSSound_DragDrop);
      this.textBoxVSSound.DragEnter += new DragEventHandler(this.textBoxSound_DragEnter);
      this.buttonVSSound.Location = new Point(320, 22);
      this.buttonVSSound.Name = "buttonVSSound";
      this.buttonVSSound.Size = new Size(24, 22);
      this.buttonVSSound.TabIndex = 2;
      this.buttonVSSound.Text = "...";
      this.buttonVSSound.UseVisualStyleBackColor = true;
      this.buttonVSSound.Click += new EventHandler(this.buttonVSSound_Click);
      this.tabPagePath.Controls.Add((Control) this.groupBoxReplayFolder);
      this.tabPagePath.Controls.Add((Control) this.groupBoxNet);
      this.tabPagePath.Controls.Add((Control) this.groupBoxGameExe);
      this.tabPagePath.Location = new Point(4, 22);
      this.tabPagePath.Name = "tabPagePath";
      this.tabPagePath.Padding = new Padding(3);
      this.tabPagePath.Size = new Size(369, 264);
      this.tabPagePath.TabIndex = 0;
      this.tabPagePath.Text = "General";
      this.tabPagePath.UseVisualStyleBackColor = true;
      this.groupBoxReplayFolder.Controls.Add((Control) this.button1);
      this.groupBoxReplayFolder.Controls.Add((Control) this.textBoxReplayFolder);
      this.groupBoxReplayFolder.Controls.Add((Control) this.buttonReplayFolder);
      this.groupBoxReplayFolder.Controls.Add((Control) this.checkBoxDivide);
      this.groupBoxReplayFolder.Location = new Point(8, 116);
      this.groupBoxReplayFolder.Name = "groupBoxReplayFolder";
      this.groupBoxReplayFolder.Size = new Size(352, 87);
      this.groupBoxReplayFolder.TabIndex = 2;
      this.groupBoxReplayFolder.TabStop = false;
      this.groupBoxReplayFolder.Text = "Replay folder path";
      this.button1.Enabled = false;
      this.button1.Location = new Point(231, 52);
      this.button1.Name = "button1";
      this.button1.Size = new Size(105, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Replay manager";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Visible = false;
      this.button1.Click += new EventHandler(this.buttonReplayManager_OnClick);
      this.textBoxReplayFolder.AllowDrop = true;
      this.textBoxReplayFolder.Location = new Point(16, 22);
      this.textBoxReplayFolder.Name = "textBoxReplayFolder";
      this.textBoxReplayFolder.Size = new Size(304, 20);
      this.textBoxReplayFolder.TabIndex = 1;
      this.textBoxReplayFolder.TextChanged += new EventHandler(this.ApplyButtonEnable);
      this.textBoxReplayFolder.DragDrop += new DragEventHandler(this.textBoxReplayFolder_DragDrop);
      this.textBoxReplayFolder.DragEnter += new DragEventHandler(this.textBoxReplayFolder_DragEnter);
      this.buttonReplayFolder.Location = new Point(321, 21);
      this.buttonReplayFolder.Name = "buttonReplayFolder";
      this.buttonReplayFolder.Size = new Size(24, 22);
      this.buttonReplayFolder.TabIndex = 2;
      this.buttonReplayFolder.Text = "...";
      this.buttonReplayFolder.UseVisualStyleBackColor = true;
      this.buttonReplayFolder.Click += new EventHandler(this.buttonReplayFolder_Click);
      this.checkBoxDivide.AutoSize = true;
      this.checkBoxDivide.Location = new Point(16, 56);
      this.checkBoxDivide.Name = "checkBoxDivide";
      this.checkBoxDivide.Size = new Size(155, 17);
      this.checkBoxDivide.TabIndex = 3;
      this.checkBoxDivide.Text = "Categorize replays by game";
      this.checkBoxDivide.UseVisualStyleBackColor = true;
      this.checkBoxDivide.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.groupBoxNet.Controls.Add((Control) this.numericUpDownMaxConnection);
      this.groupBoxNet.Controls.Add((Control) this.label5);
      this.groupBoxNet.Location = new Point(8, 209);
      this.groupBoxNet.Name = "groupBoxNet";
      this.groupBoxNet.Size = new Size(352, 49);
      this.groupBoxNet.TabIndex = 3;
      this.groupBoxNet.TabStop = false;
      this.groupBoxNet.Text = "Program settings";
      this.numericUpDownMaxConnection.Location = new Point(146, 21);
      this.numericUpDownMaxConnection.Maximum = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      this.numericUpDownMaxConnection.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDownMaxConnection.Name = "numericUpDownMaxConnection";
      this.numericUpDownMaxConnection.Size = new Size(46, 20);
      this.numericUpDownMaxConnection.TabIndex = 1;
      this.numericUpDownMaxConnection.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDownMaxConnection.ValueChanged += new EventHandler(this.ApplyButtonEnable);
      this.label5.AutoSize = true;
      this.label5.Location = new Point(6, 23);
      this.label5.Name = "label5";
      this.label5.Size = new Size(134, 13);
      this.label5.TabIndex = 0;
      this.label5.Text = "Maximum # of connections";
      this.groupBoxGameExe.Controls.Add((Control) this.buttonFindGameIni);
      this.groupBoxGameExe.Controls.Add((Control) this.textBoxGameExe);
      this.groupBoxGameExe.Controls.Add((Control) this.buttonGameExe);
      this.groupBoxGameExe.Location = new Point(8, 9);
      this.groupBoxGameExe.Name = "groupBoxGameExe";
      this.groupBoxGameExe.Size = new Size(352, 101);
      this.groupBoxGameExe.TabIndex = 1;
      this.groupBoxGameExe.TabStop = false;
      this.groupBoxGameExe.Text = "File path";
      this.groupBoxGameExe.Enter += new EventHandler(this.groupBoxGameExe_Enter);
      this.buttonFindGameIni.Location = new Point(16, 48);
      this.buttonFindGameIni.Name = "buttonFindGameIni";
      this.buttonFindGameIni.Size = new Size(105, 23);
      this.buttonFindGameIni.TabIndex = 3;
      this.buttonFindGameIni.Text = "Edit game.ini";
      this.buttonFindGameIni.UseVisualStyleBackColor = true;
      this.buttonFindGameIni.Click += new EventHandler(this.FindGameIni_OnClick);
      this.textBoxGameExe.AllowDrop = true;
      this.textBoxGameExe.Location = new Point(16, 22);
      this.textBoxGameExe.Name = "textBoxGameExe";
      this.textBoxGameExe.Size = new Size(304, 20);
      this.textBoxGameExe.TabIndex = 1;
      this.textBoxGameExe.TextChanged += new EventHandler(this.ApplyButtonEnable);
      this.textBoxGameExe.DragDrop += new DragEventHandler(this.textBoxGameExe_DragDrop);
      this.textBoxGameExe.DragEnter += new DragEventHandler(this.textBoxGameExe_DragEnter);
      this.buttonGameExe.Location = new Point(321, 21);
      this.buttonGameExe.Name = "buttonGameExe";
      this.buttonGameExe.Size = new Size(24, 22);
      this.buttonGameExe.TabIndex = 2;
      this.buttonGameExe.Text = "...";
      this.buttonGameExe.UseVisualStyleBackColor = true;
      this.buttonGameExe.Click += new EventHandler(this.buttonGameExe_Click);
      this.groupBoxSave.Controls.Add((Control) this.radioButtonReplayVersion1);
      this.groupBoxSave.Controls.Add((Control) this.radioButtonReplayVersion2);
      this.groupBoxSave.Location = new Point(192, 195);
      this.groupBoxSave.Name = "groupBoxSave";
      this.groupBoxSave.Size = new Size(168, 60);
      this.groupBoxSave.TabIndex = 4;
      this.groupBoxSave.TabStop = false;
      this.groupBoxSave.Text = "Replay compression";
      this.radioButtonReplayVersion1.AutoSize = true;
      this.radioButtonReplayVersion1.Location = new Point(11, 37);
      this.radioButtonReplayVersion1.Name = "radioButtonReplayVersion1";
      this.radioButtonReplayVersion1.Size = new Size(115, 17);
      this.radioButtonReplayVersion1.TabIndex = 2;
      this.radioButtonReplayVersion1.TabStop = true;
      this.radioButtonReplayVersion1.Text = "Off (recommended)";
      this.radioButtonReplayVersion1.UseVisualStyleBackColor = true;
      this.radioButtonReplayVersion1.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.radioButtonReplayVersion2.AutoSize = true;
      this.radioButtonReplayVersion2.Location = new Point(11, 16);
      this.radioButtonReplayVersion2.Name = "radioButtonReplayVersion2";
      this.radioButtonReplayVersion2.Size = new Size(39, 17);
      this.radioButtonReplayVersion2.TabIndex = 2;
      this.radioButtonReplayVersion2.TabStop = true;
      this.radioButtonReplayVersion2.Text = "On";
      this.radioButtonReplayVersion2.UseVisualStyleBackColor = true;
      this.radioButtonReplayVersion2.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.tabControlOption.Controls.Add((Control) this.tabPagePath);
      this.tabControlOption.Controls.Add((Control) this.Performance);
      this.tabControlOption.Controls.Add((Control) this.tabPageSound);
      this.tabControlOption.Controls.Add((Control) this.tabPageGame);
      this.tabControlOption.Controls.Add((Control) this.tabPageColor);
      this.tabControlOption.Controls.Add((Control) this.tabPageVolume);
      this.tabControlOption.Controls.Add((Control) this.tabFiMOpts);
      this.tabControlOption.Dock = DockStyle.Top;
      this.tabControlOption.Location = new Point(0, 0);
      this.tabControlOption.Name = "tabControlOption";
      this.tabControlOption.SelectedIndex = 0;
      this.tabControlOption.Size = new Size(377, 290);
      this.tabControlOption.TabIndex = 0;
      this.Performance.Controls.Add((Control) this.groupBox4);
      this.Performance.Controls.Add((Control) this.groupBox3);
      this.Performance.Controls.Add((Control) this.groupBox2);
      this.Performance.Location = new Point(4, 22);
      this.Performance.Name = "Performance";
      this.Performance.Size = new Size(369, 264);
      this.Performance.TabIndex = 8;
      this.Performance.Text = "Performance";
      this.Performance.UseVisualStyleBackColor = true;
      this.groupBox4.Controls.Add((Control) this.AltNetcodeCheckBox);
      this.groupBox4.Controls.Add((Control) this.label10);
      this.groupBox4.Controls.Add((Control) this.numericUpDownLagThreshold);
      this.groupBox4.Controls.Add((Control) this.label9);
      this.groupBox4.Controls.Add((Control) this.numericUpDownLagReductionMS);
      this.groupBox4.Controls.Add((Control) this.checkBoxLagReduction1);
      this.groupBox4.Location = new Point(9, 158);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(347, 76);
      this.groupBox4.TabIndex = 6;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Advanced";
      this.AltNetcodeCheckBox.AutoSize = true;
      this.AltNetcodeCheckBox.Location = new Point(9, 46);
      this.AltNetcodeCheckBox.Name = "AltNetcodeCheckBox";
      this.AltNetcodeCheckBox.Size = new Size(260, 17);
      this.AltNetcodeCheckBox.TabIndex = 5;
      this.AltNetcodeCheckBox.Text = "Faster input polling + netcode hack (experimental)";
      this.AltNetcodeCheckBox.UseVisualStyleBackColor = true;
      this.AltNetcodeCheckBox.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.label10.AutoSize = true;
      this.label10.Location = new Point(220, 21);
      this.label10.Name = "label10";
      this.label10.Size = new Size(73, 13);
      this.label10.TabIndex = 4;
      this.label10.Text = "FPS threshold";
      this.numericUpDownLagThreshold.Location = new Point(294, 18);
      this.numericUpDownLagThreshold.Maximum = new Decimal(new int[4]
      {
        90,
        0,
        0,
        0
      });
      this.numericUpDownLagThreshold.Name = "numericUpDownLagThreshold";
      this.numericUpDownLagThreshold.Size = new Size(35, 20);
      this.numericUpDownLagThreshold.TabIndex = 3;
      this.numericUpDownLagThreshold.Value = new Decimal(new int[4]
      {
        78,
        0,
        0,
        0
      });
      this.numericUpDownLagThreshold.ValueChanged += new EventHandler(this.ApplyButtonEnable);
      this.label9.AutoSize = true;
      this.label9.Location = new Point(121, 21);
      this.label9.Name = "label9";
      this.label9.Size = new Size(50, 13);
      this.label9.TabIndex = 2;
      this.label9.Text = "Sleep ms";
      this.numericUpDownLagReductionMS.Location = new Point(171, 18);
      this.numericUpDownLagReductionMS.Maximum = new Decimal(new int[4]
      {
        150,
        0,
        0,
        0
      });
      this.numericUpDownLagReductionMS.Name = "numericUpDownLagReductionMS";
      this.numericUpDownLagReductionMS.Size = new Size(41, 20);
      this.numericUpDownLagReductionMS.TabIndex = 1;
      this.numericUpDownLagReductionMS.Value = new Decimal(new int[4]
      {
        80,
        0,
        0,
        0
      });
      this.numericUpDownLagReductionMS.ValueChanged += new EventHandler(this.ApplyButtonEnable);
      this.checkBoxLagReduction1.AutoSize = true;
      this.checkBoxLagReduction1.Location = new Point(9, 20);
      this.checkBoxLagReduction1.Name = "checkBoxLagReduction1";
      this.checkBoxLagReduction1.Size = new Size(106, 17);
      this.checkBoxLagReduction1.TabIndex = 0;
      this.checkBoxLagReduction1.Text = "FPS stutter fix  ->";
      this.checkBoxLagReduction1.UseVisualStyleBackColor = true;
      this.checkBoxLagReduction1.CheckedChanged += new EventHandler(this.LagFix1CheckChange);
      this.groupBox3.Controls.Add((Control) this.checkBoxReduceGUIDrawingOnMatch);
      this.groupBox3.Location = new Point(9, 105);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(347, 46);
      this.groupBox3.TabIndex = 5;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "GUI";
      this.checkBoxReduceGUIDrawingOnMatch.AutoSize = true;
      this.checkBoxReduceGUIDrawingOnMatch.Location = new Point(9, 19);
      this.checkBoxReduceGUIDrawingOnMatch.Name = "checkBoxReduceGUIDrawingOnMatch";
      this.checkBoxReduceGUIDrawingOnMatch.Size = new Size(208, 17);
      this.checkBoxReduceGUIDrawingOnMatch.TabIndex = 4;
      this.checkBoxReduceGUIDrawingOnMatch.Text = "Reduce GUI drawing upon match start";
      this.checkBoxReduceGUIDrawingOnMatch.UseVisualStyleBackColor = true;
      this.checkBoxReduceGUIDrawingOnMatch.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.groupBox2.Controls.Add((Control) this.label7);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.label2);
      this.groupBox2.Controls.Add((Control) this.comboBoxGameThreadPriority);
      this.groupBox2.Controls.Add((Control) this.label1);
      this.groupBox2.Location = new Point(9, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(347, 95);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Game";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(9, 72);
      this.label7.Name = "label7";
      this.label7.Size = new Size(247, 13);
      this.label7.TabIndex = 5;
      this.label7.Text = "positive or negative impact on lag and frame drops.";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(9, 59);
      this.label3.Name = "label3";
      this.label3.Size = new Size(288, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Changing the game thread priority may have an unexpected";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(9, 46);
      this.label2.Name = "label2";
      this.label2.Size = new Size(302, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Telepone and the game program have a symbiotic relationship.";
      this.comboBoxGameThreadPriority.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxGameThreadPriority.FormattingEnabled = true;
      this.comboBoxGameThreadPriority.Items.AddRange(new object[3]
      {
        (object) "Normal",
        (object) "AboveNormal",
        (object) "High"
      });
      this.comboBoxGameThreadPriority.Location = new Point(113, 19);
      this.comboBoxGameThreadPriority.Name = "comboBoxGameThreadPriority";
      this.comboBoxGameThreadPriority.Size = new Size(117, 21);
      this.comboBoxGameThreadPriority.TabIndex = 2;
      this.comboBoxGameThreadPriority.SelectedIndexChanged += new EventHandler(this.ApplyButtonEnable);
      this.label1.AutoSize = true;
      this.label1.Location = new Point(6, 23);
      this.label1.Name = "label1";
      this.label1.Size = new Size(104, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Game thread priority:";
      this.tabPageGame.Controls.Add((Control) this.groupBoxSave);
      this.tabPageGame.Controls.Add((Control) this.groupBoxSimulate);
      this.tabPageGame.Controls.Add((Control) this.groupBoxRun);
      this.tabPageGame.Controls.Add((Control) this.groupBoxView);
      this.tabPageGame.Controls.Add((Control) this.groupBoxSetting);
      this.tabPageGame.Location = new Point(4, 22);
      this.tabPageGame.Name = "tabPageGame";
      this.tabPageGame.Padding = new Padding(3);
      this.tabPageGame.Size = new Size(369, 264);
      this.tabPageGame.TabIndex = 4;
      this.tabPageGame.Text = "Game";
      this.tabPageGame.UseVisualStyleBackColor = true;
      this.groupBoxSimulate.Controls.Add((Control) this.numericUpDownSimDelay);
      this.groupBoxSimulate.Controls.Add((Control) this.labelSimDelay);
      this.groupBoxSimulate.Location = new Point(192, 141);
      this.groupBoxSimulate.Name = "groupBoxSimulate";
      this.groupBoxSimulate.Size = new Size(168, 48);
      this.groupBoxSimulate.TabIndex = 5;
      this.groupBoxSimulate.TabStop = false;
      this.groupBoxSimulate.Text = "Single player simulated delay";
      this.numericUpDownSimDelay.Location = new Point(112, 19);
      this.numericUpDownSimDelay.Name = "numericUpDownSimDelay";
      this.numericUpDownSimDelay.Size = new Size(40, 20);
      this.numericUpDownSimDelay.TabIndex = 1;
      this.numericUpDownSimDelay.ValueChanged += new EventHandler(this.ApplyButtonEnable);
      this.labelSimDelay.AutoSize = true;
      this.labelSimDelay.Location = new Point(16, 21);
      this.labelSimDelay.Name = "labelSimDelay";
      this.labelSimDelay.Size = new Size(34, 13);
      this.labelSimDelay.TabIndex = 0;
      this.labelSimDelay.Text = "Delay";
      this.groupBoxRun.Controls.Add((Control) this.checkBoxWindowSize);
      this.groupBoxRun.Controls.Add((Control) this.checkBoxHitJudge);
      this.groupBoxRun.Location = new Point(8, 176);
      this.groupBoxRun.Name = "groupBoxRun";
      this.groupBoxRun.Size = new Size(168, 80);
      this.groupBoxRun.TabIndex = 3;
      this.groupBoxRun.TabStop = false;
      this.groupBoxRun.Text = "Other";
      this.checkBoxWindowSize.AutoSize = true;
      this.checkBoxWindowSize.Location = new Point(16, 48);
      this.checkBoxWindowSize.Name = "checkBoxWindowSize";
      this.checkBoxWindowSize.Size = new Size(110, 17);
      this.checkBoxWindowSize.TabIndex = 2;
      this.checkBoxWindowSize.Text = "Boot at 640 x 480";
      this.checkBoxWindowSize.UseVisualStyleBackColor = true;
      this.checkBoxWindowSize.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.checkBoxHitJudge.AutoSize = true;
      this.checkBoxHitJudge.Location = new Point(16, 22);
      this.checkBoxHitJudge.Name = "checkBoxHitJudge";
      this.checkBoxHitJudge.Size = new Size(124, 17);
      this.checkBoxHitJudge.TabIndex = 1;
      this.checkBoxHitJudge.Text = "Show hurt / hitboxes";
      this.checkBoxHitJudge.UseVisualStyleBackColor = true;
      this.checkBoxHitJudge.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.groupBoxView.Controls.Add((Control) this.checkBoxVersus);
      this.groupBoxView.Controls.Add((Control) this.checkBoxName);
      this.groupBoxView.Controls.Add((Control) this.checkBoxFramerate);
      this.groupBoxView.Controls.Add((Control) this.checkBoxRand);
      this.groupBoxView.Location = new Point(192, 9);
      this.groupBoxView.Name = "groupBoxView";
      this.groupBoxView.Size = new Size(168, 126);
      this.groupBoxView.TabIndex = 4;
      this.groupBoxView.TabStop = false;
      this.groupBoxView.Text = "Title bar";
      this.checkBoxVersus.AutoSize = true;
      this.checkBoxVersus.Location = new Point(16, 48);
      this.checkBoxVersus.Name = "checkBoxVersus";
      this.checkBoxVersus.Size = new Size(86, 17);
      this.checkBoxVersus.TabIndex = 2;
      this.checkBoxVersus.Text = "Match count";
      this.checkBoxVersus.UseVisualStyleBackColor = true;
      this.checkBoxVersus.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.checkBoxName.AutoSize = true;
      this.checkBoxName.Location = new Point(16, 22);
      this.checkBoxName.Name = "checkBoxName";
      this.checkBoxName.Size = new Size(89, 17);
      this.checkBoxName.TabIndex = 1;
      this.checkBoxName.Text = "Player names";
      this.checkBoxName.UseVisualStyleBackColor = true;
      this.checkBoxName.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.checkBoxFramerate.AutoSize = true;
      this.checkBoxFramerate.Location = new Point(16, 74);
      this.checkBoxFramerate.Name = "checkBoxFramerate";
      this.checkBoxFramerate.Size = new Size(46, 17);
      this.checkBoxFramerate.TabIndex = 3;
      this.checkBoxFramerate.Text = "FPS";
      this.checkBoxFramerate.UseVisualStyleBackColor = true;
      this.checkBoxFramerate.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.checkBoxRand.AutoSize = true;
      this.checkBoxRand.Location = new Point(16, 100);
      this.checkBoxRand.Name = "checkBoxRand";
      this.checkBoxRand.Size = new Size(139, 17);
      this.checkBoxRand.TabIndex = 4;
      this.checkBoxRand.Text = "Random number display";
      this.checkBoxRand.UseVisualStyleBackColor = true;
      this.checkBoxRand.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.groupBoxSetting.Controls.Add((Control) this.numericUpDownRound);
      this.groupBoxSetting.Controls.Add((Control) this.labelRound);
      this.groupBoxSetting.Controls.Add((Control) this.labelTimer);
      this.groupBoxSetting.Controls.Add((Control) this.numericUpDownTimer);
      this.groupBoxSetting.Controls.Add((Control) this.numericUpDownMaxStage);
      this.groupBoxSetting.Controls.Add((Control) this.labelMaxStage);
      this.groupBoxSetting.Controls.Add((Control) this.labelStageSelect);
      this.groupBoxSetting.Controls.Add((Control) this.numericUpDownStageSelect);
      this.groupBoxSetting.Location = new Point(8, 9);
      this.groupBoxSetting.Name = "groupBoxSetting";
      this.groupBoxSetting.Size = new Size(168, 139);
      this.groupBoxSetting.TabIndex = 1;
      this.groupBoxSetting.TabStop = false;
      this.groupBoxSetting.Text = "Battle settings";
      this.numericUpDownRound.Location = new Point(112, 79);
      this.numericUpDownRound.Maximum = new Decimal(new int[4]
      {
        9,
        0,
        0,
        0
      });
      this.numericUpDownRound.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDownRound.Name = "numericUpDownRound";
      this.numericUpDownRound.Size = new Size(40, 20);
      this.numericUpDownRound.TabIndex = 3;
      this.numericUpDownRound.Value = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.numericUpDownRound.ValueChanged += new EventHandler(this.ApplyButtonEnable);
      this.labelRound.AutoSize = true;
      this.labelRound.Location = new Point(16, 82);
      this.labelRound.Name = "labelRound";
      this.labelRound.Size = new Size(44, 13);
      this.labelRound.TabIndex = 0;
      this.labelRound.Text = "Rounds";
      this.labelTimer.AutoSize = true;
      this.labelTimer.Location = new Point(16, 113);
      this.labelTimer.Name = "labelTimer";
      this.labelTimer.Size = new Size(62, 13);
      this.labelTimer.TabIndex = 0;
      this.labelTimer.Text = "Match timer";
      this.numericUpDownTimer.Location = new Point(112, 109);
      this.numericUpDownTimer.Maximum = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.numericUpDownTimer.Name = "numericUpDownTimer";
      this.numericUpDownTimer.Size = new Size(40, 20);
      this.numericUpDownTimer.TabIndex = 4;
      this.numericUpDownTimer.Value = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.numericUpDownTimer.ValueChanged += new EventHandler(this.ApplyButtonEnable);
      this.numericUpDownMaxStage.Location = new Point(112, 18);
      this.numericUpDownMaxStage.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.numericUpDownMaxStage.Name = "numericUpDownMaxStage";
      this.numericUpDownMaxStage.Size = new Size(40, 20);
      this.numericUpDownMaxStage.TabIndex = 1;
      this.numericUpDownMaxStage.Value = new Decimal(new int[4]
      {
        4,
        0,
        0,
        0
      });
      this.numericUpDownMaxStage.ValueChanged += new EventHandler(this.numericUpDownStage_ValueChanged);
      this.labelMaxStage.AutoSize = true;
      this.labelMaxStage.Location = new Point(16, 22);
      this.labelMaxStage.Name = "labelMaxStage";
      this.labelMaxStage.Size = new Size(66, 13);
      this.labelMaxStage.TabIndex = 0;
      this.labelMaxStage.Text = "Max stage #";
      this.labelStageSelect.AutoSize = true;
      this.labelStageSelect.Location = new Point(16, 52);
      this.labelStageSelect.Name = "labelStageSelect";
      this.labelStageSelect.Size = new Size(35, 13);
      this.labelStageSelect.TabIndex = 0;
      this.labelStageSelect.Text = "Stage";
      this.numericUpDownStageSelect.Location = new Point(112, 49);
      this.numericUpDownStageSelect.Name = "numericUpDownStageSelect";
      this.numericUpDownStageSelect.Size = new Size(40, 20);
      this.numericUpDownStageSelect.TabIndex = 2;
      this.numericUpDownStageSelect.ValueChanged += new EventHandler(this.numericUpDownStage_ValueChanged);
      this.tabPageColor.Controls.Add((Control) this.groupBoxMessageColor);
      this.tabPageColor.Controls.Add((Control) this.groupBoxOthersColor);
      this.tabPageColor.Controls.Add((Control) this.groupBoxStateColor);
      this.tabPageColor.Controls.Add((Control) this.groupBoxNameColor);
      this.tabPageColor.Location = new Point(4, 22);
      this.tabPageColor.Name = "tabPageColor";
      this.tabPageColor.Padding = new Padding(3);
      this.tabPageColor.Size = new Size(369, 264);
      this.tabPageColor.TabIndex = 5;
      this.tabPageColor.Text = "Color";
      this.tabPageColor.UseVisualStyleBackColor = true;
      this.groupBoxMessageColor.Controls.Add((Control) this.buttonDebugMessage);
      this.groupBoxMessageColor.Controls.Add((Control) this.buttonErrorMessage);
      this.groupBoxMessageColor.Controls.Add((Control) this.buttonSystemMessage);
      this.groupBoxMessageColor.Location = new Point(192, 9);
      this.groupBoxMessageColor.Name = "groupBoxMessageColor";
      this.groupBoxMessageColor.Size = new Size(168, 117);
      this.groupBoxMessageColor.TabIndex = 3;
      this.groupBoxMessageColor.TabStop = false;
      this.groupBoxMessageColor.Text = "Messages";
      this.buttonDebugMessage.BackColor = SystemColors.Window;
      this.buttonDebugMessage.Location = new Point(16, 82);
      this.buttonDebugMessage.Name = "buttonDebugMessage";
      this.buttonDebugMessage.Size = new Size(136, 22);
      this.buttonDebugMessage.TabIndex = 3;
      this.buttonDebugMessage.Text = "Debug";
      this.buttonDebugMessage.UseVisualStyleBackColor = false;
      this.buttonDebugMessage.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonDebugMessage.Click += new EventHandler(this.buttonDebugMessage_Click);
      this.buttonErrorMessage.BackColor = SystemColors.Window;
      this.buttonErrorMessage.Location = new Point(16, 52);
      this.buttonErrorMessage.Name = "buttonErrorMessage";
      this.buttonErrorMessage.Size = new Size(136, 22);
      this.buttonErrorMessage.TabIndex = 2;
      this.buttonErrorMessage.Text = "Error";
      this.buttonErrorMessage.UseVisualStyleBackColor = false;
      this.buttonErrorMessage.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonErrorMessage.Click += new EventHandler(this.buttonErrorMessage_Click);
      this.buttonSystemMessage.BackColor = SystemColors.Window;
      this.buttonSystemMessage.Location = new Point(16, 22);
      this.buttonSystemMessage.Name = "buttonSystemMessage";
      this.buttonSystemMessage.Size = new Size(136, 22);
      this.buttonSystemMessage.TabIndex = 1;
      this.buttonSystemMessage.Text = "System";
      this.buttonSystemMessage.UseVisualStyleBackColor = false;
      this.buttonSystemMessage.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonSystemMessage.Click += new EventHandler(this.buttonSystemMessage_Click);
      this.groupBoxOthersColor.Controls.Add((Control) this.buttonSecret);
      this.groupBoxOthersColor.Controls.Add((Control) this.buttonCommentBack);
      this.groupBoxOthersColor.Controls.Add((Control) this.buttonNoticeBack);
      this.groupBoxOthersColor.Location = new Point(192, 139);
      this.groupBoxOthersColor.Name = "groupBoxOthersColor";
      this.groupBoxOthersColor.Size = new Size(168, 117);
      this.groupBoxOthersColor.TabIndex = 4;
      this.groupBoxOthersColor.TabStop = false;
      this.groupBoxOthersColor.Text = "Other";
      this.buttonSecret.BackColor = SystemColors.Window;
      this.buttonSecret.Location = new Point(16, 82);
      this.buttonSecret.Name = "buttonSecret";
      this.buttonSecret.Size = new Size(136, 22);
      this.buttonSecret.TabIndex = 3;
      this.buttonSecret.Text = "???";
      this.buttonSecret.UseVisualStyleBackColor = false;
      this.buttonSecret.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonSecret.Click += new EventHandler(this.buttonSecret_Click);
      this.buttonCommentBack.ForeColor = SystemColors.WindowText;
      this.buttonCommentBack.Location = new Point(16, 52);
      this.buttonCommentBack.Name = "buttonCommentBack";
      this.buttonCommentBack.Size = new Size(136, 22);
      this.buttonCommentBack.TabIndex = 2;
      this.buttonCommentBack.Text = "Comment background";
      this.buttonCommentBack.UseVisualStyleBackColor = false;
      this.buttonCommentBack.BackColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonCommentBack.Click += new EventHandler(this.buttonCommentBack_Click);
      this.buttonNoticeBack.ForeColor = SystemColors.WindowText;
      this.buttonNoticeBack.Location = new Point(16, 22);
      this.buttonNoticeBack.Name = "buttonNoticeBack";
      this.buttonNoticeBack.Size = new Size(136, 22);
      this.buttonNoticeBack.TabIndex = 1;
      this.buttonNoticeBack.Text = "Notification background";
      this.buttonNoticeBack.UseVisualStyleBackColor = false;
      this.buttonNoticeBack.BackColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonNoticeBack.Click += new EventHandler(this.buttonNoticeBack_Click);
      this.groupBoxStateColor.Controls.Add((Control) this.buttonWatchState);
      this.groupBoxStateColor.Controls.Add((Control) this.buttonVSState);
      this.groupBoxStateColor.Controls.Add((Control) this.buttonRestState);
      this.groupBoxStateColor.Location = new Point(8, 139);
      this.groupBoxStateColor.Name = "groupBoxStateColor";
      this.groupBoxStateColor.Size = new Size(168, 117);
      this.groupBoxStateColor.TabIndex = 2;
      this.groupBoxStateColor.TabStop = false;
      this.groupBoxStateColor.Text = "Status";
      this.buttonWatchState.ForeColor = SystemColors.WindowText;
      this.buttonWatchState.Location = new Point(16, 82);
      this.buttonWatchState.Name = "buttonWatchState";
      this.buttonWatchState.Size = new Size(136, 22);
      this.buttonWatchState.TabIndex = 3;
      this.buttonWatchState.Text = "Spectating";
      this.buttonWatchState.UseVisualStyleBackColor = false;
      this.buttonWatchState.BackColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonWatchState.Click += new EventHandler(this.buttonWatchState_Click);
      this.buttonVSState.ForeColor = SystemColors.WindowText;
      this.buttonVSState.Location = new Point(16, 52);
      this.buttonVSState.Name = "buttonVSState";
      this.buttonVSState.Size = new Size(136, 22);
      this.buttonVSState.TabIndex = 2;
      this.buttonVSState.Text = "Fighting";
      this.buttonVSState.UseVisualStyleBackColor = false;
      this.buttonVSState.BackColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonVSState.Click += new EventHandler(this.buttonVSState_Click);
      this.buttonRestState.ForeColor = SystemColors.WindowText;
      this.buttonRestState.Location = new Point(16, 22);
      this.buttonRestState.Name = "buttonRestState";
      this.buttonRestState.Size = new Size(136, 22);
      this.buttonRestState.TabIndex = 1;
      this.buttonRestState.Text = "Resting";
      this.buttonRestState.UseVisualStyleBackColor = false;
      this.buttonRestState.BackColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonRestState.Click += new EventHandler(this.buttonRestState_Click);
      this.groupBoxNameColor.Controls.Add((Control) this.buttonClientName);
      this.groupBoxNameColor.Controls.Add((Control) this.buttonHostName);
      this.groupBoxNameColor.Controls.Add((Control) this.buttonServerName);
      this.groupBoxNameColor.Location = new Point(8, 9);
      this.groupBoxNameColor.Name = "groupBoxNameColor";
      this.groupBoxNameColor.Size = new Size(168, 117);
      this.groupBoxNameColor.TabIndex = 1;
      this.groupBoxNameColor.TabStop = false;
      this.groupBoxNameColor.Text = "Name";
      this.buttonClientName.BackColor = SystemColors.Window;
      this.buttonClientName.Location = new Point(16, 82);
      this.buttonClientName.Name = "buttonClientName";
      this.buttonClientName.Size = new Size(136, 22);
      this.buttonClientName.TabIndex = 3;
      this.buttonClientName.Text = "Client";
      this.buttonClientName.UseVisualStyleBackColor = false;
      this.buttonClientName.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonClientName.Click += new EventHandler(this.buttonClientName_Click);
      this.buttonHostName.BackColor = SystemColors.Window;
      this.buttonHostName.Location = new Point(16, 52);
      this.buttonHostName.Name = "buttonHostName";
      this.buttonHostName.Size = new Size(136, 22);
      this.buttonHostName.TabIndex = 2;
      this.buttonHostName.Text = "Host";
      this.buttonHostName.UseVisualStyleBackColor = false;
      this.buttonHostName.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonHostName.Click += new EventHandler(this.buttonHostName_Click);
      this.buttonServerName.BackColor = SystemColors.Window;
      this.buttonServerName.Location = new Point(16, 22);
      this.buttonServerName.Name = "buttonServerName";
      this.buttonServerName.Size = new Size(136, 22);
      this.buttonServerName.TabIndex = 1;
      this.buttonServerName.Text = "Server";
      this.buttonServerName.UseVisualStyleBackColor = false;
      this.buttonServerName.ForeColorChanged += new EventHandler(this.ApplyButtonEnable);
      this.buttonServerName.Click += new EventHandler(this.buttonServerName_Click);
      this.tabPageVolume.Controls.Add((Control) this.groupBoxMidi);
      this.tabPageVolume.Controls.Add((Control) this.groupBoxSE);
      this.tabPageVolume.Controls.Add((Control) this.groupBoxBGM);
      this.tabPageVolume.Location = new Point(4, 22);
      this.tabPageVolume.Name = "tabPageVolume";
      this.tabPageVolume.Padding = new Padding(3);
      this.tabPageVolume.Size = new Size(369, 264);
      this.tabPageVolume.TabIndex = 6;
      this.tabPageVolume.Text = "Volume";
      this.tabPageVolume.UseVisualStyleBackColor = true;
      this.groupBoxMidi.Controls.Add((Control) this.labelMidi);
      this.groupBoxMidi.Controls.Add((Control) this.trackBarMidi);
      this.groupBoxMidi.Location = new Point(8, 199);
      this.groupBoxMidi.Name = "groupBoxMidi";
      this.groupBoxMidi.Size = new Size(352, 56);
      this.groupBoxMidi.TabIndex = 3;
      this.groupBoxMidi.TabStop = false;
      this.groupBoxMidi.Text = "Software synthesizer (Midi)";
      this.labelMidi.AutoSize = true;
      this.labelMidi.Location = new Point(8, 26);
      this.labelMidi.Name = "labelMidi";
      this.labelMidi.Size = new Size(33, 13);
      this.labelMidi.TabIndex = 0;
      this.labelMidi.Text = "100%";
      this.trackBarMidi.AutoSize = false;
      this.trackBarMidi.LargeChange = 10;
      this.trackBarMidi.Location = new Point(48, 13);
      this.trackBarMidi.Maximum = 100;
      this.trackBarMidi.Name = "trackBarMidi";
      this.trackBarMidi.Size = new Size(296, 35);
      this.trackBarMidi.TabIndex = 1;
      this.trackBarMidi.TickFrequency = 10;
      this.trackBarMidi.TickStyle = TickStyle.TopLeft;
      this.trackBarMidi.Scroll += new EventHandler(this.trackBarMidi_Scroll);
      this.groupBoxSE.Controls.Add((Control) this.labelSE);
      this.groupBoxSE.Controls.Add((Control) this.trackBarSE);
      this.groupBoxSE.Location = new Point(8, 74);
      this.groupBoxSE.Name = "groupBoxSE";
      this.groupBoxSE.Size = new Size(352, 56);
      this.groupBoxSE.TabIndex = 2;
      this.groupBoxSE.TabStop = false;
      this.groupBoxSE.Text = "Sound effects";
      this.labelSE.AutoSize = true;
      this.labelSE.Location = new Point(8, 26);
      this.labelSE.Name = "labelSE";
      this.labelSE.Size = new Size(33, 13);
      this.labelSE.TabIndex = 0;
      this.labelSE.Text = "100%";
      this.trackBarSE.AutoSize = false;
      this.trackBarSE.LargeChange = 2;
      this.trackBarSE.Location = new Point(48, 13);
      this.trackBarSE.Maximum = 20;
      this.trackBarSE.Name = "trackBarSE";
      this.trackBarSE.Size = new Size(296, 35);
      this.trackBarSE.TabIndex = 1;
      this.trackBarSE.TickFrequency = 2;
      this.trackBarSE.TickStyle = TickStyle.TopLeft;
      this.trackBarSE.Scroll += new EventHandler(this.trackBarSE_Scroll);
      this.groupBoxBGM.Controls.Add((Control) this.labelBGM);
      this.groupBoxBGM.Controls.Add((Control) this.trackBarBGM);
      this.groupBoxBGM.Location = new Point(8, 9);
      this.groupBoxBGM.Name = "groupBoxBGM";
      this.groupBoxBGM.Size = new Size(352, 56);
      this.groupBoxBGM.TabIndex = 1;
      this.groupBoxBGM.TabStop = false;
      this.groupBoxBGM.Text = "Music";
      this.labelBGM.AutoSize = true;
      this.labelBGM.Location = new Point(8, 26);
      this.labelBGM.Name = "labelBGM";
      this.labelBGM.Size = new Size(33, 13);
      this.labelBGM.TabIndex = 0;
      this.labelBGM.Text = "100%";
      this.trackBarBGM.AutoSize = false;
      this.trackBarBGM.LargeChange = 2;
      this.trackBarBGM.Location = new Point(48, 13);
      this.trackBarBGM.Maximum = 20;
      this.trackBarBGM.Name = "trackBarBGM";
      this.trackBarBGM.Size = new Size(296, 35);
      this.trackBarBGM.TabIndex = 1;
      this.trackBarBGM.TickFrequency = 2;
      this.trackBarBGM.TickStyle = TickStyle.TopLeft;
      this.trackBarBGM.Scroll += new EventHandler(this.trackBarBGM_Scroll);
      this.tabFiMOpts.Controls.Add((Control) this.groupBox1);
      this.tabFiMOpts.ForeColor = SystemColors.ControlText;
      this.tabFiMOpts.Location = new Point(4, 22);
      this.tabFiMOpts.Name = "tabFiMOpts";
      this.tabFiMOpts.Size = new Size(369, 264);
      this.tabFiMOpts.TabIndex = 7;
      this.tabFiMOpts.Text = "FiM";
      this.tabFiMOpts.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.CHK_ColorCodedChat);
      this.groupBox1.Controls.Add((Control) this.radioButtonUseNoIcons);
      this.groupBox1.Controls.Add((Control) this.radioButtonUseTrampStamp);
      this.groupBox1.Controls.Add((Control) this.radioButtonUseNormalIcons);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.comboBoxFaveIcon);
      this.groupBox1.Location = new Point(12, 8);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(344, 126);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Icons";
      this.CHK_ColorCodedChat.AutoSize = true;
      this.CHK_ColorCodedChat.Location = new Point(7, 94);
      this.CHK_ColorCodedChat.Name = "CHK_ColorCodedChat";
      this.CHK_ColorCodedChat.Size = new Size(107, 17);
      this.CHK_ColorCodedChat.TabIndex = 10;
      this.CHK_ColorCodedChat.Text = "Color coded chat";
      this.CHK_ColorCodedChat.UseVisualStyleBackColor = true;
      this.CHK_ColorCodedChat.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.radioButtonUseNoIcons.AutoSize = true;
      this.radioButtonUseNoIcons.Location = new Point(7, 64);
      this.radioButtonUseNoIcons.Name = "radioButtonUseNoIcons";
      this.radioButtonUseNoIcons.Size = new Size(67, 17);
      this.radioButtonUseNoIcons.TabIndex = 9;
      this.radioButtonUseNoIcons.Text = "No icons";
      this.radioButtonUseNoIcons.UseVisualStyleBackColor = true;
      this.radioButtonUseNoIcons.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.radioButtonUseTrampStamp.AutoSize = true;
      this.radioButtonUseTrampStamp.Location = new Point(7, 41);
      this.radioButtonUseTrampStamp.Name = "radioButtonUseTrampStamp";
      this.radioButtonUseTrampStamp.Size = new Size(111, 17);
      this.radioButtonUseTrampStamp.TabIndex = 8;
      this.radioButtonUseTrampStamp.Text = "Use alternate icon";
      this.radioButtonUseTrampStamp.UseVisualStyleBackColor = true;
      this.radioButtonUseTrampStamp.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.radioButtonUseNormalIcons.AutoSize = true;
      this.radioButtonUseNormalIcons.Checked = true;
      this.radioButtonUseNormalIcons.Location = new Point(7, 18);
      this.radioButtonUseNormalIcons.Name = "radioButtonUseNormalIcons";
      this.radioButtonUseNormalIcons.Size = new Size(106, 17);
      this.radioButtonUseNormalIcons.TabIndex = 7;
      this.radioButtonUseNormalIcons.TabStop = true;
      this.radioButtonUseNormalIcons.Text = "Use normal icons";
      this.radioButtonUseNormalIcons.UseVisualStyleBackColor = true;
      this.radioButtonUseNormalIcons.CheckedChanged += new EventHandler(this.ApplyButtonEnable);
      this.label6.AutoSize = true;
      this.label6.Location = new Point(216, 41);
      this.label6.Name = "label6";
      this.label6.Size = new Size(101, 13);
      this.label6.TabIndex = 6;
      this.label6.Text = "(requires reconnect)";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(177, 21);
      this.label4.Name = "label4";
      this.label4.Size = new Size(31, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Icon:";
      this.comboBoxFaveIcon.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxFaveIcon.FormattingEnabled = true;
      this.comboBoxFaveIcon.Items.AddRange(new object[7]
      {
        (object) "No icon",
        (object) "Applejack",
        (object) "Pinkie Pie",
        (object) "Rarity",
        (object) "Twilight Sparkle",
        (object) "Fluttershy",
        (object) "Rainbow Dash"
      });
      this.comboBoxFaveIcon.Location = new Point(208, 17);
      this.comboBoxFaveIcon.Name = "comboBoxFaveIcon";
      this.comboBoxFaveIcon.Size = new Size(121, 21);
      this.comboBoxFaveIcon.TabIndex = 4;
      this.comboBoxFaveIcon.SelectionChangeCommitted += new EventHandler(this.ApplyButtonEnable);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(377, 326);
      this.Controls.Add((Control) this.tabControlOption);
      this.Controls.Add((Control) this.buttonApply);
      this.Controls.Add((Control) this.buttonCancel);
      this.Controls.Add((Control) this.buttonOK);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionForm";
      this.ShowInTaskbar = false;
      this.Text = "Option";
      OptionForm optionForm1 = this;
      // ISSUE: method pointer
      IntPtr method1 = __methodptr(OptionForm_FormClosed);
      FormClosedEventHandler closedEventHandler = new FormClosedEventHandler((object) optionForm1, method1);
      optionForm1.FormClosed += closedEventHandler;
      OptionForm optionForm2 = this;
      // ISSUE: method pointer
      IntPtr method2 = __methodptr(OptionForm_Load);
      EventHandler eventHandler1 = new EventHandler((object) optionForm2, method2);
      optionForm2.Load += eventHandler1;
      OptionForm optionForm3 = this;
      // ISSUE: method pointer
      IntPtr method3 = __methodptr(OptionForm_Shown);
      EventHandler eventHandler2 = new EventHandler((object) optionForm3, method3);
      optionForm3.Shown += eventHandler2;
      this.tabPageSound.ResumeLayout(false);
      this.groupBoxEnterSound.ResumeLayout(false);
      this.groupBoxEnterSound.PerformLayout();
      this.groupBoxNoticeSound.ResumeLayout(false);
      this.groupBoxNoticeSound.PerformLayout();
      this.groupBoxVSSound.ResumeLayout(false);
      this.groupBoxVSSound.PerformLayout();
      this.tabPagePath.ResumeLayout(false);
      this.groupBoxReplayFolder.ResumeLayout(false);
      this.groupBoxReplayFolder.PerformLayout();
      this.groupBoxNet.ResumeLayout(false);
      this.groupBoxNet.PerformLayout();
      this.numericUpDownMaxConnection.EndInit();
      this.groupBoxGameExe.ResumeLayout(false);
      this.groupBoxGameExe.PerformLayout();
      this.groupBoxSave.ResumeLayout(false);
      this.groupBoxSave.PerformLayout();
      this.tabControlOption.ResumeLayout(false);
      this.Performance.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.numericUpDownLagThreshold.EndInit();
      this.numericUpDownLagReductionMS.EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.tabPageGame.ResumeLayout(false);
      this.groupBoxSimulate.ResumeLayout(false);
      this.groupBoxSimulate.PerformLayout();
      this.numericUpDownSimDelay.EndInit();
      this.groupBoxRun.ResumeLayout(false);
      this.groupBoxRun.PerformLayout();
      this.groupBoxView.ResumeLayout(false);
      this.groupBoxView.PerformLayout();
      this.groupBoxSetting.ResumeLayout(false);
      this.groupBoxSetting.PerformLayout();
      this.numericUpDownRound.EndInit();
      this.numericUpDownTimer.EndInit();
      this.numericUpDownMaxStage.EndInit();
      this.numericUpDownStageSelect.EndInit();
      this.tabPageColor.ResumeLayout(false);
      this.groupBoxMessageColor.ResumeLayout(false);
      this.groupBoxOthersColor.ResumeLayout(false);
      this.groupBoxStateColor.ResumeLayout(false);
      this.groupBoxNameColor.ResumeLayout(false);
      this.tabPageVolume.ResumeLayout(false);
      this.groupBoxMidi.ResumeLayout(false);
      this.groupBoxMidi.PerformLayout();
      this.trackBarMidi.EndInit();
      this.groupBoxSE.ResumeLayout(false);
      this.groupBoxSE.PerformLayout();
      this.trackBarSE.EndInit();
      this.groupBoxBGM.ResumeLayout(false);
      this.groupBoxBGM.PerformLayout();
      this.trackBarBGM.EndInit();
      this.tabFiMOpts.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
    }

    protected void AdviceGameExe()
    {
      this.textBoxGameExe.Text = "Click the button at the right and select path to game file";
      this.textBoxGameExe.Focus();
    }

    protected void CheckStageValue()
    {
      if (this.numericUpDownStageSelect.Value > this.numericUpDownMaxStage.Value)
      {
        this.labelMaxStage.Text = "First stage";
        this.labelStageSelect.Text = "Last stage";
      }
      else
      {
        this.labelMaxStage.Text = "Max stage #";
        this.labelStageSelect.Text = "Battle stage";
      }
      if (!(this.numericUpDownStageSelect.Value == (Decimal) 0))
        return;
      this.labelStageSelect.Text = "Random stage";
    }

    protected unsafe void SaveOption([MarshalAs(UnmanagedType.U1)] bool apply)
    {
      MainForm mainForm = (MainForm) this.Owner;
      try
      {
        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.textBoxGameExe.Text);
        if (versionInfo.FileDescription != "２Ｄ格闘ツク\x30FCル2nd.")
        {
          if (versionInfo.FileDescription != "２Ｄ格闘ツク\x30FCル９５")
            throw new Exception();
        }
      }
      catch (Exception ex)
      {
        this.textBoxGameExe.Text = "Not a valid FM2K game executable";
      }
      IntPtr num1 = new IntPtr();
      IntPtr hglobal1 = Marshal.StringToHGlobalAuto(this.textBoxGameExe.Text);
      Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) (&Module.MTOPTION + 844)), (char*) hglobal1.ToPointer());
      Marshal.FreeHGlobal(hglobal1);
      IntPtr hglobal2 = Marshal.StringToHGlobalAuto(this.textBoxReplayFolder.Text);
      Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) (&Module.MTOPTION + 1364)), (char*) hglobal2.ToPointer());
      Marshal.FreeHGlobal(hglobal2);
      IntPtr hglobal3 = Marshal.StringToHGlobalAuto(this.textBoxVSSound.Text);
      Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) (&Module.MTOPTION + 1884)), (char*) hglobal3.ToPointer());
      Marshal.FreeHGlobal(hglobal3);
      hglobal3 = Marshal.StringToHGlobalAuto(this.textBoxNoticeSound.Text);
      Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) (&Module.MTOPTION + 2404)), (char*) hglobal3.ToPointer());
      Marshal.FreeHGlobal(hglobal3);
      hglobal3 = Marshal.StringToHGlobalAuto(this.textBoxEnterSound.Text);
      Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) (&Module.MTOPTION + 2924)), (char*) hglobal3.ToPointer());
      Marshal.FreeHGlobal(hglobal3);
      Decimal num2 = this.numericUpDownMaxStage.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3980)) = (int) (uint) num2;
      Decimal num3 = this.numericUpDownStageSelect.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3984)) = (int) (uint) num3;
      Decimal num4 = this.numericUpDownRound.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3988)) = (int) (uint) num4;
      Decimal num5 = this.numericUpDownTimer.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3992)) = (int) (uint) num5;
      Decimal num6 = this.numericUpDownSimDelay.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3996)) = (int) (uint) num6;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4001)) = (sbyte) this.checkBoxName.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4002)) = (sbyte) this.checkBoxVersus.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4003)) = (sbyte) this.checkBoxFramerate.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4004)) = (sbyte) this.checkBoxRand.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4005)) = (sbyte) this.checkBoxDivide.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4006)) = (sbyte) this.checkBoxWindowSize.Checked;
      Decimal num7 = this.numericUpDownMaxConnection.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3968)) = (int) (uint) num7;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3972)) = this.trackBarBGM.Value * 5;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 3976)) = this.trackBarSE.Value * 5;
      if (this.radioButtonReplayVersion2.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4020)) = 2;
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4020)) = 1;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4076)) = this.comboBoxFaveIcon.SelectedIndex;
      if (this.radioButtonUseNormalIcons.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4080)) = 0;
      }
      else if (this.radioButtonUseTrampStamp.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4080)) = 1;
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4080)) = 2;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4036)) = (sbyte) this.checkBoxReduceGUIDrawingOnMatch.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4038)) = (sbyte) this.checkBoxLagReduction1.Checked;
      Decimal num8 = this.numericUpDownLagReductionMS.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4060)) = (int) (uint) num8;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) (&Module.MTOPTION + 4046)) = (sbyte) this.CHK_ColorCodedChat.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) (&Module.MTINFO + 28)) == 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4043)) = (sbyte) this.AltNetcodeCheckBox.Checked;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((int)  ((IntPtr) (&Module.MTOPTION + 4000)) != (this.checkBoxHitJudge.Checked ? 1 : 0))
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) (&Module.MTOPTION + 4000)) = (sbyte) this.checkBoxHitJudge.Checked;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  ((IntPtr) (&Module.MTINFO + 2)) != 0 &&  ((IntPtr) (&Module.MTINFO + 28)) != 0)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          uint num9 = (uint)  ((IntPtr) (&Module.MTOPTION + 4000));
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((int)  ((IntPtr) (&Module.MTINFO + 4)) != 0)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            Module.WriteProcessMemory(  ((IntPtr) (&Module.MTINFO + 28)),  4343564,  &num9, 4U, (uint*) 0);
          }
          else
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            Module.WriteProcessMemory(  ((IntPtr) (&Module.MTINFO + 28)),  4400960,  &num9, 4U, (uint*) 0);
          }
        }
      }
      Color foreColor1 = this.buttonServerName.ForeColor;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       @Module.MTCOLOR = foreColor1.ToArgb();
      Color foreColor2 = this.buttonHostName.ForeColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 4) = foreColor2.ToArgb();
      Color foreColor3 = this.buttonClientName.ForeColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 8) = foreColor3.ToArgb();
      Color backColor1 = this.buttonRestState.BackColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 12) = backColor1.ToArgb();
      Color backColor2 = this.buttonVSState.BackColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 16) = backColor2.ToArgb();
      Color backColor3 = this.buttonWatchState.BackColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 20) = backColor3.ToArgb();
      Color foreColor4 = this.buttonSystemMessage.ForeColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 24) = foreColor4.ToArgb();
      Color foreColor5 = this.buttonErrorMessage.ForeColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 28) = foreColor5.ToArgb();
      Color foreColor6 = this.buttonDebugMessage.ForeColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 32) = foreColor6.ToArgb();
      Color backColor4 = this.buttonNoticeBack.BackColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 36) = backColor4.ToArgb();
      Color backColor5 = this.buttonCommentBack.BackColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 40) = backColor5.ToArgb();
      Color foreColor7 = this.buttonSecret.ForeColor;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTCOLOR + 44) = foreColor7.ToArgb();
      mainForm.ResetColor();
      Module.CheckMTOption();
      if (apply)
      {
        this.textBoxGameExe.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 844));
        this.textBoxReplayFolder.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 1364));
        this.textBoxVSSound.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 1884));
        this.textBoxNoticeSound.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 2404));
        this.textBoxEnterSound.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 2924));
      }
      Module.SaveMTOption();
    }

    public void SetGameExePath(ref string path)
    {
      this.textBoxGameExe.Text = path;
    }

    private unsafe void OptionForm_Load(object sender, EventArgs e)
    {
      this.textBoxGameExe.MaxLength = 260;
      this.textBoxReplayFolder.MaxLength = 260;
      this.textBoxVSSound.MaxLength = 260;
      this.textBoxNoticeSound.MaxLength = 260;
      this.textBoxEnterSound.MaxLength = 260;
      this.textBoxGameExe.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 844));
      this.textBoxReplayFolder.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 1364));
      this.textBoxVSSound.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 1884));
      this.textBoxNoticeSound.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 2404));
      this.textBoxEnterSound.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 2924));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownMaxConnection.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3968));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.trackBarBGM.Value = (int) ((uint)  ((IntPtr) &Module.MTOPTION + 3972) / 5U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.trackBarSE.Value = (int) ((uint)  ((IntPtr) &Module.MTOPTION + 3976) / 5U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownMaxStage.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3980));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownStageSelect.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3984));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownRound.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3988));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownTimer.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3992));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownSimDelay.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3996));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxHitJudge.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4000);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxName.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4001);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxVersus.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4002);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxFramerate.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4003);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxRand.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4004);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxDivide.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4005);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxWindowSize.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4006);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.comboBoxGameThreadPriority.SelectedIndex =  ((IntPtr) &Module.MTOPTION + 4056);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxReduceGUIDrawingOnMatch.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4036);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxLagReduction1.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4038);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownLagReductionMS.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 4060));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownLagThreshold.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 4064));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.AltNetcodeCheckBox.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4043);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.CHK_ColorCodedChat.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4046);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.comboBoxFaveIcon.SelectedIndex =  ((IntPtr) &Module.MTOPTION + 4076);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 4080) == 0)
      {
        this.radioButtonUseTrampStamp.Checked = false;
        this.radioButtonUseNoIcons.Checked = false;
        this.radioButtonUseNormalIcons.Checked = true;
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 4080) == 1)
        {
          this.radioButtonUseNormalIcons.Checked = false;
          this.radioButtonUseNoIcons.Checked = false;
          this.radioButtonUseTrampStamp.Checked = true;
        }
        else
        {
          this.radioButtonUseNormalIcons.Checked = false;
          this.radioButtonUseTrampStamp.Checked = false;
          this.radioButtonUseNoIcons.Checked = true;
        }
      }
      this.CheckStageValue();
      this.labelBGM.Text = string.Format("{0,3}%", (object) (this.trackBarBGM.Value * 5));
      this.labelSE.Text = string.Format("{0,3}%", (object) (this.trackBarSE.Value * 5));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 4020) == 2)
      {
        this.radioButtonReplayVersion1.Checked = false;
        this.radioButtonReplayVersion2.Checked = true;
      }
      else
      {
        this.radioButtonReplayVersion1.Checked = true;
        this.radioButtonReplayVersion2.Checked = false;
      }
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonServerName.ForeColor = Color.FromArgb( @Module.MTCOLOR);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonHostName.ForeColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 4));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonClientName.ForeColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 8));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonRestState.BackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 12));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonVSState.BackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 16));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonWatchState.BackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 20));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonSystemMessage.ForeColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 24));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonErrorMessage.ForeColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 28));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonDebugMessage.ForeColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 32));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonNoticeBack.BackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 36));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonCommentBack.BackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 40));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.buttonSecret.ForeColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 44));
      try
      {
        this.hMixer = (HMIXER__*) 0;
        fixed (HMIXER__** hmixerPtr = &this.hMixer)
        {
          // ISSUE: variable of a reference type
          HMIXER__*& local;
          // ISSUE: fault handler
          try
          {
            if ((int) Module.mixerOpen(hmixerPtr, 0U, 0U, 0U, 0U) != 0)
              throw new Exception();
            tagMIXERLINEW tagMixerlinew;
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             @tagMixerlinew = 280;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &tagMixerlinew + 24) = 4100;
            if ((int) Module.mixerGetLineInfoW((HMIXEROBJ__*) this.hMixer, &tagMixerlinew, 2147483651U) != 0)
              throw new Exception();
            tagMIXERLINECONTROLSW mixerlinecontrolsw;
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             @mixerlinecontrolsw = 24;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixerlinecontrolsw + 4) =  ((IntPtr) &tagMixerlinew + 12);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixerlinecontrolsw + 8) = 1342373889;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixerlinecontrolsw + 12) = 1;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixerlinecontrolsw + 16) = 228;
            tagMIXERCONTROLW tagMixercontrolw;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixerlinecontrolsw + 20) = (int) &tagMixercontrolw;
            if ((int) Module.mixerGetLineControlsW((HMIXEROBJ__*) this.hMixer, &mixerlinecontrolsw, 2147483650U) != 0)
              throw new Exception();
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            this.MixerControlID = (uint)  ((IntPtr) &tagMixercontrolw + 4);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            this.MixerVolumeMin = (uint)  ((IntPtr) &tagMixercontrolw + 180);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            this.MixerVolumeMax = (uint)  ((IntPtr) &tagMixercontrolw + 184);
            tMIXERCONTROLDETAILS mixercontroldetails;
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             @mixercontroldetails = 24;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixercontroldetails + 4) =  ((IntPtr) &tagMixercontrolw + 4);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixercontroldetails + 8) = 1;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixercontroldetails + 12) = 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixercontroldetails + 16) = 4;
            tMIXERCONTROLDETAILS_UNSIGNED mixercontroldetailsUnsigned;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &mixercontroldetails + 20) = (int) &mixercontroldetailsUnsigned;
            if ((int) Module.mixerGetControlDetailsW((HMIXEROBJ__*) this.hMixer, &mixercontroldetails, (uint) int.MinValue) != 0)
              throw new Exception();
            uint num = this.MixerVolumeMax - this.MixerVolumeMin;
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            this.trackBarMidi.Value = (int) (((uint) (( @mixercontroldetailsUnsigned - (int) this.MixerVolumeMin) * 100) + num / 2U) / num);
            this.labelMidi.Text = string.Format("{0,3}%", (object) this.trackBarMidi.Value);
          }
          __fault
          {
            // ISSUE: cast to a reference type
            local = 0;
          }
          // ISSUE: cast to a reference type
          local = 0;
        }
      }
      catch (Exception ex)
      {
        if ((IntPtr) this.hMixer != IntPtr.Zero)
        {
          int num = (int) Module.mixerClose(this.hMixer);
          this.hMixer = (HMIXER__*) 0;
        }
        this.labelMidi.Text = "xxx";
        this.groupBoxMidi.Enabled = false;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTWS + 20) > 0 &&  ((IntPtr) &Module.MTWS + 24) > 0)
      {
        this.StartPosition = FormStartPosition.Manual;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.Location = new Point( ((IntPtr) &Module.MTWS + 20),  ((IntPtr) &Module.MTWS + 24));
      }
      this.buttonApply.Enabled = false;
      if (0 == 0)
        return;
      this.tabControlOption.Controls.Remove((Control) this.tabFiMOpts);
    }

    private void OptionForm_Shown(object sender, EventArgs e)
    {
      if (!this.GameExePathError)
        return;
      this.AdviceGameExe();
    }

    private unsafe void OptionForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      if ((IntPtr) this.hMixer != IntPtr.Zero)
      {
        int num = (int) Module.mixerClose(this.hMixer);
        this.hMixer = (HMIXER__*) 0;
      }
      Point location1 = this.Location;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTWS + 20) = location1.X;
      Point location2 = this.Location;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTWS + 24) = location2.Y;
      this.Owner.Focus();
    }

    private void buttonOK_Click(object sender, EventArgs e)
    {
      if (this.buttonApply.Enabled)
      {
        this.buttonApply.Enabled = false;
        this.SaveOption(false);
      }
      this.Close();
    }

    private void buttonApply_Click(object sender, EventArgs e)
    {
      this.buttonApply.Enabled = false;
      this.SaveOption(true);
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void buttonGameExe_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.Title = "FM2K game file";
      this.openFileDialog1.Filter = "exe file (*.exe)|*.exe";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.openFileDialog1.FileName);
      if (versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル2nd." || versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル９５")
      {
        this.textBoxGameExe.Text = this.openFileDialog1.FileName;
      }
      else
      {
        this.textBoxGameExe.Text = "Not a valid FM2K game file";
        this.textBoxGameExe.SelectAll();
        this.textBoxGameExe.Focus();
      }
    }

    private void buttonReplayFolder_Click(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBoxReplayFolder.Text = this.folderBrowserDialog1.SelectedPath;
    }

    private void buttonVSSound_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.Title = "Challenge notification sound file";
      this.openFileDialog1.Filter = "wav file (*.wav)|*.wav";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBoxVSSound.Text = this.openFileDialog1.FileName;
    }

    private void buttonNoticeSound_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.Title = "Chat notification sound file";
      this.openFileDialog1.Filter = "wav file (*.wav)|*.wav";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBoxNoticeSound.Text = this.openFileDialog1.FileName;
    }

    private void buttonEnterSound_Click(object sender, EventArgs e)
    {
      this.openFileDialog1.Title = "Room entry notification sound file";
      this.openFileDialog1.Filter = "wav file (*.wav)|*.wav";
      if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBoxEnterSound.Text = this.openFileDialog1.FileName;
    }

    private void ApplyButtonEnable(object sender, EventArgs e)
    {
      this.buttonApply.Enabled = true;
    }

    private void numericUpDownStage_ValueChanged(object sender, EventArgs e)
    {
      this.buttonApply.Enabled = true;
      this.CheckStageValue();
    }

    private void buttonServerName_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonServerName.ForeColor = this.colorDialog1.Color;
    }

    private void buttonHostName_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonHostName.ForeColor = this.colorDialog1.Color;
    }

    private void buttonClientName_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonClientName.ForeColor = this.colorDialog1.Color;
    }

    private void buttonRestState_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonRestState.BackColor = this.colorDialog1.Color;
    }

    private void buttonVSState_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonVSState.BackColor = this.colorDialog1.Color;
    }

    private void buttonWatchState_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonWatchState.BackColor = this.colorDialog1.Color;
    }

    private void buttonSystemMessage_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonSystemMessage.ForeColor = this.colorDialog1.Color;
    }

    private void buttonErrorMessage_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonErrorMessage.ForeColor = this.colorDialog1.Color;
    }

    private void buttonDebugMessage_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonDebugMessage.ForeColor = this.colorDialog1.Color;
    }

    private void buttonNoticeBack_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonNoticeBack.BackColor = this.colorDialog1.Color;
    }

    private void buttonCommentBack_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonCommentBack.BackColor = this.colorDialog1.Color;
    }

    private void buttonSecret_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.buttonSecret.ForeColor = this.colorDialog1.Color;
    }

    private void trackBarBGM_Scroll(object sender, EventArgs e)
    {
      this.buttonApply.Enabled = true;
      this.labelBGM.Text = string.Format("{0,3}%", (object) (this.trackBarBGM.Value * 5));
    }

    private void trackBarSE_Scroll(object sender, EventArgs e)
    {
      this.buttonApply.Enabled = true;
      this.labelSE.Text = string.Format("{0,3}%", (object) (this.trackBarSE.Value * 5));
    }

    private unsafe void trackBarMidi_Scroll(object sender, EventArgs e)
    {
      this.labelMidi.Text = string.Format("{0,3}%", (object) this.trackBarMidi.Value);
      tMIXERCONTROLDETAILS_UNSIGNED mixercontroldetailsUnsigned;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       @mixercontroldetailsUnsigned = (int) ((uint) (this.trackBarMidi.Value * ((int) this.MixerVolumeMax - (int) this.MixerVolumeMin)) / 100U) + (int) this.MixerVolumeMin;
      tMIXERCONTROLDETAILS mixercontroldetails;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       @mixercontroldetails = 24;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &mixercontroldetails + 4) = (int) this.MixerControlID;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &mixercontroldetails + 8) = 1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &mixercontroldetails + 12) = 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &mixercontroldetails + 16) = 4;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &mixercontroldetails + 20) = (int) &mixercontroldetailsUnsigned;
      if ((int) Module.mixerSetControlDetails((HMIXEROBJ__*) this.hMixer, &mixercontroldetails, (uint) int.MinValue) == 0)
        return;
      if ((IntPtr) this.hMixer != IntPtr.Zero)
      {
        int num = (int) Module.mixerClose(this.hMixer);
        this.hMixer = (HMIXER__*) 0;
      }
      this.labelMidi.Text = "xxx";
      this.groupBoxMidi.Enabled = false;
    }

    private void textBoxGameExe_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.None;
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      string[] strArray = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
      string str = Path.GetExtension(strArray[0]).ToLower();
      FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(strArray[0]);
      if (!(str == ".exe") || !(versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル2nd.") && !(versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル９５"))
        return;
      e.Effect = DragDropEffects.All;
    }

    private void textBoxGameExe_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      this.textBoxGameExe.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
    }

    private void textBoxReplayFolder_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.None;
      if (!e.Data.GetDataPresent(DataFormats.FileDrop) || !(Path.GetExtension(((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0]) == string.Empty))
        return;
      e.Effect = DragDropEffects.All;
    }

    private void textBoxReplayFolder_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      this.textBoxReplayFolder.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
    }

    private void textBoxSound_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.None;
      if (!e.Data.GetDataPresent(DataFormats.FileDrop) || !(Path.GetExtension(((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0]).ToLower() == ".wav"))
        return;
      e.Effect = DragDropEffects.All;
    }

    private void textBoxVSSound_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      this.textBoxVSSound.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
    }

    private void textBoxNoticeSound_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      this.textBoxNoticeSound.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
    }

    private void textBoxEnterSound_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      this.textBoxEnterSound.Text = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
    }

    private void groupBoxGameExe_Enter(object sender, EventArgs e)
    {
    }

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {
    }

    private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void buttonReplayManager_OnClick(object sender, EventArgs e)
    {
      int num = (int) new ReplayManagerForm().ShowDialog((IWin32Window) this);
    }

    private unsafe void FindGameIni_OnClick(object sender, EventArgs e)
    {
      try
      {
        if (this.textBoxGameExe.Text.Length <= 1)
          throw new Exception();
        Process.Start(Path.GetDirectoryName(this.textBoxGameExe.Text) + "\\game.ini");
      }
      catch (Exception ex)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  ((IntPtr) &Module.MTOPTION + 844) != 0)
        {
          ArrayTypeBY09_W arrayTypeBy09W;
          ArrayTypeBY0BAE_W arrayTypeBy0BaEW;
          Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy09W, 20U, (char*) &arrayTypeBy0BaEW, 260U, (char*) 0, 0U, (char*) 0, 0U);
          ArrayTypeBY0BAO_W arrayTypeBy0BaOW;
          Module.swprintf_s270(&arrayTypeBy0BaOW, (char*) &Module._C_1BKLOLHAEAGAACFAAsAACFAAsAAgAAaAAmAAeAA4AAiAAnAAiAAAA, __arglist (out arrayTypeBy09W, out arrayTypeBy0BaEW));
          Process.Start(new string((char*) &arrayTypeBy0BaOW));
        }
        else
        {
          int num = (int) MessageBox.Show("Couldn't find or open game.ini", "Couldn't find game.ini");
        }
      }
    }

    private void LagFix1CheckChange(object sender, EventArgs e)
    {
      this.buttonApply.Enabled = true;
      if (this.checkBoxLagReduction1.Checked)
      {
        this.numericUpDownLagReductionMS.Enabled = true;
        this.numericUpDownLagThreshold.Enabled = true;
      }
      else
      {
        this.numericUpDownLagReductionMS.Enabled = false;
        this.numericUpDownLagThreshold.Enabled = false;
      }
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.OptionForm();
        }
        finally
        {
          base.Dispose(true);
        }
      }
      else
        base.Dispose(false);
    }
  }
}
