   M S B A M L   `   `   `  ����I  EWPF_Barbershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_Barbershop.pagesWPF_Barbershop.pages  5      "    WPF_Barbershop.pages.Records   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_Barbershop.pages     5        N� 
Background  �#fddb6d N� Title$ Записи��5	       � 	Resources 5         TextBox �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� RelativeSource	 �� Mode
 ��Name �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        �� 5   
   " ��6    .�5      ��  � �� 5      �� 5      " ��6#   .R�5      � .+�5      �� $ TextContent��6#   #��z��6�   #��z��6�   #��z��6�   ��68   �� *Text+ �� *TemplatedParent+$	 TwoWay=�6�   �� 5      $
 Placeholder��6�   $��
Поиск��6%   
�������$y�	Collapsed=�6D   $��5,0,0,0q�6[   $��Center=�6l   6�   5       5      ]� 5       5      �� 5   #    � ��$  ��6=   �� 5   #    �@J�IsKeyboardFocusWithin .  6N   ./�5      �� $ Placeholder��6&    � y�$ Visible=�6U   5      P� 5       � {� .  . �5      �� $ TextContent��6&    � ��
 �����6U   5      5       5"      5#      5$      .��5&      �  � RowDefinitions 5(   
   �� 5*      $��15 �6   �� 5+      $��65 �6   �� 5,      $��70 �6   �� 5-      $	��300 �6   �� 5.      .+�52   
   � $��1��6    � ColumnDefinitions 54      �� 55      $��55 �6#   �� 56      $��60 �6#   �� 57      .+�5:      �� $��1��6   $��Center=�6)   $��Center=�6F   .+�5;      �� $��55��6   $��60��6$   $��/pictures/Record.png��60   5<      �� 5>      $��2��6   $
��Left=�6)   $��Center=�6D   .+�5?      �� $��Записи��6   $��30(�6*   $��Arial)�68   $
��Bold"�6K   $��Italic$�6]    �� TextAlignment$ Center=�6p   $	��150��6�    �� Padding$ 2q�6�   5@      5B      � 5D   
   $��2��6    5F      �� 5G      $��10 �6    �� 5H      �� 5I      $��10 �6    .+�5L      � $��1��6    5N      �� 5O      $��25 �6'   �� 5P      $	��220 �6'   �� 5Q      $��10 �6'   �� 5R      $	��110 �6'   �� 5S      $��10 �6'   �� 5T      .+�5W      �� $��1��6    �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5X      �� $
��🔎��6   $��25��6)   �� 5Y      -   5        $ Search_Records��5Y      #��[  67   $	��190��6d   $��25��6p   $��17(�6|   
���   �6�   5Z      �� 5\      $��3��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5]      �� -   5         ��Name$ AddRecordBtn��5]      $��Добавить��6N   $��25��6a   $	��100��6m   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5^      �� 5`      $��5��6   $ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5a      �� -   5        $ DeleteRecordBtn��5a      $��Удалить��6T   $��25��6f   $	��100��6r   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5b      5d      5f      � 5h   
   $��3��6    5j      �� 5k      $��25 �6#   �� 5l      �� 5m      $��25 �6#   .+�5p      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DG_Records��5p   '   $��1��6   $��Arial)�6;   $��20(�6N   $
��Bold"�6\      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6n      	RowHeight$ 50Q�6~      
IsReadOnly .    AutoGenerateColumns . 6�   5r      5t      5u      