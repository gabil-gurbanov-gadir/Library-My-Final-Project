   M S B A M L   `   `   `  ����P  LLibrary-Final Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Library_Final_Project.WindowsLibrary_Final_Project.Windows  5   	   /    )Library_Final_Project.Windows.UsersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:Library_Final_Project.Windows     5   	     � Title$  İdareçi Lövhəsi��5   	   $	��480��6!   $	��694��6.   .��5	      � .+�5
   
   � $��	0,0,494,0q�6   .+�5      �� -   5         ��Name$ LblName��5      $��Ad��6%   $
��Left=�62   $��	30,16,0,0q�6M   $	��Top=�6`   $	��145��6x   $
��Bold"�6�   �� 5      -   5         ��Name$ TxtName��5      $
��Left=�6'   $��	30,45,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��145��6�   �� 5      -   5        $ 
LblSurname��5      $��Soyad��6(   $
��Left=�68   $��	30,95,0,0q�6S   $	��Top=�6f   $	��145��6~   $
��Bold"�6�   �� 5      -   5        $ 
TxtSurname��5      $
��Left=�6*   $��
30,124,0,0q�6E   $
 Wrap=�6Y   $	��Top=�6m   $	��145��6�   �� 5      -   5        $ LblLogin��5      $��İstifadəçi adı��6&   $
��Left=�6?   $��
30,170,0,0q�6Z   $	��Top=�6n   $	��145��6�   $
��Bold"�6�   �� 5      -   5        $ TxtLogin��5      $
��Left=�6(   $��
30,199,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��145��6�   �� 5      -   5        $ LblPassword��5      $��Şifrə��6)   $
��Left=�69   $��
30,245,0,0q�6T   $	��Top=�6h   $	��145��6�   $
��Bold"�6�   �� 5      -   5        $ TxtPassword��5      $
��Left=�6+   $��
30,274,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��145��6�   �� 5      -	   5         ��Name$ 	BtnCreate��5      $��	Qeydiyyat��6(   $��Center=�6<   $��	0,348,0,0q�6Y   $	��Top=�6l   $	��148��6�   6�   �� 5      -
   5        $ 	BtnUpdate��5      $��Yenile��6(   $��Center=�69   $��	0,316,0,0q�6V   $	��Top=�6i   $	��148��6�   $y�Hidden=�6�   ���	#FF0F9C67���	#FF0844486�   �� 5      -   5        $ 	BtnDelete��5      $	��Sil��6(   $��Center=�66   $��	0,380,0,0q�6S   $	��Top=�6f   $	��148��6~   $y�Hidden=�6�   ���	#FFD93535���	#FF80100B6�   5      � 5   
   $��	200,0,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DgvUsers��5         
IsReadOnly$
 True��6)      CanUserAddRows$ False��6;      AutoGenerateColumns$ False��6R   $��10,10,10,10q�6n   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.10* 6)      Header$ Id��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Id+  5      $
 0.18* 6)   $ Ad��67    6C   �� *Name+  5      $
 0.23* 6)   $ Soyad��67    6F   �� *	Surname+  5      $
 0.30* 6)   $ İstifadəçi adı��67    6O   �� *
Username+  5      $
 0.30* 6)   $ Şifrə��67    6F   �� *
Password+5       5"      5#      5$      