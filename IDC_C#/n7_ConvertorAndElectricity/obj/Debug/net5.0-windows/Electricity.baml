   M S B A M L   `   `   `  ����U  Qn7_ConvertorAndElectricity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:n7_ConvertorAndElectricityn7_ConvertorAndElectricity  5   	   ,    &n7_ConvertorAndElectricity.Electricity   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:n7_ConvertorAndElectricity     5   	   -   5          � Title$"  Электроэнегрия��5   	   $	��450��5	   	   $	��800��5
   	    � 
ResizeMode$ CanMinimize=�5   	   .��5      � .+�5   
   �� -   5         ��Name$ lblMeterReadings��5      $)��#Показания счетчика��5      $
��Left=�5      $��
130,52,0,0q�5      $	��Top=�5      $��22(�5      $��Consolas)�5      �� 5   
   -   5        $ lblPrevious��5      $��Предыдущее��5      $
��Left=�5      $��
130,92,0,0q�5      $	��Top=�5      $��20(�5      $��Consolas)�5      �� 5   
   -   5        $ 
lblCurrent��5      $��Текущее��5      $
��Left=�5      $��130,140,0,0q�5      $	��Top=�5       $��20(�5!      $��Consolas)�5"      �� 5#   
   -   5         ��Name$ txtPrevious��5#      $
��Left=�5$      $��23��5%      $��299,102,0,0q�5&       �� TextWrapping$
 Wrap=�5'      $	��Top=�5(      $	��164��5)      $��Consolas)�5+      $��14(�5,      5-      �� 5.   
   -   5        $ 
txtCurrent��5.      $
��Left=�5/      $��23��50      $��299,150,0,0q�51      $
 Wrap=�52      $	��Top=�53      $	��164��54      $��Consolas)�56      $��14(�57      58      �� 59   
   -   5        $ 	lblTariff��59      $��Цена(руб./кВт)��5:      $
��Left=�5;      $��130,208,0,0q�5<      $	��Top=�5=      $��20(�5>      $��Consolas)�5?      �� 5@   
   -   5        $ 	txtTariff��5@      $
��Left=�5A      $��24��5B      $��299,217,0,0q�5C      $
 Wrap=�5D      $	��Top=�5E      $	��164��5F      $��Consolas)�5H      $��14(�5I      5J      �� 5K   
   -	   5         ��Name$ btnCalculation��5K      $��Вычисление��5L      $
��Left=�5M      $��501,173,0,0q�5N      $	��Top=�5O      $	��119��5P      $��57��5Q      $��18(�5R      $��Consolas)�5S      5T      �� 5U   
   -
   5        $ 	lblAnswer��5U      $!��Сумма к оплате:��5V      $
��Left=�5W      $��130,269,0,0q�5X      $	��Top=�5Y      $	��184��5Z      $��41��5[      $��20(�5\      $��Consolas)�5]      �� 5^   
   -   5        $ lblAnswerField��5^      $
��Left=�5_      $��52��5`      $��130,310,0,0q�5a      $	��Top=�5b      $	��367��5c      $��18(�5d      $��Consolas)�5e      �� 5f   
   -   5        $ btnQuit��5f      $��Завершить��5g      $
��Left=�5h      $��42��5i      $��664,320,0,0q�5j      $	��Top=�5k      $��99��5l      $��18(�5m      $��Consolas)�5o      5q      5r      