# CollectionViewGlitching
I encountered a glitch using Xamarin Forms CollectionView, if the view contains more than 4 rows items start to glitch. This happened under Android 9, kernel version 3.18.91-16642474 Build number PPR1.180610.011. I tried same code on emulator also Android 9 but kernel version 4.4.124+ build number PSR1.18072.117 and worked just fine. 
Once I rotate an item with 180deg and scroll down and up, the UI either hide and other item or flips and another one.  
the problem seems to appear only with the first and last row.
