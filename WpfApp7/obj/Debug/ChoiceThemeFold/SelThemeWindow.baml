   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApp7.ChoiceThemeFoldWpfApp7.ChoiceThemeFold  5   	   ,    &WpfApp7.ChoiceThemeFold.SelThemeWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:WpfApp7.ChoiceThemeFold     5   	   -   5          � Title$  SelThemeWindow��5   	   $	��450��6    $	��800��6-    � WindowStartupLocation$ CenterScreen=�6Z    � WindowStyle$
 None=�6    � 
ResizeMode$ NoResize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��209* �6   6,   �� 5      $	��16* �6   .+�5   
   �� -   5        $��
NameGroupp��5   �   $	��150��6   $��20��6   $��1��6+   $	��Top=�68   $��325,40,325,0q�6P    �� DisplayMemberPath$ 
Name_Group��6f   6�   �� 5   
   $��Группа��6   $��1��6!   $��15(�6.   $��369,5,369,355q�6<   �� 5   
   -   5        $��x1��5   3   $
��auto��6   $��10,5,490,355q�6   $��1��6=   �� 5   
   $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   .+�5      �� -   5         ��Name$ BtnBack��5   ;   $	��150��6   $#��Вернуться назад��6!   $��30��6L   6X   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataInStudent��5   A   	   AutoGenerateColumns	 .  
   
IsReadOnly
 . $��Center=�6X   $��1��6u   $	��300��6�   $
��auto��6�      SelectionMode$ Single=�6�   $��	0,70,0,20q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6A      MinWidth$	 130Q�6N      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	St_Name+6]     5      $ Фамилия��6D   $	 130Q�6U   $ * 6d    6%   �� *
St_Surname+6d     5      $ Отчество��6G   $	 130Q�6Y   $ * 6h    6%   �� *St_Patronymic+6h     5      $ Группа��6K   $	 130Q�6[   $ * 6j    6%   �� *Groups.Name_Group+6j   5      5      5      