   M S B A M L   `   `   `  ����I  EWPF_Barbershop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WPF_Barbershop.windowsWPF_Barbershop.windows  5   	   )    #WPF_Barbershop.windows.RecordBarber   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WPF_Barbershop.windows     5   	     � Title$  Записи��5   	   $	��450��6   $	��450��6%    � Icon$ /pictures/logo.png��61   ���#fddb6d.��5	      �  � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $	��100 �6   �� 5      $��35 �6   �� 5      $��45 �6   �� 5      $	��180 �6   .+�5   
   � $��1��6    � ColumnDefinitions 5      �� 5      $��25 �6#   �� 5      $	��110 �6#   �� 5      .+�5      �� $��1��6   $��Center=�6)   $��Center=�6F   .+�5      �� $��/pictures/logo.png��6   $	��100��64   $	��100��6A   5      �� 5      $��2��6    �� Orientation$ 
Horizontal=�6)   $
��Left=�6B   $��Center=�6]   .+�5      �� $��/pictures/Barber.png��6   $��35��66   $��35��6B   �� 5       -   5         ��Name$ Barber_name��5       $��25��6-   $��15(�69   $��Arial)�6G   $
��auto��6Z   5!      5"      � 5$   
   $��2��6   .+�5%      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5&      �� $��Записи��6   $��21(�6+   $��Arial)�69   $��SemiBold"�6L   5'      5(      � 5*   
   $��3��6   .+�5+      �� $ 
Horizontal=�6   $��Center=�62   $��Center=�6O   .+�5,      �� $ ��Выберите дату:��6   $��Center=�62   $��15(�6M   $��Arial)�6[   $��SemiBold"�6n   �� 5-      (  "System.Windows.Controls.DatePicker  5.      -   5          Name$ 
DateFilter��5.      $	��130��6f   �� 5/      �� 50      -   5         ��Name$ ClearFilterBtn��50      $��Очистить��61   
���`���$��Arial)�6y   $��80��6�   $��14(�6�   
�������
���   �$��2q�6�   51      52      � 54   
   $��4��6   .+�55      &   System.Windows.Controls.DataGrid  -   5          Name$ DG_RecordsBarber��55      $	��400��61   $��Arial)�6=   $��14(�6P   $
��Bold"�6^   	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * 6p   
   	RowHeight$
 30Q�6�      
IsReadOnly .    AutoGenerateColumns .     Columns 56      0  *System.Windows.Controls.DataGridTextColumn  57      ,  &System.Windows.Controls.DataGridColumn   Header$ Клиент��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	Surname+  58      $ Дата��6)    67   �� *Date_+ �� StringFormat$ {0:dd.MM.yyyy}��  59      $ 
Время��6)    68   �� *Time_+5;      5<      5>      5?      