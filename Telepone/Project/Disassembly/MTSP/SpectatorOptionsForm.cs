// Type: MTSP.SpectatorOptionsForm
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
  public class SpectatorOptionsForm : Form
  {
    private RadioButton RDBTN_FM2KType;
    private GroupBox groupBox1;
    private RadioButton RDBTN_FM95Type;
    private NumericUpDown NUD_BackupPacketCount;
    private Label label1;
    private Button BTN_OK;
    private CheckBox CHK_SpecWait;
    private NumericUpDown NUD_WaitForBehindSpecs;
    private Label label2;
    private ToolTip toolTip1;
    private IContainer components;

    public SpectatorOptionsForm()
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

    private void SpectatorOptionsForm()
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
      this.RDBTN_FM2KType = new RadioButton();
      this.groupBox1 = new GroupBox();
      this.RDBTN_FM95Type = new RadioButton();
      this.NUD_BackupPacketCount = new NumericUpDown();
      this.label1 = new Label();
      this.BTN_OK = new Button();
      this.CHK_SpecWait = new CheckBox();
      this.NUD_WaitForBehindSpecs = new NumericUpDown();
      this.label2 = new Label();
      SpectatorOptionsForm spectatorOptionsForm1 = this;
      ToolTip toolTip = new ToolTip(spectatorOptionsForm1.components);
      spectatorOptionsForm1.toolTip1 = toolTip;
      this.groupBox1.SuspendLayout();
      this.NUD_BackupPacketCount.BeginInit();
      this.NUD_WaitForBehindSpecs.BeginInit();
      this.SuspendLayout();
      this.RDBTN_FM2KType.AutoSize = true;
      this.RDBTN_FM2KType.Checked = true;
      this.RDBTN_FM2KType.Location = new Point(6, 19);
      this.RDBTN_FM2KType.Name = "RDBTN_FM2KType";
      this.RDBTN_FM2KType.Size = new Size(53, 17);
      this.RDBTN_FM2KType.TabIndex = 1;
      this.RDBTN_FM2KType.TabStop = true;
      this.RDBTN_FM2KType.Text = "FM2K";
      this.RDBTN_FM2KType.UseVisualStyleBackColor = true;
      this.groupBox1.Controls.Add((Control) this.RDBTN_FM95Type);
      this.groupBox1.Controls.Add((Control) this.RDBTN_FM2KType);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(181, 47);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Game type";
      this.RDBTN_FM95Type.AutoSize = true;
      this.RDBTN_FM95Type.Location = new Point(85, 18);
      this.RDBTN_FM95Type.Name = "RDBTN_FM95Type";
      this.RDBTN_FM95Type.Size = new Size(52, 17);
      this.RDBTN_FM95Type.TabIndex = 2;
      this.RDBTN_FM95Type.Text = "FM95";
      this.RDBTN_FM95Type.UseVisualStyleBackColor = true;
      this.NUD_BackupPacketCount.Location = new Point(147, 71);
      this.NUD_BackupPacketCount.Maximum = new Decimal(new int[4]
      {
        2,
        0,
        0,
        0
      });
      this.NUD_BackupPacketCount.Name = "NUD_BackupPacketCount";
      this.NUD_BackupPacketCount.Size = new Size(33, 20);
      this.NUD_BackupPacketCount.TabIndex = 3;
      this.NUD_BackupPacketCount.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.label1.AutoSize = true;
      this.label1.Location = new Point(15, 73);
      this.label1.Name = "label1";
      this.label1.Size = new Size(126, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Backup packets to send:";
      this.BTN_OK.Location = new Point(273, 152);
      this.BTN_OK.Name = "BTN_OK";
      this.BTN_OK.Size = new Size(75, 23);
      this.BTN_OK.TabIndex = 5;
      this.BTN_OK.Text = "Ok";
      this.BTN_OK.UseVisualStyleBackColor = true;
      this.BTN_OK.Click += new EventHandler(this.BTN_OK_Click);
      this.CHK_SpecWait.AutoSize = true;
      this.CHK_SpecWait.Location = new Point(18, 104);
      this.CHK_SpecWait.Name = "CHK_SpecWait";
      this.CHK_SpecWait.Size = new Size(154, 17);
      this.CHK_SpecWait.TabIndex = 6;
      this.CHK_SpecWait.Text = "Wait for spectators that are";
      this.toolTip1.SetToolTip((Control) this.CHK_SpecWait, "Warning: This will stop the game until all spectators have caught up");
      this.CHK_SpecWait.UseVisualStyleBackColor = true;
      this.NUD_WaitForBehindSpecs.Location = new Point(172, 103);
      this.NUD_WaitForBehindSpecs.Maximum = new Decimal(new int[4]
      {
        1500,
        0,
        0,
        0
      });
      this.NUD_WaitForBehindSpecs.Minimum = new Decimal(new int[4]
      {
        300,
        0,
        0,
        0
      });
      this.NUD_WaitForBehindSpecs.Name = "NUD_WaitForBehindSpecs";
      this.NUD_WaitForBehindSpecs.Size = new Size(45, 20);
      this.NUD_WaitForBehindSpecs.TabIndex = 7;
      this.NUD_WaitForBehindSpecs.Value = new Decimal(new int[4]
      {
        1200,
        0,
        0,
        0
      });
      this.label2.AutoSize = true;
      this.label2.Location = new Point(220, 106);
      this.label2.Name = "label2";
      this.label2.Size = new Size(73, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "frames behind";
      SpectatorOptionsForm spectatorOptionsForm2 = this;
      Button button = spectatorOptionsForm2.BTN_OK;
      spectatorOptionsForm2.AcceptButton = (IButtonControl) button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(360, 183);
      this.ControlBox = false;
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.NUD_WaitForBehindSpecs);
      this.Controls.Add((Control) this.CHK_SpecWait);
      this.Controls.Add((Control) this.BTN_OK);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.NUD_BackupPacketCount);
      this.Controls.Add((Control) this.groupBox1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SpectatorOptionsForm";
      this.ShowInTaskbar = false;
      this.Text = "Spectate options";
      SpectatorOptionsForm spectatorOptionsForm3 = this;
      // ISSUE: method pointer
      IntPtr method = __methodptr(SpectatorOptionsForm_Load);
      EventHandler eventHandler = new EventHandler((object) spectatorOptionsForm3, method);
      spectatorOptionsForm3.Load += eventHandler;
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.NUD_BackupPacketCount.EndInit();
      this.NUD_WaitForBehindSpecs.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private unsafe void SpectatorOptionsForm_Load(object sender, EventArgs e)
    {
      try
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        if ((int)  ((IntPtr) &Module.MTOPTION + 4041) != 0)
        {
          this.RDBTN_FM2KType.Checked = true;
          this.RDBTN_FM95Type.Checked = false;
        }
        else
        {
          this.RDBTN_FM2KType.Checked = false;
          this.RDBTN_FM95Type.Checked = true;
        }
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.NUD_BackupPacketCount.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 4068));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.NUD_WaitForBehindSpecs.Value = (Decimal) ((uint)  ((IntPtr) &Module.MTOPTION + 4072));
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
        this.CHK_SpecWait.Checked = (bool)  ((IntPtr) &Module.MTOPTION + 4044);
      }
      catch (Exception ex)
      {
        this.Close();
      }
    }

    private unsafe void BTN_OK_Click(object sender, EventArgs e)
    {
      if (this.RDBTN_FM95Type.Checked)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 4041) = (sbyte) 0;
      }
      else
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 4041) = (sbyte) 1;
      }
      Decimal num1 = this.NUD_BackupPacketCount.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4068) = (int) (uint) num1;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      if ((uint)  ((IntPtr) &Module.MTOPTION + 4068) > 3U)
      {
        // ISSUE: cast to a reference type
        // ISSUE: explicit reference operation
         ((IntPtr) &Module.MTOPTION + 4068) = 3;
      }
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4044) = (sbyte) this.CHK_SpecWait.Checked;
      Decimal num2 = this.NUD_WaitForBehindSpecs.Value;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
       ((IntPtr) &Module.MTOPTION + 4072) = (int) (uint) num2;
      this.Close();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.SpectatorOptionsForm();
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
