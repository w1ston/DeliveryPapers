   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:WpfApp7.StudentInSemFoldWpfApp7.StudentInSemFold  5      /    )WpfApp7.StudentInSemFold.StudentInSemPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:WpfApp7.StudentInSemFold     5        N� Title$  StudentInSemPage��5	       N� 
Background
 �����$	��450��63   $
��1100��6C   $	��450��6S   $
��1100��6c   .��5      �  � RowDefinitions 5   
   �� 5      $��7* �6   �� 5      $	��68* �6   .+�5   
   �� $��1��6   $%��Выберите семестр��6   $	��150��68   $��30��6D   $��325,0,325,378q�6P   $��Center=�6g   �� 5   
   -   5        $��ComboSem��5   �   $	��150��6   $��20��6   $��1��6+   $	��Top=�68   $��325,29,325,0q�6P    �� DisplayMemberPath$ ID_Semester��6f   6�   �� 5   
   $)��#Отстающие студенты��6   $��1��6-   $
��Left=�6:   $��15(�6U   $��288,45,0,335q�6c   �� 5   
   $+��%Успевающие студенты��6   $��1��6.   $
��Left=�6;   $��15(�6V   $��656,45,0,335q�6d   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataUnStudent��5   A      AutoGenerateColumns .     
IsReadOnly . $
��Left=�6X   $��1��6s   $
��auto��6�   $	��500��6�   $��
10,78,0,30q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6J   	   MinWidth$	 60Q�6W   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6e   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Students.St_Name+6e     5      $ Фамилия��6M   $	 70Q�6^   $
 * 6l    6%   �� *Students.St_Surname+6l     5      $ Отчество��6P   $	 70Q�6b   $
 * 6p    6%   �� *Students.St_Patronymic+6p     5      $ Группа��6T   $	 70Q�6d   $
 * 6r    6%   �� *Students.Groups.Name_Group+6r     5      $ Дисциплина��6Z   $	 70Q�6n   $
 * 6|    6%   �� *" Theme.Discipline.Name_Discipline+6|     5      $) #Процент выполнения��6`   $	 70Q�6|   $
 * 6�    6%   �� *Readiness_Degree+ �� StringFormat$
 {0}%��6�   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5         ��Name$ SearchTheme��5   >   $��0��6   $	��150��6"   $��
Поиск��6.   $��30��6S   $��0 0 10 0q�6y   �� 5       -   5        $ BtnBack��5    H   $��0��6   $	��150��6"   $#��Вернуться назад��6.   $��30��6Y   6e   5!        5"   
   -   5        $ DataInStudent��5"   A    .   . $��Right=�6X   $��1��6t   $
��auto��6�   $	��500��6�      SelectionMode$ Single=�6�   $��
0,78,10,30q�6�    5#        5$      $ Имя��6J   $	 60Q�6W   $
 * 6e    6%   �� *Students.St_Name+6e     5%      $ Фамилия��6M   $	 70Q�6^   $
 * 6l    6%   �� *Students.St_Surname+6l     5&      $ Отчество��6P   $	 70Q�6b   $
 * 6p    6%   �� *Students.St_Patronymic+6p     5'      $ Группа��6T   $	 70Q�6d   $
 * 6r    6%   �� *Students.Groups.Name_Group+6r     5(      $ Дисциплина��6Z   $	 70Q�6n   $
 * 6|    6%   �� *" Theme.Discipline.Name_Discipline+6|     5)      $) #Процент выполнения��6`   $	 70Q�6|   $
 * 6�    6%   �� *Readiness_Degree+$
 {0}%��6�   5+      �� 5,   
   $#��Выберите группу��6   $	��110��6*   $��137,4,853,374q�66   $��30��6M   $��1��6Y   �� 5-   
   -   5        $��
ComboGroup��5-   �   $
��Left=�6   $��
117,39,0,0q�6.   $��1��6B   $	��Top=�6O   $	��150��6g   $��20��6s   $ 
Name_Group��6   6�   �� 5.   
   $+��%Выберите дисциплину��6   $	��135��6.   $��30��6:   $��945,4,20,374q�6F   $��1��6\   �� 5/   
   -   5        $��ComboDiscipline��5/   �   $
��Left=�6   $��
930,39,0,0q�6.   $��1��6B   $	��Top=�6O   $	��150��6g   $��20��6s   $ Name_Discipline��6   6�   50      51      