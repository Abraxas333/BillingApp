   M S B A M L   `   `   `  ����E  ABillingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:BillingApp.ViewBillingApp.View  5   	       BillingApp.View.LoginView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:BillingApp.View     5   	   X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  65   $	��450��5   	   $	��350��6      BackgroundBrush#��[  5   	     � WindowStartupLocation$  CenterScreen=�5	   	   $��Segoe UI)�5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Please Sign In��6   $��20(�5        	TextBrush#��[ 5      $��Center=�5      $��0,0,0,20q�5      �� 5   
   $��1��6   $	��0,5q�6"   .+�5      �� $��Username��6   #��[ 6(   $��0,0,0,5q�6P   �� 5      -   5         ��Name$ 
usernameTb��5        ControlBackgroundBrush#��[ 6*     SecondaryAccentBrush#��[ 5      $��5q�5       5!      �� 5$   
   $��2��6   $
��0,10q�6"   .+�5%      �� $��Password��6   #��[ 6(   $��0,0,0,5q�6P   G� 5&      -   5         G�Name$ pwdBox��5&      #��[ 6*   #��[ 5'      $��5q�5(      5)      �� 5,   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��Center=�6;   $��0,20,0,0q�6X   .+�5-      �� -   5        $��Login��5-      $	��100��5.      $��35��6!     PrimaryAccentBrush#��[ 5/      
�������$��14(�50   (   $	��5,0q�51      �� 52      -   5        $��Close��52      $	��100��53      $��35��6!   #��[ 54      
�������$��14(�55   (   $	��5,0q�56      57      58      59      