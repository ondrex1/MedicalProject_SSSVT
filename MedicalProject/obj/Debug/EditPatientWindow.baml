   M S B A M L   `   `   `  ����I  EMedicalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MedicalProjectMedicalProject  5   	   &     MedicalProject.EditPatientWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MedicalProject     5   	     � Title$  EditPatientWindow��5   	   $	��300��6#    � SizeToContent$ Height=�6/    � WindowStartupLocation$ CenterScreen=�6F   .��5	      �� $��15q�6   .+�5
   
   �� .��6   Jméno6   �� 5   
   ��6   �� *Jmeno+6+   �� 5   
   .��6   Příjmení6   �� 5   
   ��6   �� *
Prijmeni+6.   �� 5   
   .��6   Datum narození6    (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$	 DP1��5         SelectedDateFormat$ Short=�6A      FirstDayOfWeek$ Sunday=�6\      SelectedDate$ 
03/02/2021X�6t      Text 6"   �� *DatumNarozeni+6t   �� 5   
   .��6   Rodné číslo6   �� 5   
   ��6   �� *
RodneCislo+60   �� 5   
   .��6   Adresa bydliště6!   �� 5   
   ��6   �� *AdresaBydliste+64   �� 5   
   .��6   Pojišťovna6   �� 5   
   ��6   �� *
Pojistovna+60   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� -   5        	 ��Name$	 OkBtn��5      $��OK��6$   $��10q�61   $��5q�6=   6_   �� 5      -   5        $	 Cancel��5      $��zavřít��6%   $��10q�66   $��5q�6B   6e   5       5!      5"      