   M S B A M L   `   `   `  ����?  ;Chat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Chat.ScriptChat.Script  5   	   "    Chat.Script.RegestrionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Chat.Script     5   	     � Title$  RegestrionWindow��5   	   $	��450��6"   $	��550��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Center=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�5      .+�5      �� $
��Name��6   $��10q�5      $��Center=�5      �� 5      $	��200��6    �� TextWrapping$
 Wrap=�5      $��10q�5      ��5      �� *Name+5      5      �� 5      $ 
Horizontal=�6   $��Right=�5      .+�5!      �� $��
Department��6   $��10q�5"      �� 5#      -   5         ��Name$ CBDepartment��5#       �� DisplayMemberPath$
 Name��5%      $	��200��5&      $��10q�5'       �� SelectedIndex 5$      �� *DepartmentId+5'      5(      �� 5*      $ 
Horizontal=�6   $��Right=�5+      .+�5,      �� $��Username��6   $��10q�5-      �� 5.      $	��200��6   $
 Wrap=�5/      $��10q�50      ��51      �� *
Username+52      �� 53      $ 
Horizontal=�6   $��Right=�54      .+�55      �� $��Password��6   $��10q�56      �� 57      $	��200��58      $
 Wrap=�59      $��10q�5:      ��57      �� *
Password+5:      5;      �� 5<      $ 
Horizontal=�6   .+�5>      �� $��Photo��6   $��Center=�5?      $��10q�5@      �� 5A      $	��100��5B      $��10q�5C      ��5A      �� *Photo+5C      5D      �� 5E      -   5         ��Name$ 	BAddImage��5E      $��	Add Image��5F      $��10q�5H      $��25��5I      �� 5J      -   5        $	 BOk��5J      $��Ok��5L      $��10q�5M      $��25��5N      
����ح�5O      5Q      5U      5V      