   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp7.StudentWpfApp7.Student  5      !    WpfApp7.Group.GroupEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp7.Student     5      -   5          N� Title$  GroupEditPage��5	      $	��450��6   $	��800��6-   $	��450��6<   $	��800��6L    N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��14* �6   �� 5      $
��119* �6   �� 5      $	��17* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridGroups��5   A      AutoGenerateColumns .     
IsReadOnly . $��95,33,104,36q�6Y   $��1��6o      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$# Название группы��6D      MinWidth$	 130Q�6]   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6l   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *
Name_Group+6l     5      $  Специальность��6V   $	 100Q�6m   $	 * 6|   -   5        SpecialG��
 5   %   �� *Specialties.Name_Specialties+6�   5      �� 5   
   $��2��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5      �� -   5         ��Name$ AddGroup��5   4   $	��150��6   $��Добавить��6!   $��30��6F   $��0 0 10 0q�6i   �� 5      -   5        $ 	EditGroup��5   (   $��Изменить��6   $��30��6;   $	��150��6G   $��0 0 10 0q�6k   �� 5      -   5        $ DelGroup��5   3   $	��150��6   $��Удалить��6!   $��30��6E   6Q   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5        $ SearchGroup��5   >   $��0��6   $	��150��6"   $��
Поиск��6.   $��30��6S   $��0 0 10 0q�6y   �� 5      -   5        $
 Back��5   H   $��0��6   $	��150��6"   $#��Вернуться назад��6.   $��30��6V   $��0 0 10 0q�6u   �� 5      -	   5        $ GoSpec��5   X   $��0��6   $	��200��6"   $A��;Перейти к списку специальностей��6.   $��30��6h   6t   5       5!      5"      