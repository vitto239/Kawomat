   M S B A M L   `   `   `  ����B  >kawomat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:kawomatkawomat  5   	       kawomat.BartenderView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:kawomat     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $��933.738��6)   .��5	      � -   5         �Name$ myGrid��5	      $��10,10,10,10q�6    � RowDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ stcpCoffeSize��5      $
��Left=�6,   $��	10,10,0,0q�6G   $	��Top=�6Z   .+�5      �� -   5         ��Name$ btnSmallCoffe��5      $��Small Coffe��6,   $��Stretch=�6B   $��Stretch=�6`   $	��154��6|   $	��120��6�   $��20(�6�   ���	#FFD188CD6�   �� 5      -   5        $ btnMediumCoffe��5      $��Medium Coffe��6-   $��Stretch=�6D   $��Stretch=�6b   $	��154��6~   $	��120��6�   $��20(�6�   ���	#FFD188CD6�   �� 5      -   5        $ btnBigCoffe��5      $��	Big Coffe��6*   $��Stretch=�6>   $��Stretch=�6\   $	��154��6x   $	��120��6�   $��20(�6�   ���	#FFD188CD6�   5      �� 5   
   -   5        $ stcpAddMenu��5      $
��Left=�6*   $��
184,10,0,0q�6E   $	��Top=�6Y   $	��143��6q   .+�5      �� -   5        $ btnwithMilk��5      $��	With Milk��6*   $��Stretch=�6>   $��Stretch=�6Z   $��90��6x   $��16(�6�   ���	#FFDEC46A6�   �� 5      -	   5        $ btnwithCardamon��5      $��With Cardamon��6.   $��Stretch=�6F   $��Stretch=�6b   $��90��6�   $��16(�6�   ���	#FFDEC46A6�   �� 5      -
   5        $ btnwithWhisky��5      $��With Whisky��6,   $��Stretch=�6B   $��Stretch=�6^   $��90��6|   $��16(�6�   ���	#FFDEC46A6�   �� 5      -   5        $ btnwithIceCream��5      $��With IceCream��6.   $��Stretch=�6F   $��Stretch=�6b   $��90��6�   $��16(�6�   ���	#FFDEC46A6�   5      �� 5   
   $
��Left=�6   $��
340,10,0,0q�60   $	��Top=�6D   .+�5      �� -   5        $ btnPlus��5      $��+��6&   $��Stretch=�62   $��Stretch=�6P   $��45��6l   $��45��6w   $��20(�6�   ���	#FFA4DFF56�   �� 5      -   5        $ btnMinus��5      $��-��6'   $��Stretch=�63   $��Stretch=�6Q   $��45��6m   $��45��6x   $��20(�6�   ���	#FFA4DFF56�   5      �� 5   
   -   5         ��Name$ txbOuantinity��5      $��1��6)   $��402,19,393,299q�62   $��60(�6J   $��Center=�6X   6|   �� 5   
   -   5        $ btnAddToBill��5      $��Add item to bill��6'   $
��Left=�6B   $	��216��6]   $��340,154,0,0q�6j   $	��Top=�6   $	��173��6�   $��16(�6�   ���	#FFA4DFF56�   �� 5   
   -   5         ��Name$ tblQuantinity��5      $��18(�6+    �� TextAlignment$ Center=�69   $
��Left=�6P   $��30��6k   $��340,119,0,0q�6w   $
��Wrap=�6�   $��
quantinity��6�   $	��Top=�6�   $	��125��6�   �� 5   
   -   5        $ btnSendOrder��5      $��
Send Order��6'   $
��Left=�6<   $	��351��6W   $��
780,19,0,0q�6d   $	��Top=�6x   $	��112��6�   ���	#FFA4DFF5$��20(�6�   6�   �� 5    
   -   5         ��Name$ 
lstvOrders��5       $��Visible=�6'   $��Stretch=�6\   $
��Left=�6�   $	��351��6�   $��
529,19,0,0q�6�   $	��Top=�6�   $	��235��6�   	 �� View	 5!      �� 5"      .P�5#      �� 5$      5&      5'      5(      