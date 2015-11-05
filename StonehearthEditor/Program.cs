﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonehearthEditor
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         string path = "C:/Radiant/stonehearth/source/stonehearth_data/mods";
         if (args.Length > 0)
         {
            path = args[0];
         }
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new StonehearthEditor(path));
      }
   }
}
