   M S B A M L   `   `   `  ����E  AQuanLyDiem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:QuanLyDiem
QuanLyDiem  5   	   "    QuanLyDiem.XemThongTinMonHoc   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:QuanLyDiem     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  XemThongTinMonHoc��5	   	   $	��550��6#   $	��800��60    � WindowStartupLocation$ CenterScreen=�6<   .��5
      � 
�������.+�5   
   �� 
��� � �$��2q�6%   $��Center=�69   $	��458��6V   $��0,51,0,0q�6c   $	��Top=�6u   $	��780��6�   �� 5   
   $��Thông tin Học phần��6   $��Center=�6-   $��48��6J   $	��Top=�6V   $	��339��6n   $��0,3,0,0q�6z   $��24(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   
����  �6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dtgMonHoc��5   %      
IsReadOnly$
 True��6      CanUserAddRows$ False��68      AutoGenerateColumns$ False��6O   $
��Left=�6k   $	��300��6�   $��
19,175,0,0q�6�   $	��Top=�6�   $	��751��6�    J� RenderTransformOrigin$ 0.501,0.612&�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã môn học��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 69   �� *MaMh+  5      $ Tên môn học��6%   	 6:   �� *TenMh+  5      $ Số TC (Lý thuyết)��6%   	 6@   �� *
LyThuyet+  5      $ Số TC (Thực hành)��6%   	 6@   �� *
ThucHanh+  5      $ Tổng tín chỉ��6%   	 6;   �� *SoTc+  5      $ 
Học kỳ��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 65   	 6?   �� *Ky+5      �� 5   
   $��Mã môn học:��6   $
��Left=�6&   $��	25,87,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ txtMaMH��5      $��Center=�6$   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$( " Nhập mã môn học muốn tìm��6F   $
��Left=�6�   $��
119,79,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��275��6�   $��32��6�   �� 5   
   -   5         � ToolTip$ Tìm kiếm��5      $
��Left=�6$   $��
395,74,0,0q�6?   $	��Top=�6S   $��37��6k   $��41��6x   ��5      �� 5       �� ImageSource$ Resources\search.png��6   5      �� 5   
   -   5        $��
tbThongBao��5   b    )  %MaterialDesignComboBoxEditableTextBox#��[  6   
���  ��$
��Left=�6t   $��28��6�   $��119,116,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��209��6�   5      5       