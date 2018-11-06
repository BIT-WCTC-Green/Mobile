using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TeamList Teams = new TeamList();
            TeamListOut.ItemsSource = Teams.getTeamList();
        }

        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

                  await Navigation.PushAsync(new MyPage());
  
        }
    }
}
