﻿namespace Flour.Tests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BCCAD bccad = BCCAD.FromBCCAD(@"C:\Users\Braedon\Desktop\RHModding\RomFS\cellanim\arc\batter_00.bccad");
            for (int i = 0; i < bccad.animations.Count; i++)
            {
                Console.WriteLine(bccad.animations[i].name);
            }
        }
    }
}