   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp7.GroupWpfApp7.Group  5           WpfApp7.Group.AddGroupPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp7.Group     5        N� Title$  AddGroupPage��5	      $	��450��6   $	��800��6,   $	��450��6;   $	��800��6K    N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5       � RowDefinitions 5   
   �� 5      $	��149 �6   �� 5      $
��107* �6   �� 5      $
��194* �6   .+�5   
   �� $#��Название группы��6   $��Center=�6+   $��Center=�6H   $��0��6c   $	��134��6p   $��16��6|   �� 5   
   $ ��Специальность��6   $��Center=�6)   $��1��6F   $��Center=�6S   $��96��6n   $��16��6y   �� 5   
   -   5         ��Name$ NGroup��5      $��1��6"   $
��Left=�62   $��26��6M    �� TextWrapping$
 Wrap=�6Y   $��Center=�6�   $	��205��6�    �� 	MaxLength$ 20��6�   $��0��6�   ��6m   �� *
Name_Group+6�   �� 5   
   -   5         ��Name$ 	ComboSpec��5      $��1��6&   $
��Left=�66   $��26��6Q    �� DisplayMemberPath$ Name_Specialties��6]   $��Center=�6�   $	��205��6�   $��1��6�   6�   �� 5   
   -   5        $��BtnSave��5   2   $��Сохранить��6   $��2��6%   $��40��6W   $	��150��6c   �� 5   
   -   5        $��BtnBack��5   m   $#��Вернуться назад��6   $��Center=�6+   $��2��6H   $	��150��6U   $��40��6a   $��Bottom=�6�   $��0 0 0 20q�6�   5      5      