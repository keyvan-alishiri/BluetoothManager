using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using Windows.Devices.Enumeration;
using Windows.Devices.PointOfService;
using Windows.Foundation;
using Windows.Graphics.Printing;

namespace DeviceManagment.Views
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class PrinterView : UserControl
    {
      
      private MainWindow rootPage = MainWindow.Current;
      bool isBusy = false;
      public PrinterView()
        {
            InitializeComponent();
         
        }

	  private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
	  {
         
         RetainDeviceCheckBox.IsChecked = rootPage.IsAnImportantTransaction;
         rootPage.StateChanged += UpdateButtons;
         UpdateButtons();
      }

	  private void UserControl_Unloaded(object sender, System.Windows.RoutedEventArgs e)
	  {
         
         rootPage.StateChanged -= UpdateButtons;
      }
      void UpdateButtons()
      {
         PrinterNameRun.Text = (rootPage.Printer == null) ? "None" : rootPage.deviceInfo.Name + " (" + rootPage.Printer.DeviceId + ")";
         if (isBusy)
         {
            FindButton.IsEnabled = false;
            ClaimAndEnableButton.IsEnabled = false;
            ReleaseClaimedPrinterButton.IsEnabled = false;
            ReleaseAllPrintersButton.IsEnabled = false;
         }
         else if (rootPage.Printer == null)
         {
            FindButton.IsEnabled = true;
            ClaimAndEnableButton.IsEnabled = false;
            ReleaseClaimedPrinterButton.IsEnabled = false;
            ReleaseAllPrintersButton.IsEnabled = false;
         }
         else
         {
            FindButton.IsEnabled = false;
            ReleaseAllPrintersButton.IsEnabled = true;
            if (rootPage.ClaimedPrinter == null)
            {
               ClaimAndEnableButton.IsEnabled = true;
               ReleaseClaimedPrinterButton.IsEnabled = false;
            }
            else
            {
               ClaimAndEnableButton.IsEnabled = false;
               ReleaseClaimedPrinterButton.IsEnabled = true;
            }
         }
      }

      async void FindPrinter_Click()
      {
         isBusy = true;
         UpdateButtons();
         rootPage.NotifyUser("", NotifyType.StatusMessage);

         rootPage.ReleaseAllPrinters();

         // Select a PosPrinter device using the Device Picker.
         DevicePicker devicePicker = new DevicePicker();
         devicePicker.Filter.SupportedDeviceSelectors.Add(PosPrinter.GetDeviceSelector());

         // Anchor the picker on the Find button.
         //  GeneralTransform ge = FindButton.TransformToVisual(FrameworkElement);
         Windows.Foundation.Rect rect = new Windows.Foundation.Rect(0, 0, MainWindow.Current.Width / 3  , MainWindow.Current.Height);

         DeviceInformation deviceInfo = await devicePicker.PickSingleDeviceAsync(rect);
         rootPage.deviceInfo = deviceInfo;
         PosPrinter printer = null;
         if (deviceInfo != null)
         {
            printer = await PosPrinter.FromIdAsync(deviceInfo.Id);
         }
         if (printer != null && printer.Capabilities.Receipt.IsPrinterPresent)
         {
            rootPage.Printer = printer;
            rootPage.NotifyUser("Found receipt printer.", NotifyType.StatusMessage);
         }
         else
         {
            // Get rid of the printer we can't use.
            printer?.Dispose();
            rootPage.NotifyUser("Please select a device whose printer is present.", NotifyType.ErrorMessage);
         }

         isBusy = false;
         UpdateButtons();
      }

      async void ClaimAndEnable_Click()
      {
         isBusy = true;
         UpdateButtons();
         rootPage.ClaimedPrinter = await rootPage.Printer.ClaimPrinterAsync();
         if (rootPage.ClaimedPrinter == null)
         {
            rootPage.NotifyUser("Unable to claim printer", NotifyType.ErrorMessage);
         }
         else
         {
            rootPage.NotifyUser("Claimed printer", NotifyType.StatusMessage);

            // Register for the ReleaseDeviceRequested event so we know when somebody
            // wants to claim the printer away from us.
            rootPage.SubscribeToReleaseDeviceRequested();

            if (await rootPage.ClaimedPrinter.EnableAsync())
            {
               rootPage.NotifyUser("Enabled printer.", NotifyType.StatusMessage);
            }
            else
            {
               rootPage.NotifyUser("Could not enable printer", NotifyType.ErrorMessage);
               rootPage.ReleaseClaimedPrinter();
            }
         }

         isBusy = false;
         UpdateButtons();
      }

      void IsImportantTransaction_Click()
      {
         rootPage.IsAnImportantTransaction = RetainDeviceCheckBox.IsChecked.Value;
      }

      void ReleaseClaim_Click()
      {
         rootPage.ReleaseClaimedPrinter();
      }

      void ReleaseAll_Click()
      {
         rootPage.ReleaseAllPrinters();
      }

	  private void FindButton_Click(object sender, System.Windows.RoutedEventArgs e)
	  {
         FindPrinter_Click();

      }

	  private void ClaimAndEnableButton_Click(object sender, System.Windows.RoutedEventArgs e)
	  {
         ClaimAndEnable_Click();

      }

	  private void RetainDeviceCheckBox_Click(object sender, System.Windows.RoutedEventArgs e)
	  {
         IsImportantTransaction_Click();

      }

	  private void ReleaseClaimedPrinterButton_Click(object sender, System.Windows.RoutedEventArgs e)
	  {
         ReleaseClaim_Click();

      }

	  private void ReleaseAllPrintersButton_Click(object sender, System.Windows.RoutedEventArgs e)
	  {
         ReleaseAll_Click();

      }

	  

	  private void InvokePrintingButton_Click(object sender, System.Windows.RoutedEventArgs e)
	  {

         
            
         StartProcess("explorer.exe", "shell:::{A8A91A66-3A7D-4424-8D24-04E180695C7A}", true);
        





      }

   
      [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
      
      public static extern bool IsIconic(IntPtr hWnd);


      [DllImport("User32.dll", CharSet = CharSet.None, ExactSpelling = false)]
      
      public static extern int ShowWindowAsync(IntPtr hWnd, int swCommand);

      [DllImport("user32.dll", CharSet = CharSet.None, ExactSpelling = false)]
     
      public static extern bool SetForegroundWindow(IntPtr hWnd);

	  public void StartProcess(string app_path, string app_args, bool bring_to_front_if_already_started)
	  {
		 try
		 {
			if (!string.IsNullOrEmpty(app_path))
			{


			   try
			   {
				  if (string.IsNullOrEmpty(app_path))
				  {
					 app_path = "";
				  }
				  if (string.IsNullOrEmpty(app_args))
				  {
					 app_args = "";
				  }

				  string fileNameWithoutExtension = null;
				  fileNameWithoutExtension = Path.GetFileNameWithoutExtension(app_path);
				  string lower = null;
				  lower = fileNameWithoutExtension.ToLower();
				  bool flag = false;
				  if (lower == "explorer")
				  {
					 flag = true;
				  }
				  else if (lower == "cmd")
				  {
					 flag = true;
				  }
				  else if (lower == "svchost")
				  {
					 flag = true;
				  }
				  else if (lower == "winoldap")
				  {
					 flag = true;
				  }
				  else if (lower == "rundll32")
				  {
					 flag = true;
				  }
				  else if (lower == "rundll")
				  {
					 flag = true;
				  }
				  ProcessStartInfo processStartInfo = null;
				  processStartInfo = new ProcessStartInfo()
				  {
					 UseShellExecute = false,
                     FileName = app_path,
					 Arguments = app_args,
                     WindowStyle= ProcessWindowStyle.Maximized,
                     RedirectStandardOutput = true
				  };
				  if (!bring_to_front_if_already_started || flag)
				  {
					 Process.Start(processStartInfo);
					 rootPage.NotifyUser("Start Devices and Printers Process ...", NotifyType.StatusMessage);
					 return;
				  }
				  else
				  {

                     
                     Process[] processesByName = null;
					 processesByName = Process.GetProcessesByName(fileNameWithoutExtension);
					 bool flag1 = false;

					 if (processesByName != null && processesByName.Length > 0)
					 {
						Process process = null;
						process = processesByName[0];
						flag1 = true;
						IntPtr mainWindowHandle = process.MainWindowHandle;
						if (IsIconic(mainWindowHandle))
						{
						   ShowWindowAsync(mainWindowHandle, 9);

						}
						SetForegroundWindow(mainWindowHandle);
                        
                     }
					 if (!flag1)
					 {
						Process.Start(processStartInfo);
                        

                     }
                     
                  }
                  
			   }
			   catch (Exception exception1)
			   {
				  Exception exception = exception1;

				  rootPage.NotifyUser("StartProcess failed", NotifyType.ErrorMessage);

			   }

			}
		 }
		 catch (Exception exception3)
		 {
			Exception exception2 = exception3;
			rootPage.NotifyUser("StartProcess failed", NotifyType.ErrorMessage);
		 }
	  }

      
	  
   }
}
