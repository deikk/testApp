   M S B A M L   `   `   `  ����  FinalApp    FinalApp.Views.ViewLogin   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      [ WPrism.DryIoc.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59T PPrism.Wpf, Version=8.1.97.5141, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/   5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel$
  TrueX�5       � 	Resources 5       �� 
TargetType �� 	Resources �� Property �� Value��%�   '��       �� 5   
   " ��6    5      ���� 5	      '��       " ��6   .�5
      ��  �@��CornerRadius$ 5��65   5      5      5      5      .��5      �� $��1��6   $��2��6   $	��350��6*   $	��180��66   $��2��6C   $��8��6W   $	�� 20q�6h    �� CornerRadius$ 20��6u   ���#E7F4F2 J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6   	   Color$	 	LightGray��6/   
   ShadowDepth$
 10Q�6A   ._�5   
   �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5"   
   �� $��0��6   $��1��6!   $��2��61   $��Center=�6E   $��42                    (�6b   $��0 0 0 20q�5#      $��Segoe UI Semilight)�6(   
Login Form5%      �� 5(   
   $��1��6   $��1��6!   $��0 0 0 10q�61   	Username:6N   �� 5)   
   -   5         ��Name$ userNameValue��5)      $��1��6*   $��2��67   $	��100��6G   $��0 0 0 10q�6V   6j   �� 5,   
   $��2��6   $��1��6!   $��0 0 0 10q�61   	Password:6N   G� 5-   
   -   5         G�Name$ PasswordValue��5-      $��2��6-   $��2��6:   $	��100��6J   $��0 0 0 10q�6Y   6m   �� 50   
   -   5         ��Name$ loginButton��50   .   $��3��6   $��2��6   $��0 5 0 5q�6C   $��Login��6T   6d   53      54      55      