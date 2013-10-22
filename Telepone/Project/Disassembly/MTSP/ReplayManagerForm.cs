// Type: MTSP.ReplayManagerForm
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class ReplayManagerForm : Form
  {
    private Button buttonExit;
    private TextBox textBoxTargetPath;
    private Label label1;
    private Button button1;
    private GroupBox groupBox1;
    private TextBox textBoxContainsSpecifier;
    private Label label5;
    private Button button3;
    private Label label3;
    private NumericUpDown numericUpDownMaxByteSize;
    private CheckBox checkBoxBackupDelete;
    private CheckBox checkBoxDeleteOnlyMTR;
    private FolderBrowserDialog folderBrowserDialog1;
    private StatusStrip statusStrip1;
    private CheckBox checkBoxFilenameContains;
    private CheckBox checkBoxReplaySizeLessThan;
    private CheckBox checkBoxSinglePlayerOnly;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel StatusLabel;
    private GroupBox groupBoxMarkedReplays;
    private Button buttonScanForReplays;
    private Button buttonSortByDate;
    private ListBox listBoxReplayList;
    private CheckBox checkBoxFastScan;
    private ToolTip toolTipReplayList;
    private Button button2;
    private ContextMenuStrip contextMenuStripRepNav;
    private ToolStripMenuItem watchToolStripMenuItem;
    private ToolStripMenuItem toggleMarkToolStripMenuItem;
    private ToolStripMenuItem deleteToolStripMenuItem;
    private CheckBox checkBoxDontDeleteCommented;
    private CheckBox checkBoxDontDeleteMarked;
    private ToolStripSeparator toolStripMenuItem2;
    private ToolStripMenuItem addCommentToolStripMenuItem;
    private Label labelLoaded;
    private Label label2;
    private Label label4;
    private IContainer components;
    private List<Replay> frm_RepList;

    public ReplayManagerForm()
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

    private void ReplayManagerForm()
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ReplayManagerForm));
      this.buttonExit = new Button();
      this.textBoxTargetPath = new TextBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.groupBox1 = new GroupBox();
      this.checkBoxDontDeleteCommented = new CheckBox();
      this.checkBoxDontDeleteMarked = new CheckBox();
      this.checkBoxFilenameContains = new CheckBox();
      this.checkBoxReplaySizeLessThan = new CheckBox();
      this.checkBoxSinglePlayerOnly = new CheckBox();
      this.textBoxContainsSpecifier = new TextBox();
      this.label5 = new Label();
      this.button3 = new Button();
      this.label3 = new Label();
      this.numericUpDownMaxByteSize = new NumericUpDown();
      this.checkBoxBackupDelete = new CheckBox();
      this.checkBoxDeleteOnlyMTR = new CheckBox();
      this.folderBrowserDialog1 = new FolderBrowserDialog();
      this.statusStrip1 = new StatusStrip();
      this.toolStripStatusLabel1 = new ToolStripStatusLabel();
      this.StatusLabel = new ToolStripStatusLabel();
      this.groupBoxMarkedReplays = new GroupBox();
      this.label4 = new Label();
      this.labelLoaded = new Label();
      this.label2 = new Label();
      this.button2 = new Button();
      this.checkBoxFastScan = new CheckBox();
      this.listBoxReplayList = new ListBox();
      ReplayManagerForm replayManagerForm1 = this;
      ContextMenuStrip contextMenuStrip = new ContextMenuStrip(replayManagerForm1.components);
      replayManagerForm1.contextMenuStripRepNav = contextMenuStrip;
      this.watchToolStripMenuItem = new ToolStripMenuItem();
      this.toggleMarkToolStripMenuItem = new ToolStripMenuItem();
      this.deleteToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripSeparator();
      this.addCommentToolStripMenuItem = new ToolStripMenuItem();
      this.buttonSortByDate = new Button();
      this.buttonScanForReplays = new Button();
      ReplayManagerForm replayManagerForm2 = this;
      ToolTip toolTip = new ToolTip(replayManagerForm2.components);
      replayManagerForm2.toolTipReplayList = toolTip;
      this.groupBox1.SuspendLayout();
      this.numericUpDownMaxByteSize.BeginInit();
      this.statusStrip1.SuspendLayout();
      this.groupBoxMarkedReplays.SuspendLayout();
      this.contextMenuStripRepNav.SuspendLayout();
      this.SuspendLayout();
      this.buttonExit.Location = new Point(627, 20);
      this.buttonExit.Name = "buttonExit";
      this.buttonExit.Size = new Size(75, 23);
      this.buttonExit.TabIndex = 0;
      this.buttonExit.Text = "Exit";
      this.buttonExit.UseVisualStyleBackColor = true;
      this.buttonExit.Click += new EventHandler(this.buttonExit_OnClick);
      this.textBoxTargetPath.Location = new Point(84, 22);
      this.textBoxTargetPath.Name = "textBoxTargetPath";
      this.textBoxTargetPath.Size = new Size(389, 20);
      this.textBoxTargetPath.TabIndex = 1;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 25);
      this.label1.Name = "label1";
      this.label1.Size = new Size(70, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Target folder:";
      this.button1.Location = new Point(479, 20);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Browse";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.replayPathBrowse_OnClick);
      this.groupBox1.Controls.Add((Control) this.checkBoxDontDeleteCommented);
      this.groupBox1.Controls.Add((Control) this.checkBoxDontDeleteMarked);
      this.groupBox1.Controls.Add((Control) this.checkBoxFilenameContains);
      this.groupBox1.Controls.Add((Control) this.checkBoxReplaySizeLessThan);
      this.groupBox1.Controls.Add((Control) this.checkBoxSinglePlayerOnly);
      this.groupBox1.Controls.Add((Control) this.textBoxContainsSpecifier);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.button3);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Controls.Add((Control) this.numericUpDownMaxByteSize);
      this.groupBox1.Location = new Point(11, 75);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(373, 266);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Replay folder cleanup";
      this.checkBoxDontDeleteCommented.AutoSize = true;
      this.checkBoxDontDeleteCommented.Checked = true;
      this.checkBoxDontDeleteCommented.CheckState = CheckState.Checked;
      this.checkBoxDontDeleteCommented.Location = new Point(8, 131);
      this.checkBoxDontDeleteCommented.Name = "checkBoxDontDeleteCommented";
      this.checkBoxDontDeleteCommented.Size = new Size(177, 17);
      this.checkBoxDontDeleteCommented.TabIndex = 13;
      this.checkBoxDontDeleteCommented.Text = "Don't delete commented replays";
      this.checkBoxDontDeleteCommented.UseVisualStyleBackColor = true;
      this.checkBoxDontDeleteMarked.AutoSize = true;
      this.checkBoxDontDeleteMarked.Checked = true;
      this.checkBoxDontDeleteMarked.CheckState = CheckState.Checked;
      this.checkBoxDontDeleteMarked.Location = new Point(8, 108);
      this.checkBoxDontDeleteMarked.Name = "checkBoxDontDeleteMarked";
      this.checkBoxDontDeleteMarked.Size = new Size(157, 17);
      this.checkBoxDontDeleteMarked.TabIndex = 12;
      this.checkBoxDontDeleteMarked.Text = "Don't delete marked replays";
      this.checkBoxDontDeleteMarked.UseVisualStyleBackColor = true;
      this.checkBoxFilenameContains.AutoSize = true;
      this.checkBoxFilenameContains.Location = new Point(8, 85);
      this.checkBoxFilenameContains.Name = "checkBoxFilenameContains";
      this.checkBoxFilenameContains.Size = new Size(111, 17);
      this.checkBoxFilenameContains.TabIndex = 11;
      this.checkBoxFilenameContains.Text = "Filename contains";
      this.checkBoxFilenameContains.UseVisualStyleBackColor = true;
      this.checkBoxReplaySizeLessThan.AutoSize = true;
      this.checkBoxReplaySizeLessThan.Checked = true;
      this.checkBoxReplaySizeLessThan.CheckState = CheckState.Checked;
      this.checkBoxReplaySizeLessThan.Location = new Point(8, 41);
      this.checkBoxReplaySizeLessThan.Name = "checkBoxReplaySizeLessThan";
      this.checkBoxReplaySizeLessThan.Size = new Size(135, 17);
      this.checkBoxReplaySizeLessThan.TabIndex = 10;
      this.checkBoxReplaySizeLessThan.Text = "Replay size is less than";
      this.checkBoxReplaySizeLessThan.UseVisualStyleBackColor = true;
      this.checkBoxSinglePlayerOnly.AutoSize = true;
      this.checkBoxSinglePlayerOnly.Location = new Point(8, 19);
      this.checkBoxSinglePlayerOnly.Name = "checkBoxSinglePlayerOnly";
      this.checkBoxSinglePlayerOnly.Size = new Size(144, 17);
      this.checkBoxSinglePlayerOnly.TabIndex = 8;
      this.checkBoxSinglePlayerOnly.Text = "Single player replays only";
      this.checkBoxSinglePlayerOnly.UseVisualStyleBackColor = true;
      this.textBoxContainsSpecifier.Location = new Point(121, 83);
      this.textBoxContainsSpecifier.Name = "textBoxContainsSpecifier";
      this.textBoxContainsSpecifier.Size = new Size(142, 20);
      this.textBoxContainsSpecifier.TabIndex = 9;
      this.textBoxContainsSpecifier.Text = "insert playername or string";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(221, 43);
      this.label5.Name = "label5";
      this.label5.Size = new Size(32, 13);
      this.label5.TabIndex = 6;
      this.label5.Text = "bytes";
      this.button3.Location = new Point(6, 157);
      this.button3.Name = "button3";
      this.button3.Size = new Size(92, 23);
      this.button3.TabIndex = 4;
      this.button3.Text = "Delete specified";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.DeleteSpecified_OnClick);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(9, 62);
      this.label3.Name = "label3";
      this.label3.Size = new Size(361, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "(Replays smaller than 1500 bytes are likely to be incomplete or junk replays)";
      this.numericUpDownMaxByteSize.Location = new Point(143, 40);
      this.numericUpDownMaxByteSize.Maximum = new Decimal(new int[4]
      {
        40000000,
        0,
        0,
        0
      });
      this.numericUpDownMaxByteSize.Name = "numericUpDownMaxByteSize";
      this.numericUpDownMaxByteSize.Size = new Size(77, 20);
      this.numericUpDownMaxByteSize.TabIndex = 2;
      this.numericUpDownMaxByteSize.Value = new Decimal(new int[4]
      {
        1500,
        0,
        0,
        0
      });
      this.checkBoxBackupDelete.AutoSize = true;
      this.checkBoxBackupDelete.Checked = true;
      this.checkBoxBackupDelete.CheckState = CheckState.Checked;
      this.checkBoxBackupDelete.Location = new Point(11, 52);
      this.checkBoxBackupDelete.Name = "checkBoxBackupDelete";
      this.checkBoxBackupDelete.Size = new Size(236, 17);
      this.checkBoxBackupDelete.TabIndex = 5;
      this.checkBoxBackupDelete.Text = "Send deleted replays to replay backup folder";
      this.checkBoxBackupDelete.UseVisualStyleBackColor = true;
      this.checkBoxDeleteOnlyMTR.AutoSize = true;
      this.checkBoxDeleteOnlyMTR.Checked = true;
      this.checkBoxDeleteOnlyMTR.CheckState = CheckState.Checked;
      this.checkBoxDeleteOnlyMTR.Location = new Point(253, 52);
      this.checkBoxDeleteOnlyMTR.Name = "checkBoxDeleteOnlyMTR";
      this.checkBoxDeleteOnlyMTR.Size = new Size(120, 17);
      this.checkBoxDeleteOnlyMTR.TabIndex = 6;
      this.checkBoxDeleteOnlyMTR.Text = "Only delete .mtr files";
      this.checkBoxDeleteOnlyMTR.UseVisualStyleBackColor = true;
      this.statusStrip1.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.toolStripStatusLabel1,
        (ToolStripItem) this.StatusLabel
      });
      this.statusStrip1.Location = new Point(0, 351);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new Size(714, 22);
      this.statusStrip1.TabIndex = 7;
      this.statusStrip1.Text = "statusStrip1";
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new Size(42, 17);
      this.toolStripStatusLabel1.Text = "Status:";
      this.StatusLabel.Name = "StatusLabel";
      this.StatusLabel.Size = new Size(10, 17);
      this.StatusLabel.Text = " ";
      this.groupBoxMarkedReplays.Controls.Add((Control) this.label4);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.labelLoaded);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.label2);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.button2);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.checkBoxFastScan);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.listBoxReplayList);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.buttonSortByDate);
      this.groupBoxMarkedReplays.Controls.Add((Control) this.buttonScanForReplays);
      this.groupBoxMarkedReplays.Location = new Point(390, 46);
      this.groupBoxMarkedReplays.Name = "groupBoxMarkedReplays";
      this.groupBoxMarkedReplays.Size = new Size(312, 295);
      this.groupBoxMarkedReplays.TabIndex = 8;
      this.groupBoxMarkedReplays.TabStop = false;
      this.groupBoxMarkedReplays.Text = "Replay navigator";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(7, 209);
      this.label4.Name = "label4";
      this.label4.Size = new Size(184, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Right click a replay for more functions";
      this.labelLoaded.AutoSize = true;
      this.labelLoaded.Location = new Point(60, 187);
      this.labelLoaded.Name = "labelLoaded";
      this.labelLoaded.Size = new Size(13, 13);
      this.labelLoaded.TabIndex = 7;
      this.labelLoaded.Text = "0";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(7, 187);
      this.label2.Name = "label2";
      this.label2.Size = new Size(46, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Loaded:";
      this.button2.Location = new Point(197, 243);
      this.button2.Name = "button2";
      this.button2.Size = new Size(84, 23);
      this.button2.TabIndex = 5;
      this.button2.Text = "Scan favorites";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.ScanMarked_OnClick);
      this.checkBoxFastScan.AutoSize = true;
      this.checkBoxFastScan.Location = new Point(7, 272);
      this.checkBoxFastScan.Name = "checkBoxFastScan";
      this.checkBoxFastScan.Size = new Size(229, 17);
      this.checkBoxFastScan.TabIndex = 4;
      this.checkBoxFastScan.Text = "Don't load entire replay file (faster, less info)";
      this.checkBoxFastScan.UseVisualStyleBackColor = true;
      this.listBoxReplayList.ContextMenuStrip = this.contextMenuStripRepNav;
      this.listBoxReplayList.DrawMode = DrawMode.OwnerDrawFixed;
      this.listBoxReplayList.FormattingEnabled = true;
      this.listBoxReplayList.Location = new Point(7, 20);
      this.listBoxReplayList.Name = "listBoxReplayList";
      this.listBoxReplayList.Size = new Size(299, 160);
      this.listBoxReplayList.TabIndex = 3;
      this.listBoxReplayList.DrawItem += new DrawItemEventHandler(this.ReplayNav_DrawItem);
      this.listBoxReplayList.BackColorChanged += new EventHandler(this.ReplayNav_CollectionChanged);
      this.listBoxReplayList.DoubleClick += new EventHandler(this.addCommentToolStripMenuItem_OnClick);
      this.listBoxReplayList.MouseMove += new MouseEventHandler(this.ReplayNav_MouseMove);
      this.contextMenuStripRepNav.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.watchToolStripMenuItem,
        (ToolStripItem) this.toggleMarkToolStripMenuItem,
        (ToolStripItem) this.deleteToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.addCommentToolStripMenuItem
      });
      this.contextMenuStripRepNav.Name = "contextMenuStripRepNav";
      this.contextMenuStripRepNav.Size = new Size(152, 98);
      this.contextMenuStripRepNav.Opening += new CancelEventHandler(this.contextMenuStripRepNav_Opening);
      this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
      this.watchToolStripMenuItem.Size = new Size(151, 22);
      this.watchToolStripMenuItem.Text = "Watch";
      this.watchToolStripMenuItem.Click += new EventHandler(this.ContextMenuStripWatch_OnClick);
      this.toggleMarkToolStripMenuItem.Name = "toggleMarkToolStripMenuItem";
      this.toggleMarkToolStripMenuItem.Size = new Size(151, 22);
      this.toggleMarkToolStripMenuItem.Text = "Toggle mark";
      this.toggleMarkToolStripMenuItem.Click += new EventHandler(this.ContextMenuStripToggleMark_OnClick);
      this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
      this.deleteToolStripMenuItem.Size = new Size(151, 22);
      this.deleteToolStripMenuItem.Text = "Delete";
      this.deleteToolStripMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_OnClick);
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new Size(148, 6);
      this.addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
      this.addCommentToolStripMenuItem.Size = new Size(151, 22);
      this.addCommentToolStripMenuItem.Text = "Add comment...";
      this.addCommentToolStripMenuItem.Click += new EventHandler(this.addCommentToolStripMenuItem_OnClick);
      this.buttonSortByDate.Location = new Point(113, 242);
      this.buttonSortByDate.Name = "buttonSortByDate";
      this.buttonSortByDate.Size = new Size(78, 23);
      this.buttonSortByDate.TabIndex = 2;
      this.buttonSortByDate.Text = "Scan by date";
      this.buttonSortByDate.UseVisualStyleBackColor = true;
      this.buttonSortByDate.Click += new EventHandler(this.SortByDate_OnClick);
      this.buttonScanForReplays.Location = new Point(7, 242);
      this.buttonScanForReplays.Name = "buttonScanForReplays";
      this.buttonScanForReplays.Size = new Size(100, 23);
      this.buttonScanForReplays.TabIndex = 1;
      this.buttonScanForReplays.Text = "Alphabetical scan";
      this.buttonScanForReplays.UseVisualStyleBackColor = true;
      this.buttonScanForReplays.Click += new EventHandler(this.buttonReplayNavScan);
      this.toolTipReplayList.AutoPopDelay = 5000;
      this.toolTipReplayList.InitialDelay = 50;
      this.toolTipReplayList.ReshowDelay = 20;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(714, 373);
      this.Controls.Add((Control) this.groupBoxMarkedReplays);
      this.Controls.Add((Control) this.statusStrip1);
      this.Controls.Add((Control) this.checkBoxDeleteOnlyMTR);
      this.Controls.Add((Control) this.checkBoxBackupDelete);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.buttonExit);
      this.Controls.Add((Control) this.textBoxTargetPath);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = "ReplayManagerForm";
      this.ShowInTaskbar = false;
      this.Text = "Replay manager";
      ReplayManagerForm replayManagerForm3 = this;
      // ISSUE: method pointer
      IntPtr method = __methodptr(ReplayManager_OnLoad);
      EventHandler eventHandler = new EventHandler((object) replayManagerForm3, method);
      replayManagerForm3.Load += eventHandler;
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.numericUpDownMaxByteSize.EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.groupBoxMarkedReplays.ResumeLayout(false);
      this.groupBoxMarkedReplays.PerformLayout();
      this.contextMenuStripRepNav.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void CallStartGame(Form parentform, string path, uint type)
    {
      MainForm mainForm = (MainForm) parentform;
      MainForm.ReplayFilePath = path;
      mainForm.StartGame(type);
    }

    private List<Replay> GetReplays()
    {
      List<Replay> list1;
      if (this.textBoxTargetPath.Text.Length <= 0)
      {
        this.StatusLabel.Text = "Invalid filepath to replay directory";
        list1 = (List<Replay>) null;
      }
      else
      {
        string[] files = Directory.GetFiles(this.textBoxTargetPath.Text);
        IEnumerator enumerator = files.GetEnumerator();
        List<Replay> list2 = new List<Replay>();
        ProgressWindow progressWindow = new ProgressWindow();
        progressWindow.Setup("Scanning directory...", 0, files.Length, 0, 1);
        ((Control) progressWindow).Show();
        int num = 0;
        while (enumerator.MoveNext())
        {
          string path = (string) enumerator.Current;
          progressWindow.SetProgressText(string.Format("{0}", (object) path), true);
          progressWindow.Step();
          Replay replay = new Replay(path, this.checkBoxFastScan.Checked);
          list2.Add(replay);
          ++num;
        }
        list1 = list2;
      }
      return list1;
    }

    private void buttonExit_OnClick(object sender, EventArgs e)
    {
      this.Close();
    }

    private unsafe void ReplayManager_OnLoad(object sender, EventArgs e)
    {
      string str = "C:\\";
      // ISSUE: cast to a reference type
      if ((_MT_SP_OPTION&) ((IntPtr) &Module.MTOPTION + 1364) != null)
      {
        str = new string((char*) ((IntPtr) &Module.MTOPTION + 1364));
        this.textBoxTargetPath.Text = str;
      }
      this.folderBrowserDialog1.ShowNewFolderButton = true;
      this.folderBrowserDialog1.Description = "Select folder containing Telepone replays";
      this.folderBrowserDialog1.SelectedPath = str;
      if (!Directory.Exists("mtspbackups"))
        Directory.CreateDirectory("mtspbackups");
      if (Directory.Exists("mtspbackups/replays"))
        return;
      Directory.CreateDirectory("mtspbackups/replays");
    }

    private void replayPathBrowse_OnClick(object sender, EventArgs e)
    {
      if (this.folderBrowserDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBoxTargetPath.Text = this.folderBrowserDialog1.SelectedPath;
    }

    private void DeleteSpecified_OnClick(object sender, EventArgs e)
    {
      string str1 = (string) null;
      this.StatusLabel.Text = " ";
      if (this.textBoxTargetPath.Text.Length <= 0)
      {
        this.StatusLabel.Text = "Invalid filepath to replay directory";
      }
      else
      {
        string[] files = Directory.GetFiles(this.textBoxTargetPath.Text);
        IEnumerator enumerator1 = files.GetEnumerator();
        List<string> list = new List<string>();
        while (enumerator1.MoveNext())
        {
          string str2 = (string) enumerator1.Current;
          if (!this.checkBoxDeleteOnlyMTR.Checked || !(Path.GetExtension(str2) != ".mtr"))
          {
            Replay replay = new Replay(str2, false);
            if ((replay.GetState() == (REP_FILE_STATE) 0 || !replay.m_Marked || !this.checkBoxDontDeleteMarked.Checked) && (replay.GetState() == (REP_FILE_STATE) 0 || !(replay.m_Comment != string.Empty) || !this.checkBoxDontDeleteCommented.Checked))
            {
              FileInfo fileInfo = new FileInfo(str2);
              if (this.checkBoxReplaySizeLessThan.Checked)
              {
                Decimal num = this.numericUpDownMaxByteSize.Value;
                if ((Decimal) fileInfo.Length > num)
                  continue;
              }
              if (this.checkBoxFilenameContains.Checked)
              {
                string str3 = this.textBoxContainsSpecifier.Text.ToUpper();
                if (!Path.GetFileNameWithoutExtension(str2).ToUpper().Contains(str3))
                  continue;
              }
              if (!this.checkBoxSinglePlayerOnly.Checked || !Path.GetFileNameWithoutExtension(str2).Contains("_vs_"))
                list.Add(str2);
            }
          }
        }
        if (list.Count <= 0)
          this.StatusLabel.Text = "No files matching the criteria were found";
        else if (MessageBox.Show(string.Format("{0} files matched out of {1}. OK to continue?", (object) list.Count, (object) files.Length), "Proceed?", MessageBoxButtons.YesNo) == DialogResult.No)
        {
          this.StatusLabel.Text = "Operation cancelled";
        }
        else
        {
          IEnumerator enumerator2 = (IEnumerator) list.GetEnumerator();
          int num = 0;
          while (enumerator2.MoveNext())
          {
            string str2 = (string) enumerator2.Current;
            if (this.checkBoxBackupDelete.Checked)
            {
              try
              {
                File.Copy(str2, "mtspbackups/replays/" + Path.GetFileName(str2), true);
              }
              catch (Exception ex)
              {
                str1 = ex.ToString();
              }
            }
            File.Delete(str2);
            ++num;
          }
          this.listBoxReplayList.Items.Clear();
          ReplayManagerForm replayManagerForm = this;
          // ISSUE: variable of the null type
          __Null local = null;
          replayManagerForm.ReplayNav_CollectionChanged((object) replayManagerForm, (EventArgs) local);
          this.StatusLabel.Text = string.Format("{0} files deleted/backed up.", (object) num);
        }
      }
    }

    private void buttonReplayNavScan(object sender, EventArgs e)
    {
      ReplayManagerForm replayManagerForm1 = this;
      List<Replay> replays = replayManagerForm1.GetReplays();
      replayManagerForm1.frm_RepList = replays;
      if (this.frm_RepList.Count <= 1)
        return;
      ProgressWindow progressWindow = new ProgressWindow();
      progressWindow.Setup("Scanning directory...", 0, this.frm_RepList.Count, 0, 1);
      ((Control) progressWindow).Show();
      this.listBoxReplayList.Items.Clear();
      List<Replay>.Enumerator enumerator = this.frm_RepList.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Replay current = enumerator.Current;
        progressWindow.SetProgressText(string.Format("{0}", (object) current.m_FullFilepath), true);
        progressWindow.Step();
        this.listBoxReplayList.Items.Add((object) current);
      }
      ReplayManagerForm replayManagerForm2 = this;
      // ISSUE: variable of the null type
      __Null local = null;
      replayManagerForm2.ReplayNav_CollectionChanged((object) replayManagerForm2, (EventArgs) local);
      this.StatusLabel.Text = string.Format("Found {0} replays.", (object) this.listBoxReplayList.Items.Count);
    }

    private void ReplayNav_DrawItem(object sender, DrawItemEventArgs e)
    {
      if (e.Index == -1 || e.Index >= this.listBoxReplayList.Items.Count)
        return;
      Brush brush = (Brush) new SolidBrush(Color.FromName("Black"));
      e.DrawBackground();
      Replay replay = (Replay) this.listBoxReplayList.Items[e.Index];
      if (replay.GetState() == (REP_FILE_STATE) 0)
        brush = (Brush) new SolidBrush(Color.FromName("Gray"));
      else if (replay.GetState() == (REP_FILE_STATE) 2)
        brush = (Brush) new SolidBrush(Color.FromName("Goldenrod"));
      RectangleF layoutRectangle = (RectangleF) e.Bounds;
      e.Graphics.DrawString(this.listBoxReplayList.Items[e.Index].ToString(), e.Font, brush, layoutRectangle);
      e.DrawFocusRectangle();
    }

    private void ReplayNav_MouseMove(object sender, MouseEventArgs e)
    {
      int index = this.listBoxReplayList.IndexFromPoint(e.X, e.Y);
      if (index == -1)
      {
        this.toolTipReplayList.Active = false;
      }
      else
      {
        if (index >= this.listBoxReplayList.Items.Count)
          return;
        Replay replay = (Replay) this.listBoxReplayList.Items[index];
        if (index == -1)
        {
          this.toolTipReplayList.Active = false;
        }
        else
        {
          this.toolTipReplayList.Active = true;
          this.toolTipReplayList.SetToolTip((Control) this.listBoxReplayList, replay.GetInfoString(this.checkBoxFastScan.Checked));
        }
      }
    }

    private void SortByDate_OnClick(object sender, EventArgs e)
    {
      ReplayManagerForm replayManagerForm1 = this;
      List<Replay> replays = replayManagerForm1.GetReplays();
      replayManagerForm1.frm_RepList = replays;
      if (this.frm_RepList.Count <= 1)
        return;
      Replay replay = new Replay("", true);
      replay.SetCompareType((REP_CMP_TYPE) 1);
      this.frm_RepList.Sort((IComparer<Replay>) replay);
      ProgressWindow progressWindow = new ProgressWindow();
      progressWindow.Setup("Scanning directory...", 0, this.frm_RepList.Count, 0, 1);
      ((Control) progressWindow).Show();
      this.listBoxReplayList.Items.Clear();
      List<Replay>.Enumerator enumerator = this.frm_RepList.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Replay current = enumerator.Current;
        progressWindow.SetProgressText(string.Format("{0}", (object) current.m_FullFilepath), true);
        progressWindow.Step();
        this.listBoxReplayList.Items.Add((object) current);
      }
      ReplayManagerForm replayManagerForm2 = this;
      // ISSUE: variable of the null type
      __Null local = null;
      replayManagerForm2.ReplayNav_CollectionChanged((object) replayManagerForm2, (EventArgs) local);
      this.StatusLabel.Text = string.Format("Found {0} replays.", (object) this.listBoxReplayList.Items.Count);
    }

    private void ScanMarked_OnClick(object sender, EventArgs e)
    {
      ReplayManagerForm replayManagerForm1 = this;
      List<Replay> replays = replayManagerForm1.GetReplays();
      replayManagerForm1.frm_RepList = replays;
      if (this.frm_RepList.Count <= 1)
        return;
      Replay replay = new Replay("", true);
      replay.SetCompareType((REP_CMP_TYPE) 2);
      this.frm_RepList.Sort((IComparer<Replay>) replay);
      ProgressWindow progressWindow = new ProgressWindow();
      progressWindow.Setup("Scanning directory...", 0, this.frm_RepList.Count, 0, 1);
      ((Control) progressWindow).Show();
      this.listBoxReplayList.Items.Clear();
      List<Replay>.Enumerator enumerator = this.frm_RepList.GetEnumerator();
      while (enumerator.MoveNext())
      {
        Replay current = enumerator.Current;
        progressWindow.SetProgressText(string.Format("{0}", (object) current.m_FullFilepath), true);
        progressWindow.Step();
        this.listBoxReplayList.Items.Add((object) current);
      }
      ReplayManagerForm replayManagerForm2 = this;
      // ISSUE: variable of the null type
      __Null local = null;
      replayManagerForm2.ReplayNav_CollectionChanged((object) replayManagerForm2, (EventArgs) local);
      this.StatusLabel.Text = string.Format("Found {0} replays.", (object) this.listBoxReplayList.Items.Count);
    }

    private void contextMenuStripRepNav_Opening(object sender, CancelEventArgs e)
    {
      if (this.listBoxReplayList.SelectedIndex == -1 || this.listBoxReplayList.Items.Count < 1 || this.listBoxReplayList.SelectedIndex > this.listBoxReplayList.Items.Count)
      {
        this.watchToolStripMenuItem.Enabled = false;
        this.toggleMarkToolStripMenuItem.Enabled = false;
        this.deleteToolStripMenuItem.Enabled = false;
        this.addCommentToolStripMenuItem.Enabled = false;
      }
      else
      {
        Replay replay = (Replay) this.listBoxReplayList.Items[this.listBoxReplayList.SelectedIndex];
        if (replay.GetState() == (REP_FILE_STATE) 0)
        {
          this.watchToolStripMenuItem.Enabled = false;
          this.toggleMarkToolStripMenuItem.Enabled = false;
          this.deleteToolStripMenuItem.Enabled = false;
          this.addCommentToolStripMenuItem.Enabled = false;
        }
        else
        {
          if (replay.IsWatchable())
            this.watchToolStripMenuItem.Enabled = true;
          if (replay.m_Marked)
            this.toggleMarkToolStripMenuItem.Text = "Unmark";
          else
            this.toggleMarkToolStripMenuItem.Text = "Mark";
          this.toggleMarkToolStripMenuItem.Enabled = true;
          this.deleteToolStripMenuItem.Enabled = true;
          this.addCommentToolStripMenuItem.Enabled = true;
        }
      }
    }

    private void ContextMenuStripWatch_OnClick(object sender, EventArgs e)
    {
      Replay replay = (Replay) this.listBoxReplayList.Items[this.listBoxReplayList.SelectedIndex];
      ReplayManagerForm replayManagerForm = this;
      Form owner = replayManagerForm.Owner;
      string path = replay.m_FullFilepath;
      int num = 3;
      replayManagerForm.CallStartGame(owner, path, (uint) num);
    }

    private void ContextMenuStripToggleMark_OnClick(object sender, EventArgs e)
    {
      Replay replay = (Replay) this.listBoxReplayList.Items[this.listBoxReplayList.SelectedIndex];
      replay.ToggleMarked();
      replay.Save((string) null, true);
      int selectedIndex = this.listBoxReplayList.SelectedIndex;
      this.listBoxReplayList.Items.RemoveAt(selectedIndex);
      this.listBoxReplayList.Items.Insert(selectedIndex, (object) replay);
    }

    private void deleteToolStripMenuItem_OnClick(object sender, EventArgs e)
    {
      string str = (string) null;
      Replay replay = (Replay) this.listBoxReplayList.Items[this.listBoxReplayList.SelectedIndex];
      if (this.checkBoxBackupDelete.Checked)
      {
        try
        {
          File.Copy(replay.m_FullFilepath, "mtspbackups/replays/" + replay.m_FullFilename, true);
          this.StatusLabel.Text = string.Format("Moved {0} to backup folder.", (object) replay.m_FullFilename);
        }
        catch (Exception ex)
        {
          str = ex.ToString();
        }
      }
      else
      {
        File.Delete(replay.m_FullFilepath);
        this.StatusLabel.Text = string.Format("Deleted {0}", (object) replay.m_FullFilename);
      }
      this.listBoxReplayList.Items.RemoveAt(this.listBoxReplayList.SelectedIndex);
      ReplayManagerForm replayManagerForm = this;
      // ISSUE: variable of the null type
      __Null local = null;
      replayManagerForm.ReplayNav_CollectionChanged((object) replayManagerForm, (EventArgs) local);
    }

    private void addCommentToolStripMenuItem_OnClick(object sender, EventArgs e)
    {
      Replay rep = (Replay) this.listBoxReplayList.Items[this.listBoxReplayList.SelectedIndex];
      ReplayDetailViewForm replayDetailViewForm = new ReplayDetailViewForm();
      replayDetailViewForm.SendReplay(rep);
      int num = (int) replayDetailViewForm.ShowDialog((IWin32Window) this);
    }

    private void ReplayNav_CollectionChanged(object sender, EventArgs e)
    {
      this.labelLoaded.Text = this.listBoxReplayList.Items.Count.ToString();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.ReplayManagerForm();
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
