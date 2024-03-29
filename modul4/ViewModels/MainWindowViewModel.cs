﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using modul4.ChocholateLogic;
using modul4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace modul4.ViewModels
{
    public partial class MainWindowViewModel: ObservableRecipient
    {
        public int Income
        {
            get { return logic.Income; }
        }
        public ObservableCollection<Chocolate> Chocolates {  get; set; }
        ChocolateLogic logic;


        
        

        public ICommand AddButton { get; set; }
        public ICommand RemoveButton { get; set; }
        public ICommand EditButton { get; set; }
        public ICommand BuySnackButton { get; set; }
        private Chocolate _selectedChocolate;
        public Chocolate SelectedChocolate 
        {
            get { return _selectedChocolate; }
            set
            {
                _selectedChocolate = value;
                OnPropertyChanged("SelectedChocolate");
            }
        }

        public MainWindowViewModel()
        {
            Chocolates=new ObservableCollection<Chocolate>();
            Chocolates.Add(new Chocolate()
            {
                Type="Twix",
                Price=300,
                Quantity=20
            });
            Chocolates.Add(new Chocolate()
            {
                Type="Mars",
                Price=150,
                Quantity=13
            });
            Chocolates.Add(new Chocolate()
            {
                Type = "Balaton szelet",
                Price = 400,
                Quantity = 16
            });
            logic = new ChocolateLogic(Chocolates);
            logic.Income = 4000;


            BuySnackButton = new RelayCommand(
                () => logic.BuySnack(SelectedChocolate)
                );
            AddButton = new RelayCommand(
                () => logic.AddSnack()
                );
            RemoveButton = new RelayCommand(
                () => logic.RemoveSnack(SelectedChocolate)
                );

        }

    }
}
