   M S B A M L   `   `   `  ����P  LShoolProgram_Anayatov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ShoolProgram_Anayatov.PagesShoolProgram_Anayatov.Pages  5      /    )ShoolProgram_Anayatov.Pages.PageProviders   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ShoolProgram_Anayatov.Pages     5        N� Title$+  %Таблица поставщиков��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��421* �6   .+�5   
   �� -   5        $��	TxbSearch��5      
�������$'��!Поиск поставщиков��5      $��5,0,0,0q�5      $	��120��5      $
��Left=�5      $��Center=�5      $��30��6/   �� 5   
   -   5        $��	BtnSearch��5      $��75��5      $��
Поиск��5      $��	130,0,0,0q�5      $
��Left=�5      $��Center=�5       $��32��5!   )   �� 5#   
   -   5        $��BtnAdd��5%      $	��178��5#      $+��%Добавить поставщика��5$      $��	130,0,0,0q�5&      $��Right=�5'      $��Center=�5(      $��32��5)   &   &   System.Windows.Controls.DataGrid  5+   
   -   5        $��DataGridProviders��5-      $��0,0,0,45q�5,         AutoGenerateColumns .     
IsReadOnly . $��1��5/   '      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��55         Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 57      1  +System.Windows.Controls.DataGridBoundColumn   Binding 56      �� *id+57        59      $- 'Название предприятия��5:      $ * 5<       5;      �� *Name+5<        5>      $ 
Адрес��5@      $ * 5B       5A      �� *	Address+5B        5D      $ Телефон��5F      $ * 5H       5G      �� *	Telephone+5H        5J      $' !Статус поставщика��5L      $ * 5N       5M      �� *StatusProvider.Name+5N      4  .System.Windows.Controls.DataGridTemplateColumn  5P      $	 115 6)      CellTemplate 5Q      �� 5R      .R�5S      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5U   "   �� $��BtnShowInfoProviders��6)   -   5        $	��...��5X   %   
������ 
������ 
�������5[   %   �� 5^   "   $��BtnEditInfo��6)   -   5        
������ 
������ 
������ .��5d   &   �� $��./Resource/Gears.png��6,   5e   #   5g      5h      5j        5l      $ 75 6)    5m      �� 5n      .R�5o      �� .+�5p   "   �� $��	BtnDelete��6)   -   5        
������ 
������ $��X��5t   %   $
��Left=�5u   %   
���  ��5v   %   5x      5y      5{      5}      5~      5      