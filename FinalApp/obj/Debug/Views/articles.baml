   M S B A M L   `   `   `  ����C  ?FinalApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FinalApp.ViewsFinalApp.Views  5   	   /clr-namespace:FinalApp.ModelFinalApp.Model  5   	   9!clr-namespace:FinalApp.ViewModelsFinalApp.ViewModels  5   	       FinalApp.Views.articles   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:FinalApp.Views     5   	   /modelsclr-namespace:FinalApp.Model     5   	   8
ViewModels!clr-namespace:FinalApp.ViewModels     5   	     � Title$  articles��5   	   $	��450��6   $	��610��6'    � 	Resources 5          FinalApp.Model.PersonModel 
  person!   FinalApp.Model.ArticleModel  aart+  %FinalApp.ViewModels.ArticlesViewModel  art��%W   &	        &	      &	 &       5   
   6     5   
   6     5   
   6'   5      .��5      �  � DataContext 6   ��  �� Source# [  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��70 �6   �� 5       $��70 �6   �� 5!      $��70 �6   �� 5"      $��70 �6   �� 5#      $��70 �6   �� 5$      $��70 �6   .+�5&   
   �� $��5��65   $��1��6B   ��6   �� *Name+ �� Mode$ TwoWay=�6B   �� 5'   
   $��5��69   $��2��6F   ��6   �� *SelectedArticleBody+6F   �� 5(   
   $��Select your article��6   $��0��6/   $��0��6?   $��20q�6L   $	��220��6X   $��20(�6d   $��2��6r   �� 5)   
   -   5        $��Add new article��5)      $��0��6B   $��4��6O   $��2��6_   $��10,55,30,55q�6s   $��2��6�   �� 5*   
   -   5         ��Name$ articlesComboBox��5+   	    �� DisplayMemberPath$ Title��5*   �   $��0��5+   #   $��0��60   $��4��6@   $��20,55q�6T   $��2��6c   ��5*      �� 	 �� Path$	 Articles�
 �� SelectedValue
 69   �� $	 SelectedArticle�$ TwoWay=� �� SelectedItem 6u   �� $	 SelectedArticle�$ TwoWay=�5+   c   �� 5,   
   -   5         ��Name$ ArticleBodyTextBox��5,      " �� VerticalScrollBarVisibility$ Visible=�6a   $��1��6�   $��0��6�   $��4��6�   $��
20,33,20,0q�6�   $��4��6�    �� TextWrapping$
 Wrap=�6�   ��6.   �� *SelectedArticleBody+$ TwoWay=�6�   5/      50      