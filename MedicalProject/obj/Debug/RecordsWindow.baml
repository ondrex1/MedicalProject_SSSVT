   M S B A M L   `   `   `  ����I  EMedicalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MedicalProjectMedicalProject  5   	   "    MedicalProject.RecordsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MedicalProject     5   	     � Title$  RecordsWindow��5   	   $	��500��6    � SizeToContent$ Width=�6,   .��5	      � ���	#FFB8EBF9 � ColumnDefinitions 5
   
   �� 5      $	��100 �6   6-   �� 5      $	��100 �6   6-   �� 5      $	��120 �6   6-   �� 5      $	��120 �6   6-   �� 5      $	��120 �6   6-   �� 5      $	��120 �6   6-   �� 5      $	��100 �6   6-   �� 5      $��60 �6   6,    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      $��30 �6   6*   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� -   5         ��Name$ backBtn��5   !   $��7��6   $��Right=�62   $��40��6N   $��30��6Y   $	��Top=�6e   $��zpět��6}   6�   �� 5   
   -   5        $ 	AddRecord��5      $��3��6$   $��3��64   $��10q�6A   $��přidat záznam��6M   6   �� 5   
   -   5        $ removeRecord��5      $��3��6'   $��4��64   $��10q�6D   $��odstranit záznam��6P   6�   �� 5   
   -   5        $ 
editRecord��5      $��3��6%   $��5��62   $��10q�6B   $��upravit záznam��6N   6�   �� 5!   
   $��1��6   $��Jméno��6   $��Center=�6-   $��12(�6J   $��	28,0,22,0q�6X   $��50��6k   6x   �� 5"   
   -   5         ��Name$ 
RecordName��5"      $��2��6)   $��0��66   $��20(�6F   $��Center=�6U   $	��Top=�6r   $��jmeno��6�   6�   �� 5#   
   $��1��6   $��1��6   $��Příjmení��6-   $��Center=�6@   $��12(�6]   6m   �� 5$   
   -   5        $ RecordSurname��5$      $��2��6+   $��1��68   $��20(�6H   $��Příjmení��6V   $��Center=�6g   $	��Top=�6�   6�   �� 5%   
   $��1��6   $��2��6   $��Datum narození��6-   $��Center=�6F   $��12(�6c   6s   �� 5&   
   -   5        $ 
RecordDate��5&      $��2��6(   $��2��65   $��Center=�6F   $	��Top=�6c   $��Dat.Nar��6{   $��17(�6�   6�   �� 5'   
   $��1��6   $��3��6   $��Adresa bydliště��6-   $��Center=�6G   $��12(�6d   6t   �� 5(   
   -   5        $ RecordStreet��5(      $��2��6*   $��3��67   $��Center=�6H   $	��Top=�6e   $��Adresa byd.��6}   $��20(�6�   6�   �� 5)   
   $��1��6   $��4��6   $��Rodné číslo��6-   $��Center=�6C   $��12(�6`   6p   �� 5*   
   -	   5        $ RecordNumber��5*      $��2��6*   $��4��67   $��20(�6G   $��	Rodne č.��6U   $	��Top=�6e   $��Center=�6}   6�   �� 5+   
   $��1��6   $��5��6   $��Pojišťovna��6-   $��Center=�6B   $��12(�6_   6o   �� 5,   
   -
   5        $ RecordInsurance��5,      $��
Pojistovna��6-   $��20(�6?   $	��top=�6M   $��Center=�6e   $��5��6�   $��2��6�   6�   �� 5.   
   $��Id��6   $��12(�6   $��1��6+   $��6��68   $��Center=�6H   6g   �� 5/   
   -   5        $ RecordId��5/      $��Id��6&   $��20(�60   $	��top=�6>   $��Center=�6V   $��6��6s   $��2��6�   6�   &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ RecordsDataGrid��52      $��8��6,   $��4��6@      AutoGenerateColumns .  ���	#FFB8EBF9   Columns 53      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+6J     57      $	 Datum vzniku��6%   
 6;   �� *DatumVzniku+6]     59      $	 Ošetřující lékař��6%   
 6?   �� *OsetrujiciLekar+6e     5;      $	 Objektivní popis��6%   
 6?   �� *ObjektivniPopis+6e     5=      $
	 Stav��6%   
 63   �� *Stav+6O     5?      $	 Subjektivni popis��6%   
 6@   �� *SubjektivniPopis+6g     5A      $	 Medikace��6%   
 67   �� *
Medikace+6V     5C      $	 Datum kontroly��6%   
 6=   �� *DatumKontroly+6a     5E      $	 Id pacienta��6%   
 6:   �� *
IdPacienta+6[     5G      $	 id kontrola��6%   
 6:   �� *
IdKontrola+6[   5I      5J      5L      