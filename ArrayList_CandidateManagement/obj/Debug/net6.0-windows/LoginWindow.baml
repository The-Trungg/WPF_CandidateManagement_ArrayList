   M S B A M L   `   `   `  ����!  ArrayList_CandidateManagement/    )ArrayList_CandidateManagement.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login��5   	   $	��568��6   $	��400��6$    � WindowStartupLocation$ CenterScreen=�5   	   ���#F5F5F5 � 	Resources 5      3  -System.Windows.Media.Effects.DropShadowEffect   Z1   
BlurRadius   ShadowDepth   Color  ModernTextBox �� 
TargetType �� Property �� Value	 �� 
TargetType
 ��Name �� CornerRadius J� Effect ��Name �� Triggers P� Property P� Value �� 
TargetName  ModernButton��%_  &	        &	 =     &	 &      5	   
   $ 5Q�6&   $ 1Q�65   $ 	#20000000��6E   �� 5   
   " ��6&   .�5      ��  � ��$ 40��6'   �� 5       � ��$ 14(�6)   �� 5       � ��$
 10,0q�6(   �� 5       � ��$ Center=�69   �� 5       � ��
 �����6+   �� 5       � ��$ 0q�60   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $
 border��6!   $��0q�5   !   
�������$ 5��5   !    5        5   "   $ 5Q�63   $ 1Q�6B   $ 	#20000000��6R   ._�5      �� $ PART_ContentHost��6+   5       5      P� 5       �@J�	IsFocused$
 True��6;   . �5    "   �� $ border��6;    �@J�Effect 5!   &     5"   *   $ 5Q�6;   $ #2196F3��6J   $ 0Q�6Z   5$   #   5%      5'      5)      5*      �� 5,   
   " ��6%   .�5-      ��  � ��$ 40��6'   �� 5.       � ��$ 14(�6)   �� 5/       � ��
 �����6+   �� 50       � �� �#2196F36+   �� 51       � ��$ 0q�60   �� 52       �@�Cursor$
 Hand��6'   �� 53       � �� 54      �� 55      "	 ��6&   .R�56      �� $
 border��6!   #��z��57   !   $��0q�58   !   $ 5��59   !    5:        5;   "   $ 5Q�63   $ 1Q�6B   $ 	#20000000��6R   ._�5=      �� $��Center=�6/   $��Center=�6L   5>       5?      P� 5@       �@J�IsMouseOver$
 True��6=   . �5A   "   ��  � �� �#1976D26?   �� 5B   "    �@J�Effect 5C   &     5D   *   $ 8Q�6;   $ 2Q�6J   $ 	#40000000��6Z   5F   #   5G      5I      5K      5L      5M      .��5O      �� 
�������$��20q�6    $ 10��6,    5P   
     5Q      $ 5Q�6   $ 1Q�6.   $ 	#20000000��6>   ._�5S   
   � $��30q�6    � RowDefinitions 5T      �� 5U      $
��Auto �6    �� 5V      $��* �6    .+�5Y      �� $��Login��6   $��28(�5Z      $��SemiBold"�5[      $��Center=�5\      ���#333333$��0,0,0,40q�5^      �� 5`      $��1��6   .+�5a      �� $��0,0,0,20q�6   .+�5b      �� $��Email��6    $��5,0,0,8q�5c      ���#6666665d      �� 5e      -   5         ��Name$ txtEmail��5e      #��[ 5f      $��admin@hr.com.vn��5g      5h      5i      �� 5k      $��0,0,0,20q�6   .+�5l      �� $��Password��6    $��5,0,0,8q�5m      ���#6666665n      �� 5o      -   5        $ txtPassword��5o      #��[ 5p      $
��123@��5q      5r      5s      �� 5u      $��0,20,0,0q�6   .+�5v      �� -   5         ��Name$ BtnLogin��5v      #��[ 5w      $��Login��5x      $��0,0,0,10q�5y      5z      �� 5|      -   5        $ btnRegister��5|      #��[ 5}      $��Register��5~      ���#4CAF50$��0,0,0,10q�5�      5�      �� 5�      -   5        $ 	BtnCancel��5�      #��[ 5�      $��Cancel��5�      ���#F443365�      5�      5�      5�      5�      5�      