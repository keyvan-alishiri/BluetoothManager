   M S B A M L   `   `   `  ����   DeviceManagment%    DeviceManagment.Views.AboutView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -     � 	Resources     ComboBoxItemTemplate �� Path  ResultsListViewTemplate �� DataType � ColumnDefinitions �� Mode �� Orientation��%�  &	        &	 7     �� .R��� $��0,0,10,0q����� $ DisplayName��� $$ local:DeviceInformationDisplay��.R�� $��5q� �� $
��Auto ��� $��* �$	��100��.+��� $��0��$��40��$��40��$��5q�$	��Top=�._��� $��UniformToFill=����� *GlyphBitmapImage+$ OneWay=��� $��1��$��5q�._��� .+��� $ 
Horizontal=�.+��� $��Name:��$��0,0,5,0q��� $
��Bold"�$��WrapWithOverflow=����� *Name+$ OneWay=��� $ 
Horizontal=�.+��� $	��Id:��$��0,0,5,0q��� $
��Wrap=����� *Id+$ OneWay=��� $ 
Horizontal=�.+��� $��CanPair:��$��0,0,5,0q��� ���� *	CanPair+$ OneWay=��� $ 
Horizontal=�.+��� $��	IsPaired:��$��0,0,5,0q��� ���� *
IsPaired+$ OneWay=�.��� $��5,8,0,0q� � RowDefinitions �� $��* ��� $
��Auto �.+��� .+��� $��Description:���� $
��Wrap=�$��0,0,0,10q�GEBasic pairing allows you to tell Windows which device you want paired�� hfThis method can be used to pair devices like WiFiDirect, WSD, UPnP, Bluetooth or Bluetooth LE devices.�� $��0,0,0,10q�$��Choose a device selector:���� -    ��Name$ selectorComboBox��$��0,0,0,10q�$
��Left=�#��[  �  � Orientation$ 
Horizontal=�	 � 	ItemWidth$		 150��.+��� -   
 ��Name$
 startWatcherButton��$��1q�$��Stretch=�$��Stretch=�.��Start Watcher�� -   $
 stopWatcherButton��$��1q�{�.  $��Stretch=�$��Stretch=�.��Stop Watcher�� -   $
 
pairButton��$��1q�{�.  $��Stretch=�$��Stretch=�.��Pair Selected Device�� -   $
 unpairButton��$��1q�{�.  $��Stretch=�$��Stretch=�.��Unpair Selected Device�� -    ��Name$ resultsListView��
�������$��1q�$��1��$��20��$��	0,10,0,60q�$��Stretch=�#��[ $	��450��