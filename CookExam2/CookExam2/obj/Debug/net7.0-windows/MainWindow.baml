   M S B A M L   `   `   `  ����D  @CookExam2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CookExam2	CookExam2  5   	       CookExam2.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CookExam2     5   	     � Title$!  Книга рецептів��5   	   $	��450��6    $	��835��6.   $	��450��6:   $	��800��6J   $	��835��6Y   $	��450��6h   
������� � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   
dropShadow   ShadowDepth   	Direction   Color   Opacity   
BlurRadius��%c   &	          5   
   $ 3Q�6.   $	 270Q�6>   $ #999999��6N   $	 0.5Q�6^   $ 6Q�6l   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   c� $��0��6   
����������#EAEAEA$��0,0,0,1q�6I   .@�5      �� $��Добавити��63   $��5q�6F   $��10q�6Q   ���#EAEAEA$��0q�6s   ��6   �� *	AddRecipe+6s   �� 5      $��Змінити��6b   $��5q�6t   $��10q�6   ���#EAEAEA$��0q�6�   ��6   �� *ChangeRecipe+��66   �� *SelectedRecipe+6�   �� 5      $��Видалити��6b   $��5q�6u   $��10q�6�   ���#EAEAEA$��0q�6�   ��6   �� *DeleteRecipe+��66   �� *SelectedRecipe+6�   �� 5      $��Збрегти��64   $��5q�6F   $��10q�6Q   ���#EAEAEA$��0q�6s   ��6   �� *
SaveRecipe+6s   5      �� 5   
   $��1��6   ���#EAEAEA$��1q�6�   
���������6   �� *recipesList+ �� SelectedItem 6C   �� *SelectedRecipe+��5      �� 5      .R�5      �� ���#EAEAEA$��1q�63   	 �� CornerRadius$	 10��6G   
 �� Padding$
 15q�6Y   $��5q�6f   
������� J� Effect# [  6�   ._�5       ��  �� Orientation$ 
Horizontal=�6%   .+�5!      �� .+�5"   "   �� $
��Bold"�6B   $��22(�6T   ���#444444��6,   �� *Name+6b   �� 5#   "   $��20(�6B   $��Italic$�6P   ���#666666��6,   �� *Type+6c   �� 5$   "   $��20(�6I   ���#666666��6,   �� *KitchenType+6W   �� 5%   "   $��18(�6I   $
��Wrap=�6W   $	��400��6k   ���#888888��6,   �� *Description+6w   5&      �� 5'      $	��300��6C   $	��300��6O   $��25, 0, 0, 0q�6\   ��6$   �� *ImageSource+6\   5(      5)      5*      5,      5-      5.      