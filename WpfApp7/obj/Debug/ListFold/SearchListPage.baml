   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfApp7.ListFoldWpfApp7.ListFold  5      %    WpfApp7.ListFold.SearchListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:WpfApp7.ListFold     5        N� Title$  SearchListPage��5	       N� 
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
Horizontal=�6   $��	0 10 10 0q�62   .+�5      �� $%��Выберите группу: ��6   $
��auto��65   $ Right=�6B   6Z   �� 5      -   5        $��
ComboGroup��5   (   $
��auto��6    �� DisplayMemberPath$ 
Name_Group��6i   6�   5      �� 5      $ 
Horizontal=�6   $��	0 10 10 0q�62   .+�5      �� $.��(Введите имя студента: ��6   $
��auto��6:   $ Right=�6G   6_   �� 5      -   5        $��
SBoxSearch��5   &   $	��150��6   6�   5      �� 5      $ 
Horizontal=�6   $��	0 10 10 0q�62   .+�5       �� $6��0Введите фамилию студента: ��6   $
��auto��6>   $ Right=�6K   6c   �� 5!      -   5        $��SSBoxSearch��5!   &   $	��150��6   6�   5"      5#      �� 5%   
   -   5        $��	LViewList��5%       $��1��6   $��Disabled=�61   $��Center=�6g   $��2��6�   $��0,55,0,0q�6�   ��5&      �� 5'      .R�5(      � $ 
Horizontal=�6    $��Center=�69   6X   5)      ��5+      �� 5,      .R�5-      � $
��auto��6    5.      �� 5/      $
��auto �6,   �� 50      $
��auto �6,   �� 51      $
��auto �6,   �� 52      $
��auto �6,   �� 53      $
��auto �6,   .+�55      �� $��Center=�6F   $ Center=�6a   $	��200��6x   $
��Wrap=�6�   $	��5 5q�6�   $��15(�6�   $��0��6�   ��6$   �� *Theme.Name_Theme+6�   �� 56      $��Center=�6V   $��	5 15 5 15q�6s   $��26(�6�   $��2��6�   $
��Bold"�6�   ��6$   �� *" Theme.Discipline.Name_Discipline+6�   �� 57      $��Center=�6P   $��	5 45 5 15q�6m   $��26(�6�   $��2��6�   $
��Bold"�6�   ��6$   �� *Students.Groups.Name_Group+6�   �� 58      $��Center=�6F   $��	5 75 5 15q�6c   $��26(�6v   $��2��6�   ��6$   �� *Students.St_Name+6�   �� 59      $��Center=�6I   $��	5 95 5 15q�6f   $��26(�6y   $��2��6�   ��6$   �� *Students.St_Surname+6�   5:      5;      5=      �� 5>   
   -   5         ��Name$
 Back��5>      $��2��6   $	��200��6,   $��25��68   $#��Вернуться назад��6D   $��300,4,300,3q�6q   6�   5?      5@      