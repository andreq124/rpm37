   M S B A M L   `   `   `  ����@  <MVVM2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MVVM2MVVM2  5   	       MVVM2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MVVM2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	   	   ��  �� RelativeSource �� *Self+.��5
      � .+�5   
   �� .+�5      ��  �� Left$ 0��6R   $	��800��6b   
�������
���   �
���   �$��2q�6�   $
��Bold"�6�   $��20(�6�   ��6   �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��Is Completed��69   
 �� Top$ 35��6P   
���   �$
��Bold"�6s   $��15(�6�    d� 	IsChecked 6   �� *IsCompleted+6�   �� 5      $��Add Task��6   $ 60��6K   $	��100��6[   
�������
���   �$��2q�6�   $
��Bold"�6�   $��15(�6�   ��6(   �� *AddTaskCommand+6�   �� 5      $��Delete Selected Task��6   $ 90��6Z   
�������
���   �
���   �$��2q�6�   $
��Bold"�6�   $��15(�6�   ��64   �� *DeleteTaskCommand+6�   �� 5      $ 0��6Z   $	 140��6j   
�������
���   �$��2q�6�   $
��Bold"�6�   $��15(�6�   ��6   �� *Tasks+ �� SelectedItem 64   �� *SelectedTask+��5      �� 5      .R�5      �� .+�5      �� $
��Wrap=�6(   $	��780��6S   ��6<   �� *Title+6S   �� 5      
�������$
��Bold"�6\   $��15(�6n    6'   �� *IsCompleted+6n   5      5      5      5      5      5      