   M S B A M L   `   `   `  ����  WpfApp7"    WpfApp7.Student.StudentsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5          N� Title$  StudentsPage��5       N� 
Background
 �����.��5
      � .+�5   
   �� -   5        $��
ComboGroup��5      $	��150��6%   $��20��61   $��	0 0 0 450q�6=    �� DisplayMemberPath$ 
Name_Group��6P   6o   �� 5   
   $#��Выберите группу��6   $��30��6*   $	��120��66   $��	0 0 0 400q�6B   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridStudents��5   A      AutoGenerateColumns .     
IsReadOnly . $��0��6[   $��	0,66,0,79q�6k   $��0��6~   $	��800��6�    �� SelectedItem 6�   �� *SelectedItem+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$+ %Номер студенческого��6D   	   MinWidth$	 80Q�6a   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
St_ID_Card+6o     5      $# Группа студента��6K   $	 70Q�6d   $
 * 6r   -   5        GroupsSt�� 5   %   �� *Groups.Name_Group+6|     5      $ Фамилия��6D   $	 80Q�6U   $
 * 6c    6%   �� *
St_Surname+6c     5      $ Имя��6A   $	 80Q�6N   $
 * 6\    6%   �� *	St_Name+6\     5      $ Отчество��6G   $	 80Q�6Y   $
 * 6g    6%   �� *St_Patronymic+6g   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $��30��6I   $��79,440,0,28q�6U   $	��632��6j   .+�5      �� -   5         ��Name$ 	AddButton��5      $��Добавить��6(   $��1��6S   $��1��6c   $��30��6p   $��30��6   $	��100��6�   $	��100��6�   $��0 0 10 0q�6�   �� 5      -   5        $ DeleteButton��5      $��Удалить��6+   $��1��6X   $��1��6h   $��30��6u   $��30��6�   $	��100��6�   $	��100��6�   $��0 0 10 0q�6�   �� 5      -   5        $ 
EditButton��5      $ ��Редактировать��6)   $��30��6Q   $��30��6`   $	��100��6o   $	��100��6~   $��0 0 10 0q�6�   �� 5      -   5        $ 	SearchBtn��5      $��
Поиск��6(   $��30��6J   $��30��6Y   $	��100��6h   $	��100��6w   $��0 0 10 0q�6�   �� 5      -	   5        $ GoGroupEdit��5      $?��9Перейти к редактированию групп��6*   $��30��6S   $��30��6b   $	��200��6q   $	��100��6�   6�   5      5      5      