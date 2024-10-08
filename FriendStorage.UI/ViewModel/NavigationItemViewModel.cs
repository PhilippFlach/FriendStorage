﻿using FriendStorage.UI.Command;
using FriendStorage.UI.Events;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FriendStorage.UI.ViewModel
{
    public class NavigationItemViewModel
    {
      public NavigationItemViewModel(int id,
          string displayMember,
          IEventAggregator eventAggregator)
        {
            Id = id;
            DisplayMember = displayMember;
            OpenFriendEditViewCommand = new DelegateCommand(OnOpenFriendEditViewExecute);
            _eventAggregator = eventAggregator;

        }

        private void OnOpenFriendEditViewExecute(object obj)
        {
            _eventAggregator.GetEvent<OpenFriendEditViewEvent>()
                .Publish(Id);
        }

        public int Id { get; private set; }
        public string DisplayMember { get; private set; }
        public ICommand OpenFriendEditViewCommand { get; private set; }

        private IEventAggregator _eventAggregator;
    }
}
