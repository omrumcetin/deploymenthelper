   M S B A M L   `   `   `  ����S  OP.I.Deployment_Helper_v2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:P.I.Deployment_Helper_v2P.I.Deployment_Helper_v2  5   	   )    #P.I.Deployment_Helper_v2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:P.I.Deployment_Helper_v2     5   	   -   5          �Name$  Main_Window��5   	    � Title$ P.I. Deployment Helper��5   	   $	��700��6(   $
��1000��65   $y�Visible=�6B    � WindowStyle$
 None=�6W    � 
ResizeMode$ NoResize=�6j    � AllowsTransparency . 
������  � Icon$ 
Img/DH.ico��6�   .��5	      � -   5         �Name$ MainGrid��5	      $	��700��6   $��Bottom=�6*    J� Effect 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6   	   ShadowDepth$	 5Q�6/   .+�5   
   � -   5        $ 	InnerGrid��5      $	��680��6"   $��Bottom=�6/   $��10,10,10,10q�6J   .+�5      � -   5        $ TitleBar��5      $
��Left=�6%   $��50��6@   $	��Top=�6L   $	��980��6d   ���	#FF333E48.+�5      �� $
��Left=�6   $	��Top=�63   $��30��6K   $��30��6W   $��	10,10,0,0q�6b   $��
Img/DH.ico��6u   �� 5      $
��Left=�6   $��	50,10,0,0q�67   $
��Wrap=�6J   $��P.I. Deployment Helper��6^   $	��Top=�6|   
�������$��20(�6�   $��
Nirmala UI)�6�   �� 5      -   5        $�� ��5      $��Right=�6$   $	��Top=�6@   $��40��6X   $��0,5,10,0q�6c   $��40��6u   $��0q�6�   ��5      �� 5      
 �� ImageSource$
 Img/Close_New.png��6%   5      �� 5      -   5        $�� ��5      $��Right=�6$   $	��Top=�6@   $��40��6X   $��0,5,60,0q�6c   $��40��6u   $��0q�6�   ��5      �� 5      $
 Img/minimize_new.png��6%   5      5      � 5      -   5        $ MenuBar��5      $
��Left=�6$   $	��630��6?   $��
911,50,0,0q�6L   $	��Top=�6`   $��70��6x   ���	#FF00496C6�   � 5      -   5        $ ApplicationGrid��5      $
��Left=�6,   $	��630��6G   $��0,50,0,0q�6T   $	��Top=�6f   $	��911��6~   ���	#FF006DA25      5       5#      5$      