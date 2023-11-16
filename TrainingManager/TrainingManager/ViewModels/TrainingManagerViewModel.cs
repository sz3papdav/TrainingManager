using CommunityToolkit.Mvvm.ComponentModel;
using TrainingManagerProject.Models;
using System.Linq;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using System;

namespace TrainingManagerProject.ViewModels
{
    public partial class TrainingViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<string> _korosztaly = new ObservableCollection<string>(new Korosztaly().OsszesKorosztaly);

        [ObservableProperty]
        private ObservableCollection<TrainingManager> _trainingmanagers = new ObservableCollection<TrainingManager>();

        [ObservableProperty]
        private TrainingManager _ember;

        private string _korosztalyok = "U9";

        public string Korosztalyok
        {
            get => _korosztalyok;
            set
            {
                SetProperty(ref _korosztalyok, value);
                Ember.Korosztaly = _korosztalyok;
            }
        }
        public TrainingViewModel()
        {
            Ember = new TrainingManager();
            Korosztalyok = _korosztaly.ElementAt(0);
        }
        [RelayCommand]
        public void DoSave(TrainingManager trainingmanager)
        {
            Trainingmanagers.Add(trainingmanager);
            OnPropertyChanged(nameof(TrainingManager));
        }
    }
}
