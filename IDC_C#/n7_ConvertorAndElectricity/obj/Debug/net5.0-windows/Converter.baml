   M S B A M L   `   `   `  ����U  Qn7_ConvertorAndElectricity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:n7_ConvertorAndElectricityn7_ConvertorAndElectricity  5   	   *    $n7_ConvertorAndElectricity.Converter   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:n7_ConvertorAndElectricity     5   	   -   5          � Title$  Конвертер��5   	   $	��450��5	   	   $	��800��5
   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ txtPrice��5      $
��Left=�5      $��22��5      $��249,144,0,0q�5       �� TextWrapping$
 Wrap=�5      $	��Top=�5      $	��201��5      $��Consolas)�5      $��14(�5      5      �� 5   
   -   5         ��Name$ lblPrice��5      $��Цена ($)��5      $
��Left=�5      $��122,134,0,0q�5      $	��Top=�5      $	��122��5      $��42��5      $��20(�5       $��Consolas)�5!      �� 5"   
   -   5        $ lblRate��5"      $��Курс (₽/$)��5#      $
��Left=�5$      $��122,194,0,0q�5%      $	��Top=�5&      $	��122��5'      $��40��5(      $��20(�5)      $��Consolas)�5*      �� 5+   
   -   5        $ txtRate��5+      $
��Left=�5,      $��22��5-      $��249,204,0,0q�5.      $
 Wrap=�5/      $	��Top=�50      $	��201��51      $��Consolas)�53      $��14(�54      55      �� 56   
   -   5         ��Name$ 	btnRecalc��56      $��Пересчет��57      $
��Left=�58      $��54��59      $��477,160,0,0q�5:      $	��Top=�5;      $	��105��5<      $��18(�5=      $��Consolas)�5?      �� 5@   
   -   5        $ lblDescription��5@      $s��mВведите курс, цену в долларах и
щелкните по кнопке Пересчет��5A      $
��Left=�5B      $��
122,35,0,0q�5C      $	��Top=�5D      $��62��5E      $	��407��5F      $��18(�5G      $��Consolas)�5H      �� 5I   
   -   5        $ lblAnswerField��5I      $
��Left=�5J      $��56��5K      $��122,306,0,0q�5L      $	��Top=�5M      $	��375��5N      $��18(�5O      $��Consolas)�5P      �� 5Q   
   -	   5        $ 	lblAnswer��5Q      $��Результат:��5R      $
��Left=�5S      $��122,261,0,0q�5T      $	��Top=�5U      $	��126��5V      $��41��5W      $��20(�5X      $��Consolas)�5Y      �� 5Z   
   -
   5        $ btnQuit��5Z      $��Завершить��5[      $
��Left=�5\      $��42��5]      $��664,320,0,0q�5^      $	��Top=�5_      $��99��5`      $��18(�5a      $��Consolas)�5c      5d      5e      