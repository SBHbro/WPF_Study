using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CurruncyConvert
{
    class CurruncyConvertViewModel : Notifier
    {
        private decimal won;
        public decimal Won
        {
            get { return won; }
            set
            {
                won = value;
                OnPropertyChanged("Won");
                OnWonChanged();
            }
        }

        private decimal dollor;
        public decimal Dollor
        {
            get { return Decimal.Round(dollor,2); }
            set
            {
                dollor = value;
                OnPropertyChanged("Dollor");
            }
        }

        private void OnWonChanged()
        {
            Dollor = Won / 1200;
        }
    }
}
