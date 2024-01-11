Näyttöprojekti on peli app jossa on kaksi eri peliä Pong ja Breakout.
Pongissa ohjataan nuolinäppäimellä vasemmalla olevaa pelaajan mailaa ja torjutaan keskellä liikkuvaa palloa ja koitetaan saada se maaliin tietokonetta vastaan.
Breakoutissa ohjataan alhaalla nuolinäppäimillä alhaalla olevaa palkkia jolla kimmotetaan palloa ylöspäin yrittäen tuhota kaikki värilliset palikat.
![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/fa18288a-4425-4417-a44f-4a006eddd791)

Pelin aloitus interface jossa voit valita haluatko pelata Pongia vai Breakouttia.
![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/687b0ef9-a31e-4665-95dc-f86fde93f8b1)


Pong peli jossa näkyy molemmissa ylälaidoissa Pelaajan ja CPUn voitot, keskellä näkyvät pelaajan ja tietokoneen pisteet. Kun jompikumpi saavuttaa 10 pistettä niin peli päättyy ja voittajalle lisätään voittopiste yläkulmaan ja tulee ponnahdus ikkuna kysymään
haluatko aloittaa uuden pelin tai lopettaa.
![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/25baa65e-a566-4c11-a10e-3e729bbafa04)
Jos valitset Kyllä, niin heti alkaa uusi peli ja jos valitset Ei niin se vie sinut takaisin aloitus pelivalikkoon.

Breakoutpeli jossa tarkoitus on saada tuhottua kaikki värilliset palikat, oikeassa ylälaidassa näkyy Score joka kertoo kuinka monta palikkaa olet tuhonnut.

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/05dd51b5-478b-48d5-abe6-809777cf189e)

Jos annat pallon osua "maahan" niin häviät pelin tai jos saat tuhottua kaikki palikat niin voitat ja sitten voit päättää aloitatko uuden pelin vai palaatko takaisin valikkoon.

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/fa6a48e9-1d5d-47c8-a9d8-cea3fb739417)


Tässä näkyy perus koodi pelivalikolle josta valitaan joko pong tai breakout

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/e8319157-59d9-46a4-a7e3-990b0e664ffa)

Tämä tallentaa Pongin pelaaja voitot ja TK voitot pelin sisälle

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/379ad33e-0a4b-4bc0-a613-682d5c3563ff)


Tässä näkyy perus logiikka pallolle ja sille jos saat yli 5 pistettä niin peli alkaa nopeutumaan joka vaikeuttaa palloon osumista.


![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/f3c3dffa-340b-48b9-9fb2-d0998c5d06ec)

Pelaajan mailan liikutus ja uuden pelin aloitus


![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/1b3f82f1-259c-444f-aaed-74e149e17980)


Tästä näkyy Breakoutin koodia jolla luodaan väripalikat joita koitetaan rikkoa 

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/1e0672a7-518f-4b74-a70d-ab302fd376f6)

Tästä löytyy logiikka pelaajan mailalle ja miten se käyttäytyy kun osuu mailaan 

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/dd693da6-8f38-4b2d-a914-a76394543089)

Vuokaavio pelistä

![image](https://github.com/KeppuliHeppuli/Nayttoprojekti/assets/111448248/ae66fc5f-3b00-4d1b-90e5-0ef1a87d55df)


Peliä voisi vielä jatkossa kehittää tekemällä laajemman highscoren, ennakoivan tietokoneen Pongiin ja paremman logiikan pallolle molempiin peliin.






