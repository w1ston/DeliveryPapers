   M S B A M L   `   `   `  ����  WpfApp7!    WpfApp7.ThemeFold.ThemePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  	ThemePage��5      $	��550��6   $	��800��6)    N� 
Background
 �����.��5
      � .+�5   
   �� -   5        $��ComboDiscip��5      $	��150��6&   $��20��62   $��	0 0 0 500q�6>    �� DisplayMemberPath$ Name_Discipline��6Q   6u   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridTheme��5   A      AutoGenerateColumns .     
IsReadOnly . $��85,40,114,153q�6X      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название темы��6D      MinWidth$	 130Q�6[   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6j   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *
Name_Theme+6j     5      $+ %Название дисциплины��6T   $	 100Q�6q   $	 * 6�   -   5        DisciplineName��
 5   %   �� *Discipline.Name_Discipline+6�   5      �� 5   
   $��-14,397,14,75q�6    �� Orientation$ 
Horizontal=�6,   $��Center=�6E   $��40��6b   .+�5      �� -   5        $��AddTheme��5   -   $��Добавить тему��6   $��0 0 10 0q�6T   $	��100��6f   �� 5      -   5        $��BtnDel��5   ,   $��Удалить тему��6   $��0 0 10 0q�6O   $	��100��6a   �� 5      -   5        $��BtnEdit��5   2   $)��#Редактировать тему��6   $��0 0 10 0q�6W   $	��130��6i   �� 5      -   5        $��	BtnSearch��5   *   $��Поиск темы��6   $	��100��6S   5      5      5      