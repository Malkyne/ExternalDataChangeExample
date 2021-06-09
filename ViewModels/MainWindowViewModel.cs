using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using ExternalDataChangeExample.Models;
using ReactiveUI;

namespace ExternalDataChangeExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Arrival> Arrivals { get; } = new();

        private int _selectedIndex = -1;
        public int SelectedIndex { get => _selectedIndex; private set => this.RaiseAndSetIfChanged(ref _selectedIndex, value); }
        
        private Arrival? _selectedArrival = null;
        public Arrival? SelectedArrival { get => _selectedArrival; private set => this.RaiseAndSetIfChanged(ref _selectedArrival, value); }

        public MainWindowViewModel()
        {
            Arrivals.Add(new Arrival("James"));
            Arrivals.Add(new Arrival("Jocelyn"));
            Arrivals.Add(new Arrival("Akua"));
            Arrivals.Add(new Arrival("Esperanza"));
            Arrivals.Add(new Arrival("Kofi"));
            Arrivals.Add(new Arrival("Emma"));
            Arrivals.Add(new Arrival("Raul"));
        }
        
        public void AddTimestamp()
        {
            if (SelectedArrival == null) return;
            SelectedArrival.Timestamp = DateTime.Now;
        }
        
        
    }
}