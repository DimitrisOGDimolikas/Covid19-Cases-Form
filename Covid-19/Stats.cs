using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19
{
    

    class Stats
    {
        private int oneToTen;
        private int elevenToTwenty;
        private int twentyoneToThirty;
        private int thiryoneToFourty;
        private int fourtyoneToFifty;
        private int fiftyoneToSixty;
        private int sixtyoneToSeventy;
        private int seventyoneToEighty;
        private int eightyoneToNinety;
        private int ninetyoneToOnehundred;
        private int males;
        private int females;
        private int others;
        private int nosimata;

        public Stats(int oneToTen, int elevenToTwenty, int twentyoneToThirty, int thiryoneToFourty, int fourtyoneToFifty, int fiftyoneToSixty, int sixtyoneToSeventy, int seventyoneToEighty, int eightyoneToNinety, int ninetyoneToOnehundred, int males, int females, int others, int nosimata)
        {
            this.OneToTen = oneToTen;
            this.ElevenToTwenty = elevenToTwenty;
            this.TwentyoneToThirty = twentyoneToThirty;
            this.ThiryoneToFourty = thiryoneToFourty;
            this.FourtyoneToFifty = fourtyoneToFifty;
            this.FiftyoneToSixty = fiftyoneToSixty;
            this.SixtyoneToSeventy = sixtyoneToSeventy;
            this.SeventyoneToEighty = seventyoneToEighty;
            this.EightyoneToNinety = eightyoneToNinety;
            this.NinetyoneToOnehundred = ninetyoneToOnehundred;
            this.Males = males;
            this.Females = females;
            this.Others = others;
            this.Nosimata = nosimata;
        }

        public int OneToTen { get => oneToTen; set => oneToTen = value; }
        public int ElevenToTwenty { get => elevenToTwenty; set => elevenToTwenty = value; }
        public int TwentyoneToThirty { get => twentyoneToThirty; set => twentyoneToThirty = value; }
        public int ThiryoneToFourty { get => thiryoneToFourty; set => thiryoneToFourty = value; }
        public int FourtyoneToFifty { get => fourtyoneToFifty; set => fourtyoneToFifty = value; }
        public int FiftyoneToSixty { get => fiftyoneToSixty; set => fiftyoneToSixty = value; }
        public int SixtyoneToSeventy { get => sixtyoneToSeventy; set => sixtyoneToSeventy = value; }
        public int SeventyoneToEighty { get => seventyoneToEighty; set => seventyoneToEighty = value; }
        public int EightyoneToNinety { get => eightyoneToNinety; set => eightyoneToNinety = value; }
        public int NinetyoneToOnehundred { get => ninetyoneToOnehundred; set => ninetyoneToOnehundred = value; }
        public int Males { get => males; set => males = value; }
        public int Females { get => females; set => females = value; }
        public int Others { get => others; set => others = value; }
        public int Nosimata { get => nosimata; set => nosimata = value; }
    }
}
