using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Stories = 3;
            FiveOneTwoEigth.Width = 50;
            FiveOneTwoEigth.Depth = 100;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Dominic K.");

            Building NineOneNineBSt = new Building("919 B St");
            NineOneNineBSt.Stories = 12;
            NineOneNineBSt.Width = 1000;
            NineOneNineBSt.Depth = 300;
            NineOneNineBSt.Construct();
            NineOneNineBSt.Purchase("Abbey B");

            Building FourOneSpruceSt = new Building("41 Spruce St");
            FourOneSpruceSt.Stories = 2;
            FourOneSpruceSt.Width = 50;
            FourOneSpruceSt.Depth = 50;
            FourOneSpruceSt.Construct();
            FourOneSpruceSt.Purchase("Brian N.");

            Building SixteenNineteenMarshallHollow = new Building("1619 Marshall Hollow");
            SixteenNineteenMarshallHollow.Stories = 3;
            SixteenNineteenMarshallHollow.Width = 20;
            SixteenNineteenMarshallHollow.Depth = 100;
            SixteenNineteenMarshallHollow.Construct();
            SixteenNineteenMarshallHollow.Purchase("Connor B.");

            City ConnorLand= new City("ConnorLand");
            ConnorLand.Elect("Connor");

            ConnorLand.Buildings.Add(FiveOneTwoEigth);
            ConnorLand.Buildings.Add(NineOneNineBSt);
            ConnorLand.Buildings.Add(FourOneSpruceSt);
            ConnorLand.Buildings.Add(SixteenNineteenMarshallHollow);

            ConnorLand.Print();




        }
    }
}
