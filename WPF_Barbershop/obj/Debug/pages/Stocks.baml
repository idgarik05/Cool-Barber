   M S B A M L   `   `   `  ����I  EWPF_Barbershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_Barbershop.pagesWPF_Barbershop.pages  5      !    WPF_Barbershop.pages.Stocks   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_Barbershop.pages     5        N� 
Background  �#fddb6d N� Title$ 
Акции��5	       � 	Resources 5         TextBox �� 
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
   � $��1��6    � ColumnDefinitions 52      �� 53      $��55 �6#   �� 54      $��60 �6#   �� 55      .+�58      �� $��1��6   $��Center=�6)   $��Center=�6F   .+�59      �� $��55��6   $��60��6$   $��/pictures/sale.png��60   5:      �� 5<      $��2��6   $
��Left=�6)   $��Center=�6D   .+�5=      �� $��
Акции��6   $��30(�6)   $��Arial)�67   $
��Bold"�6J   $��Italic$�6\    �� TextAlignment$ Center=�6o   $	��150��6�    �� Padding$ 2q�6�   5>      5@      � 5B   
   $��2��6    5D      �� 5E      $��10 �6    �� 5F      �� 5G      $��10 �6    .+�5J      � $��1��6    5L      �� 5M      $��25 �6'   �� 5N      $	��220 �6'   �� 5O      $��10 �6'   �� 5P      $	��110 �6'   �� 5Q      $��10 �6'   �� 5R      .+�5U      �� $��1��6    �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5V      �� $
��🔎��6   $��25��6)   �� 5W      -   5        $ Search_Stock��5W      #��[  6\   $	��190��6�   $��25��6�   $��17(�6�   
���   �6�   5X      �� 5Z      $��3��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5[      �� -   5         ��Name$ AddStockBtn��5[      $��Добавить��6L   $��25��6_   $	��100��6k   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5\      �� 5^      $��5��6   $ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5_      �� -   5        $ DeleteStockBtn��5_      $��Удалить��6R   $��25��6d   $	��100��6p   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5`      5b      5d      � 5f   
   $��3��6    5h      �� 5i      $��25 �6#   �� 5j      �� 5k      $��25 �6#   .+�5n      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DG_Stocks��5n   '   $��1��6   $��Arial)�6:   $��20(�6M   $
��Bold"�6[      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6m      	RowHeight$ 50Q�6}      
IsReadOnly .    AutoGenerateColumns .     Columns 5o      4  .System.Windows.Controls.DataGridTemplateColumn  5p      ,  &System.Windows.Controls.DataGridColumn   Width$
 auto 6-      Header$" Редактирование��6:       CellTemplate  5q      �� 5r      .R�5s   "   �� $ EditBtn��6)   -   5        
��� ���
���   �
���   �$ ��Редактировать��5s   �   5t      5v      0  *System.Windows.Controls.DataGridTextColumn  5w      $ Наименование��6)   $ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6?   �� *Title+6Y     5x      $ Размер скидки��6)   $ * 6b   ! 6@   �� *Discount_size+6b     5y      $ Дата начала��6)   $ * 6}   ! 6>   �� *Start_date_+" �� StringFormat$" {0:dd.MM.yyyy}��6}     5z      $! Дата окончания��6)   $ * 6~   ! 6A   �� *	End_date_+$" {0:dd.MM.yyyy}��6~   5|      5}      5      5�      