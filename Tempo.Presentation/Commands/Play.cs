﻿using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace Tempo.Presentation
{
    public partial class MainWindowViewModel
    {
        private ICommand _playCommand;
        public ICommand PlayCommand
        {
            get
            {
                if (_playCommand == null)
                {
                    _playCommand = new RelayCommand(playCommandAction());
                }
                return _playCommand;
            }
        }
        private Action playCommandAction()
        {
            return new Action(
                () =>
                {
                    audioPlayer.Play(this.SelectedSong);
                });
        }
    }
}