   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��50 �6   �� 5       $
��auto �6   �� 5!      $��20 �6   �� 5"      $��* �6   �� 5#      $��20 �6   .+�5&   
   �� -   5         ��Name$ vendingMachineCash��5&      $��1��60   $��1��6@   $��5��6M   $��KASA W AUTOMACIE��6a   �� 5'   
   -   5        $ databaseCash��5'      $��7��6*   $��1��6:   $��3��6G   $��KASA W BAZIE��6[   �� 5)   
   -   5         ��Name$
 cola��5)      $��1��6   $��3��6/   $
��Cola��6<   6K   �� 5*   
   -   5        $ fanta��5*      $��3��6    $��3��60   $��Fanta��6=   6M   �� 5+   
   -   5        $ sprite��5+      $��5��6!   $��3��61   $��Sprite��6>   6O   �� 5,   
   -   5        $ monster��5,      $��1��6"   $��5��62   $��Monster��6?   6Q   �� 5-   
   -   5        $ lipton��5-      $��3��6!   $��5��61   $��Lipton��6>   6O   �� 5.   
   -   5        $ water��5.      $��5��6    $��5��60   $
��Woda��6=   6L   �� 50   
   -	   5        $ addCashToVendingMachine��50      $��1��62   $��7��6B   $��Wrzuć 5zł��6O   $��5��6c   6w   �� 51   
   -
   5        $ drinkOne��51      $��7��6$   $��7��64   $��Wypij jedno picie��6A   6]   �� 52   
   -   5        $ drinkAll��52      $��9��6#   $��7��63   $��Wypij wszystkie picia��6@   6`   �� 54   
   -   5         ��Name$ database��54      $��7��6$   $��3��64   $��3��6A   $��3��6U   56      57      