﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverwatchLootBoxTracker.Translate
{
    class L_Zenyatta
    {
        Languages.English.Heroes.EN_Zenyatta EN;
        Languages.German.Heroes.DE_Zenyatta DE;
        string myLang;

        public L_Zenyatta(string Lang)
        {
            myLang = Lang;

            EN = new Languages.English.Heroes.EN_Zenyatta();
            DE = new Languages.German.Heroes.DE_Zenyatta();
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
        public string Air_SK//1
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Air_SK;
                }
                else
                {
                    return EN.Air_SK;
                }
            }
        }

        public string Earth_SK//2
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Earth_SK;
                }
                else
                {
                    return EN.Earth_SK;
                }
            }
        }

        public string Leaf_SK//3
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Leaf_SK;
                }
                else
                {
                    return EN.Leaf_SK;
                }
            }
        }

        public string Water_SK//4
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Water_SK;
                }
                else
                {
                    return EN.Water_SK;
                }
            }
        }
        //Epic
        public string Ascendant_SK//5
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ascendant_SK;
                }
                else
                {
                    return EN.Ascendant_SK;
                }
            }
        }

        public string Harmonious_SK//6
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Harmonious_SK;
                }
                else
                {
                    return EN.Harmonious_SK;
                }
            }
        }

        public string Skullyatta_SK//7
        {//Halloween 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Skullyatta_SK;
                }
                else
                {
                    return EN.Skullyatta_SK;
                }
            }
        }
        //Legendary
        public string Djinnyatta_SK//8
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Djinnyatta_SK;
                }
                else
                {
                    return EN.Djinnyatta_SK;
                }
            }
        }

        public string Ifrit_SK//9
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ifrit_SK;
                }
                else
                {
                    return EN.Ifrit_SK;
                }
            }
        }

        public string Ra_SK//10
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Ra_SK;
                }
                else
                {
                    return EN.Ra_SK;
                }
            }
        }

        public string Sunyatta_SK//11
        {
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sunyatta_SK;
                }
                else
                {
                    return EN.Sunyatta_SK;
                }
            }
        }

        public string Cultist_SK//12
        {//Halloween 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Cultist_SK;
                }
                else
                {
                    return EN.Cultist_SK;
                }
            }
        }

        public string Nutcracker_SK//13
        {//Winter 2016
            get
            {
                if (myLang == "DE")
                {
                    return DE.Nutcracker_SK;
                }
                else
                {
                    return EN.Nutcracker_SK;
                }
            }
        }

        public string Sanzang_SK//14
        {//Rooster 2017
            get
            {
                if (myLang == "DE")
                {
                    return DE.Sanzang_SK;
                }
                else
                {
                    return EN.Sanzang_SK;
                }
            }
        }


        //Emotes
    }
}
