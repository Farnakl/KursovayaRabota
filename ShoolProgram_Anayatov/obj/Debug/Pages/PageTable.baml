   M S B A M L   `   `   `  ����P  LShoolProgram_Anayatov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:ShoolProgram_Anayatov.PagesShoolProgram_Anayatov.Pages  5      +    %ShoolProgram_Anayatov.Pages.PageTable   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:ShoolProgram_Anayatov.Pages     5      -   5          N� Title$'  !Таблица Продуктов��5
      .��5      �  � RowDefinitions 5   
   �� 5      $	��41* �6   �� 5      $
��421* �6   .+�5   
   �� -   5        $��	TxbSearch��5      
�������$#��Поиск продуктов��5      $��5,0,0,0q�5      $	��120��5      $
��Left=�5      $��Center=�5      $��30��6/   �� 5   
   -   5        $��	BtnSearch��5      $��75��5      $��
Поиск��5      $��	130,0,0,0q�5      $
��Left=�5      $��Center=�5       $��32��5!   )   �� 5#   
   -   5        $��BtnAdd��5%      $	��159��5#      $%��Добавить продукт��5$      $��	130,0,0,0q�5&      $��Right=�5'      $��Center=�5(      $��32��5)   &   &   System.Windows.Controls.DataGrid  5,   
   -   5        $��DataGridProduct��5.      $��1��5,      $��0,0,0,45q�5-         AutoGenerateColumns .     
IsReadOnly .    Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��56         Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 58      1  +System.Windows.Controls.DataGridBoundColumn   Binding 57      �� *id+58        5:      $ Продукты��5;      $ * 5=       5<      �� *NameProduct+5=        5?      $ Поставщик��5A      $ * 5C       5B      �� *Provider.Name+5C        5E      $ Тип продукта��5G      $ * 5I       5H      �� *TypeOfProduct.NameType+5I        5K      $ Количество��5M      $ * 5O       5N      �� *PurchaseVolume+5O        5Q      $' !Единица измерения��5S      $ * 5U       5T      �� *Unit.NameUnit+5U        5W      $ Цена��5Y      $ * 5[       5Z      �� *PurchasePrice+5[        5]      $ Статус��5_      $ * 5a       5`      �� *StatusProduct.NameStatus+5a      4  .System.Windows.Controls.DataGridTemplateColumn  5c      $	 120 6)      CellTemplate 5d      �� 5e      .R�5f      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5h   "   �� $��BtnEditInfo��6)   -   5        
������ 
������ 
������ .��5m   &   �� $��./Resource/Gears.png��6,   5n   #   �� 5p   "   $��
BtnDelete1��6)   -   5        
������ 
������ $��X��5t   %   
���  ��5u   %   5w      5x      5z      5|      5}      5~      