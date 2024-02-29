using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stardrop_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 1000000;

            int original = input;
            input = input / 1000000;

            int coins = 0;
            int power = 0;
            int doubler = 0;
            int bling = 0;
            int cred = 0;

            int gadget = 0;
            int sp = 0;
            int charge = 0;

            int spray = 0;
            int icon = 0;
            int[] pin = new int[3];
            int[] skin = new int[3];
            int[] brawler = new int[5];

            int rarity = 0;

            //Rare
            rarity = 50;

            coins += input * rarity * 4185 * 50;
            power += input * rarity * 3256 * 25;
            doubler += input * rarity * 2093 * 100;
            bling += input * rarity * 233 * 20;
            cred += input * rarity * 233 * 10;

            //SuperRare
            rarity = 28;

            coins += input * rarity * 4238 * 100;
            power += input * rarity * 3311 * 50;
            doubler += input * rarity * 1325 * 200;
            bling += input * rarity * 331 * 50;
            cred += input * rarity * 331 * 30;

            pin[0] += input * rarity * 331;
            spray += input * rarity * 132;

            //Epic
            rarity = 15;

            coins += input * rarity * 2105 * 200;
            power += input * rarity * 2105 * 100;
            doubler += input * rarity * 1053 * 500;

            pin[0] += input * rarity * 1579;
            spray += input * rarity * 1579;
            brawler[0] += input * rarity * 526;
            pin[1] += input * rarity * 526;
            skin[0] += input * rarity * 526;

            //Myth
            rarity = 5;

            coins += input * rarity * 949 * 500;
            power += input * rarity * 1899 * 200;

            gadget += input * rarity * 1582;

            pin[1] += input * rarity * 633;
            spray += input * rarity * 633;
            brawler[1] += input * rarity * 949;
            brawler[2] += input * rarity * 633;
            skin[0] += input * rarity * 1582;
            icon += input * rarity * 633;
            pin[2] +=   input * rarity * 316;
            brawler[3] += input * rarity * 190;

            //Legendary
            rarity = 2;

            skin[1] += input * rarity * 3587;
            sp += input * rarity * 2717;
            charge += input * rarity * 1630;
            brawler[2] += input * rarity * 1087;
            brawler[3] += input * rarity * 453;
            skin[2] += input * rarity * 217;
            brawler[4] += input * rarity * 217;


            Console.WriteLine
            (
            $"Coins: {coins} - On average: {coins / (double)original} \n" +
            $"Power Points: {power} - On average: {power / (double)original} \n" +
            $"Doublers: {doubler} - On average: {doubler / (double)original} \n" +
            $"Bling: {bling} - On average: {bling / (double)original} \n" +
            $"Credits: {cred} - On average: {cred / (double)original} \n\n" +
            $"Gadgets: {gadget} - On average: {gadget / (double)original} \n" +
            $"Starpowers: {sp} - On average: {sp / (double)original} \n" +
            $"Hypercharges: {charge} - On average: {charge / (double)original} \n\n" +
            $"Sprays: {spray} - On average: {spray / (double)original}  \n" +
            $"Icons: {icon} - On average: {icon / (double)original}  \n\n" +
            $"Common Pins: {pin[0]} - On average: {pin[0] / (double)original} \n" +
            $"Rare Pins: {pin[1]} - On average: {pin[1] / (double)original} \n" +
            $"Epic Pins: {pin[2]} - On average: {pin[2] / (double)original} \n\n" +
            $"Rare Skins: {skin[0]} - On average: {skin[0] / (double)original} \n" +
            $"Super Rare Skin: {skin[1]} - On average: {skin[1] / (double)original} \n" +
            $"Epic Skin: {skin[2]} - On average: {skin[2] / (double)original} \n\n" +
            $"Rare Brawler: {brawler[0]} - On average: {brawler[0] / (double)original} \n" +
            $"Super Rare Brawler: {brawler[1]} - On average: {brawler[1] / (double)original} \n" +
            $"Epic Brawler: {brawler[2]} - On average: {brawler[2] / (double)original} \n" +
            $"Mythic Brawler: {brawler[3]} - On average: {brawler[3] / (double)original} \n" +
            $"Legendary Brawler: {brawler[4]} - On average: {brawler[4] / (double)original}"
            );
        }
    }
}
