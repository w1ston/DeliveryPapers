   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp7WpfApp7  5      $    WpfApp7.ThemeFold.AddThemePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp7     5        N� Title$  AddThemePage��5	      $	��450��6   $	��500��6,   $	��450��6;   $	��500��6K    N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��115 �6   �� 5      $
��141* �6   �� 5      $
��194* �6   .+�5   
   �� $��0��6   $��Название темы��6$   $��Center=�69   $��Center=�6V   $��0��6q   $	��134��6~   $��16��6�   �� 5   
   $��0��6   $+��%Название дисциплины��6$   $��Center=�6?   $��1��6\   $��Center=�6i   $	��130��6�   $��16��6�   �� 5   
   -   5         ��Name$ 	NameTheme��5      $��1��6%   $
��Left=�65   $��60��6P    �� TextWrapping$
 Wrap=�6\   $��Center=�6�   $	��290��6�    �� 	MaxLength$ 20��6�   $��0��6�   $��Center=�6�   ��6p   �� *
Name_Theme+6�   �� 5   
   -   5         ��Name$ 	ComboDisc��5      $��1��6&   $
��Left=�66   $��26��6Q    �� DisplayMemberPath$ Name_Discipline��6]   $��Center=�6�   $	��205��6�   $��1��6�   6�   �� 5   
   -   5        $��BtnSave��5   B   $��0��6   $��Сохранить��6!   $��2��65   $��25,77,25,77q�6g   �� 5   
   -   5        $��BtnBack��5   }   $��0��6   $#��Вернуться назад��6!   $��Center=�6;   $��2��6X   $	��150��6e   $��40��6q   $	��Top=�6�   $��	0,121,0,0q�6�   5      5      