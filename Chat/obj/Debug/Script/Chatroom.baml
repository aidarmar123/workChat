   M S B A M L   `   `   `  ����?  ;Chat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Chat.ScriptChat.Script  5          Chat.Script.Chatroom   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Chat.Script     5      -   5          N� Title$  Chatroom��5	      .��5      �  J� RenderTransformOrigin$ 
0.49,0.508&�6    � RowDefinitions 5   
   �� 5      �� 5      $	��130 �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   �� .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DGUsers��5         
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *Employee.Name+5      5      �� 5   
   $��Bottom=�6   .+�5       �� -   5        	 ��Name$	 BAddUser��5       $��Add User��5"      �� 5#      -   5        $	 BChangeTopic��5#      $��Change Topic��5%      �� 5&      -   5        $	 BLeaveChartroom��5&      $��Leave Chartroom��5(      5)        5*   
   -   5        $ 	DGMessage��5+      $��1��5*       .  .   5.        50       6%   �� *Date+4  .System.Windows.Controls.DataGridTemplateColumn  51      
   CellTemplate
 52      �� 53      .R�54      �� $��50��55      ��54   $   �� *Employee.Photo+55      56      58        59       6%   �� *Employee.Name+  5;      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5<   %    5;   %   �� *	Message+5<   %     5=      
 5>      �� 5?      .R�5@      �� $	��100��5A   %   ��5@   $   �� *Image+5A   %   5B      5D      5G      �� 5I   
   $��2��6   $��1��6)    �� Orientation$ 
Horizontal=�66   .+�5J      �� -   5         ��Name$ TBSendMessage��5J      $	��500��5K       �� 	MaxLength$ 50��5L       �� TextWrapping$
 Wrap=�5M      �� 5N      -   5         ��Name$ 
ISendPhoto��5N      $	��100��5P      ��5O      �� *Image+5P      �� 5Q      -	   5        $	 BSend��5Q      $
��Send��5S      $	��100��5T      
����ح�5U      �� 5V      -
   5        $	 	BAddImage��5V      $��	Add Image��5X      $	��100��5Y      
����ح�5Z      5[      5\      5]      