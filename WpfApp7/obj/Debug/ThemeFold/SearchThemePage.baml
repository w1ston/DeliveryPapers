   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp7WpfApp7  5      '    !WpfApp7.ThemeFold.SearchThemePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp7     5        N� Title$  SearchThemePage��5	       N� 
Background
 �����.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��209* �6   6,   �� 5      $	��16* �6   .+�5   
   �  � Orientation$ 
Horizontal=�6   $��Center=�6-   
�������$��1��6]   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��	0 10 10 0q�62   .+�5      �� $0��*Введите название темы: ��6   $
��auto��6;    �� TextAlignment$ Right=�6H   6`   �� 5      -   5        $��
TBoxSearch��5   &   $	��150��6   6�   5      �� 5      $ 
Horizontal=�6   $��	0 10 10 0q�62   .+�5      �� $-��'Выберите дисциплину: ��6   $
��auto��69   $ Right=�6F   6^   �� 5      -   5        $��	ComboDisc��5   (   $
��auto��6    �� DisplayMemberPath$ Name_Discipline��6g   6�   5      5      �� 5   
   -   5        $��
LViewTheme��5       $��1��6   $��Disabled=�62   $��Center=�6h   $��2��6�   $��0,47,0,0q�6�   ��5      �� 5      .R�5       � $ 
Horizontal=�6    $��Center=�69   6X   5!      ��5#      �� 5$      .R�5%      � $
��auto��6    5&      �� 5'      $
��auto �6,   �� 5(      $
��auto �6,   .+�5*      �� $��Center=�6@   $ Center=�6[   $	��200��6r   $
��Wrap=�6~   $	��5 5q�6�   $��15(�6�   $��0��6�   ��6$   �� *
Name_Theme+6�   �� 5+      $��Center=�6P   $��5 5 5 15q�6m   $��26(�6   $��2��6�   $
��Bold"�6�   ��6$   �� *Discipline.Name_Discipline+6�   5,      5-      5/      �� 50   
   -   5         ��Name$
 Back��50      $��2��6   $	��200��6,   $��25��68   $#��Вернуться назад��6D   $��300,4,300,3q�6q   6�   51      52      