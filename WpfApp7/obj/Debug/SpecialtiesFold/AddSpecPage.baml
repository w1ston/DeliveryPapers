   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WpfApp7.SpecialtiesFoldWpfApp7.SpecialtiesFold  5      )    #WpfApp7.SpecialtiesFold.AddSpecPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:WpfApp7.SpecialtiesFold     5        N� Title$  AddSpecPage��5	      $	��450��6   $	��500��6+   $	��450��6:   $	��500��6J    N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��200 �6   .+�5   
   �� $1��+Название специальности��6   $��Center=�62   $��Center=�6O   $��0��6j   $
��auto��6w   $��16��6�   �� 5   
   -   5         ��Name$ Special��5      $��1��6#   $
��Left=�63   $��40��6N    �� TextWrapping$
 Wrap=�6Z   $��Center=�6�   $	��290��6�    �� 	MaxLength$ 20��6�   $��0��6�   ��6n   �� *Name_Specialties+6�   �� 5   
   -   5        $��BtnSave��5   2   $��Сохранить��6   $��1��6%   $��40��6W   $	��150��6c   $��Center=�6o   �� 5   
   -   5        $��BtnBack��5   m   $#��Вернуться назад��6   $��Center=�6+   $��1��6H   $	��150��6U   $��40��6a   $��Bottom=�6�   5      5      