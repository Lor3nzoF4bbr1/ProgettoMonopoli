using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagramma_delle_Classi_Monopoli
{
    public class Proprieta : Carta
    {
        private string _colore;
        private int _costo;
        private int _numCase;
        private bool _hotel;

        public int CostoVendita
        {
            get => default;
            set //calcola la metà del costo e lo restituisce nel get
            {
            }
        }
    }
}