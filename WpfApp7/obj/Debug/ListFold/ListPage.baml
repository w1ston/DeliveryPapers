   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp7.ListFoldWpfApp7.ListFold  5          WpfApp7.ListFold.ListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfApp7.ListFold     5      -   5        $��Pages��5	   +     N� Title$  ListPage��6    N� 
Background
 ����� � 	Resources 5      1   +WpfApp7.ListFold.WorkSubmitionDateConverter   WorkSubmitionDateConverter��%   &	          5   
   6+   5      .��5      �  � RowDefinitions 5   
   �� 5      $	��14* �6   �� 5      $
��119* �6   �� 5      $	��17* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridList��5   A      AutoGenerateColumns .     
IsReadOnly . $��1��6W      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя студента��6J   	   MinWidth$		 100Q�6`   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6o   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Students.St_Name+6o     5      $% Фамилия студента��6M   $		 100Q�6g   $
 * 6v    6%   �� *Students.St_Surname+6v     5      $' !Отчество студента��6P   $		 100Q�6k   $
 * 6z    6%   �� *Students.St_Patronymic+6z     5      $ Название темы��6J   $		 130Q�6a   $
 * 6p    6%   �� *Theme.Name_Theme+6p     5      $ Группа��6T   $
 * 6d    6%   �� *Students.Groups.Name_Group+6d     5      $ Дисциплина��6Z   $		 100Q�6n   $
 * 6}    6%   �� *" Theme.Discipline.Name_Discipline+6}     5      $ Семместр��6N   $
 * 6`    6%   �� *Semester.ID_Semester+6`     5      $) #Процент выполнения��6`   $		 100Q�6|   $
 * 6�    6%   �� *Readiness_Degree+ �� StringFormat$
 {0}%��6�     5      $ Оценка��6?   $
 * 6O    6%   �� *Grade+6O     5       $ Дата сдачи��6�   $		 100Q�6�   $
 * 6�    6%   �� *Work_submition_date+$ {0:dd.MM.yyyy}�� �� TargetNullValue$  �� �� 	Converter# [  6�   5"      �� 5#   
   $��2��6   $��Center=�6"    �� Orientation$ 
Horizontal=�6?   .+�5$      �� -   5         ��Name$ Readness��5$   F   $
��auto��6   $6��0Определить процент работы��6"   $��30��6X   $��0 0 10 0q�6d   6v   �� 5%      -   5        $ DelList��5%   3   $	��150��6   $��Удалить��6!   $��30��6D   $��0 0 10 0q�6P   6b   �� 5&      -   5        $ AddList��5&   ?   $	��150��6   $)��#Добавить / Изменить��6!   $��30��6P   $��0 0 10 0q�6\   6n   �� 5'      -   5        $ SemBtn��5'   3   $	��150��6   $��Семестр��6!   $��30��6C   $��0 0 10 0q�6d   �� 5(      -   5        $ 	StudInSem��5(   ?   $	��150��6   $+��%Успевающие студенты��6!   $��30��6R   $��0 0 10 0q�6y   �� 5)      -   5        $
 DocX��5)   <   $	��150��6   $%��Создать документ��6!   $��30��6J   6V   5*      �� 5+   
   $��0��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5,      �� -	   5        $ 
SearchList��5,   1   $	��150��6   $��
Поиск��6!   $��30��6E   $��	0 0 100 0q�6Q   6d   �� 5-      $��Группа��6   $��25��6%   �� 5.      -
   5        $��
ComboGroup��5.   {   $	��150��6   $��20��6#   $��Center=�6/   $��0 0 10 0q�6J    �� DisplayMemberPath$ 
Name_Group��6\   6�   �� 5/      $��Дисциплина��6   $��25��6)   �� 50      -   5        $��ComboDiscip��50   �   $	��150��6   $��20��6#   $��Center=�6/   $��0 0 10 0q�6J   $ Name_Discipline��6\   6�   51      52      55      