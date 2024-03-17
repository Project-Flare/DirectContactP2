using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Views.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();

            NewItems = new ObservableCollection<string>();
        }

        

        // discovery people list
        [ObservableProperty]
        ObservableCollection<string> items;

        // friend list
        [ObservableProperty]
        ObservableCollection<string> newItems;


        




        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add() // instead of adding users, this method would be good for search usage
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void AddUser(string s)
        {
            if(Items.Contains(s))
            {
                NewItems.Add(s);
                Items.Remove(s);
            }
        }

        [RelayCommand]
        void DeleteUser(string s)
        {
            if (NewItems.Contains(s))
            {
                Items.Add(s);
                NewItems.Remove(s);
            }
        }
    }

}
