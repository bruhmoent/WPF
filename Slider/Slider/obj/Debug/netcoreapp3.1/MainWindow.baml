   M S B A M L   `   `   `  ����A  =Slider, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SliderSlider  5   	       Slider.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Slider     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
�������.+�5
   
   ��  �� Orientation$ Vertical=�6   $��Center=�6,   .+�5   
   �� $��50��6   $	��800��6!   $��Center=�6-   $	��Top=�6J   .+�5      �� $��30(�6   $��Center=�6"   $��Center=�6?   .��6Z   !KALKULATOR JEDNOSTEK DŁUGOŚCI6y   5      �� 5   
   $��50��6   $	��800��6!   $ 
Horizontal=�6-   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��20(�6   .��6*   Wybierz wartość liczbową:6E   �� 5      -   5         ��Name$ slider��5       �� IsSnapToTickEnabled$
 True��6-    �� TickFrequency$ 1Q�6H    � Maximum$	 100Q�6Z    � Minimum$ 0Q�6h   $	��400��6t   6�   �� 5      -   5         ��Name$ wartosc��5   J   
���**�� �� TextAlignment$ Center=�62   $��80��6\   $��50��6g   ${�False��6s   $��Center=�6�   $��Center=�6�   $��Center=�6�   6�   5      5      �� 5      $��60��6   $	��300��6%   $ 
Horizontal=�61   $��Center=�6J   .+�5      �� $��10q�6   $��20(�6$   $��Center=�62   $��Center=�6M   .��6j   	Zamień6r   �� 5      -   5        	 ��Name$	 first��5      $��30��6+   .@�5      �� 
 �� 
IsSelected$

 True��6#   .��65   cm69   �� 5      $
 False��6#   .��66   dm6:   �� 5      $
 False��6#   .��66   m69   �� 5      $
 False��6#   .��66   km6:   5      �� 5      $��10q�6   $��20(�6$   $��Center=�62   $��Center=�6M   .��6j   na6n   �� 5       -   5        $	 second��5       $��30��6,   .@�5!      �� $

 True��6#   .��65   cm69   �� 5"      $
 False��6#   .��66   dm6:   �� 5#      $
 False��6#   .��66   m69   �� 5$      $
 False��6#   .��66   km6:   5%      5&      �� 5(      $	��100��6   $��Center=�6&   $ 
Horizontal=�6C   $��30q�6\   $	��300��6h   .+�5)      �� -   5         ��Name$ przelicz��5)      $��Przelicz Wartość��6+   $��14(�6F   $��40��6T   $	��150��6`   6{   �� 5*      -   5         ��Name$ aj��5*      $��10q�6$   $��
/units.png��60   $	��150��6D   6S   5+      � 5-      $��80��6   $	��400��6   .+�5.      �� $��Center=�6   .+�5/      �� -   5        $ field��5/      
�������
���**��$��Center=�6W   $��Center=�6y   $ Center=�6�   $	��150��6�   $��50��6�   ${�False��6�   $��Center=�6�   $��Center=�6�   6  50      51      52      53      54      