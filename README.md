os
==

OS: VM ir RM

VM
--
Realus adresas = 10*[10*(10 * a2 + a3) + x1] + x2
 
Virtualios mašinos kūrimo ir veiklos scenarijus žvelgiant iš atminties pusės būtų toks: 
 
1. Pradėta kurti virtuali mašina. 
2. Virtuali mašina reikalauja 10 takelių atminties savo reikmėms. 
3. Yra išskiriama 10 takelių virtualiai mašinai. 
4. Yra išskiriamas 1 takelis virtualios mašinos puslapių lentelei. 
5. Puslapių lentelė (t.y. tas takelis)yra užpildomas išskirtų 10 takelių realiais adresais. 
6. Virtualios mašinos virtualaus registro PTR reikšmei priskiriamas puslapių lentelės 
takelio realus adresas. 
7. Virtuali mašina baigiama kurti. 
8. Virtuali mašina gauna procesorių. 
 99. Virtualiai mašinai prireikė paversti virtualų adresą 50 (t.y. penktas takelis, parinkta 
atsitiktinai) realiu. 
10. Virtuali mašina iš puslapių lentelės nuskaito 5 žodį. Tai ir yra realus adresas. 
11. Taip toliau 


Literatura
--
* [Magistrinis](http://kurti.lt/OS/Knygos/Giedrius%20Siaulys%20-%20Mokomoji%20OS.pdf)
* [Destytojo patarimai](http://uosis.mif.vu.lt/~meglinskas/os/)
* [Reikalavimai](http://kurti.lt/OS/?page=reikalavimai_2)
