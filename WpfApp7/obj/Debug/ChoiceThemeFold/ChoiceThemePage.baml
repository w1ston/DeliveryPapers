   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApp7.ChoiceThemeFoldWpfApp7.ChoiceThemeFold  5      -    'WpfApp7.ChoiceThemeFold.ChoiceThemePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:WpfApp7.ChoiceThemeFold     5      -   5        $��Pages��5	   p     N� Title$  ChoiceThemePage��6   $	��450��6   $	��800��6/   $	��450��6>   $	��800��6N    N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $	��14* �6   �� 5      $
��119* �6   �� 5      $	��17* �6   .+�5   
   �� -   5        $��label1��5   v   $$��Студенты без тем��6   $��1��6+   $
��Left=�68   $��15(�6S   $��131,0,0,329q�6a   6v   �� 5   
   -   5        $��label2��5   d   $A��;Двойное нажатие, для выбора темы��6   $��1��6;   $��Right=�6H   $��0,1,180,328q�6r   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataUnStudent��5   A      AutoGenerateColumns .     
IsReadOnly . $
��Left=�6X   $��1��6s   $	��300��6�   $	��390��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6A      MinWidth$ 80Q�6N   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6\   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *	St_Name+6\     5      $ Фамилия��6D   $ 80Q�6U   $	 * 6c   
 6%   �� *
St_Surname+6c     5      $ Отчество��6G   $ 80Q�6Y   $	 * 6g   
 6%   �� *St_Patronymic+6g     5      $ Группа��6K   $ 80Q�6[   $	 * 6i   
 6%   �� *Groups.Name_Group+6i   5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5         ��Name$ SearchTheme��5   >   $��0��6   $	��150��6"   $��
Поиск��6.   $��30��6S   $��0 0 10 0q�6y   �� 5      -   5        $ RandomTheme��5   J   $��0��6   $	��150��6"   $'��!Распределить темы��6.   $��30��6_   6k   5        5   
   -   5        $ DataUnSelectedTheme��5   A    .   . $��Right=�6^   $��1��6z   $	��300��6�   $	��390��6�      SelectionMode$ Single=�6�    5         5!      $! Свободные темы��6D   $	 130Q�6\   $	 * 6k   
 6%   �� *
Name_Theme+6k     5"      $ Дисциплина��6T   $	 130Q�6h   $	 * 6w   
 6%   �� *Discipline.Name_Discipline+6w   5$      �� 5%   
   -   5        $��Ngroup��5%   �   $
��Left=�6   $��11,3,0,0q�6.   $��1��6@    �� DisplayMemberPath$ 
Name_Group��6M   $	��Top=�6l   $	��120��6�   6�   �� 5&   
   -	   5        $��NLabel��5&      $��0��6   $��Выбор группы��6+   $
��Left=�6B   $��	26,14,0,0q�6]   $	��Top=�6p   �� 5'   
   -
   5        $��NDiscipline��5'   g   $��Center=�6   $��	670,3,0,0q�60   $	��Top=�6C   $	��120��6[   $ Name_Discipline��6z   $��1��6�   6�   �� 5(   
   -   5        $��
NLabelDisc��5(      $��0��6"   $%��Выбор дисциплины��6/   $
��Left=�6J   $��
670,16,0,0q�6e   $	��Top=�6y   5)      5*      