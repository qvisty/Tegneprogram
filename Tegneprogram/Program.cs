using System;
using System.Collections.Generic;
using Tegneprogram;

// Skriv dit program her.
// God fornøjelse 

// width="412" height="236" = Fundet i billedet på opgaven 

// Laver en ny tegning til at tegne på
Tegning olTegning = new Tegning();

// basale værdier der genbruges
int diameter = 90;
int bredde = 412;
int højde = 236;

// Jeg har fundet et billede, hvor jeg ca aflæste at modellen kan deles i 22 stykker jeg kan gange op
// det endte med næste at fungere :) 
double del = bredde / 22;

// Laver en liste til Cirkler, som jeg laver .ToArray() på nederst. Jeg kan bedre lide at arbejde med liste<>.Add() istedet for at arbejde med Array[antal]. Det virker mere dynamisk
List<Cirkel> mineCirkler = new();

// Laver de fem cirkler manuel. Jeg prøvede at lave noget dynamisk med en løkke, men det var for svært at få helt godt.
Cirkel c1 = new Cirkel("blue")
{
    X = Convert.ToInt32(4*del),
    Y = diameter,
    Diameter = diameter,
};

Cirkel c2 = new Cirkel("black")
{
    X = Convert.ToInt32(10.5*del),
    Y = diameter,
    Diameter = diameter,
};

Cirkel c3 = new Cirkel("red")
{
    X = Convert.ToInt32(17*del),
    Y = diameter,
    Diameter = diameter,
};

Cirkel c4 = new Cirkel("yellow")
{
    X = Convert.ToInt32(7.25*del),
    Y = Convert.ToInt32(7 * del),
    Diameter = diameter,
};

Cirkel c5 = new Cirkel("green")
{
    X = Convert.ToInt32(13.75*del),
    Y = Convert.ToInt32(7 * del),
    Diameter = diameter,
};


//List<> løsningen
mineCirkler.Add(c1);
mineCirkler.Add(c2);
mineCirkler.Add(c3);
mineCirkler.Add(c4);
mineCirkler.Add(c5);

/* Array-løsningen. Men jeg kunne bedre lidt List<>
Cirkel[] mineCirkler = new Cirkel[5];
mineCirkler[0] = c1;
mineCirkler[1] = c2;
mineCirkler[2] = c3;
mineCirkler[3] = c4;
mineCirkler[4] = c5;
*/

// Så laver vi vores firkant
Firkant[] mineFirkanter = new Firkant[1];
Firkant f1 = new Firkant("black")
{
    Bredde = bredde,
    Hojde = højde,
};

// med kun een firkant virker det omstændigt. Men jeg kunne ikke lure at lave [] direkte i .Tegn nedenfor 
mineFirkanter[0] = f1;

olTegning.Tegn(mineFirkanter, mineCirkler.ToArray());

// Array-løsningen:
//olTegning.Tegn(mineFirkanter, mineCirkler);