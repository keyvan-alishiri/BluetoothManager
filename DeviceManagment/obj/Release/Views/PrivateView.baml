   M S B A M L   `   `   `  ���� J  FDeviceManagment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DeviceManagmentDeviceManagment  '    !DeviceManagment.Views.PrivateView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:DeviceManagment     -     � 	Resources      SelectorComboBoxItemTemplate �� DataType ' #ProtectionLevelComboBoxItemTemplate  ResultsListViewTemplate � ColumnDefinitions �� Mode �� Orientation��%v  &	        &	 T     &	 �     �� $ local:DeviceSelectorInfo��.R��� $��0,0,10,0q����� *DisplayName+�� $' !local:ProtectionLevelSelectorInfo��.R��� $��0,0,10,0q����� *DisplayName+�� $$ local:DeviceInformationDisplay��.R�� $��5q� �� $
��Auto ��� $��* �$	��100��.+��� $��0��$��40��$��40��$��5q�$	��Top=�._��� $��UniformToFill=����� *GlyphBitmapImage+$ OneWay=��� $��1��$��5q�._��� .+��� $ 
Horizontal=�.+��� $��Name:��$��0,0,5,0q��� $
��Bold"�$��WrapWithOverflow=����� *Name+$ OneWay=��� $ 
Horizontal=�.+��� $	��Id:��$��0,0,5,0q��� $
��Wrap=����� *Id+$ OneWay=��� $ 
Horizontal=�.+��� $��CanPair:��$��0,0,5,0q��� ���� *	CanPair+$ OneWay=��� $ 
Horizontal=�.+��� $��	IsPaired:��$��0,0,5,0q��� ���� *
IsPaired+$ OneWay=�.��� $��5,8,0,0q� � RowDefinitions �� $
��Auto ��� $��* �.+��� .+��� $��Description:���� $
��Wrap=�$��0,0,0,10q���Custom pairing allows your app to be involved in the pairing ceremony and use your own UI. If you want Windows to control the ceremony and display system UI, please look at the basic pairing .�� �� -    ��Name$ selectorComboBox��$��0,0,0,5q�$
��Left=�$	��120��#��[  �� $��0,0,0,2q�$*��$Select supported pairing ceremonies:���  � Orientation$ 
Horizontal=� � 	ItemWidth$	 150��$��	0,10,0,10q�.+��� -   	 ��Name$	 confirmOnlyOption��$��ConfirmOnly��
 d� 	IsChecked$

 TrueY��� -   $	 displayPinOption��$��
DisplayPin��$

 TrueY��� -   $	 providePinOption��$��
ProvidePin��$

 TrueY��� -   $	 confirmPinMatchOption��$��ConfirmPinMatch��$

 TrueY��� -   $	 passwordCredentialOption��$��
Credential��$

 TrueY��� -   $ protectionLevelComboBox��$	��120��$��0,0,0,10q�$
��Left=�#��[ � $ 
Horizontal=�$	 150��.+��� -	    ��Name$ startWatcherButton��$��1q�$��Start Watcher��$��Stretch=�$��Stretch=��� -
   $ stopWatcherButton��$��1q�$��Stop Watcher��{�.  $��Stretch=�$��Stretch=��� -   $ 
pairButton��$��1q�$��Pair Selected Device��{�.  $��Stretch=�$��Stretch=��� -   $ unpairButton��$��1q�$��Unpair Selected Device��{�.  $��Stretch=�$��Stretch=��� -    ��Name$ pairingPanel��$��1q�
��� ���$��0,0,0,5q�$y�	Collapsed=�._��� $ Vertical=�.+��� -    ��Name$ pairingTextBlock��$��0,0,0,2q�$��WrapWithOverflow=��� $ 
Horizontal=�.+��� -    ��Name$ pinEntryTextBox��$	��100��$��2q�$y�	Collapsed=��� -   $ okButton��$��75��$��2q�$y�	Collapsed=�.��OK�� -   $ usernameEntryTextBox��$	��100��$��2q�$y�	Collapsed=��� -   $ passwordEntryTextBox��$	��100��$��2q�$y�	Collapsed=��� -   $ verifyButton��$��75��$��2q�$y�	Collapsed=�.��Verify�� -   $ 	yesButton��$��75��$��2q�$y�	Collapsed=�.��Yes�� -   $ noButton��$��75��$��2q�$y�	Collapsed=�.��No�� -    ��Name$ resultsListView��
�������$��1q�$��1��$��20��$��0,10,0,0q�#��[ $	��450��