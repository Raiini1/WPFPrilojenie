   M S B A M L   `   `   `  ����  Uchebnye_kursi    Uchebnye_kursi.Kursi   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
Курсы��5   	   $	��250��6   $	��800��6$    � Icon$ /иконка.ico��60    � WindowStartupLocation$ CenterScreen=�5      .��5      � $��
0,0,-246,0q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridKurs��5         AutoGenerateColumns$ False��6)      HeadersVisibility$ Column=�6E      CanUserAddRows$ False��5      $��113,12,256,11q�6*      Columns 5	      0  *System.Windows.Controls.DataGridTextColumn  5
      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 60   �� *	ID_Kurs+6L     5      $! Название курса��6%   $		 150 6`   
 6=   �� *Nazvanie_kursa+6`     5      $3 -Продолжительность курса��6%   $		 160 6p   
 6F   �� *Prodoljitelnost_kursa+6p     5      $ Цена курса��6%   $	 80 6Y   
 69   �� *Tsena_kursa+6Y     5      $# Количество мест��6%   $		 110 6]   
 6>   �� *
Kolvo_mest+6]     5      $  Преподаватель��6%   $		 150 6^   
 6<   �� *Sotrudnik_FIO+6^     5      $ Скидка��6%   $	 50 6P   
 65   �� *Skidka+6P     5      $" Цена со скидкой��6%   $		 110 6c   
 6>   �� *Tsena_so_skidkoi+6c     5      $ Дата начала��6%   $	 80 6[   
 6:   �� *Data_nachala+6[     5      $! Дата окончания��6%   $	 80 6a   
 6=   �� *Data_okonchania+6a     5      $ Статус оплаты��6%   $	 90 6^   
 6<   �� *Status_oplati+6^   5      �� 5   
   $
��Left=�6   $��87��6+   $��	10,11,0,0q�67   $	��Top=�6J   $��87��6b   $��/user_add_icon_257914.png��6m   �� 5   
   $��
Курсы��6   $
��Left=�6    $��	24,95,0,0q�6;   $	��Top=�6N   $%��Bahnschrift Light SemiCondensed)�6f   $��20(�6�   5      5      