   M S B A M L   `   `   `  ����M  In6-1_CalculatorWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:n6_1_CalculatorWPFn6_1_CalculatorWPF  5   	   #    n6_1_CalculatorWPF.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:n6_1_CalculatorWPF     5   	     � Title$  
Calculator��5   	   $	��309��6   $	��622��6)   .��5	      � .+�5
   
   �� $
��Left=�6   $��
190,68,0,0q�6,   $	��Top=�6@   $��16(�6X   .��5      �� -   5         ��Name$ btnPlus��5      $��+��6&   $��35��62   $��35��6>   $��16(�6_   $
��Bold"�6m   5      �� 5   
   $
��Left=�6   $��
241,68,0,0q�6,   $	��Top=�6@   $��16(�6X   .��5      �� -   5        $ btnMinus��5      $��-��6'   $��35��63   $��35��6?   $��16(�6a   5      �� 5   
   $
��Left=�6   $��
291,68,0,0q�6,   $	��Top=�6@   $��16(�6X   .��5      �� -   5        $ btnMultiply��5      $��*��6*   $��35��66   $��35��6B   $��16(�6g   5      �� 5   
   $
��Left=�6   $��
341,68,0,0q�6,   $	��Top=�6@   $��16(�6X   .��5      �� -   5        $ 	btnDivide��5      $��/��6(   $��35��64   $��35��6@   $��16(�6c   5      �� 5   
   -   5         ��Name$ 	tbNumber2��5      $
��Left=�6%   $��181,120,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��203��6�   $��28��6�   �� 5   
   -   5        $ 	tbNumber1��5      $
��Left=�6%   $��
181,25,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $	��203��6�   $��28��6�   �� 5   
   -   5         ��Name$ lbAnswer��5      $��Answer��6"   $
��Left=�63   $��
23,157,0,0q�6N   $	��Top=�6b   $��14(�6z   �� 5   
   -   5        $ 	lbNumber1��5      $��Number 1��6#   $
��Left=�66   $��	23,25,0,0q�6Q   $	��Top=�6d   $��14(�6|   �� 5   
   -	   5        $ 	lbNumber2��5      $��Number 2��6#   $
��Left=�66   $��
23,111,0,0q�6Q   $	��Top=�6e   $��14(�6}   �� 5   
   -
   5        $ lbOperation��5      $��	Operation��6%   $
��Left=�69   $��	23,68,0,0q�6T   $	��Top=�6g   $��14(�6   �� 5   
   -   5        $ lbAnswerField��5      $��..��6'   $
��Left=�64   $��181,157,0,0q�6O   $	��Top=�6d   �� 5   
   $��Disigned by Amirov Kirill��6   $
��Left=�64   $��
450,10,0,0q�6O   $	��Top=�6c   $��32��6{   $	��143��6�   5      5      