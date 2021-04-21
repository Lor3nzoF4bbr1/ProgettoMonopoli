using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Diagramma_delle_Classi_Monopoli
{
    public class Giocatore
    {
        private int _denaro;
        private List<Proprieta> _proprieta;
        private List<Probabilita> _probabilita;
        private List<Imprevisto> _imprevisti;
        private ImageSource _pedina;
        private string _nickname;
        private bool _sesso;
        private int _eta;
    }
}