   M S B A M L   `   `   `  ����I  EWPF_Barbershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_Barbershop.pagesWPF_Barbershop.pages  5      "    WPF_Barbershop.pages.Clients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_Barbershop.pages     5        N� 
Background  �#fddb6d N� Title$ Клиенты��5	       � 	Resources 5         TextBox �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� RelativeSource	 �� Mode
 ��Name �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        �� 5   
   " ��6    .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� $ TextContent��6&   #��z��6�   #��z��6�   #��z��6�   ��6;   �� *Text+ �� *TemplatedParent+$	 TwoWay=�6�   �� 5      $
 Placeholder��6�   $��
Поиск��6(   
�������$y�	Collapsed=�6G   $��5,0,0,0q�6^   $��Center=�6o   6�   5       5      ]� 5       5   "   �� 5   &    � ��$  ��6@   �� 5   &    �@J�IsKeyboardFocusWithin .  6Q   ./�5   "   �� $ Placeholder��6)    � y�$ Visible=�6X   5      P� 5       � {� .  . �5   "   �� $ TextContent��6)    � ��
 �����6X   5      5       5"      5#      5$      .��5&      �  � RowDefinitions 5(   
   �� 5)      $��15 �6   �� 5*      $��65 �6   �� 5+      $��60 �6   �� 5,      $	��300 �6   �� 5-      .+�50   
   � $��1��6    � ColumnDefinitions 52      �� 53      $��55 �6#   �� 54      $��60 �6#   �� 55      .+�58      �� $��1��6   $��Center=�6)   $��Center=�6F   .+�59      �� $��55��6   $��60��6$   $��/pictures/pers_icon_2.png��6/   5:      �� 5<      $��2��6   $
��Left=�6)   $��Center=�6D   .+�5=      �� $��Клиенты��6   $��30(�6+   $��Arial)�69   $
��Bold"�6L   $��Italic$�6^    �� TextAlignment$ Center=�6q   $	��150��6�    �� Padding$ 2q�6�   5>      5@      � 5B   
   $��2��6    5D      �� 5E      $��10 �6    �� 5F      �� 5G      $��10 �6    .+�5J      � $��1��6    5L      �� 5M      $��25 �6'   �� 5N      $	��220 �6'   �� 5O      $��10 �6'   �� 5P      $	��110 �6'   �� 5Q      $��10 �6'   �� 5R      .+�5U      �� $��1��6    �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5V      �� $
��🔎��6   $��25��6)   �� 5W      -   5        $ Search_Client��5W      #��[  66   $	��190��6�   $��25��6�   $��17(�6�   
���   �6�   5X      �� 5Z      $��3��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5[      �� -   5         ��Name$ AddClientBtn��5[      $��Добавить��6N   $��25��6a   $	��100��6m   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5\      5^      5`      � 5b   
   $��3��6    5d      �� 5e      $��25 �6#   �� 5f      �� 5g      $��25 �6#   .+�5j      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DG_Clients��5j   (   $��1��6   $��Arial)�6<   $��20(�6O   $
��Bold"�6]      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6o      	RowHeight$ 70Q�6      
IsReadOnly . 6�   5k      5m      5n      