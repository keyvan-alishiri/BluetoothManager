   M S B A M L   `   `   `  ����  DeviceManagment+    %DeviceManagment.Views.BasicParingView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          � 	Resources  5
         ComboBoxItemTemplate �� Path  ResultsListViewTemplate �� DataType � ColumnDefinitions �� Mode �� Orientation��%�  &	        &	 \     �� 5      .R�5      �� $��0,0,10,0q�6   ��6!   �� $ DisplayName�5      �� 5      $$ local:DeviceInformationDisplay��62   .R�5      � $��5q�6
    5      �� 5      $
��Auto �6   �� 5      $��* �6   $	��100��6#   .+�5      �� $��0��6   $��40��6   $��40��6(   $��5q�63   $	��Top=�6>   ._�5      �� $��UniformToFill=�5      ��5      �� *GlyphBitmapImage+$ OneWay=�5      5      �� 5      $��1��6   $��5q�6   ._�5      �� .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Name:��6   $��0,0,5,0q�6   �� 5      $
��Bold"�65   $��WrapWithOverflow=�6G   ��6   �� *Name+$ OneWay=�6G   5   	   �� 5       $ 
Horizontal=�6   .+�5!      �� $	��Id:��6   $��0,0,5,0q�6   �� 5"      $
��Wrap=�63   ��6   �� *Id+$ OneWay=�63   5#   	   �� 5$      $ 
Horizontal=�6   .+�5%      �� $��CanPair:��6   $��0,0,5,0q�6"   �� 5&      ��6   �� *	CanPair+$ OneWay=�5'   	   �� 5(      $ 
Horizontal=�6   .+�5)      �� $��	IsPaired:��6   $��0,0,5,0q�6#   �� 5*      ��6   �� *
IsPaired+$ OneWay=�5+   	   5,   	   5-      5.      5/      50      .��51      � $��5,8,0,0q�6
    � RowDefinitions 52      �� 53      $��* �6   �� 54      $
��Auto �6   .+�57      �� .+�58      �� $��Description:��6   �� 59      $
��Wrap=�6   $��0,0,0,10q�6$   GEBasic pairing allows you to tell Windows which device you want paired�� 5;      hfThis method can be used to pair devices like WiFiDirect, WSD, UPnP, Bluetooth or Bluetooth LE devices.5=      �� 5?      $��0,0,0,10q�6   $��Choose a device selector:��6!   �� 5@      -   5         ��Name$ selectorComboBox��5@      $��0,0,0,10q�5A      $
��Left=�5B      #��[  5C      � 5E       � Orientation$ 
Horizontal=�6   	 � 	ItemWidth$		 150��6(   .+�5F      �� -   5        
 ��Name$
 startWatcherButton��5F      $��1q�5G      $��Stretch=�5I      $��Stretch=�5J      .��5K      Start Watcher5M      �� 5N      -   5        $
 stopWatcherButton��5N      $��1q�5O      {�.  $��Stretch=�5R      $��Stretch=�5S      .��5T      Stop Watcher5V      �� 5W      -   5        $
 
pairButton��5W      $��1q�5X      {�.  $��Stretch=�5[      $��Stretch=�5\      .��5]      Pair Selected Device5_      �� 5`      -   5        $
 unpairButton��5`      $��1q�5a      {�.  $��Stretch=�5d      $��Stretch=�5e      .��5f      Unpair Selected Device5h      5i      5j      �� 5l      -   5         ��Name$ resultsListView��5l      
�������$��1q�6B   $��1��5m      $��20��5n      $��	0,10,0,60q�6"   $��Stretch=�5o      #��[ 5p      $	��450��5r      5w      5x      