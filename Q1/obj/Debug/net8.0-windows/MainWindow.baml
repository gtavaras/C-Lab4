   M S B A M L   `   `   `  ����=  9Q1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Q1.UserControlsQ1.UserControls  5   	   -clr-namespace:Q1.ViewModelsQ1.ViewModels  5   	       Q1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Q1.UserControls     5   	   1	viewModelclr-namespace:Q1.ViewModels     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)    � 	Resources 5       �� DataType,   &Q1.ViewModels.ListOrderDetailViewModel%   Q1.UserControls.ListOrderDetail+   %Q1.ViewModels.AddItemToOrderViewModel$   Q1.UserControls.AddItemToOrder��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5       � DataContext 5      '   !Q1.ViewModels.MainWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5    
   �� 
�����_�._�5!      ��  �� Orientation$ 
Horizontal=�6   $��Center=�5"      .+�5#      �� $��Manage Orders��6   $��24(�5$      $��Center=�5%      $��Ink Free)�5&      5'      5(      �� 5)   
   $��1��6   $ 
Horizontal=�5*      .+�5+      �� $��List Order Details��6   $	��150��5,      
����d�
��� �����5/      �� *View1Command+�� 50      $��Add Item to Order��6   $	��150��51      
����ح�
��� �����54      �� *View2Command+55      �� 56      $
��Exit��6   $	��150��57      
����d�
��� �����5:      �� *ExitCommand+5<      �� 5=   
   $��2��6   ��5>      �� *CurrentViewModel+6/   5@      5A      