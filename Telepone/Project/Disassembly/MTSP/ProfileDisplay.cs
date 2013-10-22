// Type: MTSP.ProfileDisplay
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MTSP
{
  public class ProfileDisplay : PictureBox
  {
    private static uint MaxExpandSpeed = 66U;
    private static uint MinExpandSpeed = 25U;
    private System.Windows.Forms.Timer timer1;
    private ContextMenuStrip profileContextMenu;
    private ToolStripMenuItem profileMenuItemCopyComment;
    private ToolStripMenuItem profileMenuItemOpenLink;
    private IContainer components;
    private Font statfon;
    private Font vsmallfon;
    private Font smallfon;
    private Font fon;
    private SolidBrush br;
    private SolidBrush blubr;
    private SolidBrush redbr;
    private SolidBrush yellobr;
    private SolidBrush greenbr;
    private SolidBrush pingbr;
    private Point PonyImageBase;
    private Point IPTextBase;
    private Point PlayerNameTextBase;
    private Point VsTimeTextBase;
    private Point RegionTextBase;
    private Point LookingForTextBase;
    private Point NotSeekingTextBase;
    private Point StatusTextBase;
    private Point CommentTextBase;
    private Point IDTextBase;
    private Point PingTextBase;
    private Point MiscTextBase;
    private Point IgnTextBase;
    private Point DecTextBase;
    private Point BanTextBase;
    private Point FrenTextBase;
    private uint MaxExpandR;
    private uint MaxExpandB;
    private uint CurExpandSpeed;
    private uint CurRectColor;
    private GFXLoader Gfx_Loader_Ref;
    private ProfileDisplay.PROFDISP_STATE display_state;
    private Bitmap PonyImage;
    private string PlayerName;
    private FAVORITE_PONY FavPony;
    private IPEndPoint IP_EP;
    private string VSTime;
    private PLAYER_REGION Region;
    private string LookingFor;
    private string NotLookingFor;
    private string PlayerStatus;
    private string Comment;
    private int AvgPing;
    private int PlayerID;
    private int Wins;
    private int Losses;
    private bool good_ip;
    private bool backing_storeIgnored;
    private bool backing_storeDeclined;
    private bool backing_storeBlacklisted;
    private bool backing_storeFriended;

    internal bool Friended
    {
      get
      {
        return this.backing_storeFriended;
      }
      set
      {
        this.backing_storeFriended = __set_formal;
      }
    }

    internal bool Blacklisted
    {
      get
      {
        return this.backing_storeBlacklisted;
      }
      set
      {
        this.backing_storeBlacklisted = __set_formal;
      }
    }

    internal bool Declined
    {
      get
      {
        return this.backing_storeDeclined;
      }
      set
      {
        this.backing_storeDeclined = __set_formal;
      }
    }

    internal bool Ignored
    {
      get
      {
        return this.backing_storeIgnored;
      }
      set
      {
        this.backing_storeIgnored = __set_formal;
      }
    }

    static ProfileDisplay()
    {
    }

    public ProfileDisplay()
    {
      // ISSUE: fault handler
      try
      {
        this.InitializeComponent();
        this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        this.UpdateStyles();
        this.MaxExpandR = 0U;
        this.MaxExpandB = 0U;
        this.CurExpandSpeed = ProfileDisplay.MaxExpandSpeed;
        this.Height = 0;
        this.Width = 0;
        this.CurRectColor = uint.MaxValue;
        this.Visible = false;
        this.display_state = ProfileDisplay.PROFDISP_STATE.OFF;
        this.PonyImageBase = new Point(64, 15);
        this.IPTextBase = new Point(164, 16);
        this.IDTextBase = new Point(280, 16);
        this.PlayerNameTextBase = new Point(159, 35);
        this.VsTimeTextBase = new Point(45, 90);
        this.RegionTextBase = new Point(310, 89);
        this.LookingForTextBase = new Point(45, 124);
        this.PingTextBase = new Point(311, 124);
        this.NotSeekingTextBase = new Point(45, 159);
        this.StatusTextBase = new Point(45, 191);
        this.CommentTextBase = new Point(45, 224);
        this.MiscTextBase = new Point(350, 276);
        this.IgnTextBase = new Point(330, 4);
        this.DecTextBase = new Point(360, 4);
        this.BanTextBase = new Point(390, 4);
        this.FrenTextBase = new Point(420, 4);
        this.Gfx_Loader_Ref = (GFXLoader) null;
        this.PlayerName = string.Empty;
        this.Comment = string.Empty;
        this.LookingFor = string.Empty;
        this.NotLookingFor = string.Empty;
        this.VSTime = string.Empty;
        this.PlayerStatus = string.Empty;
        this.AvgPing = 0;
        this.Ignored = false;
        this.Declined = false;
        this.Blacklisted = false;
        this.Friended = false;
        this.good_ip = true;
        this.PlayerID = 0;
        this.IP_EP = new IPEndPoint(0L, 0);
        this.Region = PLAYER_REGION.NODATA;
        this.Wins = 0;
        this.Losses = 0;
        this.statfon = new Font("Arial", 9f, FontStyle.Bold | FontStyle.Italic);
        this.vsmallfon = new Font("Arial", 7f);
        this.smallfon = new Font("Arial", 10f);
        this.fon = new Font("Arial", 12f);
        this.br = new SolidBrush(Color.Black);
        this.blubr = new SolidBrush(Color.Blue);
        this.redbr = new SolidBrush(Color.Red);
        this.yellobr = new SolidBrush(Color.Goldenrod);
        this.greenbr = new SolidBrush(Color.Green);
        ProfileDisplay profileDisplay1 = this;
        SolidBrush solidBrush = profileDisplay1.br;
        profileDisplay1.pingbr = solidBrush;
        ProfileDisplay profileDisplay2 = this;
        ContextMenuStrip contextMenuStrip = profileDisplay2.profileContextMenu;
        profileDisplay2.ContextMenuStrip = contextMenuStrip;
      }
      __fault
      {
        base.Dispose(true);
      }
    }

    private void ProfileDisplay()
    {
      if (this.components != null)
      {
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
      IDisposable disposable1 = (IDisposable) this.statfon;
      int num1;
      if (disposable1 != null)
      {
        disposable1.Dispose();
        num1 = 0;
      }
      else
        num1 = 0;
      IDisposable disposable2 = (IDisposable) this.vsmallfon;
      int num2;
      if (disposable2 != null)
      {
        disposable2.Dispose();
        num2 = 0;
      }
      else
        num2 = 0;
      IDisposable disposable3 = (IDisposable) this.smallfon;
      int num3;
      if (disposable3 != null)
      {
        disposable3.Dispose();
        num3 = 0;
      }
      else
        num3 = 0;
      IDisposable disposable4 = (IDisposable) this.fon;
      int num4;
      if (disposable4 != null)
      {
        disposable4.Dispose();
        num4 = 0;
      }
      else
        num4 = 0;
      IDisposable disposable5 = (IDisposable) this.br;
      int num5;
      if (disposable5 != null)
      {
        disposable5.Dispose();
        num5 = 0;
      }
      else
        num5 = 0;
      IDisposable disposable6 = (IDisposable) this.greenbr;
      int num6;
      if (disposable6 != null)
      {
        disposable6.Dispose();
        num6 = 0;
      }
      else
        num6 = 0;
      IDisposable disposable7 = (IDisposable) this.blubr;
      int num7;
      if (disposable7 != null)
      {
        disposable7.Dispose();
        num7 = 0;
      }
      else
        num7 = 0;
      IDisposable disposable8 = (IDisposable) this.yellobr;
      int num8;
      if (disposable8 != null)
      {
        disposable8.Dispose();
        num8 = 0;
      }
      else
        num8 = 0;
      IDisposable disposable9 = (IDisposable) this.redbr;
      int num9;
      if (disposable9 != null)
      {
        disposable9.Dispose();
        num9 = 0;
      }
      else
        num9 = 0;
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ProfileDisplay));
      ProfileDisplay profileDisplay1 = this;
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(profileDisplay1.components);
      profileDisplay1.timer1 = timer;
      ProfileDisplay profileDisplay2 = this;
      ContextMenuStrip contextMenuStrip = new ContextMenuStrip(profileDisplay2.components);
      profileDisplay2.profileContextMenu = contextMenuStrip;
      this.profileMenuItemCopyComment = new ToolStripMenuItem();
      this.profileMenuItemOpenLink = new ToolStripMenuItem();
      this.profileContextMenu.SuspendLayout();
      this.BeginInit();
      this.SuspendLayout();
      this.timer1.Enabled = true;
      this.timer1.Interval = 15;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.profileContextMenu.Items.AddRange(new ToolStripItem[2]
      {
        (ToolStripItem) this.profileMenuItemCopyComment,
        (ToolStripItem) this.profileMenuItemOpenLink
      });
      this.profileContextMenu.Name = "profileContextMenu";
      this.profileContextMenu.Size = new Size(177, 48);
      this.profileContextMenu.Opening += new CancelEventHandler(this.profileContextMenu_Opening);
      this.profileMenuItemCopyComment.Name = "profileMenuItemCopyComment";
      this.profileMenuItemCopyComment.Size = new Size(176, 22);
      this.profileMenuItemCopyComment.Text = "Copy comment";
      this.profileMenuItemCopyComment.Click += new EventHandler(this.profileMenuItemCopyComment_Click);
      this.profileMenuItemOpenLink.Name = "profileMenuItemOpenLink";
      this.profileMenuItemOpenLink.Size = new Size(176, 22);
      this.profileMenuItemOpenLink.Text = "Open comment link...";
      this.profileMenuItemOpenLink.Click += new EventHandler(this.profileMenuItemOpenLink_Click);
      this.Image = (Image) componentResourceManager.GetObject("$this.Image");
      this.Size = new Size(476, 314);
      ProfileDisplay profileDisplay3 = this;
      // ISSUE: method pointer
      IntPtr method1 = __methodptr(ProfileDisplay_Load);
      EventHandler eventHandler = new EventHandler((object) profileDisplay3, method1);
      profileDisplay3.DoubleClick += eventHandler;
      ProfileDisplay profileDisplay4 = this;
      // ISSUE: method pointer
      IntPtr method2 = __methodptr(ProfileDisplay_MouseClick);
      MouseEventHandler mouseEventHandler = new MouseEventHandler((object) profileDisplay4, method2);
      profileDisplay4.MouseClick += mouseEventHandler;
      this.profileContextMenu.ResumeLayout(false);
      this.EndInit();
      this.ResumeLayout(false);
    }

    public void SetProfileFields(FAVORITE_PONY favpon, IPEndPoint IP_EP, string name, string time_played, PLAYER_REGION region, string looking_for, string not_looking_for, string comment)
    {
    }

    public void SetName(string name)
    {
      this.PlayerName = name;
    }

    public void SetIP(IPEndPoint IP_EP, [MarshalAs(UnmanagedType.U1)] bool good_ip)
    {
      this.IP_EP = IP_EP;
      if ((int) Module.IPToInt32(IP_EP) == 0)
        this.good_ip = true;
      else
        this.good_ip = good_ip;
    }

    public void SetVSTime(string vs_time)
    {
      this.VSTime = vs_time;
    }

    public void SetRegion(PLAYER_REGION region)
    {
      this.Region = region;
    }

    public void SetLookingFor(string looking)
    {
      this.LookingFor = looking;
    }

    public void SetNotLookingFor(string notlooking)
    {
      this.NotLookingFor = notlooking;
    }

    public void SetStatus([MarshalAs(UnmanagedType.U1)] bool ign, [MarshalAs(UnmanagedType.U1)] bool dec, [MarshalAs(UnmanagedType.U1)] bool black, [MarshalAs(UnmanagedType.U1)] bool fren)
    {
      this.Ignored = ign;
      this.Declined = dec;
      this.Blacklisted = black;
      this.Friended = fren;
    }

    public void SetComment(string comment)
    {
      this.Comment = comment;
    }

    public void SetFavPon(FAVORITE_PONY favpon)
    {
      this.FavPony = favpon;
      if (this.Gfx_Loader_Ref == null || !this.Gfx_Loader_Ref.loaded)
        return;
      ProfileDisplay profileDisplay = this;
      Bitmap favPonyImage = profileDisplay.Gfx_Loader_Ref.GetFavPonyImage(favpon);
      profileDisplay.PonyImage = favPonyImage;
    }

    public void SetID(int id)
    {
      this.PlayerID = id;
    }

    public void SetAvgPing(int ping)
    {
      this.AvgPing = ping;
      if (ping <= 80)
      {
        ProfileDisplay profileDisplay = this;
        SolidBrush solidBrush = profileDisplay.greenbr;
        profileDisplay.pingbr = solidBrush;
      }
      else if (ping <= 150)
      {
        ProfileDisplay profileDisplay = this;
        SolidBrush solidBrush = profileDisplay.blubr;
        profileDisplay.pingbr = solidBrush;
      }
      else if (ping <= 210)
      {
        ProfileDisplay profileDisplay = this;
        SolidBrush solidBrush = profileDisplay.yellobr;
        profileDisplay.pingbr = solidBrush;
      }
      else
      {
        ProfileDisplay profileDisplay = this;
        SolidBrush solidBrush = profileDisplay.redbr;
        profileDisplay.pingbr = solidBrush;
      }
    }

    public void SetGFXLoaderRef(GFXLoader loader)
    {
      if (this.Gfx_Loader_Ref != null)
        return;
      this.Gfx_Loader_Ref = loader;
    }

    public void SetImage(Bitmap newimg)
    {
      try
      {
        this.Image = (Image) newimg;
      }
      catch (Exception ex)
      {
        newimg = (Bitmap) null;
      }
    }

    public void SetWinLoss(int wins, int losses)
    {
      if (wins == -1)
      {
        this.Wins = 0;
        this.Losses = 0;
      }
      else
      {
        this.Wins = wins;
        this.Losses = losses;
      }
    }

    public void Activate()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke((Delegate) new NoArgsDelegate(this.Activate));
      }
      else
      {
        switch (this.display_state)
        {
          case ProfileDisplay.PROFDISP_STATE.INVALID:
          case ProfileDisplay.PROFDISP_STATE.OFF:
            this.display_state = ProfileDisplay.PROFDISP_STATE.EXPANDING;
            break;
          case ProfileDisplay.PROFDISP_STATE.FLASHING:
            this.display_state = ProfileDisplay.PROFDISP_STATE.DIMMING;
            break;
          case ProfileDisplay.PROFDISP_STATE.CONTRACTING:
            this.display_state = ProfileDisplay.PROFDISP_STATE.EXPANDING;
            break;
        }
      }
    }

    public void Deactivate()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke((Delegate) new NoArgsDelegate(this.Deactivate));
      }
      else
      {
        switch (this.display_state)
        {
          case ProfileDisplay.PROFDISP_STATE.EXPANDING:
            this.display_state = ProfileDisplay.PROFDISP_STATE.CONTRACTING;
            break;
          case ProfileDisplay.PROFDISP_STATE.OPEN:
            this.display_state = ProfileDisplay.PROFDISP_STATE.FLASHING;
            break;
        }
      }
    }

    public new void Update()
    {
      if (this.InvokeRequired)
        this.BeginInvoke((Delegate) new NoArgsDelegate(this.Update));
      else
        this.Invalidate();
    }

    public void AdjustExpandSpeed(uint adjust)
    {
      this.CurExpandSpeed += adjust;
      uint num1;
      if (this.CurExpandSpeed < ProfileDisplay.MinExpandSpeed)
      {
        this.CurExpandSpeed = ProfileDisplay.MinExpandSpeed;
        num1 = ProfileDisplay.MinExpandSpeed;
      }
      else
        num1 = 0U;
      uint num2;
      if (this.CurExpandSpeed > ProfileDisplay.MaxExpandSpeed)
      {
        this.CurExpandSpeed = ProfileDisplay.MaxExpandSpeed;
        num2 = ProfileDisplay.MaxExpandSpeed;
      }
      else
        num2 = 0U;
    }

    public void CapSize()
    {
      if (this.Image == null)
        return;
      uint num1;
      if ((int) this.MaxExpandR < 0)
      {
        this.MaxExpandR = 0U;
        num1 = 0U;
      }
      else
        num1 = 0U;
      uint num2;
      if ((int) this.MaxExpandB < 0)
      {
        this.MaxExpandB = 0U;
        num2 = 0U;
      }
      else
        num2 = 0U;
      if (this.Width < 0)
        this.Width = 0;
      if (this.Height < 0)
        this.Height = 0;
      uint num3;
      if (this.MaxExpandR > (uint) this.Image.Width)
      {
        int width = this.Image.Width;
        this.MaxExpandR = (uint) width;
        num3 = (uint) width;
      }
      else
        num3 = 0U;
      uint num4;
      if (this.MaxExpandB > (uint) this.Image.Height)
      {
        int height = this.Image.Height;
        this.MaxExpandB = (uint) height;
        num4 = (uint) height;
      }
      else
        num4 = 0U;
      if (this.Width > this.Image.Width)
      {
        ProfileDisplay profileDisplay = this;
        int width = profileDisplay.Image.Width;
        profileDisplay.Width = width;
      }
      if (this.Height <= this.Image.Height)
        return;
      ProfileDisplay profileDisplay1 = this;
      int height1 = profileDisplay1.Image.Height;
      profileDisplay1.Height = height1;
    }

    public void DrawProfileMembers(PaintEventArgs e)
    {
      if (this.Ignored)
        e.Graphics.DrawString("IGN", this.statfon, (Brush) this.redbr, (float) this.IgnTextBase.X, (float) this.IgnTextBase.Y);
      if (this.Declined)
        e.Graphics.DrawString("DEC", this.statfon, (Brush) this.redbr, (float) this.DecTextBase.X, (float) this.IgnTextBase.Y);
      if (this.Blacklisted)
        e.Graphics.DrawString("BAN", this.statfon, (Brush) this.redbr, (float) this.BanTextBase.X, (float) this.IgnTextBase.Y);
      if (this.good_ip)
        e.Graphics.DrawString(" (" + (object) this.IP_EP.Address + ")", this.smallfon, (Brush) this.br, (float) this.IPTextBase.X, (float) this.IPTextBase.Y);
      else
        e.Graphics.DrawString(" (" + (object) this.IP_EP.Address + ")", this.smallfon, (Brush) this.redbr, (float) this.IPTextBase.X, (float) this.IPTextBase.Y);
      e.Graphics.DrawString("ID: " + (object) this.PlayerID, this.smallfon, (Brush) this.br, (float) this.IDTextBase.X, (float) this.IDTextBase.Y);
      e.Graphics.DrawString(this.PlayerName, this.fon, (Brush) this.blubr, (float) this.PlayerNameTextBase.X, (float) this.PlayerNameTextBase.Y);
      e.Graphics.DrawString(this.VSTime, this.fon, (Brush) this.br, (float) this.VsTimeTextBase.X, (float) this.VsTimeTextBase.Y);
      e.Graphics.DrawString("Area: " + Module.GetRegionalString(this.Region), this.smallfon, (Brush) this.br, (float) this.RegionTextBase.X, (float) this.RegionTextBase.Y);
      e.Graphics.DrawString("Ping: ", this.smallfon, (Brush) this.br, (float) this.PingTextBase.X, (float) this.PingTextBase.Y);
      if (this.AvgPing == -1 || this.AvgPing == 0)
      {
        e.Graphics.DrawString("no data", this.smallfon, (Brush) this.br, (float) this.PingTextBase.X + 34f, (float) this.PingTextBase.Y);
      }
      else
      {
        int num = this.AvgPing;
        e.Graphics.DrawString(num.ToString() + "ms", this.smallfon, (Brush) this.pingbr, (float) this.PingTextBase.X + 34f, (float) this.PingTextBase.Y);
      }
      e.Graphics.DrawString("Seeking : " + this.LookingFor, this.fon, (Brush) this.br, (float) this.StatusTextBase.X, (float) this.StatusTextBase.Y);
      e.Graphics.DrawString("Avoiding : " + this.NotLookingFor, this.fon, (Brush) this.br, (float) this.CommentTextBase.X, (float) this.CommentTextBase.Y);
      e.Graphics.DrawString("Win / Loss: " + (object) this.Wins + " / " + (object) this.Losses, this.fon, (Brush) this.br, (float) this.LookingForTextBase.X, (float) this.LookingForTextBase.Y);
      if (this.Comment.Length > 53)
        e.Graphics.DrawString(this.Comment, this.vsmallfon, (Brush) this.br, (float) this.NotSeekingTextBase.X, (float) this.NotSeekingTextBase.Y);
      else
        e.Graphics.DrawString(this.Comment, this.smallfon, (Brush) this.br, (float) this.NotSeekingTextBase.X, (float) this.NotSeekingTextBase.Y);
      if (this.Gfx_Loader_Ref == null || !this.Gfx_Loader_Ref.loaded)
        return;
      Bitmap ponyProfilePic = this.Gfx_Loader_Ref.GetPonyProfilePic(this.FavPony);
      if (ponyProfilePic == null)
        return;
      e.Graphics.DrawImage((Image) ponyProfilePic, this.PonyImageBase.X, this.PonyImageBase.Y, ponyProfilePic.Width, ponyProfilePic.Height);
    }

    public void HideProfile()
    {
      this.Deactivate();
    }

    private void ProfileDisplay_Load(object sender, EventArgs e)
    {
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      switch (this.display_state)
      {
        case ProfileDisplay.PROFDISP_STATE.INVALID:
        case ProfileDisplay.PROFDISP_STATE.OFF:
          this.Visible = false;
          break;
        case ProfileDisplay.PROFDISP_STATE.EXPANDING:
        case ProfileDisplay.PROFDISP_STATE.CONTRACTING:
          Color color1 = Color.FromArgb(-1);
          e.Graphics.Clear(color1);
          this.Visible = true;
          if (this.Image != null)
          {
            Point location = this.Location;
            e.Graphics.DrawImage(this.Image, location);
          }
          this.DrawProfileMembers(e);
          this.CurRectColor = uint.MaxValue;
          SolidBrush solidBrush1 = new SolidBrush(Color.FromArgb((int) this.CurRectColor));
          e.Graphics.FillRectangle((Brush) solidBrush1, 0, 0, this.Width, this.Height);
          IDisposable disposable1 = (IDisposable) solidBrush1;
          int num1;
          if (disposable1 != null)
          {
            disposable1.Dispose();
            num1 = 0;
            break;
          }
          else
          {
            num1 = 0;
            break;
          }
        case ProfileDisplay.PROFDISP_STATE.DIMMING:
        case ProfileDisplay.PROFDISP_STATE.FLASHING:
          Color color2 = Color.FromArgb(-1);
          e.Graphics.Clear(color2);
          this.Visible = true;
          if (this.Image != null)
          {
            Point location = this.Location;
            e.Graphics.DrawImage(this.Image, location);
          }
          this.DrawProfileMembers(e);
          SolidBrush solidBrush2 = new SolidBrush(Color.FromArgb((int) this.CurRectColor));
          e.Graphics.FillRectangle((Brush) solidBrush2, 0, 0, this.Width, this.Height);
          IDisposable disposable2 = (IDisposable) solidBrush2;
          int num2;
          if (disposable2 != null)
          {
            disposable2.Dispose();
            num2 = 0;
            break;
          }
          else
          {
            num2 = 0;
            break;
          }
        case ProfileDisplay.PROFDISP_STATE.OPEN:
          this.Visible = true;
          if (this.Image != null)
          {
            Point location = this.Location;
            e.Graphics.DrawImage(this.Image, location);
          }
          this.DrawProfileMembers(e);
          break;
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      switch (this.display_state)
      {
        case ProfileDisplay.PROFDISP_STATE.INVALID:
        case ProfileDisplay.PROFDISP_STATE.OFF:
          this.timer1.Interval = 150;
          this.Visible = false;
          this.MaxExpandR = 0U;
          this.Width = 0;
          this.MaxExpandB = 0U;
          this.Height = 0;
          break;
        case ProfileDisplay.PROFDISP_STATE.EXPANDING:
          if (this.Image != null)
          {
            this.timer1.Interval = 15;
            this.Visible = true;
            this.MaxExpandR += this.CurExpandSpeed;
            ProfileDisplay profileDisplay1 = this;
            int num1 = (int) profileDisplay1.MaxExpandR;
            profileDisplay1.Width = num1;
            this.MaxExpandB += this.CurExpandSpeed;
            ProfileDisplay profileDisplay2 = this;
            int num2 = (int) profileDisplay2.MaxExpandB;
            profileDisplay2.Height = num2;
            this.CapSize();
            if (this.MaxExpandR >= (uint) this.Image.Width && this.MaxExpandR >= (uint) this.Image.Height)
              this.display_state = ProfileDisplay.PROFDISP_STATE.DIMMING;
            this.AdjustExpandSpeed(4294967293U);
            this.Invalidate();
            break;
          }
          else
            break;
        case ProfileDisplay.PROFDISP_STATE.DIMMING:
          this.timer1.Interval = 15;
          this.Visible = true;
          uint num3 = this.CurRectColor;
          this.CurRectColor -= 285212672U;
          if (this.CurRectColor > num3)
          {
            this.CurExpandSpeed = ProfileDisplay.MaxExpandSpeed;
            this.CurRectColor = 16777215U;
            this.display_state = ProfileDisplay.PROFDISP_STATE.OPEN;
          }
          this.Invalidate();
          break;
        case ProfileDisplay.PROFDISP_STATE.FLASHING:
          this.timer1.Interval = 15;
          this.Visible = true;
          uint num4 = this.CurRectColor;
          this.CurRectColor += 570425344U;
          if (this.CurRectColor < num4)
          {
            this.CurExpandSpeed = ProfileDisplay.MaxExpandSpeed;
            this.CurRectColor = uint.MaxValue;
            this.display_state = ProfileDisplay.PROFDISP_STATE.CONTRACTING;
          }
          this.Invalidate();
          break;
        case ProfileDisplay.PROFDISP_STATE.CONTRACTING:
          if (this.Image != null)
          {
            this.timer1.Interval = 15;
            this.Visible = true;
            this.MaxExpandR -= this.CurExpandSpeed;
            ProfileDisplay profileDisplay1 = this;
            int num1 = (int) profileDisplay1.MaxExpandR;
            profileDisplay1.Width = num1;
            this.MaxExpandB -= this.CurExpandSpeed;
            ProfileDisplay profileDisplay2 = this;
            int num2 = (int) profileDisplay2.MaxExpandB;
            profileDisplay2.Height = num2;
            this.CapSize();
            if (this.MaxExpandR <= 0U && this.MaxExpandB <= 0U)
              this.display_state = ProfileDisplay.PROFDISP_STATE.OFF;
            this.AdjustExpandSpeed(4294967293U);
            this.Invalidate();
            break;
          }
          else
            break;
        default:
          this.timer1.Interval = 100;
          break;
      }
      this.CapSize();
    }

    private void ProfileDisplay_MouseClick(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Middle)
      {
        this.ProfDisp_FastClose((object) null, (EventArgs) null);
      }
      else
      {
        if (e.Button != MouseButtons.Left)
          return;
        this.timer1.Interval = 15;
        this.Deactivate();
      }
    }

    private void profileContextMenu_Opening(object sender, CancelEventArgs e)
    {
      if (this.Comment.Length <= 0)
      {
        this.profileMenuItemCopyComment.Enabled = false;
        this.profileMenuItemOpenLink.Enabled = false;
      }
      else
      {
        this.profileMenuItemCopyComment.Enabled = true;
        this.profileMenuItemOpenLink.Enabled = true;
      }
    }

    private void profileMenuItemCopyComment_Click(object sender, EventArgs e)
    {
      Clipboard.SetDataObject((object) this.Comment, true);
    }

    private void profileMenuItemOpenLink_Click(object sender, EventArgs e)
    {
      string urlInString = Module.FindUrlInString(this.Comment);
      if (!(urlInString != string.Empty))
        return;
      Process.Start(urlInString);
    }

    private void ProfDisp_FastClose(object sender, EventArgs e)
    {
      this.display_state = ProfileDisplay.PROFDISP_STATE.OFF;
      this.CurExpandSpeed = ProfileDisplay.MaxExpandSpeed;
      this.MaxExpandR = 0U;
      this.MaxExpandB = 0U;
      this.Width = 0;
      this.Height = 0;
      this.Visible = false;
      this.timer1.Interval = 1000;
      this.Invalidate();
    }

    [HandleProcessCorruptedStateExceptions]
    protected override void Dispose([MarshalAs(UnmanagedType.U1)] bool _param1)
    {
      if (param0)
      {
        try
        {
          this.ProfileDisplay();
        }
        finally
        {
          base.Dispose(true);
        }
      }
      else
        base.Dispose(false);
    }

    private enum PROFDISP_STATE
    {
      INVALID,
      OFF,
      EXPANDING,
      DIMMING,
      OPEN,
      FLASHING,
      CONTRACTING,
    }
  }
}
