   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp7.SemFoldWpfApp7.SemFold  5          WpfApp7.SemFold.SemPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp7.SemFold     5      -   5          N� Title$  SemPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��14* �6   �� 5      $
��119* �6   �� 5      $	��17* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridSem��5   A      AutoGenerateColumns .     
IsReadOnly . $��95,33,104,36q�6V   $��1��6l      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Семестер��6E      MinWidth$	 130Q�6W   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6f   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *ID_Semester+6f     5      $ Год��6G   $	 100Q�6T   $	 * 6c   -   5        YearSem��
 5   %   �� *Semester_Year+6m   5      �� 5   
   $��2��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5      �� -   5         ��Name$ EditSem��5   (   $��Изменить��6   $��30��69   $	��150��6E   $��0 0 10 0q�6g   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5        $
 Back��5   H   $��0��6   $	��150��6"   $#��Вернуться назад��6.   $��30��6V   6b   5      5      5      