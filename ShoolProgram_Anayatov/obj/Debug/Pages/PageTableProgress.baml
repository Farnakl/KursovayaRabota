   M S B A M L   `   `   `  ����P  LShoolProgram_Anayatov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ShoolProgram_Anayatov.PagesShoolProgram_Anayatov.Pages  5      3    -ShoolProgram_Anayatov.Pages.PageTableProgress   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ShoolProgram_Anayatov.Pages     5        N� Title$%  История операций��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��409* �6   .+�5   
   �� -   5        $��	TxbSearch��5      
�������$'��!Поиск сотрудников��5      $��5,0,0,0q�5      $	��120��5      $
��Left=�5      $��Center=�5      $��30��6/   �� 5   
   -   5        $��	BtnSearch��5      $��75��5      $��
Поиск��5      $��	130,0,0,0q�5      $
��Left=�5      $��Center=�5       $��32��5!   )   �� 5#   
   -   5        $��BtnAdd��5%      $	��159��5#      $%��Добавить продажу��5$      $��	130,0,0,0q�5&      $��Right=�5'      $��Center=�5(      $��32��5)   &   &   System.Windows.Controls.DataGrid  5+   
   -   5        $��DataGridOperation��5-      $��1��5+      $��0,0,0,45q�5,         AutoGenerateColumns .     
IsReadOnly .    Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��55         Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 57      1  +System.Windows.Controls.DataGridBoundColumn   Binding 56      �� *id+57        59      $ Продукты��5:      $ * 5<       5;      �� *Product.NameProduct+5<        5>      $ Количество��5@      $ * 5B       5A      �� *
Quantity+5B        5D      $ Дата продажи��5F      $ * 5H       5G      �� *
DateOfsale+5H        5J      $ Сотрудник ��5L      $ * 5N       5M      �� *Employees.Name+5N      4  .System.Windows.Controls.DataGridTemplateColumn  5O      $	 120 6)      CellTemplate 5P      �� 5Q      .R�5R      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5T   "   �� $��BtnEditInfo��6)   -   5        
������ 
������ 
������ .��5Y   &   �� $��./Resource/Gears.png��6,   5Z   #   �� 5\   "   $��	BtnDelete��6)   -   5        
������ 
������ $��X��5`   %   
���  ��5a   %   5c      5d      5f      5h      5i      5j      