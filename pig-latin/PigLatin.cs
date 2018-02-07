public static class PigLatin
{
    public static string Translate(string word)

    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        int index = word.IndexOfAny(vowels, 0, 1);

        if (index == 0)
        {
            return word + "ay";

        }
        /*      
        if (word.Substring(0, 1) == "a")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "e")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "i")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "o")
        {
            return word + "ay";
        }
        else if (word.Substring(0, 1) == "u")
        {
            return word + "ay";
        }*/
        else if (word.Substring(0, 2) == "ch")
        {
            string twoLetters = word.Substring(0, 2);
            string remainWord = word.Substring(2);
            return remainWord + twoLetters + "ay";
        }
        else if (word.Substring(0, 2) == "qu")
        {
            string twoLetters = word.Substring(0, 2);
            string remainWord = word.Substring(2);
            return remainWord + twoLetters + "ay";
        }
        else if (word.Substring(0, 3) == "squ")
        {
            string threeLetters = word.Substring(0, 3);
            string remainWord = word.Substring(3);
            return remainWord + threeLetters + "ay";
        }
        else if (word.Substring(0, 2) == "th")
        {
            if (word.Substring(0, 3) == "thr")
            {
                string threeLetters = word.Substring(0, 3);
                string remainWord = word.Substring(3);
                return remainWord + threeLetters + "ay";
            }
            else
            {
                string twoLetters = word.Substring(0, 2);
                string remainWord = word.Substring(2);
                return remainWord + twoLetters + "ay";
            }
        }
        else if (word.Substring(0, 3) == "sch")
        {
            string threeLetters = word.Substring(0, 3);
            string remainWord = word.Substring(3);
            return remainWord + threeLetters + "ay";
        }
        else if (word.Substring(0, 2) == "yt")
        {
            //string twoLetters = word.Substring(0, 2);
            string remainWord = word.Substring(0);
            return remainWord + "ay";
        }
        else if (word.Substring(0, 2) == "xr")
        {
            //string twoLetters = word.Substring(0, 2);
            string remainWord = word.Substring(0);
            return remainWord + "ay";
        }
        /*
        else if (word.Substring(0, 1) == "y")
        {
            string oneLetter = word.Substring(0, 1);
            string remainWord = word.Substring(1);
            return remainWord + oneLetter + "ay";
        }

        else if (word.Substring(1, 1) == "y")
        {
            string oneLetter = word.Substring(0, 1);
            return "y" + oneLetter + "ay";

        }
        */
        else
        {
            string firstLetter = word.Substring(0, 1);
            string restWord = word.Substring(1);
            return restWord + firstLetter + "ay";
        }
    }
}
