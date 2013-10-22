// Type: GFXLoader
// Assembly: Telepone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F2D09375-1D39-4599-BC5F-6F2C9D33ED80
// Assembly location: C:\Users\Tux\Documents\Dev\Projects\FightingIsMagic\Build\Clean Release\multiplayer\TeleponeCopie.exe

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class GFXLoader
{
  public readonly Dictionary<string, Bitmap> GFXDict = new Dictionary<string, Bitmap>();
  public bool loaded;

  public unsafe void Init()
  {
    try
    {
      this.loaded = false;
      this.GFXDict.Clear();
      string str = new string((char*) &Module.MTOPTION);
      this.GFXDict.Add("GFX-Unknown", new Bitmap(str + "\\rsrc\\unknown.png"));
      this.GFXDict.Add("GFX-none", new Bitmap(str + "\\rsrc\\emptyimage.png"));
      this.GFXDict.Add("GFX-FAV-AJ", new Bitmap(str + "\\rsrc\\FAV-AJ.png"));
      this.GFXDict.Add("GFX-FAV-PP", new Bitmap(str + "\\rsrc\\FAV-PP.png"));
      this.GFXDict.Add("GFX-FAV-RY", new Bitmap(str + "\\rsrc\\FAV-RY.png"));
      this.GFXDict.Add("GFX-FAV-TS", new Bitmap(str + "\\rsrc\\FAV-TS.png"));
      this.GFXDict.Add("GFX-FAV-FS", new Bitmap(str + "\\rsrc\\FAV-FS.png"));
      this.GFXDict.Add("GFX-FAV-RD", new Bitmap(str + "\\rsrc\\FAV-RD.png"));
      this.GFXDict.Add("GFX-MARK-AJ", new Bitmap(str + "\\rsrc\\AJ-mark.png"));
      this.GFXDict.Add("GFX-MARK-PP", new Bitmap(str + "\\rsrc\\PP-mark.png"));
      this.GFXDict.Add("GFX-MARK-RY", new Bitmap(str + "\\rsrc\\RY-mark.png"));
      this.GFXDict.Add("GFX-MARK-TS", new Bitmap(str + "\\rsrc\\TS-mark.png"));
      this.GFXDict.Add("GFX-MARK-FS", new Bitmap(str + "\\rsrc\\FS-mark.png"));
      this.GFXDict.Add("GFX-MARK-RD", new Bitmap(str + "\\rsrc\\RD-mark.png"));
      this.GFXDict.Add("GFX-STATEBG-REST", new Bitmap(str + "\\rsrc\\default-resting.png"));
      this.GFXDict.Add("PROFILE-BG", new Bitmap(str + "\\rsrc\\ProfileBG.png"));
      this.GFXDict.Add("AJ_PROF-MED", new Bitmap(str + "\\rsrc\\AJProfMed.png"));
      this.GFXDict.Add("PP_PROF-MED", new Bitmap(str + "\\rsrc\\PPProfMed.png"));
      this.GFXDict.Add("RY_PROF-MED", new Bitmap(str + "\\rsrc\\RYProfMed.png"));
      this.GFXDict.Add("TS_PROF-MED", new Bitmap(str + "\\rsrc\\TSProfMed.png"));
      this.GFXDict.Add("FS_PROF-MED", new Bitmap(str + "\\rsrc\\FSProfMed.png"));
      this.GFXDict.Add("RD_PROF-MED", new Bitmap(str + "\\rsrc\\RDProfMed.png"));
      this.loaded = true;
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show("Failed to load images resources (\\rsrc\\ directory).\n Did you copy the /rsrc/ directory?\n It is highly advised that you restart Telepone.", "Warning", MessageBoxButtons.OK);
      this.loaded = false;
    }
  }

  public Bitmap GetLoadedImage(string sought)
  {
    return !this.loaded || !this.GFXDict.ContainsKey(sought) ? (Bitmap) null : this.GFXDict[sought];
  }

  public Bitmap GetFavPonyImage(FAVORITE_PONY favpony)
  {
    Bitmap bitmap1;
    if (!this.loaded)
    {
      bitmap1 = (Bitmap) null;
    }
    else
    {
      Bitmap bitmap2;
      try
      {
        switch (favpony)
        {
          case (FAVORITE_PONY) 0:
            bitmap1 = this.GFXDict["GFX-Unknown"];
            goto label_13;
          case (FAVORITE_PONY) 1:
            bitmap1 = this.GFXDict["GFX-FAV-AJ"];
            goto label_13;
          case (FAVORITE_PONY) 2:
            bitmap1 = this.GFXDict["GFX-FAV-PP"];
            goto label_13;
          case (FAVORITE_PONY) 3:
            bitmap1 = this.GFXDict["GFX-FAV-RY"];
            goto label_13;
          case (FAVORITE_PONY) 4:
            bitmap1 = this.GFXDict["GFX-FAV-TS"];
            goto label_13;
          case (FAVORITE_PONY) 5:
            bitmap1 = this.GFXDict["GFX-FAV-FS"];
            goto label_13;
          case (FAVORITE_PONY) 6:
            bitmap1 = this.GFXDict["GFX-FAV-RD"];
            goto label_13;
          default:
            bitmap1 = (Bitmap) null;
            goto label_13;
        }
      }
      catch (KeyNotFoundException ex)
      {
        bitmap2 = (Bitmap) null;
      }
      bitmap1 = bitmap2;
    }
label_13:
    return bitmap1;
  }

  public Bitmap GetCutieMark(FAVORITE_PONY favpony)
  {
    Bitmap bitmap1;
    if (!this.loaded)
    {
      bitmap1 = (Bitmap) null;
    }
    else
    {
      Bitmap bitmap2;
      try
      {
        switch (favpony)
        {
          case (FAVORITE_PONY) 0:
            bitmap1 = this.GFXDict["GFX-Unknown"];
            goto label_13;
          case (FAVORITE_PONY) 1:
            bitmap1 = this.GFXDict["GFX-MARK-AJ"];
            goto label_13;
          case (FAVORITE_PONY) 2:
            bitmap1 = this.GFXDict["GFX-MARK-PP"];
            goto label_13;
          case (FAVORITE_PONY) 3:
            bitmap1 = this.GFXDict["GFX-MARK-RY"];
            goto label_13;
          case (FAVORITE_PONY) 4:
            bitmap1 = this.GFXDict["GFX-MARK-TS"];
            goto label_13;
          case (FAVORITE_PONY) 5:
            bitmap1 = this.GFXDict["GFX-MARK-FS"];
            goto label_13;
          case (FAVORITE_PONY) 6:
            bitmap1 = this.GFXDict["GFX-MARK-RD"];
            goto label_13;
          default:
            bitmap1 = (Bitmap) null;
            goto label_13;
        }
      }
      catch (KeyNotFoundException ex)
      {
        bitmap2 = (Bitmap) null;
      }
      bitmap1 = bitmap2;
    }
label_13:
    return bitmap1;
  }

  public Bitmap GetPonyProfilePic(FAVORITE_PONY favpony)
  {
    Bitmap bitmap1;
    if (!this.loaded)
    {
      bitmap1 = (Bitmap) null;
    }
    else
    {
      Bitmap bitmap2;
      try
      {
        switch (favpony)
        {
          case (FAVORITE_PONY) 0:
            bitmap1 = (Bitmap) null;
            goto label_13;
          case (FAVORITE_PONY) 1:
            bitmap1 = this.GFXDict["AJ_PROF-MED"];
            goto label_13;
          case (FAVORITE_PONY) 2:
            bitmap1 = this.GFXDict["PP_PROF-MED"];
            goto label_13;
          case (FAVORITE_PONY) 3:
            bitmap1 = this.GFXDict["RY_PROF-MED"];
            goto label_13;
          case (FAVORITE_PONY) 4:
            bitmap1 = this.GFXDict["TS_PROF-MED"];
            goto label_13;
          case (FAVORITE_PONY) 5:
            bitmap1 = this.GFXDict["FS_PROF-MED"];
            goto label_13;
          case (FAVORITE_PONY) 6:
            bitmap1 = this.GFXDict["RD_PROF-MED"];
            goto label_13;
          default:
            bitmap1 = (Bitmap) null;
            goto label_13;
        }
      }
      catch (KeyNotFoundException ex)
      {
        bitmap2 = (Bitmap) null;
      }
      bitmap1 = bitmap2;
    }
label_13:
    return bitmap1;
  }

  public Bitmap GetStateBG(uint state)
  {
    Bitmap bitmap1;
    if (!this.loaded)
    {
      bitmap1 = (Bitmap) null;
    }
    else
    {
      Bitmap bitmap2;
      try
      {
        bitmap1 = (int) state == 1 ? this.GFXDict["GFX-STATEBG-REST"] : this.GFXDict["GFX-none"];
        goto label_5;
      }
      catch (KeyNotFoundException ex)
      {
        bitmap2 = (Bitmap) null;
      }
      bitmap1 = bitmap2;
    }
label_5:
    return bitmap1;
  }
}
