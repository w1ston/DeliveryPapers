   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfApp7.DisciplineFoldWpfApp7.DisciplineFold  5      +    %WpfApp7.DisciplineFold.DisciplinePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WpfApp7.DisciplineFold     5      -   5          N� Title$  DisciplinePage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��14* �6   �� 5      $
��119* �6   �� 5      $	��17* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridDiscip��5   A      AutoGenerateColumns .     
IsReadOnly . $��1��6Y   $	��300��6f   $	��500��6s      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$+ %Название дисциплины��6I      MinWidth$	 130Q�6f   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6u   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Name_Discipline+6u   5      �� 5   
   $��2��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5      �� -   5         ��Name$ 	AddDiscip��5   4   $	��150��6   $��Добавить��6!   $��30��6G   $��0 0 10 0q�6k   �� 5      -   5        $ 
EditDiscip��5   (   $��Изменить��6   $��30��6<   $	��150��6H   $��0 0 10 0q�6m   �� 5      -   5        $ 	DelDiscip��5   3   $	��150��6   $��Удалить��6!   $��30��6F   6R   5      �� 5   
   $��0��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5        $ SearchDiscip��5   1   $	��150��6   $��
Поиск��6!   $��30��6G   $��0 0 10 0q�6n   5      5      5      