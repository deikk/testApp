   M S B A M L   `   `   `  ����C  ?FinalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FinalApp.ViewsFinalApp.Views  5   	   9!clr-namespace:FinalApp.ViewModelsFinalApp.ViewModels  5   	       FinalApp.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5   	   -controlsclr-namespace:FinalApp.Views   5   	   3	viewmodel!clr-namespace:FinalApp.ViewModels   5   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5   	   $	��420��5   !   $	��525��6.    � Title 6	   �� *Title+ � 	Resources 5	      -   'FinalApp.ViewModels.MainWindowViewModel   but-   'FinalApp.ViewModels.exitButtonViewModel  exit,   &FinalApp.ViewModels.ViewLoginViewModel 	 login  firstButton �� 
TargetType �� Property �� Value �� 	Resources  
lastButton  middleButton��%]  &	        &	      &	 &     &	 9     &	     &	 �      5
   
   66     5   
   67     5   
   67   �� 5   
   " ��6$   .�5      ��  � �� �#00cccc6+    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 4 0 0 0��65   5      5      5      �� 5   
   " ��6#   .�5      ��  � �� �#00cccc6+    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 0 4 0 0��65   5      5      5      �� 5   
   " ��6%   .�5      ��  � �� �#00cccc6+   5      5       .��5!      �  � ColumnDefinitions 5"   
   �� 5#      $��80 �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��10 �6    � RowDefinitions 5)   
   �� 5*      $��25 �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   �� 5.      $��* �6   �� 5/      $��* �6   �� 50      $��* �6   �� 51      $��10 �6   .+�54   
   �� $��1��6   $��0��6"   $��4��62   $��6��6F   $��10q�6W   .+�55         FinalApp.Views.ViewLogin  -   5        	  Name$	 loginUserControl��55   !   $y�Visible=�6;   %   FinalApp.Views.ViewRegistration  56      -   5        
  Name$
 registrationUserControl��56   (   $y�	Collapsed=�6I      FinalApp.Views.General  57      -   5          Name$ generalUserControl��57      $y�	Collapsed=�6;   58      ]� 5:   
    � Cursor$
 Hand��6   $��0��6"   $��5��62   $
��Left=�6F   .+�5;      �� -   5        $��70��5;   5   #��[ 6@   ��6   �� *LoginButton+6f   �� 5<      -   5        $��70��5<   7   #��[ 6B   ��6   �� *GeneralButton+6h   �� 5=      -   5        $��90��5=   <   #��[ 6G   ��6   �� *RegistrationButton+6m   �� 5>      $��70��64   #��[ 6?   ��6   �� *
ExitButton+��6c   ��  �� Source# [  �� Path$ eButton�5?      �� 5@   
   $��0��6   $��5��6!   $��1��65   $��7��6B   ���#00b3b3$��6q�6i   5A      5B      5C      