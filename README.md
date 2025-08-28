# How to swipe an item like Outlook or Gmail application in xamarin.forms listview?
This example demonstrates to swipe an item like Outlook or Gmail application in xamarin.forms listview by using the swiping events of listview.

## Sample

```xaml
<syncfusion:SfListView x:Name="listView"
                    ItemTemplate="{StaticResource ItemTemplate}" 
                    HeaderTemplate="{StaticResource HeaderTemplate}"
                    AllowSwiping="True" 
                    SelectionMode="None"
                    SwipeThreshold="30"  
                    IsStickyHeader="True" 
                    ItemSize="100" HeaderSize="70">

    <syncfusion:SfListView.RightSwipeTemplate>
        <DataTemplate x:Name="RightSwipeTemplate">
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </syncfusion:SfListView.RightSwipeTemplate>

    <syncfusion:SfListView.LeftSwipeTemplate>
        <DataTemplate x:Name="LeftSwipeTemplate">
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </syncfusion:SfListView.LeftSwipeTemplate>
</syncfusion:SfListView>
```

See [How to swipe an item like Outlook or Gmail application in xamarin.forms listview](https://www.syncfusion.com/kb/9965/how-to-swipe-an-item-like-outlook-or-gmail-application-in-xamarin-forms-listview) for more details.
## <a name="requirements-to-run-the-demo"></a>Requirements to run the demo ##

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
