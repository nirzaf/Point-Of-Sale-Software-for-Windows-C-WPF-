   M S B A M L   `   `   `  ����H  DPosControls, Version=1.0.651.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PosControlsPosControls  5      *    $PosControls.InternetMapViewerControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (myclr-namespace:PosControls     5      .��5	      ]� .+�5
   
   &    PosControls.ConfigurationManager  -   5           Name$  Configuration��5
   "   � 5   
   ��5      �� 5       �� ElementName$ Configuration��6    �� Path$$ BindableControlBackgroundBrush�66    � RowDefinitions 5      �� 5      $
��236* �6    �� 5      $��80 �6    .+�5      ]� 
������ .+�5      '   !PosControls.WebBrowserHostControl  -   5          Name$ 
webBrowser��5   +   5      �� 5      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $��Center=�6Z   .+�5      !   PosControls.TextBlockButton  -   5          Name$ 
buttonTest��5   %   !   PosControls.TextBlockButton   Click$ buttonTest_Click��6�   $��0,0,5,0q�69   $��70��6J   $��64��6U   $��Bottom=�6a   $
��Left=�6|      Text$
 Test��6�   6�     5      -   5        $ buttonClose��5   %   $ buttonClose_Click��6�   $��5,0,0,0q�6:   $��70��6K   $��64��6V   $��Bottom=�6b   $
��Left=�6}   $ Close Window��6�   6�   5      5      5      5      