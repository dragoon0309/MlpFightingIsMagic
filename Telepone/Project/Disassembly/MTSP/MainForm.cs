// Type: MTSP.MainForm
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using std;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace MTSP
{
  public class MainForm : Form
  {
    private static Color TalkMessageColor = new Color();
    private static Color SystemMessageColor = new Color();
    private static Color ErrorMessageColor = new Color();
    private static Color DebugMessageColor = new Color();
    private static Color NoticeBackColor = new Color();
    private static Color CommentBackColor = new Color();
    private static Color SecretColor = new Color();
    private MenuStrip menuStrip1;
    private SplitContainer splitContainer1;
    private ListBox listBoxMember;
    private TextBox textBoxInput;
    private ToolStripMenuItem toolStripMenuItemFile;
    private ToolStripMenuItem toolStripMenuItemSaveLog;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem toolStripMenuItemExit;
    private ToolStripMenuItem toolStripMenuItemOption;
    private ToolStripMenuItem toolStripMenuItemSetting;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem toolStripMenuItemDelay;
    private ToolStripMenuItem toolStripMenuItemDelayAuto;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem toolStripMenuItemDelay2;
    private ToolStripMenuItem toolStripMenuItemDelay3;
    private ToolStripMenuItem toolStripMenuItemDelay4;
    private ToolStripMenuItem toolStripMenuItemDelay5;
    private ToolStripMenuItem toolStripMenuItemDelay6;
    private ToolStripMenuItem toolStripMenuItemDelay7;
    private ToolStripMenuItem toolStripMenuItemDelay8;
    private ToolStripMenuItem toolStripMenuItemDelay9;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem toolStripMenuItemRecordReplay;
    private ToolStripMenuItem toolStripMenuItemAllowSpectator;
    private ToolStripMenuItem toolStripMenuItemHelp;
    private ToolStripMenuItem toolStripMenuItemViewCommand;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripMenuItem toolStripMenuItemVersion;
    private ContextMenuStrip contextMenuStripMember;
    private ContextMenuStrip contextMenuStripLog;
    private ToolStripMenuItem contextMenuItemCopy;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripMenuItem contxtMenuItemSaveLog;
    private ToolStripMenuItem toolStripMenuItemVS;
    private OpenFileDialog openFileDialog1;
    private ToolTip toolTipMember;
    private ToolStripMenuItem toolStripMenuItemPing;
    private ToolStripMenuItem toolStripMenuItemReplay;
    private ToolStripMenuItem toolStripMenuItemWatch;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripMenuItem toolStripMenuItemAfterRest;
    private ToolStripMenuItem toolStripMenuItemChangeList;
    private ToolStripMenuItem toolStripMenuItemDelay10;
    private ToolStripMenuItem toolStripMenuItemDelay11;
    private ToolStripMenuItem toolStripMenuItemDelay12;
    private ToolStripMenuItem actionsAToolStripMenuItem;
    private ToolStripMenuItem reconnectRToolStripMenuItem;
    private CustomRTB richTextBoxLog;
    private Button buttonRestToggle;
    private CheckBox checkBox1Autoscroll;
    private Button buttonRandVsWPing;
    private Label label1;
    private NumericUpDown textBoxMaxChallengePing;
    private ToolStripMenuItem toggleIgnoreToolStripMenuItem;
    private ToolStripMenuItem declineChallengesToolStripMenuItem;
    private CheckBox checkBoxDisableChat;
    private ToolStripMenuItem queryVersionToolStripMenuItem;
    private ToolStripMenuItem restOnConnectToolStripMenuItem;
    private Panel panel1;
    private Button buttonTrain;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripMenuItem toolStripMenuItemDisableEmotes;
    private Button button1;
    private Button buttonReconnect;
    private ToolStripMenuItem openSimpleHelpToolStripMenuItem;
    private ToolStripSeparator toolStripMenuItem1;
    private ToolStripMenuItem checkCompatibilityToolStripMenuItem;
    private Button button2;
    private ToolStripMenuItem noSinglePlayerReplaysToolStripMenuItem;
    private Button RefreshMemberList;
    private System.Windows.Forms.Timer General1SecTimer;
    private ProfileDisplay ProfileDisplayAnchored;
    private NotifyIcon notifyIcon1;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem restToolStripMenuItem;
    private ToolStripMenuItem replayManagerToolStripMenuItem1;
    private ToolStripMenuItem statsManagerToolStripMenuItem;
    private ToolStripMenuItem spectateSettingsToolStripMenuItem;
    private ComboBox CMBX_GameSwitcher;
    private System.Windows.Forms.Timer Prize1HourTimer;
    private IContainer components;
    private static OptionForm Option;
    private static bool IsFormClosing;
    private static SERVER_MODE ServerMode;
    private static LIST_VIEW ListView;
    public static string ReplayFilePath;
    public static string LastReplayPath;
    public static GFXLoader GFXLOADER;
    public static USER_RELATIONS MYRELATIONS;
    public static PrizeManager PRIZEMAN;
    public static PacketScheduler PACSCHED;
    private static int ChatHistoryNumber;
    private static List<string> ChatHistory;
    private static uint LastThrottledMessageTime;
    private static Color[] NameColor;
    private static Color[] StateRectColor;
    private static List<MemberInfo> MemberList;
    private static ushort IDCounter;
    private static uint Ping;
    private static Thread GameThread;
    private static UdpClient UDP;
    private static string ServerName;
    private static bool AfterCloseUDP;
    private static Thread SonarThread;
    private static bool Ranging;
    private static bool SonarSleeping;
    private static Thread VersusThread;
    private static VersusInfo NetVS;
    private static Thread SpectacleThread;
    private static List<MainForm.SpectatorInfo> SpectatorList;
    private static bool AllowWatch;
    private static uint WaitingWatch;
    private static IPEndPoint WatchTarget;
    private static ushort TargetID;
    private static ushort P1ID;
    private static ushort P2ID;
    private static uint WatchFrame;
    private static ushort[] WatchHistory;
    private static uint InputFrame;
    private static ushort[] InputHistory;
    private static bool WaitingForResend;
    private static uint WaitingForFrame;
    private static GenericResultsWindow SpecDbgWnd;
    private static int LastMemberRefresh;
    private static int LastMemberIndex;

    static MainForm()
    {
    }

    public MainForm()
    {
      // ISSUE: fault handler
      try
      {
        this.InitializeComponent();
        MainForm.LastThrottledMessageTime = 0U;
        this.splitContainer1.Panel1.Controls.Remove((Control) this.listBoxMember);
        this.listBoxMember = (ListBox) new CustomListBox();
        this.splitContainer1.Panel1.Controls.Add((Control) this.listBoxMember);
        this.listBoxMember.BorderStyle = BorderStyle.None;
        this.listBoxMember.ContextMenuStrip = this.contextMenuStripMember;
        this.listBoxMember.Dock = DockStyle.Fill;
        this.listBoxMember.DrawMode = DrawMode.OwnerDrawFixed;
        this.listBoxMember.FormattingEnabled = true;
        this.listBoxMember.ItemHeight = 16;
        this.listBoxMember.Location = new Point(0, 0);
        this.listBoxMember.Name = "listBoxMember";
        this.listBoxMember.Size = new Size(118, 365);
        this.listBoxMember.TabIndex = 2;
        this.listBoxMember.MouseClick += new MouseEventHandler(this.listBoxMember_OnClick);
        this.listBoxMember.DrawItem += new DrawItemEventHandler(this.listBoxMember_DrawItem);
        this.listBoxMember.SelectedIndexChanged += new EventHandler(this.listBoxMember_SelectedIndexChanged);
        this.listBoxMember.DragOver += new DragEventHandler(this.listBoxMember_DragOver);
        this.listBoxMember.MouseDoubleClick += new MouseEventHandler(this.listBoxMember_MouseDoubleClick);
        this.listBoxMember.MouseLeave += new EventHandler(this.listBoxMember_MouseLeave);
        this.listBoxMember.MouseMove += new MouseEventHandler(this.listBoxMember_MouseMove);
        this.listBoxMember.Enabled = true;
        this.listBoxMember.Show();
      }
      __fault
      {
        base.Dispose(true);
      }
    }

    private void MainForm()
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MainForm));
      this.menuStrip1 = new MenuStrip();
      this.toolStripMenuItemFile = new ToolStripMenuItem();
      this.toolStripMenuItemReplay = new ToolStripMenuItem();
      this.toolStripMenuItemSaveLog = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.toolStripMenuItemExit = new ToolStripMenuItem();
      this.actionsAToolStripMenuItem = new ToolStripMenuItem();
      this.restToolStripMenuItem = new ToolStripMenuItem();
      this.reconnectRToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.replayManagerToolStripMenuItem1 = new ToolStripMenuItem();
      this.statsManagerToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItemOption = new ToolStripMenuItem();
      this.toolStripMenuItemSetting = new ToolStripMenuItem();
      this.spectateSettingsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.toolStripMenuItemDelay = new ToolStripMenuItem();
      this.toolStripMenuItemDelayAuto = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.toolStripMenuItemDelay2 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay3 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay4 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay5 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay6 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay7 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay8 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay9 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay10 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay11 = new ToolStripMenuItem();
      this.toolStripMenuItemDelay12 = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.toolStripMenuItemRecordReplay = new ToolStripMenuItem();
      this.noSinglePlayerReplaysToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItemAllowSpectator = new ToolStripMenuItem();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.restOnConnectToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItemAfterRest = new ToolStripMenuItem();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.toolStripMenuItemDisableEmotes = new ToolStripMenuItem();
      this.toolStripMenuItemHelp = new ToolStripMenuItem();
      this.toolStripMenuItemViewCommand = new ToolStripMenuItem();
      this.openSimpleHelpToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItemChangeList = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.toolStripMenuItemVersion = new ToolStripMenuItem();
      this.splitContainer1 = new SplitContainer();
      this.listBoxMember = new ListBox();
      MainForm mainForm1 = this;
      ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip(mainForm1.components);
      mainForm1.contextMenuStripMember = contextMenuStrip1;
      this.toolStripMenuItemVS = new ToolStripMenuItem();
      this.toolStripMenuItemWatch = new ToolStripMenuItem();
      this.toolStripMenuItemPing = new ToolStripMenuItem();
      this.toggleIgnoreToolStripMenuItem = new ToolStripMenuItem();
      this.declineChallengesToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripSeparator();
      this.queryVersionToolStripMenuItem = new ToolStripMenuItem();
      this.checkCompatibilityToolStripMenuItem = new ToolStripMenuItem();
      this.ProfileDisplayAnchored = new ProfileDisplay();
      this.richTextBoxLog = new CustomRTB();
      MainForm mainForm2 = this;
      ContextMenuStrip contextMenuStrip2 = new ContextMenuStrip(mainForm2.components);
      mainForm2.contextMenuStripLog = contextMenuStrip2;
      this.contextMenuItemCopy = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.contxtMenuItemSaveLog = new ToolStripMenuItem();
      this.textBoxInput = new TextBox();
      this.openFileDialog1 = new OpenFileDialog();
      MainForm mainForm3 = this;
      ToolTip toolTip = new ToolTip(mainForm3.components);
      mainForm3.toolTipMember = toolTip;
      this.buttonRestToggle = new Button();
      this.buttonRandVsWPing = new Button();
      this.checkBoxDisableChat = new CheckBox();
      this.buttonTrain = new Button();
      this.button1 = new Button();
      this.buttonReconnect = new Button();
      this.RefreshMemberList = new Button();
      this.checkBox1Autoscroll = new CheckBox();
      this.label1 = new Label();
      this.textBoxMaxChallengePing = new NumericUpDown();
      this.panel1 = new Panel();
      this.CMBX_GameSwitcher = new ComboBox();
      this.button2 = new Button();
      MainForm mainForm4 = this;
      System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer(mainForm4.components);
      mainForm4.General1SecTimer = timer1;
      MainForm mainForm5 = this;
      NotifyIcon notifyIcon = new NotifyIcon(mainForm5.components);
      mainForm5.notifyIcon1 = notifyIcon;
      MainForm mainForm6 = this;
      System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer(mainForm6.components);
      mainForm6.Prize1HourTimer = timer2;
      this.menuStrip1.SuspendLayout();
      this.splitContainer1.BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.contextMenuStripMember.SuspendLayout();
      this.ProfileDisplayAnchored.BeginInit();
      this.contextMenuStripLog.SuspendLayout();
      this.textBoxMaxChallengePing.BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.menuStrip1.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItemFile,
        (ToolStripItem) this.actionsAToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItemOption,
        (ToolStripItem) this.toolStripMenuItemHelp
      });
      this.menuStrip1.Location = new Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new Size(711, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
      this.toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItemReplay,
        (ToolStripItem) this.toolStripMenuItemSaveLog,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.toolStripMenuItemExit
      });
      this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
      this.toolStripMenuItemFile.Size = new Size(52, 20);
      this.toolStripMenuItemFile.Text = "File (&F)";
      this.toolStripMenuItemFile.Click += new EventHandler(this.toolStripMenuItemFile_Click);
      this.toolStripMenuItemReplay.Name = "toolStripMenuItemReplay";
      this.toolStripMenuItemReplay.Size = new Size(184, 22);
      this.toolStripMenuItemReplay.Text = "Playback replay file (&R)";
      this.toolStripMenuItemReplay.Click += new EventHandler(this.toolStripMenuItemReplay_Click);
      this.toolStripMenuItemSaveLog.Name = "toolStripMenuItemSaveLog";
      this.toolStripMenuItemSaveLog.ShortcutKeys = Keys.S | Keys.Control;
      this.toolStripMenuItemSaveLog.Size = new Size(184, 22);
      this.toolStripMenuItemSaveLog.Text = "Save log (&S)";
      this.toolStripMenuItemSaveLog.Click += new EventHandler(this.toolStripMenuItemSaveLog_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(181, 6);
      this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
      this.toolStripMenuItemExit.Size = new Size(184, 22);
      this.toolStripMenuItemExit.Text = "Exit (&X)";
      this.toolStripMenuItemExit.Click += new EventHandler(this.toolStripMenuItemExit_Click);
      this.actionsAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.restToolStripMenuItem,
        (ToolStripItem) this.reconnectRToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator10,
        (ToolStripItem) this.replayManagerToolStripMenuItem1,
        (ToolStripItem) this.statsManagerToolStripMenuItem
      });
      this.actionsAToolStripMenuItem.Name = "actionsAToolStripMenuItem";
      this.actionsAToolStripMenuItem.Size = new Size(63, 20);
      this.actionsAToolStripMenuItem.Text = "Tasks (&T)";
      this.restToolStripMenuItem.Name = "restToolStripMenuItem";
      this.restToolStripMenuItem.Size = new Size(164, 22);
      this.restToolStripMenuItem.Text = "Toggle rest (&T)";
      this.restToolStripMenuItem.Click += new EventHandler(this.buttonToggleRestOn_Click);
      this.reconnectRToolStripMenuItem.Name = "reconnectRToolStripMenuItem";
      this.reconnectRToolStripMenuItem.Size = new Size(164, 22);
      this.reconnectRToolStripMenuItem.Text = "Reconnect (&R)";
      this.reconnectRToolStripMenuItem.Click += new EventHandler(this.reconnectRToolStripMenuItem_Click);
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new Size(161, 6);
      this.replayManagerToolStripMenuItem1.Name = "replayManagerToolStripMenuItem1";
      this.replayManagerToolStripMenuItem1.Size = new Size(164, 22);
      this.replayManagerToolStripMenuItem1.Text = "Replay manager...";
      this.replayManagerToolStripMenuItem1.Click += new EventHandler(this.menuStripReplayManager_OnClick);
      this.statsManagerToolStripMenuItem.Name = "statsManagerToolStripMenuItem";
      this.statsManagerToolStripMenuItem.Size = new Size(164, 22);
      this.statsManagerToolStripMenuItem.Text = "Stats manager...";
      this.statsManagerToolStripMenuItem.Click += new EventHandler(this.StatsManagerMenuItem_Click);
      this.toolStripMenuItemOption.DropDownItems.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.toolStripMenuItemSetting,
        (ToolStripItem) this.spectateSettingsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.toolStripMenuItemDelay,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.toolStripMenuItemRecordReplay,
        (ToolStripItem) this.noSinglePlayerReplaysToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItemAllowSpectator,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.restOnConnectToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItemAfterRest,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.toolStripMenuItemDisableEmotes
      });
      this.toolStripMenuItemOption.Name = "toolStripMenuItemOption";
      this.toolStripMenuItemOption.Size = new Size(75, 20);
      this.toolStripMenuItemOption.Text = "Options (&O)";
      this.toolStripMenuItemOption.Click += new EventHandler(this.toolStripMenuItemOption_Click);
      this.toolStripMenuItemSetting.Name = "toolStripMenuItemSetting";
      this.toolStripMenuItemSetting.Size = new Size(209, 22);
      this.toolStripMenuItemSetting.Text = "General settings... (&G)";
      this.toolStripMenuItemSetting.Click += new EventHandler(this.toolStripMenuItemSetting_Click);
      this.spectateSettingsToolStripMenuItem.Name = "spectateSettingsToolStripMenuItem";
      this.spectateSettingsToolStripMenuItem.Size = new Size(209, 22);
      this.spectateSettingsToolStripMenuItem.Text = "Spectate settings... (&S)";
      this.spectateSettingsToolStripMenuItem.Click += new EventHandler(this.spectateSettingsToolStripMenuItem_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(206, 6);
      this.toolStripMenuItemDelay.DropDownItems.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.toolStripMenuItemDelayAuto,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.toolStripMenuItemDelay2,
        (ToolStripItem) this.toolStripMenuItemDelay3,
        (ToolStripItem) this.toolStripMenuItemDelay4,
        (ToolStripItem) this.toolStripMenuItemDelay5,
        (ToolStripItem) this.toolStripMenuItemDelay6,
        (ToolStripItem) this.toolStripMenuItemDelay7,
        (ToolStripItem) this.toolStripMenuItemDelay8,
        (ToolStripItem) this.toolStripMenuItemDelay9,
        (ToolStripItem) this.toolStripMenuItemDelay10,
        (ToolStripItem) this.toolStripMenuItemDelay11,
        (ToolStripItem) this.toolStripMenuItemDelay12
      });
      this.toolStripMenuItemDelay.Name = "toolStripMenuItemDelay";
      this.toolStripMenuItemDelay.Size = new Size(209, 22);
      this.toolStripMenuItemDelay.Text = "Delay (&D)";
      this.toolStripMenuItemDelayAuto.Checked = true;
      this.toolStripMenuItemDelayAuto.CheckState = CheckState.Checked;
      this.toolStripMenuItemDelayAuto.Name = "toolStripMenuItemDelayAuto";
      this.toolStripMenuItemDelayAuto.Size = new Size(97, 22);
      this.toolStripMenuItemDelayAuto.Text = "Auto";
      this.toolStripMenuItemDelayAuto.Click += new EventHandler(this.toolStripMenuItemDelayAuto_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(94, 6);
      this.toolStripMenuItemDelay2.Name = "toolStripMenuItemDelay2";
      this.toolStripMenuItemDelay2.Size = new Size(97, 22);
      this.toolStripMenuItemDelay2.Text = "2";
      this.toolStripMenuItemDelay2.Click += new EventHandler(this.toolStripMenuItemDelay2_Click);
      this.toolStripMenuItemDelay3.Name = "toolStripMenuItemDelay3";
      this.toolStripMenuItemDelay3.Size = new Size(97, 22);
      this.toolStripMenuItemDelay3.Text = "3";
      this.toolStripMenuItemDelay3.Click += new EventHandler(this.toolStripMenuItemDelay3_Click);
      this.toolStripMenuItemDelay4.Name = "toolStripMenuItemDelay4";
      this.toolStripMenuItemDelay4.Size = new Size(97, 22);
      this.toolStripMenuItemDelay4.Text = "4";
      this.toolStripMenuItemDelay4.Click += new EventHandler(this.toolStripMenuItemDelay4_Click);
      this.toolStripMenuItemDelay5.Name = "toolStripMenuItemDelay5";
      this.toolStripMenuItemDelay5.Size = new Size(97, 22);
      this.toolStripMenuItemDelay5.Text = "5";
      this.toolStripMenuItemDelay5.Click += new EventHandler(this.toolStripMenuItemDelay5_Click);
      this.toolStripMenuItemDelay6.Name = "toolStripMenuItemDelay6";
      this.toolStripMenuItemDelay6.Size = new Size(97, 22);
      this.toolStripMenuItemDelay6.Text = "6";
      this.toolStripMenuItemDelay6.Click += new EventHandler(this.toolStripMenuItemDelay6_Click);
      this.toolStripMenuItemDelay7.Name = "toolStripMenuItemDelay7";
      this.toolStripMenuItemDelay7.Size = new Size(97, 22);
      this.toolStripMenuItemDelay7.Text = "7";
      this.toolStripMenuItemDelay7.Click += new EventHandler(this.toolStripMenuItemDelay7_Click);
      this.toolStripMenuItemDelay8.Name = "toolStripMenuItemDelay8";
      this.toolStripMenuItemDelay8.Size = new Size(97, 22);
      this.toolStripMenuItemDelay8.Text = "8";
      this.toolStripMenuItemDelay8.Click += new EventHandler(this.toolStripMenuItemDelay8_Click);
      this.toolStripMenuItemDelay9.Name = "toolStripMenuItemDelay9";
      this.toolStripMenuItemDelay9.Size = new Size(97, 22);
      this.toolStripMenuItemDelay9.Text = "9";
      this.toolStripMenuItemDelay9.Click += new EventHandler(this.toolStripMenuItemDelay9_Click);
      this.toolStripMenuItemDelay10.Name = "toolStripMenuItemDelay10";
      this.toolStripMenuItemDelay10.Size = new Size(97, 22);
      this.toolStripMenuItemDelay10.Text = "10";
      this.toolStripMenuItemDelay10.Click += new EventHandler(this.toolStripMenuItemDelay10_Click);
      this.toolStripMenuItemDelay11.Name = "toolStripMenuItemDelay11";
      this.toolStripMenuItemDelay11.Size = new Size(97, 22);
      this.toolStripMenuItemDelay11.Text = "11";
      this.toolStripMenuItemDelay11.Click += new EventHandler(this.toolStripMenuItemDelay11_Click);
      this.toolStripMenuItemDelay12.Name = "toolStripMenuItemDelay12";
      this.toolStripMenuItemDelay12.Size = new Size(97, 22);
      this.toolStripMenuItemDelay12.Text = "12";
      this.toolStripMenuItemDelay12.Click += new EventHandler(this.toolStripMenuItemDelay12_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(206, 6);
      this.toolStripMenuItemRecordReplay.Checked = true;
      this.toolStripMenuItemRecordReplay.CheckState = CheckState.Checked;
      this.toolStripMenuItemRecordReplay.Name = "toolStripMenuItemRecordReplay";
      this.toolStripMenuItemRecordReplay.Size = new Size(209, 22);
      this.toolStripMenuItemRecordReplay.Text = "Save replay files (&R)";
      this.toolStripMenuItemRecordReplay.Click += new EventHandler(this.toolStripMenuItemRecordReplay_Click);
      this.noSinglePlayerReplaysToolStripMenuItem.Name = "noSinglePlayerReplaysToolStripMenuItem";
      this.noSinglePlayerReplaysToolStripMenuItem.Size = new Size(209, 22);
      this.noSinglePlayerReplaysToolStripMenuItem.Text = "No single player replays (&P)";
      this.noSinglePlayerReplaysToolStripMenuItem.Click += new EventHandler(this.noSinglePlayerReplaysToolStripMenuItem_Click);
      this.toolStripMenuItemAllowSpectator.Checked = true;
      this.toolStripMenuItemAllowSpectator.CheckState = CheckState.Checked;
      this.toolStripMenuItemAllowSpectator.Name = "toolStripMenuItemAllowSpectator";
      this.toolStripMenuItemAllowSpectator.Size = new Size(209, 22);
      this.toolStripMenuItemAllowSpectator.Text = "Allow spectators (&A)";
      this.toolStripMenuItemAllowSpectator.Click += new EventHandler(this.toolStripMenuItemAllowSpectator_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(206, 6);
      this.restOnConnectToolStripMenuItem.Name = "restOnConnectToolStripMenuItem";
      this.restOnConnectToolStripMenuItem.Size = new Size(209, 22);
      this.restOnConnectToolStripMenuItem.Text = "Rest on connect";
      this.restOnConnectToolStripMenuItem.Click += new EventHandler(this.toolStripMenuItemConnectRest_Click);
      this.toolStripMenuItemAfterRest.Name = "toolStripMenuItemAfterRest";
      this.toolStripMenuItemAfterRest.Size = new Size(209, 22);
      this.toolStripMenuItemAfterRest.Text = "Go to rest mode after battle";
      this.toolStripMenuItemAfterRest.Click += new EventHandler(this.toolStripMenuItemAfterRest_Click);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(206, 6);
      this.toolStripMenuItemDisableEmotes.Name = "toolStripMenuItemDisableEmotes";
      this.toolStripMenuItemDisableEmotes.Size = new Size(209, 22);
      this.toolStripMenuItemDisableEmotes.Text = "Disable emotes (&E)";
      this.toolStripMenuItemDisableEmotes.Click += new EventHandler(this.toolStripMenuItem2_Click);
      this.toolStripMenuItemHelp.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripMenuItemViewCommand,
        (ToolStripItem) this.openSimpleHelpToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItemChangeList,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.toolStripMenuItemVersion
      });
      this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
      this.toolStripMenuItemHelp.ShortcutKeyDisplayString = "Ctrl+L";
      this.toolStripMenuItemHelp.Size = new Size(58, 20);
      this.toolStripMenuItemHelp.Text = "Help (&H)";
      this.toolStripMenuItemViewCommand.Name = "toolStripMenuItemViewCommand";
      this.toolStripMenuItemViewCommand.Size = new Size(192, 22);
      this.toolStripMenuItemViewCommand.Text = "Command list (&C)";
      this.toolStripMenuItemViewCommand.Click += new EventHandler(this.toolStripMenuItemViewCommand_Click);
      this.openSimpleHelpToolStripMenuItem.Name = "openSimpleHelpToolStripMenuItem";
      this.openSimpleHelpToolStripMenuItem.ShortcutKeys = Keys.F1;
      this.openSimpleHelpToolStripMenuItem.Size = new Size(192, 22);
      this.openSimpleHelpToolStripMenuItem.Text = "Open simple help (H)";
      this.openSimpleHelpToolStripMenuItem.Click += new EventHandler(this.menuItemSimpleHelp_OnClick);
      this.toolStripMenuItemChangeList.Name = "toolStripMenuItemChangeList";
      this.toolStripMenuItemChangeList.ShortcutKeys = Keys.F2;
      this.toolStripMenuItemChangeList.Size = new Size(192, 22);
      this.toolStripMenuItemChangeList.Text = "List switch (&L)";
      this.toolStripMenuItemChangeList.Click += new EventHandler(this.toolStripMenuItemChangeList_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(189, 6);
      this.toolStripMenuItemVersion.Name = "toolStripMenuItemVersion";
      this.toolStripMenuItemVersion.Size = new Size(192, 22);
      this.toolStripMenuItemVersion.Text = "Version info (&A)";
      this.toolStripMenuItemVersion.Click += new EventHandler(this.toolStripMenuItemVersion_Click);
      this.splitContainer1.BorderStyle = BorderStyle.FixedSingle;
      this.splitContainer1.Dock = DockStyle.Fill;
      this.splitContainer1.Location = new Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Panel1.Controls.Add((Control) this.listBoxMember);
      this.splitContainer1.Panel2.Controls.Add((Control) this.ProfileDisplayAnchored);
      this.splitContainer1.Panel2.Controls.Add((Control) this.richTextBoxLog);
      this.splitContainer1.Panel2.Controls.Add((Control) this.textBoxInput);
      this.splitContainer1.Size = new Size(711, 367);
      this.splitContainer1.SplitterDistance = 120;
      this.splitContainer1.TabIndex = 2;
      this.splitContainer1.TabStop = false;
      this.listBoxMember.BorderStyle = BorderStyle.None;
      this.listBoxMember.ContextMenuStrip = this.contextMenuStripMember;
      this.listBoxMember.Dock = DockStyle.Fill;
      this.listBoxMember.DrawMode = DrawMode.OwnerDrawFixed;
      this.listBoxMember.FormattingEnabled = true;
      this.listBoxMember.ItemHeight = 16;
      this.listBoxMember.Location = new Point(0, 0);
      this.listBoxMember.Name = "listBoxMember";
      this.listBoxMember.Size = new Size(118, 365);
      this.listBoxMember.TabIndex = 2;
      this.listBoxMember.MouseClick += new MouseEventHandler(this.listBoxMember_OnClick);
      this.listBoxMember.DrawItem += new DrawItemEventHandler(this.listBoxMember_DrawItem);
      this.listBoxMember.SelectedIndexChanged += new EventHandler(this.listBoxMember_SelectedIndexChanged);
      this.listBoxMember.DragOver += new DragEventHandler(this.listBoxMember_DragOver);
      this.listBoxMember.MouseDoubleClick += new MouseEventHandler(this.listBoxMember_MouseDoubleClick);
      this.listBoxMember.MouseLeave += new EventHandler(this.listBoxMember_MouseLeave);
      this.listBoxMember.MouseMove += new MouseEventHandler(this.listBoxMember_MouseMove);
      this.contextMenuStripMember.Items.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.toolStripMenuItemVS,
        (ToolStripItem) this.toolStripMenuItemWatch,
        (ToolStripItem) this.toolStripMenuItemPing,
        (ToolStripItem) this.toggleIgnoreToolStripMenuItem,
        (ToolStripItem) this.declineChallengesToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.queryVersionToolStripMenuItem,
        (ToolStripItem) this.checkCompatibilityToolStripMenuItem
      });
      this.contextMenuStripMember.Name = "contextMenuStrip1";
      this.contextMenuStripMember.ShowImageMargin = false;
      this.contextMenuStripMember.Size = new Size(141, 164);
      this.contextMenuStripMember.Opening += new CancelEventHandler(this.contextMenuStripMember_Opening);
      this.toolStripMenuItemVS.Name = "toolStripMenuItemVS";
      this.toolStripMenuItemVS.Size = new Size(140, 22);
      this.toolStripMenuItemVS.Text = "Challenge";
      this.toolStripMenuItemVS.Click += new EventHandler(this.toolStripMenuItemVS_Click);
      this.toolStripMenuItemWatch.Name = "toolStripMenuItemWatch";
      this.toolStripMenuItemWatch.Size = new Size(140, 22);
      this.toolStripMenuItemWatch.Text = "Spectate";
      this.toolStripMenuItemWatch.Click += new EventHandler(this.toolStripMenuItemWatch_Click);
      this.toolStripMenuItemPing.Name = "toolStripMenuItemPing";
      this.toolStripMenuItemPing.Size = new Size(140, 22);
      this.toolStripMenuItemPing.Text = "Ping";
      this.toolStripMenuItemPing.Click += new EventHandler(this.toolStripMenuItemPing_Click);
      this.toggleIgnoreToolStripMenuItem.Name = "toggleIgnoreToolStripMenuItem";
      this.toggleIgnoreToolStripMenuItem.Size = new Size(140, 22);
      this.toggleIgnoreToolStripMenuItem.Text = "Toggle ignore";
      this.toggleIgnoreToolStripMenuItem.Click += new EventHandler(this.ToggleIgnore_OnClick);
      this.declineChallengesToolStripMenuItem.Name = "declineChallengesToolStripMenuItem";
      this.declineChallengesToolStripMenuItem.Size = new Size(140, 22);
      this.declineChallengesToolStripMenuItem.Text = "Decline challenges";
      this.declineChallengesToolStripMenuItem.Click += new EventHandler(this.DeclineChallenges_OnClick);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new Size(137, 6);
      this.queryVersionToolStripMenuItem.Name = "queryVersionToolStripMenuItem";
      this.queryVersionToolStripMenuItem.Size = new Size(140, 22);
      this.queryVersionToolStripMenuItem.Text = "Get version info";
      this.queryVersionToolStripMenuItem.Click += new EventHandler(this.QueryVersion_OnClick);
      this.checkCompatibilityToolStripMenuItem.Name = "checkCompatibilityToolStripMenuItem";
      this.checkCompatibilityToolStripMenuItem.Size = new Size(140, 22);
      this.checkCompatibilityToolStripMenuItem.Text = "Check compatibility";
      this.checkCompatibilityToolStripMenuItem.Click += new EventHandler(this.CheckCompatibility_OnClick);
      this.ProfileDisplayAnchored.Image = (Image) componentResourceManager.GetObject("ProfileDisplayAnchored.Image");
      this.ProfileDisplayAnchored.Location = new Point(0, 0);
      this.ProfileDisplayAnchored.Name = "ProfileDisplayAnchored";
      this.ProfileDisplayAnchored.Size = new Size(0, 0);
      this.ProfileDisplayAnchored.TabIndex = 1;
      this.ProfileDisplayAnchored.TabStop = false;
      this.ProfileDisplayAnchored.Visible = false;
      this.richTextBoxLog.BackColor = SystemColors.Window;
      this.richTextBoxLog.BorderStyle = BorderStyle.None;
      this.richTextBoxLog.ContextMenuStrip = this.contextMenuStripLog;
      this.richTextBoxLog.Dock = DockStyle.Fill;
      this.richTextBoxLog.Location = new Point(0, 0);
      this.richTextBoxLog.Name = "richTextBoxLog";
      this.richTextBoxLog.ReadOnly = true;
      this.richTextBoxLog.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
      this.richTextBoxLog.Size = new Size(585, 345);
      this.richTextBoxLog.TabIndex = 0;
      this.richTextBoxLog.TabStop = false;
      this.richTextBoxLog.Text = "";
      this.richTextBoxLog.LinkClicked += new LinkClickedEventHandler(this.richTextBoxLog_LinkClicked);
      this.richTextBoxLog.Click += new EventHandler(this.HideProfile);
      this.richTextBoxLog.TextChanged += new EventHandler(this.richTextBoxLog_TextChanged);
      this.richTextBoxLog.KeyDown += new KeyEventHandler(this.richTextBoxLog_KeyDown);
      this.richTextBoxLog.MouseHover += new EventHandler(this.HideProfile);
      this.contextMenuStripLog.Items.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.contextMenuItemCopy,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.contxtMenuItemSaveLog
      });
      this.contextMenuStripLog.Name = "contextMenuStrip2";
      this.contextMenuStripLog.ShowImageMargin = false;
      this.contextMenuStripLog.Size = new Size(146, 54);
      this.contextMenuItemCopy.Name = "contextMenuItemCopy";
      this.contextMenuItemCopy.ShortcutKeys = Keys.C | Keys.Control;
      this.contextMenuItemCopy.Size = new Size(145, 22);
      this.contextMenuItemCopy.Text = "Copy (&C)";
      this.contextMenuItemCopy.Click += new EventHandler(this.contextMenuItemCopy_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(142, 6);
      this.contxtMenuItemSaveLog.Name = "contxtMenuItemSaveLog";
      this.contxtMenuItemSaveLog.ShortcutKeys = Keys.S | Keys.Control;
      this.contxtMenuItemSaveLog.Size = new Size(145, 22);
      this.contxtMenuItemSaveLog.Text = "Save log (&S)";
      this.contxtMenuItemSaveLog.Click += new EventHandler(this.toolStripMenuItemSaveLog_Click);
      this.textBoxInput.BackColor = SystemColors.Window;
      this.textBoxInput.Dock = DockStyle.Bottom;
      this.textBoxInput.Location = new Point(0, 345);
      this.textBoxInput.MaxLength = (int) sbyte.MaxValue;
      this.textBoxInput.Name = "textBoxInput";
      this.textBoxInput.Size = new Size(585, 20);
      this.textBoxInput.TabIndex = 0;
      this.textBoxInput.Enter += new EventHandler(this.HideProfile);
      this.textBoxInput.KeyDown += new KeyEventHandler(this.textBoxInput_KeyDown);
      this.textBoxInput.MouseEnter += new EventHandler(this.HideProfile);
      this.openFileDialog1.Filter = "MT Replay file (*.mtr)|*.mtr";
      this.openFileDialog1.Title = "Telepone用のリプレイファイル";
      this.toolTipMember.AutomaticDelay = 10;
      this.toolTipMember.AutoPopDelay = 5000;
      this.toolTipMember.InitialDelay = 10;
      this.toolTipMember.ReshowDelay = 10;
      this.toolTipMember.Popup += new PopupEventHandler(this.toolTipMember_Popup);
      this.buttonRestToggle.BackColor = Color.Cornsilk;
      this.buttonRestToggle.FlatAppearance.BorderColor = Color.White;
      this.buttonRestToggle.FlatAppearance.BorderSize = 0;
      this.buttonRestToggle.FlatAppearance.MouseDownBackColor = Color.Yellow;
      this.buttonRestToggle.Image = (Image) componentResourceManager.GetObject("buttonRestToggle.Image");
      this.buttonRestToggle.Location = new Point(166, 2);
      this.buttonRestToggle.Name = "buttonRestToggle";
      this.buttonRestToggle.Size = new Size(35, 28);
      this.buttonRestToggle.TabIndex = 3;
      this.toolTipMember.SetToolTip((Control) this.buttonRestToggle, "Toggle rest mode");
      this.buttonRestToggle.UseVisualStyleBackColor = false;
      this.buttonRestToggle.Click += new EventHandler(this.buttonToggleRestOn_Click);
      this.buttonRestToggle.MouseLeave += new EventHandler(this.buttonToggleRestMode_OnMouseLeave);
      this.buttonRandVsWPing.Image = (Image) componentResourceManager.GetObject("buttonRandVsWPing.Image");
      this.buttonRandVsWPing.Location = new Point(275, 2);
      this.buttonRandVsWPing.Name = "buttonRandVsWPing";
      this.buttonRandVsWPing.Size = new Size(41, 28);
      this.buttonRandVsWPing.TabIndex = 5;
      this.toolTipMember.SetToolTip((Control) this.buttonRandVsWPing, "Challenge random opponent whose ping is less than the specified ping");
      this.buttonRandVsWPing.UseVisualStyleBackColor = true;
      this.buttonRandVsWPing.Click += new EventHandler(this.buttonRandomPingVS_OnClick);
      this.buttonRandVsWPing.MouseLeave += new EventHandler(this.buttonToggleRestMode_OnMouseLeave);
      this.checkBoxDisableChat.AutoSize = true;
      this.checkBoxDisableChat.BackColor = Color.LightSteelBlue;
      this.checkBoxDisableChat.Location = new Point(627, 9);
      this.checkBoxDisableChat.Name = "checkBoxDisableChat";
      this.checkBoxDisableChat.Size = new Size(81, 17);
      this.checkBoxDisableChat.TabIndex = 8;
      this.checkBoxDisableChat.Text = "Silent mode";
      this.toolTipMember.SetToolTip((Control) this.checkBoxDisableChat, "Disables all chat output. This can improve Telepone's stability.");
      this.checkBoxDisableChat.UseVisualStyleBackColor = false;
      this.checkBoxDisableChat.MouseLeave += new EventHandler(this.buttonToggleRestMode_OnMouseLeave);
      this.buttonTrain.Image = (Image) componentResourceManager.GetObject("buttonTrain.Image");
      this.buttonTrain.Location = new Point(202, 2);
      this.buttonTrain.Name = "buttonTrain";
      this.buttonTrain.Size = new Size(37, 28);
      this.buttonTrain.TabIndex = 9;
      this.toolTipMember.SetToolTip((Control) this.buttonTrain, "Train in single player mode");
      this.buttonTrain.UseVisualStyleBackColor = true;
      this.buttonTrain.Click += new EventHandler(this.buttonTrain_OnClick);
      this.buttonTrain.MouseLeave += new EventHandler(this.buttonToggleRestMode_OnMouseLeave);
      this.button1.Image = (Image) componentResourceManager.GetObject("button1.Image");
      this.button1.Location = new Point(241, 2);
      this.button1.Name = "button1";
      this.button1.Size = new Size(34, 28);
      this.button1.TabIndex = 10;
      this.toolTipMember.SetToolTip((Control) this.button1, "Mark recently saved replay as a favorite");
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.buttonFavLast_OnClick);
      this.button1.MouseLeave += new EventHandler(this.buttonToggleRestMode_OnMouseLeave);
      this.buttonReconnect.Image = (Image) componentResourceManager.GetObject("buttonReconnect.Image");
      this.buttonReconnect.Location = new Point(129, 2);
      this.buttonReconnect.Name = "buttonReconnect";
      this.buttonReconnect.Size = new Size(35, 28);
      this.buttonReconnect.TabIndex = 11;
      this.toolTipMember.SetToolTip((Control) this.buttonReconnect, "Reconnect or go to free play");
      this.buttonReconnect.UseVisualStyleBackColor = true;
      this.buttonReconnect.Click += new EventHandler(this.reconnectRToolStripMenuItem_Click);
      this.RefreshMemberList.Location = new Point(6, 5);
      this.RefreshMemberList.Name = "RefreshMemberList";
      this.RefreshMemberList.Size = new Size(120, 23);
      this.RefreshMemberList.TabIndex = 13;
      this.RefreshMemberList.Text = "Refresh list";
      this.toolTipMember.SetToolTip((Control) this.RefreshMemberList, "Gets an updated member list from the server, because sometimes member join packets are lost.");
      this.RefreshMemberList.UseVisualStyleBackColor = true;
      this.RefreshMemberList.Click += new EventHandler(this.RefreshMemberList_Click);
      this.RefreshMemberList.MouseLeave += new EventHandler(this.buttonToggleRestMode_OnMouseLeave);
      this.checkBox1Autoscroll.AutoSize = true;
      this.checkBox1Autoscroll.BackColor = Color.LightSteelBlue;
      this.checkBox1Autoscroll.Checked = true;
      this.checkBox1Autoscroll.CheckState = CheckState.Checked;
      this.checkBox1Autoscroll.Location = new Point(551, 9);
      this.checkBox1Autoscroll.Name = "checkBox1Autoscroll";
      this.checkBox1Autoscroll.Size = new Size(72, 17);
      this.checkBox1Autoscroll.TabIndex = 4;
      this.checkBox1Autoscroll.Text = "Autoscroll";
      this.checkBox1Autoscroll.UseVisualStyleBackColor = false;
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.LightSteelBlue;
      this.label1.Location = new Point(317, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(50, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "Max ping";
      this.textBoxMaxChallengePing.Location = new Point(368, 6);
      this.textBoxMaxChallengePing.Maximum = new Decimal(new int[4]
      {
        999,
        0,
        0,
        0
      });
      this.textBoxMaxChallengePing.Name = "textBoxMaxChallengePing";
      this.textBoxMaxChallengePing.Size = new Size(40, 20);
      this.textBoxMaxChallengePing.TabIndex = 1;
      this.textBoxMaxChallengePing.Value = new Decimal(new int[4]
      {
        150,
        0,
        0,
        0
      });
      this.textBoxMaxChallengePing.ValueChanged += new EventHandler(this.numericMaxChallengePing_OnChange);
      this.panel1.BackColor = Color.LightSteelBlue;
      this.panel1.Controls.Add((Control) this.CMBX_GameSwitcher);
      this.panel1.Controls.Add((Control) this.RefreshMemberList);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.buttonReconnect);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.buttonTrain);
      this.panel1.Controls.Add((Control) this.buttonRestToggle);
      this.panel1.Controls.Add((Control) this.buttonRandVsWPing);
      this.panel1.Controls.Add((Control) this.textBoxMaxChallengePing);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.checkBox1Autoscroll);
      this.panel1.Controls.Add((Control) this.checkBoxDisableChat);
      this.panel1.Dock = DockStyle.Bottom;
      this.panel1.Location = new Point(0, 391);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(711, 33);
      this.panel1.TabIndex = 9;
      this.CMBX_GameSwitcher.DropDownStyle = ComboBoxStyle.DropDownList;
      this.CMBX_GameSwitcher.FormattingEnabled = true;
      this.CMBX_GameSwitcher.Location = new Point(417, 6);
      this.CMBX_GameSwitcher.Name = "CMBX_GameSwitcher";
      this.CMBX_GameSwitcher.Size = new Size(121, 21);
      this.CMBX_GameSwitcher.TabIndex = 14;
      this.CMBX_GameSwitcher.SelectionChangeCommitted += new EventHandler(this.CMBX_GameSwitcher_SelectionChangeCommitted);
      this.button2.Enabled = false;
      this.button2.Location = new Point(577, 23);
      this.button2.Name = "button2";
      this.button2.Size = new Size(75, 23);
      this.button2.TabIndex = 12;
      this.button2.Text = "TEST";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Visible = false;
      this.button2.Click += new EventHandler(this.TESTBUTTON_OnClick);
      this.General1SecTimer.Enabled = true;
      this.General1SecTimer.Interval = 1000;
      this.General1SecTimer.Tick += new EventHandler(this.General1SecTimer_Tick);
      this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
      this.notifyIcon1.Icon = (Icon) componentResourceManager.GetObject("notifyIcon1.Icon");
      this.notifyIcon1.Text = "Telepone";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
      this.Prize1HourTimer.Enabled = true;
      this.Prize1HourTimer.Interval = 3500000;
      this.Prize1HourTimer.Tick += new EventHandler(this.Prize1HourTimer_Tick);
      this.AllowDrop = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(711, 424);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.menuStrip1);
      this.Controls.Add((Control) this.panel1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      MainForm mainForm7 = this;
      MenuStrip menuStrip = mainForm7.menuStrip1;
      mainForm7.MainMenuStrip = menuStrip;
      this.Name = "MainForm";
      MainForm mainForm8 = this;
      // ISSUE: method pointer
      IntPtr method1 = __methodptr(MainForm_FormClosing);
      FormClosingEventHandler closingEventHandler = new FormClosingEventHandler((object) mainForm8, method1);
      mainForm8.FormClosing += closingEventHandler;
      MainForm mainForm9 = this;
      // ISSUE: method pointer
      IntPtr method2 = __methodptr(MainForm_FormClosed);
      FormClosedEventHandler closedEventHandler = new FormClosedEventHandler((object) mainForm9, method2);
      mainForm9.FormClosed += closedEventHandler;
      MainForm mainForm10 = this;
      // ISSUE: method pointer
      IntPtr method3 = __methodptr(MainForm_Load);
      EventHandler eventHandler1 = new EventHandler((object) mainForm10, method3);
      mainForm10.Load += eventHandler1;
      MainForm mainForm11 = this;
      // ISSUE: method pointer
      IntPtr method4 = __methodptr(MainForm_Shown);
      EventHandler eventHandler2 = new EventHandler((object) mainForm11, method4);
      mainForm11.Shown += eventHandler2;
      MainForm mainForm12 = this;
      // ISSUE: method pointer
      IntPtr method5 = __methodptr(MainForm_DragDrop);
      DragEventHandler dragEventHandler1 = new DragEventHandler((object) mainForm12, method5);
      mainForm12.DragDrop += dragEventHandler1;
      MainForm mainForm13 = this;
      // ISSUE: method pointer
      IntPtr method6 = __methodptr(MainForm_DragEnter);
      DragEventHandler dragEventHandler2 = new DragEventHandler((object) mainForm13, method6);
      mainForm13.DragEnter += dragEventHandler2;
      MainForm mainForm14 = this;
      // ISSUE: method pointer
      IntPtr method7 = __methodptr(HideProfile);
      EventHandler eventHandler3 = new EventHandler((object) mainForm14, method7);
      mainForm14.MouseLeave += eventHandler3;
      MainForm mainForm15 = this;
      // ISSUE: method pointer
      IntPtr method8 = __methodptr(MainForm_Resize);
      EventHandler eventHandler4 = new EventHandler((object) mainForm15, method8);
      mainForm15.Resize += eventHandler4;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      this.splitContainer1.EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.contextMenuStripMember.ResumeLayout(false);
      this.ProfileDisplayAnchored.EndInit();
      this.contextMenuStripLog.ResumeLayout(false);
      this.textBoxMaxChallengePing.EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private unsafe void Begin()
    {
      Random random = (Random) null;
      string str1 = (string) null;
      IPAddress[] ipAddressArray = (IPAddress[]) null;
      MainForm.ServerName = new string((char*) ((IntPtr) &Module.MTOPTION + 524));
      MainForm.ServerMode = (SERVER_MODE) 0;
      random = new Random((int) Module.timeGetTime());
      str1 = Dns.GetHostName();
      ipAddressArray = Dns.GetHostAddresses(Dns.GetHostName());
      MemberInfo memberInfo = new MemberInfo();
      memberInfo.IP_EP = new IPEndPoint(0L, 0);
      memberInfo.ID = (ushort) 0;
      memberInfo.NAME = new string((char*) ((IntPtr) &Module.MTOPTION + 3444));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      memberInfo.REGION = (PLAYER_REGION) ((IntPtr) &Module.MTOPTION + 3948);
      memberInfo.LOOKINGFOR = new string((char*) ((IntPtr) &Module.MTOPTION + 3618));
      memberInfo.NOTLOOKING = new string((char*) ((IntPtr) &Module.MTOPTION + 3728));
      memberInfo.COMMENT = new string((char*) ((IntPtr) &Module.MTOPTION + 3508));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      memberInfo.TYPE = (uint)  ((IntPtr) &Module.MTOPTION + 520);
      memberInfo.RESPONSE = Module.timeGetTime();
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      memberInfo.FAVPON = (FAVORITE_PONY) ( ((IntPtr) &Module.MTOPTION + 4076));
      memberInfo.SECURITYCODE = ulong.MaxValue;
      try
      {
        MainForm.MYRELATIONS = new USER_RELATIONS();
        MainForm.MYRELATIONS.LoadList("mtspfim_ignores.txt", (RELATION_TYPE) 0);
        MainForm.MYRELATIONS.LoadList("mtspfim_declines.txt", (RELATION_TYPE) 1);
        MainForm.MYRELATIONS.LoadList("bl.txt", (RELATION_TYPE) 2);
        MainForm.MYRELATIONS.LoadList(".\\files\\stats.pon", (RELATION_TYPE) 3);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show(string.Format("One or more relations files experienced a load error. \nRestarting the program is advised or settings may not save properly.\nIf you are running multiple instances of Telepone, this behavior is normal.", (object) ex.ToString()), "Error");
        Module.WriteErrorLog(ex.ToString(), "Relations loading 1");
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 520) == 0 && MainForm.ServerName.Length > 0)
      {
        if ((int) MainForm.ServerName[0] == 35)
        {
          MainForm.ServerMode = (SERVER_MODE) 3;
          MainForm.ListView = (LIST_VIEW) 2;
          memberInfo.NAME = "◆";
          memberInfo.COMMENT = string.Empty;
          MainForm.MemberList.Add(memberInfo);
          this.listBoxMember.Items.Add((object) "野試合会場");
        }
        else
        {
          MainForm.MemberList.Add(memberInfo);
          this.listBoxMember.Items.Add((object) memberInfo.NAME);
          if ((int) MainForm.ServerName[0] == 43)
            MainForm.ServerMode = (SERVER_MODE) 1;
          else if ((int) MainForm.ServerName[0] == 64)
            MainForm.ServerMode = (SERVER_MODE) 2;
        }
      }
      else
      {
        MainForm.MemberList.Add(memberInfo);
        this.listBoxMember.Items.Add((object) memberInfo.NAME);
      }
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 0 ||  ((IntPtr) &Module.MTOPTION + 520) == 1)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          MainForm.UDP = new UdpClient( ((IntPtr) &Module.MTOPTION + 3956));
        }
        else
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ( ((IntPtr) &Module.MTOPTION + 520) != 2)
            return;
          MainForm.UDP = new UdpClient();
        }
      }
      catch (SocketException ex)
      {
        MainForm.UDP = (UdpClient) null;
        if (ex.ErrorCode == 10048)
        {
          this.WriteMessage("Another application is using the specified open port.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        }
        else
        {
          this.WriteMessage(string.Format("Falied to initialize UDP ({0})\n", (object) ex.ErrorCode), MainForm.ErrorMessageColor, MSGOPT.NONE);
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((int)  @Module.MTINFO != 0)
            this.WriteMessage(ex.ToString() + "\n", MainForm.DebugMessageColor, MSGOPT.NONE);
        }
      }
      if (MainForm.UDP != null)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
        {
          MainForm.UDP.BeginReceive(new AsyncCallback(MainForm.ReceivePackets), (object) this);
          MainForm.Ranging = true;
          MainForm.SonarThread = new Thread(new ThreadStart(this.RunSonar));
          MainForm.SonarThread.Name = "Server sonar";
          MainForm.SonarThread.Start();
          MainForm mainForm = this;
          string str2 = mainForm.Text + string.Format("  [Server : {0}]", (object) MainForm.ServerName);
          mainForm.Text = str2;
          this.WriteMessage("Server setup complete.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
        }
        else
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          int port =  ((IntPtr) &Module.MTOPTION + 3952);
          char[] separator = new char[1]
          {
            ':'
          };
          string[] strArray = MainForm.ServerName.Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
          if (strArray.Length > 1)
          {
            try
            {
              port = Convert.ToInt32(strArray[1]);
            }
            catch (Exception ex)
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              port =  ((IntPtr) &Module.MTOPTION + 3952);
            }
          }
          long address;
          try
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int)  ((IntPtr) &Module.MTOPTION + 3960) != 0)
            {
              try
              {
                address = Dns.GetHostEntry(strArray[0]).AddressList[0].Address;
              }
              catch (Exception ex)
              {
                address = 0L;
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  @Module.MTINFO != 0)
                  this.WriteMessage(ex.ToString() + "\n", MainForm.DebugMessageColor, MSGOPT.NONE);
              }
            }
            else
              address = Module.DecryptionIP(strArray[0]);
            if (address == 0L)
            {
              this.WriteMessage("Couldn't find destination.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              throw new SocketException();
            }
            else
            {
              IPEndPoint remoteEP = new IPEndPoint(address, port);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              PacketPacker packetPacker = Module.PH_REQ_CONNECTION_Make((byte)  ((IntPtr) &Module.MTOPTION + 520), memberInfo.NAME, memberInfo.COMMENT, memberInfo.LOOKINGFOR, memberInfo.NOTLOOKING, (uint) memberInfo.FAVPON, (byte) memberInfo.REGION);
              if (MainForm.UDP == null)
                throw new NullReferenceException();
              MainForm.UDP.Send(packetPacker.Packet, packetPacker.Length, remoteEP);
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  @Module.MTINFO != 0)
                this.WriteMessage("Attempting connection.\n", MainForm.DebugMessageColor, MSGOPT.NONE);
              MainForm.UDP.Client.ReceiveTimeout = 3000;
              byte[] datagram = MainForm.UDP.Receive(ref remoteEP);
              MainForm.UDP.Client.ReceiveTimeout = 0;
              PacketDivider packetDivider = new PacketDivider(ref datagram);
              if ((int) packetDivider.Divide() != 4)
                throw new SocketException();
              int length1 = (int) packetDivider.Divide();
              MainForm.ServerName = Encoding.Unicode.GetString(packetDivider.Divide(length1));
              MainForm.MemberList[0].ID = BitConverter.ToUInt16(packetDivider.Divide(2), 0);
              if ((uint) MainForm.MemberList[0].ID > 16383U)
                throw new SocketException();
              MemberInfo info = new MemberInfo();
              info.IP_EP = remoteEP;
              info.ID = (ushort) 0;
              info.TYPE = 0U;
              info.NUM_VS = 0U;
              info.RESPONSE = Module.timeGetTime();
              int length2 = (int) packetDivider.Divide();
              info.NAME = Encoding.Unicode.GetString(packetDivider.Divide(length2));
              int length3 = (int) packetDivider.Divide();
              info.COMMENT = Encoding.Unicode.GetString(packetDivider.Divide(length3));
              info.STATE = (uint) packetDivider.Divide();
              if (packetDivider.HasMore())
              {
                int num = (int) packetDivider.Divide();
              }
              if (packetDivider.HasMore())
                info.REGION = (PLAYER_REGION) packetDivider.Divide();
              if (packetDivider.HasMore())
              {
                int length4 = (int) packetDivider.Divide();
                info.LOOKINGFOR = Encoding.Unicode.GetString(packetDivider.Divide(length4));
              }
              if (packetDivider.HasMore())
              {
                int length4 = (int) packetDivider.Divide();
                info.NOTLOOKING = Encoding.Unicode.GetString(packetDivider.Divide(length4));
              }
              MainForm.MemberList.Add(info);
              this.AddListView(ref info);
              MainForm.UDP.BeginReceive(new AsyncCallback(MainForm.ReceivePackets), (object) this);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ( ((IntPtr) &Module.MTOPTION + 520) == 1)
              {
                MainForm mainForm = this;
                string str2 = mainForm.Text + string.Format(" [ Connected as host-> {0 }]", (object) MainForm.ServerName);
                mainForm.Text = str2;
              }
              else
              {
                MainForm mainForm = this;
                string str2 = mainForm.Text + string.Format(" [ Connected as client-> {0} ]", (object) MainForm.ServerName);
                mainForm.Text = str2;
              }
              this.WriteMessage(string.Format("Connected to {0} (ID = {1})\n", (object) MainForm.ServerName, (object) memberInfo.ID), MainForm.SystemMessageColor, MSGOPT.NONE);
              if (MainForm.ServerName.Length > 0)
              {
                if ((int) MainForm.ServerName[0] == 43)
                {
                  MainForm.ServerMode = (SERVER_MODE) 1;
                  this.WriteMessage("This server is mixed.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                }
                if ((int) MainForm.ServerName[0] == 64)
                {
                  MainForm.ServerMode = (SERVER_MODE) 2;
                  this.WriteMessage("This is a no-chat server.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                }
                else if ((int) MainForm.ServerName[0] == 35)
                {
                  MainForm.ServerMode = (SERVER_MODE) 3;
                  this.WriteMessage("Whee! NORA server! \n", MainForm.SystemMessageColor, MSGOPT.NONE);
                  MainForm.ListView = (LIST_VIEW) 2;
                  this.listBoxMember.Items[0] = (object) "野試合会場";
                }
              }
              byte[] numArray = Module.PH_REQ_LIST_Make((ushort) 0);
              UdpClient udpClient = MainForm.UDP;
              byte[] dgram = numArray;
              int length5 = dgram.Length;
              IPEndPoint endPoint = remoteEP;
              udpClient.Send(dgram, length5, endPoint);
              MainForm.Ranging = true;
              MainForm.SonarThread = new Thread(new ThreadStart(this.RunSonar));
              MainForm.SonarThread.Name = "Client sonar";
              MainForm.SonarThread.Start();
              Module.Sleep(75U);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  ((IntPtr) &Module.MTOPTION + 4031) != 0)
                this.ChangeState((object) 1);
              else
                this.ChangeState((object) 0);
            }
          }
          catch (SocketException ex)
          {
            this.Leave(false);
            if (ex.ErrorCode == 0)
            {
              if ((int) memberInfo.ID == (int) ushort.MaxValue)
                this.WriteMessage(string.Format("Server \"{0}\" is full.\n", (object) MainForm.ServerName), MainForm.ErrorMessageColor, MSGOPT.NONE);
              else if ((int) memberInfo.ID == 65534)
                this.WriteMessage("Server / client versions are different.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              else if ((int) memberInfo.ID == 65533)
                this.WriteMessage("You have been banned.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              else if ((int) memberInfo.ID == 65532)
                this.WriteMessage("Your connection has been throttled for 30 seconds for connecting too many times.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              else if ((uint) memberInfo.ID > 16383U)
              {
                this.WriteMessage(string.Format("ID too high for server {0}.\n", (object) MainForm.ServerName), MainForm.ErrorMessageColor, MSGOPT.NONE);
              }
              else
              {
                if (address == 0L)
                  return;
                this.WriteMessage("Couldn't connect to server.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              }
            }
            else
            {
              if (ex.ErrorCode == 10054)
                this.WriteMessage("Server port is not open.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              else if (ex.ErrorCode == 10060)
                this.WriteMessage("No response from server.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              else if (ex.ErrorCode != 11001)
                this.WriteMessage(string.Format("Socket error: {0}\n", (object) ex.ErrorCode), MainForm.ErrorMessageColor, MSGOPT.NONE);
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  @Module.MTINFO == 0)
                return;
              this.WriteMessage(ex.ToString() + "\n", MainForm.DebugMessageColor, MSGOPT.NONE);
            }
          }
          catch (NullReferenceException ex)
          {
            this.WriteMessage(ex.ToString() + "\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
          }
        }
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) != 3)
        {
          this.Leave(false);
        }
        else
        {
          MainForm mainForm = this;
          string str2 = mainForm.Text + "Telepone [Free Play]";
          mainForm.Text = str2;
        }
      }
    }

    private unsafe void RunSonar()
    {
      int num1 = 0;
      bool flag = false;
      byte[] numArray1 = new byte[3]
      {
        (byte) 13,
        (byte) 0,
        (byte) 0
      };
      MainForm.SonarSleeping = false;
      while (MainForm.Ranging)
      {
        MainForm.SonarSleeping = true;
        try
        {
          Thread.Sleep(20000);
        }
        catch (ThreadInterruptedException ex)
        {
        }
        MainForm.SonarSleeping = false;
        ++num1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) != 0 && MainForm.UDP != null)
        {
          if (Monitor.TryEnter((object) MainForm.MemberList, 300))
          {
            try
            {
              byte[] numArray2 = new byte[1]
              {
                (byte) 0
              };
              int index = 0;
              List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
              while (enumerator.MoveNext())
              {
                MemberInfo current = enumerator.Current;
                if (index <= 1)
                {
                  ++index;
                }
                else
                {
                  UdpClient udpClient = MainForm.UDP;
                  byte[] dgram = numArray2;
                  int length = dgram.Length;
                  IPEndPoint endPoint = MainForm.MemberList[index].IP_EP;
                  udpClient.Send(dgram, length, endPoint);
                  current.SILENTPINGTIME = Module.timeGetTime();
                  ++index;
                }
              }
            }
            catch (SocketException ex)
            {
              MainForm.UDP = (UdpClient) null;
              MainForm.SonarThread.Abort();
            }
            finally
            {
              Monitor.Exit((object) MainForm.MemberList);
            }
          }
          if ((num1 & 5) == 5)
          {
            if (Monitor.TryEnter((object) MainForm.MemberList, 300))
            {
              try
              {
                this.RequestServerMemberList(MainForm.MemberList[1].IP_EP);
              }
              finally
              {
                Monitor.Exit((object) MainForm.MemberList);
              }
            }
          }
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((uint)  ((IntPtr) &Module.MTOPTION + 3964) > 0U && (Module.timeGetTime() - MainForm.MemberList[0].RESPONSE) / 60000U >= (uint)  ((IntPtr) &Module.MTOPTION + 3964))
        {
          string path = new string((char*) &Module.MTOPTION) + "auto.log";
          Monitor.Enter((object) MainForm.ChatHistory);
          try
          {
            this.richTextBoxLog.SaveFile(path, RichTextBoxStreamType.PlainText);
          }
          catch (Exception ex)
          {
            Module.WriteErrorLog(ex.ToString(), "SaveLog");
          }
          finally
          {
            Monitor.Exit((object) MainForm.ChatHistory);
          }
          MainForm.MemberList[0].RESPONSE = Module.timeGetTime();
        }
        if (!MainForm.Ranging)
          return;
        if (Monitor.TryEnter((object) MainForm.MemberList, 1000))
        {
          try
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
            {
              this.listBoxMember.BeginUpdate();
              for (int index1 = 1; index1 < MainForm.MemberList.Count; ++index1)
              {
                Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[index1].ID), 0, (Array) numArray1, 1, 2);
                if (Module.timeGetTime() - MainForm.MemberList[index1].RESPONSE <= 100000U)
                  goto label_37;
                this.WriteMessage("Connection with " + MainForm.MemberList[index1].NAME + " ended.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                numArray1[0] = (byte) 11;
                for (int index2 = 1; index2 < MainForm.MemberList.Count; ++index2)
                {
                  if (MainForm.UDP == null)
                    continue;
                  UdpClient udpClient1 = MainForm.UDP;
                  byte[] datagram = numArray1;
                  int length = datagram.Length;
                  IPEndPoint endPoint = MainForm.MemberList[index2].IP_EP;
                  AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                  UdpClient udpClient2 = MainForm.UDP;
                  udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
                }
                MainForm.MemberList.RemoveAt(index1);
                this.listBoxMember.Items.RemoveAt(index1);
                numArray1[0] = (byte) 13;
                --index1;
                continue;
label_37:
                if (MainForm.UDP != null)
                {
                  UdpClient udpClient1 = MainForm.UDP;
                  byte[] datagram = numArray1;
                  int length = datagram.Length;
                  IPEndPoint endPoint = MainForm.MemberList[index1].IP_EP;
                  AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                  UdpClient udpClient2 = MainForm.UDP;
                  udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
                }
              }
              this.listBoxMember.EndUpdate();
            }
            else if (MainForm.MemberList.Count >= 2)
            {
              if (Module.timeGetTime() - MainForm.MemberList[1].RESPONSE > 100000U)
              {
                this.WriteMessage("Connection with server ended.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                flag = true;
                MainForm.Ranging = false;
              }
              else
              {
                try
                {
                  if (MainForm.UDP != null)
                  {
                    UdpClient udpClient = MainForm.UDP;
                    byte[] dgram = numArray1;
                    int length = dgram.Length;
                    IPEndPoint endPoint = MainForm.MemberList[1].IP_EP;
                    udpClient.Send(dgram, length, endPoint);
                  }
                }
                catch (SocketException ex)
                {
                  int num2 = (int) MessageBox.Show("Connection with server lost.", "Error");
                }
                catch (NullReferenceException ex)
                {
                }
                catch (ObjectDisposedException ex)
                {
                }
              }
            }
          }
          finally
          {
            Monitor.Exit((object) MainForm.MemberList);
          }
        }
      }
      if (!flag)
        return;
      this.Leave(false);
    }

    private unsafe void RunGame(object obj)
    {
      uint num1 = (uint) obj;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      bool flag1 = (bool)  ((IntPtr) &Module.MTOPTION + 4028);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      bool @as = (bool)  ((IntPtr) &Module.MTOPTION + 4029);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      uint num2 = (uint)  ((IntPtr) &Module.MTOPTION + 3996);
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((int)  @Module.MTINFO != 0)
        this.WriteMessage(string.Format("RunGame(run_type: {0})\n", (object) num1.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      if (this.ProfileDisplayAnchored != null)
        this.ProfileDisplayAnchored.Deactivate();
      if ((int) num1 == 2)
      {
        MainForm.NetVS.INTERVAL = 0U;
        MainForm.NetVS.INTERVAL2 = 0U;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((uint)  ((IntPtr) &Module.MTOPTION + 4016) > 0U)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ( ((IntPtr) &Module.MTOPTION + 4016) == 1)
          {
            VersusInfo versusInfo = MainForm.NetVS;
            int num3 = (int) ((versusInfo.DELAY + 1U) / 4U);
            versusInfo.INTERVAL = (uint) num3;
            if ((int) MainForm.NetVS.INTERVAL == 1)
            {
              switch (MainForm.NetVS.DELAY - 3U)
              {
                case 0U:
                  MainForm.NetVS.INTERVAL = 0U;
                  break;
                case 1U:
                  MainForm.NetVS.INTERVAL2 = 5U;
                  break;
                case 2U:
                case 3U:
                  MainForm.NetVS.INTERVAL2 = 3U;
                  break;
              }
            }
          }
          else
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ( ((IntPtr) &Module.MTOPTION + 4016) == 2)
            {
              VersusInfo versusInfo = MainForm.NetVS;
              int num3 = (int) ((versusInfo.DELAY + 1U) / 3U);
              versusInfo.INTERVAL = (uint) num3;
              if ((int) MainForm.NetVS.INTERVAL == 1)
              {
                uint num4 = MainForm.NetVS.DELAY;
                if ((int) num4 != 2)
                {
                  if (num4 > 2U && num4 <= 4U)
                    MainForm.NetVS.INTERVAL2 = 4U;
                }
                else
                  MainForm.NetVS.INTERVAL = 0U;
              }
            }
            else
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ( ((IntPtr) &Module.MTOPTION + 4016) == 3)
              {
                VersusInfo versusInfo = MainForm.NetVS;
                int num3 = (int) ((versusInfo.DELAY + 1U) / 2U);
                versusInfo.INTERVAL = (uint) num3;
                if ((int) MainForm.NetVS.INTERVAL == 1)
                  MainForm.NetVS.INTERVAL2 = 3U;
              }
            }
          }
        }
      }
      void* voidPtr =  0;
      DateTime now1 = DateTime.Now;
      uint num5 = 0U;
      uint time1 = Module.timeGetTime();
      uint num6 = 0U;
      uint num7 = 0U;
      uint num8 = 0U;
      uint num9 = 0U;
      uint num10 = 0U;
      uint num11 = 0U;
      int num12 = 0;
      int num13 = 0;
      int wins = 0;
      int losses = 0;
      int num14 = 0;
      int num15 = 0;
      bool flag2 = true;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTINFO + 2) = (sbyte) 0;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTINFO + 3) = (sbyte) 0;
      Module.memset( ((IntPtr) &Module.MTINFO + 170), 0, 512U);
      Module.memset( ((IntPtr) &Module.MTINFO + 682), 0, 512U);
      BinaryWriter bw = (BinaryWriter) null;
      BinaryReader br = (BinaryReader) null;
      _REPLAY_INFO replayInfo;
      Module._REPLAY_INFOctor(&replayInfo);
      byte num16 = (byte) 0;
      dequeunsignedshortstdallocatorunsignedshort allocatorUnsignedShort;
      // ISSUE: fault handler
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &replayInfo + 2) = (sbyte) 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        ((IntPtr) &replayInfo + 6) = (short) -1;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &replayInfo + 4) = (short)  ((IntPtr) &replayInfo + 6);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &replayInfo + 9) = (sbyte) 0;
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &replayInfo + 8) = (sbyte)  ((IntPtr) &replayInfo + 9);
        Module.stddequeunsignedshortstdallocatorunsignedshortctor(&allocatorUnsignedShort);
        byte num3 = (byte) 0;
        // ISSUE: fault handler
        try
        {
          if ((int) num1 == 1 && num2 > 0U)
          {
            for (uint index = 0U; index < num2; ++index)
            {
              ushort num4 = (ushort) 0;
              Module.stddequeunsignedshortstdallocatorunsignedshortpush_back(&allocatorUnsignedShort, &num4);
            }
          }
          try
          {
            char[] chars = new char[5]
            {
              'T',
              'Y',
              'M',
              'T',
              'R'
            };
            if ((int) num1 == 3)
            {
              Replay replay = new Replay(MainForm.ReplayFilePath, false);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &replayInfo + 12) = (int) replay.GetFileEndPos();
              br = new BinaryReader((Stream) System.IO.File.OpenRead(MainForm.ReplayFilePath));
              br.ReadChars(chars.Length);
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               @replayInfo = (short) br.ReadChar();
              byte num4 = br.ReadByte();
              for (int index = 0; index < (int) num4; ++index)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 42 + index * 2) = (short) br.ReadChar();
              }
              byte num17 = br.ReadByte();
              for (int index = 0; index < (int) num17; ++index)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 106 + index * 2) = (short) br.ReadChar();
              }
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTINFO + 8) = (int) br.ReadUInt32();
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  @replayInfo >= 51)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 12) = (int) br.ReadByte();
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 16) = (int) br.ReadByte();
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 20) = (int) br.ReadByte();
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 24) = (int) br.ReadByte();
              }
              else
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 12) =  ((IntPtr) &Module.MTOPTION + 3980);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 16) =  ((IntPtr) &Module.MTOPTION + 3984);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 20) =  ((IntPtr) &Module.MTOPTION + 3988);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 24) =  ((IntPtr) &Module.MTOPTION + 3992);
              }
            }
            else if (flag1)
            {
              string path1 = new string((char*) ((IntPtr) &Module.MTOPTION + 1364));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  ((IntPtr) &Module.MTOPTION + 4005) != 0)
                path1 = path1 + "\\" + Path.GetFileNameWithoutExtension(new string((char*) ((IntPtr) &Module.MTOPTION + 844)));
              if (!Directory.Exists(path1))
                Directory.CreateDirectory(path1);
              string str1;
              if ((int) num1 == 2)
              {
                if (MainForm.ListView == (LIST_VIEW) 2)
                {
                  str1 = string.Format("vs_{0}.mtr", (object) DateTime.Now.ToString("yyMMdd-HHmmss"));
                }
                else
                {
                  DateTime now2 = DateTime.Now;
                  str1 = string.Format("{0}_vs_{1}_{2}.mtr", (object) new string((char*) ((IntPtr) &Module.MTINFO + 42)), (object) new string((char*) ((IntPtr) &Module.MTINFO + 106)), (object) now2.ToString("yyMMdd-HHmmss"));
                }
              }
              else
              {
                DateTime now2 = DateTime.Now;
                str1 = string.Format("{0}_{1}.mtr", (object) new string((char*) ((IntPtr) &Module.MTINFO + 42)), (object) now2.ToString("yyMMdd-HHmmss"));
              }
              string str2 = path1 + "\\";
              string path2 = path1 + "\\" + str1;
              try
              {
                bw = new BinaryWriter((Stream) System.IO.File.Create(path2));
              }
              catch (ArgumentException ex)
              {
                this.WriteMessage("Illegal characters in player name. Couldn't create proper name for replay file.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                DateTime now2 = DateTime.Now;
                path2 = str2 + "\\" + string.Format("invalidpath_{0}.mtr", (object) now2.ToString("yyMMdd-HHmmss"));
                bw = new BinaryWriter((Stream) System.IO.File.Create(path2));
              }
              MainForm.LastReplayPath = path2;
              this.WriteMessage(string.Format("Replay \"{0}\" created.\n", (object) str1), MainForm.SystemMessageColor, MSGOPT.NONE);
              bw.Write(chars);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ( ((IntPtr) &Module.MTOPTION + 4020) == 1)
              {
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 @replayInfo = (short) 51;
              }
              else
              {
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 @replayInfo = (short) 52;
              }
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((char)  @replayInfo);
              byte num4 = (byte) Module.wcslen((char*) ((IntPtr) &Module.MTINFO + 42));
              bw.Write(num4);
              for (int index = 0; index < (int) num4; ++index)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                bw.Write((char)  ((IntPtr) &Module.MTINFO + 42 + index * 2));
              }
              byte num17 = (byte) Module.wcslen((char*) ((IntPtr) &Module.MTINFO + 106));
              bw.Write(num17);
              for (int index = 0; index < (int) num17; ++index)
              {
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                bw.Write((char)  ((IntPtr) &Module.MTINFO + 106 + index * 2));
              }
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((uint)  ((IntPtr) &Module.MTINFO + 8));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((byte)  ((IntPtr) &Module.MTINFO + 12));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((byte)  ((IntPtr) &Module.MTINFO + 16));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((byte)  ((IntPtr) &Module.MTINFO + 20));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((byte)  ((IntPtr) &Module.MTINFO + 24));
            }
          }
          catch (IOException ex)
          {
            this.WriteMessage(string.Format("ERROR > Replay file \n{0}\n", (object) ex.ToString()), MainForm.ErrorMessageColor, MSGOPT.NONE);
            if (bw != null)
            {
              bw.Close();
              bw = (BinaryWriter) null;
            }
          }
          int num18 = (int) Module.wcslen((char*) ((IntPtr) &Module.MTINFO + 42));
          int num19 = (int) Module.wcslen((char*) ((IntPtr) &Module.MTINFO + 106));
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          int num20 = (int) Module.RandomStage((uint)  ((IntPtr) &Module.MTINFO + 8));
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((uint)  ((IntPtr) &Module.MTINFO + 16) > (uint)  ((IntPtr) &Module.MTINFO + 12))
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            num6 = (uint)  ((IntPtr) &Module.MTINFO + 12);
          }
          if (@as)
          {
            MainForm.AllowWatch = false;
            MainForm.InputFrame = 0U;
            MainForm.SpectacleThread = new Thread(new ThreadStart(this.RunSpectacle));
            MainForm.SpectacleThread.Name = "SpecThread";
            MainForm.SpectacleThread.Priority = ThreadPriority.AboveNormal;
            MainForm.SpectacleThread.Start();
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int)  @Module.MTINFO != 0)
              this.WriteMessage("RunGame() >> SPEC THREAD STARTED\n", MainForm.DebugMessageColor, MSGOPT.NONE);
          }
          if ((int) num1 != 4)
            this.ChangeState((object) 2);
          _PROCESS_INFORMATION processInformation;
          try
          {
            try
            {
              _STARTUPINFOW startupinfow;
              Module.memset( &startupinfow, 0, 68U);
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               @startupinfow = 68;
              ArrayTypeBY02_W arrayTypeBy02W;
              ArrayTypeBY0BAE_W arrayTypeBy0BaEW1;
              Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy02W, 3U, (char*) &arrayTypeBy0BaEW1, 256U, (char*) 0, 0U, (char*) 0, 0U);
              ArrayTypeBY0BAE_W arrayTypeBy0BaEW2;
              Module.swprintf_s260(&arrayTypeBy0BaEW2, (char*) &Module.A0x21959a7bunnamedglobal8, __arglist (out arrayTypeBy02W, out arrayTypeBy0BaEW1));
              if (Module.CreateProcessW((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) 0, (_SECURITY_ATTRIBUTES*) 0, (_SECURITY_ATTRIBUTES*) 0, 0, 1U,  0, (char*) &arrayTypeBy0BaEW2, &startupinfow, &processInformation) != 0)
              {
                if ((int) num1 == 3)
                  this.WriteMessage(string.Format("Replaying \"{0}\".\n", (object) Path.GetFileName(MainForm.ReplayFilePath)), MainForm.SystemMessageColor, MSGOPT.NONE);
                else
                  this.WriteMessage(string.Format("\"{0}\" started.\n", (object) Path.GetFileNameWithoutExtension(new string((char*) ((IntPtr) &Module.MTOPTION + 844)))), MainForm.SystemMessageColor, MSGOPT.NONE);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 28) =  @processInformation;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 32) =  ((IntPtr) &processInformation + 8);
                _DEBUG_EVENT debugEvent;
                while (Module.WaitForDebugEvent(&debugEvent, uint.MaxValue) != 0)
                {
                  uint num4 = 65538U;
                  uint num17;
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  switch ((uint)  @debugEvent - 1U)
                  {
                    case 0U:
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      uint num21 = (uint)  ((IntPtr) &debugEvent + 12);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      uint num22 = (uint)  ((IntPtr) &debugEvent + 24);
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0 && num15 < 10)
                      {
                        this.WriteMessage(string.Format("Debug event: code:{0:X}  address:{1:X}  blits:{2}\n", (object) num21, (object) num22, (object) num7), MainForm.DebugMessageColor, MSGOPT.NONE);
                        ++num15;
                      }
                      if ((int) num21 == -1073741819)
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        uint num23 = (uint)  ((IntPtr) &debugEvent + 32);
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        uint num24 = (uint)  ((IntPtr) &debugEvent + 36);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ((int)  @Module.MTINFO != 0)
                        {
                          object[] objArray = new object[4]
                          {
                            (object) num21,
                            (object) num22,
                            null,
                            null
                          };
                          string str = (int) num23 == 0 ? "write" : "read";
                          objArray[2] = (object) str;
                          objArray[3] = (object) num24;
                          this.WriteMessage(string.Format("EXCEPTION_ACCESS_VIOLATION > {0:X8}@{1:X8} : {2}@{3:X8}\n", objArray), MainForm.DebugMessageColor, MSGOPT.NONE);
                        }
                        this.ThrottledWriteMessage(string.Format("An unknown exception has occurred: code:{0:X}  address:{1:X}\n", (object) num21, (object) num22), MainForm.ErrorMessageColor, MSGOPT.NONE);
                        num4 = 2147549185U;
                      }
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int) num21 == -2147483645 &&  ((IntPtr) &debugEvent + 8) == (int) num5)
                      {
                        uint num23 = num22;
                        _CONTEXT context;
                        if (num23 <= 4231216U)
                        {
                          if ((int) num23 != 4231216)
                          {
                            if (num23 <= 4213815U)
                            {
                              if ((int) num23 != 4213815)
                              {
                                if (num23 <= 4207742U)
                                {
                                  if ((int) num23 != 4207742 && (int) num23 != 4202562)
                                  {
                                    if ((int) num23 != 4202576)
                                    {
                                      if ((int) num23 == 4205107)
                                      {
                                        // ISSUE: explicit reference operation
                                        // ISSUE: cast to a reference type
                                        // ISSUE: explicit reference operation
                                         @context = 65538;
                                        Module.GetThreadContext(voidPtr, &context);
                                        // ISSUE: cast to a reference type
                                        // ISSUE: explicit reference operation
                                         ((IntPtr) &context + 176) = 0;
                                        Module.SetThreadContext(voidPtr, &context);
                                        break;
                                      }
                                      else
                                        break;
                                    }
                                  }
                                  else
                                  {
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     @context = 65538;
                                    Module.GetThreadContext(voidPtr, &context);
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     ((IntPtr) &context + 168) =  ((IntPtr) &Module.MTINFO + 1196 + (int) ((uint)  ((IntPtr) &Module.MTOPTION + 3972) / 5U) * 4);
                                    Module.SetThreadContext(voidPtr, &context);
                                    break;
                                  }
                                }
                                else if ((int) num23 != 4207756)
                                {
                                  if ((int) num23 == 4212569)
                                    goto label_221;
                                  else
                                    break;
                                }
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 @context = 65538;
                                Module.GetThreadContext(voidPtr, &context);
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 ((IntPtr) &context + 168) =  ((IntPtr) &Module.MTINFO + 1196 + (int) ((uint)  ((IntPtr) &Module.MTOPTION + 3976) / 5U) * 4);
                                Module.SetThreadContext(voidPtr, &context);
                                break;
                              }
label_221:
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               @context = 65538;
                              Module.GetThreadContext(voidPtr, &context);
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 160) =  ((IntPtr) &context + 176);
                              Module.SetThreadContext(voidPtr, &context);
                              ++num7;
                              uint time2 = Module.timeGetTime();
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              if ((int)  ((IntPtr) &Module.MTOPTION + 4044) != 0 && MainForm.NetVS != null && MainForm.NetVS.L_FRAME > (uint) ( ((IntPtr) &Module.MTOPTION + 4072) + 20))
                              {
                                bool flag3 = false;
                                List<MainForm.SpectatorInfo>.Enumerator enumerator = MainForm.SpectatorList.GetEnumerator();
                                while (enumerator.MoveNext())
                                {
                                  MainForm.SpectatorInfo current = enumerator.Current;
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  if (MainForm.NetVS.L_FRAME - (uint)  ((IntPtr) &Module.MTOPTION + 4072) > MainForm.NetVS.L_FRAME - current.FRAME)
                                    flag3 = true;
                                }
                                if (flag3)
                                {
                                  this.ThrottledWriteMessage("Waiting for spectators.", MainForm.DebugMessageColor, MSGOPT.NONE);
                                  Thread.Sleep(55);
                                }
                              }
                              if (MainForm.NetVS != null && (int) (MainForm.NetVS.L_FRAME % 1500U) == 0 && ((int) MainForm.NetVS.L_FRAME != 0 && MainForm.UDP != null) && (int) num1 == 2)
                              {
                                int p1x;
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                Module.ReadProcessMemory(  @processInformation,  5110976,  &p1x, 4U, (uint*) 0);
                                int p1y;
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                Module.ReadProcessMemory(  @processInformation,  5110980,  &p1y, 4U, (uint*) 0);
                                int p2x;
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                Module.ReadProcessMemory(  @processInformation,  5168384,  &p2x, 4U, (uint*) 0);
                                int p2y;
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                Module.ReadProcessMemory(  @processInformation,  5168388,  &p2y, 4U, (uint*) 0);
                                byte[] numArray = Module.PH_SYNC_CHECK_Make((int) MainForm.NetVS.L_FRAME, p1x, p1y, p2x, p2y);
                                UdpClient udpClient = MainForm.UDP;
                                byte[] dgram = numArray;
                                int length = dgram.Length;
                                IPEndPoint endPoint = MainForm.NetVS.IP_EP;
                                udpClient.Send(dgram, length, endPoint);
                                VersusInfo versusInfo = MainForm.NetVS;
                                int num24 = (int) versusInfo.L_FRAME;
                                versusInfo.LastSyncFrame = num24;
                                MainForm.NetVS.P1Pos.X = p1x;
                                MainForm.NetVS.P1Pos.Y = p1y;
                                MainForm.NetVS.P2Pos.X = p2x;
                                MainForm.NetVS.P2Pos.Y = p2y;
                              }
                              if (time2 - num10 >= 1000U)
                              {
                                num10 = time2;
                                int num24 = 0;
                                Module.wcscpy_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) ((IntPtr) &Module.MTINFO + 170));
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  ((IntPtr) &Module.MTOPTION + 4001) != 0)
                                {
                                  // ISSUE: cast to a reference type
                                  // ISSUE: cast to a reference type
                                  // ISSUE: cast to a reference type
                                  // ISSUE: cast to a reference type
                                  // ISSUE: cast to a reference type
                                  // ISSUE: cast to a reference type
                                  num24 = num18 != 0 || num19 != 0 ? (num19 != 0 ? Module.swprintf_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) &Module.A0x21959a7bunnamedglobal11, __arglist ( ((IntPtr) &Module.MTINFO + 682),  ((IntPtr) &Module.MTINFO + 42),  ((IntPtr) &Module.MTINFO + 106))) : Module.swprintf_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) &Module.A0x21959a7bunnamedglobal10, __arglist ( ((IntPtr) &Module.MTINFO + 682),  ((IntPtr) &Module.MTINFO + 42)))) : Module.swprintf_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) &Module.A0x21959a7bunnamedglobal9, __arglist ( ((IntPtr) &Module.MTINFO + 682)));
                                }
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  ((IntPtr) &Module.MTOPTION + 4002) != 0)
                                {
                                  // ISSUE: cast to a reference type
                                  num24 = Module.swprintf_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) &Module.A0x21959a7bunnamedglobal12, __arglist ( ((IntPtr) &Module.MTINFO + 682), num13, wins, losses));
                                }
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  ((IntPtr) &Module.MTOPTION + 4003) != 0)
                                {
                                  // ISSUE: cast to a reference type
                                  num24 = Module.swprintf_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) &Module.A0x21959a7bunnamedglobal13, __arglist ( ((IntPtr) &Module.MTINFO + 682), (int) num7, (int) num8));
                                }
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  ((IntPtr) &Module.MTOPTION + 4004) != 0)
                                {
                                  // ISSUE: cast to a reference type
                                  num24 = Module.swprintf_s256((ArrayTypeBY0BAA_W*) ((IntPtr) &Module.MTINFO + 682), (char*) &Module.A0x21959a7bunnamedglobal14, __arglist ( ((IntPtr) &Module.MTINFO + 682), (int) num9));
                                }
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if (num7 < (uint)  ((IntPtr) &Module.MTOPTION + 4064) && (int)  ((IntPtr) &Module.MTOPTION + 4038) != 0 && (time2 - time1 > 4000U && time2 - num11 > 3000U))
                                {
                                  num11 = time2;
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  Thread.Sleep( ((IntPtr) &Module.MTOPTION + 4060));
                                  // ISSUE: explicit reference operation
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  if ((int)  @Module.MTINFO != 0)
                                  {
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    this.WriteMessage(string.Format("Sleeping {0}.\n", (object) (uint)  ((IntPtr) &Module.MTOPTION + 4060)), MainForm.DebugMessageColor, MSGOPT.NONE);
                                  }
                                }
                                num7 = 0U;
                                num8 = 0U;
                                num9 = 0U;
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if (num24 > 0 || num12 > 0 ||  ((IntPtr) &Module.MTINFO + 36) == 0)
                                {
                                  num12 = num24;
                                  new Thread(new ThreadStart(Module.SetCaption))
                                  {
                                    Name = "CaptionSet thread"
                                  }.Start();
                                  break;
                                }
                                else
                                  break;
                              }
                              else
                                break;
                            }
                            else if (num23 <= 4228950U)
                            {
                              if ((int) num23 != 4228950)
                              {
                                if ((int) num23 != 4218937)
                                {
                                  if ((int) num23 == 4219638)
                                  {
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     @context = 65539;
                                    Module.GetThreadContext(voidPtr, &context);
                                    tagMSG tagMsg;
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     @tagMsg =  ((IntPtr) &context + 176);
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     ((IntPtr) &tagMsg + 4) =  ((IntPtr) &context + 160);
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     ((IntPtr) &tagMsg + 8) =  ((IntPtr) &context + 168);
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     ((IntPtr) &tagMsg + 12) =  ((IntPtr) &context + 172);
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    switch ((uint)  ((IntPtr) &tagMsg + 4) - 161U)
                                    {
                                      case 0U:
                                      case 3U:
                                      case 6U:
                                      case 10U:
                                        if (MainForm.UDP != null && MainForm.NetVS != null && MainForm.NetVS.L_FRAME > 400U)
                                        {
                                          byte[] numArray = Module.PH_VS_EVENT_Make(VS_EVENT.NCPUSH);
                                          UdpClient udpClient = MainForm.UDP;
                                          byte[] dgram = numArray;
                                          int length = dgram.Length;
                                          IPEndPoint endPoint = MainForm.NetVS.IP_EP;
                                          udpClient.Send(dgram, length, endPoint);
                                          break;
                                        }
                                        else
                                          break;
                                    }
                                    Module.AsmPushEcx(&context, &processInformation);
                                    Module.SetThreadContext(voidPtr, &context);
                                    break;
                                  }
                                  else
                                    break;
                                }
                                else
                                {
                                  // ISSUE: explicit reference operation
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                   @context = 65539;
                                  Module.GetThreadContext(voidPtr, &context);
                                  Module.AsmPushEdi(&context, &processInformation);
                                  if (MainForm.UDP != null && MainForm.NetVS != null && MainForm.NetVS.L_FRAME > 400U)
                                  {
                                    byte[] numArray = Module.PH_VS_EVENT_Make(VS_EVENT.WND_MOVE);
                                    UdpClient udpClient = MainForm.UDP;
                                    byte[] dgram = numArray;
                                    int length = dgram.Length;
                                    IPEndPoint endPoint = MainForm.NetVS.IP_EP;
                                    udpClient.Send(dgram, length, endPoint);
                                  }
                                  Module.SetThreadContext(voidPtr, &context);
                                  break;
                                }
                              }
                            }
                            else if ((int) num23 != 4229503)
                            {
                              if ((int) num23 == 4231196)
                                goto label_192;
                              else
                                break;
                            }
                            else
                            {
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               @context = 65538;
                              Module.GetThreadContext(voidPtr, &context);
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 176) =  ((IntPtr) &context + 176) + 1;
                              Module.SetThreadContext(voidPtr, &context);
                              if ((int) num1 == 2)
                                Module.Sleep(200U);
                              if (flag2)
                              {
                                ++num13;
                                flag2 = false;
                                break;
                              }
                              else
                                break;
                            }
                          }
                          else
                            goto label_191;
                        }
                        else if (num23 <= 4278034U)
                        {
                          if ((int) num23 != 4278034)
                          {
                            if (num23 <= 4265516U)
                            {
                              if ((int) num23 != 4265516)
                              {
                                if ((int) num23 != 4231244)
                                {
                                  if ((int) num23 != 4231256)
                                  {
                                    if ((int) num23 == 4232981)
                                    {
                                      // ISSUE: explicit reference operation
                                      // ISSUE: cast to a reference type
                                      // ISSUE: explicit reference operation
                                      Module.ReadProcessMemory(  @processInformation,  5168300,  &num17, 4U, (uint*) 0);
                                      // ISSUE: explicit reference operation
                                      // ISSUE: cast to a reference type
                                      // ISSUE: explicit reference operation
                                       @context = 65538;
                                      Module.GetThreadContext(voidPtr, &context);
                                      // ISSUE: cast to a reference type
                                      // ISSUE: explicit reference operation
                                       ((IntPtr) &context + 160) = (int) num17;
                                      if (!flag2)
                                      {
                                        // ISSUE: cast to a reference type
                                        // ISSUE: explicit reference operation
                                        // ISSUE: cast to a reference type
                                        // ISSUE: explicit reference operation
                                        if ( ((IntPtr) &context + 176) ==  ((IntPtr) &context + 168))
                                        {
                                          ++wins;
                                          flag2 = true;
                                        }
                                        // ISSUE: cast to a reference type
                                        // ISSUE: explicit reference operation
                                        // ISSUE: cast to a reference type
                                        // ISSUE: explicit reference operation
                                        if ( ((IntPtr) &context + 176) ==  ((IntPtr) &context + 160))
                                        {
                                          ++losses;
                                          flag2 = true;
                                        }
                                        if (flag2)
                                          num14 = 0;
                                      }
                                      Module.SetThreadContext(voidPtr, &context);
                                      break;
                                    }
                                    else
                                      break;
                                  }
                                  else
                                    goto label_191;
                                }
                                else
                                  goto label_192;
                              }
                            }
                            else if ((int) num23 != 4265569)
                            {
                              if ((int) num23 == 4273168)
                              {
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 @context = 65538;
                                Module.GetThreadContext(voidPtr, &context);
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 ((IntPtr) &context + 164) = 0;
                                Module.SetThreadContext(voidPtr, &context);
                                if (!flag2)
                                {
                                  // ISSUE: explicit reference operation
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  Module.ReadProcessMemory(  @processInformation,  6199572,  &num17, 4U, (uint*) 0);
                                  if ((int) num17 == 2)
                                  {
                                    ++wins;
                                    flag2 = true;
                                  }
                                  // ISSUE: explicit reference operation
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  Module.ReadProcessMemory(  @processInformation,  6199672,  &num17, 4U, (uint*) 0);
                                  if ((int) num17 == 2)
                                  {
                                    ++losses;
                                    flag2 = true;
                                    break;
                                  }
                                  else
                                    break;
                                }
                                else
                                  break;
                              }
                              else
                                break;
                            }
                            else
                            {
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               @context = 65538;
                              Module.GetThreadContext(voidPtr, &context);
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 168) = 0;
                              Module.SetThreadContext(voidPtr, &context);
                              if (flag2)
                              {
                                ++num13;
                                flag2 = false;
                                break;
                              }
                              else
                                break;
                            }
                          }
                          else
                          {
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             @context = 65538;
                            Module.GetThreadContext(voidPtr, &context);
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             ((IntPtr) &context + 172) = 0;
                            Module.SetThreadContext(voidPtr, &context);
                            break;
                          }
                        }
                        else if (num23 <= 4278116U)
                        {
                          if ((int) num23 != 4278116 && (int) num23 != 4278057)
                          {
                            if ((int) num23 != 4278090)
                              break;
                          }
                          else
                            ++num8;
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           @context = 65538;
                          Module.GetThreadContext(voidPtr, &context);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ((int)  ((IntPtr) &Module.MTOPTION + 4043) != 0 && (int) num22 != 4278057 && ((int) num22 != 4278116 && (int) num1 == 2))
                          {
                            ushort eax = ushort.MaxValue;
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            if ((int)  ((IntPtr) &Module.MTINFO + 40) == 0)
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 176) = (int) this.LocalInput((ushort)  ((IntPtr) &context + 176), false);
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              Module.WriteProcessMemory(  @processInformation,  4348352,  ((IntPtr) &context + 176), 4U, (uint*) 0);
                              ++num8;
                              eax = this.RemoteInput();
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              Module.WriteProcessMemory(  @processInformation,  4348356,  &eax, 4U, (uint*) 0);
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              if ((int)  ((IntPtr) &Module.MTOPTION + 4084) != 0)
                              {
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                this.WriteMessage(string.Format("ALT_NETCODE C0>> p1Eax:{0}  p2input:{1}\n", (object) (uint)  ((IntPtr) &context + 176), (object) eax), MainForm.DebugMessageColor, MSGOPT.NONE);
                              }
                            }
                            else
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              if ((int)  ((IntPtr) &Module.MTINFO + 40) == 1)
                              {
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                eax = this.LocalInput((ushort)  ((IntPtr) &context + 176), true);
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                Module.WriteProcessMemory(  @processInformation,  4348356,  &eax, 4U, (uint*) 0);
                                ++num8;
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 ((IntPtr) &context + 176) = (int) this.RemoteInput();
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                Module.WriteProcessMemory(  @processInformation,  4348352,  ((IntPtr) &context + 176), 4U, (uint*) 0);
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  ((IntPtr) &Module.MTOPTION + 4084) != 0)
                                {
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  this.WriteMessage(string.Format("ALT_NETCODE C1>> p1Eax:{0}  p2input:{1}\n", (object) (uint)  ((IntPtr) &context + 176), (object) eax), MainForm.DebugMessageColor, MSGOPT.NONE);
                                }
                              }
                            }
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            Module.WriteProcessMemory(  @processInformation,  4307460,  &eax, 4U, (uint*) 0);
                            if (flag1 && (int) num1 != 4 || @as)
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              this.RecordInput((ushort)  ((IntPtr) &context + 176), bw, &replayInfo, @as);
                              this.RecordInput(eax, bw, &replayInfo, @as);
                            }
                            Module.SetThreadContext(voidPtr, &context);
                            break;
                          }
                          else
                          {
                            if ((int) num1 == 2)
                            {
                              if ((int) num22 == 4278057)
                              {
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 ((IntPtr) &context + 176) = (int) this.LocalInput((ushort)  ((IntPtr) &context + 176), false);
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 ((IntPtr) &context + 176) =  ((IntPtr) &context + 176) | (int) this.RemoteInput();
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  ((IntPtr) &Module.MTOPTION + 4084) != 0)
                                {
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  this.WriteMessage(string.Format("STORY_KEY>> p1Eax:{0}\n", (object) (uint)  ((IntPtr) &context + 176)), MainForm.DebugMessageColor, MSGOPT.NONE);
                                }
                              }
                              else
                              {
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int) num22 == 4278090 && (int)  ((IntPtr) &Module.MTINFO + 40) == 0 || (int) num22 == 4278116 && (int)  ((IntPtr) &Module.MTINFO + 40) == 1)
                                {
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  if ((int)  ((IntPtr) &Module.MTOPTION + 4084) != 0)
                                  {
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                     ((IntPtr) &context + 176) = (int) this.LocalInput((ushort)  ((IntPtr) &context + 176), false);
                                  }
                                }
                                else
                                {
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                   ((IntPtr) &context + 176) = (int) this.RemoteInput();
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  if ((int)  ((IntPtr) &Module.MTOPTION + 4084) != 0)
                                  {
                                    // ISSUE: cast to a reference type
                                    // ISSUE: explicit reference operation
                                    this.WriteMessage(string.Format("VS_REMOTE>> p1Eax:{0}\n", (object) (uint)  ((IntPtr) &context + 176)), MainForm.DebugMessageColor, MSGOPT.NONE);
                                  }
                                }
                              }
                            }
                            else if ((int) num1 == 4 && MainForm.WaitingWatch > 0U)
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 176) = (int) MainForm.WatchHistory[(int) (MainForm.WatchFrame % (uint) MainForm.WatchHistory.Length)];
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              if ( ((IntPtr) &context + 176) == (int) ushort.MaxValue)
                              {
                                Monitor.Enter((object) MainForm.WatchHistory);
                                try
                                {
                                  MainForm.WaitingWatch = 2U;
                                  // ISSUE: explicit reference operation
                                  // ISSUE: cast to a reference type
                                  // ISSUE: explicit reference operation
                                  if ((int)  @Module.MTINFO != 0)
                                    this.WriteMessage(string.Format("Waiting for frame{0}\n", (object) MainForm.WatchFrame), MainForm.ErrorMessageColor, MSGOPT.NONE);
                                  MainForm.WaitingForFrame = MainForm.WatchFrame;
                                  Monitor.Wait((object) MainForm.WatchHistory, 6000);
                                }
                                finally
                                {
                                  Monitor.Exit((object) MainForm.WatchHistory);
                                }
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                 ((IntPtr) &context + 176) = (int) MainForm.WatchHistory[(int) (MainForm.WatchFrame % (uint) MainForm.WatchHistory.Length)];
                                MainForm.WaitingForFrame = uint.MaxValue;
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                // ISSUE: cast to a reference type
                                // ISSUE: explicit reference operation
                                if ((int)  @Module.MTINFO != 0 &&  ((IntPtr) &context + 176) == (int) ushort.MaxValue && (int) MainForm.WaitingWatch == 2)
                                {
                                  this.WriteMessage("Spectating ended due to timeout.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                                  this.QuitWatch(true);
                                }
                              }
                              Monitor.Enter((object) MainForm.WatchHistory);
                              try
                              {
                                MainForm.WatchHistory[(int) (MainForm.WatchFrame % (uint) MainForm.WatchHistory.Length)] = ushort.MaxValue;
                                ++MainForm.WatchFrame;
                              }
                              finally
                              {
                                Monitor.Exit((object) MainForm.WatchHistory);
                              }
                            }
                            else if ((int) num1 == 3)
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 176) = (int) this.ReadReplayData(br, &replayInfo);
                            }
                            else if ((int) num1 == 1 && num2 > 0U && (int) num22 != 4278116)
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              ushort num24 = (ushort)  ((IntPtr) &context + 176);
                              Module.stddequeunsignedshortstdallocatorunsignedshortpush_back(&allocatorUnsignedShort, &num24);
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                               ((IntPtr) &context + 176) = (int) *Module.stddequeunsignedshortstdallocatorunsignedshortfront(&allocatorUnsignedShort);
                              Module.stddequeunsignedshortstdallocatorunsignedshortpop_front(&allocatorUnsignedShort);
                            }
                            if (flag1 && (int) num1 != 4 || @as)
                            {
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              this.RecordInput((ushort)  ((IntPtr) &context + 176), bw, &replayInfo, @as);
                            }
                            if ((int) num22 == 4278116)
                            {
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              Module.WriteProcessMemory(  @processInformation,  4348356,  ((IntPtr) &context + 176), 4U, (uint*) 0);
                            }
                            else
                            {
                              // ISSUE: explicit reference operation
                              // ISSUE: cast to a reference type
                              // ISSUE: explicit reference operation
                              Module.WriteProcessMemory(  @processInformation,  4348352,  ((IntPtr) &context + 176), 4U, (uint*) 0);
                            }
                            Module.SetThreadContext(voidPtr, &context);
                            break;
                          }
                        }
                        else if ((int) num23 != 4291106)
                        {
                          if ((int) num23 == 4302948)
                          {
                            ++num9;
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            Module.ReadProcessMemory(  @processInformation,  4342780,  &num17, 4U, (uint*) 0);
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             @context = 65538;
                            Module.GetThreadContext(voidPtr, &context);
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             ((IntPtr) &context + 176) = (int) num17;
                            Module.SetThreadContext(voidPtr, &context);
                            break;
                          }
                          else
                            break;
                        }
                        else
                        {
                          ++num9;
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.ReadProcessMemory(  @processInformation,  4324124,  &num17, 4U, (uint*) 0);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           @context = 65538;
                          Module.GetThreadContext(voidPtr, &context);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 176) = (int) num17;
                          Module.SetThreadContext(voidPtr, &context);
                          break;
                        }
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                         @context = 65538;
                        Module.GetThreadContext(voidPtr, &context);
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ((int)  ((IntPtr) &Module.MTINFO + 1) != 0)
                        {
                          num6 = 0U;
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &Module.MTINFO + 12) =  ((IntPtr) &Module.MTOPTION + 3980);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &Module.MTINFO + 16) =  ((IntPtr) &Module.MTOPTION + 3984);
                        }
                        int num25;
                        if (num6 > 0U)
                        {
                          num25 = (int) num6 - 1;
                          ++num6;
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if (num6 > (uint)  ((IntPtr) &Module.MTINFO + 16))
                          {
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            num6 = (uint)  ((IntPtr) &Module.MTINFO + 12);
                          }
                        }
                        else
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          num25 =  ((IntPtr) &Module.MTINFO + 16) != 0 ?  ((IntPtr) &Module.MTINFO + 16) - 1 : (int) (Module.RandomStage(0U) % (uint)  ((IntPtr) &Module.MTINFO + 12));
                        }
                        if ((int) num22 == 4228950)
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 176) = num25;
                        }
                        else
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 172) = num25;
                        }
                        Module.SetThreadContext(voidPtr, &context);
                        break;
label_191:
                        ++num8;
label_192:
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                         @context = 65538;
                        Module.GetThreadContext(voidPtr, &context);
                        if ((int) num22 == 4231196)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.ReadProcessMemory(  @processInformation,  4421376,  &num17, 4U, (uint*) 0);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 172) = (int) num17;
                        }
                        else if ((int) num22 == 4231216)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.ReadProcessMemory(  @processInformation,  4421376,  &num17, 4U, (uint*) 0);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 168) = (int) num17;
                        }
                        if ((int) num1 == 2)
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ((int) num22 == 4231196 && (int)  ((IntPtr) &Module.MTINFO + 40) == 0 || (int) num22 == 4231216 && (int)  ((IntPtr) &Module.MTINFO + 40) == 1 || ((int) num22 == 4231244 && (int)  ((IntPtr) &Module.MTINFO + 40) == 0 || (int) num22 == 4231256 && (int)  ((IntPtr) &Module.MTINFO + 40) == 1))
                          {
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             ((IntPtr) &context + 176) = (int) this.LocalInput((ushort)  ((IntPtr) &context + 176), false);
                          }
                          else
                          {
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             ((IntPtr) &context + 176) = (int) this.RemoteInput();
                          }
                        }
                        else if ((int) num1 == 4 && MainForm.WaitingWatch > 0U)
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 176) = (int) MainForm.WatchHistory[(int) (MainForm.WatchFrame % (uint) MainForm.WatchHistory.Length)];
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ( ((IntPtr) &context + 176) == (int) ushort.MaxValue)
                          {
                            Monitor.Enter((object) MainForm.WatchHistory);
                            try
                            {
                              MainForm.WaitingWatch = 2U;
                              Monitor.Wait((object) MainForm.WatchHistory, 6000);
                            }
                            finally
                            {
                              Monitor.Exit((object) MainForm.WatchHistory);
                            }
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                             ((IntPtr) &context + 176) = (int) MainForm.WatchHistory[(int) (MainForm.WatchFrame % (uint) MainForm.WatchHistory.Length)];
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            if ( ((IntPtr) &context + 176) == (int) ushort.MaxValue && (int) MainForm.WaitingWatch == 2)
                            {
                              this.WriteMessage("Spectating ended due to timeout.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                              this.QuitWatch(true);
                            }
                          }
                          Monitor.Enter((object) MainForm.WatchHistory);
                          try
                          {
                            MainForm.WatchHistory[(int) (MainForm.WatchFrame % (uint) MainForm.WatchHistory.Length)] = ushort.MaxValue;
                            ++MainForm.WatchFrame;
                          }
                          finally
                          {
                            Monitor.Exit((object) MainForm.WatchHistory);
                          }
                        }
                        else if ((int) num1 == 3)
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 176) = (int) this.ReadReplayData(br, &replayInfo);
                        }
                        else if ((int) num1 == 1 && num2 > 0U && ((int) num22 != 4231216 && (int) num22 != 4231256))
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          ushort num24 = (ushort)  ((IntPtr) &context + 176);
                          Module.stddequeunsignedshortstdallocatorunsignedshortpush_back(&allocatorUnsignedShort, &num24);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                           ((IntPtr) &context + 176) = (int) *Module.stddequeunsignedshortstdallocatorunsignedshortfront(&allocatorUnsignedShort);
                          Module.stddequeunsignedshortstdallocatorunsignedshortpop_front(&allocatorUnsignedShort);
                        }
                        if (flag1 && (int) num1 != 4 || @as)
                        {
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          this.RecordInput((ushort)  ((IntPtr) &context + 176), bw, &replayInfo, @as);
                        }
                        if ((int) num22 == 4231244)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4421456,  ((IntPtr) &context + 176), 4U, (uint*) 0);
                        }
                        else if ((int) num22 == 4231256)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4421460,  ((IntPtr) &context + 176), 4U, (uint*) 0);
                        }
                        Module.SetThreadContext(voidPtr, &context);
                        break;
                      }
                      else
                        break;
                    case 1U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        this.WriteMessage(string.Format("CREATE_THREAD_DEBUG_EVENT  addr:{0:X}  localstore:{1:X}\n", (object)  ((IntPtr) &debugEvent + 20), (object)  ((IntPtr) &debugEvent + 16)), MainForm.DebugMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                        break;
                    case 2U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                        this.WriteMessage(string.Format("CREATE_PROCESS_DEBUG_EVENT  RT: {0}\n", (object) num1), MainForm.DebugMessageColor, MSGOPT.NONE);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      voidPtr =   ((IntPtr) &debugEvent + 20);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      num5 = (uint)  ((IntPtr) &debugEvent + 8);
                      if ((int) num1 == 4)
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                         ((IntPtr) &Module.MTINFO + 4) = (sbyte)  ((IntPtr) &Module.MTOPTION + 4041);
                      }
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  ((IntPtr) &Module.MTINFO + 4) != 0)
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        num17 = (uint)  ((IntPtr) &Module.MTOPTION + 4000);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4343564,  &num17, 4U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4279440,  &Module.A0x21959a7bHIT_JUDGE_SET_CODE, 6U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4324124,  ((IntPtr) &Module.MTINFO + 8), 4U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4228950,  &Module.A0x21959a7bSTAGE_SELECT_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4279036,  &Module.A0x21959a7bROUND_SET_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4278924,  &Module.A0x21959a7bTIMER_SET_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4391204,  ((IntPtr) &Module.MTINFO + 20), 4U, (uint*) 0);
                        if ((int) num1 == 1)
                        {
                          int num23 = 0;
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4391188,  &num23, 4U, (uint*) 0);
                        }
                        else
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4391188,  ((IntPtr) &Module.MTINFO + 24), 4U, (uint*) 0);
                        }
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4229503,  &Module.A0x21959a7bVS_ROUND_CODE, 1U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4232981,  &Module.A0x21959a7bROUND_END_CODE, 6U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4213815,  &Module.A0x21959a7bFRAME_RATE_CODE, 2U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4291106,  &Module.A0x21959a7bRAND_FUNC_CODE, 5U, (uint*) 0);
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ((int)  ((IntPtr) &Module.MTOPTION + 4047) == 0)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4207617,  &Module.A0x21959a7bVOLUME_SET_1_CODE, 30U, (uint*) 0);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4207739,  &Module.A0x21959a7bVOLUME_SET_2_CODE, 28U, (uint*) 0);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ((int)  @Module.MTINFO != 0)
                            this.WriteMessage("DBG LOOP >> Inserted sound hack\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                        }
                        else
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ((int)  @Module.MTINFO != 0)
                            this.WriteMessage("DBG LOOP >> Skipped inserting sound hack\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                        }
                        if ((int) num1 == 2)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4219585,  &Module.A0x21959a7bFM2K_SYS_BTN_PUSH_PATCH, 5U, (uint*) 0);
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ((int)  ((IntPtr) &Module.MTOPTION + 4042) != 0)
                          {
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            Module.WriteProcessMemory(  @processInformation,  4218937,  &Module.A0x21959a7bFM2K_WM_MOVE_PATCH, 1U, (uint*) 0);
                            // ISSUE: explicit reference operation
                            // ISSUE: cast to a reference type
                            // ISSUE: explicit reference operation
                            Module.WriteProcessMemory(  @processInformation,  4219638,  &Module.A0x21959a7bFM2K_DEF_WNDPROC_PATCH, 1U, (uint*) 0);
                          }
                        }
                        if ((int) num1 == 2)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4278034,  &Module.A0x21959a7bSINGLE_CONTROL_HOOK_CODE, 6U, (uint*) 0);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4278088,  &Module.A0x21959a7bVS_CONTROL_HOOK_CODE, 2U, (uint*) 0);
                        }
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4278057,  &Module.A0x21959a7bSTORY_KEY_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4278090,  &Module.A0x21959a7bVS_P1_KEY_CODE, 5U, (uint*) 0);
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ((int)  ((IntPtr) &Module.MTOPTION + 4043) != 0 && (int) num1 == 2)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          if ((int)  @Module.MTINFO != 0)
                            this.WriteMessage("Inserted fast input polling hack\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4278116,  &Module.A0x21959a7bVS_P2_FAST_KEY_CODE, 12U, (uint*) 0);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4307712,  &Module.A0x21959a7bVS_P2_FAST_KEY_HACK_CODE, 22U, (uint*) 0);
                        }
                        else
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4278116,  &Module.A0x21959a7bVS_P2_KEY_CODE, 5U, (uint*) 0);
                        }
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ((int)  ((IntPtr) &Module.MTOPTION + 4006) != 0 && (int) num1 != 4)
                        {
                          Module.swprintf_s260(&arrayTypeBy0BaEW1, (char*) &Module.A0x21959a7bunnamedglobal15, __arglist (out arrayTypeBy0BaEW2));
                          if (System.IO.File.Exists(new string((char*) &arrayTypeBy0BaEW1)))
                          {
                            ArrayTypeBY0CA_W arrayTypeBy0CaW;
                            Module._itow_s32(640, &arrayTypeBy0CaW, 10);
                            Module.WritePrivateProfileStringW((char*) &Module.A0x21959a7bunnamedglobal17, (char*) &Module.A0x21959a7bunnamedglobal16, (char*) &arrayTypeBy0CaW, (char*) &arrayTypeBy0BaEW1);
                            Module._itow_s32(480, &arrayTypeBy0CaW, 10);
                            Module.WritePrivateProfileStringW((char*) &Module.A0x21959a7bunnamedglobal19, (char*) &Module.A0x21959a7bunnamedglobal18, (char*) &arrayTypeBy0CaW, (char*) &arrayTypeBy0BaEW1);
                          }
                        }
                      }
                      else
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        num17 = (uint)  ((IntPtr) &Module.MTOPTION + 4000);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4400960,  &num17, 4U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4205033,  &Module.A0x21959a7bHIT_JUDGE_SET_95_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4342780,  ((IntPtr) &Module.MTINFO + 8), 4U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4265516,  &Module.A0x21959a7bSTAGE_SELECT_95_CODE, 6U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4205160,  &Module.A0x21959a7bTIMER_SET_95_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4400980,  ((IntPtr) &Module.MTINFO + 24), 4U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4265569,  &Module.A0x21959a7bVS_ROUND_95_CODE, 2U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4273168,  &Module.A0x21959a7bROUND_END_95_CODE, 2U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4212569,  &Module.A0x21959a7bFRAME_RATE_95_CODE, 2U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4302948,  &Module.A0x21959a7bRAND_FUNC_95_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4202440,  &Module.A0x21959a7bVOLUME_SET_1_95_CODE, 39U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4202559,  &Module.A0x21959a7bVOLUME_SET_2_95_CODE, 28U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4205107,  &Module.A0x21959a7bUNCHECK_JOYSTICK_95_CODE, 5U, (uint*) 0);
                        if ((int) num1 == 2)
                        {
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4231211,  &Module.A0x21959a7bCONTROL_HOOK1_95_CODE, 5U, (uint*) 0);
                          // ISSUE: explicit reference operation
                          // ISSUE: cast to a reference type
                          // ISSUE: explicit reference operation
                          Module.WriteProcessMemory(  @processInformation,  4231251,  &Module.A0x21959a7bCONTROL_HOOK2_95_CODE, 5U, (uint*) 0);
                        }
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4231196,  &Module.A0x21959a7bSTORY_P1_KEY_95_CODE, 6U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4231216,  &Module.A0x21959a7bSTORY_P2_KEY_95_CODE, 6U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4231244,  &Module.A0x21959a7bVS_P1_KEY_95_CODE, 5U, (uint*) 0);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.WriteProcessMemory(  @processInformation,  4231256,  &Module.A0x21959a7bVS_P2_KEY_95_CODE, 5U, (uint*) 0);
                      }
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      Module.FlushInstructionCache(  @processInformation,  0, 0U);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                       ((IntPtr) &Module.MTINFO + 2) = (sbyte) 1;
                      break;
                    case 3U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        this.WriteMessage("EXIT_THREAD_DEBUG_EVENT\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                        break;
                    case 4U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        this.WriteMessage("EXIT_PROCESS_DEBUG_EVENT\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                        break;
                    case 5U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        int num23;
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.ReadProcessMemory(  @processInformation,   ((IntPtr) &debugEvent + 28),  &num23, 4U, (uint*) 0);
                        ArrayTypeBY0BAE_W arrayTypeBy0BaEW3;
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.ReadProcessMemory(  @processInformation,  num23,  &arrayTypeBy0BaEW3, 520U, (uint*) 0);
                        this.WriteMessage(string.Format("LOAD_DLL_DEBUG_EVENT > \"{0}\"\n", (object) new string((char*) &arrayTypeBy0BaEW3)), MainForm.DebugMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                        break;
                    case 6U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        this.WriteMessage("UNLOAD_DLL_DEBUG_EVENT\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                        break;
                    case 7U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        int num23 = (int)  ((IntPtr) &debugEvent + 18);
                        sbyte* numPtr = (sbyte*) Module.malloc((uint) num23);
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        Module.ReadProcessMemory(  @processInformation,   ((IntPtr) &debugEvent + 12),  numPtr, (uint) num23, (uint*) 0);
                        if ((int) numPtr[num23 - 2] == 10)
                          numPtr[num23 - 2] = (sbyte) 0;
                        this.WriteMessage(string.Format("OUTPUT_DEBUG_STRING_EVENT > {0}\n", (object) new string(numPtr)), MainForm.DebugMessageColor, MSGOPT.NONE);
                        Module.free( numPtr);
                        break;
                      }
                      else
                        break;
                    case 8U:
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                      {
                        this.WriteMessage("RIP_EVENT\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                        break;
                  }
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ( @debugEvent != 5)
                  {
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    Module.ContinueDebugEvent((uint)  ((IntPtr) &debugEvent + 4), (uint)  ((IntPtr) &debugEvent + 8), num4);
                  }
                  else
                    break;
                }
                goto label_353;
              }
              else
                this.WriteMessage(string.Format("ERROR({0}) > \"{1}\" couldn't be opened.\n", (object) Marshal.GetLastWin32Error(), (object) new string((char*) ((IntPtr) &Module.MTOPTION + 844))), MainForm.ErrorMessageColor, MSGOPT.NONE);
            }
            catch (Exception ex)
            {
              this.WriteMessage(ex.ToString() + "\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
              goto label_353;
            }
            Module.stddequeunsignedshortstdallocatorunsignedshortdtor(&allocatorUnsignedShort);
            num16 = (byte) 1;
            Module._REPLAY_INFOdtor(&replayInfo);
            goto label_358;
          }
          finally
          {
            MainForm.AllowWatch = false;
            MainForm.InputFrame = 0U;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            Module.CloseHandle(  ((IntPtr) &processInformation + 4));
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            Module.CloseHandle(  @processInformation);
            if (br != null)
              br.Close();
            if (bw != null)
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write( ((IntPtr) &replayInfo + 4));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write( ((IntPtr) &replayInfo + 8));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write((ushort) ((uint)  ((IntPtr) &replayInfo + 6) | 2048U));
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              bw.Write( ((IntPtr) &replayInfo + 9));
              string name = ((FileStream) bw.BaseStream).Name;
              bw.Flush();
              bw.Close();
              Replay replay = new Replay(name, false);
              replay.m_GameExeName = Path.GetFileName(new string((char*) ((IntPtr) &Module.MTOPTION + 844)));
              replay.UpdateSecondaryHeaderInfo();
              replay.Save(name, true);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  ((IntPtr) &Module.MTOPTION + 4037) != 0 && num19 == 0)
              {
                System.IO.File.Delete(name);
                this.WriteMessage("Deleting single player replay.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
              }
            }
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int)  ((IntPtr) &Module.MTINFO + 2) != 0)
            {
              if (MainForm.WaitingWatch > 0U)
              {
                MainForm.WaitingWatch = 0U;
                this.WriteMessage("Stopped spectating.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
              }
              else if (Module.wcslen((char*) ((IntPtr) &Module.MTINFO + 170)) > 0U)
              {
                this.WriteMessage(string.Format("\"{0}\" ended.\n", (object) new string((char*) ((IntPtr) &Module.MTINFO + 170))), MainForm.SystemMessageColor, MSGOPT.NONE);
                if ((int) num1 == 2)
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  ((IntPtr) &Module.MTINFO + 40) == 1)
                  {
                    int num4 = wins;
                    wins = losses;
                    losses = num4;
                  }
                  this.WriteMessage(string.Format("Battle results： {0} match, {1} win, {2} loss.\n", (object) num13, (object) wins, (object) losses), MainForm.SecretColor, MSGOPT.NONE);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  ((IntPtr) &Module.MTOPTION + 4032) == 1 && (DateTime.Now - now1).TotalSeconds > (double) (uint)  ((IntPtr) &Module.MTOPTION + 4052))
                    this.WriteGGMessage();
                }
              }
              else
                this.WriteMessage("Game ended.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
              bool flag3 = true;
              string name = "None";
              string str1 = new string((char*) ((IntPtr) &Module.MTINFO + 42));
              string str2 = new string((char*) ((IntPtr) &Module.MTINFO + 106));
              string str3 = new string((char*) ((IntPtr) &Module.MTOPTION + 3444));
              if (str2 == string.Empty)
                flag3 = false;
              if (str1 == str3 && flag3)
                name = str2;
              else if (str3 == str2 && flag3)
                name = str1;
              if (flag3)
              {
                TimeSpan difference = DateTime.Now - now1;
                MainForm.MYRELATIONS.AddVsTime(name, difference);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  ((IntPtr) &Module.MTOPTION + 4045) != 0)
                  MainForm.MYRELATIONS.AddWinLoss(name, wins, losses);
                MainForm.MYRELATIONS.SaveList(".\\files\\stats.pon", (RELATION_TYPE) 3);
              }
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              Process.GetProcessById( ((IntPtr) &Module.MTINFO + 32)).CloseMainWindow();
            }
            if (MainForm.NetVS != null && (int) MainForm.NetVS.SEQUENCE == 4 && MainForm.UDP != null)
            {
              MainForm.NetVS.SEQUENCE = 5U;
              byte[] dgram = new byte[1]
              {
                (byte) 26
              };
              MainForm.UDP.Send(dgram, 1, MainForm.NetVS.IP_EP);
              Monitor.Enter((object) MainForm.NetVS.LOCAL);
              Monitor.Exit((object) MainForm.NetVS.LOCAL);
              Monitor.Enter((object) MainForm.NetVS.REMOTE);
              Monitor.Exit((object) MainForm.NetVS.REMOTE);
              IDisposable disposable = MainForm.NetVS as IDisposable;
              int num4;
              if (disposable != null)
              {
                disposable.Dispose();
                num4 = 0;
              }
              else
                num4 = 0;
              MainForm.NetVS = (VersusInfo) null;
            }
            if (@as)
            {
              MainForm.AllowWatch = false;
              MainForm.SpectacleThread.Join();
            }
            if (MainForm.AfterCloseUDP)
            {
              MainForm.AfterCloseUDP = false;
              if (MainForm.UDP != null)
                MainForm.UDP.Close();
            }
            else if ((int) num1 == 4)
            {
              this.QuitWatch(true);
            }
            else
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              if ((int)  ((IntPtr) &Module.MTOPTION + 4030) != 0 && (int) num1 == 2)
                this.ChangeState((object) 1);
              else
                this.ChangeState((object) 0);
            }
            if (this.listBoxMember.InvokeRequired)
              this.listBoxMember.BeginInvoke((Delegate) new NoArgsDelegate(((Control) this).Invalidate));
            else
              this.listBoxMember.Invalidate();
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTINFO + 2) = (sbyte) 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTINFO + 3) = (sbyte) 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTINFO + 28) = 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTINFO + 32) = 0;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTINFO + 36) = 0;
            Module.memset( ((IntPtr) &Module.MTINFO + 170), 0, 512U);
            Module.memset( ((IntPtr) &Module.MTINFO + 682), 0, 512U);
            if (MainForm.IsFormClosing)
              this.Close();
          }
        }
        __fault
        {
          if ((int) num3 == 0)
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            Module.___CxxCallUnwindDtor((__FnPtr<void >) __methodptr(stddequeunsignedshortstdallocatorunsignedshortdtor),  &allocatorUnsignedShort);
          }
        }
label_353:
        Module.stddequeunsignedshortstdallocatorunsignedshortdtor(&allocatorUnsignedShort);
      }
      __fault
      {
        if ((int) num16 == 0)
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          Module.___CxxCallUnwindDtor((__FnPtr<void >) __methodptr(_REPLAY_INFOdtor),  &replayInfo);
        }
      }
      Module._REPLAY_INFOdtor(&replayInfo);
label_358:
      byte num26 = (byte) 0;
      // ISSUE: fault handler
      try
      {
        num16 = (byte) 0;
        // ISSUE: fault handler
        try
        {
        }
        __fault
        {
          if ((int) num26 == 0)
          {
            // ISSUE: method pointer
            // ISSUE: cast to a function pointer type
            Module.___CxxCallUnwindDtor((__FnPtr<void >) __methodptr(stddequeunsignedshortstdallocatorunsignedshortdtor),  &allocatorUnsignedShort);
          }
        }
      }
      __fault
      {
        if ((int) num16 == 0)
        {
          // ISSUE: method pointer
          // ISSUE: cast to a function pointer type
          Module.___CxxCallUnwindDtor((__FnPtr<void >) __methodptr(_REPLAY_INFOdtor),  &replayInfo);
        }
      }
    }

    private unsafe void RunVersus()
    {
      byte[] dgram1 = new byte[7];
      try
      {
        dgram1[0] = (byte) 17;
        Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) dgram1, 1, 2);
        Array.Copy((Array) BitConverter.GetBytes(Path.GetFileNameWithoutExtension(new string((char*) ((IntPtr) &Module.MTOPTION + 844))).GetHashCode()), 0, (Array) dgram1, 3, 4);
        if (MainForm.UDP == null)
          this.WriteMessage("UDP null error in RunVersus", MainForm.ErrorMessageColor, MSGOPT.NONE);
        MainForm.UDP.Send(dgram1, 7, MainForm.NetVS.IP_EP);
        MainForm.NetVS.SLEEPING = true;
        try
        {
          Thread.Sleep(3000);
        }
        catch (ThreadInterruptedException ex)
        {
        }
        MainForm.NetVS.SLEEPING = false;
        if ((int) MainForm.NetVS.SEQUENCE != 1)
        {
          if ((int) MainForm.NetVS.SEQUENCE == 7)
            return;
          this.WriteMessage("No response from challenge opponent.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        }
        else
        {
          dgram1[0] = (byte) 19;
          for (byte index = (byte) 0; (int) index < 5; ++index)
          {
            MainForm.NetVS.PING[(int) index] = Module.timeGetTime();
            dgram1[1] = index;
            MainForm.UDP.Send(dgram1, 2, MainForm.NetVS.IP_EP);
            Thread.Sleep(10);
          }
          if ((int) MainForm.NetVS.SEQUENCE == 1)
          {
            MainForm.NetVS.SLEEPING = true;
            try
            {
              Thread.Sleep(1000);
            }
            catch (ThreadInterruptedException ex)
            {
            }
            MainForm.NetVS.SLEEPING = false;
          }
          if ((int) MainForm.NetVS.SEQUENCE != 2)
          {
            this.WriteMessage("Connection to opponent is unstable.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
          }
          else
          {
            dgram1[0] = (byte) 21;
            uint num1 = 0U;
            uint num2 = 0U;
            for (int index = 0; index < 5; ++index)
            {
              if (MainForm.NetVS.PONG[index] <= 0U)
                continue;
              num1 += MainForm.NetVS.PONG[index] - MainForm.NetVS.PING[index];
              ++num2;
              if ((int) num2 == 4)
                break;
            }
            if ((int) num1 != 0)
            {
              uint num3 = num1 / 5U;
              Decimal num4 = this.textBoxMaxChallengePing.Value;
              if (num3 > (uint) num4)
              {
                this.WriteMessage(string.Format("Declined challenge because average ping to challenger was {1}. (Current max:{0})\n", (object) (uint) this.textBoxMaxChallengePing.Value, (object) num3), MainForm.SystemMessageColor, MSGOPT.NONE);
                byte[] dgram2 = new byte[2]
                {
                  (byte) 32,
                  (byte) 1
                };
                MainForm.UDP.Send(dgram2, 2, MainForm.NetVS.IP_EP);
                return;
              }
            }
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ( ((IntPtr) &Module.MTOPTION + 4012) == 0)
            {
              uint num3 = 0U;
              uint num4 = 0U;
              for (int index = 0; index < 5; ++index)
              {
                if (MainForm.NetVS.PONG[index] <= 0U)
                  continue;
                num3 += MainForm.NetVS.PONG[index] - MainForm.NetVS.PING[index];
                ++num4;
                if ((int) num4 == 4)
                  break;
              }
              if (num4 < 4U)
              {
                this.WriteMessage("Couldn't perform normal delay calculation.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                return;
              }
              else
              {
                uint num5 = num3 / 40U + 2U;
                if (num5 > 12U)
                  num5 = 12U;
                MainForm.NetVS.DELAY = num5;
              }
            }
            else
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              MainForm.NetVS.DELAY = (uint)  ((IntPtr) &Module.MTOPTION + 4012);
            }
            dgram1[1] = (byte) MainForm.NetVS.DELAY;
            MainForm.UDP.Send(dgram1, 2, MainForm.NetVS.IP_EP);
            MainForm.NetVS.SLEEPING = true;
            try
            {
              Thread.Sleep(3000);
            }
            catch (ThreadInterruptedException ex)
            {
            }
            MainForm.NetVS.SLEEPING = false;
            if ((int) MainForm.NetVS.SEQUENCE != 3)
            {
              this.WriteMessage("Battle preparation was not completed.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
            }
            else
            {
              MainForm.NetVS.SEQUENCE = 4U;
              this.WriteMessage(string.Format("Battle started. (delay:{0})\n", (object) MainForm.NetVS.DELAY), MainForm.SystemMessageColor, MSGOPT.NONE);
              MainForm.GameThread = new Thread(new ParameterizedThreadStart(this.RunGame));
              MainForm.GameThread.Name = "GameThread";
              MainForm.GameThread.Start((object) 2);
              MainForm.GameThread.Priority = MainForm.GetGameThreadPrioritySetting();
            }
          }
        }
      }
      finally
      {
        if (MainForm.NetVS.SEQUENCE < 4U || (int) MainForm.NetVS.SEQUENCE == 7)
        {
          MainForm.MemberList[0].STATE = 0U;
          IDisposable disposable = MainForm.NetVS as IDisposable;
          int num;
          if (disposable != null)
          {
            disposable.Dispose();
            num = 0;
          }
          else
            num = 0;
          MainForm.NetVS = (VersusInfo) null;
        }
      }
    }

    private unsafe void RunSpectacle()
    {
      byte[] numArray1 = new byte[14];
      numArray1[0] = (byte) 28;
      numArray1[1] = (byte) 0;
      Array.Copy((Array) BitConverter.GetBytes(MainForm.P1ID), 0, (Array) numArray1, 2, 2);
      Array.Copy((Array) BitConverter.GetBytes(MainForm.P2ID), 0, (Array) numArray1, 4, 2);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Array.Copy((Array) BitConverter.GetBytes((uint)  ((IntPtr) &Module.MTINFO + 8)), 0, (Array) numArray1, 6, 4);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      numArray1[10] = (byte)  ((IntPtr) &Module.MTINFO + 12);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      numArray1[11] = (byte)  ((IntPtr) &Module.MTINFO + 16);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      numArray1[12] = (byte)  ((IntPtr) &Module.MTINFO + 20);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      numArray1[13] = (byte)  ((IntPtr) &Module.MTINFO + 24);
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((int)  @Module.MTINFO != 0)
        this.WriteMessage("RunSpectacle() >> Signalling spectate start\n", MainForm.DebugMessageColor, MSGOPT.NONE);
      Monitor.Enter((object) MainForm.InputHistory);
      try
      {
        for (int index1 = 0; index1 < MainForm.SpectatorList.Count; ++index1)
        {
          UdpClient udpClient1 = MainForm.UDP;
          byte[] datagram1 = numArray1;
          int length1 = datagram1.Length;
          IPEndPoint endPoint1 = MainForm.SpectatorList[index1].IP_EP;
          AsyncCallback requestCallback1 = new AsyncCallback(MainForm.SendPackets);
          UdpClient udpClient2 = MainForm.UDP;
          udpClient1.BeginSend(datagram1, length1, endPoint1, requestCallback1, (object) udpClient2);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          for (uint index2 = 0U; index2 < (uint)  ((IntPtr) &Module.MTOPTION + 4068); ++index2)
          {
            UdpClient udpClient3 = MainForm.UDP;
            byte[] datagram2 = numArray1;
            int length2 = datagram2.Length;
            IPEndPoint endPoint2 = MainForm.SpectatorList[index1].IP_EP;
            AsyncCallback requestCallback2 = new AsyncCallback(MainForm.SendPackets);
            UdpClient udpClient4 = MainForm.UDP;
            udpClient3.BeginSend(datagram2, length2, endPoint2, requestCallback2, (object) udpClient4);
          }
        }
      }
      finally
      {
        Monitor.Exit((object) MainForm.InputHistory);
      }
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((int)  @Module.MTINFO != 0)
        this.WriteMessage(string.Format("Spectator count = {0}\n", (object) MainForm.SpectatorList.Count), MainForm.DebugMessageColor, MSGOPT.NONE);
      Thread.Sleep(100);
      byte[] numArray2 = new byte[45];
      numArray2[0] = (byte) 29;
      byte[] datagram3 = numArray2;
      MainForm.AllowWatch = true;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (MainForm.SpecDbgWnd != null && !MainForm.SpecDbgWnd.Visible && (int)  @Module.MTINFO != 0)
        ((Control) MainForm.SpecDbgWnd).Show();
      while (MainForm.AllowWatch)
      {
        Monitor.Enter((object) MainForm.InputHistory);
        try
        {
          if (MainForm.SpecDbgWnd != null && MainForm.SpecDbgWnd.Visible)
            MainForm.SpecDbgWnd.Append(string.Format("frame: {0}  IHist: {1:X8}  Lookup: {2}\n", (object) MainForm.InputFrame, (object) MainForm.InputHistory[(int) (MainForm.InputFrame % (uint) MainForm.InputHistory.Length)], (object) (MainForm.InputFrame % (uint) MainForm.InputHistory.Length)));
          uint num1 = MainForm.InputFrame;
          for (int index1 = 0; index1 < MainForm.SpectatorList.Count; ++index1)
          {
            uint num2 = MainForm.SpectatorList[index1].FRAME;
            if (num2 + 20U >= num1)
              continue;
            Array.Copy((Array) BitConverter.GetBytes(num2), 0, (Array) datagram3, 1, 4);
            for (int index2 = 0; index2 < 20; ++index2)
              Array.Copy((Array) BitConverter.GetBytes(MainForm.InputHistory[(int) ((num2 + (uint) index2) % (uint) MainForm.InputHistory.Length)]), 0, (Array) datagram3, index2 * 2 + 5, 2);
            UdpClient udpClient1 = MainForm.UDP;
            byte[] datagram1 = datagram3;
            int length1 = datagram1.Length;
            IPEndPoint endPoint1 = MainForm.SpectatorList[index1].IP_EP;
            AsyncCallback requestCallback1 = new AsyncCallback(MainForm.SendPackets);
            UdpClient udpClient2 = MainForm.UDP;
            udpClient1.BeginSend(datagram1, length1, endPoint1, requestCallback1, (object) udpClient2);
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            for (uint index2 = 0U; index2 < (uint)  ((IntPtr) &Module.MTOPTION + 4068); ++index2)
            {
              UdpClient udpClient3 = MainForm.UDP;
              byte[] datagram2 = datagram3;
              int length2 = datagram2.Length;
              IPEndPoint endPoint2 = MainForm.SpectatorList[index1].IP_EP;
              AsyncCallback requestCallback2 = new AsyncCallback(MainForm.SendPackets);
              UdpClient udpClient4 = MainForm.UDP;
              udpClient3.BeginSend(datagram2, length2, endPoint2, requestCallback2, (object) udpClient4);
            }
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int)  @Module.MTINFO != 0 && (int) num2 == 0)
            {
              UdpClient udpClient3 = MainForm.UDP;
              byte[] datagram2 = datagram3;
              int length2 = datagram2.Length;
              IPEndPoint endPoint2 = MainForm.SpectatorList[index1].IP_EP;
              AsyncCallback requestCallback2 = new AsyncCallback(MainForm.SendPackets);
              UdpClient udpClient4 = MainForm.UDP;
              udpClient3.BeginSend(datagram2, length2, endPoint2, requestCallback2, (object) udpClient4);
            }
            MainForm.SpectatorList[index1].FRAME += 10U;
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.InputHistory);
        }
        if (MainForm.SpectatorList.Count > 0)
        {
          Thread.Sleep(20);
        }
        else
        {
          Application.DoEvents();
          Thread.Sleep(100);
        }
      }
      datagram3[0] = (byte) 30;
      if (MainForm.SpecDbgWnd.Visible)
        MainForm.SpecDbgWnd.Hide();
      Monitor.Enter((object) MainForm.InputHistory);
      try
      {
        for (int index = 0; index < MainForm.SpectatorList.Count; ++index)
        {
          Array.Copy((Array) BitConverter.GetBytes(MainForm.SpectatorList[index].ID), 0, (Array) datagram3, 1, 2);
          MainForm.UDP.BeginSend(datagram3, 3, MainForm.SpectatorList[index].IP_EP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
        }
        MainForm.SpectatorList.Clear();
      }
      finally
      {
        Monitor.Exit((object) MainForm.InputHistory);
      }
    }

    private unsafe void WriteGGMessage()
    {
      byte[] numArray = (byte[]) null;
      byte[] msg = new byte[118];
      try
      {
        string s = new string((char*) ((IntPtr) &Module.MTOPTION + 3838));
        if ((uint) s.Length > 63U)
          return;
        numArray = new byte[s.Length];
        byte[] bytes = Encoding.Unicode.GetBytes(s);
        msg[0] = (byte) 5;
        Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) msg, 1, 2);
        msg[3] = (byte) bytes.Length;
        Array.Copy((Array) bytes, 0, (Array) msg, 4, bytes.Length);
      }
      catch (Exception ex)
      {
        return;
      }
      this.TalkMessage(MainForm.MemberList[0].ID, msg);
    }

    private void ThrottledWriteMessage(string msg, Color clr, MSGOPT msgoptions)
    {
      uint time = Module.timeGetTime();
      if (time - 4000U <= MainForm.LastThrottledMessageTime)
        return;
      this.WriteMessage(msg, clr, msgoptions);
      MainForm.LastThrottledMessageTime = time;
    }

    private void AppendNewline()
    {
      if (this.richTextBoxLog.InvokeRequired)
        this.richTextBoxLog.BeginInvoke((Delegate) new NoArgsDelegate(this.AppendNewline));
      else
        this.richTextBoxLog.AppendText("\n");
    }

    private void UdpStatOut(object form)
    {
      if (form == null || MainForm.UDP == null)
        return;
      MainForm mainForm = (MainForm) form;
      UdpStatistics udpIpv4Statistics = IPGlobalProperties.GetIPGlobalProperties().GetUdpIPv4Statistics();
      Socket client = MainForm.UDP.Client;
      mainForm.WriteMessage(string.Format("  Datagrams Received  \t\t : {0}\n", (object) udpIpv4Statistics.DatagramsReceived), MainForm.DebugMessageColor, MSGOPT.NONE);
      mainForm.WriteMessage(string.Format("  Datagrams Sent  \t\t\t : {0}\n", (object) udpIpv4Statistics.DatagramsSent), MainForm.DebugMessageColor, MSGOPT.NONE);
      mainForm.WriteMessage(string.Format("  Incoming Datagrams Discarded  \t : {0}\n", (object) udpIpv4Statistics.IncomingDatagramsDiscarded), MainForm.DebugMessageColor, MSGOPT.NONE);
      mainForm.WriteMessage(string.Format("  Incoming Datagrams With Errors \t : {0}\n", (object) udpIpv4Statistics.IncomingDatagramsWithErrors), MainForm.DebugMessageColor, MSGOPT.NONE);
      mainForm.WriteMessage(string.Format("  UDP Listeners  \t\t\t : {0}\n", (object) udpIpv4Statistics.UdpListeners), MainForm.DebugMessageColor, MSGOPT.NONE);
      int available = MainForm.UDP.Available;
      mainForm.WriteMessage(string.Format("  Available Bytes\t\t\t : {0}\n", (object) available.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      bool enableBroadcast = MainForm.UDP.EnableBroadcast;
      mainForm.WriteMessage(string.Format("  Broadcast Enable\t\t\t : {0}\n", (object) enableBroadcast.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      bool exclusiveAddressUse = MainForm.UDP.ExclusiveAddressUse;
      mainForm.WriteMessage(string.Format("  Address Exclusive\t\t\t : {0}\n", (object) exclusiveAddressUse.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      bool connected = client.Connected;
      mainForm.WriteMessage(string.Format("  Sock. Connected\t\t\t : {0}\n", (object) connected.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      mainForm.WriteMessage(string.Format("  Local End Point\t\t\t : {0}\n", (object) client.LocalEndPoint.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      int receiveTimeout = client.ReceiveTimeout;
      mainForm.WriteMessage(string.Format("  Receive Timeout\t\t\t : {0}\n", (object) receiveTimeout.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
    }

    private void RemoveConnection(byte[] rcv, int id)
    {
      int index1 = 0;
      for (int index2 = 1; index2 < MainForm.MemberList.Count; ++index2)
      {
        if (id == (int) MainForm.MemberList[index2].ID)
          goto label_5;
        UdpClient udpClient1 = MainForm.UDP;
        byte[] datagram = rcv;
        int length = datagram.Length;
        IPEndPoint endPoint = MainForm.MemberList[index2].IP_EP;
        AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
        UdpClient udpClient2 = MainForm.UDP;
        udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        continue;
label_5:
        index1 = index2;
      }
      if (index1 <= 0)
        return;
      if (MainForm.ListView != (LIST_VIEW) 2)
        this.WriteMessage(MainForm.MemberList[index1].NAME + " has left.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      if (((int) MainForm.MemberList[0].STATE == 3 || (int) MainForm.MemberList[0].STATE == 4) && (int) MainForm.TargetID == (int) MainForm.MemberList[index1].ID)
        this.QuitWatch(false);
      MainForm.MemberList.RemoveAt(index1);
      this.listBoxMember.Items.RemoveAt(index1);
    }

    private void RequestServerMemberList(IPEndPoint server_ep)
    {
      if (MainForm.UDP == null)
        return;
      PacketPacker packetPacker = new PacketPacker();
      packetPacker.Clear();
      packetPacker.Pack((byte) 7);
      packetPacker.Pack((byte) 0);
      packetPacker.Pack((byte) 0);
      MainForm.UDP.Send(packetPacker.Packet, packetPacker.Length, server_ep);
    }

    private void PrintLatestVersionInfo()
    {
      FileStream fileStream = (FileStream) null;
      try
      {
        fileStream = new FileStream("versioninfo.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        StreamReader streamReader = new StreamReader((Stream) fileStream);
        this.WriteMessage("   ** Version info **\n", MainForm.SystemMessageColor, MSGOPT.NOTIME);
        this.WriteMessage("    \n", MainForm.SystemMessageColor, MSGOPT.NOTIME);
        while (1 != 0)
        {
          string str = streamReader.ReadLine() + "\n";
          if (str.Length <= 1)
          {
            this.WriteMessage("   \n", MainForm.SystemMessageColor, MSGOPT.NOTIME);
            break;
          }
          else
            this.WriteMessage("  " + str, MainForm.SystemMessageColor, MSGOPT.NOTIME);
        }
      }
      catch (EndOfStreamException ex)
      {
      }
      catch (FileNotFoundException ex)
      {
        this.WriteMessage("  ** Version file not found **  \n", MainForm.SystemMessageColor, MSGOPT.NOTIME);
      }
      catch (Exception ex)
      {
      }
      finally
      {
        try
        {
          fileStream.Close();
        }
        catch (Exception ex)
        {
        }
      }
    }

    private void LoadGameSettingsPresets()
    {
      if (this.CMBX_GameSwitcher.InvokeRequired)
      {
        this.BeginInvoke((Delegate) new NoArgsDelegate(this.LoadGameSettingsPresets));
      }
      else
      {
        try
        {
          this.CMBX_GameSwitcher.Items.Clear();
          string[] files = Directory.GetFiles(".\\files\\GameSettings\\");
          IEnumerator enumerator = files.GetEnumerator();
          if (files.Length < 1)
          {
            this.CMBX_GameSwitcher.Items.Add((object) "no preset");
          }
          else
          {
            while (enumerator.MoveNext())
              this.CMBX_GameSwitcher.Items.Add((object) Path.GetFileName((string) enumerator.Current));
          }
        }
        catch (Exception ex)
        {
          this.WriteMessage("Problem loading game setting presets\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        }
      }
    }

    private static unsafe ThreadPriority GetGameThreadPrioritySetting()
    {
      ThreadPriority threadPriority;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      switch ((uint)  ((IntPtr) &Module.MTOPTION + 4056))
      {
        case 0U:
          threadPriority = ThreadPriority.Normal;
          break;
        case 1U:
          threadPriority = ThreadPriority.AboveNormal;
          break;
        case 2U:
          threadPriority = ThreadPriority.Highest;
          break;
        default:
          threadPriority = ThreadPriority.Normal;
          break;
      }
      return threadPriority;
    }

    private ushort LocalInput(ushort eax, [MarshalAs(UnmanagedType.U1)] bool flip)
    {
      if (((int) eax & 3) == 3)
        eax &= (ushort) 65533;
      if (flip)
      {
        if (((int) eax & 1) != 0)
        {
          eax &= (ushort) 65534;
          eax |= (ushort) 2;
        }
        else if (((int) eax & 2) != 0)
        {
          eax &= (ushort) 65533;
          eax |= (ushort) 1;
        }
      }
      Monitor.Enter((object) MainForm.NetVS.LOCAL);
      try
      {
        MainForm.NetVS.LOCAL[(int) (((uint) MainForm.NetVS.L_READ + MainForm.NetVS.DELAY) % (uint) MainForm.NetVS.LOCAL.Length)] = eax;
        eax = MainForm.NetVS.LOCAL[MainForm.NetVS.L_READ];
        bool flag = true;
        if (MainForm.NetVS.INTERVAL > 0U)
        {
          if ((int) MainForm.NetVS.INTERVAL == 1)
          {
            if ((int) (MainForm.NetVS.L_FRAME % MainForm.NetVS.INTERVAL2) == (int) MainForm.NetVS.INTERVAL2 - 1)
              flag = false;
          }
          else if ((int) (MainForm.NetVS.L_FRAME % MainForm.NetVS.INTERVAL) != 0)
            flag = false;
        }
        if (flag)
        {
          Array.Copy((Array) BitConverter.GetBytes(MainForm.NetVS.L_FRAME), 0, (Array) MainForm.NetVS.SEND, 1, 4);
          uint num;
          for (num = 0U; num <= MainForm.NetVS.DELAY; ++num)
            Array.Copy((Array) BitConverter.GetBytes(MainForm.NetVS.LOCAL[(int) (((uint) MainForm.NetVS.L_READ + num) % (uint) MainForm.NetVS.LOCAL.Length)]), 0, (Array) MainForm.NetVS.SEND, (int) num * 2 + 5, 2);
          MainForm.UDP.BeginSend(MainForm.NetVS.SEND, (int) num * 2 + 5, MainForm.NetVS.IP_EP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
        }
        ++MainForm.NetVS.L_FRAME;
        ++MainForm.NetVS.L_READ;
        MainForm.NetVS.L_READ %= MainForm.NetVS.LOCAL.Length;
      }
      finally
      {
        Monitor.Exit((object) MainForm.NetVS.LOCAL);
      }
      return eax;
    }

    private ushort RemoteInput()
    {
      ushort num1;
      if ((int) MainForm.NetVS.SEQUENCE != 4)
      {
        num1 = (ushort) 0;
      }
      else
      {
        ushort num2 = MainForm.NetVS.REMOTE[MainForm.NetVS.R_READ];
        if ((int) num2 == (int) ushort.MaxValue)
        {
          Monitor.Enter((object) MainForm.NetVS.REMOTE);
          try
          {
            MainForm.NetVS.WAITING = 2;
            Monitor.Wait((object) MainForm.NetVS.REMOTE, (int) MainForm.NetVS.DELAY * 10);
            num2 = MainForm.NetVS.REMOTE[MainForm.NetVS.R_READ];
          }
          finally
          {
            Monitor.Exit((object) MainForm.NetVS.REMOTE);
          }
        }
        if ((int) num2 == (int) ushort.MaxValue)
        {
          MainForm.NetVS.WAITING = 1;
          byte[] numArray1 = new byte[5];
          numArray1[0] = (byte) 24;
          byte[] numArray2 = numArray1;
          Array.Copy((Array) BitConverter.GetBytes(MainForm.NetVS.R_FRAME), 0, (Array) numArray2, 1, 4);
          uint num3 = 0U;
          while ((int) MainForm.NetVS.SEQUENCE == 4)
          {
            UdpClient udpClient1 = MainForm.UDP;
            byte[] datagram = numArray2;
            int length = datagram.Length;
            IPEndPoint endPoint = MainForm.NetVS.IP_EP;
            AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
            UdpClient udpClient2 = MainForm.UDP;
            udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
            Monitor.Enter((object) MainForm.NetVS.REMOTE);
            try
            {
              MainForm.NetVS.WAITING = 2;
              Monitor.Wait((object) MainForm.NetVS.REMOTE, (int) MainForm.NetVS.DELAY * 10);
            }
            finally
            {
              Monitor.Exit((object) MainForm.NetVS.REMOTE);
            }
            if (MainForm.NetVS.WAITING == 2)
            {
              MainForm.NetVS.WAITING = 1;
              ++num3;
              if (num3 > 100U)
                MainForm.NetVS.SEQUENCE = 6U;
            }
            else
            {
              num2 = MainForm.NetVS.REMOTE[MainForm.NetVS.R_READ];
              if ((int) num2 == (int) ushort.MaxValue)
              {
                num3 = 0U;
                Thread.Sleep((int) MainForm.NetVS.DELAY * 5);
              }
              else
                break;
            }
          }
          if ((int) num2 == (int) ushort.MaxValue && (int) MainForm.NetVS.SEQUENCE == 6)
          {
            this.WriteMessage("Battle ended due to timeout.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int)  @Module.MTINFO != 0)
              this.WriteMessage(string.Format("Frame > L:{0} / R:{1} (delay:{2})\n", (object) MainForm.NetVS.L_FRAME, (object) MainForm.NetVS.R_FRAME, (object) MainForm.NetVS.DELAY), MainForm.DebugMessageColor, MSGOPT.NONE);
            this.QuitGame();
            num1 = (ushort) 0;
            goto label_32;
          }
          else
            MainForm.NetVS.WAITING = 0;
        }
        if ((int) MainForm.NetVS.SEQUENCE != 4)
          num1 = (ushort) 0;
        else if (((int) num2 & 3) == 3)
        {
          this.WriteMessage("Irregular packet received > 4+6 dual pressed\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((int)  @Module.MTINFO != 0)
            this.WriteMessage(string.Format("IP = {0}\n", (object) MainForm.NetVS.IP_EP.Address), MainForm.DebugMessageColor, MSGOPT.NONE);
          this.QuitGame();
          num1 = ushort.MaxValue;
        }
        else
        {
          Monitor.Enter((object) MainForm.NetVS.REMOTE);
          try
          {
            MainForm.NetVS.REMOTE[MainForm.NetVS.R_READ] = ushort.MaxValue;
            ++MainForm.NetVS.R_FRAME;
            ++MainForm.NetVS.R_READ;
            MainForm.NetVS.R_READ %= MainForm.NetVS.REMOTE.Length;
          }
          finally
          {
            Monitor.Exit((object) MainForm.NetVS.REMOTE);
          }
          num1 = num2;
        }
      }
label_32:
      return num1;
    }

    private unsafe ushort ReadReplayData(BinaryReader br, _REPLAY_INFO* ri)
    {
      byte[] numArray1 = (byte[]) null;
      ushort num1;
      if (br == null)
      {
        num1 = (ushort) 0;
      }
      else
      {
        ushort num2;
        ushort num3;
        ushort num4;
        try
        {
          if (br.BaseStream.Position >= (long) (uint) *(int*) ((IntPtr) ri + 12))
          {
            br.Close();
            br = (BinaryReader) null;
            this.QuitGame();
            num1 = (ushort) 0;
            goto label_36;
          }
          else if ((int) *(ushort*) ri == 49 || (int) *(ushort*) ri == 51)
          {
            num2 = br.ReadUInt16();
            goto label_35;
          }
          else
          {
            if ((int) *(byte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) == 0)
            {
              _REPLAY_DATA replayData;
              if (Module.stddeque_REPLAY_DATAstdallocator_REPLAY_DATAsize((deque_REPLAY_DATAstdallocator_REPLAY_DATA*) ((IntPtr) ri + 16 + (int) *(byte*) ((IntPtr) ri + 2) * 24)) > 0U)
              {
                // ISSUE: explicit reference operation
                // ISSUE: cpblk instruction
                __memcpy(@replayData, (IntPtr) Module.stddeque_REPLAY_DATAstdallocator_REPLAY_DATAfront((deque_REPLAY_DATAstdallocator_REPLAY_DATA*) ((IntPtr) ri + 16 + (int) *(byte*) ((IntPtr) ri + 2) * 24)), 4);
                Module.stddeque_REPLAY_DATAstdallocator_REPLAY_DATApop_front((deque_REPLAY_DATAstdallocator_REPLAY_DATA*) ((IntPtr) ri + 16 + (int) *(byte*) ((IntPtr) ri + 2) * 24));
              }
              else
              {
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 @replayData = (short) br.ReadUInt16();
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &replayData + 2) = (sbyte) br.ReadByte();
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                for (bool flag = ((int)  @replayData & 2048) > 0; (flag ? 1 : 0) != (int) *(byte*) ((IntPtr) ri + 2); flag = ((int)  @replayData & 2048) > 0)
                {
                  Module.stddeque_REPLAY_DATAstdallocator_REPLAY_DATApush_back((deque_REPLAY_DATAstdallocator_REPLAY_DATA*) ((IntPtr) ri + 16 + (flag ? 1 : 0) * 24), &replayData);
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   @replayData = (short) br.ReadUInt16();
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   ((IntPtr) &replayData + 2) = (sbyte) br.ReadByte();
                }
              }
              // ISSUE: explicit reference operation
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(short*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2) = (short) ((int)  @replayData & 2047);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
              *(sbyte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) = (sbyte)  ((IntPtr) &replayData + 2);
            }
            else
              *(sbyte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) = (sbyte) ((int) *(byte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) - 1);
            num2 = *(ushort*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2);
            int num5 = (int) br.BaseStream.Position;
            br.BaseStream.Position -= 3L;
            bool flag1 = false;
            numArray1 = new byte[Replay.mRepDataEnder.Length];
            if ((int) (byte) num2 == (int) Replay.mRepDataEnder[0])
            {
              byte[] numArray2 = br.ReadBytes(Replay.mRepDataEnder.Length);
              for (int index = 0; index < Replay.mRepDataEnder.Length; ++index)
              {
                if ((int) numArray2[index] != (int) Replay.mRepDataEnder[index])
                {
                  flag1 = false;
                  break;
                }
                else
                  flag1 = true;
              }
            }
            if (flag1)
              throw new EndOfStreamException();
            if ((int) (byte) ((uint) num2 >> 8) == (int) Replay.mRepDataEnder[0])
            {
              int num6 = (int) br.ReadByte();
              byte[] numArray2 = br.ReadBytes(Replay.mRepDataEnder.Length);
              for (int index = 0; index < Replay.mRepDataEnder.Length; ++index)
              {
                if ((int) numArray2[index] != (int) Replay.mRepDataEnder[index])
                {
                  flag1 = false;
                  break;
                }
                else
                  flag1 = true;
              }
            }
            if (flag1)
              throw new EndOfStreamException();
            br.BaseStream.Position = (long) num5;
            *(sbyte*) ((IntPtr) ri + 2) = (sbyte) ((int) *(byte*) ((IntPtr) ri + 2) ^ 1);
            goto label_35;
          }
        }
        catch (EndOfStreamException ex)
        {
          this.WriteMessage("Replay playback complete.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
          br.Close();
          br = (BinaryReader) null;
          this.QuitGame();
          num3 = (ushort) 0;
          goto label_34;
        }
        catch (ObjectDisposedException ex)
        {
          br = (BinaryReader) null;
          num4 = (ushort) 0;
        }
        num1 = num4;
        goto label_36;
label_34:
        num1 = num3;
        goto label_36;
label_35:
        num1 = num2;
      }
label_36:
      return num1;
    }

    private unsafe uint GetKgtChecksum()
    {
      uint num;
      try
      {
        ArrayTypeBY09_W arrayTypeBy09W;
        ArrayTypeBY0BAE_W arrayTypeBy0BaEW1;
        ArrayTypeBY0BAE_W arrayTypeBy0BaEW2;
        ArrayTypeBY0BAE_W arrayTypeBy0BaEW3;
        Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy09W, 20U, (char*) &arrayTypeBy0BaEW1, 260U, (char*) &arrayTypeBy0BaEW2, 260U, (char*) &arrayTypeBy0BaEW3, 260U);
        ArrayTypeBY0BAE_W arrayTypeBy0BaEW4;
        Module.swprintf_s260(&arrayTypeBy0BaEW4, (char*) &Module.A0x21959a7bunnamedglobal20, __arglist (out arrayTypeBy09W, out arrayTypeBy0BaEW1, out arrayTypeBy0BaEW2));
        return (uint) (int) new FileStream(new string((char*) &arrayTypeBy0BaEW4), FileMode.Open, FileAccess.Read, FileShare.ReadWrite).Length;
      }
      catch (Exception ex)
      {
        num = uint.MaxValue;
      }
      return num;
    }

    private unsafe void RecordInput(ushort eax, BinaryWriter bw, _REPLAY_INFO* ri, [MarshalAs(UnmanagedType.U1)] bool @as)
    {
      if (bw != null)
      {
        if ((int) *(ushort*) ri == 51)
        {
          bw.Write(eax);
        }
        else
        {
          if ((int) *(ushort*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2) == (int) ushort.MaxValue)
            *(short*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2) = (short) eax;
          else if ((int) eax == (int) *(ushort*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2))
          {
            if ((int) *(byte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) == (int) byte.MaxValue)
            {
              bw.Write((ushort) ((uint) *(ushort*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2) | (uint) *(byte*) ((IntPtr) ri + 2) << 11));
              bw.Write(*(byte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)));
              *(sbyte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) = (sbyte) 0;
            }
            else
              *(sbyte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) = (sbyte) ((int) *(byte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) + 1);
          }
          else
          {
            bw.Write((ushort) ((uint) *(ushort*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2) | (uint) *(byte*) ((IntPtr) ri + 2) << 11));
            bw.Write(*(byte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)));
            *(short*) ((IntPtr) ri + 4 + (int) *(byte*) ((IntPtr) ri + 2) * 2) = (short) eax;
            *(sbyte*) ((IntPtr) ri + 8 + (int) *(byte*) ((IntPtr) ri + 2)) = (sbyte) 0;
          }
          *(sbyte*) ((IntPtr) ri + 2) = (sbyte) ((int) *(byte*) ((IntPtr) ri + 2) ^ 1);
        }
      }
      if (!@as || MainForm.UDP == null)
        return;
      Monitor.Enter((object) MainForm.InputHistory);
      try
      {
        MainForm.InputHistory[(int) (MainForm.InputFrame % (uint) MainForm.InputHistory.Length)] = eax;
        ++MainForm.InputFrame;
      }
      finally
      {
        Monitor.Exit((object) MainForm.InputHistory);
      }
    }

    private int MemberNameToIndex(string membername)
    {
      int num1;
      if (Monitor.TryEnter((object) MainForm.MemberList, 150))
      {
        try
        {
          int num2 = 0;
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            if (enumerator.Current.NAME == membername)
            {
              num1 = num2;
              goto label_8;
            }
            else
              ++num2;
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      num1 = -1;
label_8:
      return num1;
    }

    private int MemberIPToIndex(IPEndPoint ipep)
    {
      int num1;
      if (Monitor.TryEnter((object) MainForm.MemberList, 150))
      {
        try
        {
          int num2 = 0;
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            if (enumerator.Current.IP_EP.Address.ToString() == ipep.Address.ToString())
            {
              num1 = num2;
              goto label_8;
            }
            else
              ++num2;
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      num1 = -1;
label_8:
      return num1;
    }

    private string MemberIPToName(IPEndPoint ipep)
    {
      string str;
      if (Monitor.TryEnter((object) MainForm.MemberList, 150))
      {
        try
        {
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            MemberInfo current = enumerator.Current;
            if (current.IP_EP.Address.ToString() == ipep.Address.ToString())
            {
              str = current.NAME;
              goto label_7;
            }
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      str = "[unknown]";
label_7:
      return str;
    }

    private ushort MemberIPToID(IPEndPoint ipep, int trytime)
    {
      ushort num;
      if (Monitor.TryEnter((object) MainForm.MemberList, trytime))
      {
        try
        {
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            MemberInfo current = enumerator.Current;
            if (current.IP_EP.Address.ToString() == ipep.Address.ToString() && current.IP_EP.Port == ipep.Port)
            {
              num = current.ID;
              goto label_7;
            }
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      num = ushort.MaxValue;
label_7:
      return num;
    }

    private unsafe IPEndPoint GetServerIP(int trytime)
    {
      IPEndPoint ipEndPoint;
      if (Monitor.TryEnter((object) MainForm.MemberList, trytime))
      {
        try
        {
          if (MainForm.MemberList.Count >= 1)
          {
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
            {
              ipEndPoint = MainForm.MemberList[1].IP_EP;
              goto label_8;
            }
          }
          else
          {
            ipEndPoint = (IPEndPoint) null;
            goto label_8;
          }
        }
        catch (ArgumentOutOfRangeException ex)
        {
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      ipEndPoint = (IPEndPoint) null;
label_8:
      return ipEndPoint;
    }

    [return: MarshalAs(UnmanagedType.U1)]
    private bool UserIsConnected(IPEndPoint ipep, int trytime)
    {
      bool flag;
      if (Monitor.TryEnter((object) MainForm.MemberList, trytime))
      {
        try
        {
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            if (enumerator.Current.IP_EP.ToString() == ipep.ToString())
            {
              flag = true;
              goto label_8;
            }
          }
          flag = false;
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      else
        flag = false;
label_8:
      return flag;
    }

    private IPEndPoint FindBySecurityCode(ulong sccode, int trytime)
    {
      IPEndPoint ipEndPoint;
      if (Monitor.TryEnter((object) MainForm.MemberList, trytime))
      {
        try
        {
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            MemberInfo current = enumerator.Current;
            if ((long) current.SECURITYCODE == (long) sccode)
            {
              ipEndPoint = current.IP_EP;
              goto label_7;
            }
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      ipEndPoint = (IPEndPoint) null;
label_7:
      return ipEndPoint;
    }

    private int CountConnectionsFromIP(IPEndPoint ipep, int trytime)
    {
      int num = 0;
      if (Monitor.TryEnter((object) MainForm.MemberList, trytime))
      {
        try
        {
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            if (enumerator.Current.IP_EP.Address.GetAddressBytes() == ipep.Address.GetAddressBytes())
              ++num;
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      return num;
    }

    private string GetRandomMemberName()
    {
      bool flag = Monitor.TryEnter((object) MainForm.MemberList, 1000);
      List<string> list = new List<string>();
      string str;
      if (flag)
      {
        try
        {
          List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
          while (enumerator.MoveNext())
          {
            MemberInfo current = enumerator.Current;
            if (!list.Contains(current.NAME))
              list.Add(current.NAME);
          }
          if (list.Count < 1)
          {
            str = "oops";
          }
          else
          {
            Random random = new Random((int) Module.timeGetTime());
            str = list[random.Next(list.Count - 1)];
          }
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
      }
      else
        str = "oops";
      return str;
    }

    private string RemoveReservedStrings(string str)
    {
      return str.Replace("/rs", " ");
    }

    private unsafe void PrizeEvent()
    {
      string randomMemberName = this.GetRandomMemberName();
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (randomMemberName == "oops" ||  ((IntPtr) &Module.MTOPTION + 520) != 0)
        return;
      Prize prize = MainForm.PRIZEMAN.GeneratePrize(randomMemberName);
      MainForm.PRIZEMAN.AddPrize(prize);
      MainForm.PRIZEMAN.SavePrizes("./files/misc/artifacts.txt");
      int num1 = MainForm.PRIZEMAN.CountOwnersItems(prize.Owner);
      string str1 = prize.Owner + " has found " + prize.PrizeName + "!";
      int num2 = num1;
      string str2 = prize.Owner + " now has " + num2.ToString() + " item(s).";
      if (MainForm.UDP != null)
      {
        byte num3 = (byte) (str1.Length * 2);
        byte[] datagram = new byte[(int) num3 + 2];
        datagram[0] = (byte) 6;
        datagram[1] = num3;
        Array.Copy((Array) Encoding.Unicode.GetBytes(str1), 0, (Array) datagram, 2, (int) num3);
        this.PacketSendAllMember(ref datagram, 0U);
      }
      this.WriteNotice(str1);
      if (MainForm.UDP != null)
      {
        byte num3 = (byte) (str2.Length * 2);
        byte[] datagram = new byte[(int) num3 + 2];
        datagram[0] = (byte) 6;
        datagram[1] = num3;
        Array.Copy((Array) Encoding.Unicode.GetBytes(str2), 0, (Array) datagram, 2, (int) num3);
        this.PacketSendAllMember(ref datagram, 0U);
      }
      this.WriteNotice(str2);
    }

    private void PacketSendAllMember(ref byte[] datagram, uint received_id)
    {
      Monitor.Enter((object) MainForm.MemberList);
      try
      {
        for (int index = 1; index < MainForm.MemberList.Count; ++index)
        {
          if ((int) received_id == (int) MainForm.MemberList[index].ID)
            continue;
          MainForm.UDP.BeginSend(datagram, datagram.Length, MainForm.MemberList[index].IP_EP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
        }
      }
      finally
      {
        Monitor.Exit((object) MainForm.MemberList);
      }
    }

    private static void SendPackets(IAsyncResult asyncResult)
    {
      string str = (string) null;
      UdpClient udpClient = (UdpClient) asyncResult.AsyncState;
      try
      {
        udpClient.EndSend(asyncResult);
      }
      catch (ObjectDisposedException ex)
      {
        str = ex.ToString();
      }
    }

    private static unsafe void ReceivePackets(IAsyncResult asyncResult)
    {
      MemberInfo info1 = (MemberInfo) null;
      string str1 = (string) null;
      byte[] data1 = (byte[]) null;
      MainForm mainForm = (MainForm) asyncResult.AsyncState;
      IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);
      try
      {
        if (MainForm.UDP == null)
          throw new Exception();
        byte[] datagram1 = MainForm.UDP.EndReceive(asyncResult, ref remoteEP);
        MainForm.UDP.BeginReceive(new AsyncCallback(MainForm.ReceivePackets), (object) mainForm);
        if ((int) datagram1[0] != 23 && (int) datagram1[0] != 24 && ((int) datagram1[0] != 29 && MainForm.MYRELATIONS.IsBlacklisted(remoteEP)))
        {
          ++Module.A0x21959a7bbl_discards1ReceivePacketsMainFormMTSPCMXPAAUIAsyncResultSystemZQ4HA;
        }
        else
        {
          if (!MainForm.PACSCHED.IsScheduled((MT_SP_PACKET_HEADER) datagram1[0], true))
            return;
          if (0 != 0)
            mainForm.WriteMessage(string.Format("Packet> {0}\t Len> {1}\t  From> {2}\n", (object) datagram1[0], (object) datagram1.Length, (object) remoteEP.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
          if ((uint) datagram1.Length > 1020U)
          {
            // ISSUE: explicit reference operation
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            if ((int)  @Module.MTINFO == 0)
              return;
            mainForm.WriteMessage(string.Format("Large Packet > {0} from {1}\n", (object) datagram1[0], (object) remoteEP.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
          }
          else
          {
            switch (datagram1[0])
            {
              case (byte) 0:
                PacketPacker packetPacker1 = new PacketPacker();
                if (!Monitor.TryEnter((object) MainForm.MemberList, 300))
                  break;
                try
                {
                  byte[] bytes = Encoding.Unicode.GetBytes(MainForm.MemberList[0].NAME);
                  packetPacker1.Pack((byte) 1);
                  packetPacker1.Pack((byte) bytes.Length);
                  packetPacker1.Pack(ref bytes);
                  MainForm.UDP.Send(packetPacker1.Packet, packetPacker1.Length, remoteEP);
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 1:
                Monitor.Enter((object) MainForm.MemberList);
                try
                {
                  if (datagram1.Length == 1 && MainForm.Ping > 0U)
                  {
                    int pingsample = (int) Module.timeGetTime() - (int) MainForm.Ping;
                    if (pingsample < 4000)
                    {
                      mainForm.WriteMessage(string.Format("Ping to {1} : {0}ms\n", (object) pingsample, (object) mainForm.MemberIPToName(remoteEP)), MainForm.SystemMessageColor, MSGOPT.NONE);
                      int index = mainForm.MemberIPToIndex(remoteEP);
                      if (index != -1)
                        MainForm.MYRELATIONS.UpdatePingInfo(MainForm.MemberList[index].NAME, pingsample);
                    }
                    MainForm.Ping = 0U;
                    break;
                  }
                  else if (MainForm.Ping <= 0U)
                  {
                    int num = (int) Module.timeGetTime();
                    try
                    {
                      int index = mainForm.MemberIPToIndex(remoteEP);
                      if (index == -1)
                        break;
                      int pingsample = num - (int) MainForm.MemberList[index].SILENTPINGTIME;
                      MainForm.MYRELATIONS.UpdatePingInfo(MainForm.MemberList[index].NAME, pingsample);
                      break;
                    }
                    catch (Exception ex)
                    {
                      break;
                    }
                  }
                  else
                  {
                    if (datagram1.Length <= 1 || MainForm.Ping <= 0U)
                      break;
                    int pingsample = (int) Module.timeGetTime() - (int) MainForm.Ping;
                    if (pingsample < 4000)
                    {
                      mainForm.WriteMessage(string.Format("Ping to {0}: {1}ms\n", (object) Encoding.Unicode.GetString(datagram1, 2, (int) datagram1[1]), (object) pingsample), MainForm.SystemMessageColor, MSGOPT.NONE);
                      MainForm.MYRELATIONS.UpdatePingInfo(Encoding.Unicode.GetString(datagram1, 2, (int) datagram1[1]), pingsample);
                      MainForm.MYRELATIONS.SaveList(".\\files\\stats.pon", (RELATION_TYPE) 3);
                    }
                    MainForm.Ping = 0U;
                    break;
                  }
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 2:
              case (byte) 3:
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
                  break;
                Monitor.Enter((object) MainForm.MemberList);
                try
                {
                  byte[] bytes1 = Encoding.Unicode.GetBytes(MainForm.ServerName);
                  byte[] bytes2 = Encoding.Unicode.GetBytes(MainForm.MemberList[0].NAME);
                  byte[] bytes3 = Encoding.Unicode.GetBytes(MainForm.MemberList[0].COMMENT);
                  byte[] bytes4 = Encoding.Unicode.GetBytes(MainForm.MemberList[0].LOOKINGFOR);
                  byte[] bytes5 = Encoding.Unicode.GetBytes(MainForm.MemberList[0].NOTLOOKING);
                  PacketPacker packetPacker2 = new PacketPacker();
                  PacketDivider packetDivider = new PacketDivider(ref datagram1);
                  Random random = new Random((int) Module.timeGetTime());
                  ulong num1;
                  do
                  {
                    num1 = (ulong) ((uint) (random.Next() * random.Next() * 4) / 2U) * 150119987579016UL;
                  }
                  while (mainForm.FindBySecurityCode(num1, 500) != null);
                  int num2 = (int) packetDivider.Divide() != 2 ? 1 : 2;
                  packetPacker2.Pack((byte) 4);
                  packetPacker2.Pack((byte) bytes1.Length);
                  packetPacker2.Pack(ref bytes1);
                  byte[] data2;
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (MainForm.MemberList.Count >  ((IntPtr) &Module.MTOPTION + 3968))
                    data2 = new byte[2]
                    {
                      byte.MaxValue,
                      byte.MaxValue
                    };
                  else if ((int) packetDivider.Divide() != 6)
                    data2 = new byte[2]
                    {
                      (byte) 254,
                      byte.MaxValue
                    };
                  else if (mainForm.CountConnectionsFromIP(remoteEP, 10) >= 3)
                  {
                    data2 = new byte[2]
                    {
                      (byte) 252,
                      byte.MaxValue
                    };
                  }
                  else
                  {
                    ++MainForm.IDCounter;
                    data2 = BitConverter.GetBytes(MainForm.IDCounter);
                    if ((uint) MainForm.IDCounter <= 16383U)
                    {
                      if ((int) MainForm.IDCounter == 16383)
                        mainForm.WriteMessage("Max IDs reached.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                      info1 = new MemberInfo();
                      info1.IP_EP = remoteEP;
                      info1.ID = MainForm.IDCounter;
                      info1.TYPE = (uint) num2;
                      info1.STATE = 0U;
                      info1.NUM_VS = 0U;
                      info1.RESPONSE = Module.timeGetTime();
                      info1.SECURITYCODE = num1;
                      int length1 = (int) packetDivider.Divide();
                      info1.NAME = Encoding.Unicode.GetString(packetDivider.Divide(length1));
                      int length2 = (int) packetDivider.Divide();
                      info1.COMMENT = Encoding.Unicode.GetString(packetDivider.Divide(length2));
                      if (packetDivider.HasMore())
                        info1.FAVPON = (FAVORITE_PONY) packetDivider.Divide();
                      if (packetDivider.HasMore())
                        info1.REGION = (PLAYER_REGION) packetDivider.Divide();
                      if (packetDivider.HasMore())
                      {
                        int length3 = (int) packetDivider.Divide();
                        info1.LOOKINGFOR = Encoding.Unicode.GetString(packetDivider.Divide(length3));
                      }
                      if (packetDivider.HasMore())
                      {
                        int length3 = (int) packetDivider.Divide();
                        info1.NOTLOOKING = Encoding.Unicode.GetString(packetDivider.Divide(length3));
                      }
                      if (MainForm.ListView == (LIST_VIEW) 2)
                      {
                        info1.NAME = "◆";
                        info1.LOOKINGFOR = string.Empty;
                        info1.NOTLOOKING = string.Empty;
                        info1.COMMENT = string.Empty;
                      }
                      MainForm.MemberList.Add(info1);
                      mainForm.AddListView(ref info1);
                      int length4 = info1.COMMENT.IndexOf("\n");
                      if (length4 != -1)
                      {
                        string comment = info1.COMMENT.Substring(0, length4);
                        mainForm.WriteComment(info1.NAME, (int) info1.TYPE, comment);
                      }
                      else
                        mainForm.WriteComment(info1.NAME, (int) info1.TYPE, info1.COMMENT);
                      // ISSUE: explicit reference operation
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      if ((int)  @Module.MTINFO != 0)
                        mainForm.WriteMessage(string.Format("Connect from {0}:{1}\n", (object) remoteEP.Address, (object) remoteEP.Port), MainForm.DebugMessageColor, MSGOPT.NONE);
                    }
                    else if ((uint) MainForm.IDCounter > 16383U)
                      MainForm.IDCounter = (ushort) 2;
                  }
                  packetPacker2.Pack(ref data2);
                  packetPacker2.Pack((byte) bytes2.Length);
                  packetPacker2.Pack(ref bytes2);
                  packetPacker2.Pack((byte) bytes3.Length);
                  packetPacker2.Pack(ref bytes3);
                  packetPacker2.Pack((byte) MainForm.MemberList[0].STATE);
                  packetPacker2.Pack((byte) MainForm.MemberList[0].FAVPON);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  packetPacker2.Pack((byte)  ((IntPtr) &Module.MTOPTION + 3948));
                  packetPacker2.Pack((byte) bytes4.Length);
                  packetPacker2.Pack(ref bytes4);
                  packetPacker2.Pack((byte) bytes5.Length);
                  packetPacker2.Pack(ref bytes5);
                  packetPacker2.Pack64(num1);
                  MainForm.UDP.Send(packetPacker2.Packet, packetPacker2.Length, remoteEP);
                  if (info1 != null)
                  {
                    packetPacker2.Clear();
                    bytes2 = Encoding.Unicode.GetBytes(info1.NAME);
                    bytes3 = Encoding.Unicode.GetBytes(info1.COMMENT);
                    byte[] bytes6 = Encoding.Unicode.GetBytes(info1.LOOKINGFOR);
                    byte[] bytes7 = Encoding.Unicode.GetBytes(info1.NOTLOOKING);
                    byte[] addressBytes = remoteEP.Address.GetAddressBytes();
                    byte[] bytes8 = BitConverter.GetBytes((ushort) remoteEP.Port);
                    data2[1] = (byte) ((int) data2[1] | (int) info1.TYPE << 6);
                    packetPacker2.Pack((byte) 9);
                    packetPacker2.Pack(ref data2);
                    packetPacker2.Pack((byte) bytes2.Length);
                    packetPacker2.Pack(ref bytes2);
                    packetPacker2.Pack((byte) bytes3.Length);
                    packetPacker2.Pack(ref bytes3);
                    packetPacker2.Pack((byte) 0);
                    packetPacker2.Pack(ref addressBytes);
                    packetPacker2.Pack(ref bytes8);
                    packetPacker2.Pack((byte) info1.FAVPON);
                    packetPacker2.Pack((byte) info1.REGION);
                    packetPacker2.Pack((byte) bytes6.Length);
                    packetPacker2.Pack(ref bytes6);
                    packetPacker2.Pack((byte) bytes7.Length);
                    packetPacker2.Pack(ref bytes7);
                    Monitor.Enter((object) MainForm.ServerName);
                    try
                    {
                      int num3 = (int) Module.CipherRand((uint) MainForm.ServerName.GetHashCode());
                      for (int index = 1; index < packetPacker2.Length; ++index)
                        packetPacker2.Packet[index] = (byte) ((int) packetPacker2.Packet[index] ^ (int) Module.CipherRand(0U));
                    }
                    finally
                    {
                      Monitor.Exit((object) MainForm.ServerName);
                    }
                    for (int index = 1; index < MainForm.MemberList.Count - 1; ++index)
                      MainForm.UDP.BeginSend(packetPacker2.Packet, packetPacker2.Length, MainForm.MemberList[index].IP_EP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
                  }
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
                int num4 = (int) Module.wcslen((char*) ((IntPtr) &Module.MTOPTION + 588)) * 2;
                if (num4 <= 0)
                  break;
                Thread.Sleep(50);
                PacketPacker packetPacker3 = new PacketPacker();
                packetPacker3.Pack((byte) 6);
                packetPacker3.Pack((byte) num4);
                byte[] bytes9 = Encoding.Unicode.GetBytes(new string((char*) ((IntPtr) &Module.MTOPTION + 588)));
                packetPacker3.Pack(ref bytes9);
                MainForm.UDP.Send(packetPacker3.Packet, packetPacker3.Length, remoteEP);
                break;
              case (byte) 5:
                if (MainForm.ServerMode >= (SERVER_MODE) 2)
                  break;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                {
                  if (!mainForm.UserIsConnected(remoteEP, 500))
                    break;
                  ushort id = mainForm.MemberIPToID(remoteEP, 1000);
                  if ((int) id == -1)
                    break;
                  mainForm.TalkMessage(id, datagram1);
                  break;
                }
                else
                {
                  if (!(remoteEP.ToString() == mainForm.GetServerIP(1000).ToString()))
                    break;
                  mainForm.TalkMessage(ushort.MaxValue, datagram1);
                  break;
                }
              case (byte) 6:
                if (MainForm.UDP == null)
                  break;
                mainForm.WriteNotice(Encoding.Unicode.GetString(datagram1, 2, (int) datagram1[1]));
                break;
              case (byte) 7:
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
                  break;
                ushort num5 = BitConverter.ToUInt16(datagram1, 1);
                PacketPacker packetPacker4 = new PacketPacker();
                bool flag1 = Monitor.TryEnter((object) MainForm.MemberList, 1000);
                try
                {
                  int index1;
                  for (index1 = 1; index1 < MainForm.MemberList.Count; ++index1)
                  {
                    if ((int) num5 != 0 && (int) num5 != (int) MainForm.MemberList[index1].ID)
                      continue;
                    byte[] bytes1 = BitConverter.GetBytes((ushort) ((uint) MainForm.MemberList[index1].ID | MainForm.MemberList[index1].TYPE << 14));
                    byte[] bytes2 = Encoding.Unicode.GetBytes(MainForm.MemberList[index1].NAME);
                    byte[] bytes3 = Encoding.Unicode.GetBytes(MainForm.MemberList[index1].COMMENT);
                    byte[] bytes4 = Encoding.Unicode.GetBytes(MainForm.MemberList[index1].LOOKINGFOR);
                    byte[] bytes5 = Encoding.Unicode.GetBytes(MainForm.MemberList[index1].NOTLOOKING);
                    byte[] addressBytes = MainForm.MemberList[index1].IP_EP.Address.GetAddressBytes();
                    byte[] bytes6 = BitConverter.GetBytes((ushort) MainForm.MemberList[index1].IP_EP.Port);
                    packetPacker4.Clear();
                    packetPacker4.Pack((byte) 8);
                    packetPacker4.Pack(ref bytes1);
                    packetPacker4.Pack((byte) bytes2.Length);
                    packetPacker4.Pack(ref bytes2);
                    packetPacker4.Pack((byte) bytes3.Length);
                    packetPacker4.Pack(ref bytes3);
                    packetPacker4.Pack((byte) MainForm.MemberList[index1].STATE);
                    packetPacker4.Pack(ref addressBytes);
                    packetPacker4.Pack(ref bytes6);
                    packetPacker4.Pack((byte) MainForm.MemberList[index1].FAVPON);
                    packetPacker4.Pack((byte) MainForm.MemberList[index1].REGION);
                    packetPacker4.Pack((byte) bytes4.Length);
                    packetPacker4.Pack(ref bytes4);
                    packetPacker4.Pack((byte) bytes5.Length);
                    packetPacker4.Pack(ref bytes5);
                    Monitor.Enter((object) MainForm.ServerName);
                    try
                    {
                      int num1 = (int) Module.CipherRand((uint) MainForm.ServerName.GetHashCode());
                      for (int index2 = 1; index2 < packetPacker4.Length; ++index2)
                        packetPacker4.Packet[index2] = (byte) ((int) packetPacker4.Packet[index2] ^ (int) Module.CipherRand(0U));
                    }
                    finally
                    {
                      Monitor.Exit((object) MainForm.ServerName);
                    }
                    MainForm.UDP.BeginSend(packetPacker4.Packet, packetPacker4.Length, remoteEP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
                    if ((int) num5 > 0)
                      break;
                  }
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int) num5 <= 0 || index1 < MainForm.MemberList.Count || (int)  @Module.MTINFO == 0)
                    break;
                  mainForm.WriteMessage(string.Format("ERROR > Unregistered user ({0}) search \n", (object) num5), MainForm.DebugMessageColor, MSGOPT.NONE);
                  break;
                }
                finally
                {
                  if (flag1)
                    Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 8:
              case (byte) 9:
                Monitor.Enter((object) MainForm.ServerName);
                try
                {
                  int num1 = (int) Module.CipherRand((uint) MainForm.ServerName.GetHashCode());
                  for (int index = 1; index < datagram1.Length; ++index)
                    datagram1[index] = (byte) ((int) datagram1[index] ^ (int) Module.CipherRand(0U));
                }
                finally
                {
                  Monitor.Exit((object) MainForm.ServerName);
                }
                ushort num6 = BitConverter.ToUInt16(datagram1, 1);
                if (((int) num6 & 16383) == (int) MainForm.MemberList[0].ID)
                  break;
                PacketDivider packetDivider1 = new PacketDivider(ref datagram1);
                packetDivider1.Length = 3;
                bool flag2 = Monitor.TryEnter((object) MainForm.MemberList, 1000);
                try
                {
                  MemberInfo info2 = new MemberInfo();
                  info2.IP_EP = new IPEndPoint(0L, 0);
                  info2.ID = (ushort) ((int) num6 & 16383);
                  info2.TYPE = (uint) num6 >> 14;
                  info2.NUM_VS = 0U;
                  int length1 = (int) packetDivider1.Divide();
                  info2.NAME = Encoding.Unicode.GetString(packetDivider1.Divide(length1));
                  int length2 = (int) packetDivider1.Divide();
                  info2.COMMENT = Encoding.Unicode.GetString(packetDivider1.Divide(length2));
                  info2.STATE = (uint) packetDivider1.Divide();
                  info2.IP_EP.Address = new IPAddress(packetDivider1.Divide(4));
                  info2.IP_EP.Port = (int) BitConverter.ToUInt16(packetDivider1.Divide(2), 0);
                  if (packetDivider1.HasMore())
                    info2.FAVPON = (FAVORITE_PONY) packetDivider1.Divide();
                  if (packetDivider1.HasMore())
                    info2.REGION = (PLAYER_REGION) packetDivider1.Divide();
                  if (packetDivider1.HasMore())
                  {
                    int length3 = (int) packetDivider1.Divide();
                    if (length3 < 65)
                      info2.LOOKINGFOR = Encoding.Unicode.GetString(packetDivider1.Divide(length3));
                  }
                  if (packetDivider1.HasMore())
                  {
                    int length3 = (int) packetDivider1.Divide();
                    if (length3 < 65)
                      info2.NOTLOOKING = Encoding.Unicode.GetString(packetDivider1.Divide(length3));
                  }
                  bool flag3 = false;
                  List<MemberInfo>.Enumerator enumerator = MainForm.MemberList.GetEnumerator();
                  while (enumerator.MoveNext())
                  {
                    if ((int) enumerator.Current.ID == (int) info2.ID)
                      flag3 = true;
                  }
                  if (!flag3)
                  {
                    MainForm.MemberList.Add(info2);
                    mainForm.AddListView(ref info2);
                    byte[] dgram = new byte[1]
                    {
                      (byte) 0
                    };
                    MainForm.UDP.Send(dgram, 1, info2.IP_EP);
                    info2.SILENTPINGTIME = Module.timeGetTime();
                    if ((int) datagram1[0] == 9)
                      mainForm.WriteComment(info2.NAME, (int) info2.TYPE, info2.COMMENT);
                    DateTime now = DateTime.Now;
                    MainForm.MYRELATIONS.UserJoined(info2.NAME, info2.IP_EP, now);
                  }
                }
                finally
                {
                  if (flag2)
                    Monitor.Exit((object) MainForm.MemberList);
                }
                if (MainForm.GameThread == null || MainForm.GameThread.IsAlive || ((int) num6 & 3) != 3)
                  break;
                MainForm.MYRELATIONS.SaveList(".\\files\\stats.pon", (RELATION_TYPE) 3);
                break;
              case (byte) 10:
              case (byte) 11:
                ushort num7;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
                {
                  if (remoteEP.ToString() == mainForm.GetServerIP(1000).ToString())
                  {
                    if (datagram1.Length >= 2)
                      num7 = BitConverter.ToUInt16(datagram1, 1);
                  }
                  else
                  {
                    mainForm.WriteMessage("Got quit message from non-server " + remoteEP.ToString() + "\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                    break;
                  }
                }
                else if (!mainForm.UserIsConnected(remoteEP, 1000))
                {
                  mainForm.WriteMessage("Warning: Got quit message from non-connected source " + remoteEP.ToString() + "\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                  break;
                }
                else
                {
                  ushort num1 = mainForm.MemberIPToID(remoteEP, 3000);
                  num7 = num1;
                  Array.Copy((Array) BitConverter.GetBytes(num1), 0, (Array) datagram1, 1, 2);
                }
                Monitor.Enter((object) MainForm.MemberList);
                bool flag4 = true;
                try
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                  {
                    int index1 = 0;
                    for (int index2 = 1; index2 < MainForm.MemberList.Count; ++index2)
                    {
                      if ((int) num7 == (int) MainForm.MemberList[index2].ID)
                        goto label_158;
                      UdpClient udpClient1 = MainForm.UDP;
                      byte[] datagram2 = datagram1;
                      int length = datagram2.Length;
                      IPEndPoint endPoint = MainForm.MemberList[index2].IP_EP;
                      AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                      UdpClient udpClient2 = MainForm.UDP;
                      udpClient1.BeginSend(datagram2, length, endPoint, requestCallback, (object) udpClient2);
                      continue;
label_158:
                      index1 = index2;
                    }
                    if (index1 > 0)
                    {
                      if (MainForm.ListView != (LIST_VIEW) 2)
                        mainForm.WriteMessage(MainForm.MemberList[index1].NAME + " has left.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      if (((int) MainForm.MemberList[0].STATE == 3 || (int) MainForm.MemberList[0].STATE == 4) && (int) MainForm.TargetID == (int) MainForm.MemberList[index1].ID)
                        mainForm.QuitWatch(false);
                      MainForm.MemberList.RemoveAt(index1);
                      mainForm.listBoxMember.Items.RemoveAt(index1);
                    }
                  }
                  else if ((int) num7 == 0)
                  {
                    mainForm.WriteMessage(MainForm.ServerName + " has shut down.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                    MainForm.MemberList[0].STATE = (uint) byte.MaxValue;
                  }
                  else if ((int) num7 == (int) ushort.MaxValue)
                  {
                    mainForm.WriteMessage("Not registered with " + MainForm.ServerName + ".\nTry again later.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                    MainForm.MemberList[0].STATE = (uint) byte.MaxValue;
                  }
                  else
                  {
                    for (int index = 0; index < MainForm.MemberList.Count; ++index)
                    {
                      if ((int) num7 == (int) MainForm.MemberList[index].ID)
                      {
                        if (index == 0)
                        {
                          mainForm.WriteMessage("Connection with server severed.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                          MainForm.MemberList[0].STATE = (uint) byte.MaxValue;
                          break;
                        }
                        else
                        {
                          if (MainForm.ListView != (LIST_VIEW) 2)
                          {
                            if ((int) datagram1[0] == 10)
                            {
                              if (new Random().Next(15) == 14)
                                mainForm.WriteMessage(MainForm.MemberList[index].NAME + " has ragequit!\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                              else
                                mainForm.WriteMessage(MainForm.MemberList[index].NAME + " has left.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                            }
                            else
                              mainForm.WriteMessage(MainForm.MemberList[index].NAME + "'s connection was interrupted.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                          }
                          if (((int) MainForm.MemberList[0].STATE == 3 || (int) MainForm.MemberList[0].STATE == 4) && (int) MainForm.TargetID == (int) MainForm.MemberList[index].ID)
                            mainForm.QuitWatch(false);
                          MainForm.MemberList.RemoveAt(index);
                          if (mainForm.listBoxMember.InvokeRequired)
                          {
                            Monitor.Exit((object) MainForm.MemberList);
                            flag4 = false;
                            IntDelegate intDelegate = new IntDelegate(mainForm.listBoxMember.Items.RemoveAt);
                            object[] objArray = new object[1]
                            {
                              (object) index
                            };
                            mainForm.listBoxMember.BeginInvoke((Delegate) intDelegate, objArray);
                            break;
                          }
                          else
                          {
                            mainForm.listBoxMember.Items.RemoveAt(index);
                            break;
                          }
                        }
                      }
                    }
                  }
                }
                finally
                {
                  if (flag4)
                    Monitor.Exit((object) MainForm.MemberList);
                }
                if ((int) MainForm.MemberList[0].STATE != (int) byte.MaxValue)
                  break;
                mainForm.Leave(false);
                break;
              case (byte) 12:
                ushort num8;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                  num8 = mainForm.MemberIPToID(remoteEP, 500);
                else if ((int) Module.IPToInt32(mainForm.GetServerIP(300)) != (int) Module.IPToInt32(remoteEP))
                {
                  mainForm.WriteWarning("Bad state change packet", remoteEP, true);
                  num8 = mainForm.MemberIPToID(remoteEP, 300);
                }
                else
                  num8 = (ushort) BitConverter.ToInt16(datagram1, 1);
                Monitor.Enter((object) MainForm.MemberList);
                try
                {
                  for (int index = 0; index < MainForm.MemberList.Count; ++index)
                  {
                    if ((int) num8 != (int) MainForm.MemberList[index].ID)
                      goto label_210;
                    MainForm.MemberList[index].STATE = (uint) datagram1[3];
                    if (mainForm.listBoxMember.InvokeRequired)
                    {
                      NoArgsDelegate noArgsDelegate = new NoArgsDelegate(mainForm.listBoxMember.Refresh);
                      mainForm.listBoxMember.BeginInvoke((Delegate) noArgsDelegate);
                    }
                    else
                      mainForm.listBoxMember.Refresh();
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
                      break;
                    else
                      continue;
label_210:
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if (index != 0 &&  ((IntPtr) &Module.MTOPTION + 520) == 0)
                    {
                      UdpClient udpClient1 = MainForm.UDP;
                      byte[] datagram2 = datagram1;
                      int length = datagram2.Length;
                      IPEndPoint endPoint = MainForm.MemberList[index].IP_EP;
                      AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                      UdpClient udpClient2 = MainForm.UDP;
                      udpClient1.BeginSend(datagram2, length, endPoint, requestCallback, (object) udpClient2);
                    }
                  }
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 13:
                ushort num9 = BitConverter.ToUInt16(datagram1, 1);
                Monitor.Enter((object) MainForm.MemberList);
                try
                {
                  byte[] numArray = new byte[4]
                  {
                    (byte) 14,
                    datagram1[1],
                    datagram1[2],
                    byte.MaxValue
                  };
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                  {
                    for (int index = 0; index < MainForm.MemberList.Count; ++index)
                    {
                      if ((int) num9 == (int) MainForm.MemberList[index].ID)
                      {
                        byte num1 = (byte) MainForm.MemberList[index].STATE;
                        if ((int) num1 == 5)
                          num1 = (byte) 0;
                        numArray[3] = num1;
                        break;
                      }
                    }
                  }
                  else if ((int) num9 == (int) MainForm.MemberList[0].ID)
                  {
                    byte num1 = (byte) MainForm.MemberList[0].STATE;
                    if ((int) num1 == 5)
                      num1 = (byte) 0;
                    numArray[3] = num1;
                  }
                  UdpClient udpClient = MainForm.UDP;
                  byte[] dgram = numArray;
                  int length = dgram.Length;
                  IPEndPoint endPoint = remoteEP;
                  udpClient.Send(dgram, length, endPoint);
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 14:
                ushort num10 = (ushort) BitConverter.ToInt16(datagram1, 1);
                Monitor.Enter((object) MainForm.MemberList);
                try
                {
                  for (int index1 = 1; index1 < MainForm.MemberList.Count; ++index1)
                  {
                    if ((int) num10 == (int) MainForm.MemberList[index1].ID)
                    {
                      MainForm.MemberList[index1].RESPONSE = Module.timeGetTime();
                      if ((int) datagram1[3] == (int) byte.MaxValue)
                      {
                        mainForm.WriteMessage(MainForm.MemberList[index1].NAME + " is not here.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                        {
                          datagram1[0] = (byte) 11;
                          for (int index2 = 1; index2 < MainForm.MemberList.Count; ++index2)
                          {
                            if ((int) num10 == (int) MainForm.MemberList[index2].ID)
                              continue;
                            MainForm.UDP.BeginSend(datagram1, 3, MainForm.MemberList[index2].IP_EP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
                          }
                        }
                        else
                        {
                          datagram1[0] = (byte) 11;
                          datagram1[1] = byte.MaxValue;
                          datagram1[2] = byte.MaxValue;
                          MainForm.UDP.Send(datagram1, 3, MainForm.MemberList[index1].IP_EP);
                        }
                        MainForm.MemberList.RemoveAt(index1);
                        mainForm.listBoxMember.Items.RemoveAt(index1);
                        break;
                      }
                      else
                      {
                        if ((int) MainForm.MemberList[index1].STATE == (int) datagram1[3])
                          break;
                        // ISSUE: explicit reference operation
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ((int)  @Module.MTINFO != 0)
                          mainForm.WriteMessage(string.Format(MainForm.MemberList[index1].NAME + " > state:{0}\n", (object) datagram1[3]), MainForm.DebugMessageColor, MSGOPT.NONE);
                        mainForm.WriteMessage(MainForm.MemberList[index1].NAME + "'s state has changed.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                        MainForm.MemberList[index1].STATE = (uint) datagram1[3];
                        mainForm.listBoxMember.Refresh();
                        break;
                      }
                    }
                  }
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 15:
                break;
              case (byte) 16:
                break;
              case (byte) 17:
                string name = "Unknown";
                Monitor.Enter((object) MainForm.MemberList);
                int index3;
                int count;
                try
                {
                  ushort num1 = BitConverter.ToUInt16(datagram1, 1);
                  for (index3 = 0; index3 < MainForm.MemberList.Count; ++index3)
                  {
                    if ((int) num1 == (int) MainForm.MemberList[index3].ID)
                    {
                      name = MainForm.MemberList[index3].NAME;
                      break;
                    }
                  }
                  count = MainForm.MemberList.Count;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
                if (index3 >= count)
                {
                  mainForm.WriteMessage("Received challenge from user not in list.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                  break;
                }
                else if (MainForm.MYRELATIONS.IsDeclining(name))
                {
                  mainForm.WriteMessage(string.Format("You autodeclined a match with {0}.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
                  break;
                }
                else
                {
                  Decimal num1 = mainForm.textBoxMaxChallengePing.Value;
                  if ((Decimal) MainForm.MYRELATIONS.GetAveragePing(name) > num1)
                  {
                    mainForm.WriteMessage(string.Format("Autodeclined a match with {0} because their ping was too high.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
                    if (MainForm.UDP == null)
                      break;
                    byte[] numArray = Module.PH_VS_DECLINE_Make(1);
                    UdpClient udpClient = MainForm.UDP;
                    byte[] dgram = numArray;
                    int length = dgram.Length;
                    IPEndPoint endPoint = remoteEP;
                    udpClient.Send(dgram, length, endPoint);
                    break;
                  }
                  else
                  {
                    if (MainForm.NetVS != null && (int) MainForm.MemberList[0].STATE == 5 && Module.timeGetTime() - MainForm.NetVS.START_UP > 7000U)
                    {
                      MainForm.MemberList[0].STATE = 0U;
                      IDisposable disposable = MainForm.NetVS as IDisposable;
                      int num2;
                      if (disposable != null)
                      {
                        disposable.Dispose();
                        num2 = 0;
                      }
                      else
                        num2 = 0;
                      MainForm.NetVS = (VersusInfo) null;
                    }
                    byte[] numArray1 = new byte[2]
                    {
                      (byte) 18,
                      (byte) MainForm.MemberList[0].STATE
                    };
                    try
                    {
                      string str2 = new string((char*) ((IntPtr) &Module.MTOPTION + 844));
                      FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(str2);
                      if (versionInfo.FileDescription != "２Ｄ格闘ツク\x30FCル2nd." && versionInfo.FileDescription != "２Ｄ格闘ツク\x30FCル９５")
                        throw new Exception();
                      if (MainForm.ServerMode == (SERVER_MODE) 1)
                      {
                        if (Path.GetFileNameWithoutExtension(str2).GetHashCode() != BitConverter.ToInt32(datagram1, 3))
                          numArray1[1] = (byte) 254;
                      }
                      else if (versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル2nd.")
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                         ((IntPtr) &Module.MTINFO + 4) = (sbyte) 1;
                      }
                      else
                      {
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                         ((IntPtr) &Module.MTINFO + 4) = (sbyte) 0;
                      }
                    }
                    catch (Exception ex)
                    {
                      numArray1[1] = byte.MaxValue;
                      mainForm.WriteMessage("Not a valid FM2K game file.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                      mainForm.WriteMessage("Please set the game executable path in the option menu.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                    }
                    UdpClient udpClient1 = MainForm.UDP;
                    byte[] datagram2 = numArray1;
                    int length = datagram2.Length;
                    IPEndPoint endPoint = remoteEP;
                    AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                    UdpClient udpClient2 = MainForm.UDP;
                    udpClient1.BeginSend(datagram2, length, endPoint, requestCallback, (object) udpClient2);
                    if ((int) numArray1[1] != 0)
                      break;
                    MainForm.MemberList[0].STATE = 5U;
                    ushort num3 = BitConverter.ToUInt16(datagram1, 1);
                    Monitor.Enter((object) MainForm.MemberList);
                    try
                    {
                      str1 = "Unknown";
                      int index1;
                      for (index1 = 0; index1 < MainForm.MemberList.Count; ++index1)
                      {
                        if ((int) num3 == (int) MainForm.MemberList[index1].ID)
                        {
                          str1 = MainForm.MemberList[index1].NAME;
                          break;
                        }
                      }
                      if (index1 >= MainForm.MemberList.Count)
                      {
                        mainForm.WriteMessage("Received challenge from user not in list.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                        MainForm.MemberList[0].STATE = 0U;
                        // ISSUE: cast to a reference type
                        // ISSUE: explicit reference operation
                        if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                          break;
                        byte[] numArray2 = new byte[3];
                        numArray2[0] = (byte) 7;
                        byte[] dgram = numArray2;
                        Array.Copy((Array) BitConverter.GetBytes(num3), 0, (Array) dgram, 1, 2);
                        MainForm.UDP.Send(dgram, 3, MainForm.MemberList[1].IP_EP);
                        break;
                      }
                      else
                      {
                        MainForm.NetVS = new VersusInfo();
                        MainForm.NetVS.SEQUENCE = 2U;
                        MainForm.NetVS.SLEEPING = false;
                        MainForm.NetVS.WAITING = 0;
                        MainForm.NetVS.START_UP = Module.timeGetTime();
                        MainForm.NetVS.IP_EP = remoteEP;
                        uint[] numArray2 = new uint[5]
                        {
                          0U,
                          0U,
                          0U,
                          0U,
                          0U
                        };
                        MainForm.NetVS.PING = numArray2;
                        uint[] numArray3 = new uint[5]
                        {
                          0U,
                          0U,
                          0U,
                          0U,
                          0U
                        };
                        MainForm.NetVS.PONG = numArray3;
                        byte[] numArray4 = new byte[32];
                        numArray4[0] = (byte) 23;
                        MainForm.NetVS.SEND = numArray4;
                        MainForm.NetVS.L_FRAME = 0U;
                        MainForm.NetVS.L_READ = 0;
                        MainForm.NetVS.R_FRAME = 0U;
                        MainForm.NetVS.R_READ = 0;
                        MainForm.P1ID = MainForm.MemberList[0].ID;
                        MainForm.P2ID = num3;
                        Module.memset( ((IntPtr) &Module.MTINFO + 42), 0, 64U);
                        Module.memset( ((IntPtr) &Module.MTINFO + 106), 0, 64U);
                        if (MainForm.ListView != (LIST_VIEW) 2)
                        {
                          Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 42), (char*) ((IntPtr) &Module.MTOPTION + 3444));
                          IntPtr hglobal = Marshal.StringToHGlobalAuto(MainForm.MemberList[index1].NAME);
                          Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 106), (char*) hglobal.ToPointer());
                          Marshal.FreeHGlobal(hglobal);
                        }
                        ++MainForm.MemberList[index1].NUM_VS;
                        if (MainForm.ListView == (LIST_VIEW) 2)
                          break;
                        mainForm.WriteMessage(MainForm.MemberList[index1].NAME + " sent a challenge request.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                        break;
                      }
                    }
                    finally
                    {
                      Monitor.Exit((object) MainForm.MemberList);
                    }
                  }
                }
              case (byte) 18:
                if ((int) datagram1[1] != 0)
                {
                  switch (datagram1[1])
                  {
                    case (byte) 1:
                      mainForm.WriteMessage("Opponent is resting.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      MainForm.MemberList[0].STATE = 0U;
                      break;
                    case (byte) 2:
                      mainForm.WriteMessage("Opponent is already in a battle.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      MainForm.MemberList[0].STATE = 0U;
                      break;
                    case (byte) 3:
                    case (byte) 4:
                      mainForm.WriteMessage("Opponent is spectating.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      MainForm.MemberList[0].STATE = 0U;
                      break;
                    case (byte) 5:
                      mainForm.WriteMessage("Opponent preparing to fight.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      break;
                    case (byte) 254:
                      mainForm.WriteMessage("Opponent is playing a different game.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                      MainForm.MemberList[0].STATE = 0U;
                      break;
                    default:
                      mainForm.WriteMessage("Opponent is unable to play.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      MainForm.MemberList[0].STATE = 0U;
                      break;
                  }
                  MainForm.NetVS.SEQUENCE = 7U;
                  if (MainForm.VersusThread == null || !MainForm.VersusThread.IsAlive || !MainForm.NetVS.SLEEPING)
                    break;
                  MainForm.VersusThread.Interrupt();
                  break;
                }
                else
                {
                  if (MainForm.NetVS == null)
                    break;
                  MainForm.NetVS.SEQUENCE = 1U;
                  if (MainForm.VersusThread == null || !MainForm.VersusThread.IsAlive || !MainForm.NetVS.SLEEPING)
                    break;
                  MainForm.VersusThread.Interrupt();
                  break;
                }
              case (byte) 19:
                datagram1[0] = (byte) 20;
                UdpClient udpClient3 = MainForm.UDP;
                byte[] dgram1 = datagram1;
                int length5 = dgram1.Length;
                IPEndPoint endPoint1 = remoteEP;
                udpClient3.Send(dgram1, length5, endPoint1);
                break;
              case (byte) 20:
                if (MainForm.NetVS == null)
                  break;
                MainForm.NetVS.PONG[(int) datagram1[1]] = Module.timeGetTime();
                ushort num11 = (ushort) 0;
                int num12 = 0;
                for (; (int) num11 < 5; ++num11)
                {
                  if (MainForm.NetVS.PONG[(int) num11] <= 0U)
                    continue;
                  ++num12;
                  if (num12 == 4)
                  {
                    if ((int) MainForm.NetVS.SEQUENCE != 1)
                      break;
                    MainForm.NetVS.SEQUENCE = 2U;
                    if (MainForm.VersusThread == null || !MainForm.VersusThread.IsAlive || !MainForm.NetVS.SLEEPING)
                      break;
                    MainForm.VersusThread.Interrupt();
                    break;
                  }
                }
                break;
              case (byte) 21:
                if (MainForm.NetVS == null || (int) MainForm.NetVS.SEQUENCE != 2)
                  break;
                byte[] numArray5 = new byte[10];
                numArray5[0] = (byte) 22;
                byte[] numArray6 = numArray5;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 8) = (int) Module.XorShift(0U);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 12) =  ((IntPtr) &Module.MTOPTION + 3980);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 16) =  ((IntPtr) &Module.MTOPTION + 3984);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 20) =  ((IntPtr) &Module.MTOPTION + 3988);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 24) =  ((IntPtr) &Module.MTOPTION + 3992);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                numArray6[1] =  ((IntPtr) &Module.MTOPTION + 4012) == 0 || (uint) datagram1[1] > (uint)  ((IntPtr) &Module.MTOPTION + 4012) ? datagram1[1] : (byte)  ((IntPtr) &Module.MTOPTION + 4012);
                MainForm.NetVS.SEQUENCE = 4U;
                MainForm.NetVS.DELAY = (uint) numArray6[1];
                VersusInfo versusInfo1 = MainForm.NetVS;
                ushort[] numArray7 = new ushort[(int) versusInfo1.DELAY * 4];
                versusInfo1.LOCAL = numArray7;
                VersusInfo versusInfo2 = MainForm.NetVS;
                ushort[] numArray8 = new ushort[(int) versusInfo2.DELAY * 4];
                versusInfo2.REMOTE = numArray8;
                for (int index1 = 0; index1 < MainForm.NetVS.LOCAL.Length; ++index1)
                {
                  MainForm.NetVS.LOCAL[index1] = ushort.MaxValue;
                  MainForm.NetVS.REMOTE[index1] = ushort.MaxValue;
                }
                for (uint index1 = 0U; index1 < MainForm.NetVS.DELAY; ++index1)
                  MainForm.NetVS.LOCAL[(int) index1] = (ushort) 0;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                Array.Copy((Array) BitConverter.GetBytes((uint)  ((IntPtr) &Module.MTINFO + 8)), 0, (Array) numArray6, 2, 4);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                numArray6[6] = (byte)  ((IntPtr) &Module.MTINFO + 12);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                numArray6[7] = (byte)  ((IntPtr) &Module.MTINFO + 16);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                numArray6[8] = (byte)  ((IntPtr) &Module.MTINFO + 20);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                numArray6[9] = (byte)  ((IntPtr) &Module.MTINFO + 24);
                UdpClient udpClient4 = MainForm.UDP;
                byte[] dgram2 = numArray6;
                int length6 = dgram2.Length;
                IPEndPoint endPoint2 = remoteEP;
                udpClient4.Send(dgram2, length6, endPoint2);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 40) = (sbyte) 0;
                mainForm.WriteMessage(string.Format("Starting match. (delay: {0})\n", (object) MainForm.NetVS.DELAY), MainForm.SystemMessageColor, MSGOPT.NONE);
                try
                {
                  new SoundPlayer(new string((char*) ((IntPtr) &Module.MTOPTION + 1884))).Play();
                }
                catch (Exception ex)
                {
                }
                MainForm.GameThread = new Thread(new ParameterizedThreadStart(mainForm.RunGame));
                MainForm.GameThread.Name = "GameThread";
                MainForm.GameThread.Priority = MainForm.GetGameThreadPrioritySetting();
                MainForm.GameThread.Start((object) 2);
                break;
              case (byte) 22:
                if (MainForm.NetVS == null)
                  break;
                MainForm.NetVS.DELAY = (uint) datagram1[1];
                VersusInfo versusInfo3 = MainForm.NetVS;
                ushort[] numArray9 = new ushort[(int) versusInfo3.DELAY * 4];
                versusInfo3.LOCAL = numArray9;
                VersusInfo versusInfo4 = MainForm.NetVS;
                ushort[] numArray10 = new ushort[(int) versusInfo4.DELAY * 4];
                versusInfo4.REMOTE = numArray10;
                for (int index1 = 0; index1 < MainForm.NetVS.LOCAL.Length; ++index1)
                {
                  MainForm.NetVS.LOCAL[index1] = ushort.MaxValue;
                  MainForm.NetVS.REMOTE[index1] = ushort.MaxValue;
                }
                for (uint index1 = 0U; index1 < MainForm.NetVS.DELAY; ++index1)
                  MainForm.NetVS.LOCAL[(int) index1] = (ushort) 0;
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 8) = (int) BitConverter.ToUInt32(datagram1, 2);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 12) = (int) datagram1[6];
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 16) = (int) datagram1[7];
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 20) = (int) datagram1[8];
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                 ((IntPtr) &Module.MTINFO + 24) = (int) datagram1[9];
                if (MainForm.VersusThread == null || !MainForm.VersusThread.IsAlive || ((int) MainForm.NetVS.SEQUENCE != 2 || !MainForm.NetVS.SLEEPING))
                  break;
                MainForm.NetVS.SEQUENCE = 3U;
                MainForm.VersusThread.Interrupt();
                break;
              case (byte) 23:
                if (MainForm.NetVS == null || (int) MainForm.NetVS.SEQUENCE != 4)
                  break;
                uint num13 = BitConverter.ToUInt32(datagram1, 1);
                Monitor.Enter((object) MainForm.NetVS.REMOTE);
                try
                {
                  if (MainForm.NetVS.R_FRAME > num13 + MainForm.NetVS.DELAY)
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO == 0)
                      break;
                    mainForm.WriteMessage(string.Format("Invalid packet (behind) > {0} / {1}\n", (object) num13, (object) MainForm.NetVS.R_FRAME), MainForm.DebugMessageColor, MSGOPT.NONE);
                    break;
                  }
                  else if (num13 > MainForm.NetVS.R_FRAME + MainForm.NetVS.DELAY)
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO == 0)
                      break;
                    mainForm.WriteMessage(string.Format("Invalid packet (ahead) > {0} / {1}\n", (object) num13, (object) MainForm.NetVS.R_FRAME), MainForm.DebugMessageColor, MSGOPT.NONE);
                    break;
                  }
                  else
                  {
                    for (uint index1 = 0U; index1 <= MainForm.NetVS.DELAY; ++index1)
                    {
                      if (num13 + index1 < MainForm.NetVS.R_FRAME)
                        continue;
                      MainForm.NetVS.REMOTE[(int) ((num13 + index1) % (uint) MainForm.NetVS.REMOTE.Length)] = BitConverter.ToUInt16(datagram1, (int) index1 * 2 + 5);
                      if ((int) num13 + (int) index1 == (int) MainForm.NetVS.R_FRAME && MainForm.NetVS.WAITING == 2)
                      {
                        MainForm.NetVS.WAITING = 1;
                        Monitor.Pulse((object) MainForm.NetVS.REMOTE);
                      }
                    }
                    break;
                  }
                }
                finally
                {
                  Monitor.Exit((object) MainForm.NetVS.REMOTE);
                }
              case (byte) 24:
                if (MainForm.NetVS == null || (int) MainForm.NetVS.SEQUENCE != 4)
                  break;
                byte[] numArray11 = new byte[7];
                numArray11[0] = (byte) 25;
                Array.Copy((Array) datagram1, 1, (Array) numArray11, 1, 4);
                numArray11[5] = byte.MaxValue;
                numArray11[6] = byte.MaxValue;
                uint num14 = BitConverter.ToUInt32(datagram1, 1);
                Monitor.Enter((object) MainForm.NetVS.LOCAL);
                try
                {
                  if (num14 >= MainForm.NetVS.L_FRAME + MainForm.NetVS.DELAY)
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO != 0)
                      mainForm.WriteMessage(string.Format("Invalid packet (ahead request) > {0} / {1}\n", (object) num14, (object) MainForm.NetVS.L_FRAME), MainForm.DebugMessageColor, MSGOPT.NONE);
                    UdpClient udpClient1 = MainForm.UDP;
                    byte[] datagram2 = numArray11;
                    int length1 = datagram2.Length;
                    IPEndPoint endPoint3 = remoteEP;
                    AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                    UdpClient udpClient2 = MainForm.UDP;
                    udpClient1.BeginSend(datagram2, length1, endPoint3, requestCallback, (object) udpClient2);
                    break;
                  }
                  else if (MainForm.NetVS.L_FRAME > num14 + MainForm.NetVS.DELAY * 2U)
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO == 0)
                      break;
                    mainForm.WriteMessage(string.Format("Invalid packet (behind request) > {0} / {1}\n", (object) num14, (object) MainForm.NetVS.L_FRAME), MainForm.DebugMessageColor, MSGOPT.NONE);
                    break;
                  }
                  else
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO != 0)
                      mainForm.WriteMessage(string.Format("Request packet > {0} / {1}\n", (object) num14, (object) MainForm.NetVS.L_FRAME), MainForm.DebugMessageColor, MSGOPT.NONE);
                    Array.Copy((Array) BitConverter.GetBytes(MainForm.NetVS.LOCAL[(int) (num14 % (uint) MainForm.NetVS.LOCAL.Length)]), 0, (Array) numArray11, 5, 2);
                    UdpClient udpClient1 = MainForm.UDP;
                    byte[] datagram2 = numArray11;
                    int length1 = datagram2.Length;
                    IPEndPoint endPoint3 = remoteEP;
                    AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
                    UdpClient udpClient2 = MainForm.UDP;
                    udpClient1.BeginSend(datagram2, length1, endPoint3, requestCallback, (object) udpClient2);
                    break;
                  }
                }
                finally
                {
                  Monitor.Exit((object) MainForm.NetVS.LOCAL);
                }
              case (byte) 25:
                if (MainForm.NetVS == null || MainForm.NetVS.WAITING <= 0)
                  break;
                uint num15 = BitConverter.ToUInt32(datagram1, 1);
                Monitor.Enter((object) MainForm.NetVS.REMOTE);
                try
                {
                  if ((int) num15 != (int) MainForm.NetVS.R_FRAME)
                    break;
                  ushort num1 = BitConverter.ToUInt16(datagram1, 5);
                  MainForm.NetVS.REMOTE[MainForm.NetVS.R_READ] = num1;
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  @Module.MTINFO != 0)
                    mainForm.WriteMessage(string.Format("Reply packet > {0} : {1}\n", (object) num15, (object) num1), MainForm.DebugMessageColor, MSGOPT.NONE);
                  if (MainForm.NetVS.WAITING != 2)
                    break;
                  MainForm.NetVS.WAITING = 1;
                  Monitor.Pulse((object) MainForm.NetVS.REMOTE);
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.NetVS.REMOTE);
                }
              case (byte) 26:
                if (MainForm.NetVS == null)
                  break;
                mainForm.WriteMessage("Match over.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                MainForm.NetVS.SEQUENCE = 5U;
                mainForm.QuitGame();
                Monitor.Enter((object) MainForm.NetVS.REMOTE);
                try
                {
                  if (MainForm.NetVS.WAITING == 2)
                  {
                    MainForm.NetVS.WAITING = 1;
                    Monitor.Pulse((object) MainForm.NetVS.REMOTE);
                  }
                }
                finally
                {
                  Monitor.Exit((object) MainForm.NetVS.REMOTE);
                }
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  @Module.MTINFO == 0)
                  break;
                mainForm.WriteMessage(string.Format("Frame > {0}\n", (object) MainForm.NetVS.L_FRAME), MainForm.DebugMessageColor, MSGOPT.NONE);
                break;
              case (byte) 27:
                datagram1[0] = (byte) 28;
                ushort num16 = BitConverter.ToUInt16(datagram1, 1);
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  ((IntPtr) &Module.MTOPTION + 4029) == 0)
                {
                  datagram1[1] = (byte) 1;
                  MainForm.UDP.Send(datagram1, 2, remoteEP);
                  break;
                }
                else
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if (MainForm.SpectatorList.Count >=  ((IntPtr) &Module.MTOPTION + 3968))
                  {
                    datagram1[1] = (byte) 2;
                    MainForm.UDP.Send(datagram1, 2, remoteEP);
                    break;
                  }
                  else if (MainForm.InputFrame > (uint) (MainForm.InputHistory.Length - 200))
                  {
                    datagram1[1] = (byte) 3;
                    MainForm.UDP.Send(datagram1, 2, remoteEP);
                    break;
                  }
                  else if (MainForm.WatchTarget != null && (int) num16 == (int) MainForm.TargetID)
                  {
                    datagram1[1] = (byte) 4;
                    MainForm.UDP.Send(datagram1, 2, remoteEP);
                    break;
                  }
                  else
                  {
                    MainForm.SpectatorInfo spectatorInfo = new MainForm.SpectatorInfo();
                    spectatorInfo.ID = num16;
                    spectatorInfo.IP_EP = remoteEP;
                    spectatorInfo.FRAME = 0U;
                    if (MainForm.SpectacleThread != null && MainForm.SpectacleThread.IsAlive && MainForm.AllowWatch)
                    {
                      byte[] numArray1 = new byte[14];
                      numArray1[0] = (byte) 28;
                      numArray1[1] = (byte) 0;
                      Array.Copy((Array) BitConverter.GetBytes(MainForm.P1ID), 0, (Array) numArray1, 2, 2);
                      Array.Copy((Array) BitConverter.GetBytes(MainForm.P2ID), 0, (Array) numArray1, 4, 2);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      Array.Copy((Array) BitConverter.GetBytes((uint)  ((IntPtr) &Module.MTINFO + 8)), 0, (Array) numArray1, 6, 4);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      numArray1[10] = (byte)  ((IntPtr) &Module.MTINFO + 12);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      numArray1[11] = (byte)  ((IntPtr) &Module.MTINFO + 16);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      numArray1[12] = (byte)  ((IntPtr) &Module.MTINFO + 20);
                      // ISSUE: cast to a reference type
                      // ISSUE: explicit reference operation
                      numArray1[13] = (byte)  ((IntPtr) &Module.MTINFO + 24);
                      UdpClient udpClient1 = MainForm.UDP;
                      byte[] dgram3 = numArray1;
                      int length1 = dgram3.Length;
                      IPEndPoint endPoint3 = remoteEP;
                      udpClient1.Send(dgram3, length1, endPoint3);
                      Thread.Sleep(100);
                    }
                    Monitor.Enter((object) MainForm.InputHistory);
                    try
                    {
                      MainForm.SpectatorList.Add(spectatorInfo);
                    }
                    finally
                    {
                      Monitor.Exit((object) MainForm.InputHistory);
                    }
                    if (MainForm.ListView == (LIST_VIEW) 2)
                      break;
                    Monitor.Enter((object) MainForm.MemberList);
                    try
                    {
                      int index1 = 0;
                      while (index1 < MainForm.MemberList.Count && (int) num16 != (int) MainForm.MemberList[index1].ID)
                        ++index1;
                      if (index1 >= MainForm.MemberList.Count)
                      {
                        mainForm.WriteMessage("A spectator has joined.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                        break;
                      }
                      else
                      {
                        mainForm.WriteMessage(MainForm.MemberList[index1].NAME + " has come to spectate.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                        break;
                      }
                    }
                    finally
                    {
                      Monitor.Exit((object) MainForm.MemberList);
                    }
                  }
                }
              case (byte) 28:
                if ((int) datagram1[1] > 0)
                {
                  switch (datagram1[1])
                  {
                    case (byte) 1:
                      mainForm.WriteMessage("Spectating not allowed.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      break;
                    case (byte) 2:
                      mainForm.WriteMessage("Spectator slots are full.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      break;
                    case (byte) 3:
                      mainForm.WriteMessage("Too late to spectate.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      break;
                    case (byte) 4:
                      mainForm.WriteMessage("Already spectating.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                      break;
                  }
                  mainForm.QuitWatch(false);
                  break;
                }
                else
                {
                  if ((int) MainForm.MemberList[0].STATE != 3 && (int) MainForm.MemberList[0].STATE != 4)
                    break;
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  @Module.MTINFO != 0)
                    mainForm.WriteMessage("PH_RES_WATCH >> Spec starting\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                  if ((int) MainForm.WaitingWatch != 0)
                    break;
                  MainForm.WaitingForResend = false;
                  MainForm.WaitingForFrame = uint.MaxValue;
                  Module.memset( ((IntPtr) &Module.MTINFO + 42), 0, 64U);
                  Module.memset( ((IntPtr) &Module.MTINFO + 106), 0, 64U);
                  MainForm.P1ID = BitConverter.ToUInt16(datagram1, 2);
                  MainForm.P2ID = BitConverter.ToUInt16(datagram1, 4);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   ((IntPtr) &Module.MTINFO + 8) = (int) BitConverter.ToUInt32(datagram1, 6);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   ((IntPtr) &Module.MTINFO + 12) = (int) datagram1[10];
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   ((IntPtr) &Module.MTINFO + 16) = (int) datagram1[11];
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   ((IntPtr) &Module.MTINFO + 20) = (int) datagram1[12];
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                   ((IntPtr) &Module.MTINFO + 24) = (int) datagram1[13];
                  IntPtr num1 = new IntPtr();
                  int num2 = 0;
                  if (MainForm.ListView != (LIST_VIEW) 2)
                  {
                    Monitor.Enter((object) MainForm.MemberList);
                    try
                    {
                      for (int index1 = 0; index1 < MainForm.MemberList.Count; ++index1)
                      {
                        IntPtr hglobal;
                        if ((int) MainForm.MemberList[index1].ID == (int) MainForm.P1ID)
                        {
                          hglobal = Marshal.StringToHGlobalAuto(MainForm.MemberList[index1].NAME);
                          Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 42), (char*) hglobal.ToPointer());
                          Marshal.FreeHGlobal(hglobal);
                          ++num2;
                        }
                        else if ((int) MainForm.MemberList[index1].ID == (int) MainForm.P2ID)
                        {
                          hglobal = Marshal.StringToHGlobalAuto(MainForm.MemberList[index1].NAME);
                          Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 106), (char*) hglobal.ToPointer());
                          Marshal.FreeHGlobal(hglobal);
                          ++num2;
                        }
                        if (num2 == 2)
                          break;
                      }
                    }
                    finally
                    {
                      Monitor.Exit((object) MainForm.MemberList);
                    }
                  }
                  if ((int) MainForm.WaitingWatch != 0)
                    break;
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  @Module.MTINFO != 0)
                  {
                    mainForm.WriteMessage("PH_RES_WATCH >> Watch params\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                    mainForm.WriteMessage(string.Format("- P1id:\t {0}\n", (object) MainForm.P1ID), MainForm.DebugMessageColor, MSGOPT.NONE);
                    mainForm.WriteMessage(string.Format("- P2id:\t {0}\n", (object) MainForm.P2ID), MainForm.DebugMessageColor, MSGOPT.NONE);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    mainForm.WriteMessage(string.Format("- Seed:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 8)), MainForm.DebugMessageColor, MSGOPT.NONE);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    mainForm.WriteMessage(string.Format("- MaxStage:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 12)), MainForm.DebugMessageColor, MSGOPT.NONE);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    mainForm.WriteMessage(string.Format("- Select:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 16)), MainForm.DebugMessageColor, MSGOPT.NONE);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    mainForm.WriteMessage(string.Format("- Round:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 20)), MainForm.DebugMessageColor, MSGOPT.NONE);
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    mainForm.WriteMessage(string.Format("- Timer:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 24)), MainForm.DebugMessageColor, MSGOPT.NONE);
                  }
                  for (int index1 = 0; index1 < MainForm.WatchHistory.Length; ++index1)
                    MainForm.WatchHistory[index1] = ushort.MaxValue;
                  MainForm.WaitingWatch = 1U;
                  MainForm.GameThread = new Thread(new ParameterizedThreadStart(mainForm.RunGame));
                  MainForm.GameThread.Name = "GameThread";
                  MainForm.GameThread.Priority = MainForm.GetGameThreadPrioritySetting();
                  MainForm.GameThread.Start((object) 4);
                  mainForm.WriteMessage("PH_RES_WATCH >> Spectate thread started.\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                  break;
                }
              case (byte) 29:
                if (MainForm.WatchTarget == null || MainForm.WaitingWatch <= 0U)
                  break;
                uint num17 = BitConverter.ToUInt32(datagram1, 1);
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  @Module.MTINFO != 0 && (int) (num17 % 20U) == 0)
                  mainForm.WriteMessage(string.Format("PH_WATCH_DATA>> f:{0} wf:{1}\n", (object) num17, (object) MainForm.WatchFrame), MainForm.DebugMessageColor, MSGOPT.NONE);
                if (num17 > MainForm.WaitingForFrame + 200U && !MainForm.WaitingForResend && ((int) MainForm.WaitingForFrame != -1 && MainForm.UDP != null))
                {
                  byte[] numArray1 = Module.PH_WFRAME_REQ_Make((int) MainForm.WatchFrame);
                  UdpClient udpClient1 = MainForm.UDP;
                  byte[] dgram3 = numArray1;
                  int length1 = dgram3.Length;
                  IPEndPoint endPoint3 = MainForm.WatchTarget;
                  udpClient1.Send(dgram3, length1, endPoint3);
                  MainForm.WaitingForResend = true;
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  @Module.MTINFO != 0)
                    mainForm.WriteMessage(string.Format("PH_WATCH_DATA >> Req lost frame:{0}\n", (object) MainForm.WatchFrame), MainForm.DebugMessageColor, MSGOPT.NONE);
                }
                if (num17 > (uint) ((int) MainForm.WatchFrame + MainForm.WatchHistory.Length - 20))
                {
                  mainForm.WriteMessage(string.Format("Stopped spectating due to syncronization failure.  rcvframe:{0}  cur:{1}  WHist->Len - 20:{2}\n", (object) num17, (object) MainForm.WatchFrame, (object) (MainForm.WatchHistory.Length - 20)), MainForm.ErrorMessageColor, MSGOPT.NONE);
                  mainForm.QuitWatch(true);
                }
                Monitor.Enter((object) MainForm.WatchHistory);
                try
                {
                  if (MainForm.WatchFrame > num17 + 20U)
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO == 0)
                      break;
                    mainForm.WriteMessage(string.Format("Spectator packet (behind) > {0} / {1}\n", (object) num17, (object) MainForm.WatchFrame), MainForm.DebugMessageColor, MSGOPT.NONE);
                    break;
                  }
                  else
                  {
                    for (uint index1 = 0U; index1 < 20U; ++index1)
                    {
                      if ((int) num17 + (int) index1 == (int) MainForm.WaitingForFrame)
                      {
                        MainForm.WaitingForResend = false;
                        MainForm.WaitingForFrame = uint.MaxValue;
                      }
                      if (num17 + index1 < MainForm.WatchFrame)
                        continue;
                      MainForm.WatchHistory[(int) ((num17 + index1) % (uint) MainForm.WatchHistory.Length)] = BitConverter.ToUInt16(datagram1, (int) index1 * 2 + 5);
                      if ((int) num17 + (int) index1 == (int) MainForm.WatchFrame && (int) MainForm.WaitingWatch == 2)
                      {
                        MainForm.WaitingWatch = 1U;
                        Monitor.Pulse((object) MainForm.WatchHistory);
                      }
                    }
                    break;
                  }
                }
                finally
                {
                  Monitor.Exit((object) MainForm.WatchHistory);
                }
              case (byte) 30:
                ushort num18 = BitConverter.ToUInt16(datagram1, 1);
                if ((int) num18 == (int) MainForm.MemberList[0].ID)
                {
                  mainForm.WriteMessage("Spectating end notification.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
                  mainForm.QuitWatch(false);
                  break;
                }
                else
                {
                  Monitor.Enter((object) MainForm.InputHistory);
                  try
                  {
                    // ISSUE: explicit reference operation
                    // ISSUE: cast to a reference type
                    // ISSUE: explicit reference operation
                    if ((int)  @Module.MTINFO != 0)
                      mainForm.WriteMessage(string.Format("Spectating ended > {0}\n", (object) num18), MainForm.DebugMessageColor, MSGOPT.NONE);
                    for (int index1 = 0; index1 < MainForm.SpectatorList.Count; ++index1)
                    {
                      if ((int) num18 == (int) MainForm.SpectatorList[index1].ID)
                      {
                        MainForm.SpectatorList.RemoveAt(index1);
                        break;
                      }
                    }
                    break;
                  }
                  finally
                  {
                    Monitor.Exit((object) MainForm.InputHistory);
                  }
                }
              case (byte) 31:
                break;
              case (byte) 32:
                if (MainForm.NetVS != null && MainForm.UDP != null && (int) datagram1[1] == 1)
                {
                  mainForm.WriteMessage(string.Format(">>({0}) declined the challenge because the average ping was too high.\n", (object) remoteEP.Address.ToString()), MainForm.SystemMessageColor, MSGOPT.NONE);
                  goto case 37;
                }
                else
                  goto case 37;
              case (byte) 33:
                PacketPacker packetPacker5 = new PacketPacker();
                Monitor.Enter((object) MainForm.MemberList);
                try
                {
                  byte[] bytes1 = Encoding.Unicode.GetBytes(MainForm.MemberList[0].NAME);
                  byte[] bytes2 = Encoding.Unicode.GetBytes("2.06b");
                  packetPacker5.Pack((byte) 34);
                  packetPacker5.Pack((byte) bytes1.Length);
                  packetPacker5.Pack(ref bytes1);
                  packetPacker5.Pack((byte) bytes2.Length);
                  packetPacker5.Pack(ref bytes2);
                  MainForm.UDP.Send(packetPacker5.Packet, packetPacker5.Length, remoteEP);
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
              case (byte) 34:
                try
                {
                  PacketDivider packetDivider2 = new PacketDivider(ref datagram1);
                  int num1 = (int) packetDivider2.Divide();
                  int length1 = (int) packetDivider2.Divide();
                  string string1 = Encoding.Unicode.GetString(packetDivider2.Divide(length1));
                  int length2 = (int) packetDivider2.Divide();
                  string string2 = Encoding.Unicode.GetString(packetDivider2.Divide(length2));
                  mainForm.WriteMessage(string.Format("{0}'s version: v{1}\n", (object) string1, (object) string2), MainForm.SystemMessageColor, MSGOPT.NONE);
                  break;
                }
                catch (Exception ex)
                {
                  break;
                }
              case (byte) 35:
                Monitor.Enter((object) MainForm.MemberList);
                uint num19;
                try
                {
                  data1 = Encoding.Unicode.GetBytes(MainForm.MemberList[0].NAME);
                  num19 = MainForm.MemberList[0].STATE;
                }
                catch (Exception ex)
                {
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.MemberList);
                }
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int) num19 == 2 || (int) num19 == 3 || (int)  ((IntPtr) &Module.MTOPTION + 844) == 0)
                  break;
                ArrayTypeBY09_W arrayTypeBy09W1;
                ArrayTypeBY0BAE_W arrayTypeBy0BaEW1;
                Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy09W1, 20U, (char*) &arrayTypeBy0BaEW1, 260U, (char*) 0, 0U, (char*) 0, 0U);
                ArrayTypeBY0BAE_W arrayTypeBy0BaEW2;
                Module.swprintf_s260(&arrayTypeBy0BaEW2, (char*) &Module.A0x21959a7bunnamedglobal2, __arglist (out arrayTypeBy09W1, out arrayTypeBy0BaEW1));
                PacketPacker packetPacker6 = new PacketPacker();
                byte data3;
                byte data4;
                byte data5;
                byte data6;
                byte[] bytes10;
                byte data7;
                uint kgtChecksum1;
                try
                {
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  data3 = (byte)  ((IntPtr) &Module.MTOPTION + 3992);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  data4 = (byte)  ((IntPtr) &Module.MTOPTION + 3980);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  data5 = (byte)  ((IntPtr) &Module.MTOPTION + 3988);
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  data6 = (byte)  ((IntPtr) &Module.MTOPTION + 3984);
                  bytes10 = Encoding.Unicode.GetBytes(Path.GetFileNameWithoutExtension(new string((char*) ((IntPtr) &Module.MTOPTION + 844))));
                  data7 = (byte) Module.GetPrivateProfileInt((char*) &Module.A0x21959a7bunnamedglobal4, (char*) &Module.A0x21959a7bunnamedglobal3, (int) byte.MaxValue, (char*) &arrayTypeBy0BaEW2);
                  kgtChecksum1 = mainForm.GetKgtChecksum();
                }
                catch (Exception ex)
                {
                  break;
                }
                packetPacker6.Pack((byte) 36);
                packetPacker6.Pack((byte) data1.Length);
                packetPacker6.Pack(ref data1);
                packetPacker6.Pack((byte) bytes10.Length);
                packetPacker6.Pack(ref bytes10);
                packetPacker6.Pack(data7);
                packetPacker6.Pack(data3);
                packetPacker6.Pack(data4);
                packetPacker6.Pack(data6);
                packetPacker6.Pack(data5);
                packetPacker6.Pack32(kgtChecksum1);
                MainForm.UDP.Send(packetPacker6.Packet, packetPacker6.Length, remoteEP);
                break;
              case (byte) 36:
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  ((IntPtr) &Module.MTOPTION + 844) == 0)
                  break;
                ArrayTypeBY09_W arrayTypeBy09W2;
                ArrayTypeBY0BAE_W arrayTypeBy0BaEW3;
                Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy09W2, 20U, (char*) &arrayTypeBy0BaEW3, 260U, (char*) 0, 0U, (char*) 0, 0U);
                ArrayTypeBY0BAE_W arrayTypeBy0BaEW4;
                Module.swprintf_s260(&arrayTypeBy0BaEW4, (char*) &Module.A0x21959a7bunnamedglobal5, __arglist (out arrayTypeBy09W2, out arrayTypeBy0BaEW3));
                byte num20 = (byte) Module.GetPrivateProfileInt((char*) &Module.A0x21959a7bunnamedglobal7, (char*) &Module.A0x21959a7bunnamedglobal6, (int) byte.MaxValue, (char*) &arrayTypeBy0BaEW4);
                try
                {
                  StringBuilder stringBuilder = new StringBuilder();
                  PacketDivider packetDivider2 = new PacketDivider(ref datagram1);
                  int num1 = (int) packetDivider2.Divide();
                  int length1 = (int) packetDivider2.Divide();
                  string string1 = Encoding.Unicode.GetString(packetDivider2.Divide(length1));
                  int length2 = (int) packetDivider2.Divide();
                  string string2 = Encoding.Unicode.GetString(packetDivider2.Divide(length2));
                  string str2 = packetDivider2.Divide().ToString();
                  string str3 = !(str2 == "255") ? str2 : "?";
                  string str4 = num20.ToString();
                  string str5 = !(str4 == "255") ? str4 : "?";
                  byte num2 = packetDivider2.Divide();
                  byte num3 = packetDivider2.Divide();
                  byte num21 = packetDivider2.Divide();
                  byte num22 = packetDivider2.Divide();
                  string str6 = "?";
                  uint kgtChecksum2 = mainForm.GetKgtChecksum();
                  if (packetDivider2.HasMore())
                    str6 = BitConverter.ToInt32(packetDivider2.Divide(4), 0).ToString("X");
                  string withoutExtension = Path.GetFileNameWithoutExtension(new string((char*) ((IntPtr) &Module.MTOPTION + 844)));
                  stringBuilder.Append(string.Format("              \t\tYou\t\t\t{0}", (object) string1));
                  stringBuilder.Append(string.Format("\n\t Game speed  \t {0}\t\t\t {1}", (object) str5, (object) str3));
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  stringBuilder.Append(string.Format("\n\t Timer       \t {0}\t\t\t {1}", (object) (uint)  ((IntPtr) &Module.MTOPTION + 3992), (object) num2));
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  stringBuilder.Append(string.Format("\n\t Max stage   \t {0}\t\t\t {1}", (object) (uint)  ((IntPtr) &Module.MTOPTION + 3980), (object) num3));
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  stringBuilder.Append(string.Format("\n\t Stage select\t {0}\t\t\t {1}", (object) (uint)  ((IntPtr) &Module.MTOPTION + 3984), (object) num21));
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  stringBuilder.Append(string.Format("\n\t Round       \t {0}\t\t\t {1}", (object) (uint)  ((IntPtr) &Module.MTOPTION + 3988), (object) num22));
                  stringBuilder.Append(string.Format("\n\t Game name   \t {0}\t\t {1}", (object) withoutExtension, (object) string2));
                  uint num23 = kgtChecksum2;
                  stringBuilder.Append(string.Format("\n\t Data hash   \t {0}\t\t\t {1}", (object) num23.ToString("X"), (object) str6));
                  stringBuilder.Append("\n");
                  mainForm.WriteMessage(stringBuilder.ToString(), MainForm.SystemMessageColor, MSGOPT.NONE);
                  break;
                }
                catch (Exception ex)
                {
                  break;
                }
              case (byte) 37:
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
                  break;
                byte[] numArray12 = new byte[1]
                {
                  (byte) 38
                };
                UdpClient udpClient5 = MainForm.UDP;
                byte[] dgram4 = numArray12;
                int length7 = dgram4.Length;
                IPEndPoint endPoint4 = remoteEP;
                udpClient5.Send(dgram4, length7, endPoint4);
                break;
              case (byte) 38:
                break;
              case (byte) 39:
                if (MainForm.NetVS == null)
                  break;
                if (!(remoteEP.Address.ToString() == MainForm.NetVS.IP_EP.Address.ToString()))
                  break;
                try
                {
                  bool flag3 = true;
                  if (MainForm.NetVS.LastSyncFrame != BitConverter.ToInt32(datagram1, 1))
                    break;
                  if (MainForm.NetVS.P1Pos.X != BitConverter.ToInt32(datagram1, 5))
                    flag3 = false;
                  if (MainForm.NetVS.P1Pos.Y != BitConverter.ToInt32(datagram1, 9))
                    flag3 = false;
                  if (MainForm.NetVS.P2Pos.X != BitConverter.ToInt32(datagram1, 13))
                    flag3 = false;
                  if (MainForm.NetVS.P2Pos.Y != BitConverter.ToInt32(datagram1, 17))
                    flag3 = false;
                  if (flag3 || MainForm.NetVS.DesyncCount >= 3)
                    break;
                  mainForm.WriteMessage("Warning: Desync with opponent likely\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                  ++MainForm.NetVS.DesyncCount;
                  break;
                }
                catch (Exception ex)
                {
                  mainForm.WriteMessage(ex.ToString(), MainForm.ErrorMessageColor, MSGOPT.NONE);
                  break;
                }
              case (byte) 40:
                if (MainForm.NetVS == null || !(remoteEP.Address.ToString() == MainForm.NetVS.IP_EP.Address.ToString()))
                  break;
                switch (BitConverter.ToInt32(datagram1, 1))
                {
                  case 1:
                    if (!MainForm.PACSCHED.TryWarningMessage(4000))
                      return;
                    mainForm.WriteMessage("Opponent caused a delay by moving the game window.\n", MainForm.SecretColor, MSGOPT.NONE);
                    return;
                  case 2:
                    if (!MainForm.PACSCHED.TryWarningMessage(4000))
                      return;
                    mainForm.WriteMessage("Opponent caused a delay by clicking the window's nonclient area.\n", MainForm.SecretColor, MSGOPT.NONE);
                    return;
                  default:
                    return;
                }
              case (byte) 41:
                Monitor.Enter((object) MainForm.SpectatorList);
                try
                {
                  if (MainForm.SpectatorList.Count <= 0 || MainForm.UDP == null || (MainForm.SpectacleThread == null || !MainForm.AllowWatch))
                    break;
                  int index1 = 0;
                  List<MainForm.SpectatorInfo>.Enumerator enumerator = MainForm.SpectatorList.GetEnumerator();
                  while (enumerator.MoveNext() && !(enumerator.Current.IP_EP.ToString() == remoteEP.ToString()))
                    ++index1;
                  if (index1 > MainForm.SpectatorList.Count + 1)
                    break;
                  int num1 = BitConverter.ToInt32(datagram1, 1);
                  MainForm.SpectatorList[index1].FRAME = (uint) num1;
                  byte[] dgram3 = new byte[1]
                  {
                    (byte) 42
                  };
                  MainForm.UDP.Send(dgram3, 1, remoteEP);
                  // ISSUE: explicit reference operation
                  // ISSUE: cast to a reference type
                  // ISSUE: explicit reference operation
                  if ((int)  @Module.MTINFO == 0)
                    break;
                  mainForm.WriteMessage("PH_WFRAME_REQ>> Reset spectator position.\n", MainForm.DebugMessageColor, MSGOPT.NONE);
                  break;
                }
                finally
                {
                  Monitor.Exit((object) MainForm.SpectatorList);
                }
              case (byte) 42:
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if (MainForm.WatchTarget == null || (int)  @Module.MTINFO == 0)
                  break;
                mainForm.WriteMessage("Got frame resend reply. \n", MainForm.DebugMessageColor, MSGOPT.NONE);
                break;
              default:
                // ISSUE: explicit reference operation
                // ISSUE: cast to a reference type
                // ISSUE: explicit reference operation
                if ((int)  @Module.MTINFO == 0)
                  break;
                mainForm.WriteMessage(string.Format("Unknown Packet > {0} from {1}\n", (object) datagram1[0], (object) remoteEP.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
                break;
            }
          }
        }
      }
      catch (ObjectDisposedException ex)
      {
        if (MainForm.UDP == null)
          return;
        MainForm.UDP = (UdpClient) null;
        mainForm.WriteMessage("Connection lost.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      catch (SocketException ex1)
      {
        try
        {
          if (MainForm.UDP != null)
            MainForm.UDP.BeginReceive(new AsyncCallback(MainForm.ReceivePackets), (object) mainForm);
        }
        catch (Exception ex2)
        {
          MainForm.UDP = (UdpClient) null;
          mainForm.WriteMessage(ex2.ToString() + "\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
          mainForm.WriteMessage("Connection lost.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
        }
        if (ex1.ErrorCode == 10054)
          return;
        mainForm.WriteMessage(string.Format("Socket error: ({0})\n", (object) ex1.ErrorCode), MainForm.ErrorMessageColor, MSGOPT.NONE);
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  @Module.MTINFO == 0)
          return;
        mainForm.WriteMessage(ex1.ToString() + "\n", MainForm.DebugMessageColor, MSGOPT.NONE);
      }
      catch (Exception ex)
      {
        mainForm.WriteMessage(ex.ToString() + "\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        Module.WriteErrorLog(ex.ToString(), "ReceivePackets");
      }
    }

    public void WriteWarning(string msg, IPEndPoint ep, [MarshalAs(UnmanagedType.U1)] bool reserved)
    {
      this.WriteMessage(string.Format("WARNING: {0}   Source: {1}", (object) msg, (object) ep.Address.ToString()), MainForm.ErrorMessageColor, MSGOPT.NONE);
    }

    public unsafe void StartGame(uint type)
    {
      try
      {
        FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(new string((char*) ((IntPtr) &Module.MTOPTION + 844)));
        if (versionInfo.FileDescription != "２Ｄ格闘ツク\x30FCル2nd." && versionInfo.FileDescription != "２Ｄ格闘ツク\x30FCル９５")
          throw new Exception();
        if (versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル2nd.")
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 4) = (sbyte) 1;
        }
        else
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 4) = (sbyte) 0;
        }
      }
      catch (Exception ex)
      {
        this.WriteMessage("FM2K executable isn't valid.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        this.WriteMessage("Please set the path to a valid FM2K executable in the options.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        return;
      }
      if ((int) MainForm.MemberList[0].STATE == 1)
        MainForm.MemberList[0].STATE = 0U;
      if ((int) MainForm.MemberList[0].STATE != 0)
        return;
      if (MainForm.GameThread != null && !MainForm.GameThread.IsAlive)
        MainForm.GameThread = (Thread) null;
      if (MainForm.VersusThread != null && !MainForm.VersusThread.IsAlive)
        MainForm.VersusThread = (Thread) null;
      if (MainForm.NetVS != null && (int) MainForm.MemberList[0].STATE == 5 && Module.timeGetTime() - MainForm.NetVS.START_UP > 7000U)
      {
        MainForm.MemberList[0].STATE = 0U;
        IDisposable disposable = MainForm.NetVS as IDisposable;
        int num;
        if (disposable != null)
        {
          disposable.Dispose();
          num = 0;
        }
        else
          num = 0;
        MainForm.NetVS = (VersusInfo) null;
      }
      if (MainForm.GameThread == null)
      {
        Module.memset( ((IntPtr) &Module.MTINFO + 42), 0, 64U);
        Module.memset( ((IntPtr) &Module.MTINFO + 106), 0, 64U);
        if ((int) type == 1 || (int) type == 5)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 8) = (int) Module.XorShift(0U);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 12) =  ((IntPtr) &Module.MTOPTION + 3980);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 16) =  ((IntPtr) &Module.MTOPTION + 3984);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 20) =  ((IntPtr) &Module.MTOPTION + 3988);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 24) =  ((IntPtr) &Module.MTOPTION + 3992);
          MainForm.P1ID = MainForm.MemberList[0].ID;
          MainForm.P2ID = ushort.MaxValue;
          Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 42), (char*) ((IntPtr) &Module.MTOPTION + 3444));
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTINFO + 40) = (sbyte) 0;
        }
        else if ((int) type == 2)
        {
          Monitor.Enter((object) MainForm.MemberList);
          try
          {
            MainForm.MemberList[0].STATE = 5U;
            MainForm.NetVS = new VersusInfo();
            MainForm.NetVS.SEQUENCE = 0U;
            MainForm.NetVS.SLEEPING = false;
            MainForm.NetVS.WAITING = 0;
            MainForm.NetVS.START_UP = Module.timeGetTime();
            MainForm.NetVS.IP_EP = MainForm.MemberList[this.listBoxMember.SelectedIndex].IP_EP;
            uint[] numArray1 = new uint[5]
            {
              0U,
              0U,
              0U,
              0U,
              0U
            };
            MainForm.NetVS.PING = numArray1;
            uint[] numArray2 = new uint[5]
            {
              0U,
              0U,
              0U,
              0U,
              0U
            };
            MainForm.NetVS.PONG = numArray2;
            byte[] numArray3 = new byte[32];
            numArray3[0] = (byte) 23;
            MainForm.NetVS.SEND = numArray3;
            MainForm.NetVS.L_FRAME = 0U;
            MainForm.NetVS.L_READ = 0;
            MainForm.NetVS.R_FRAME = 0U;
            MainForm.NetVS.L_READ = 0;
            MainForm.P1ID = MainForm.MemberList[this.listBoxMember.SelectedIndex].ID;
            MainForm.P2ID = MainForm.MemberList[0].ID;
            Module.memset( ((IntPtr) &Module.MTINFO + 42), 0, 64U);
            Module.memset( ((IntPtr) &Module.MTINFO + 106), 0, 64U);
            if (MainForm.ListView != (LIST_VIEW) 2)
            {
              IntPtr hglobal = Marshal.StringToHGlobalAuto(MainForm.MemberList[this.listBoxMember.SelectedIndex].NAME);
              Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 42), (char*) hglobal.ToPointer());
              Marshal.FreeHGlobal(hglobal);
              Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTINFO + 106), (char*) ((IntPtr) &Module.MTOPTION + 3444));
            }
            ++MainForm.MemberList[this.listBoxMember.SelectedIndex].NUM_VS;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTINFO + 40) = (sbyte) 1;
            MainForm.VersusThread = new Thread(new ThreadStart(this.RunVersus));
            MainForm.VersusThread.Name = "VsThread";
            MainForm.VersusThread.Start();
            return;
          }
          finally
          {
            Monitor.Exit((object) MainForm.MemberList);
          }
        }
        else if ((int) type == 3)
        {
          if (MainForm.ReplayFilePath == string.Empty)
          {
            this.openFileDialog1.InitialDirectory = new string((char*) ((IntPtr) &Module.MTOPTION + 1364));
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
              return;
            MainForm.ReplayFilePath = this.openFileDialog1.FileName;
          }
          char[] chArray1 = new char[5]
          {
            'T',
            'Y',
            'M',
            'T',
            'R'
          };
          BinaryReader binaryReader = new BinaryReader((Stream) System.IO.File.OpenRead(MainForm.ReplayFilePath));
          try
          {
            char[] chArray2 = binaryReader.ReadChars(chArray1.Length);
            for (int index = 0; index < chArray2.Length; ++index)
            {
              if ((int) chArray2[index] != (int) chArray1[index])
              {
                this.WriteMessage("Not a valid replay file.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
                return;
              }
            }
            char ch = binaryReader.ReadChar();
            if ((int) ch >= 49)
            {
              if ((int) ch <= 52)
                goto label_43;
            }
            this.WriteMessage("Invalid replay file version.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
            return;
          }
          finally
          {
            binaryReader.Close();
          }
        }
label_43:
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  @Module.MTINFO != 0)
        {
          this.WriteMessage("RunVersus() >> Params\n", MainForm.DebugMessageColor, MSGOPT.NONE);
          this.WriteMessage(string.Format("- P1id:\t {0}\n", (object) MainForm.P1ID), MainForm.DebugMessageColor, MSGOPT.NONE);
          this.WriteMessage(string.Format("- P2id:\t {0}\n", (object) MainForm.P2ID), MainForm.DebugMessageColor, MSGOPT.NONE);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          this.WriteMessage(string.Format("- Seed:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 8)), MainForm.DebugMessageColor, MSGOPT.NONE);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          this.WriteMessage(string.Format("- MaxStage:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 12)), MainForm.DebugMessageColor, MSGOPT.NONE);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          this.WriteMessage(string.Format("- Select:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 16)), MainForm.DebugMessageColor, MSGOPT.NONE);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          this.WriteMessage(string.Format("- Round:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 20)), MainForm.DebugMessageColor, MSGOPT.NONE);
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          this.WriteMessage(string.Format("- Timer:\t {0}\n", (object) (uint)  ((IntPtr) &Module.MTINFO + 24)), MainForm.DebugMessageColor, MSGOPT.NONE);
        }
        MainForm.GameThread = new Thread(new ParameterizedThreadStart(this.RunGame));
        MainForm.GameThread.Start((object) type);
        MainForm.GameThread.Name = "GameThread";
        MainForm.GameThread.Priority = MainForm.GetGameThreadPrioritySetting();
      }
      else if (Module.wcslen((char*) ((IntPtr) &Module.MTINFO + 170)) > 0U)
        this.WriteMessage(string.Format("{0} starting.\n", (object) new string((char*) ((IntPtr) &Module.MTINFO + 170))), MainForm.SystemMessageColor, MSGOPT.NONE);
      else
        this.WriteMessage("Another game is running.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
    }

    public unsafe void QuitGame()
    {
      if (MainForm.GameThread == null)
        return;
      if (!MainForm.GameThread.IsAlive)
        return;
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        Process.GetProcessById( ((IntPtr) &Module.MTINFO + 32)).CloseMainWindow();
      }
      catch (Exception ex)
      {
        MainForm.GameThread = (Thread) null;
      }
    }

    public void QuitWatch([MarshalAs(UnmanagedType.U1)] bool send_packet)
    {
      if (MainForm.WaitingWatch > 0U && MainForm.GameThread != null && MainForm.GameThread.IsAlive)
      {
        bool flag = (int) MainForm.WaitingWatch == 2;
        MainForm.WaitingWatch = 0U;
        if (flag)
        {
          Monitor.Enter((object) MainForm.WatchHistory);
          try
          {
            Monitor.Pulse((object) MainForm.WatchHistory);
          }
          finally
          {
            Monitor.Exit((object) MainForm.WatchHistory);
          }
        }
        this.QuitGame();
      }
      if (MainForm.WatchTarget != null && MainForm.UDP != null)
      {
        if (send_packet)
        {
          byte[] numArray1 = new byte[3];
          numArray1[0] = (byte) 30;
          byte[] numArray2 = numArray1;
          Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) numArray2, 1, 2);
          UdpClient udpClient1 = MainForm.UDP;
          byte[] datagram = numArray2;
          int length = datagram.Length;
          IPEndPoint endPoint = MainForm.WatchTarget;
          AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
          UdpClient udpClient2 = MainForm.UDP;
          udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        }
        IDisposable disposable = MainForm.WatchTarget as IDisposable;
        int num;
        if (disposable != null)
        {
          disposable.Dispose();
          num = 0;
        }
        else
          num = 0;
        MainForm.WatchTarget = (IPEndPoint) null;
      }
      int num1 = (int) MainForm.MemberList[0].STATE;
      if (num1 == 3)
        this.ChangeState((object) 0);
      if (num1 == 4)
        this.ChangeState((object) 1);
      this.toolStripMenuItemWatch.Text = "Spectate";
    }

    public void Restart()
    {
      if (MainForm.MYRELATIONS != null)
        MainForm.MYRELATIONS.SaveAll();
      if (MainForm.AfterCloseUDP)
        return;
      this.CloseUdp(true);
      MainForm.MemberList.Clear();
      this.listBoxMember.Items.Clear();
      this.Text = "Telepone";
      int num = (int) new StartupForm().ShowDialog((IWin32Window) this);
      MainForm.ListView = (LIST_VIEW) 0;
      this.Begin();
    }

    public unsafe void Leave([MarshalAs(UnmanagedType.U1)] bool send_packet)
    {
      if (this.listBoxMember.InvokeRequired)
      {
        this.BeginInvoke((Delegate) new BoolDelegate(this.Leave), new object[1]
        {
          (object) (bool) (send_packet ? 1 : 0)
        });
      }
      else
      {
        this.CloseUdp(send_packet);
        bool flag = Monitor.TryEnter((object) MainForm.MemberList, 500);
        try
        {
          this.listBoxMember.BeginUpdate();
          while (MainForm.MemberList.Count > 1)
          {
            MainForm.MemberList.RemoveAt(1);
            this.listBoxMember.Items.RemoveAt(1);
          }
          this.listBoxMember.EndUpdate();
        }
        finally
        {
          if (flag)
            Monitor.Exit((object) MainForm.MemberList);
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 520) = 3;
        MainForm.MemberList[0].TYPE = 3U;
        MainForm.MemberList[0].STATE = 0U;
        this.Text = "Telepone [Free Play]";
        this.listBoxMember.Refresh();
      }
    }

    public unsafe void ChangeState(object obj)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 520) == 3 || MainForm.UDP == null)
        return;
      byte num = (byte) obj;
      byte[] datagram1 = new byte[4]
      {
        (byte) 12,
        (byte) 0,
        (byte) 0,
        num
      };
      MainForm.MemberList[0].STATE = (uint) num;
      if (this.listBoxMember.InvokeRequired)
        this.listBoxMember.BeginInvoke((Delegate) new NoArgsDelegate(this.listBoxMember.Refresh));
      else
        this.listBoxMember.Refresh();
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
      {
        this.PacketSendAllMember(ref datagram1, 0U);
      }
      else
      {
        Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) datagram1, 1, 2);
        UdpClient udpClient1 = MainForm.UDP;
        byte[] datagram2 = datagram1;
        int length = datagram2.Length;
        IPEndPoint endPoint = MainForm.MemberList[1].IP_EP;
        AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
        UdpClient udpClient2 = MainForm.UDP;
        udpClient1.BeginSend(datagram2, length, endPoint, requestCallback, (object) udpClient2);
      }
    }

    public unsafe void CloseUdp([MarshalAs(UnmanagedType.U1)] bool send_packet)
    {
      if (MainForm.UDP == null)
        return;
      if (MainForm.SonarThread != null && MainForm.SonarThread.IsAlive && MainForm.Ranging)
      {
        MainForm.Ranging = false;
        if (MainForm.SonarSleeping)
          MainForm.SonarThread.Interrupt();
        MainForm.SonarThread.Join();
      }
      if (send_packet)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
        {
          byte[] datagram = new byte[3]
          {
            (byte) 10,
            (byte) 0,
            (byte) 0
          };
          this.PacketSendAllMember(ref datagram, 0U);
          MainForm.IDCounter = (ushort) 0;
        }
        else if (MainForm.MemberList.Count > 1)
        {
          byte[] numArray1 = new byte[3];
          numArray1[0] = (byte) 10;
          byte[] numArray2 = numArray1;
          Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) numArray2, 1, 2);
          UdpClient udpClient1 = MainForm.UDP;
          byte[] datagram = numArray2;
          int length = datagram.Length;
          IPEndPoint endPoint = MainForm.MemberList[1].IP_EP;
          AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
          UdpClient udpClient2 = MainForm.UDP;
          udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        }
      }
      if (MainForm.GameThread != null && MainForm.GameThread.IsAlive)
        MainForm.AfterCloseUDP = true;
      else
        MainForm.UDP.Close();
    }

    public unsafe void TalkMessage(ushort id, byte[] msg)
    {
      string str = (string) null;
      Color color = new Color();
      if (this.richTextBoxLog.InvokeRequired)
      {
        this.richTextBoxLog.BeginInvoke((Delegate) new MainForm.TalkMessageDelegate(this.TalkMessage), (object) id, (object) msg);
      }
      else
      {
        uint num = 0U;
        if (MainForm.UDP != null && MainForm.MemberList.Count > 1)
        {
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
          {
            this.PacketSendAllMember(ref msg, (uint) id);
            if (this.checkBoxDisableChat.Checked)
              return;
          }
          else
          {
            if (this.checkBoxDisableChat.Checked)
              return;
            if ((int) id != (int) ushort.MaxValue)
            {
              UdpClient udpClient1 = MainForm.UDP;
              byte[] datagram = msg;
              int length = datagram.Length;
              IPEndPoint endPoint = MainForm.MemberList[1].IP_EP;
              AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
              UdpClient udpClient2 = MainForm.UDP;
              udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
            }
            else
              id = BitConverter.ToUInt16(msg, 1);
          }
        }
        int index;
        for (index = 0; index < MainForm.MemberList.Count; ++index)
        {
          if ((int) id == (int) MainForm.MemberList[index].ID)
          {
            str = MainForm.MemberList[index].NAME;
            color = MainForm.NameColor[(int) MainForm.MemberList[index].TYPE];
            num = (uint) MainForm.MemberList[index].FAVPON;
            break;
          }
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (index >= MainForm.MemberList.Count &&  ((IntPtr) &Module.MTOPTION + 520) != 0 && MainForm.UDP != null)
        {
          str = "[ Unknown ] ";
          color = MainForm.ErrorMessageColor;
          byte[] numArray = new byte[3];
          numArray[0] = (byte) 7;
          byte[] dgram = numArray;
          Array.Copy((Array) BitConverter.GetBytes(id), 0, (Array) dgram, 1, 2);
          MainForm.UDP.Send(dgram, 3, MainForm.MemberList[1].IP_EP);
        }
        string name = str.Replace("/", " ");
        Monitor.Enter((object) MainForm.ChatHistory);
        try
        {
          this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
          int textLength = this.richTextBoxLog.TextLength;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ( ((IntPtr) &Module.MTOPTION + 520) == 0 && msg.Length > (int) msg[3] + 5)
          {
            int startIndex = (int) msg[3] + 4;
            int ID = BitConverter.ToInt32(msg, startIndex);
            if (MainForm.PACSCHED.IsDuplicatePacket(ID))
              return;
            MainForm.PACSCHED.MarkReceived(ID);
          }
          if (MainForm.MYRELATIONS.IsIgnored(name))
            return;
          DateTime now = DateTime.Now;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((int)  ((IntPtr) &Module.MTOPTION + 4046) != 0)
          {
            this.richTextBoxLog.SelectionColor = Color.Black;
            this.richTextBoxLog.AppendText(string.Format("[{0:hh}:{0:mm}:{0:ss}] ", (object) now));
            this.richTextBoxLog.SelectionColor = Pon.GetSecondaryColor((FAVORITE_PONY) num);
            this.richTextBoxLog.AppendText("<");
            this.richTextBoxLog.SelectionColor = Pon.GetMainColor((FAVORITE_PONY) num);
            this.richTextBoxLog.AppendText(string.Format("{0}", (object) name));
            this.richTextBoxLog.SelectionColor = Pon.GetSecondaryColor((FAVORITE_PONY) num);
            this.richTextBoxLog.AppendText("> ");
          }
          else
          {
            this.richTextBoxLog.SelectionColor = color;
            this.richTextBoxLog.AppendText(string.Format("[{0:hh}:{0:mm}:{0:ss}] <{1}> ", (object) now, (object) name));
          }
          this.richTextBoxLog.SelectionColor = MainForm.TalkMessageColor;
          if (!this.checkBox1Autoscroll.Checked)
          {
            this.richTextBoxLog.AppendText(Encoding.Unicode.GetString(msg, 4, (int) msg[3]) + "\n");
            if (this.richTextBoxLog.ContainsFocus)
              this.textBoxInput.Focus();
          }
          else
          {
            this.richTextBoxLog.AppendText(Encoding.Unicode.GetString(msg, 4, (int) msg[3]) + "\n");
            this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
            this.richTextBoxLog.ScrollToEnd();
          }
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((int)  ((IntPtr) &Module.MTOPTION + 4033) != 0 || (int)  ((IntPtr) &Module.MTOPTION + 4036) != 0 && MainForm.GameThread != null && MainForm.GameThread.IsAlive)
            return;
          this.richTextBoxLog.SelectionStart = textLength;
          this.richTextBoxLog.SelectionLength = 100000;
          this.richTextBoxLog.SelectedRtf = Module.EmoteExpanderExpandEmotes(this.richTextBoxLog.SelectedRtf + "\\", MainForm.GFXLOADER);
          if (!this.checkBox1Autoscroll.Checked)
            return;
          this.richTextBoxLog.ScrollToEnd();
        }
        catch (Exception ex)
        {
        }
        finally
        {
          Monitor.Exit((object) MainForm.ChatHistory);
        }
      }
    }

    public void WriteMessage(string msg, Color color, MSGOPT msgopt)
    {
      if (this.checkBoxDisableChat.Checked)
        return;
      if (this.richTextBoxLog.InvokeRequired)
      {
        this.richTextBoxLog.BeginInvoke((Delegate) new MainForm.WriteMessageDelegate(this.WriteMessage), (object) msg, (object) color, (object) msgopt);
      }
      else
      {
        Monitor.Enter((object) MainForm.ChatHistory);
        try
        {
          if (msgopt != MSGOPT.NOTIME)
            msg = string.Format("[{0:hh}:{0:mm}:{0:ss}] ", (object) DateTime.Now) + msg;
          if (this.richTextBoxLog.ContainsFocus)
            this.textBoxInput.Focus();
          this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
          this.richTextBoxLog.SelectionColor = color;
          this.richTextBoxLog.AppendText(msg);
          this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
          if (!this.checkBox1Autoscroll.Checked)
            return;
          this.richTextBoxLog.ScrollToEnd();
        }
        catch (ObjectDisposedException ex)
        {
        }
        catch (Exception ex)
        {
          Module.WriteErrorLog(ex.ToString(), "RichTextBox");
        }
        finally
        {
          Monitor.Exit((object) MainForm.ChatHistory);
        }
      }
    }

    public unsafe void WriteNotice(string msg)
    {
      if (this.checkBoxDisableChat.Checked)
        return;
      if (this.richTextBoxLog.InvokeRequired)
      {
        this.richTextBoxLog.BeginInvoke((Delegate) new MainForm.ColorlessMessageDelegate(this.WriteNotice), new object[1]
        {
          (object) msg
        });
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
        {
          try
          {
            new SoundPlayer(new string((char*) ((IntPtr) &Module.MTOPTION + 2404))).Play();
          }
          catch (Exception ex)
          {
          }
        }
        msg = msg.Replace("_", "\n");
        Monitor.Enter((object) MainForm.ChatHistory);
        try
        {
          if (this.richTextBoxLog.ContainsFocus)
            this.textBoxInput.Focus();
          msg = string.Format("[{0:hh}:{0:mm}:{0:ss}] ", (object) DateTime.Now) + msg;
          this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
          this.richTextBoxLog.AppendText("\n");
          this.richTextBoxLog.SelectionFont = new Font(this.richTextBoxLog.Font.FontFamily, this.richTextBoxLog.Font.Size + 2f);
          this.richTextBoxLog.SelectionColor = MainForm.TalkMessageColor;
          this.richTextBoxLog.SelectionBackColor = MainForm.NoticeBackColor;
          this.richTextBoxLog.AppendText(msg + "\n");
          this.richTextBoxLog.AppendText("\n");
          this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
          if (!this.checkBox1Autoscroll.Checked)
            return;
          this.richTextBoxLog.ScrollToCaret();
        }
        catch (Exception ex)
        {
          Module.WriteErrorLog(ex.ToString(), "RichTextBox");
        }
        finally
        {
          Monitor.Exit((object) MainForm.ChatHistory);
        }
      }
    }

    public unsafe void WriteComment(string name, int type, string comment)
    {
      if (this.checkBoxDisableChat.Checked)
        return;
      if (this.richTextBoxLog.InvokeRequired)
      {
        this.richTextBoxLog.BeginInvoke((Delegate) new MainForm.WriteCommentDelegate(this.WriteComment), (object) name, (object) type, (object) comment);
      }
      else
      {
        if (MainForm.ListView == (LIST_VIEW) 2)
          return;
        try
        {
          new SoundPlayer(new string((char*) ((IntPtr) &Module.MTOPTION + 2924))).Play();
        }
        catch (Exception ex)
        {
        }
        if (comment.Length > 0)
        {
          Monitor.Enter((object) MainForm.ChatHistory);
          try
          {
            name = string.Format("[{0:hh}:{0:mm}:{0:ss}] ", (object) DateTime.Now) + name;
            this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
            this.richTextBoxLog.SelectionColor = MainForm.NameColor[type];
            this.richTextBoxLog.SelectionBackColor = MainForm.CommentBackColor;
            if (this.checkBox1Autoscroll.Checked)
            {
              this.richTextBoxLog.AppendText(string.Format(" {0} ", (object) name));
              this.richTextBoxLog.ScrollToEnd();
            }
            else
              this.richTextBoxLog.AppendText(string.Format(" {0} ", (object) name));
            this.richTextBoxLog.SelectionColor = MainForm.TalkMessageColor;
            this.richTextBoxLog.SelectionBackColor = MainForm.CommentBackColor;
            if (this.checkBox1Autoscroll.Checked)
            {
              this.richTextBoxLog.AppendText(comment + "\n");
              this.richTextBoxLog.ScrollToEnd();
            }
            else
              this.richTextBoxLog.AppendText(comment + "\n");
            this.richTextBoxLog.SelectionStart = this.richTextBoxLog.TextLength;
            if (!this.checkBox1Autoscroll.Checked)
              return;
            this.richTextBoxLog.ScrollToEnd();
          }
          catch (Exception ex)
          {
            Module.WriteErrorLog(ex.ToString(), "RichTextBox");
          }
          finally
          {
            Monitor.Exit((object) MainForm.ChatHistory);
          }
        }
        else
          this.WriteMessage(string.Format("{0} has joined.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
      }
    }

    public void WriteCommandList()
    {
      this.WriteMessage("/help - Display command list\n/clear - Delete entire log\n/log - Save log in Rich Text format (.rtf)\n/debug - Switch to debug mode\n/vs - Challenge a random opponent\n/game - Boot game\n/gg - print your gg message\n/comment - print your comment\n/replay - Play replay file\n/quit - Close currently running game\n/restart - Start new connection\n/rest - Toggle rest mode (You cannot be challenged while resting)\n/list - Toggle list display\n/leave - Leave and switch to free play\n/exit ： Exit program\n", MainForm.SystemMessageColor, MSGOPT.NONE);
    }

    public unsafe void RandomVersus()
    {
      if (MainForm.ServerMode == (SERVER_MODE) 1)
      {
        this.WriteMessage("Server isn't in a mode that supports random versus\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 3 || (int) MainForm.MemberList[0].STATE != 0)
          return;
        uint num1 = 0U;
        List<int> list = new List<int>();
        string name = "";
        Monitor.Enter((object) MainForm.MemberList);
        try
        {
          for (int index = 1; index < MainForm.MemberList.Count; ++index)
          {
            if ((int) MainForm.MemberList[index].STATE != 0)
              continue;
            list.Add(index);
          }
          if (list.Count > 0)
            num1 = (uint) list[(int) (Module.XorShift(0U) % (uint) list.Count)];
          name = MainForm.MemberList[(int) num1].NAME;
        }
        finally
        {
          Monitor.Exit((object) MainForm.MemberList);
        }
        if (num1 > 0U)
        {
          this.listBoxMember.SelectedIndex = (int) num1;
          if (MainForm.MYRELATIONS.IsDeclining(name))
            this.WriteMessage(string.Format("Randomed {0}, but you are declining their matches\n", (object) MainForm.MemberList[(int) num1].NAME), MainForm.SystemMessageColor, MSGOPT.NONE);
          else if (MainForm.MYRELATIONS.GetAveragePing(name) != -1)
          {
            Decimal num2 = this.textBoxMaxChallengePing.Value;
            if (!((Decimal) MainForm.MYRELATIONS.GetAveragePing(name) > num2))
              return;
            this.WriteMessage(string.Format("Challenge cancelled because {0} has an average ping of {1}.\n", (object) name, (object) MainForm.MYRELATIONS.GetAveragePing(name)), MainForm.SystemMessageColor, MSGOPT.NONE);
          }
          else
            this.StartGame(2U);
        }
        else
          this.WriteMessage("No one capable of being challenged.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      }
    }

    [return: MarshalAs(UnmanagedType.U1)]
    public unsafe bool AnalyzeCommand()
    {
      bool flag = true;
      if (this.textBoxInput.Text.StartsWith("/help", StringComparison.OrdinalIgnoreCase))
        this.WriteCommandList();
      else if (this.textBoxInput.Text.StartsWith("/clear", StringComparison.OrdinalIgnoreCase))
        this.richTextBoxLog.Clear();
      else if (this.textBoxInput.Text.StartsWith("/log", StringComparison.OrdinalIgnoreCase))
      {
        string str1 = new string((char*) &Module.MTOPTION);
        string str2 = string.Format("MT_{0}.rtf", (object) DateTime.Now.ToString("yyMMdd-HHmmss"));
        string path = str1 + str2;
        Monitor.Enter((object) MainForm.ChatHistory);
        try
        {
          this.richTextBoxLog.SaveFile(path, RichTextBoxStreamType.RichText);
        }
        catch (Exception ex)
        {
          Module.WriteErrorLog(ex.ToString(), "SaveLog");
        }
        finally
        {
          Monitor.Exit((object) MainForm.ChatHistory);
        }
        this.WriteMessage(string.Format("Saved to log file \"{0}\".\n", (object) str2), MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      else if (this.textBoxInput.Text.StartsWith("/debug", StringComparison.OrdinalIgnoreCase))
      {
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         @Module.MTINFO = (sbyte) ((int)  @Module.MTINFO ^ 1);
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  @Module.MTINFO != 0)
          this.WriteMessage("Debug mode: On\n", MainForm.SystemMessageColor, MSGOPT.NONE);
        else
          this.WriteMessage("Debug mode: Off\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      else if (this.textBoxInput.Text.StartsWith("/vs", StringComparison.OrdinalIgnoreCase))
        this.RandomVersus();
      else if (this.textBoxInput.Text.StartsWith("/game", StringComparison.OrdinalIgnoreCase))
        this.StartGame(1U);
      else if (this.textBoxInput.Text.StartsWith("/replay", StringComparison.OrdinalIgnoreCase))
      {
        MainForm.ReplayFilePath = string.Empty;
        this.StartGame(3U);
      }
      else if (this.textBoxInput.Text.StartsWith("/quit", StringComparison.OrdinalIgnoreCase))
        this.QuitGame();
      else if (this.textBoxInput.Text.StartsWith("/restart", StringComparison.OrdinalIgnoreCase))
        this.Restart();
      else if (this.textBoxInput.Text.StartsWith("/rest", StringComparison.OrdinalIgnoreCase))
      {
        if ((int) MainForm.MemberList[0].STATE == 0 || (int) MainForm.MemberList[0].STATE == 5)
          this.ChangeState((object) 1);
        else if ((int) MainForm.MemberList[0].STATE == 1)
          this.ChangeState((object) 0);
      }
      else if (this.textBoxInput.Text.StartsWith("/list", StringComparison.OrdinalIgnoreCase))
        this.ChangeListView(true);
      else if (this.textBoxInput.Text.StartsWith("/time", StringComparison.OrdinalIgnoreCase))
        this.WriteMessage(string.Format("{0} {1}\n", (object) DateTime.Now.ToLongDateString(), (object) DateTime.Now.ToLongTimeString()), MainForm.SecretColor, MSGOPT.NONE);
      else if (this.textBoxInput.Text.StartsWith("/gg", StringComparison.OrdinalIgnoreCase))
      {
        this.textBoxInput.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3838));
        flag = false;
      }
      else if (this.textBoxInput.Text.StartsWith("/comment", StringComparison.OrdinalIgnoreCase))
      {
        this.textBoxInput.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3508));
        flag = false;
      }
      else if (!this.textBoxInput.Text.StartsWith("/dice", StringComparison.OrdinalIgnoreCase))
      {
        if (this.textBoxInput.Text.StartsWith("/leave", StringComparison.OrdinalIgnoreCase))
          this.Leave(true);
        else if (this.textBoxInput.Text.StartsWith("/exit", StringComparison.OrdinalIgnoreCase))
          this.Close();
        else if (this.textBoxInput.Text.StartsWith("/udpstat", StringComparison.OrdinalIgnoreCase))
        {
          MainForm mainForm = this;
          mainForm.UdpStatOut((object) mainForm);
        }
        else if (this.textBoxInput.Text.StartsWith("/blreload", StringComparison.OrdinalIgnoreCase))
          MainForm.MYRELATIONS.LoadList("bl.txt", (RELATION_TYPE) 2);
        else if (this.textBoxInput.Text.StartsWith("/exeini", StringComparison.OrdinalIgnoreCase))
        {
          try
          {
            ArrayTypeBY09_W arrayTypeBy09W;
            ArrayTypeBY0BAE_W arrayTypeBy0BaEW1;
            Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy09W, 20U, (char*) &arrayTypeBy0BaEW1, 260U, (char*) 0, 0U, (char*) 0, 0U);
            ArrayTypeBY0BAE_W arrayTypeBy0BaEW2;
            Module.swprintf_s260(&arrayTypeBy0BaEW2, (char*) &Module._C_1BKLOLHAEAGAACFAAsAACFAAsAAgAAaAAmAAeAA4AAiAAnAAiAAAA, __arglist (out arrayTypeBy09W, out arrayTypeBy0BaEW1));
            Process.Start(new string((char*) &arrayTypeBy0BaEW2));
          }
          catch (Exception ex)
          {
            this.WriteMessage("Failed to open game.ini", MainForm.ErrorMessageColor, MSGOPT.NONE);
          }
        }
      }
      return flag;
    }

    public void AddListView(ref MemberInfo info)
    {
      if (this.listBoxMember.InvokeRequired)
      {
        this.BeginInvoke((Delegate) new MainForm.AddMemberDelegate(this.AddListView), new object[1]
        {
          (object) info
        });
      }
      else
      {
        switch (MainForm.ListView)
        {
          case (LIST_VIEW) 0:
            this.listBoxMember.Items.Add((object) info.NAME);
            break;
          case (LIST_VIEW) 1:
            if (info.COMMENT.Length > 0)
            {
              this.listBoxMember.Items.Add((object) info.COMMENT);
              break;
            }
            else
            {
              this.listBoxMember.Items.Add((object) "◆");
              break;
            }
          case (LIST_VIEW) 2:
            this.listBoxMember.Items.Add((object) "◆");
            break;
        }
      }
    }

    public void ChangeListView([MarshalAs(UnmanagedType.U1)] bool auto_change)
    {
      this.listBoxMember.SelectedIndex = -1;
      if (MainForm.ListView == (LIST_VIEW) 2)
        return;
      if (auto_change)
      {
        switch (MainForm.ListView)
        {
          case (LIST_VIEW) 0:
            MainForm.ListView = (LIST_VIEW) 1;
            break;
          case (LIST_VIEW) 1:
            MainForm.ListView = (LIST_VIEW) 0;
            break;
        }
      }
      Monitor.Enter((object) MainForm.MemberList);
      try
      {
        for (int index = 0; index < this.listBoxMember.Items.Count; ++index)
        {
          switch (MainForm.ListView)
          {
            case (LIST_VIEW) 0:
              this.listBoxMember.Items[index] = (object) MainForm.MemberList[index].NAME;
              break;
            case (LIST_VIEW) 1:
              this.listBoxMember.Items[index] = MainForm.MemberList[index].COMMENT.Length <= 0 ? (object) "◆" : (object) MainForm.MemberList[index].COMMENT;
              break;
            case (LIST_VIEW) 2:
              this.listBoxMember.Items[index] = (object) "◆";
              break;
          }
        }
      }
      finally
      {
        Monitor.Exit((object) MainForm.MemberList);
      }
    }

    public unsafe void ResetDelay(uint value)
    {
      this.toolStripMenuItemDelayAuto.Checked = false;
      this.toolStripMenuItemDelay2.Checked = false;
      this.toolStripMenuItemDelay3.Checked = false;
      this.toolStripMenuItemDelay4.Checked = false;
      this.toolStripMenuItemDelay5.Checked = false;
      this.toolStripMenuItemDelay6.Checked = false;
      this.toolStripMenuItemDelay7.Checked = false;
      this.toolStripMenuItemDelay8.Checked = false;
      this.toolStripMenuItemDelay9.Checked = false;
      this.toolStripMenuItemDelay10.Checked = false;
      this.toolStripMenuItemDelay11.Checked = false;
      this.toolStripMenuItemDelay12.Checked = false;
      switch (value - 2U)
      {
        case 0U:
          this.toolStripMenuItemDelay2.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 2;
          break;
        case 1U:
          this.toolStripMenuItemDelay3.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 3;
          break;
        case 2U:
          this.toolStripMenuItemDelay4.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 4;
          break;
        case 3U:
          this.toolStripMenuItemDelay5.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 5;
          break;
        case 4U:
          this.toolStripMenuItemDelay6.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 6;
          break;
        case 5U:
          this.toolStripMenuItemDelay7.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 7;
          break;
        case 6U:
          this.toolStripMenuItemDelay8.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 8;
          break;
        case 7U:
          this.toolStripMenuItemDelay9.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 9;
          break;
        case 8U:
          this.toolStripMenuItemDelay10.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 10;
          break;
        case 9U:
          this.toolStripMenuItemDelay11.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 11;
          break;
        case 10U:
          this.toolStripMenuItemDelay12.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 12;
          break;
        default:
          this.toolStripMenuItemDelayAuto.Checked = true;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4012) = 0;
          break;
      }
    }

    public unsafe void ChangeComment(string comment)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (MainForm.UDP == null ||  ((IntPtr) &Module.MTOPTION + 520) != 3 && MainForm.ServerMode >= (SERVER_MODE) 2)
        return;
      MainForm.MemberList[0].COMMENT = comment;
      if (MainForm.ListView == (LIST_VIEW) 1)
        this.listBoxMember.Items[0] = comment.Length <= 0 ? (object) "◆" : (object) comment;
      byte num = (byte) (comment.Length * 2);
      byte[] datagram1 = new byte[(int) num + 4];
      datagram1[0] = (byte) 15;
      Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) datagram1, 1, 2);
      datagram1[3] = num;
      Array.Copy((Array) Encoding.Unicode.GetBytes(comment), 0, (Array) datagram1, 4, (int) num);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
      {
        this.PacketSendAllMember(ref datagram1, 0U);
      }
      else
      {
        UdpClient udpClient1 = MainForm.UDP;
        byte[] datagram2 = datagram1;
        int length = datagram2.Length;
        IPEndPoint endPoint = MainForm.MemberList[1].IP_EP;
        AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
        UdpClient udpClient2 = MainForm.UDP;
        udpClient1.BeginSend(datagram2, length, endPoint, requestCallback, (object) udpClient2);
      }
    }

    public unsafe void ResetColor()
    {
      Color[] colorArray1 = new Color[4];
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Color color1 = Color.FromArgb( @Module.MTCOLOR);
      colorArray1[0] = color1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Color color2 = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 4));
      colorArray1[1] = color2;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Color color3 = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 8));
      colorArray1[2] = color3;
      Color windowText = SystemColors.WindowText;
      colorArray1[3] = windowText;
      MainForm.NameColor = colorArray1;
      Color[] colorArray2 = new Color[4];
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Color color4 = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 12));
      colorArray2[0] = color4;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Color color5 = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 16));
      colorArray2[1] = color5;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      Color color6 = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 20));
      colorArray2[2] = color6;
      Color color7 = Color.FromArgb(Color.White.ToArgb());
      colorArray2[3] = color7;
      MainForm.StateRectColor = colorArray2;
      MainForm.TalkMessageColor = SystemColors.WindowText;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      MainForm.SystemMessageColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 24));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      MainForm.ErrorMessageColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 28));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      MainForm.DebugMessageColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 32));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      MainForm.NoticeBackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 36));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      MainForm.CommentBackColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 40));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      MainForm.SecretColor = Color.FromArgb( ((IntPtr) &Module.MTCOLOR + 44));
    }

    private unsafe void MainForm_Load(object sender, EventArgs e)
    {
      this.richTextBoxLog.LanguageOption = RichTextBoxLanguageOptions.UIFonts;
      Control.CheckForIllegalCrossThreadCalls = false;
      MainForm.GFXLOADER = new GFXLoader();
      MainForm.GFXLOADER.Init();
      MainForm.PACSCHED = new PacketScheduler();
      MainForm.PRIZEMAN = new PrizeManager();
      MainForm.SpecDbgWnd = new GenericResultsWindow();
      MainForm.SpecDbgWnd.Text = "Spectator diagnostics";
      this.ProfileDisplayAnchored.Location = new Point(1, 1);
      this.ProfileDisplayAnchored.Name = "ProfileDisplayAnchored";
      this.ProfileDisplayAnchored.Size = new Size(100, 50);
      this.ProfileDisplayAnchored.TabIndex = 1;
      this.ProfileDisplayAnchored.TabStop = false;
      this.ProfileDisplayAnchored.SetImage(MainForm.GFXLOADER.GetLoadedImage("PROFILE-BG"));
      this.ProfileDisplayAnchored.SetGFXLoaderRef(MainForm.GFXLOADER);
      this.LoadGameSettingsPresets();
      MainForm.LastMemberRefresh = 0;
      MainForm.LastMemberIndex = -1;
      MainForm.LastReplayPath = string.Empty;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.textBoxMaxChallengePing.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 4024));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.noSinglePlayerReplaysToolStripMenuItem.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4037);
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( @Module.MTWS > 0 &&  ((IntPtr) &Module.MTWS + 4) > 0)
      {
        this.StartPosition = FormStartPosition.Manual;
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.Location = new Point( @Module.MTWS,  ((IntPtr) &Module.MTWS + 4));
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTWS + 8) > 0 &&  ((IntPtr) &Module.MTWS + 12) > 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.ClientSize = new Size( ((IntPtr) &Module.MTWS + 8),  ((IntPtr) &Module.MTWS + 12));
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTWS + 16) > 0)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.splitContainer1.SplitterDistance =  ((IntPtr) &Module.MTWS + 16);
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.ResetDelay((uint)  ((IntPtr) &Module.MTOPTION + 4012));
      this.ResetColor();
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.toolStripMenuItemRecordReplay.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4028);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.toolStripMenuItemAllowSpectator.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4029);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.toolStripMenuItemAfterRest.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4030);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.restOnConnectToolStripMenuItem.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4031);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.toolStripMenuItemDisableEmotes.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4033);
      MainForm.IsFormClosing = false;
      MainForm.ListView = (LIST_VIEW) 0;
      MainForm.ChatHistoryNumber = 0;
      MainForm.ChatHistory = new List<string>();
      MainForm.UDP = (UdpClient) null;
      MainForm.MemberList = new List<MemberInfo>();
      MainForm.SpectatorList = new List<MainForm.SpectatorInfo>();
      MainForm.WatchHistory = new ushort[1800];
      MainForm.InputHistory = new ushort[1800];
      int num = (int) Module.timeBeginPeriod(1U);
    }

    private unsafe void MainForm_Shown(object sender, EventArgs e)
    {
      this.textBoxInput.Focus();
      this.toolStripMenuItemVersion_Click((object) null, (EventArgs) null);
      int num1 = (int) new StartupForm().ShowDialog((IWin32Window) this);
      if (!System.IO.File.Exists(new string((char*) ((IntPtr) &Module.MTOPTION + 844))))
      {
        int num2 = (int) MessageBox.Show("Please set the path to the executable file.", "No game file");
        int num3 = (int) new OptionForm()
        {
          GameExePathError = true
        }.ShowDialog((IWin32Window) this);
      }
      this.Begin();
    }

    private unsafe void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!MainForm.IsFormClosing && MainForm.GameThread != null && MainForm.GameThread.IsAlive)
      {
        MainForm.IsFormClosing = true;
        this.QuitGame();
        e.Cancel = true;
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 0 && MessageBox.Show("Exit server?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
          MainForm.IsFormClosing = false;
          e.Cancel = true;
        }
        else
        {
          this.QuitWatch(true);
          this.CloseUdp(true);
          // ISSUE: explicit reference operation
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          if ((int)  @Module.MTINFO == 0)
            return;
          string path = new string((char*) &Module.MTOPTION) + "log.rtf";
          Monitor.Enter((object) MainForm.ChatHistory);
          try
          {
            this.richTextBoxLog.SaveFile(path, RichTextBoxStreamType.RichText);
          }
          catch (Exception ex)
          {
            Module.WriteErrorLog(ex.ToString(), "SaveLog");
          }
          finally
          {
            Monitor.Exit((object) MainForm.ChatHistory);
          }
        }
      }
    }

    private unsafe void MainForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      Point location1 = this.Location;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       @Module.MTWS = location1.X;
      Point location2 = this.Location;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTWS + 4) = location2.Y;
      Size clientSize1 = this.ClientSize;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTWS + 8) = clientSize1.Width;
      Size clientSize2 = this.ClientSize;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTWS + 12) = clientSize2.Height;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTWS + 16) = this.splitContainer1.SplitterDistance;
      if (MainForm.MYRELATIONS != null)
        MainForm.MYRELATIONS.SaveAll();
      int num = (int) Module.timeEndPeriod(1U);
    }

    private unsafe void textBoxInput_KeyDown(object sender, KeyEventArgs e)
    {
      if (MainForm.ChatHistory.Count > 0)
      {
        if (e.KeyCode == Keys.Up)
        {
          --MainForm.ChatHistoryNumber;
          if (MainForm.ChatHistoryNumber < 0)
            MainForm.ChatHistoryNumber = 0;
          this.textBoxInput.Text = MainForm.ChatHistory[MainForm.ChatHistoryNumber];
          this.textBoxInput.SelectAll();
          e.SuppressKeyPress = true;
        }
        else if (e.KeyCode == Keys.Down)
        {
          ++MainForm.ChatHistoryNumber;
          if (MainForm.ChatHistoryNumber > MainForm.ChatHistory.Count)
            MainForm.ChatHistoryNumber = MainForm.ChatHistory.Count;
          if (MainForm.ChatHistoryNumber == MainForm.ChatHistory.Count)
          {
            this.textBoxInput.Clear();
          }
          else
          {
            this.textBoxInput.Text = MainForm.ChatHistory[MainForm.ChatHistoryNumber];
            this.textBoxInput.SelectAll();
            e.SuppressKeyPress = true;
          }
        }
      }
      if (e.KeyCode != Keys.Return || this.textBoxInput.TextLength <= 0)
        return;
      if (MainForm.ChatHistoryNumber < MainForm.ChatHistory.Count)
      {
        if (MainForm.ChatHistory[MainForm.ChatHistoryNumber] != this.textBoxInput.Text)
          MainForm.ChatHistory.Add(this.textBoxInput.Text);
      }
      else
        MainForm.ChatHistory.Add(this.textBoxInput.Text);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((uint)  ((IntPtr) &Module.MTOPTION + 4008) > 0U && (uint) MainForm.ChatHistory.Count > (uint)  ((IntPtr) &Module.MTOPTION + 4008))
        MainForm.ChatHistory.RemoveAt(0);
      MainForm.ChatHistoryNumber = MainForm.ChatHistory.Count;
      bool flag = true;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (e.Control &&  ((IntPtr) &Module.MTOPTION + 520) == 0)
      {
        byte num = (byte) (this.textBoxInput.TextLength * 2);
        byte[] datagram = new byte[(int) num + 2];
        datagram[0] = (byte) 6;
        datagram[1] = num;
        Array.Copy((Array) Encoding.Unicode.GetBytes(this.textBoxInput.Text), 0, (Array) datagram, 2, (int) num);
        this.PacketSendAllMember(ref datagram, 0U);
        MainForm mainForm = this;
        string text = mainForm.textBoxInput.Text;
        mainForm.WriteNotice(text);
      }
      else if ((int) this.textBoxInput.Text[0] == 47)
        flag = this.AnalyzeCommand();
      else if (MainForm.UDP != null && MainForm.ServerMode >= (SERVER_MODE) 2)
        this.WriteMessage("Chat is not allowed.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      else if (MainForm.UDP != null)
      {
        TextBox textBox = this.textBoxInput;
        MainForm mainForm = this;
        string text = mainForm.textBoxInput.Text;
        string str = mainForm.RemoveReservedStrings(text);
        textBox.Text = str;
        byte num1 = (byte) (this.textBoxInput.TextLength * 2);
        byte[] msg = new byte[(int) num1 + 8];
        int num2 = new Random((int) Module.timeGetTime()).Next();
        msg[0] = (byte) 5;
        Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) msg, 1, 2);
        msg[3] = num1;
        Array.Copy((Array) Encoding.Unicode.GetBytes(this.textBoxInput.Text), 0, (Array) msg, 4, (int) num1);
        Array.Copy((Array) BitConverter.GetBytes(num2), 0, (Array) msg, (int) num1 + 4, 4);
        this.TalkMessage(MainForm.MemberList[0].ID, msg);
      }
      else
      {
        MainForm mainForm = this;
        string msg = mainForm.textBoxInput.Text + "\n";
        Color color = MainForm.TalkMessageColor;
        int num = 0;
        mainForm.WriteMessage(msg, color, (MSGOPT) num);
      }
      if (flag)
        this.textBoxInput.Clear();
      e.SuppressKeyPress = true;
    }

    private unsafe void listBoxMember_DrawItem(object sender, DrawItemEventArgs e)
    {
      if (e.Index == -1)
        return;
      try
      {
        uint num1 = MainForm.MemberList[e.Index].STATE;
        Brush brush = (Brush) new SolidBrush(MainForm.NameColor[(int) MainForm.MemberList[e.Index].TYPE]);
        Pen pen = new Pen(Color.FromName("Black"));
        switch (num1 - 1U)
        {
          case 0U:
            Rectangle bounds1 = e.Bounds;
            e.Graphics.FillRectangle((Brush) new SolidBrush(MainForm.StateRectColor[0]), bounds1);
            break;
          case 1U:
            Rectangle bounds2 = e.Bounds;
            e.Graphics.FillRectangle((Brush) new SolidBrush(MainForm.StateRectColor[1]), bounds2);
            break;
          case 2U:
          case 3U:
            Rectangle bounds3 = e.Bounds;
            e.Graphics.FillRectangle((Brush) new SolidBrush(MainForm.StateRectColor[2]), bounds3);
            break;
          case 4U:
            Rectangle bounds4 = e.Bounds;
            Color color = Color.FromName("Light gray");
            e.Graphics.FillRectangle((Brush) new SolidBrush(color), bounds4);
            break;
          default:
            e.DrawBackground();
            break;
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if (1 != 0 &&  ((IntPtr) &Module.MTOPTION + 4080) != 2)
        {
          Rectangle rect = new Rectangle();
          rect.Height = 16;
          rect.Width = 18;
          Point location1 = e.Bounds.Location;
          rect.X = location1.X;
          Point location2 = e.Bounds.Location;
          rect.Y = location2.Y;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
          Bitmap bitmap =  ((IntPtr) &Module.MTOPTION + 4080) != 0 ? MainForm.GFXLOADER.GetCutieMark(MainForm.MemberList[e.Index].FAVPON) : MainForm.GFXLOADER.GetFavPonyImage(MainForm.MemberList[e.Index].FAVPON);
          if (bitmap != null && MainForm.MemberList[e.Index].FAVPON != (FAVORITE_PONY) 0)
            e.Graphics.DrawImage((Image) bitmap, rect);
        }
        PointF point = (PointF) e.Bounds.Location;
        if (1 != 0)
        {
          point.X = point.X + 19f;
          float num2 = point.Y + 1f;
          point.Y = num2;
        }
        else
          point.X = point.X + 0.0f;
        e.Graphics.DrawString(this.listBoxMember.Items[e.Index].ToString(), e.Font, brush, point);
        e.DrawFocusRectangle();
        IDisposable disposable1 = (IDisposable) pen;
        int num3;
        if (disposable1 != null)
        {
          disposable1.Dispose();
          num3 = 0;
        }
        else
          num3 = 0;
        IDisposable disposable2 = (IDisposable) brush;
        int num4;
        if (disposable2 != null)
        {
          disposable2.Dispose();
          num4 = 0;
        }
        else
          num4 = 0;
      }
      catch (ArgumentOutOfRangeException ex)
      {
      }
      catch (IndexOutOfRangeException ex)
      {
      }
    }

    private unsafe void listBoxMember_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      int index = this.listBoxMember.IndexFromPoint(e.X, e.Y);
      if (index == -1)
        this.ChangeListView(true);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 520) == 3)
        return;
      if (index == 0)
      {
        switch (MainForm.MemberList[0].STATE)
        {
          case 0U:
            this.ChangeState((object) 1);
            break;
          case 1U:
            this.ChangeState((object) 0);
            break;
          case 2U:
            this.WriteMessage("Battle interrupted.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
            this.QuitGame();
            break;
          case 3U:
          case 4U:
            this.WriteMessage("Spectating interrupted.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
            this.QuitWatch(true);
            break;
        }
      }
      else
      {
        if (index <= 0 || MainForm.UDP == null)
          return;
        byte[] numArray1 = new byte[3];
        numArray1[0] = (byte) 13;
        byte[] numArray2 = numArray1;
        Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[index].ID), 0, (Array) numArray2, 1, 2);
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 0)
        {
          UdpClient udpClient1 = MainForm.UDP;
          byte[] datagram = numArray2;
          int length = datagram.Length;
          IPEndPoint endPoint = MainForm.MemberList[index].IP_EP;
          AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
          UdpClient udpClient2 = MainForm.UDP;
          udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        }
        else
        {
          UdpClient udpClient1 = MainForm.UDP;
          byte[] datagram = numArray2;
          int length = datagram.Length;
          IPEndPoint endPoint = MainForm.MemberList[1].IP_EP;
          AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
          UdpClient udpClient2 = MainForm.UDP;
          udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        }
        this.toolStripMenuItemPing_Click((object) null, (EventArgs) null);
      }
    }

    private unsafe void listBoxMember_MouseMove(object sender, MouseEventArgs e)
    {
      string str1 = (string) null;
      string str2 = (string) null;
      int index = this.listBoxMember.IndexFromPoint(e.X, e.Y);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if (index == -1 ||  ((IntPtr) &Module.MTOPTION + 520) == 3 || MainForm.ListView == (LIST_VIEW) 2)
      {
        this.toolTipMember.Active = false;
        MainForm.LastMemberIndex = -1;
        this.ProfileDisplayAnchored.Deactivate();
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  ((IntPtr) &Module.MTOPTION + 4036) != 0 && MainForm.GameThread != null && MainForm.GameThread.IsAlive)
        {
          this.toolTipMember.Active = false;
        }
        else
        {
          string str3 = string.Format("ID = {0}", (object) MainForm.MemberList[index].ID);
          StringBuilder stringBuilder = new StringBuilder("Total VS time: ");
          if (index > 0)
          {
            ValueType valueType1 = (ValueType) new TimeSpan();
            (TimeSpan) valueType1 = new TimeSpan((long) MainForm.MYRELATIONS.GetVsTime(MainForm.MemberList[index].NAME));
            ValueType valueType2 = valueType1;
            int days = TimeSpan.FromTicks(((TimeSpan) valueType2).Ticks).Days;
            if (days > 0)
            {
              int num = days;
              stringBuilder.Append(num.ToString() + "d ");
            }
            int hours = TimeSpan.FromTicks(((TimeSpan) valueType2).Ticks).Hours;
            if (hours > 0)
            {
              int num = hours;
              stringBuilder.Append(num.ToString() + "h ");
            }
            int minutes = TimeSpan.FromTicks(((TimeSpan) valueType2).Ticks).Minutes;
            if (minutes > 0)
            {
              int num = minutes;
              stringBuilder.Append(num.ToString() + "m ");
            }
            int seconds = TimeSpan.FromTicks(((TimeSpan) valueType2).Ticks).Seconds;
            stringBuilder.Append(seconds.ToString() + "s ");
            str1 = str3 + stringBuilder.ToString();
          }
          if (index == MainForm.LastMemberIndex)
            return;
          string comment = MainForm.MemberList[index].COMMENT;
          int length = comment.IndexOf("\n");
          if (length != -1)
            comment = MainForm.MemberList[index].COMMENT.Substring(0, length);
          string name = MainForm.MemberList[index].NAME;
          this.ProfileDisplayAnchored.SetVSTime(stringBuilder.ToString());
          bool good_ip = MainForm.MYRELATIONS.MatchesSavedIP(name, MainForm.MemberList[index].IP_EP);
          str2 = MainForm.MemberList[index].IP_EP.Address.ToString();
          this.ProfileDisplayAnchored.SetIP(MainForm.MemberList[index].IP_EP, good_ip);
          this.ProfileDisplayAnchored.SetName(name);
          this.ProfileDisplayAnchored.SetRegion(MainForm.MemberList[index].REGION);
          this.ProfileDisplayAnchored.SetAvgPing(MainForm.MYRELATIONS.GetAveragePing(name));
          this.ProfileDisplayAnchored.SetLookingFor(MainForm.MemberList[index].LOOKINGFOR);
          this.ProfileDisplayAnchored.SetNotLookingFor(MainForm.MemberList[index].NOTLOOKING);
          this.ProfileDisplayAnchored.SetComment(comment);
          this.ProfileDisplayAnchored.SetFavPon(MainForm.MemberList[index].FAVPON);
          this.ProfileDisplayAnchored.SetID((int) MainForm.MemberList[index].ID);
          this.ProfileDisplayAnchored.SetStatus(MainForm.MYRELATIONS.IsIgnored(name), MainForm.MYRELATIONS.IsDeclining(name), MainForm.MYRELATIONS.IsBlacklisted(MainForm.MemberList[index].IP_EP), false);
          this.ProfileDisplayAnchored.SetWinLoss(MainForm.MYRELATIONS.GetWins(name), MainForm.MYRELATIONS.GetLosses(name));
          this.ProfileDisplayAnchored.Invalidate();
          this.ProfileDisplayAnchored.Activate();
          MainForm.LastMemberIndex = index;
        }
      }
    }

    private void toolStripMenuItemSetting_Click(object sender, EventArgs e)
    {
      if (MainForm.Option == null || MainForm.Option.IsDisposed)
      {
        MainForm.Option = new OptionForm();
        MainForm.Option.Show((IWin32Window) this);
      }
      else
        MainForm.Option.Activate();
    }

    private void toolStripMenuItemViewCommand_Click(object sender, EventArgs e)
    {
      this.WriteCommandList();
    }

    private void toolStripMenuItemChangeList_Click(object sender, EventArgs e)
    {
      this.ChangeListView(true);
    }

    private void toolStripMenuItemVersion_Click(object sender, EventArgs e)
    {
      this.PrintLatestVersionInfo();
      this.WriteMessage("* Telepone, a horse-centric upgrade to MTSP\n", MainForm.SystemMessageColor, MSGOPT.NOTIME);
      this.WriteMessage("* Version " + "2.06b" + " by anniie, send questions and bugs to (kilgamesh@gmail.com)\n\n", MainForm.SystemMessageColor, MSGOPT.NOTIME);
    }

    private void toolStripMenuItemExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private unsafe void toolStripMenuItemSaveLog_Click(object sender, EventArgs e)
    {
      string str1 = new string((char*) &Module.MTOPTION);
      string str2 = string.Format("MT_{0}.log", (object) DateTime.Now.ToString("yyMMdd-HHmmss"));
      string path = str1 + str2;
      Monitor.Enter((object) MainForm.ChatHistory);
      try
      {
        this.richTextBoxLog.SaveFile(path, RichTextBoxStreamType.PlainText);
      }
      catch (Exception ex)
      {
        Module.WriteErrorLog(ex.ToString(), "SaveLog");
      }
      finally
      {
        Monitor.Exit((object) MainForm.ChatHistory);
      }
      this.WriteMessage(string.Format("Saved log file \"{0}\"\n", (object) str2), MainForm.SystemMessageColor, MSGOPT.NONE);
    }

    private void toolStripMenuItemReplay_Click(object sender, EventArgs e)
    {
      MainForm.ReplayFilePath = string.Empty;
      this.StartGame(3U);
    }

    private unsafe void toolStripMenuItemRecordReplay_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItemRecordReplay.Checked = (bool) ((uint) this.toolStripMenuItemRecordReplay.Checked ^ 1U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4028) = (sbyte) this.toolStripMenuItemRecordReplay.Checked;
    }

    private unsafe void toolStripMenuItemAllowSpectator_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItemAllowSpectator.Checked = (bool) ((uint) this.toolStripMenuItemAllowSpectator.Checked ^ 1U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4029) = (sbyte) this.toolStripMenuItemAllowSpectator.Checked;
      if (this.toolStripMenuItemAllowSpectator.Checked || MainForm.UDP == null)
        return;
      byte[] numArray1 = new byte[3];
      numArray1[0] = (byte) 30;
      byte[] numArray2 = numArray1;
      Monitor.Enter((object) MainForm.InputHistory);
      try
      {
        for (int index = 0; index < MainForm.SpectatorList.Count; ++index)
        {
          Array.Copy((Array) BitConverter.GetBytes(MainForm.SpectatorList[index].ID), 0, (Array) numArray2, 1, 2);
          UdpClient udpClient1 = MainForm.UDP;
          byte[] datagram = numArray2;
          int length = datagram.Length;
          IPEndPoint endPoint = MainForm.SpectatorList[index].IP_EP;
          AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
          UdpClient udpClient2 = MainForm.UDP;
          udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        }
        MainForm.SpectatorList.Clear();
      }
      finally
      {
        Monitor.Exit((object) MainForm.InputHistory);
      }
    }

    private unsafe void toolStripMenuItemAfterRest_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItemAfterRest.Checked = (bool) ((uint) this.toolStripMenuItemAfterRest.Checked ^ 1U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4030) = (sbyte) this.toolStripMenuItemAfterRest.Checked;
    }

    private void toolStripMenuItemDelayAuto_Click(object sender, EventArgs e)
    {
      this.ResetDelay(0U);
    }

    private void toolStripMenuItemDelay2_Click(object sender, EventArgs e)
    {
      this.ResetDelay(2U);
    }

    private void toolStripMenuItemDelay3_Click(object sender, EventArgs e)
    {
      this.ResetDelay(3U);
    }

    private void toolStripMenuItemDelay4_Click(object sender, EventArgs e)
    {
      this.ResetDelay(4U);
    }

    private void toolStripMenuItemDelay5_Click(object sender, EventArgs e)
    {
      this.ResetDelay(5U);
    }

    private void toolStripMenuItemDelay6_Click(object sender, EventArgs e)
    {
      this.ResetDelay(6U);
    }

    private void toolStripMenuItemDelay7_Click(object sender, EventArgs e)
    {
      this.ResetDelay(7U);
    }

    private void toolStripMenuItemDelay8_Click(object sender, EventArgs e)
    {
      this.ResetDelay(8U);
    }

    private void toolStripMenuItemDelay9_Click(object sender, EventArgs e)
    {
      this.ResetDelay(9U);
    }

    private void toolStripMenuItemDelay10_Click(object sender, EventArgs e)
    {
      this.ResetDelay(10U);
    }

    private void toolStripMenuItemDelay11_Click(object sender, EventArgs e)
    {
      this.ResetDelay(11U);
    }

    private void toolStripMenuItemDelay12_Click(object sender, EventArgs e)
    {
      this.ResetDelay(12U);
    }

    private void toolStripMenuItemDelayCust_Click(object sender, EventArgs e)
    {
      this.ResetDelay(12U);
    }

    private void contextMenuItemCopy_Click(object sender, EventArgs e)
    {
      this.richTextBoxLog.Copy();
    }

    private void richTextBoxLog_LinkClicked(object sender, LinkClickedEventArgs e)
    {
      Process.Start(e.LinkText);
    }

    private unsafe void toolStripMenuItemVS_Click(object sender, EventArgs e)
    {
      if (this.listBoxMember.SelectedIndex == -1)
        return;
      if (MainForm.ListView == (LIST_VIEW) 2)
      {
        this.RandomVersus();
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ( ((IntPtr) &Module.MTOPTION + 520) == 3 || this.listBoxMember.SelectedIndex == 0)
          this.StartGame(1U);
        else
          this.StartGame(2U);
      }
    }

    private void toolStripMenuItemWatch_Click(object sender, EventArgs e)
    {
      if (this.listBoxMember.SelectedIndex == -1 || MainForm.UDP == null)
        return;
      int num = (int) MainForm.MemberList[0].STATE;
      byte[] numArray = new byte[3];
      if (num == 0 || num == 1)
      {
        if (num == 0)
          this.ChangeState((object) 3);
        if (num == 1)
          this.ChangeState((object) 4);
        MainForm.WatchTarget = MainForm.MemberList[this.listBoxMember.SelectedIndex].IP_EP;
        MainForm.TargetID = MainForm.MemberList[this.listBoxMember.SelectedIndex].ID;
        MainForm.WatchFrame = 0U;
        numArray[0] = (byte) 27;
        Array.Copy((Array) BitConverter.GetBytes(MainForm.MemberList[0].ID), 0, (Array) numArray, 1, 2);
        UdpClient udpClient1 = MainForm.UDP;
        byte[] datagram = numArray;
        int length = datagram.Length;
        IPEndPoint endPoint = MainForm.WatchTarget;
        AsyncCallback requestCallback = new AsyncCallback(MainForm.SendPackets);
        UdpClient udpClient2 = MainForm.UDP;
        udpClient1.BeginSend(datagram, length, endPoint, requestCallback, (object) udpClient2);
        this.toolStripMenuItemWatch.Text = "End spectating";
      }
      else
        this.QuitWatch(true);
    }

    private void toolStripMenuItemPing_Click(object sender, EventArgs e)
    {
      if (this.listBoxMember.SelectedIndex == -1)
        return;
      int selectedIndex = this.listBoxMember.SelectedIndex;
      IPAddress ipAddress = new IPAddress(0L);
      if (MainForm.UDP == null || MainForm.MemberList[selectedIndex].IP_EP.Address == ipAddress || MainForm.MemberList[selectedIndex].IP_EP.Port == 0)
        return;
      byte[] datagram = new byte[1]
      {
        (byte) 0
      };
      MainForm.Ping = Module.timeGetTime();
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((int)  @Module.MTINFO != 0)
        this.WriteMessage(string.Format("Packet> {0}\t To> {1}\t From> {2}\n", (object) datagram[0], (object) MainForm.MemberList[selectedIndex].IP_EP, (object) MainForm.UDP.Client.LocalEndPoint.ToString()), MainForm.DebugMessageColor, MSGOPT.NONE);
      MainForm.UDP.BeginSend(datagram, 1, MainForm.MemberList[selectedIndex].IP_EP, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
    }

    private void contextMenuStripMember_Opening(object sender, CancelEventArgs e)
    {
      if (this.listBoxMember.SelectedIndex == -1)
      {
        this.toolStripMenuItemVS.Enabled = false;
        this.toolStripMenuItemWatch.Enabled = false;
        this.toolStripMenuItemPing.Enabled = false;
        this.toggleIgnoreToolStripMenuItem.Enabled = false;
        this.declineChallengesToolStripMenuItem.Enabled = false;
        this.queryVersionToolStripMenuItem.Enabled = false;
      }
      else
      {
        int num = (int) MainForm.MemberList[this.listBoxMember.SelectedIndex].STATE;
        this.toolStripMenuItemVS.Enabled = false;
        this.toolStripMenuItemWatch.Enabled = true;
        this.toolStripMenuItemPing.Enabled = true;
        this.toggleIgnoreToolStripMenuItem.Enabled = true;
        this.declineChallengesToolStripMenuItem.Enabled = true;
        this.queryVersionToolStripMenuItem.Enabled = true;
        if (num == 0 && (int) MainForm.MemberList[0].STATE == 0 || MainForm.ListView == (LIST_VIEW) 2)
          this.toolStripMenuItemVS.Enabled = true;
        if (this.listBoxMember.SelectedIndex != 0 || num == 3 || num == 4)
          return;
        this.toolStripMenuItemWatch.Enabled = false;
      }
    }

    private void MainForm_DragEnter(object sender, DragEventArgs e)
    {
      e.Effect = DragDropEffects.None;
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      string[] strArray = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
      string str = Path.GetExtension(strArray[0]).ToLower();
      FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(strArray[0]);
      if (!(str == ".mtr") && (!(str == ".exe") || !(versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル2nd.") && !(versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル９５")))
        return;
      e.Effect = DragDropEffects.All;
    }

    private unsafe void MainForm_DragDrop(object sender, DragEventArgs e)
    {
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      string[] strArray = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
      string str = Path.GetExtension(strArray[0]).ToLower();
      if (str == ".mtr")
      {
        MainForm.ReplayFilePath = ((string[]) e.Data.GetData(DataFormats.FileDrop, false))[0];
        this.StartGame(3U);
      }
      else
      {
        if (!(str == ".exe"))
          return;
        if (MainForm.Option == null || MainForm.Option.IsDisposed)
        {
          FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(strArray[0]);
          IntPtr hglobal = Marshal.StringToHGlobalAuto(strArray[0]);
          Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) &Module.MTOPTION + 844), (char*) hglobal.ToPointer());
          Marshal.FreeHGlobal(hglobal);
          ArrayTypeBY02_W arrayTypeBy02W;
          ArrayTypeBY0BAE_W arrayTypeBy0BaEW1;
          Module._wsplitpath_s((char*) ((IntPtr) &Module.MTOPTION + 844), (char*) &arrayTypeBy02W, 3U, (char*) &arrayTypeBy0BaEW1, 256U, (char*) 0, 0U, (char*) 0, 0U);
          bool flag;
          ArrayTypeBY0BAE_W arrayTypeBy0BaEW2;
          if (versionInfo.FileDescription == "２Ｄ格闘ツク\x30FCル2nd.")
          {
            flag = true;
            Module.swprintf_s260(&arrayTypeBy0BaEW2, (char*) &Module._C_1BKLOLHAEAGAACFAAsAACFAAsAAgAAaAAmAAeAA4AAiAAnAAiAAAA, __arglist (out arrayTypeBy02W, out arrayTypeBy0BaEW1));
          }
          else
          {
            flag = false;
            Module.swprintf_s260(&arrayTypeBy0BaEW2, (char*) &Module._C_1CGJOJCMFNBAACFAAsAACFAAsPPBCPPhDMJFX0D0KP0PM0kPPBJPPBFAA4AAiAAnAAiAAAA, __arglist (out arrayTypeBy02W, out arrayTypeBy0BaEW1));
          }
          if (System.IO.File.Exists(new string((char*) &arrayTypeBy0BaEW2)))
          {
            if (flag)
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTOPTION + 3980) = (int) Module.GetPrivateProfileInt((char*) &Module._C_1BCDEHHLCJPAAGAAaAAmAAeAAPAAlAAaAAyAAAA, (char*) &Module._C_1DAEJBGHBAIAAEAAdAAiAAtAAoAArAA4AATAAeAAsAAtAAPAAlAAaAAyAA4AASAAtAAaAAgAAeAANAAbAAAA, 0, (char*) &arrayTypeBy0BaEW2) + 1;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTOPTION + 3988) = (int) Module.GetPrivateProfileInt((char*) &Module._C_1BCDEHHLCJPAAGAAaAAmAAeAAPAAlAAaAAyAAAA, (char*) &Module._C_1DKCMPJHEEFAAEAAdAAiAAtAAoAArAA4AATAAeAAsAAtAAPAAlAAaAAyAA4AAVAASAASAAiAAnAAgAAlAAeAAPAAlAAaAAyAAAA, 0, (char*) &arrayTypeBy0BaEW2);
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTOPTION + 3992) = (int) Module.GetPrivateProfileInt((char*) &Module._C_1BCDEHHLCJPAAGAAaAAmAAeAAPAAlAAaAAyAAAA, (char*) &Module._C_1CKIHBLOPJEAAEAAdAAiAAtAAoAArAA4AATAAeAAsAAtAAPAAlAAaAAyAA4AAtAAiAAmAAeAAAA, 0, (char*) &arrayTypeBy0BaEW2);
            }
            else
            {
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTOPTION + 3980) = (int) Module.GetPrivateProfileInt((char*) &Module._C_1MMJBHOHEL0LC0PM0OAIK9FLJKAAAA, (char*) &Module._C_1DKKLNNPADJAAEAAdAAiAAtAAeAArAA4AATAAeAAsAAtAAPAAlAAaAAyAA4AABAAaAAcAAkAAGAArAAoAAuAAnAAdAANAAbAAAA, 0, (char*) &arrayTypeBy0BaEW2) + 1;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTOPTION + 3988) = 2;
              // ISSUE: cast to a reference type
              // ISSUE: explicit reference operation
               ((IntPtr) &Module.MTOPTION + 3992) = (int) Module.GetPrivateProfileInt((char*) &Module._C_1MMJBHOHEL0LC0PM0OAIK9FLJKAAAA, (char*) &Module._C_1CKDBHMMCAJAAEAAdAAiAAtAAeAArAA4AATAAeAAsAAtAAPAAlAAaAAyAA4AAtAAiAAmAAeAAAA, 0, (char*) &arrayTypeBy0BaEW2);
            }
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
            int num =  ((IntPtr) &Module.MTOPTION + 3980) != 1 ? 0 : 1;
            // ISSUE: cast to a reference type
            // ISSUE: explicit reference operation
             ((IntPtr) &Module.MTOPTION + 3984) = num;
          }
          this.WriteMessage(string.Format("Game changed to \"{0}\".\n", (object) Path.GetFileNameWithoutExtension(strArray[0])), MainForm.SystemMessageColor, MSGOPT.NONE);
        }
        else
          MainForm.Option.SetGameExePath(ref strArray[0]);
      }
    }

    private void toolStripMenuItemFile_Click(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItemOption_Click(object sender, EventArgs e)
    {
    }

    private void toolTipMember_Popup(object sender, PopupEventArgs e)
    {
    }

    private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void reconnectRToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Restart();
    }

    private void buttonToggleRestOn_Click(object sender, EventArgs e)
    {
      this.textBoxInput.Text = "";
      this.textBoxInput.Text = "/rest";
      this.AnalyzeCommand();
      this.textBoxInput.Text = "";
      this.toolTipMember.Hide((IWin32Window) this);
    }

    private void buttonToggleRestMode_OnMouseLeave(object sender, EventArgs e)
    {
      this.toolTipMember.Hide((IWin32Window) this);
      this.toolTipMember.Active = false;
      this.toolTipMember.Active = true;
      MainForm.LastMemberIndex = -1;
    }

    private void richTextBoxLog_TextChanged(object sender, EventArgs e)
    {
    }

    private void buttonRandomPingVS_OnClick(object sender, EventArgs e)
    {
      this.RandomVersus();
    }

    private void ToggleIgnore_OnClick(object sender, EventArgs e)
    {
      string name = MainForm.MemberList[this.listBoxMember.SelectedIndex].NAME;
      if (MainForm.MYRELATIONS.IsIgnored(MainForm.MemberList[this.listBoxMember.SelectedIndex].NAME))
      {
        MainForm.MYRELATIONS.ToggleIgnore(name, false);
        this.ProfileDisplayAnchored.Ignored = false;
        this.WriteMessage(string.Format("No longer ignoring {0}.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      else
      {
        MainForm.MYRELATIONS.ToggleIgnore(name, true);
        this.ProfileDisplayAnchored.Ignored = true;
        this.WriteMessage(string.Format("Now ignoring {0}.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      MainForm.MYRELATIONS.SaveList("mtspfim_ignores.txt", (RELATION_TYPE) 0);
      this.ProfileDisplayAnchored.Update();
    }

    private void DeclineChallenges_OnClick(object sender, EventArgs e)
    {
      string name = MainForm.MemberList[this.listBoxMember.SelectedIndex].NAME;
      if (MainForm.MYRELATIONS.IsDeclining(MainForm.MemberList[this.listBoxMember.SelectedIndex].NAME))
      {
        MainForm.MYRELATIONS.ToggleDecline(name, false);
        this.ProfileDisplayAnchored.Declined = false;
        this.WriteMessage(string.Format("No longer declining challenges from {0}.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      else
      {
        MainForm.MYRELATIONS.ToggleDecline(name, true);
        this.ProfileDisplayAnchored.Declined = true;
        this.WriteMessage(string.Format("Now declining challenges from {0}.\n", (object) name), MainForm.SystemMessageColor, MSGOPT.NONE);
      }
      MainForm.MYRELATIONS.SaveList("mtspfim_declines.txt", (RELATION_TYPE) 1);
      this.ProfileDisplayAnchored.Update();
    }

    private unsafe void numericMaxChallengePing_OnChange(object sender, EventArgs e)
    {
      Decimal num = this.textBoxMaxChallengePing.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4024) = (int) (uint) num;
    }

    private void QueryVersion_OnClick(object sender, EventArgs e)
    {
      IPAddress ipAddress = (IPAddress) null;
      string str = (string) null;
      if (this.listBoxMember.SelectedIndex == -1)
        return;
      int selectedIndex = this.listBoxMember.SelectedIndex;
      ipAddress = new IPAddress(0L);
      if (MainForm.UDP == null || MainForm.MemberList[selectedIndex].IP_EP.Port == 0)
      {
        this.WriteMessage("Cannot perform this operation\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
      }
      else
      {
        IPEndPoint endPoint = new IPEndPoint(MainForm.MemberList[selectedIndex].IP_EP.Address, MainForm.MemberList[selectedIndex].IP_EP.Port);
        if (selectedIndex == 0)
        {
          byte[] address = new byte[4]
          {
            (byte) 127,
            (byte) 0,
            (byte) 0,
            (byte) 1
          };
          endPoint.Address = new IPAddress(address);
          str = endPoint.ToString();
        }
        byte[] datagram = new byte[1]
        {
          (byte) 33
        };
        MainForm.UDP.BeginSend(datagram, 1, endPoint, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
        MainForm.PACSCHED.Schedule(34);
        this.WriteMessage("Requesting version from user. (only v1.80+ will understand the request)\n", MainForm.SystemMessageColor, MSGOPT.NONE);
      }
    }

    private void listBoxMember_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.listBoxMember.Invalidate();
    }

    private unsafe void toolStripMenuItemConnectRest_Click(object sender, EventArgs e)
    {
      this.restOnConnectToolStripMenuItem.Checked = (bool) ((uint) this.restOnConnectToolStripMenuItem.Checked ^ 1U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4031) = (sbyte) this.restOnConnectToolStripMenuItem.Checked;
    }

    private void buttonSortAlphabetically_OnClick(object sender, EventArgs e)
    {
      Monitor.Enter((object) MainForm.MemberList);
      try
      {
        if (MainForm.MemberList.Count < 2)
          return;
        MemberList_AlphabeticalSort alphabeticalSort = new MemberList_AlphabeticalSort();
        MainForm.MemberList.Sort(2, MainForm.MemberList.Count - 2, (IComparer<MemberInfo>) alphabeticalSort);
        this.listBoxMember.Invalidate();
      }
      finally
      {
        Monitor.Exit((object) MainForm.MemberList);
      }
    }

    private void listBoxMember_MouseLeave(object sender, EventArgs e)
    {
      this.listBoxMember.Refresh();
      MainForm.LastMemberIndex = -1;
    }

    private void buttonTrain_OnClick(object sender, EventArgs e)
    {
      this.StartGame(1U);
    }

    private unsafe void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      this.toolStripMenuItemDisableEmotes.Checked = (bool) ((uint) this.toolStripMenuItemDisableEmotes.Checked ^ 1U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4033) = (sbyte) this.toolStripMenuItemDisableEmotes.Checked;
    }

    private void buttonFavLast_OnClick(object sender, EventArgs e)
    {
      try
      {
        if (MainForm.LastReplayPath == string.Empty)
          this.WriteMessage("No replay has been created during this session.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        else if (MainForm.LastReplayPath.Length <= 1)
        {
          this.WriteMessage("No/invalid/corrupted replay path.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        }
        else
        {
          Replay rep = new Replay(MainForm.LastReplayPath, false);
          if (rep.GetState() == (REP_FILE_STATE) 0)
          {
            this.WriteMessage("No/invalid/corrupted replay.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
          }
          else
          {
            ReplayDetailViewForm replayDetailViewForm = new ReplayDetailViewForm();
            rep.UpdateSecondaryHeaderInfo();
            replayDetailViewForm.SendReplay(rep);
            int num = (int) replayDetailViewForm.ShowDialog((IWin32Window) this);
            if (rep.m_Marked)
              this.WriteMessage(string.Format("{0} is marked as a favorite.\n", (object) rep.m_FullFilename), MainForm.SystemMessageColor, MSGOPT.NONE);
            else
              this.WriteMessage(string.Format("{0} is unmarked as a favorite.\n", (object) rep.m_FullFilename), MainForm.SystemMessageColor, MSGOPT.NONE);
          }
        }
      }
      catch (Exception ex)
      {
        this.WriteMessage(ex.ToString(), MainForm.ErrorMessageColor, MSGOPT.NONE);
        Module.WriteErrorLog(ex.ToString(), "Favorite replay OnClick");
      }
    }

    private void menuStripReplayManager_OnClick(object sender, EventArgs e)
    {
      if (MainForm.MemberList.Count < 1 || (int) MainForm.MemberList[0].STATE == 5 || ((int) MainForm.MemberList[0].STATE == 2 || (int) MainForm.MemberList[0].STATE == 3))
        return;
      this.ChangeState((object) 1);
      int num = (int) new ReplayManagerForm().ShowDialog((IWin32Window) this);
    }

    private void menuItemSimpleHelp_OnClick(object sender, EventArgs e)
    {
      try
      {
        Process.Start("HELP.txt");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Could not open HELP.txt", "Error");
      }
    }

    private void CheckCompatibility_OnClick(object sender, EventArgs e)
    {
      IPAddress ipAddress = (IPAddress) null;
      IPEndPoint endPoint = (IPEndPoint) null;
      string str = (string) null;
      if (this.listBoxMember.SelectedIndex == -1)
        return;
      if (!Monitor.TryEnter((object) MainForm.MemberList, 1500))
        return;
      try
      {
        int selectedIndex = this.listBoxMember.SelectedIndex;
        ipAddress = new IPAddress(0L);
        if (MainForm.UDP == null || MainForm.MemberList[selectedIndex].IP_EP.Port == 0)
        {
          this.WriteMessage("Cannot perform this operation\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
          return;
        }
        else if ((int) MainForm.MemberList[selectedIndex].STATE == 2)
        {
          this.WriteMessage("Can't get settings while user is in match.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
          return;
        }
        else
        {
          endPoint = new IPEndPoint(MainForm.MemberList[selectedIndex].IP_EP.Address, MainForm.MemberList[selectedIndex].IP_EP.Port);
          if (selectedIndex == 0)
          {
            byte[] address = new byte[4]
            {
              (byte) 127,
              (byte) 0,
              (byte) 0,
              (byte) 1
            };
            endPoint.Address = new IPAddress(address);
            str = endPoint.ToString();
          }
        }
      }
      finally
      {
        Monitor.Exit((object) MainForm.MemberList);
      }
      byte[] datagram = new byte[1]
      {
        (byte) 35
      };
      MainForm.UDP.BeginSend(datagram, 1, endPoint, new AsyncCallback(MainForm.SendPackets), (object) MainForm.UDP);
      MainForm.PACSCHED.Schedule(36);
      this.WriteMessage("Requesting game settings from user. (only v1.84+ will understand the request)\n", MainForm.SystemMessageColor, MSGOPT.NONE);
    }

    private void TESTBUTTON_OnClick(object sender, EventArgs e)
    {
      PacketPacker packetPacker1 = (PacketPacker) null;
      if (MainForm.UDP == null)
        return;
      PacketPacker packetPacker2 = new PacketPacker();
      packetPacker1 = new PacketPacker();
      packetPacker2.Pack((byte) 12);
      packetPacker2.Pack((byte) 0);
      packetPacker2.Pack((byte) 0);
      packetPacker2.Pack(byte.MaxValue);
      MainForm.UDP.Send(packetPacker2.Packet, packetPacker2.Length, MainForm.MemberList[1].IP_EP);
    }

    private void listBoxMember_OnClick(object sender, MouseEventArgs e)
    {
    }

    private unsafe void noSinglePlayerReplaysToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.noSinglePlayerReplaysToolStripMenuItem.Checked = (bool) ((uint) this.noSinglePlayerReplaysToolStripMenuItem.Checked ^ 1U);
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4037) = (sbyte) this.noSinglePlayerReplaysToolStripMenuItem.Checked;
    }

    private void RefreshMemberList_Click(object sender, EventArgs e)
    {
      if (MainForm.LastMemberRefresh != 0 || MainForm.MemberList.Count < 2 || MainForm.UDP == null)
        return;
      MainForm.LastMemberRefresh = 1001;
      PacketPacker packetPacker = new PacketPacker();
      packetPacker.Clear();
      packetPacker.Pack((byte) 7);
      packetPacker.Pack((byte) 0);
      packetPacker.Pack((byte) 0);
      MainForm.UDP.Send(packetPacker.Packet, packetPacker.Length, MainForm.MemberList[1].IP_EP);
      this.WriteMessage("Requesting lobby member list update from server.\n", MainForm.SystemMessageColor, MSGOPT.NONE);
    }

    private void General1SecTimer_Tick(object sender, EventArgs e)
    {
      MainForm.LastMemberRefresh = 0;
    }

    private void HideProfile(object sender, EventArgs e)
    {
      this.ProfileDisplayAnchored.HideProfile();
    }

    private unsafe void MainForm_Resize(object sender, EventArgs e)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTOPTION + 520) != 0)
        this.notifyIcon1.Visible = false;
      else if (this.WindowState == FormWindowState.Minimized)
      {
        this.notifyIcon1.Visible = true;
        this.Hide();
      }
      else
      {
        if (this.WindowState != FormWindowState.Normal)
          return;
        this.notifyIcon1.Visible = false;
      }
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      ((Control) this).Show();
      this.WindowState = FormWindowState.Normal;
    }

    private void richTextBoxLog_MouseHover(object sender, EventArgs e)
    {
      this.HideProfile((object) null, (EventArgs) null);
    }

    private void listBoxMember_DragOver(object sender, DragEventArgs e)
    {
      this.listBoxMember.Invalidate();
    }

    private void StatsManagerMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new UserStatsManager(MainForm.MYRELATIONS).ShowDialog((IWin32Window) this);
    }

    private void spectateSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new SpectatorOptionsForm().Show((IWin32Window) this);
    }

    private void richTextBoxLog_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Alt || e.Control || (e.KeyCode == Keys.Prior || e.KeyCode == Keys.Next))
        return;
      this.textBoxInput.Focus();
      this.textBoxInput_KeyDown(sender, e);
      e.Handled = true;
      e.SuppressKeyPress = true;
    }

    private unsafe void CMBX_GameSwitcher_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (this.CMBX_GameSwitcher.Text == string.Empty || this.CMBX_GameSwitcher.Text == "no preset")
        return;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ( ((IntPtr) &Module.MTINFO + 28) != 0)
      {
        this.WriteMessage("Can't change settings while game is running.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
      }
      else
      {
        try
        {
          FileStream fileStream = new FileStream(".\\files\\GameSettings\\" + this.CMBX_GameSwitcher.Text, FileMode.Open);
          StreamReader streamReader = new StreamReader((Stream) fileStream);
          string str1 = streamReader.ReadLine();
          IntPtr hglobal = Marshal.StringToHGlobalAuto(str1);
          Module.wcscpy_s260((ArrayTypeBY0BAE_W*) ((IntPtr) &Module.MTOPTION + 844), (char*) hglobal.ToPointer());
          Marshal.FreeHGlobal(hglobal);
          string withoutExtension = Path.GetFileNameWithoutExtension(str1);
          string str2 = streamReader.ReadLine();
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 3980) = Convert.ToInt32(str2, 10);
          string str3 = streamReader.ReadLine();
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 3984) = Convert.ToInt32(str3, 10);
          string str4 = streamReader.ReadLine();
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 3988) = Convert.ToInt32(str4, 10);
          string str5 = streamReader.ReadLine();
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 3992) = Convert.ToInt32(str5, 10);
          bool flag = Convert.ToInt32(streamReader.ReadLine(), 10) == 1;
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 4000) = (sbyte) flag;
          string str6 = streamReader.ReadLine();
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 3976) = Convert.ToInt32(str6, 10);
          string str7 = streamReader.ReadLine();
          // ISSUE: cast to a reference type
          // ISSUE: explicit reference operation
           ((IntPtr) &Module.MTOPTION + 3972) = Convert.ToInt32(str7, 10);
          streamReader.Close();
          fileStream.Close();
          this.WriteMessage(string.Format("Now playing: {0}\n", (object) withoutExtension), MainForm.SystemMessageColor, MSGOPT.NONE);
        }
        catch (Exception ex)
        {
          this.WriteMessage("Error during settings change.\n", MainForm.ErrorMessageColor, MSGOPT.NONE);
        }
      }
    }

    private void Prize1HourTimer_Tick(object sender, EventArgs e)
    {
      if (new Random().Next(4) != 2)
        return;
      this.PrizeEvent();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.MainForm();
        }
        finally
        {
          base.Dispose(true);
        }
      }
      else
        base.Dispose(false);
    }

    private delegate void WriteMessageDelegate(string msg, Color color, MSGOPT options);

    private delegate void WriteCommentDelegate(string _param1, int _param2, string _param3);

    private delegate void ColorlessMessageDelegate(string msg);

    private delegate void TalkMessageDelegate(ushort id, byte[] msg);

    private delegate void AddMemberDelegate(ref MemberInfo mi);

    private class SpectatorInfo
    {
      public ushort ID;
      public IPEndPoint IP_EP;
      public uint FRAME;
    }
  }
}
