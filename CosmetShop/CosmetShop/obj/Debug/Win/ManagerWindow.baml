   M S B A M L   `   `   `  ????E  ACosmetShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:CosmetShop.WinCosmetShop.Win  5   	   "    CosmetShop.Win.ManagerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:CosmetShop.Win     5   	     ? Title$  ManagerWindow??5   	    ? WindowState$ 	Maximized=?6    $	??600??68   $	??800??6H    ? Icon$ /Res/icon.ico??6W   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $	??59* ?6   ?? 5      $
??525* ?6   .+?5   
   ? ???#B3F4E9.+?5      ?? $??/Res/logo.png??6   $
??Left=?6+   $??74??6G   5      ?? 5      $??Candara)?6   $??20(?6)   $??Center=?67   $??Center=?6T   $#??Форма Менеджера??6o   5      ? 5   
   -   5         ?Name$ GridContent??5      ???#ebebeb$??1??69    ? ColumnDefinitions 5      ?? 5      $??9* ?6#   ?? 5      $	??41* ?6#   .+?5      ?? $??0??6   $??0 150q?6)   .+?5      ?? -   5         ??Name$ 
AddProduct??5   Z   $
??5 10q?6   $??70??6(   ???#A5E887 ?? CornerRadius$ 5??6I   ._?5      ?? 
???????$??Center=?63   $??18(?6N   $??Center=?6\   .??6?   Заказы6?   5      ?? 5      -   5        $ SeeOrder??5   [   $
??5 10q?6   $??70??6(   ???#A5E887$ 5??6J   ._?5      ?? 
???????$??Center=?63   $??18(?6N   $??Center=?6\   $??Товары??6?   5      5       ?? 5#      
???????$??1q?6(   $ 5??6<   $??1??6M   $??1??6]   ._?5$       ? -   5          ?Name$ 	MainFrame??5$      	  ? NavigationUIVisibility$	 Hidden=?6+   $??1??6K   $??0,-1,0,0q?6X   6m   5%      5&      5'      5(      