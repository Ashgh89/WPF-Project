   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.PlayStation5_Demo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  PlayStation5_Demo��5   	   $	��450��6#   $	��800��60   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   r� -   5        $��mediaPlayer��5       r� Source$ PS5.mp4?�5       r� Stretch$
 Fill=�6(    r� LoadedBehavior$ Manual=�5      5      �� 5   
   $��1��6   .+�5      �� -   5        $��labelStatus��5      $��PRESS PLAY BUTTON��5      
������$
��Left=�5      $��5q�5      � 5      $
��Left=�6   .+�5      �� -   5        $��btnPlay��5      $
��15,5q�5      
�����F�.��5   /   play65   �� 5      -   5        $��btnPause��5      $
��15,5q�5      
�����F�.��5   0   Pause67   �� 5       -   5        $��btnStop��5       $
��15,5q�5!      
�����F� J� RenderTransformOrigin$ 2.388,1.017&�5#   /   .��6S   Stop6Y   5%      5&      5'      5(      