using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CurruncyConvert
{
    class Curruncy
    {
        public Curruncy(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }

        public string Title { get; set; }
        public decimal Rate { get; set; }
    }

    class CurruncyConvertViewModel2:Notifier
    {
        #region property
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

        private decimal converted;
        public decimal Converted
        {
            get { return converted; }
            set
            {
                converted = value;
                OnPropertyChanged("Converted");
            }
        }

        private Curruncy selectedCurruncy;
        public Curruncy SelectedCurruncy
        {
            get { return selectedCurruncy; }
            set
            {
                selectedCurruncy = value;
                OnPropertyChanged("SelectedCurruncy");
                OnSelectedCurruncyChaged();
            }
        }

        private IEnumerable<Curruncy> curruncies;
        public IEnumerable<Curruncy> Curruncies
        {
            get { return curruncies; }
            set
            {
                curruncies = value;
                OnPropertyChanged("Curruncies");
            }
        }

        private string resultText;
        public string ResultText
        {
            get { return resultText; }
            set
            {
                resultText = value;
                OnPropertyChanged("ResultText");
            }
        }
        #endregion

        public CurruncyConvertViewModel2()
        {
            Curruncies = new Curruncy[]
            {
                new Curruncy("US",0.0008m),
                new Curruncy("CHINA",0.005m)
            };
        }

        private void OnWonChanged()
        {
            ComputedCurruncy();
        }

        private void OnSelectedCurruncyChaged()
        {
            ComputedCurruncy();
        }

        private void ComputedCurruncy()
        {
            if(SelectedCurruncy == null)
            {
                return;
            }

            Converted = Won * SelectedCurruncy.Rate;

            ResultText = string.Format("Amount in {0}", SelectedCurruncy.Title);
        }
    }
}
