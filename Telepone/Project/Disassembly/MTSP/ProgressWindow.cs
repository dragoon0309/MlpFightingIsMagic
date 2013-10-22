// Type: MTSP.ProgressWindow
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class ProgressWindow : Form
  {
    private ProgressBar progressBar1;
    private Label labelProgressText;
    private Container components;

    public ProgressWindow()
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

    private void ProgressWindow()
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
      this.progressBar1 = new ProgressBar();
      this.labelProgressText = new Label();
      this.SuspendLayout();
      this.progressBar1.Location = new Point(12, 46);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new Size(475, 23);
      this.progressBar1.TabIndex = 0;
      this.labelProgressText.AutoSize = true;
      this.labelProgressText.Location = new Point(12, 19);
      this.labelProgressText.Name = "labelProgressText";
      this.labelProgressText.Size = new Size(79, 13);
      this.labelProgressText.TabIndex = 1;
      this.labelProgressText.Text = "Getting ready...";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(500, 81);
      this.ControlBox = false;
      this.Controls.Add((Control) this.labelProgressText);
      this.Controls.Add((Control) this.progressBar1);
      this.Name = "ProgressWindow";
      this.Text = "Progress";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public void SetProgressText(string new_text, [MarshalAs(UnmanagedType.U1)] bool strip_path)
    {
      if (strip_path)
        new_text = Path.GetFileName(new_text);
      this.labelProgressText.Text = new_text;
      this.Refresh();
    }

    public void SetMinimumProgress(int min)
    {
      this.progressBar1.Minimum = min;
    }

    public void SetMaximumProgress(int max)
    {
      this.progressBar1.Maximum = max;
    }

    public void SetProgressValue(int val)
    {
      this.progressBar1.Value = val;
    }

    public void SetProgressStep(int step)
    {
      this.progressBar1.Step = step;
    }

    public void Setup(string progtext, int min, int max, int val, int step)
    {
      this.SetProgressText(progtext, false);
      this.SetMinimumProgress(min);
      this.SetMaximumProgress(max);
      this.SetProgressValue(val);
      this.SetProgressStep(step);
    }

    public void Step()
    {
      this.progressBar1.PerformStep();
      if (this.progressBar1.Value < this.progressBar1.Maximum)
        return;
      this.Close();
    }

    public ProgressBar GetProgressBarHandle()
    {
      return this.progressBar1;
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.ProgressWindow();
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
