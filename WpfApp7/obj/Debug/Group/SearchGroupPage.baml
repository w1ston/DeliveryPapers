   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp7.GroupWpfApp7.Group  5      #    WpfApp7.Group.SearchGroupPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfApp7.Group     5        N� Title$  SearchGroupPage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��209* �6   6,   �� 5      $	��16* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   
�������$��1��6]   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��	0 10 10 0q�62   .+�5      �� $O��IВведите название группы (аббревиатуру): ��6   $
��auto��6L    �� TextAlignment$ Right=�6Y   6q   �� 5      -   5        $��
GBoxSearch��5   &   $	��150��6   6�   5      �� 5      $ 
Horizontal=�6   $��	0 10 10 0q�62   .+�5      �� $3��-Выберите специальность: ��6   $
��auto��6<   $ Right=�6I   6a   �� 5      -   5        $��	ComboSpec��5   (   $
��auto��6    �� DisplayMemberPath$ Name_Specialties��6g   6�   5      5      �� 5   
   -   5        $��
LViewTheme��5       $��1��6   $��Disabled=�62   $��Center=�6h   $��2��6�   $��0,47,0,0q�6�   ��5      �� 5      .R�5       � $ 
Horizontal=�6    $��Center=�69   6X   5!      ��5#      �� 5$      .R�5%      � $
��auto��6    5&      �� 5'      $
��auto �6,   �� 5(      $
��auto �6,   .+�5*      �� $��Center=�6@   $ Center=�6[   $	��500��6r   $
��Wrap=�6~   $	��5 5q�6�   $��15(�6�   $��0��6�   ��6$   �� *
Name_Group+6�   �� 5+      $��Center=�6R   $��5 5 5 15q�6o   $��26(�6�   $��2��6�   $
��Bold"�6�   ��6$   �� *Specialties.Name_Specialties+6�   5,      5-      5/      �� 50   
   -   5         ��Name$
 Back��50      $��2��6   $	��200��6,   $��25��68   $#��Вернуться назад��6D   $��300,4,300,3q�6q   6�   51      52      