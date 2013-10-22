// Type: MTSP.UserStatsEditorDlg
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class UserStatsEditorDlg : Form
  {
    private Label label1;
    private TextBox NameEdit;
    private Label label2;
    private NumericUpDown PingEdit;
    private Label label3;
    private NumericUpDown IPEdit1;
    private NumericUpDown IPEdit2;
    private NumericUpDown IPEdit3;
    private NumericUpDown IPEdit4;
    private Button SaveExit;
    private Button Cancel;
    private Container components;
    private USER_STATS stats;

    public UserStatsEditorDlg()
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

    public void Init(USER_STATS _stats)
    {
      this.stats = _stats;
      this.NameEdit.Text = _stats.Name;
      this.PingEdit.Value = (Decimal) _stats.AvgPing;
      byte[] addressBytes = new IPAddress((long) _stats.FirstIP).GetAddressBytes();
      this.IPEdit1.Value = (Decimal) addressBytes[0];
      this.IPEdit2.Value = (Decimal) addressBytes[1];
      this.IPEdit3.Value = (Decimal) addressBytes[2];
      this.IPEdit4.Value = (Decimal) addressBytes[3];
    }

    private void UserStatsEditorDlg()
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
      this.NameEdit = new TextBox();
      this.label2 = new Label();
      this.PingEdit = new NumericUpDown();
      this.label3 = new Label();
      this.IPEdit1 = new NumericUpDown();
      this.IPEdit2 = new NumericUpDown();
      this.IPEdit3 = new NumericUpDown();
      this.IPEdit4 = new NumericUpDown();
      this.SaveExit = new Button();
      this.Cancel = new Button();
      this.PingEdit.BeginInit();
      this.IPEdit1.BeginInit();
      this.IPEdit2.BeginInit();
      this.IPEdit3.BeginInit();
      this.IPEdit4.BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(13, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      this.NameEdit.Location = new Point(69, 13);
      this.NameEdit.Name = "NameEdit";
      this.NameEdit.ReadOnly = true;
      this.NameEdit.Size = new Size(196, 20);
      this.NameEdit.TabIndex = 1;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(13, 45);
      this.label2.Name = "label2";
      this.label2.Size = new Size(31, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Ping:";
      this.PingEdit.Location = new Point(69, 42);
      this.PingEdit.Maximum = new Decimal(new int[4]
      {
        999,
        0,
        0,
        0
      });
      this.PingEdit.Name = "PingEdit";
      this.PingEdit.Size = new Size(47, 20);
      this.PingEdit.TabIndex = 3;
      this.label3.AutoSize = true;
      this.label3.Location = new Point(13, 73);
      this.label3.Name = "label3";
      this.label3.Size = new Size(20, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "IP:";
      this.IPEdit1.Location = new Point(69, 71);
      this.IPEdit1.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.IPEdit1.Name = "IPEdit1";
      this.IPEdit1.Size = new Size(47, 20);
      this.IPEdit1.TabIndex = 5;
      this.IPEdit2.Location = new Point(122, 72);
      this.IPEdit2.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.IPEdit2.Name = "IPEdit2";
      this.IPEdit2.Size = new Size(47, 20);
      this.IPEdit2.TabIndex = 6;
      this.IPEdit3.Location = new Point(175, 72);
      this.IPEdit3.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.IPEdit3.Name = "IPEdit3";
      this.IPEdit3.Size = new Size(47, 20);
      this.IPEdit3.TabIndex = 7;
      this.IPEdit4.Location = new Point(228, 72);
      this.IPEdit4.Maximum = new Decimal(new int[4]
      {
        (int) byte.MaxValue,
        0,
        0,
        0
      });
      this.IPEdit4.Name = "IPEdit4";
      this.IPEdit4.Size = new Size(47, 20);
      this.IPEdit4.TabIndex = 8;
      this.SaveExit.Location = new Point(141, 103);
      this.SaveExit.Name = "SaveExit";
      this.SaveExit.Size = new Size(92, 23);
      this.SaveExit.TabIndex = 9;
      this.SaveExit.Text = "Save && Exit";
      this.SaveExit.UseVisualStyleBackColor = true;
      this.SaveExit.Click += new EventHandler(this.SaveExit_Click);
      this.Cancel.DialogResult = DialogResult.Cancel;
      this.Cancel.Location = new Point(239, 103);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new Size(75, 23);
      this.Cancel.TabIndex = 10;
      this.Cancel.Text = "Cancel";
      this.Cancel.UseVisualStyleBackColor = true;
      this.Cancel.Click += new EventHandler(this.FormCancel);
      UserStatsEditorDlg userStatsEditorDlg1 = this;
      Button button1 = userStatsEditorDlg1.SaveExit;
      userStatsEditorDlg1.AcceptButton = (IButtonControl) button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      UserStatsEditorDlg userStatsEditorDlg2 = this;
      Button button2 = userStatsEditorDlg2.Cancel;
      userStatsEditorDlg2.CancelButton = (IButtonControl) button2;
      this.ClientSize = new Size(326, 138);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Cancel);
      this.Controls.Add((Control) this.SaveExit);
      this.Controls.Add((Control) this.IPEdit4);
      this.Controls.Add((Control) this.IPEdit3);
      this.Controls.Add((Control) this.IPEdit2);
      this.Controls.Add((Control) this.IPEdit1);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.PingEdit);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.NameEdit);
      this.Controls.Add((Control) this.label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserStatsEditorDlg";
      this.ShowIcon = false;
      this.Text = "Edit stats";
      this.PingEdit.EndInit();
      this.IPEdit1.EndInit();
      this.IPEdit2.EndInit();
      this.IPEdit3.EndInit();
      this.IPEdit4.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void FormCancel(object sender, EventArgs e)
    {
      this.Close();
    }

    private void SaveExit_Click(object sender, EventArgs e)
    {
      if (this.stats == null)
        return;
      this.stats.AvgPing = (uint) this.PingEdit.Value;
      byte[] numArray = new byte[4];
      Decimal num1 = this.IPEdit1.Value;
      numArray[0] = (byte) num1;
      Decimal num2 = this.IPEdit2.Value;
      numArray[1] = (byte) num2;
      Decimal num3 = this.IPEdit3.Value;
      numArray[2] = (byte) num3;
      Decimal num4 = this.IPEdit4.Value;
      numArray[3] = (byte) num4;
      this.stats.FirstIP = (uint) BitConverter.ToInt32(numArray, 0);
      this.Close();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.UserStatsEditorDlg();
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
