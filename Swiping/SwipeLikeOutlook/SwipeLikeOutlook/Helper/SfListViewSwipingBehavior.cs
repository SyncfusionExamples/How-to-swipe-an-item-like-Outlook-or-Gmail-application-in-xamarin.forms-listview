using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfListViewSample
{
    #region SwipingBehavior
    public class SfListViewSwipingBehavior : Behavior<SfListView>
    {
        #region Fields

        private ListViewSwipingViewModel SwipingViewModel;
        private SfListView ListView;

        #endregion

        #region Overrides
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            ListView.SwipeEnded += ListView_SwipeEnded;
            ListView.PropertyChanged += ListView_PropertyChanged;
            SwipingViewModel = new ListViewSwipingViewModel();
            SwipingViewModel.sfListView = ListView;
            bindable.BindingContext = SwipingViewModel;
            ListView.ItemsSource = SwipingViewModel.InboxInfo;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfListView bindable)
        {
            ListView.SwipeEnded -= ListView_SwipeEnded;
            ListView.PropertyChanged -= ListView_PropertyChanged;
            ListView = null;
            SwipingViewModel = null;
            base.OnDetachingFrom(bindable);
        }

        #endregion

        #region Events

        private void ListView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Width" && ListView.Orientation == Orientation.Vertical && ListView.SwipeOffset != ListView.Width)
                ListView.SwipeOffset = ListView.Width;
            else if (e.PropertyName == "Height" && ListView.Orientation == Orientation.Horizontal && ListView.SwipeOffset != ListView.Height)
                ListView.SwipeOffset = ListView.Height;
        }

        private void ListView_SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            SwipingViewModel.ItemIndex = e.ItemIndex;

            if (e.SwipeDirection == Syncfusion.ListView.XForms.SwipeDirection.Right)
            {
                e.SwipeOffset = ListView.Width;
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Task.Delay(500);
                    SwipingViewModel.InboxInfo.Remove(e.ItemData as ListViewInboxInfo);

                });
            }
            else if (e.SwipeDirection == Syncfusion.ListView.XForms.SwipeDirection.Left)
            {
                e.SwipeOffset = ListView.Width;
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Task.Delay(500);
                    SwipingViewModel.InboxInfo.Remove(e.ItemData as ListViewInboxInfo);

                });
            }
        }
        #endregion
    }
    #endregion
}
