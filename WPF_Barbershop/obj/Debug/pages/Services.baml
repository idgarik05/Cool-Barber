   M S B A M L   `   `   `  ����I  EWPF_Barbershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WPF_Barbershop.pagesWPF_Barbershop.pages  5      #    WPF_Barbershop.pages.Services   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:WPF_Barbershop.pages     5        N� 
Background  �#fddb6d N� Title$ Услуги��5	       � 	Resources 5         TextBox �� 
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
   � $��1��6    � ColumnDefinitions 52      �� 53      $��55 �6#   �� 54      $��60 �6#   �� 55      .+�58      �� $��1��6   $��Center=�6)   $��Center=�6F   .+�59      �� $��55��6   $��60��6$   $��/pictures/service.png��6/   5:      �� 5<      $��2��6   $
��Left=�6)   $��Center=�6D   .+�5=      �� $��Услуги��6   $��30(�6*   $��Arial)�68   $
��Bold"�6K   $��Italic$�6]    �� TextAlignment$ Center=�6p   $	��150��6�    �� Padding$ 2q�6�   5>      5@      � 5B   
   $��2��6    5D      �� 5E      $��10 �6    �� 5F      �� 5G      $��10 �6    .+�5J      � $��1��6    5L      �� 5M      $��25 �6'   �� 5N      $	��220 �6'   �� 5O      $��10 �6'   �� 5P      $	��110 �6'   �� 5Q      $��10 �6'   �� 5R      .+�5U      �� $��1��6    �� Orientation$ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5V      �� $
��🔎��6   $��25��6)   �� 5W      -   5        $ Search_Service��5W      #��[  67   $	��190��6�   $��25��6�   $��17(�6�   
���   �6�   5X      �� 5Z      $��3��6   $ 
Horizontal=�6-   $��Center=�6F   $��Center=�6c   .+�5[      �� -   5         ��Name$ AddServiceBtn��5[      $��Добавить��6P   $��25��6c   $	��100��6o   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5\      �� 5^      $��5��6   $ 
Horizontal=�6-   $
��Left=�6F   $��Center=�6a   .+�5_      �� -   5        $ DeleteServiceBtn��5_      $��Удалить��6V   $��25��6h   $	��100��6t   
���`���
�������
���   �$��2q�6�   $��Arial)�6�   $��17(�6�   $��Italic$�6�   5`      5b      5d      � 5f   
   $��3��6    5h      �� 5i      $��25 �6#   �� 5j      �� 5k      $��25 �6#   .+�5p      &   System.Windows.Controls.DataGrid  -   5          Name$ DG_Services��5p   '   $��1��6      AutoGenerateColumns .  $��Arial)�6X   $��20(�6k   $
��Bold"�6y      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      	RowHeight$ 50Q�6�      
IsReadOnly .    Columns 5q      4  .System.Windows.Controls.DataGridTemplateColumn  5r      ,  &System.Windows.Controls.DataGridColumn   Header$" Редактирование��6-      Width$
 auto 6E       CellTemplate  5s      �� 5t      .R�5u   "   �� -   5        $ ��Редактировать��5u   )   
��� ���
���   �
���   �$��2q�5y   )   5z   )   5{      5}      0  *System.Windows.Controls.DataGridTextColumn  5~      $ Название��6)   $ * 6U   1  +System.Windows.Controls.DataGridBoundColumn!   Binding! 6;   �� *Title+6U     5      $ Цена услуги��6)   ! 6>   �� *Price+5�      5�      5�      5�      