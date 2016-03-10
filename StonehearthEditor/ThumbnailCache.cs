﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonehearthEditor
{
   public class ThumbnailCache
   {
      private static Dictionary<string, Image> sThumbnailCache = new Dictionary<string, Image>();
      private static int kDefaultSize = 40;
      public static Image GetThumbnail(string imageFile)
      {
         Image thumbnail;
         if (!sThumbnailCache.TryGetValue(imageFile, out thumbnail))
         {
            if (System.IO.File.Exists(imageFile))
            {
               Image image = Image.FromFile(imageFile);
               thumbnail = image.GetThumbnailImage(kDefaultSize, kDefaultSize, null, IntPtr.Zero);
               sThumbnailCache[imageFile] = thumbnail;
               image.Dispose();
            }
         }
         return thumbnail;
      }
   }
}