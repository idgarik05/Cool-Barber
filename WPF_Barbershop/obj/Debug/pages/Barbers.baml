   M S B A M L   `   `   `  ����I  EWPF_Barbershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_Barbershop.pagesWPF_Barbershop.pages  5      "    WPF_Barbershop.pages.Barbers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_Barbershop.pages     5        N� 
Background  �#fddb6d N� Title$ Барберы��5	       � 	Resources 5         TextBox �� 
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
   � $��1��6    � ColumnDefinitions 52      �� 53      $��55 �6#   �� 54      $��60 �6#   �� 55      .+�58      �� $��1��6   $��Center=�6)   $��Center=�6F   .+�59      �� $��55��6   $��60��6$   $��/pictures/Barber.png��6/   5:      �� 5<      $��2��6   $
��Left=�6)   $��Center=�6D   .+�5=      �� $��Барберы��6   $��30(�6+   $��Arial)�69   $
��Bold"�6L   $��Italic$�6^    �� TextAlignment$ Center=�6q   $	��150��6�    �� Padding$ 2q�6�   5>      5@      � 5B   
   $��2��6    5D      �� 5E      $��10 �6    �� 5F      �� 5G      $��10 �6    .+�5J      � $��1��6    5L      �� 5M      $��25 �6'   �� 5N      $	��220 �6'   �� 5O      $��10 �6'   �� 5P      $	��110 �6'   �� 5Q      $��10 �6'   �� 5R      .+�5U      �� $��1��6    �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5V      �� $
��🔎��6   $��25��6)   �� 5W      -   5        $ Search_Barber��5W      #��[  66   $	��190��6�   $��25��6�   $��17(�6�   
���   �6�   5Y      �� 5[      $��3��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5\      �� -   5         ��Name$ AddBarberBtn��5\      $��Добавить��6N   $��25��6a   $	��100��6m   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5]      �� 5_      $��5��6   $ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5`      �� -   5        $ DeleteBarberBtn��5`      $��Удалить��6T   $��25��6f   $	��100��6r   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5a      5c      5e      � 5g   
   $��3��6    5i      �� 5j      $��25 �6#   �� 5k      �� 5l      $��25 �6#   .+�5o      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DG_Barbers��5o   (   $��1��6   $��Arial)�6<   $��20(�6O   $
��Bold"�6]      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6o      	RowHeight$ 70Q�6      AutoGenerateColumns .    
IsReadOnly . 6�   5p      5r      5s      