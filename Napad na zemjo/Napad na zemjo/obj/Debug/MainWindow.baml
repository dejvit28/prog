   M S B A M L   `   `   `  ????I  ENapad na zemjo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Napad_na_zemjoNapad_na_zemjo  5   	       Napad_na_zemjo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Napad_na_zemjo     5   	     ? Title$  Napad na zemljo??5   	   $	??800??6!   $
??1000??6.    ? 	Resources 5	         predlogaSovražnika ?? 
TargetType??%?   &	        ?? 5
   
   " ??65   .R?5      ? .+?5      A? $??Center=?6   $	??100??67   
???   ?$??Center=?6S   $	??100??6n   
???  ??6?   5      5      5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      $??* ?6   ?? 5      $	??100 ?6    ? RowDefinitions 5   
   ?? 5      $	??100 ?6   ?? 5      ?? 5      $	??100 ?6   .+?5   
   ?? $??1??6   $??Center=?6$   $??WrapWithOverflow=?6A   $??Napad na zemljo  ??6a   $	??350??6z    ?? TextAlignment$ Center=?6?   $??Center=?6?   $??30(?6?   $??37??6?   $
??Bold"?6?   ?? 5   
   $	??100??6   $	??100??6   ?? 5   
   -   5         ??Name$ btnstart??5      $??Start??6#   $??2??63   $??	0,17,0,17q?6W   $??50??6j   $??80??6v   ? 5   
   -   5         ?Name$ prgIgra??5      $??1??6'   $??2??67   $??16(?6D   $??20??6R   ?? 5    
   $??2??6    ?? Orientation$ Vertical=?6%   $??2??6<   .+?5!      ?? $ Vertical=?6   .+?5"      ?? $
??Wrap=?6   $??Izogibaj se??60   	 J? RenderTransformOrigin$	 0.5,0.5&?6C   5$      ?? 5%      $??81??6!   $	 0.5,0.5&?6-   z?5&      V? 5'      .~?5(      ?? ?? 5)      
 ?? AngleX$
 -0.817Q?6,   ?? 5*      T? 5+       T? X$ -0.578Q?61   5,      .??5.      A? $??81??6   
???   ?$	??Top=?69   $??81??6Q   
???  ??6\   5/      50      51      ?? 52   
   -   5         ??Name$ 
igralniDel??52      $??1??6%   $??3??62   ??53      ?? 54       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??55      ?  ? Color$ white??6#   ? 56      $ 	#FF9BD043??6#    ? Offset$ 1Q?65   ? 57      $ 	#FFB3FF98??6#   $ 0.005Q?65   ? 58      $ 	#FFADADAD??6#   $ 0.513Q?65   59      .+?5;      ?? -   5         ??Name$ človek??5;      .+?5<      A? 
???????$??10??6'   $??10??63   ?? 5=      
???????$??25??6)   $??10??65   5>      ?? 5?      $	??100??6    ?? Left$	 404??6%   
???   ?
 ?? Top$	 453??6F   $	??100??6W   $	 0.501,0.476&?6c   z?5@      V? 5A      .~?5B      ?? ?? 5C      ?? 5D       ?? Angle$ 51Q?6*   T? 5E      $ 1.828Q?6-    T? Y$ 0.967Q?67   5F      ??5H      ?? 5I      $ 0.5,1&?6*   $ 0.5,0&?6;   .??5J      ? $ Black??6'   ? 5K      $ White??6'   $ 1Q?65   5L      5N      ?? 5O      $	 257??6   $
??Wrap=?6*   $??
Konec igre??6>   $ 31??6P   
???????$??50(?6s   $
??Bold"?6?   $y?	Collapsed=?6?   5P      5S      5T      