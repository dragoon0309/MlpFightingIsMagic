// Type: MTSP.GenericResultsWindow
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
  public class GenericResultsWindow : Form
  {
    private RichTextBox RTB;
    private Button BTN_Clear;
    private Button BTN_FreezeToggle;
    private Container components;
    private bool m_Frozen;

    public GenericResultsWindow()
    {
      // ISSUE: fault handler
      try
      {
        this.InitializeComponent();
        this.m_Frozen = false;
      }
      __fault
      {
        base.Dispose(true);
      }
    }

    private void GenericResultsWindow()
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
      this.RTB = new RichTextBox();
      this.BTN_Clear = new Button();
      this.BTN_FreezeToggle = new Button();
      this.SuspendLayout();
      this.RTB.Dock = DockStyle.Top;
      this.RTB.Location = new Point(0, 0);
      this.RTB.Name = "RTB";
      this.RTB.ReadOnly = true;
      this.RTB.Size = new Size(356, 241);
      this.RTB.TabIndex = 0;
      this.RTB.Text = "";
      this.RTB.WordWrap = false;
      this.BTN_Clear.Location = new Point(277, 242);
      this.BTN_Clear.Name = "BTN_Clear";
      this.BTN_Clear.Size = new Size(75, 23);
      this.BTN_Clear.TabIndex = 1;
      this.BTN_Clear.Text = "Clear";
      this.BTN_Clear.UseVisualStyleBackColor = true;
      this.BTN_Clear.Click += new EventHandler(this.Clear_Click);
      this.BTN_FreezeToggle.Location = new Point(196, 242);
      this.BTN_FreezeToggle.Name = "BTN_FreezeToggle";
      this.BTN_FreezeToggle.Size = new Size(75, 23);
      this.BTN_FreezeToggle.TabIndex = 2;
      this.BTN_FreezeToggle.Text = "Freeze";
      this.BTN_FreezeToggle.UseVisualStyleBackColor = true;
      this.BTN_FreezeToggle.Click += new EventHandler(this.BTN_FreezeToggle_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(356, 266);
      this.Controls.Add((Control) this.BTN_FreezeToggle);
      this.Controls.Add((Control) this.BTN_Clear);
      this.Controls.Add((Control) this.RTB);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "GenericResultsWindow";
      this.Text = "Results";
      GenericResultsWindow genericResultsWindow = this;
      // ISSUE: method pointer
      IntPtr method = __methodptr(GenericResultsWindow_FormClosing);
      FormClosingEventHandler closingEventHandler = new FormClosingEventHandler((object) genericResultsWindow, method);
      genericResultsWindow.FormClosing += closingEventHandler;
      this.ResumeLayout(false);
    }

    public void SetResults(string text)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke((Delegate) new StringDelegate(this.SetResults), new object[1]
        {
          (object) text
        });
      }
      else
      {
        if (this.m_Frozen)
          return;
        this.RTB.Text = text;
        this.Invalidate();
      }
    }

    public void Append(string text)
    {
      if (this.m_Frozen)
        return;
      this.RTB.AppendText(text);
    }

    private void Clear_Click(object sender, EventArgs e)
    {
      this.RTB.Clear();
    }

    private void BTN_FreezeToggle_Click(object sender, EventArgs e)
    {
      if (this.m_Frozen)
      {
        this.BTN_FreezeToggle.Text = "Freeze";
        this.m_Frozen = false;
      }
      else
      {
        this.BTN_FreezeToggle.Text = "Unfreeze";
        this.m_Frozen = true;
      }
    }

    private void GenericResultsWindow_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = true;
      this.Hide();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.GenericResultsWindow();
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
