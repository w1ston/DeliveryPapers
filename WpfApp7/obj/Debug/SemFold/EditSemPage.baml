   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp7.SemFoldWpfApp7.SemFold  5      !    WpfApp7.SemFold.EditSemPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp7.SemFold     5        N� Title$  EditSemPage��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��149 �6   �� 5      $
��107* �6   �� 5      $
��194* �6   .+�5   
   �� $��Семестер��6   $��Center=�6$   $��Center=�6A   $��0��6\   $	��134��6i   $��16��6u   �� 5   
   $��Год��6   $��Center=�6   $��1��6<   $��Center=�6I   $��96��6d   $��16��6o   �� 5   
   -   5         ��Name$
 NSem��5      $��1��6    $
��Left=�60   $��26��6K    �� TextWrapping$
 Wrap=�6W   $��Center=�6�   $	��205��6�    �� 	MaxLength$ 20��6�   $��0��6�   {�.  ��6k   �� *ID_Semester+6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ NYear��5      $��1��6$   $
��Left=�64   $��26��6O   $��Center=�6z   $	��205��6�   $��1��6�      Text 6[   �� *Semester_Year+6�   �� 5   
   -   5        $��BtnSave��5   2   $��Сохранить��6   $��2��6%   $��40��6W   $	��150��6c   �� 5   
   -   5        $��BtnBack��5   m   $#��Вернуться назад��6   $��Center=�6+   $��2��6H   $	��150��6U   $��40��6a   $��Bottom=�6�   $��0 0 0 20q�6�   5      5      