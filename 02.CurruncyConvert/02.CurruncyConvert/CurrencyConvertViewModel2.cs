using System;
using System.Collections.Generic;
using System.Text;

namespace _02.CurrencyConvert
{
    class Currency
    {
        public Currency(string title, decimal rate)
        {
            Title = title;
            Rate = rate;
        }

        public string Title { get; set; }
        public decimal Rate { get; set; }
    }

    class CurrencyConvertViewModel2:Notifier
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

        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get { return selectedCurrency; }
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                OnSelectedCurrencyChaged();
            }
        }

        private IEnumerable<Currency> curruncies;
        public IEnumerable<Currency> Curruncies
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

        public CurrencyConvertViewModel2()
        {
            Curruncies = new Currency[]
            {
                new Currency("US",0.0008m),
                new Currency("CHINA",0.005m)
            };
        }

        private void OnWonChanged()
        {
            ComputedCurrency();
        }

        private void OnSelectedCurrencyChaged()
        {
            ComputedCurrency();
        }

        private void ComputedCurrency()
        {
            if(SelectedCurrency == null)
            {
                return;
            }

            Converted = Won * SelectedCurrency.Rate;

            ResultText = string.Format("Amount in {0}", SelectedCurrency.Title);
        }
    }
}
