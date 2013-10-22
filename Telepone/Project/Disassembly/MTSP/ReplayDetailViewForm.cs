// Type: MTSP.ReplayDetailViewForm
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class ReplayDetailViewForm : Form
  {
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label12;
    private Label label13;
    private Label label14;
    private TextBox textBoxP1Name;
    private TextBox textBoxP2Name;
    private TextBox textBoxReplayType;
    private TextBox textBoxTimer;
    private TextBox textBoxMaxStage;
    private TextBox textBoxRound;
    private TextBox textBoxRandomSeed;
    private TextBox textBoxPath;
    private TextBox textBoxComment;
    private TextBox textBoxSaveVersion;
    private TextBox textBoxGameName;
    private TextBox textBoxCreated;
    private TextBox textBoxEstFrames;
    private Button buttonSave;
    private Button buttonCancel;
    private RadioButton radioButtonMarkedYes;
    private RadioButton radioButtonMarkedNo;
    private Container components;
    public Replay the_replay;

    public ReplayDetailViewForm()
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

    private void ReplayDetailViewForm()
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
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.label8 = new Label();
      this.label9 = new Label();
      this.label10 = new Label();
      this.label11 = new Label();
      this.label12 = new Label();
      this.label13 = new Label();
      this.label14 = new Label();
      this.textBoxP1Name = new TextBox();
      this.textBoxP2Name = new TextBox();
      this.textBoxReplayType = new TextBox();
      this.textBoxTimer = new TextBox();
      this.textBoxMaxStage = new TextBox();
      this.textBoxRound = new TextBox();
      this.textBoxRandomSeed = new TextBox();
      this.textBoxPath = new TextBox();
      this.textBoxComment = new TextBox();
      this.textBoxSaveVersion = new TextBox();
      this.textBoxGameName = new TextBox();
      this.textBoxCreated = new TextBox();
      this.textBoxEstFrames = new TextBox();
      this.buttonSave = new Button();
      this.buttonCancel = new Button();
      this.radioButtonMarkedYes = new RadioButton();
      this.radioButtonMarkedNo = new RadioButton();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new Size(48, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Player 1:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(13, 35);
      this.label2.Name = "label2";
      this.label2.Size = new Size(48, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Player 2:";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(13, 57);
      this.label3.Name = "label3";
      this.label3.Size = new Size(66, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Replay type:";
      this.label4.AutoSize = true;
      this.label4.Location = new Point(12, 145);
      this.label4.Name = "label4";
      this.label4.Size = new Size(76, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Random seed:";
      this.label5.AutoSize = true;
      this.label5.Location = new Point(13, 101);
      this.label5.Name = "label5";
      this.label5.Size = new Size(59, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Max stage:";
      this.label6.AutoSize = true;
      this.label6.Location = new Point(13, 123);
      this.label6.Name = "label6";
      this.label6.Size = new Size(42, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Round:";
      this.label7.AutoSize = true;
      this.label7.Location = new Point(13, 79);
      this.label7.Name = "label7";
      this.label7.Size = new Size(36, 13);
      this.label7.TabIndex = 6;
      this.label7.Text = "Timer:";
      this.label8.AutoSize = true;
      this.label8.Location = new Point(13, 167);
      this.label8.Name = "label8";
      this.label8.Size = new Size(32, 13);
      this.label8.TabIndex = 7;
      this.label8.Text = "Path:";
      this.label9.AutoSize = true;
      this.label9.Location = new Point(212, 13);
      this.label9.Name = "label9";
      this.label9.Size = new Size(72, 13);
      this.label9.TabIndex = 8;
      this.label9.Text = "Save version:";
      this.label10.AutoSize = true;
      this.label10.Location = new Point(212, 35);
      this.label10.Name = "label10";
      this.label10.Size = new Size(46, 13);
      this.label10.TabIndex = 9;
      this.label10.Text = "Marked:";
      this.label11.AutoSize = true;
      this.label11.Location = new Point(212, 57);
      this.label11.Name = "label11";
      this.label11.Size = new Size(67, 13);
      this.label11.TabIndex = 10;
      this.label11.Text = "Game name:";
      this.label12.AutoSize = true;
      this.label12.Location = new Point(212, 79);
      this.label12.Name = "label12";
      this.label12.Size = new Size(47, 13);
      this.label12.TabIndex = 11;
      this.label12.Text = "Created:";
      this.label13.AutoSize = true;
      this.label13.Location = new Point(13, 189);
      this.label13.Name = "label13";
      this.label13.Size = new Size(54, 13);
      this.label13.TabIndex = 12;
      this.label13.Text = "Comment:";
      this.label14.AutoSize = true;
      this.label14.Location = new Point(212, 101);
      this.label14.Name = "label14";
      this.label14.Size = new Size(62, 13);
      this.label14.TabIndex = 13;
      this.label14.Text = "Est. frames:";
      this.textBoxP1Name.Location = new Point(90, 10);
      this.textBoxP1Name.Name = "textBoxP1Name";
      this.textBoxP1Name.ReadOnly = true;
      this.textBoxP1Name.Size = new Size(119, 20);
      this.textBoxP1Name.TabIndex = 14;
      this.textBoxP2Name.Location = new Point(90, 32);
      this.textBoxP2Name.Name = "textBoxP2Name";
      this.textBoxP2Name.ReadOnly = true;
      this.textBoxP2Name.Size = new Size(119, 20);
      this.textBoxP2Name.TabIndex = 15;
      this.textBoxReplayType.Location = new Point(90, 54);
      this.textBoxReplayType.Name = "textBoxReplayType";
      this.textBoxReplayType.ReadOnly = true;
      this.textBoxReplayType.Size = new Size(80, 20);
      this.textBoxReplayType.TabIndex = 16;
      this.textBoxTimer.Location = new Point(90, 76);
      this.textBoxTimer.Name = "textBoxTimer";
      this.textBoxTimer.ReadOnly = true;
      this.textBoxTimer.Size = new Size(35, 20);
      this.textBoxTimer.TabIndex = 17;
      this.textBoxMaxStage.Location = new Point(90, 98);
      this.textBoxMaxStage.Name = "textBoxMaxStage";
      this.textBoxMaxStage.ReadOnly = true;
      this.textBoxMaxStage.Size = new Size(35, 20);
      this.textBoxMaxStage.TabIndex = 18;
      this.textBoxRound.Location = new Point(90, 120);
      this.textBoxRound.Name = "textBoxRound";
      this.textBoxRound.ReadOnly = true;
      this.textBoxRound.Size = new Size(35, 20);
      this.textBoxRound.TabIndex = 19;
      this.textBoxRandomSeed.Location = new Point(90, 142);
      this.textBoxRandomSeed.Name = "textBoxRandomSeed";
      this.textBoxRandomSeed.ReadOnly = true;
      this.textBoxRandomSeed.Size = new Size(119, 20);
      this.textBoxRandomSeed.TabIndex = 20;
      this.textBoxPath.Location = new Point(90, 164);
      this.textBoxPath.Name = "textBoxPath";
      this.textBoxPath.ReadOnly = true;
      this.textBoxPath.Size = new Size(332, 20);
      this.textBoxPath.TabIndex = 21;
      this.textBoxComment.Location = new Point(16, 205);
      this.textBoxComment.Multiline = true;
      this.textBoxComment.Name = "textBoxComment";
      this.textBoxComment.Size = new Size(406, 55);
      this.textBoxComment.TabIndex = 22;
      this.textBoxSaveVersion.Location = new Point(290, 10);
      this.textBoxSaveVersion.Name = "textBoxSaveVersion";
      this.textBoxSaveVersion.ReadOnly = true;
      this.textBoxSaveVersion.Size = new Size(132, 20);
      this.textBoxSaveVersion.TabIndex = 23;
      this.textBoxGameName.Location = new Point(290, 54);
      this.textBoxGameName.Name = "textBoxGameName";
      this.textBoxGameName.ReadOnly = true;
      this.textBoxGameName.Size = new Size(132, 20);
      this.textBoxGameName.TabIndex = 25;
      this.textBoxCreated.Location = new Point(290, 76);
      this.textBoxCreated.Name = "textBoxCreated";
      this.textBoxCreated.ReadOnly = true;
      this.textBoxCreated.Size = new Size(132, 20);
      this.textBoxCreated.TabIndex = 26;
      this.textBoxEstFrames.Location = new Point(290, 98);
      this.textBoxEstFrames.Name = "textBoxEstFrames";
      this.textBoxEstFrames.ReadOnly = true;
      this.textBoxEstFrames.Size = new Size(132, 20);
      this.textBoxEstFrames.TabIndex = 27;
      this.buttonSave.Location = new Point(266, 282);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new Size(75, 23);
      this.buttonSave.TabIndex = 28;
      this.buttonSave.Text = "Save";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new EventHandler(this.Save_OnClick);
      this.buttonCancel.DialogResult = DialogResult.Cancel;
      this.buttonCancel.Location = new Point(347, 282);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new Size(75, 23);
      this.buttonCancel.TabIndex = 29;
      this.buttonCancel.Text = "Cancel";
      this.buttonCancel.UseVisualStyleBackColor = true;
      this.buttonCancel.Click += new EventHandler(this.Cancel_OnClick);
      this.radioButtonMarkedYes.AutoSize = true;
      this.radioButtonMarkedYes.Location = new Point(290, 32);
      this.radioButtonMarkedYes.Name = "radioButtonMarkedYes";
      this.radioButtonMarkedYes.Size = new Size(43, 17);
      this.radioButtonMarkedYes.TabIndex = 30;
      this.radioButtonMarkedYes.TabStop = true;
      this.radioButtonMarkedYes.Text = "Yes";
      this.radioButtonMarkedYes.UseVisualStyleBackColor = true;
      this.radioButtonMarkedNo.AutoSize = true;
      this.radioButtonMarkedNo.Location = new Point(339, 32);
      this.radioButtonMarkedNo.Name = "radioButtonMarkedNo";
      this.radioButtonMarkedNo.Size = new Size(39, 17);
      this.radioButtonMarkedNo.TabIndex = 31;
      this.radioButtonMarkedNo.TabStop = true;
      this.radioButtonMarkedNo.Text = "No";
      this.radioButtonMarkedNo.UseVisualStyleBackColor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      ReplayDetailViewForm replayDetailViewForm1 = this;
      Button button = replayDetailViewForm1.buttonCancel;
      replayDetailViewForm1.CancelButton = (IButtonControl) button;
      this.ClientSize = new Size(434, 317);
      this.Controls.Add((Control) this.radioButtonMarkedNo);
      this.Controls.Add((Control) this.radioButtonMarkedYes);
      this.Controls.Add((Control) this.buttonCancel);
      this.Controls.Add((Control) this.buttonSave);
      this.Controls.Add((Control) this.textBoxEstFrames);
      this.Controls.Add((Control) this.textBoxCreated);
      this.Controls.Add((Control) this.textBoxGameName);
      this.Controls.Add((Control) this.textBoxSaveVersion);
      this.Controls.Add((Control) this.textBoxComment);
      this.Controls.Add((Control) this.textBoxPath);
      this.Controls.Add((Control) this.textBoxRandomSeed);
      this.Controls.Add((Control) this.textBoxRound);
      this.Controls.Add((Control) this.textBoxMaxStage);
      this.Controls.Add((Control) this.textBoxTimer);
      this.Controls.Add((Control) this.textBoxReplayType);
      this.Controls.Add((Control) this.textBoxP2Name);
      this.Controls.Add((Control) this.textBoxP1Name);
      this.Controls.Add((Control) this.label14);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ReplayDetailViewForm";
      this.Text = "Replay detail view";
      ReplayDetailViewForm replayDetailViewForm2 = this;
      // ISSUE: method pointer
      IntPtr method = __methodptr(ReplayDetailView_Load);
      EventHandler eventHandler = new EventHandler((object) replayDetailViewForm2, method);
      replayDetailViewForm2.Load += eventHandler;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void SendReplay(Replay rep)
    {
      this.the_replay = rep;
    }

    private void ReplayDetailView_Load(object sender, EventArgs e)
    {
      if (this.the_replay == null)
      {
        int num = (int) MessageBox.Show("Replay wasn't properly sent to viewer form", "Error");
        this.Close();
      }
      else if (!this.the_replay.StateOK())
      {
        int num = (int) MessageBox.Show(string.Format("File {0} is not a replay or corrupted.", (object) this.the_replay.m_FullFilepath), "Error");
        this.Close();
      }
      else
      {
        this.textBoxP1Name.Text = this.the_replay.m_P1Name;
        this.textBoxP2Name.Text = this.the_replay.m_P2Name;
        this.textBoxReplayType.Text = this.the_replay.IsCompressed();
        this.textBoxTimer.Text = this.the_replay.m_Timer.ToString();
        this.textBoxMaxStage.Text = this.the_replay.m_MaxStage.ToString();
        this.textBoxRound.Text = this.the_replay.m_Round.ToString();
        this.textBoxRandomSeed.Text = this.the_replay.m_RandSeed.ToString();
        this.textBoxPath.Text = this.the_replay.m_FullFilepath;
        this.textBoxCreated.Text = this.the_replay.m_CreationTime.ToString();
        this.textBoxEstFrames.Text = this.the_replay.EstimateFrames();
        if (!this.the_replay.m_HasSecondaryHeader)
          return;
        this.textBoxSaveVersion.Text = this.the_replay.m_SavedWithVersion;
        if (this.the_replay.m_Marked)
        {
          this.radioButtonMarkedYes.Checked = true;
          this.radioButtonMarkedNo.Checked = false;
        }
        else
        {
          this.radioButtonMarkedYes.Checked = false;
          this.radioButtonMarkedNo.Checked = true;
        }
        this.textBoxGameName.Text = this.the_replay.m_GameExeName;
        this.textBoxComment.Text = this.the_replay.m_Comment;
      }
    }

    private void Cancel_OnClick(object sender, EventArgs e)
    {
      this.Close();
    }

    private void Save_OnClick(object sender, EventArgs e)
    {
      this.the_replay.m_Marked = this.radioButtonMarkedYes.Checked;
      this.the_replay.m_Comment = this.textBoxComment.Text;
      this.the_replay.UpdateSecondaryHeaderInfo();
      this.the_replay.Save((string) null, true);
      this.Close();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.ReplayDetailViewForm();
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
