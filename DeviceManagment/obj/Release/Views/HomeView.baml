   M S B A M L   `   `   `  ����   DeviceManagment$    DeviceManagment.Views.HomeView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   .���� -     ��Name$  scrollViewer��$��12,20,12,12q�$��	0,0,0,-65q�.���� .+��� $��Description:���� $
��Wrap=�,*Find, claim, and enable a receipt printer.�� $��Add Device Printer��$
��Wrap=�$��0,10,0,0q��� -    ��Name$ 
FindButton��$
��Left=�$	��200��$��Find receipt printer��$��0,10,0,0q��� $
��Wrap=�$��0,10,0,0q�	Printer: �� -    ��Name$ PrinterNameRun��$
�None���� -   $ ClaimAndEnableButton��$	��200��$
��Left=�$��Claim and enable��$��0,10,0,0q��� $
��Wrap=�$��0,15,0,0q���When informed that another app is trying to claim the device, the owner must retain the device promptly in order to preserve its claim.�� -    ��Name$ RetainDeviceCheckBox��$��Retain device��$��3,13,0,0q��� -   $! ReleaseClaimedPrinterButton��$
��Left=�$	��200��$��Release claim��$��0,15,0,0q��� -   $ ReleaseAllPrintersButton��$
��Left=�$	��200��$��Release printer��$��0,10,0,0q��� $
��Wrap=�$��0,20,0,0q�%#Start Windows Devices and Printers.�� -	   $ InvokePrintingButton��$
��Left=�$	��200��$��Print��$��0,13,0,0q�