using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectionView
{
    class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<Card> Cards { get; set; }

        public MainPageViewModel()
        {
            Cards = new ObservableCollection<Card>();
            
            Cards.Add(new Card());
            Cards.Add(new Card());
            Cards.Add(new Card());

            Cards.Add(new Card());
            Cards.Add(new Card());
            Cards.Add(new Card());

            Cards.Add(new Card());
            Cards.Add(new Card());
            Cards.Add(new Card());

            Cards.Add(new Card());
            Cards.Add(new Card());
            Cards.Add(new Card());

            Cards.Add(new Card());
            Cards.Add(new Card());
            Cards.Add(new Card());

            Cards.Add(new Card());
            Cards.Add(new Card());
            Cards.Add(new Card());
        }
    }
}
