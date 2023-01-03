﻿using System.ComponentModel;
using OOP_lab3.core;
using OOP_lab3.model.Static;


namespace OOP_lab3.viewmodel
{
    public class MainViewModel : ObservableObj
    {
        public RelayCommand ProfileViewCommand { get; set; }
        public RelayCommand GameViewCommand { get; set; }
        public RelayCommand LogINCommand{get; set; }
        public RelayCommand LogOUTCommand{get; set; }
        
        public LogINViewModel LogINVM { get; set; }
        public ProfileViewModel ProfileVM { get; set; }
        public GameViewModel GameVM { get; set; }
        private object _currentView;
        private LogIN logIn = null;

        
        
        public object CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            logIn = model.Static.LogIN.Initializate();
            ProfileVM = new ProfileViewModel();
            GameVM = new GameViewModel();
            LogINVM = new LogINViewModel();


            ProfileViewCommand = new RelayCommand(o =>
            {
                CurrentView = ProfileVM;
            });

            GameViewCommand = new RelayCommand(o =>
            {
                CurrentView = GameVM;
            });

            LogINCommand = new RelayCommand(o =>
            {
                if(!logIn._logINed) 
                    CurrentView = LogINVM;
            });

            LogOUTCommand = new RelayCommand(o =>
            {
                logIn.LogOut();
                CurrentView = null;
            });
        }
    }
    
}