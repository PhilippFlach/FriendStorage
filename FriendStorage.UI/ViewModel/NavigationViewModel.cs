﻿using FriendStorage.DataAccess;
using FriendStorage.Model;
using FriendStorage.UI.DataProvider;
using Prism.Events;
using System;
using System.Collections.ObjectModel;

namespace FriendStorage.UI.ViewModel
{
  public interface INavigationViewModel
  {
    void Load();
  }
  public class NavigationViewModel : ViewModelBase,
    INavigationViewModel
  {
        private INavigationDataProvider _dataProvider;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(INavigationDataProvider dataProvider,
        IEventAggregator eventAggregator)
    {
      Friends = new ObservableCollection<NavigationItemViewModel>();
      _dataProvider = dataProvider;
      _eventAggregator = eventAggregator;
    }

    public void Load()
    {
      Friends.Clear();
      foreach (var friend in _dataProvider.GetAllFriends())
      {
        Friends.Add(new NavigationItemViewModel(
            friend.Id, friend.DisplayMember, _eventAggregator));
      }
    }

    public ObservableCollection<NavigationItemViewModel> Friends { get; private set; }
  }
}
