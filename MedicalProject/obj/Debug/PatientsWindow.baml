   M S B A M L   `   `   `  ����I  EMedicalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MedicalProjectMedicalProject  5   	   #    MedicalProject.PatientsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MedicalProject     5   	     � Title$  PatientsWindow��5   	    � SizeToContent$ Height=�6    $	��700��67    � WindowStartupLocation$ CenterScreen=�6C   .��5	      �� ���	#FFB8EBF9.+�5   
   �� -   5         ��Name$ backBtn��5      $��zpět��6"   $��Right=�61   $��60��6N   $��25��6Y   6e   �� 5   
   $��List pacientů��6   $��Center=�6(   $��22(�6E   $��Verdana)�6T   $��35��6i   $��10q�6u   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridPatients��5   +      ColumnHeaderHeight$ 30Q�6      
IsReadOnly .    AutoGenerateColumns .     AlternatingRowBackground �	#FFB6B6B6$��Center=�6�   $��Center=�6�   
�������	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Jméno��6%      FontSize$ 20Q�6N      CanUserResize .  1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Jmeno+6\     5      $
 Příjmené��6%   $ 20Q�6T    .   67   �� *
Prijmeni+6b     5      $
 Datum narození��6%   $ 20Q�6w    .   6=   �� *DatumNarozeni+ �� StringFormat$ 
dd-MM-yyyy��6�     5      $
 Rodné číslo��6%   $ 20Q�6Y    .   6:   �� *
RodneCislo+6g     5      $
 Adresa Bydlistě��6%   $ 20Q�6a    .   6>   �� *AdresaBydliste+6o     5      $
 Pojišťovna��6%   $ 20Q�6X    .   69   �� *
Pojistovna+6f     5      $
 Id��6%   $ 20Q�6H    .   61   �� *Id+6V   5      �� 5   
   ���	#FFBBBBBB$	��400��6(   $	��120��64    �� CornerRadius$ 20��6A   $��20q�6S   ._�5      � $��5q�6    � ColumnDefinitions 5      �� 5      $��* �6'   63   �� 5      $��* �6'   63   �� 5      $��* �6'   63    � RowDefinitions 5!      �� 5"      $��* �6$   61   �� 5#      $��* �6$   61   .+�5&      �� -   5        $ AddPatientBtn��5&      $��přidat��60   $��7q�6]   �� 5'      -   5        $ DeletePatientBtn��5'      $��7q�63   $��	odstranit��6>   $��1��6r   �� 5(      -   5        $ EditPatientBtn��5(      $��upravit��61   $��2��6a   $��7q�6q   �� 5*      -   5        $ ShowPatientCard��5*      $��karta pacienta��62   $��3��6i   $
��58,7q�6}   $��1��6�   5,      5-      50      56      