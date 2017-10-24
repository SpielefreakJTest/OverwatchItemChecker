﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Pharah
    {
        Languages.English.Heroes.EN_Pharah EN;
        Languages.German.Heroes.DE_Pharah DE;
        string myLang;

        public L_Pharah(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Pharah();
            DE = new Languages.German.Heroes.DE_Pharah();
        }

        public string ChangeLang
        {
            get
            {
                return myLang;
            }
            set
            {
                myLang = value;
            }
        }

        public string Name
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Name;
                }
                else
                {
                    return EN.Name;
                }
            }
        }


        //Skin

        //Rare
        public string Amethyst_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Amethyst_SK;
                }
                else
                {
                    return EN.Amethyst_SK;
                }
            }
        }

        public string Copper_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Copper_SK;
                }
                else
                {
                    return EN.Copper_SK;
                }
            }
        }

        public string Emerald_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Emerald_SK;
                }
                else
                {
                    return EN.Emerald_SK;
                }
            }
        }

        public string Titanium_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Titanium_SK;
                }
                else
                {
                    return EN.Titanium_SK;
                }
            }
        }
        //Epic
        public string Anubis_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Anubis_SK;
                }
                else
                {
                    return EN.Anubis_SK;
                }
            }
        }

        public string Jackal_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Jackal_SK;
                }
                else
                {
                    return EN.Jackal_SK;
                }
            }
        }

        public string Possessed_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Possessed_SK;
                }
                else
                {
                    return EN.Possessed_SK;
                }
            }
        }

        public string Frostbite_SK//8
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Frostbite_SK;
                }
                else
                {
                    return EN.Frostbite_SK;
                }
            }
        }
        //Legendary
        public string Mechaqueen_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Mechaqueen_SK;
                }
                else
                {
                    return EN.Mechaqueen_SK;
                }
            }
        }

        public string Raptorion_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Raptorion_SK;
                }
                else
                {
                    return EN.Raptorion_SK;
                }
            }
        }

        public string Raindancer_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Raindancer_SK;
                }
                else
                {
                    return EN.Raindancer_SK;
                }
            }
        }

        public string Thunderbird_SK//12
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Thunderbird_SK;
                }
                else
                {
                    return EN.Thunderbird_SK;
                }
            }
        }

        public string Security_Chief_SK//13
        {//Origin Special
            get
            {
                if (myLang == "DE")
                {
                    return DE.Security_Chief_SK;
                }
                else
                {
                    return EN.Security_Chief_SK;
                }
            }
        }

        public string Bedouin_SK//14
        {//Annyver 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Bedouin_SK;
                }
                else
                {
                    return EN.Bedouin_SK;
                }
            }
        }


        //Emotes
    }
}
