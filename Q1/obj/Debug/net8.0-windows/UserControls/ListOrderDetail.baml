   M S B A M L   `   `   `  ����=  9Q1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Q1.UserControlsQ1.UserControls  5      %    Q1.UserControls.ListOrderDetail   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Q1.UserControls     5      .��5	      � .+�5
   
   ��   �� Orientation$  Vertical=�6   $��	 0,10,0,0q�6,   .+�5      �� $  
Horizontal=�6   .+�5      �� $��Basket��6   $��	10,10,0,0q�6)   $	��Top=�6<   $��80��6U   $��26��6`   �� 5      -   5         ��Name$ BasketComboBox��5      $��0,10,0,0q�63   $	��Top=�6E   $	��200��5      $��26��6    �� DisplayMemberPath$ ShopperEmail��5       �� SelectedValuePath$ BasketId��62   ��5   *   �� *BasketShopperInfo+5   O   5      5      �� 5   
   $  
Horizontal=�6   $��10,70,0,106q�6.   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ OrderDetailDataGrid��5         AutoGenerateColumns$ False��5      "   VerticalScrollBarVisibility$
 Auto=�5         RowBackground
 �����   AlternatingRowBackground
 ��� �$
��Left=�5      $��Stretch=�5      $	��750��5      
�������
���������5      �� *BasketItemInfo+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Basket ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *
IdBasket+  5       $
 BasketItem ID��6)   $	 100 6@    6L   �� *IdBasketItem+  5!      $
 
Product ID��6)   $	 100 6=    6I   �� *	IdProduct+  5"      $
 Product Name��6)   $	 250 6?    6K   �� *ProductName+  5#      $
 
Unit Price��6)   $	 100 6=    6I   �� *Price+ �� StringFormat$ {0:c}��  5$      $
 Quantity��6)   $	 100 6;    6G   �� *
Quantity+5&      5'      5(      5)      