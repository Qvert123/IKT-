﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouraniZdiHra
{
    class clsKulicka
    {
        // grafika pro kreslení
        Graphics mobjGrafika;

        // proměnná kuličky
        int mintXKulicky, mintYKulicky;
        int mintPohybX, mintPohybY;
        const int mintRKulicky = 15;
        const int mintRychlostPosunu = 3;

        //------------------------------------------------
        // konstruktor
        //------------------------------------------------

        public clsKulicka(Graphics objPlatno)
        {
            mobjGrafika = objPlatno;

            mintXKulicky = (int)objPlatno.VisibleClipBounds.Width / 2;
            mintYKulicky = (int)objPlatno.VisibleClipBounds.Height / 2;
            mintPohybX = mintRychlostPosunu;
            mintPohybY = mintRychlostPosunu;
        }

        // načtení hodnot souřadnic kuličky
        public void otocYK ()
        {
            mintPohybY = mintPohybY * (-1);
        }
        public int intXK
        {
            get { return mintXKulicky; }
        }
        public int intYK { get { return mintYKulicky; } }
        public int intWK { get { return mintRKulicky; } }
        public int intHK { get { return mintRKulicky; } }

        //------------------------------------------------
        // pohyb kulicky po plátně
        //------------------------------------------------

        public void Pohyb()
        {
            // vykreslení kulicky
            mobjGrafika.FillEllipse(Brushes.Red, mintXKulicky, mintYKulicky, mintRKulicky, mintRKulicky);

            // posun
            mintXKulicky += mintPohybX;
            mintYKulicky += mintPohybY;

            // test kolize na hranách
            if (((mintYKulicky + mintRKulicky) > mobjGrafika.VisibleClipBounds.Height) ||
                (mintYKulicky < 0))
                otocYK();
            if (((mintXKulicky + mintRKulicky) > mobjGrafika.VisibleClipBounds.Width) ||
                (mintXKulicky < 0))
                mintPohybX = mintPohybX * (-1);
        }

        
    }

    
}
