   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      H DPosControls, Version=1.0.651.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PosControlsPosControls 5      ,   &PosControls.GradientBrushEditorControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6sys&clr-namespace:System;assembly=mscorlib     5      (myclr-namespace:PosControls     5      .��5
      ]� -   5        $��mainPane��5
   %   ��. .+�5   
   &   PosControls.ConfigurationManager  -   5           Name$  Configuration��5   "   � 5   
    � ColumnDefinitions 5      �� 5      $	��360 �6#   �� 5      $	��70* �6#   �� 5      $	��250 �6#    � RowDefinitions 5      �� 5      $
��150* �6    �� 5      $
��110* �6    �� 5      $
��110* �6    �� 5      $	��80* �6    �� 5      $��70 �6    ��5      �� 5       �� ElementName$ Configuration��6    �� Path$$ BindableControlBackgroundBrush�66   .+�5      �� -   5        $��stackPanelGradientStops��5       �� Orientation$ Vertical=�68   $��4��6O   .+�5      �� $��Gradient Stops��6   $��Center=�61   $��16(�6L   �� 5      -   5        $��borderGradientStops��5      $	��310��64   $��0,0,5,0q�6A   ._�5      #  PosControls.DragScrollListBox  -   5          Name$# listBoxGradientStopCollection��5   +   #  PosControls.DragScrollListBox   SelectionChanged$4 .listBoxGradientStopCollection_SelectionChanged��6R   ��5       �� 5!      $ borderGradientStops��6&   $ ActualHeight�6H   5#      5$      5%      �� 5&      $ 
Horizontal=�6   $��4��62   $��3��6?   $
��Left=�6S   $	��Top=�6n   .+�5'      !  PosControls.TextBlockButton  -   5          Name$ 	buttonAdd��5'   %   !  PosControls.TextBlockButton	   Click$	 buttonAdd_Click��6e   $��5q�68   $��60��6C   $��52��6N   
   Text$	
 Add��6Z   6e     5(      -   5        $ 
buttonEdit��5(   %   $	 buttonEdit_Click��6y   $��5q�69   $��60��6D   $��52��6O   $

 Edit��6[   {�.  6y     5)      -   5        $ buttonRemove��5)   %   $	 buttonRemove_Click��6}   $��5q�6;   $��60��6F   $��52��6Q   $
 Remove��6]   {�.  6}     5*      -	   5        $ buttonMoveUp��5*   %   $	 buttonMoveUp_Click��6�   $��5q�6;   $��60��6F   $��52��6Q   $
 Move Color Up��6]   {�.  6�     5+      -
   5        $ buttonMoveDown��5+   %   $	 buttonMoveDown_Click��6�   $��5q�6=   $��60��6H   $��52��6S   $
 Move Color Down��6_   {�.  6�   5,        5-      -   5        $ 
buttonSave��5-   !   $	 buttonSave_Click��6�   $��4��65   $��2��6B   $��Right=�6R   $��5,5,10,5q�6n   $��60��6�   $��52��6�   $

 Save��6�   {�.  6�   �� 5.      $ Vertical=�6   $��1��60   .+�5/      �� $��Gradient Type��6   $��Center=�60   $
��Left=�6K   $��16(�6f   !  PosControls.PushRadioButton  50      -   5          Name$ radioButtonLinearGradient��50   %   !  PosControls.PushRadioButton   SelectionGained$/ )radioButtonLinearGradient_SelectionGained��6t   $��32��6H   $��25,5,5,5q�6T      Text$ Linear��6f      
IsSelected . 6�     51      -   5        $ radioButtonRadialGradient��51   %   $/ )radioButtonRadialGradient_SelectionGained��6t   $��32��6H   $��25,5,5,5q�6T   $ Radial��6f   6t   52      �� 53      $��1��6   $��1��6&   .+�54      �� $��Spread Method��6   $��Center=�60   $
��Left=�6K   $��16(�6f     PosControls.PushComboBox  55      -   5          Name$ comboBoxSpreadMethod��55   "   	  PosControls.PushComboBox 	  SelectedIndexChanged$/ )comboBoxSpreadMethod_SelectedIndexChanged��6_   $��	25,5,10,5q�6@   $��35��6S      Items 56      ��57      Pad��6*   ��58      Reflect��6.   ��59      
Repeat��6-      SelectedItem 5;      ��5<      Pad��6*   5>      5?      �� 5@      $��2��6   $��1��6&   .+�5A      �� $��Color Interpolation��6   $��Bottom=�66   $
��Left=�6Q   $��16(�6m     5B      -   5        $$ comboBoxColorInterpolationMode��5B   "   $9 3comboBoxColorInterpolationMode_SelectedIndexChanged��6i   $��	25,5,10,5q�6J   $��35��6]    5C      ��5D      SRgb��6+   ��5E      	ScRgb��6,    5G      ��5H      SRgb��6+   5J      5K      �� 5L      $ Vertical=�6   $��3��60   $��2��6=   $��1��6N   $	��Top=�6^   .+�5M      �� $��Preview��6   $��Center=�6*   $��Center=�6E   $��16(�6b   �� 5N      -   5        $��borderSwatch��5N      $��80��6-   $��80��69   5O      �� 5P      $ Vertical=�6   $��2��60   $��3��6@   .+�5Q      �� $��
Parameters��6   $��Center=�6-   $
��Left=�6H   $��16(�6d   �� 5R      -   5        $ ��stackPanelLinearParameters��5R      $��20,0,0,5q�6?   $ Vertical=�6Q   $��1��6h   $��2��6u   $��2��6�   $��2��6�   .+�5S      �� $ 
Horizontal=�6!   .+�5T      �� $��Start Point:��6    $��Center=�67   $
��Left=�6R   $��70��6m   $��12(�6x   �� 5U      $��X��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  PosControls.CustomTextBox
  5V      -   5         
 Name$ textBoxLinearStartPointX��5V   +     PosControls.CustomTextBox   TextChanged$ textBox_TextChanged��6�    
  UseContextMenuEditing .  
  
PromptType$ FloatNumeric=�6j   $��0,5,0,5q�6�   $��55��6�    
  Text$ 0.000��6�   6�   �� 5W      $��Y��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5X      -   5        $ textBoxLinearStartPointY��5X   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6j   $��0,5,0,5q�6�   $��55��6�   $ 0.000��6�   6�   5Y      �� 5Z      $ 
Horizontal=�6!   .+�5[      �� $��
End Point:��6    $��Center=�65   $
��Left=�6P   $��70��6k   $��12(�6v   �� 5\      $��X��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5]      -   5        $ textBoxLinearEndPointX��5]   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6h   $��0,5,0,5q�6�   $��55��6�   $ 1.000��6�   6�   �� 5^      $��Y��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5_      -   5        $ textBoxLinearEndPointY��5_   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6h   $��0,5,0,5q�6�   $��55��6�   $ 1.000��6�   6�   5`      �� 5a      $ 
Horizontal=�6!   .+�5b      �� $��Opacity��6    $��Center=�62   $
��Left=�6M   $��70��6h   $��12(�6s   
  5c      -   5        $ textBoxLinearOpacity��5c   +   $&  textBoxLinearOpacity_TextChanged��6�    . $ FloatNumeric=�6f   $��20,5,0,5q�6�   $��55��6�   $ 1.000��6�   6�   5d      5e      �� 5f      -   5        $ ��stackPanelRadialParameters��5f      $��20,0,0,5q�6?   $ Vertical=�6Q   $��1��6h   $��2��6u   $��2��6�   $��2��6�   $y�	Collapsed=�6�   .+�5g      �� $ 
Horizontal=�6!   .+�5h      �� $��Origin:��6    $��Center=�62   $
��Left=�6M   $��70��6h   $��12(�6s   �� 5i      $��X��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5j      -   5        $ textBoxOriginX��5j   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6`   $��0,5,0,5q�6z   $��55��6�   $ 0.500��6�   6�   �� 5k      $��Y��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5l      -   5        $ textBoxOriginY��5l   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6`   $��0,5,0,5q�6z   $��55��6�   $ 0.500��6�   6�   5m      �� 5n      $ 
Horizontal=�6!   .+�5o      �� $��Center:��6    $��Center=�62   $
��Left=�6M   $��70��6h   $��12(�6s   �� 5p      $��X��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5q      -   5        $ textBoxCenterX��5q   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6`   $��0,5,0,5q�6z   $��55��6�   $ 0.500��6�   6�   �� 5r      $��Y��6    $��Center=�6,   $
��Left=�6G   $��20��6b   $��12(�6m   
  5s      -   5        $ textBoxCenterY��5s   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6`   $��0,5,0,5q�6z   $��55��6�   $ 0.500��6�   6�   5t      �� 5u      $ 
Horizontal=�6!   .+�5v      �� $��X Radius��6    $��Center=�63   $
��Left=�6N   $��70��6i   $��12(�6t   
  5w      -   5        $ textBoxRadiusX��5w   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6`   $��20,5,0,5q�6z   $��55��6�   $ 0.500��6�   6�   5x      �� 5y      $ 
Horizontal=�6!   .+�5z      �� $��Y Radius��6    $��Center=�63   $
��Left=�6N   $��70��6i   $��12(�6t   
  5{      -   5        $ textBoxRadiusY��5{   +   $ textBox_TextChanged��6�    . $ FloatNumeric=�6`   $��20,5,0,5q�6z   $��55��6�   $ 0.500��6�   6�   5|      �� 5}      $ 
Horizontal=�6!   .+�5~      �� $��Opacity��6    $��Center=�62   $
��Left=�6M   $��70��6h   $��12(�6s   
  5      -   5        $ textBoxRadientOpacity��5   +   $' !textBoxRadientOpacity_TextChanged��6�    . $ FloatNumeric=�6g   $��20,5,0,5q�6�   $��55��6�   $ 1.000��6�   6�   5�      5�      5�      5�      5�      5�      