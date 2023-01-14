﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
     static class Config
    {
        public static int Width
        {
            get
            {
                return _width;  
            }
            set 
            { 
                _width = value;
                Console.SetWindowSize(_width,_height);
                Console.SetBufferSize(_width,_height);
            }
        }

        public static int Height
        {
            get { return _height; }
            set {
                  _height = value;
                Console.SetWindowSize(_width, _height);
                Console.SetBufferSize(_width, _height);
            }
        } 

      private static int _width = 30;  
      public static int _height = 30;  
      public const int POINTCOUNT = 4;  
    }
}
