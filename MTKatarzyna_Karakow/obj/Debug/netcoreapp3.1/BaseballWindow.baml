   M S B A M L   `   `   `  ����N  JMTKatarzyna_Karakow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:MTKatarzyna_KarakowMTKatarzyna_Karakow  5   	   (    "MTKatarzyna_Karakow.BaseballWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:MTKatarzyna_Karakow     5   	   -   5          � Title$  BaseballWindow��5   	   $	��450��6    $	��800��6-   .��5	      �� $��0,0,0,-6q�6   .+�5
   
   �� -   5         ��Name$ lstBaseball��5
      $	��274��6'   $	��320��64    �� Left$ 80��6@   
 �� Top$ 57��6Q   6a   �� 5   
   -   5         ��Name$ lblBaseball��5      $��Baseball Players��6%   $	 194��6@   $��29��6R   $��99��6^   $ 24��6i    J� RenderTransformOrigin$ 0.5,0.5&�6y   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.111Q�6&   T� 5      5      5      �� 5   
   -   5         ��Name$ 	btnInsert��5      $��Insert��6$   $	 143��65   $	 356��6G   $��37��6X   $	��118��6d   6p   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $	 341��65   $	 356��6G   $��37��6X   $	��118��6d   6p   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $	 542��65   $	 356��6G   $��37��6X   $	��118��6d   6p   �� 5   
   $��	Player ID��6   $	 432��6$   $ 74��66   $��92��6F   �� 5   
   $��Player Name��6   $	 432��6&   $	 114��68   $��92��6I   �� 5   
   $��	Team Name��6   $	 432��6$   $	 160��66   $��92��6G   �� 5   
   $��Games Played��6   $	 432��6'   $	 202��69   $��92��6J   �� 5   
   $
��Runs��6   $	 432��6   $	 242��61   $��92��6B   �� 5   
   $��	Home Runs��6   $	 432��6$   $	 285��66   $��92��6G   �� 5   
   -   5         ��Name$ txtIDB��5      $	 572��6"   $ 78��64   	 �� TextWrapping$
	 Wrap=�6D   $	��150��6X   �� 5   
   -   5        $ txtPlayerNameB��5      $	 572��6*   $	 118��6<   $
	 Wrap=�6M   $	��150��6a   �� 5    
   -	   5        $ txtTeamNameB��5       $	 572��6(   $	 164��6:   $
	 Wrap=�6K   $	��150��6_   �� 5!   
   -
   5        $ txtGamesPlayedB��5!      $	 572��6+   $	 206��6=   $
	 Wrap=�6N   $	��150��6b   �� 5"   
   -   5        $ txtRunsB��5"      $	 572��6$   $	 246��66   $
	 Wrap=�6G   $	��150��6[   �� 5#   
   -   5        $ txtHomeRunsB��5#      $	 572��6(   $	 289��6:   $
	 Wrap=�6K   $	��150��6_   5%      5&      