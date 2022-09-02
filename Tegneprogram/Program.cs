using System;
using Tegneprogram;

// Skriv dit program her.
// God fornøjelse 
// JQ2  

// width="412" height="236" 

Tegning olTegning = new Tegning();

// basale værdier der genbruges
int diameter = 90;
int bredde = 412;
int højde = 236;
int spacer = diameter / 2;

// centrummer 
// 1: diameter

double del = bredde / 22;

// https://www.december.com/html/spec/colorsvg.html
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


Cirkel[] mineCirkler = new Cirkel[5];
mineCirkler[0] = c1;
mineCirkler[1] = c2;
mineCirkler[2] = c3;
mineCirkler[3] = c4;
mineCirkler[4] = c5;

Firkant[] mineFirkanter = new Firkant[1];
Firkant f1 = new Firkant("black")
{
    Bredde = bredde,
    Hojde = højde,
};
mineFirkanter[0] = f1;

olTegning.Tegn(mineFirkanter, mineCirkler);




