   M S B A M L   `   `   `  ????E  ACosmetShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CosmetShop.PagesCosmetShop.Pages  5          CosmetShop.Pages.Product   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:CosmetShop.Pages     5        N? Title$  Product??5	       ? 	Resources 5         
itemsstyle ?? 
TargetType??%E   &	        ?? 5   
   " ??6#   .?5      -   5        5      5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   6,   ?? 5      $??* ?6   6)   .+?5   
   ?  ? Orientation$ 
Horizontal=?6   $??Center=?6-   .+?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $	??175??6    ?? TextAlignment$ Right=?6(   64Введите название для поиска:6]   ?? 5      -   5        $??
TBoxSearch??5   &   $	??225??6   6_   5      5      ?? 5   
   -   5        $??
LViewTours??5   Q   #??[  6   $??1??6D   $??Disabled=?6c   ??5      ?? 5      .R?5      ?  ? ColumnDefinitions 5      ?? 5       $	??200 ?6/   6=   ?? 5!      $??8* ?6/   6?    5#      ?? 5$      $??40 ?6,   6:   ?? 5%      $	??150 ?6,   .+?5)      ?? $	??180??6    $??1??6,   $
??Fill=?6:   $
??Left=?6I   $??5q?6e   ??5*      ?? 5+   "    ?? Path$ Preview?6*   5-   #   5/      ?? 53      $??1??6%   $??1??62   $??Center=?6B   .+?54      ?? $	??Top=?6=   $??15(?6U   $
??Bold"?6c   $??1??6u   ??6$   ?? *Name+6?   ?? 55      $
??1000??6f   $	??Top=?6s   $??14(?6?   $
??Wrap=?6?   $??1??6?   $??1??6?   ??6(   ?? *Description+	 ?? StringFormat$	 Описание: {0:N2}??6?   ?? 56      $??1??6k   $??1??6x   $??14(?6?   $
??Left=?6?   ??6(   ?? *Manufacturer+$(	 "Производитель: {0:N2}??6?   ?? 57      $??1??6[   $??1??6h   $??14(?6x   $
??Left=?6?   ??6(   ?? *Cost+$	 Цена: {0:N2}??6?   ?? 58      $??1??6l   $??1??6y   $??14(?6?   $??Right=?6?   $??Center=?6?   ??6(   ?? *CurrentSale+$)	 #Текущая скидка: {0:N2}??6?   59      5:      5;      5=      5>      5?      