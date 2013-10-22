// Type: MTSP.StartupForm
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using CppImplementationDetails;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class StartupForm : Form
  {
    private RadioButton radioButtonServer;
    private RadioButton radioButtonHost;
    private RadioButton radioButtonClient;
    private Label labelIP;
    private Label labelOpenPort;
    private NumericUpDown numericUpDownOpenPort;
    private Button buttonOK;
    private Button buttonCancel;
    private TabControl tabControlStartUp;
    private TabPage tabPageMode;
    private TabPage tabPageOption;
    private TabPage tabPageWelcome;
    private Label labelName;
    private TextBox textBoxName;
    private RichTextBox richTextBoxWelcome;
    private Label labelComment;
    private TextBox textBoxComment;
    private TabPage tabPageCipher;
    private Button buttonEncryption;
    private TextBox textBoxAfterIP;
    private TextBox textBoxBeforeIP;
    private Label labelAfterIP;
    private Label labelBeforeIP;
    private CheckBox checkBoxDNS;
    private ComboBox comboBoxServerName;
    private Button buttonEditServers;
    private CheckBox checkBoxAutoGGEnable;
    private TextBox textBoxAutoGGMessage;
    private Label label1;
    private Button buttonViewChangelog;
    private Button buttonEditDeclines;
    private Button buttonEditIgnores;
    private NumericUpDown numericUpDownMaxConnection;
    private Label labelMaxConnection;
    private Label labelPort;
    private NumericUpDown numericUpDownPort;
    private Label label2;
    private Label label3;
    private NumericUpDown numericUpDownMinimumGGSeconds;
    private ComboBox comboBoxPlayerRegion;
    private TextBox textBoxLookingFor;
    private Label label4;
    private TextBox textBoxAvoiding;
    private Label label5;
    private Container components;

    public StartupForm()
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

    private void StartupForm()
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
      this.radioButtonServer = new RadioButton();
      this.radioButtonHost = new RadioButton();
      this.radioButtonClient = new RadioButton();
      this.labelIP = new Label();
      this.labelOpenPort = new Label();
      this.numericUpDownOpenPort = new NumericUpDown();
      this.buttonOK = new Button();
      this.buttonCancel = new Button();
      this.tabControlStartUp = new TabControl();
      this.tabPageMode = new TabPage();
      this.numericUpDownMaxConnection = new NumericUpDown();
      this.labelMaxConnection = new Label();
      this.labelPort = new Label();
      this.numericUpDownPort = new NumericUpDown();
      this.buttonViewChangelog = new Button();
      this.buttonEditDeclines = new Button();
      this.buttonEditIgnores = new Button();
      this.buttonEditServers = new Button();
      this.comboBoxServerName = new ComboBox();
      this.checkBoxDNS = new CheckBox();
      this.tabPageOption = new TabPage();
      this.textBoxAvoiding = new TextBox();
      this.label5 = new Label();
      this.comboBoxPlayerRegion = new ComboBox();
      this.textBoxLookingFor = new TextBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.numericUpDownMinimumGGSeconds = new NumericUpDown();
      this.label2 = new Label();
      this.checkBoxAutoGGEnable = new CheckBox();
      this.textBoxAutoGGMessage = new TextBox();
      this.label1 = new Label();
      this.textBoxComment = new TextBox();
      this.labelComment = new Label();
      this.textBoxName = new TextBox();
      this.labelName = new Label();
      this.tabPageWelcome = new TabPage();
      this.richTextBoxWelcome = new RichTextBox();
      this.tabPageCipher = new TabPage();
      this.buttonEncryption = new Button();
      this.textBoxAfterIP = new TextBox();
      this.textBoxBeforeIP = new TextBox();
      this.labelAfterIP = new Label();
      this.labelBeforeIP = new Label();
      this.numericUpDownOpenPort.BeginInit();
      this.tabControlStartUp.SuspendLayout();
      this.tabPageMode.SuspendLayout();
      this.numericUpDownMaxConnection.BeginInit();
      this.numericUpDownPort.BeginInit();
      this.tabPageOption.SuspendLayout();
      this.numericUpDownMinimumGGSeconds.BeginInit();
      this.tabPageWelcome.SuspendLayout();
      this.tabPageCipher.SuspendLayout();
      this.SuspendLayout();
      this.radioButtonServer.AutoSize = true;
      this.radioButtonServer.Location = new Point(11, 12);
      this.radioButtonServer.Name = "radioButtonServer";
      this.radioButtonServer.Size = new Size(56, 17);
      this.radioButtonServer.TabIndex = 1;
      this.radioButtonServer.Text = "Server";
      this.radioButtonServer.UseVisualStyleBackColor = true;
      this.radioButtonServer.CheckedChanged += new EventHandler(this.radioButtonServer_CheckedChanged);
      this.radioButtonHost.AutoSize = true;
      this.radioButtonHost.Location = new Point(11, 37);
      this.radioButtonHost.Name = "radioButtonHost";
      this.radioButtonHost.Size = new Size(47, 17);
      this.radioButtonHost.TabIndex = 1;
      this.radioButtonHost.Text = "Host";
      this.radioButtonHost.UseVisualStyleBackColor = true;
      this.radioButtonHost.CheckedChanged += new EventHandler(this.radioButtonHost_CheckedChanged);
      this.radioButtonClient.AutoSize = true;
      this.radioButtonClient.Location = new Point(11, 62);
      this.radioButtonClient.Name = "radioButtonClient";
      this.radioButtonClient.Size = new Size(51, 17);
      this.radioButtonClient.TabIndex = 1;
      this.radioButtonClient.Text = "Client";
      this.radioButtonClient.UseVisualStyleBackColor = true;
      this.radioButtonClient.CheckedChanged += new EventHandler(this.radioButtonClient_CheckedChanged);
      this.labelIP.AutoSize = true;
      this.labelIP.Location = new Point(79, 16);
      this.labelIP.Name = "labelIP";
      this.labelIP.Size = new Size(67, 13);
      this.labelIP.TabIndex = 0;
      this.labelIP.Text = "Server name";
      this.labelIP.Click += new EventHandler(this.labelIP_Click);
      this.labelOpenPort.AutoSize = true;
      this.labelOpenPort.Location = new Point(150, 65);
      this.labelOpenPort.Name = "labelOpenPort";
      this.labelOpenPort.Size = new Size(68, 13);
      this.labelOpenPort.TabIndex = 0;
      this.labelOpenPort.Text = "Connect port";
      this.numericUpDownOpenPort.Location = new Point(219, 61);
      this.numericUpDownOpenPort.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDownOpenPort.Minimum = new Decimal(new int[4]
      {
        1024,
        0,
        0,
        0
      });
      this.numericUpDownOpenPort.Name = "numericUpDownOpenPort";
      this.numericUpDownOpenPort.Size = new Size(64, 20);
      this.numericUpDownOpenPort.TabIndex = 4;
      this.numericUpDownOpenPort.Value = new Decimal(new int[4]
      {
        7500,
        0,
        0,
        0
      });
      this.buttonOK.Location = new Point(136, 170);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new Size(68, 26);
      this.buttonOK.TabIndex = 6;
      this.buttonOK.Text = "OK";
      this.buttonOK.UseVisualStyleBackColor = true;
      this.buttonOK.Click += new EventHandler(this.buttonOK_Click);
      this.buttonCancel.DialogResult = DialogResult.Cancel;
      this.buttonCancel.Location = new Point(208, 170);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new Size(68, 26);
      this.buttonCancel.TabIndex = 7;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
      this.tabControlStartUp.Controls.Add((Control) this.tabPageMode);
      this.tabControlStartUp.Controls.Add((Control) this.tabPageOption);
      this.tabControlStartUp.Controls.Add((Control) this.tabPageWelcome);
      this.tabControlStartUp.Controls.Add((Control) this.tabPageCipher);
      this.tabControlStartUp.Dock = DockStyle.Top;
      this.tabControlStartUp.Location = new Point(0, 0);
      this.tabControlStartUp.Name = "tabControlStartUp";
      this.tabControlStartUp.SelectedIndex = 0;
      this.tabControlStartUp.Size = new Size(312, 167);
      this.tabControlStartUp.TabIndex = 0;
      this.tabPageMode.Controls.Add((Control) this.numericUpDownMaxConnection);
      this.tabPageMode.Controls.Add((Control) this.labelMaxConnection);
      this.tabPageMode.Controls.Add((Control) this.labelPort);
      this.tabPageMode.Controls.Add((Control) this.numericUpDownPort);
      this.tabPageMode.Controls.Add((Control) this.buttonViewChangelog);
      this.tabPageMode.Controls.Add((Control) this.buttonEditDeclines);
      this.tabPageMode.Controls.Add((Control) this.buttonEditIgnores);
      this.tabPageMode.Controls.Add((Control) this.buttonEditServers);
      this.tabPageMode.Controls.Add((Control) this.comboBoxServerName);
      this.tabPageMode.Controls.Add((Control) this.checkBoxDNS);
      this.tabPageMode.Controls.Add((Control) this.labelIP);
      this.tabPageMode.Controls.Add((Control) this.labelOpenPort);
      this.tabPageMode.Controls.Add((Control) this.radioButtonServer);
      this.tabPageMode.Controls.Add((Control) this.numericUpDownOpenPort);
      this.tabPageMode.Controls.Add((Control) this.radioButtonHost);
      this.tabPageMode.Controls.Add((Control) this.radioButtonClient);
      this.tabPageMode.Location = new Point(4, 22);
      this.tabPageMode.Name = "tabPageMode";
      this.tabPageMode.Padding = new Padding(3);
      this.tabPageMode.Size = new Size(304, 141);
      this.tabPageMode.TabIndex = 0;
      this.tabPageMode.Text = "Mode select";
      this.tabPageMode.UseVisualStyleBackColor = true;
      this.numericUpDownMaxConnection.Location = new Point(106, 86);
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
      this.numericUpDownMaxConnection.Size = new Size(40, 20);
      this.numericUpDownMaxConnection.TabIndex = 13;
      this.numericUpDownMaxConnection.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.labelMaxConnection.AutoSize = true;
      this.labelMaxConnection.Location = new Point(17, 90);
      this.labelMaxConnection.Name = "labelMaxConnection";
      this.labelMaxConnection.Size = new Size(88, 13);
      this.labelMaxConnection.TabIndex = 12;
      this.labelMaxConnection.Text = "Max connections";
      this.labelPort.AutoSize = true;
      this.labelPort.Location = new Point(150, 91);
      this.labelPort.Name = "labelPort";
      this.labelPort.Size = new Size(68, 13);
      this.labelPort.TabIndex = 10;
      this.labelPort.Text = "Receive port";
      this.numericUpDownPort.Location = new Point(219, 87);
      this.numericUpDownPort.Maximum = new Decimal(new int[4]
      {
        (int) ushort.MaxValue,
        0,
        0,
        0
      });
      this.numericUpDownPort.Minimum = new Decimal(new int[4]
      {
        1024,
        0,
        0,
        0
      });
      this.numericUpDownPort.Name = "numericUpDownPort";
      this.numericUpDownPort.Size = new Size(64, 20);
      this.numericUpDownPort.TabIndex = 11;
      this.numericUpDownPort.Value = new Decimal(new int[4]
      {
        7500,
        0,
        0,
        0
      });
      this.buttonViewChangelog.Location = new Point(188, 112);
      this.buttonViewChangelog.Name = "buttonViewChangelog";
      this.buttonViewChangelog.Size = new Size(91, 23);
      this.buttonViewChangelog.TabIndex = 9;
      this.buttonViewChangelog.Text = "View changelog";
      this.buttonViewChangelog.TextAlign = ContentAlignment.TopLeft;
      this.buttonViewChangelog.UseVisualStyleBackColor = true;
      this.buttonViewChangelog.Click += new EventHandler(this.buttonViewChangelog_OnClick);
      this.buttonEditDeclines.Location = new Point(98, 112);
      this.buttonEditDeclines.Name = "buttonEditDeclines";
      this.buttonEditDeclines.Size = new Size(86, 23);
      this.buttonEditDeclines.TabIndex = 8;
      this.buttonEditDeclines.Text = "Edit decline list";
      this.buttonEditDeclines.TextAlign = ContentAlignment.TopLeft;
      this.buttonEditDeclines.UseVisualStyleBackColor = true;
      this.buttonEditDeclines.Click += new EventHandler(this.buttonEditDeclineList_OnClick);
      this.buttonEditIgnores.Location = new Point(10, 112);
      this.buttonEditIgnores.Name = "buttonEditIgnores";
      this.buttonEditIgnores.Size = new Size(82, 23);
      this.buttonEditIgnores.TabIndex = 7;
      this.buttonEditIgnores.Text = "Edit ignore list";
      this.buttonEditIgnores.TextAlign = ContentAlignment.TopLeft;
      this.buttonEditIgnores.UseVisualStyleBackColor = true;
      this.buttonEditIgnores.Click += new EventHandler(this.buttonEditIgnoreList_OnClick);
      this.buttonEditServers.Location = new Point(249, 30);
      this.buttonEditServers.Name = "buttonEditServers";
      this.buttonEditServers.Size = new Size(40, 23);
      this.buttonEditServers.TabIndex = 6;
      this.buttonEditServers.Text = "Edit";
      this.buttonEditServers.UseVisualStyleBackColor = true;
      this.buttonEditServers.Click += new EventHandler(this.buttonEditServers_OnClick);
      this.comboBoxServerName.FormattingEnabled = true;
      this.comboBoxServerName.Location = new Point(79, 31);
      this.comboBoxServerName.Name = "comboBoxServerName";
      this.comboBoxServerName.Size = new Size(166, 21);
      this.comboBoxServerName.TabIndex = 5;
      this.comboBoxServerName.SelectedIndexChanged += new EventHandler(this.comboBoxServerName_SelectedIndexChanged);
      this.checkBoxDNS.AutoSize = true;
      this.checkBoxDNS.Location = new Point(79, 63);
      this.checkBoxDNS.Name = "checkBoxDNS";
      this.checkBoxDNS.Size = new Size(49, 17);
      this.checkBoxDNS.TabIndex = 3;
      this.checkBoxDNS.Text = "DNS";
      this.checkBoxDNS.UseVisualStyleBackColor = true;
      this.tabPageOption.AutoScroll = true;
      this.tabPageOption.Controls.Add((Control) this.textBoxAvoiding);
      this.tabPageOption.Controls.Add((Control) this.label5);
      this.tabPageOption.Controls.Add((Control) this.comboBoxPlayerRegion);
      this.tabPageOption.Controls.Add((Control) this.textBoxLookingFor);
      this.tabPageOption.Controls.Add((Control) this.label4);
      this.tabPageOption.Controls.Add((Control) this.label3);
      this.tabPageOption.Controls.Add((Control) this.numericUpDownMinimumGGSeconds);
      this.tabPageOption.Controls.Add((Control) this.label2);
      this.tabPageOption.Controls.Add((Control) this.checkBoxAutoGGEnable);
      this.tabPageOption.Controls.Add((Control) this.textBoxAutoGGMessage);
      this.tabPageOption.Controls.Add((Control) this.label1);
      this.tabPageOption.Controls.Add((Control) this.textBoxComment);
      this.tabPageOption.Controls.Add((Control) this.labelComment);
      this.tabPageOption.Controls.Add((Control) this.textBoxName);
      this.tabPageOption.Controls.Add((Control) this.labelName);
      this.tabPageOption.Location = new Point(4, 22);
      this.tabPageOption.Name = "tabPageOption";
      this.tabPageOption.Padding = new Padding(3);
      this.tabPageOption.Size = new Size(304, 141);
      this.tabPageOption.TabIndex = 1;
      this.tabPageOption.Text = "User profile";
      this.tabPageOption.UseVisualStyleBackColor = true;
      this.textBoxAvoiding.Location = new Point(72, 89);
      this.textBoxAvoiding.MaxLength = 45;
      this.textBoxAvoiding.Name = "textBoxAvoiding";
      this.textBoxAvoiding.Size = new Size(204, 20);
      this.textBoxAvoiding.TabIndex = 16;
      this.textBoxAvoiding.Text = "Laggers, free grazers";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(4, 91);
      this.label5.Name = "label5";
      this.label5.Size = new Size(51, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "Avoiding:";
      this.comboBoxPlayerRegion.DropDownStyle = ComboBoxStyle.DropDownList;
      this.comboBoxPlayerRegion.FormattingEnabled = true;
      this.comboBoxPlayerRegion.Items.AddRange(new object[9]
      {
        (object) "N. America",
        (object) "Europe",
        (object) "Russia",
        (object) "Asia",
        (object) "S. America",
        (object) "Africa",
        (object) "Md. East",
        (object) "Australia",
        (object) "Antarctica"
      });
      this.comboBoxPlayerRegion.Location = new Point(72, 35);
      this.comboBoxPlayerRegion.Name = "comboBoxPlayerRegion";
      this.comboBoxPlayerRegion.Size = new Size(97, 21);
      this.comboBoxPlayerRegion.TabIndex = 14;
      this.textBoxLookingFor.Location = new Point(72, 62);
      this.textBoxLookingFor.MaxLength = 45;
      this.textBoxLookingFor.Name = "textBoxLookingFor";
      this.textBoxLookingFor.Size = new Size(204, 20);
      this.textBoxLookingFor.TabIndex = 13;
      this.textBoxLookingFor.Text = "Beginners";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(4, 39);
      this.label4.Name = "label4";
      this.label4.Size = new Size(41, 13);
      this.label4.TabIndex = 12;
      this.label4.Text = "Region";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(141, 193);
      this.label3.Name = "label3";
      this.label3.Size = new Size(91, 13);
      this.label3.TabIndex = 11;
      this.label3.Text = "Minimum seconds";
      this.numericUpDownMinimumGGSeconds.Location = new Point(232, 190);
      this.numericUpDownMinimumGGSeconds.Maximum = new Decimal(new int[4]
      {
        99,
        0,
        0,
        0
      });
      this.numericUpDownMinimumGGSeconds.Name = "numericUpDownMinimumGGSeconds";
      this.numericUpDownMinimumGGSeconds.Size = new Size(44, 20);
      this.numericUpDownMinimumGGSeconds.TabIndex = 10;
      this.numericUpDownMinimumGGSeconds.Value = new Decimal(new int[4]
      {
        60,
        0,
        0,
        0
      });
      this.label2.AutoSize = true;
      this.label2.Location = new Point(4, 65);
      this.label2.Name = "label2";
      this.label2.Size = new Size(63, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Looking for:";
      this.checkBoxAutoGGEnable.AutoSize = true;
      this.checkBoxAutoGGEnable.Location = new Point(32, 192);
      this.checkBoxAutoGGEnable.Name = "checkBoxAutoGGEnable";
      this.checkBoxAutoGGEnable.Size = new Size(98, 17);
      this.checkBoxAutoGGEnable.TabIndex = 7;
      this.checkBoxAutoGGEnable.Text = "Enable auto gg";
      this.checkBoxAutoGGEnable.UseVisualStyleBackColor = true;
      this.textBoxAutoGGMessage.Location = new Point(72, 164);
      this.textBoxAutoGGMessage.MaxLength = 65;
      this.textBoxAutoGGMessage.Name = "textBoxAutoGGMessage";
      this.textBoxAutoGGMessage.Size = new Size(204, 20);
      this.textBoxAutoGGMessage.TabIndex = 6;
      this.textBoxAutoGGMessage.Text = "gg";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 168);
      this.label1.Name = "label1";
      this.label1.Size = new Size(71, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "GG message:";
      this.textBoxComment.Location = new Point(72, 116);
      this.textBoxComment.MaxLength = 55;
      this.textBoxComment.Name = "textBoxComment";
      this.textBoxComment.Size = new Size(204, 20);
      this.textBoxComment.TabIndex = 2;
      this.textBoxComment.WordWrap = false;
      this.labelComment.AutoSize = true;
      this.labelComment.Location = new Point(4, 118);
      this.labelComment.Name = "labelComment";
      this.labelComment.Size = new Size(54, 13);
      this.labelComment.TabIndex = 4;
      this.labelComment.Text = "Comment:";
      this.textBoxName.Location = new Point(72, 9);
      this.textBoxName.MaxLength = 28;
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new Size(204, 20);
      this.textBoxName.TabIndex = 1;
      this.textBoxName.Text = "Guest";
      this.labelName.AutoSize = true;
      this.labelName.Location = new Point(4, 13);
      this.labelName.Name = "labelName";
      this.labelName.Size = new Size(38, 13);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Name:";
      this.tabPageWelcome.BorderStyle = BorderStyle.FixedSingle;
      this.tabPageWelcome.Controls.Add((Control) this.richTextBoxWelcome);
      this.tabPageWelcome.Location = new Point(4, 22);
      this.tabPageWelcome.Name = "tabPageWelcome";
      this.tabPageWelcome.Padding = new Padding(3);
      this.tabPageWelcome.Size = new Size(304, 141);
      this.tabPageWelcome.TabIndex = 2;
      this.tabPageWelcome.Text = "Welcome message";
      this.tabPageWelcome.UseVisualStyleBackColor = true;
      this.richTextBoxWelcome.BorderStyle = BorderStyle.None;
      this.richTextBoxWelcome.Dock = DockStyle.Fill;
      this.richTextBoxWelcome.Location = new Point(3, 3);
      this.richTextBoxWelcome.MaxLength = (int) sbyte.MaxValue;
      this.richTextBoxWelcome.Name = "richTextBoxWelcome";
      this.richTextBoxWelcome.Size = new Size(296, 133);
      this.richTextBoxWelcome.TabIndex = 1;
      this.richTextBoxWelcome.Text = "";
      this.tabPageCipher.Controls.Add((Control) this.buttonEncryption);
      this.tabPageCipher.Controls.Add((Control) this.textBoxAfterIP);
      this.tabPageCipher.Controls.Add((Control) this.textBoxBeforeIP);
      this.tabPageCipher.Controls.Add((Control) this.labelAfterIP);
      this.tabPageCipher.Controls.Add((Control) this.labelBeforeIP);
      this.tabPageCipher.Location = new Point(4, 22);
      this.tabPageCipher.Name = "tabPageCipher";
      this.tabPageCipher.Padding = new Padding(3);
      this.tabPageCipher.Size = new Size(304, 141);
      this.tabPageCipher.TabIndex = 3;
      this.tabPageCipher.Text = "IP change";
      this.tabPageCipher.UseVisualStyleBackColor = true;
      this.buttonEncryption.Location = new Point(132, 35);
      this.buttonEncryption.Name = "buttonEncryption";
      this.buttonEncryption.Size = new Size(84, 22);
      this.buttonEncryption.TabIndex = 2;
      this.buttonEncryption.Text = "Encrypt";
      this.buttonEncryption.UseVisualStyleBackColor = true;
      this.buttonEncryption.Click += new EventHandler(this.buttonEncryption_Click);
      this.textBoxAfterIP.Location = new Point(72, 61);
      this.textBoxAfterIP.Name = "textBoxAfterIP";
      this.textBoxAfterIP.ReadOnly = true;
      this.textBoxAfterIP.Size = new Size(204, 20);
      this.textBoxAfterIP.TabIndex = 3;
      this.textBoxBeforeIP.Location = new Point(72, 9);
      this.textBoxBeforeIP.Name = "textBoxBeforeIP";
      this.textBoxBeforeIP.Size = new Size(204, 20);
      this.textBoxBeforeIP.TabIndex = 1;
      this.textBoxBeforeIP.TextChanged += new EventHandler(this.textBoxBeforeIP_TextChanged);
      this.labelAfterIP.AutoSize = true;
      this.labelAfterIP.Location = new Point(4, 65);
      this.labelAfterIP.Name = "labelAfterIP";
      this.labelAfterIP.Size = new Size(68, 13);
      this.labelAfterIP.TabIndex = 0;
      this.labelAfterIP.Text = "Encrypted IP";
      this.labelBeforeIP.AutoSize = true;
      this.labelBeforeIP.Location = new Point(4, 13);
      this.labelBeforeIP.Name = "labelBeforeIP";
      this.labelBeforeIP.Size = new Size(55, 13);
      this.labelBeforeIP.TabIndex = 0;
      this.labelBeforeIP.Text = "Original IP";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      StartupForm startupForm1 = this;
      Button button = startupForm1.buttonCancel;
      startupForm1.CancelButton = (IButtonControl) button;
      this.ClientSize = new Size(312, 206);
      this.ControlBox = false;
      this.Controls.Add((Control) this.tabControlStartUp);
      this.Controls.Add((Control) this.buttonOK);
      this.Controls.Add((Control) this.buttonCancel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StartupForm";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Startup";
      StartupForm startupForm2 = this;
      // ISSUE: method pointer
      IntPtr method1 = __methodptr(StartupForm_Load);
      EventHandler eventHandler1 = new EventHandler((object) startupForm2, method1);
      startupForm2.Load += eventHandler1;
      StartupForm startupForm3 = this;
      // ISSUE: method pointer
      IntPtr method2 = __methodptr(StartupForm_Shown);
      EventHandler eventHandler2 = new EventHandler((object) startupForm3, method2);
      startupForm3.Shown += eventHandler2;
      this.numericUpDownOpenPort.EndInit();
      this.tabControlStartUp.ResumeLayout(false);
      this.tabPageMode.ResumeLayout(false);
      this.tabPageMode.PerformLayout();
      this.numericUpDownMaxConnection.EndInit();
      this.numericUpDownPort.EndInit();
      this.tabPageOption.ResumeLayout(false);
      this.tabPageOption.PerformLayout();
      this.numericUpDownMinimumGGSeconds.EndInit();
      this.tabPageWelcome.ResumeLayout(false);
      this.tabPageCipher.ResumeLayout(false);
      this.tabPageCipher.PerformLayout();
      this.ResumeLayout(false);
    }

    private unsafe void StartupForm_Load(object sender, EventArgs e)
    {
      string str1 = (string) null;
      this.textBoxName.MaxLength = 33;
      this.textBoxComment.MaxLength = 56;
      this.textBoxAutoGGMessage.MaxLength = 56;
      this.comboBoxServerName.MaxLength = 33;
      FileStream fileStream = new FileStream("servers.txt", FileMode.OpenOrCreate);
      StreamReader streamReader = new StreamReader((Stream) fileStream);
      str1 = (string) null;
      int num = 0;
      while (true)
      {
        string str2 = streamReader.ReadLine();
        if (str2 != (string) null)
        {
          this.comboBoxServerName.Items.Add((object) str2);
          ++num;
        }
        else
          break;
      }
      if (num == 0)
        this.comboBoxServerName.Items.Add((object) "none");
      this.comboBoxServerName.SelectedIndex = 0;
      streamReader.Close();
      fileStream.Close();
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      switch ((uint)  ((IntPtr) &Module.MTOPTION + 520))
      {
        case 0U:
          this.radioButtonServer.Checked = true;
          this.labelIP.Text = "Enter server name";
          this.numericUpDownPort.Enabled = false;
          break;
        case 1U:
          this.radioButtonHost.Checked = true;
          this.labelIP.Text = "Enter destination IP";
          this.richTextBoxWelcome.Enabled = false;
          break;
        default:
          this.radioButtonClient.Checked = true;
          this.labelIP.Text = "Enter destination IP";
          this.numericUpDownOpenPort.Enabled = false;
          this.richTextBoxWelcome.Enabled = false;
          break;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownOpenPort.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3956));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxDNS.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 3960);
      this.textBoxName.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3444));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.comboBoxPlayerRegion.SelectedIndex =  ((IntPtr) &Module.MTOPTION + 3948);
      this.textBoxLookingFor.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3618));
      this.textBoxAvoiding.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3728));
      this.textBoxComment.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3508));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownPort.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3952));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownMaxConnection.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 3968));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.numericUpDownMinimumGGSeconds.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 4052));
      this.richTextBoxWelcome.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 588));
      this.textBoxAutoGGMessage.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3838));
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      this.checkBoxAutoGGEnable.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4032);
    }

    private void StartupForm_Shown(object sender, EventArgs e)
    {
      this.buttonOK.Focus();
    }

    private unsafe void buttonOK_Click(object sender, EventArgs e)
    {
      IntPtr num1 = new IntPtr();
      if (this.radioButtonServer.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 520) = 0;
      }
      else if (this.radioButtonHost.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 520) = 1;
      }
      else if (this.radioButtonClient.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 520) = 2;
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 520) = 3;
      }
      IntPtr hglobal1 = Marshal.StringToHGlobalAuto(this.comboBoxServerName.Text);
      Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTOPTION + 524), (char*) hglobal1.ToPointer());
      Marshal.FreeHGlobal(hglobal1);
      if (this.textBoxName.Text.Length == 0)
      {
        this.textBoxName.Text = new string((char*) ((IntPtr) &Module.MTOPTION + 3444));
        if (this.textBoxName.Text.Length == 0)
          this.textBoxName.Text = "Guest";
      }
      StartupForm startupForm = this;
      string text = startupForm.textBoxName.Text;
      if (!startupForm.IsValidUsername(text))
        this.textBoxName.Text = "Guest";
      IntPtr hglobal2 = Marshal.StringToHGlobalAuto(this.textBoxName.Text);
      Module.wcscpy_s32((ArrayTypeBY0CA_W*) ((IntPtr) &Module.MTOPTION + 3444), (char*) hglobal2.ToPointer());
      Marshal.FreeHGlobal(hglobal2);
      Decimal num2 = this.numericUpDownOpenPort.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 3956) = (int) (uint) num2;
      Decimal num3 = this.numericUpDownPort.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 3952) = (int) (uint) num3;
      Decimal num4 = this.numericUpDownMaxConnection.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 3968) = (int) (uint) num4;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 3960) = (sbyte) this.checkBoxDNS.Checked;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4032) = (sbyte) this.checkBoxAutoGGEnable.Checked;
      Decimal num5 = this.numericUpDownMinimumGGSeconds.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4052) = (int) (uint) num5;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 3948) = this.comboBoxPlayerRegion.SelectedIndex;
      IntPtr hglobal3 = Marshal.StringToHGlobalAuto(this.textBoxComment.Text);
      Module.wcscpy_s55((ArrayTypeBY0DH_W*) ((IntPtr) &Module.MTOPTION + 3508), (char*) hglobal3.ToPointer());
      Marshal.FreeHGlobal(hglobal3);
      IntPtr hglobal4 = Marshal.StringToHGlobalAuto(this.textBoxLookingFor.Text);
      Module.wcscpy_s55((ArrayTypeBY0DH_W*) ((IntPtr) &Module.MTOPTION + 3618), (char*) hglobal4.ToPointer());
      Marshal.FreeHGlobal(hglobal4);
      hglobal4 = Marshal.StringToHGlobalAuto(this.textBoxAvoiding.Text);
      Module.wcscpy_s55((ArrayTypeBY0DH_W*) ((IntPtr) &Module.MTOPTION + 3728), (char*) hglobal4.ToPointer());
      Marshal.FreeHGlobal(hglobal4);
      hglobal4 = Marshal.StringToHGlobalAuto(this.richTextBoxWelcome.Text);
      Module.wcscpy_s128((ArrayTypeBY0IA_W*) ((IntPtr) &Module.MTOPTION + 588), (char*) hglobal4.ToPointer());
      Marshal.FreeHGlobal(hglobal4);
      hglobal4 = Marshal.StringToHGlobalAuto(this.textBoxAutoGGMessage.Text);
      Module.wcscpy_s55((ArrayTypeBY0DH_W*) ((IntPtr) &Module.MTOPTION + 3838), (char*) hglobal4.ToPointer());
      Marshal.FreeHGlobal(hglobal4);
      Module.SaveMTOption();
      this.Close();
    }

    private unsafe void buttonCancel_Click(object sender, EventArgs e)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 520) = 3;
      this.Close();
    }

    private void radioButtonServer_CheckedChanged(object sender, EventArgs e)
    {
      this.labelIP.Text = "Enter server name";
      this.numericUpDownOpenPort.Enabled = true;
      this.numericUpDownPort.Enabled = false;
      this.checkBoxDNS.Enabled = false;
      this.richTextBoxWelcome.Enabled = true;
      this.buttonOK.Enabled = true;
    }

    private void radioButtonHost_CheckedChanged(object sender, EventArgs e)
    {
      this.labelIP.Text = "Enter destination IP";
      this.numericUpDownOpenPort.Enabled = true;
      this.numericUpDownPort.Enabled = true;
      this.checkBoxDNS.Enabled = true;
      this.richTextBoxWelcome.Enabled = false;
    }

    private void radioButtonClient_CheckedChanged(object sender, EventArgs e)
    {
      this.labelIP.Text = "Enter destination IP";
      this.numericUpDownOpenPort.Enabled = false;
      this.numericUpDownPort.Enabled = true;
      this.checkBoxDNS.Enabled = true;
      this.richTextBoxWelcome.Enabled = false;
    }

    private void textBoxBeforeIP_TextChanged(object sender, EventArgs e)
    {
      IPAddress address = new IPAddress(0L);
      if (!IPAddress.TryParse(this.textBoxBeforeIP.Text, out address))
        this.buttonEncryption.Enabled = false;
      else
        this.buttonEncryption.Enabled = true;
    }

    private void buttonEncryption_Click(object sender, EventArgs e)
    {
      this.textBoxAfterIP.Text = Module.EncryptionIP(this.textBoxBeforeIP.Text);
      this.textBoxBeforeIP.Text = new IPAddress(Module.DecryptionIP(this.textBoxAfterIP.Text)).ToString();
    }

    private void labelIP_Click(object sender, EventArgs e)
    {
    }

    private void labelPort_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void comboBoxServerName_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void buttonEditServers_OnClick(object sender, EventArgs e)
    {
      try
      {
        Process.Start("servers.txt");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Could not open file", "Error");
      }
      this.Close();
    }

    private void buttonEditIgnoreList_OnClick(object sender, EventArgs e)
    {
      try
      {
        Process.Start("mtspfim_ignores.txt");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Could not open file", "Error");
      }
    }

    private void buttonEditDeclineList_OnClick(object sender, EventArgs e)
    {
      try
      {
        Process.Start("mtspfim_declines.txt");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Could not open file", "Error");
      }
    }

    private void buttonViewChangelog_OnClick(object sender, EventArgs e)
    {
      try
      {
        Process.Start("versioninfo.txt");
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Could not open file", "Error");
      }
    }

    [return: MarshalAs(UnmanagedType.U1)]
    private unsafe bool IsValidUsername(string username)
    {
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      return (!(username.ToLower() == "anniie") || (int)  ((IntPtr) &Module.MTOPTION + 4034) != 0) && username.Length > 1;
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.StartupForm();
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
