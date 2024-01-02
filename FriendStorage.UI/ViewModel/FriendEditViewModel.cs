using FriendStorage.Model;
using FriendStorage.UI.DataProvider;

namespace FriendStorage.UI.ViewModel
{
    public interface IFriendEditViewModel
    {
        void Load(int friendId);
        Friend Friend { get; }
    }
    public class FriendEditViewModel : ViewModelBase, IFriendEditViewModel
    {
        private IFriendDataProvider _dataProvider;
        private Friend _fiend;

        public FriendEditViewModel(IFriendDataProvider dataProvider)
        {
            this._dataProvider = dataProvider;
        }

        public Friend Friend
        {
            get
            {
                return _fiend;
            }

            private set
            {
                _fiend = value;
                OnPropertyChanged();
            }
        }
        public void Load(int friendId)
        {
            var friend = _dataProvider.GetFriendById(friendId);
            Friend = friend;
        }
    }
}
