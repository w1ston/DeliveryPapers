   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WpfApp7.ReadneesFoldWpfApp7.ReadneesFold  5   	   %    WpfApp7.ReadneesFold.ReadWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WpfApp7.ReadneesFold     5   	   -   5          � Title$  
ReadWindow��5   	   $	��350��6   $	��400��6)    � WindowStartupLocation$ CenterScreen=�6U    � WindowStyle$
 None=�6z    � 
ResizeMode$ NoResize=�6�   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��104* �6   �� 5      $
��105* �6   �� 5      $	��86* �6   �� 5      $	��56* �6   .+�5   
   �� $��
1 этап��6   $��Center=�6!   $��0��6>   $��44��6K   $��0,0,0,72q�6V   �� 5   
   -   5        $��First��5   �   $	��150��6   $��30��6   $��Center=�6*   $��Center=�6L   $��Center=�6i   6�   �� 5   
   $��
2 этап��6   $��Center=�6!   $��1��6>   $��44��6K   $��0,0,0,72q�6V   �� 5   
   -   5        $��Second��5   �   $	��150��6   $��30��6   $��1��6*   $��Center=�67   $��Center=�6Y   $��Center=�6v   6�   �� 5   
   $!��Общий прогресс��6   $��Center=�6)   $��1��6F   $	��104��6S   $��
0,104,0,58q�6_   $��2��6s   �� 5   
   -   5        $��Result��5   �   $	��150��6   $��30��6   $��2��6*   $��Center=�67   $��Center=�6Y   $��Center=�6v   {�.  ��6�   �� *Readiness_Degree+6�   �� 5   
   -   5        $��Сохранить��5      $	��150��6%   $��25��61   $��4��6=   $	��Top=�6_   �� 5   
   -   5        $#��Вернуться назад��5      $	��150��6+   $��25��67   $��4��6C   $��Bottom=�6`   5      5      