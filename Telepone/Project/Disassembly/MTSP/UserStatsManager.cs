// Type: MTSP.UserStatsManager
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MTSP
{
  public class UserStatsManager : Form
  {
    private Button buttonClose;
    private CustomListView StatsListView;
    private ColumnHeader colName;
    private ColumnHeader colVSTime;
    private ColumnHeader colPing;
    private ColumnHeader colJoins;
    private ColumnHeader colSighted;
    private ColumnHeader colIPEP;
    private Label label1;
    private Label label2;
    private Label RecordsAmount;
    private Label PlaytimeAmount;
    private Label label3;
    private Label LBL_TotalWinLoss;
    private Button button1;
    private ColumnHeader colWinLoss;
    private Container components;
    private ListViewColumnSorter lvwColumnSorter;
    private USER_RELATIONS RelationsRef;

    public UserStatsManager(USER_RELATIONS relations)
    {
      // ISSUE: fault handler
      try
      {
        this.InitializeComponent();
        this.RelationsRef = relations;
        this.LoadUserStats();
        this.lvwColumnSorter = (ListViewColumnSorter) new UserStatsColumnSorter();
        this.StatsListView.ListViewItemSorter = (IComparer) this.lvwColumnSorter;
      }
      __fault
      {
        base.Dispose(true);
      }
    }

    private void UserStatsManager()
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
      this.buttonClose = new Button();
      this.StatsListView = new CustomListView();
      this.colName = new ColumnHeader();
      this.colVSTime = new ColumnHeader();
      this.colPing = new ColumnHeader();
      this.colJoins = new ColumnHeader();
      this.colSighted = new ColumnHeader();
      this.colIPEP = new ColumnHeader();
      this.colWinLoss = new ColumnHeader();
      this.label1 = new Label();
      this.label2 = new Label();
      this.RecordsAmount = new Label();
      this.PlaytimeAmount = new Label();
      this.label3 = new Label();
      this.LBL_TotalWinLoss = new Label();
      this.button1 = new Button();
      this.SuspendLayout();
      this.buttonClose.DialogResult = DialogResult.Cancel;
      this.buttonClose.Location = new Point(696, 323);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new Size(100, 23);
      this.buttonClose.TabIndex = 1;
      this.buttonClose.Text = "Close";
      this.buttonClose.UseVisualStyleBackColor = true;
      this.StatsListView.Columns.AddRange(new ColumnHeader[7]
      {
        this.colName,
        this.colVSTime,
        this.colPing,
        this.colJoins,
        this.colSighted,
        this.colIPEP,
        this.colWinLoss
      });
      this.StatsListView.FullRowSelect = true;
      this.StatsListView.GridLines = true;
      this.StatsListView.HideSelection = false;
      this.StatsListView.Location = new Point(12, 78);
      this.StatsListView.MultiSelect = false;
      this.StatsListView.Name = "StatsListView";
      this.StatsListView.Size = new Size(784, 237);
      this.StatsListView.TabIndex = 2;
      this.StatsListView.UseCompatibleStateImageBehavior = false;
      this.StatsListView.View = View.Details;
      this.StatsListView.ColumnClick += new ColumnClickEventHandler(this.StatsListView_ColumnClick);
      this.StatsListView.KeyDown += new KeyEventHandler(this.StatsListView_KeyDown);
      this.StatsListView.KeyPress += new KeyPressEventHandler(this.StatsListView_KeyPress);
      this.StatsListView.MouseDoubleClick += new MouseEventHandler(this.StatsListView_MouseDoubleClick);
      this.colName.Tag = (object) "";
      this.colName.Text = "Name";
      this.colName.Width = 134;
      this.colVSTime.Tag = (object) "";
      this.colVSTime.Text = "VS Time";
      this.colVSTime.Width = 111;
      this.colPing.Text = "Ping";
      this.colPing.Width = 50;
      this.colJoins.Text = "Sightings";
      this.colJoins.Width = 63;
      this.colSighted.Text = "Sighted";
      this.colSighted.Width = 120;
      this.colIPEP.Text = "First address";
      this.colIPEP.Width = 144;
      this.colWinLoss.Text = "Win / Loss";
      this.colWinLoss.Width = 115;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(9, 19);
      this.label1.Name = "label1";
      this.label1.Size = new Size(50, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Records:";
      this.label2.AutoSize = true;
      this.label2.Location = new Point(9, 36);
      this.label2.Name = "label2";
      this.label2.Size = new Size(75, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Total playtime:";
      this.RecordsAmount.AutoSize = true;
      this.RecordsAmount.Location = new Point(90, 19);
      this.RecordsAmount.Name = "RecordsAmount";
      this.RecordsAmount.Size = new Size(13, 13);
      this.RecordsAmount.TabIndex = 6;
      this.RecordsAmount.Text = "?";
      this.PlaytimeAmount.AutoSize = true;
      this.PlaytimeAmount.Location = new Point(90, 36);
      this.PlaytimeAmount.Name = "PlaytimeAmount";
      this.PlaytimeAmount.Size = new Size(13, 13);
      this.PlaytimeAmount.TabIndex = 7;
      this.PlaytimeAmount.Text = "?";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(9, 53);
      this.label3.Name = "label3";
      this.label3.Size = new Size(65, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Total W / L:";
      this.LBL_TotalWinLoss.AutoSize = true;
      this.LBL_TotalWinLoss.Location = new Point(90, 53);
      this.LBL_TotalWinLoss.Name = "LBL_TotalWinLoss";
      this.LBL_TotalWinLoss.Size = new Size(13, 13);
      this.LBL_TotalWinLoss.TabIndex = 9;
      this.LBL_TotalWinLoss.Text = "?";
      this.button1.Location = new Point(13, 323);
      this.button1.Name = "button1";
      this.button1.Size = new Size(111, 23);
      this.button1.TabIndex = 10;
      this.button1.Text = "Prune records";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.PruneRecords);
      UserStatsManager userStatsManager1 = this;
      Button button1 = userStatsManager1.buttonClose;
      userStatsManager1.AcceptButton = (IButtonControl) button1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      UserStatsManager userStatsManager2 = this;
      Button button2 = userStatsManager2.buttonClose;
      userStatsManager2.CancelButton = (IButtonControl) button2;
      this.ClientSize = new Size(808, 358);
      this.ControlBox = false;
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.LBL_TotalWinLoss);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.PlaytimeAmount);
      this.Controls.Add((Control) this.RecordsAmount);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.StatsListView);
      this.Controls.Add((Control) this.buttonClose);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "UserStatsManager";
      this.ShowInTaskbar = false;
      this.Text = "Stats viewer";
      UserStatsManager userStatsManager3 = this;
      // ISSUE: method pointer
      IntPtr method = __methodptr(UserStatsManager_Load);
      EventHandler eventHandler = new EventHandler((object) userStatsManager3, method);
      userStatsManager3.Load += eventHandler;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void LoadUserStats()
    {
      string str1 = (string) null;
      if (this.RelationsRef == null)
        return;
      this.StatsListView.Items.Clear();
      if (Monitor.TryEnter((object) this.RelationsRef.UserStats, 5000))
      {
        try
        {
          this.StatsListView.BeginUpdate();
          string[] items = new string[7];
          str1 = "";
          ValueType span = (ValueType) new TimeSpan();
          int num1 = 0;
          ProgressWindow progressWindow = new ProgressWindow();
          progressWindow.Setup("Loading info...", 0, this.RelationsRef.UserStats.Count, 1, 1);
          ((Control) progressWindow).Show();
          Dictionary<string, USER_STATS>.Enumerator enumerator = this.RelationsRef.UserStats.GetEnumerator();
          while (enumerator.MoveNext())
          {
            KeyValuePair<string, USER_STATS> current = enumerator.Current;
            progressWindow.SetProgressText(string.Format("Loading {0}", (object) current.Key), false);
            USER_STATS userStats = current.Value;
            items[0] = current.Key;
            string str2 = new TimeSpan((long) userStats.VS_Time).ToString();
            items[1] = str2.Length <= 8 ? str2 : str2.Remove(8);
            if ((long) userStats.VS_Time != 0L)
            {
              TimeSpan ts = TimeSpan.FromTicks((long) userStats.VS_Time);
              span = (ValueType) ((TimeSpan) span).Add(ts);
            }
            uint num2 = userStats.AvgPing;
            items[2] = num2.ToString();
            uint num3 = userStats.Joins;
            items[3] = num3.ToString();
            DateTime dateTime = DateTime.FromBinary((long) userStats.FirstSeen);
            items[4] = dateTime.ToString();
            if (new IPAddress((long) userStats.FirstIP).ToString() == "0.0.0.0")
            {
              items[5] = "";
            }
            else
            {
              IPAddress ipAddress = new IPAddress((long) userStats.FirstIP);
              items[5] = ipAddress.ToString();
            }
            if ((int) userStats.WinLoss != -1)
            {
              uint num4 = userStats.WinLoss & (uint) ushort.MaxValue;
              uint num5 = userStats.WinLoss >> 16;
              items[6] = num5.ToString() + " / " + num4.ToString();
              num1 += (int) userStats.WinLoss;
            }
            this.StatsListView.Items.Add(new ListViewItem(items));
            progressWindow.Step();
          }
          progressWindow.Close();
          this.RecordsAmount.Text = this.StatsListView.Items.Count.ToString();
          this.PlaytimeAmount.Text = Module.FormatVSTime(span);
          int num6 = num1 & (int) ushort.MaxValue;
          this.LBL_TotalWinLoss.Text = (num1 >> 16).ToString() + " / " + num6.ToString();
        }
        finally
        {
          this.StatsListView.EndUpdate();
          Monitor.Exit((object) this.RelationsRef.UserStats);
        }
      }
      else
      {
        int num = (int) MessageBox.Show("Unable to load user stats for some reason", "error");
        this.Close();
      }
    }

    private void StatsListView_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      if (e.Column == this.lvwColumnSorter.SortColumn)
      {
        this.lvwColumnSorter.Order = this.lvwColumnSorter.Order != SortOrder.Ascending ? SortOrder.Ascending : SortOrder.Descending;
      }
      else
      {
        this.lvwColumnSorter.SortColumn = e.Column;
        this.lvwColumnSorter.Order = SortOrder.Ascending;
      }
      this.StatsListView.Sort();
    }

    private void StatsListView_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void StatsListView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (this.StatsListView.SelectedItems.Count != 1 || this.RelationsRef == null)
        return;
      USER_STATS stats = this.RelationsRef.GetStats(this.StatsListView.SelectedItems[0].SubItems[0].Text);
      if (stats == null)
        return;
      UserStatsEditorDlg userStatsEditorDlg = new UserStatsEditorDlg();
      userStatsEditorDlg.Init(stats);
      int num = (int) userStatsEditorDlg.ShowDialog((IWin32Window) this);
      this.StatsListView.SelectedItems[0].SubItems[2].Text = stats.AvgPing.ToString();
      this.StatsListView.SelectedItems[0].SubItems[5].Text = new IPAddress((long) stats.FirstIP).ToString();
      this.StatsListView.Invalidate();
    }

    private void UserStatsManager_Load(object sender, EventArgs e)
    {
    }

    private void StatsListView_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Delete || this.StatsListView.Items.Count == 0 || (this.StatsListView.SelectedItems.Count != 1 || this.RelationsRef == null))
        return;
      this.RelationsRef.RemoveStatRecord(this.StatsListView.SelectedItems[0].SubItems[0].Text);
      this.StatsListView.Items.Remove(this.StatsListView.SelectedItems[0]);
    }

    private void PruneRecords(object sender, EventArgs e)
    {
      if (!Monitor.TryEnter((object) this.RelationsRef.UserStats, 5000))
        return;
      try
      {
        if (MessageBox.Show("This will remove records with less than 5 sightings older than a month", "Prune records", MessageBoxButtons.YesNo) == DialogResult.No || this.RelationsRef == null)
          return;
        List<string> list = new List<string>((IEnumerable<string>) new List<string>());
        Dictionary<string, USER_STATS>.Enumerator enumerator1 = this.RelationsRef.UserStats.GetEnumerator();
        while (enumerator1.MoveNext())
        {
          USER_STATS userStats = enumerator1.Current.Value;
          if ((long) userStats.VS_Time == 0L)
          {
            DateTime dateTime = DateTime.FromBinary((long) userStats.FirstSeen);
            if (userStats.Joins <= 5U && (DateTime.Now - dateTime).Days > 30)
              list.Add(userStats.Name);
          }
        }
        List<string>.Enumerator enumerator2 = list.GetEnumerator();
        while (enumerator2.MoveNext())
          this.RelationsRef.UserStats.Remove(enumerator2.Current);
        this.LoadUserStats();
        this.RelationsRef.SaveAll();
      }
      finally
      {
        Monitor.Exit((object) this.RelationsRef.UserStats);
      }
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.UserStatsManager();
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
