   M S B A M L   `   `   `  ����J  FDeviceManagment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DeviceManagmentDeviceManagment  5      -    'DeviceManagment.Views.CustomPairingView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DeviceManagment     5      -   5          � 	Resources  5          SelectorComboBoxItemTemplate �� DataType ' #ProtectionLevelComboBoxItemTemplate  ResultsListViewTemplate � ColumnDefinitions �� Mode �� Orientation��%�  &	        &	 ~     &	     �� 5      $ local:DeviceSelectorInfo��67   .R�5      �� $��0,0,10,0q�6   ��6!   �� *DisplayName+5      �� 5      $' !local:ProtectionLevelSelectorInfo��6>   .R�5      �� $��0,0,10,0q�6   ��6!   �� *DisplayName+5      �� 5      $$ local:DeviceInformationDisplay��62   .R�5      � $��5q�6
    5      �� 5      $
��Auto �6   �� 5      $��* �6   $	��100��6#   .+�5      �� $��0��6   $��40��6   $��40��6(   $��5q�63   $	��Top=�6>   ._�5      �� $��UniformToFill=�5      ��5      �� *GlyphBitmapImage+$ OneWay=�5      5       �� 5!      $��1��6   $��5q�6   ._�5"      �� .+�5#      �� $ 
Horizontal=�6   .+�5$      �� $��Name:��6   $��0,0,5,0q�6   �� 5%      $
��Bold"�65   $��WrapWithOverflow=�6G   ��6   �� *Name+$ OneWay=�6G   5&   	   �� 5'      $ 
Horizontal=�6   .+�5(      �� $	��Id:��6   $��0,0,5,0q�6   �� 5)      $
��Wrap=�63   ��6   �� *Id+$ OneWay=�63   5*   	   �� 5+      $ 
Horizontal=�6   .+�5,      �� $��CanPair:��6   $��0,0,5,0q�6"   �� 5-      ��6   �� *	CanPair+$ OneWay=�5.   	   �� 5/      $ 
Horizontal=�6   .+�50      �� $��	IsPaired:��6   $��0,0,5,0q�6#   �� 51      ��6   �� *
IsPaired+$ OneWay=�52   	   53   	   54      55      56      57      .��58      � $��5,8,0,0q�6
    � RowDefinitions 59      �� 5:      $
��Auto �6   �� 5;      $��* �6   .+�5>      �� .+�5?      �� $��Description:��6   �� 5@      $
��Wrap=�6   $��0,0,0,10q�6$   ��Custom pairing allows your app to be involved in the pairing ceremony and use your own UI. If you want Windows to control the ceremony and display system UI, please look at the basic pairing .�� 5C      5E      �� 5G      -   5         ��Name$ selectorComboBox��5G      $��0,0,0,5q�5H      $
��Left=�5I      $	��120��5J      #��[  5L      �� 5M      $��0,0,0,2q�6   $*��$Select supported pairing ceremonies:��6    � 5N       � Orientation$ 
Horizontal=�6    � 	ItemWidth$	 150��6(   $��	0,10,0,10q�68   .+�5O      �� -   5        	 ��Name$	 confirmOnlyOption��5O      $��ConfirmOnly��6)   
 d� 	IsChecked$

 TrueY�6?   �� 5P      -   5        $	 displayPinOption��5P      $��
DisplayPin��6(   $

 TrueY�6=   �� 5Q      -   5        $	 providePinOption��5Q      $��
ProvidePin��6(   $

 TrueY�6=   �� 5R      -   5        $	 confirmPinMatchOption��5R      $��ConfirmPinMatch��6-   $

 TrueY�6G   �� 5S      -   5        $	 passwordCredentialOption��5S      $��
Credential��60   $

 TrueY�6E   5T      �� 5U      -   5        $ protectionLevelComboBox��5U      $	��120��5V      $��0,0,0,10q�5W      $
��Left=�5X      #��[ 5Z      � 5[      $ 
Horizontal=�6   $	 150��6(   .+�5\      �� -	   5         ��Name$ startWatcherButton��5\      $��1q�5]      $��Start Watcher��5^      $��Stretch=�5`      $��Stretch=�5a      �� 5c      -
   5        $ stopWatcherButton��5c      $��1q�5d      $��Stop Watcher��5e      {�.  $��Stretch=�5h      $��Stretch=�5i      �� 5k      -   5        $ 
pairButton��5k      $��1q�5l      $��Pair Selected Device��5m      {�.  $��Stretch=�5p      $��Stretch=�5q      �� 5s      -   5        $ unpairButton��5s      $��1q�5t      $��Unpair Selected Device��5u      {�.  $��Stretch=�5x      $��Stretch=�5y      5{      �� 5}      -   5         ��Name$ pairingPanel��5}      $��1q�6"   
��� ���$��0,0,0,5q�6K   $y�	Collapsed=�6\   ._�5~      �� $ Vertical=�6   .+�5      �� -   5         ��Name$ pairingTextBlock��5      $��0,0,0,2q�6,   $��WrapWithOverflow=�6=   �� 5�      $ 
Horizontal=�6   .+�5�      �� -   5         ��Name$ pinEntryTextBox��5�      $	��100��6)   $��2q�68   $y�	Collapsed=�6C   �� 5�      -   5        $ okButton��5�      $��75��6!   $��2q�6/   $y�	Collapsed=�6Q   .��6h   OK6l   �� 5�      -   5        $ usernameEntryTextBox��5�      $	��100��6.   $��2q�6=   $y�	Collapsed=�6H   �� 5�      -   5        $ passwordEntryTextBox��5�      $	��100��6.   $��2q�6=   $y�	Collapsed=�6H   �� 5�      -   5        $ verifyButton��5�      $��75��6%   $��2q�63   $y�	Collapsed=�6Y   .��6p   Verify6x   �� 5�      -   5        $ 	yesButton��5�      $��75��6"   $��2q�60   $y�	Collapsed=�6S   .��6j   Yes6o   �� 5�      -   5        $ noButton��5�      $��75��6!   $��2q�6/   $y�	Collapsed=�6Q   .��6h   No6l   5�   	   5�      5�      5�      �� 5�      -   5         ��Name$ resultsListView��5�      
�������$��1q�6B   $��1��5�      $��20��5�      $��0,10,0,0q�6"   #��[ 5�      $	��450��5�      5�      5�      