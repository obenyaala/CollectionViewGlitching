# CollectionViewGlitching
I encountered a glitch using Xamarin Forms CollectionView, if the view contains more than 4 rows items start to glitch. This happened under Android 9, kernel version 3.18.91-16642474. 
Once I rotate an item with 180deg and scroll down and up, the UI either hide and other item or flips and another one.  
the problem seems to appear only with the first and last row.
