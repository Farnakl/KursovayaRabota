   M S B A M L   `   `   `  ����P  LShoolProgram_Anayatov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ShoolProgram_Anayatov.PagesShoolProgram_Anayatov.Pages  5      3    -ShoolProgram_Anayatov.Pages.PageTableTeachers   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ShoolProgram_Anayatov.Pages     5        N� Title$+  %Таблица сотрудников��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��421* �6   .+�5   
   �� -   5        $��	TxbSearch��5      
�������$'��!Поиск сотрудников��5      $��5,0,0,0q�5      $	��120��5      $
��Left=�5      $��Center=�5      $��30��6/   �� 5   
   -   5        $��	BtnSearch��5      $��75��5      $��
Поиск��5      $��	130,0,0,0q�5      $
��Left=�5      $��Center=�5      $��32��5    )   �� 5"   
   -   5        $��BtnAdd��5$      $	��180��5"      $+��%Добавить сотрудника��5#      $��	130,0,0,0q�5&      $��Right=�5'      $��Center=�5(      $��32��5)   &   &   System.Windows.Controls.DataGrid  5+   
   -   5        $��DataGridEmployees��5-      $��0,0,0,45q�5,         AutoGenerateColumns .     
IsReadOnly . $��1��5/         Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��54         Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 56      1  +System.Windows.Controls.DataGridBoundColumn   Binding 55      �� *id+56        58      $ Должность��59      $ * 5;       5:      �� *JobTitle.Name+5;        5=      $ ФИО��5?      $ * 5A       5@      �� *Name+5A        5C      $ Дата Рождения��5E      $ * 5G       5F      �� *DateOfBirth+5G        5I      $ Телефон��5K      $ * 5M       5L      �� *	Telephone+5M      4  .System.Windows.Controls.DataGridTemplateColumn  5O      $	 120 6)      CellTemplate 5P      �� 5Q      .R�5R      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5S   "   �� $��BtnShowInfo��6)   -   5        $	��...��5U   %   
������ 
������ 
�������5X   %   �� 5[   "   $��BtnEditInfo��6)   -   5        
������ 
������ 
������ .��5`   &   �� $��./Resource/Gears.png��6,   5a   #   5c      5d      5f        5h      $ 75 6)    5i      �� 5j      .R�5k      �� .+�5l   "   �� $��	BtnDelete��6)   -   5        
������ 
������ $��X��5p   %   
���  ��5q   %   5s      5t      5v      5x      5y      5z      