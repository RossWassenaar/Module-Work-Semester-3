   M S B A M L   `   `   `  ����M  IDateTime_ExamTimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DateTime_ExamTimerDateTime_ExamTimer  5   	   #    DateTime_ExamTimer.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:DateTime_ExamTimer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��698��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 
background��5
      $
��Left=�6$   $	��443��6?   $	��Top=�6L   $	��698��6d    J� RenderTransformOrigin$ 	0.502,0.5&�6p   $ ��/classroom exam screen.jpg��6�   �� 5   
   -   5         ��Name$ Label_Title��5      $��Exam Duration��6%   $��Center=�6=   $��0,46,0,0q�6Z   $	��Top=�6l   $��22(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ ComboBox_ExamDuration��5      $
��Left=�62   $��
224,90,0,0q�6M   $	��Top=�6a   $	��141��6y   $��30��6�   .@�5      �� $��1 Minute��6   $��16(�6.   
 � Tag$ 1��6<   �� 5      $��	3 Minutes��6   $��16(�6/   $ 3��6=   �� 5      $��	5 Minutes��6   $��16(�6/   $ 5��6=   �� 5      $��
10 Minutes��6   $��16(�60   $ 10��6>   5      � 5   
   -   5         �Name$ ProgressBar_ExamDuration��5      $��Center=�68   $��29��6U   $��	0,142,0,0q�6a   $	��Top=�6t   $	��250��6�   �� 5   
   -   5         ��Name$ Button_StartExam��5      $��
Start Exam��6+   $��16(�6@   $
��Left=�6N   $��
390,90,0,0q�6i   $	��Top=�6}   $��30��6�   $��84��6�   6�   5      5      