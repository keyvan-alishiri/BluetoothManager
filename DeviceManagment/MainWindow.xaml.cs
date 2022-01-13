using DeviceManagment.Views;
using MahApps.Metro.Controls;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using Windows.Devices.Enumeration;
using Windows.Devices.PointOfService;

namespace DeviceManagment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
	  
	  public static MainWindow Current;
	  
	  internal PosPrinter Printer = null;
	  internal ClaimedPosPrinter ClaimedPrinter = null;
	  internal DeviceInformation deviceInfo = null;
	  internal bool IsAnImportantTransaction = true;
	  internal event Action StateChanged;

	  public MainWindow()
        {
            InitializeComponent();
		 
		 Current = this;
      }
	  public void NotifyUser(string strMessage, NotifyType type)
	  {
		 // If called from the UI thread, then update immediately.
		 // Otherwise, schedule a task on the UI thread to perform the update.
		 if (Dispatcher.Thread.IsAlive)
		 {
			UpdateStatus(strMessage, type);
		 }
		 else
		 {
			var task = Dispatcher.BeginInvoke(new Action(() => UpdateStatus(strMessage, type)), System.Windows.Threading.DispatcherPriority.Normal);
		 }
	  }
	  private void UpdateStatus(string strMessage, NotifyType type)
	  {
		 switch (type)
		 {
			case NotifyType.StatusMessage:

			   StatusBorder.Background = new SolidColorBrush(Colors.Green);
			   break;
			case NotifyType.ErrorMessage:
			   StatusBorder.Background = new SolidColorBrush(Colors.Red);
			   break;
		 }

		 StatusBlock.Text = strMessage;

		 // Collapse the StatusBlock if it has no text to conserve real estate.
		 StatusBorder.Visibility = (StatusBlock.Text != String.Empty) ? System.Windows.Visibility.Visible : System.Windows.Visibility.Collapsed;
		 if (StatusBlock.Text != String.Empty)
		 {
			StatusBorder.Visibility = System.Windows.Visibility.Visible;
			StatusPanel.Visibility = System.Windows.Visibility.Visible;
		 }
		 else
		 {
			StatusBorder.Visibility = System.Windows.Visibility.Collapsed;
			StatusPanel.Visibility = System.Windows.Visibility.Collapsed;
		 }

		 //Raise an event if necessary to enable a screen reader to announce the status update.
		 var peer = FrameworkElementAutomationPeer.FromElement(StatusBlock);
		 if (peer != null)
		 {
		    peer.RaiseAutomationEvent(AutomationEvents.LiveRegionChanged);
		 }
}

	  public void SubscribeToReleaseDeviceRequested()
	  {
		 ClaimedPrinter.ReleaseDeviceRequested += ClaimedPrinter_ReleaseDeviceRequested;
	  }

	  public void ReleaseClaimedPrinter()
	  {
		 if (ClaimedPrinter != null)
		 {
			ClaimedPrinter.ReleaseDeviceRequested -= ClaimedPrinter_ReleaseDeviceRequested;
			ClaimedPrinter.Dispose();
			ClaimedPrinter = null;
			StateChanged?.Invoke();
		 }
	  }

	  public void ReleaseAllPrinters()
	  {
		 ReleaseClaimedPrinter();

		 if (Printer != null)
		 {
			Printer.Dispose();
			Printer = null;
			StateChanged?.Invoke();
		 }
	  }

	  /// <summary>
	  /// If the "Retain device" checkbox is checked, we retain the device.
	  /// Otherwise, we allow the other claimant to claim the device.
	  /// </summary>
	  private async void ClaimedPrinter_ReleaseDeviceRequested(ClaimedPosPrinter sender, PosPrinterReleaseDeviceRequestedEventArgs args)
	  {
		 if (IsAnImportantTransaction)
		 {
			await sender.RetainDeviceAsync();
		 }
		 else
		 {
			await Dispatcher.BeginInvoke((Action) (() =>
			{
			   NotifyUser("Lost printer claim.", NotifyType.ErrorMessage);
			   ReleaseClaimedPrinter();
			}),System.Windows.Threading.DispatcherPriority.Normal);
		 }
	  }

	  private void MetroWindow_Activated(object sender, EventArgs e)
	  {
		 
		 
		 NotifyUser("", NotifyType.StatusMessage);
	  }

	  //private void HamburgerMenuControl_ItemClick(object sender, ItemClickEventArgs args)
	  //{
	  //var result = args.ClickedItem as ViewModels.AboutViewModel;
	  //if(result != null)
	  //{
	  //if (result.Label.ToString() == "Bluetooth")
	  //{

	  //  Views.PrivateView.privateView.InvokeMethod();
	  //}
	  //}

	  //}
   }
   public enum NotifyType
   {
      StatusMessage,
      ErrorMessage
   };
}