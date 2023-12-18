using System.Diagnostics;
using System;
public class Program
{
    string[] F = new string[21];
    int A1 = 0;
    int A0 = 0;
    int X9 = 0;
    Random rnd = new Random();
    int B = 5;
    string[] R = new string[11];
    int Z3 = 0;
    int A7 = 0;
    int L1 = 0;
    int L2 = 0;
    int C = 0;
    int Q = 0;
    int P = 0;
    int D = 0;
    static void Main()
    {
        Program program = new Program();
        program.Welcome();
        program.Main2_GoTo60();
    }

    public void mega_start()
    {
        
    }


    public void Main2_GoTo60()
    {
        A1 = 0;
        A7 = 0;

        if (B <= 0) //80
        {
            Console.WriteLine("YOU HAVE PLAYED YOUR FIVE BALLS, AND HAVE SCORED\nA TOTAL OF " + P + " POINTS.");
            GoTo9999();
        }

        Console.WriteLine("THE BALL IS NOW AT (" + L1 + "," + L2 + ").");
        if (L2 > 15)
            L2 = 15;
        if (L1 > 19)
            L1 = 19;
        if (F[L1 - 1][L2 - 1] == ' ')
            GoTo150();

        Gosub2010();
    }

    public void GoTo150() {
        if (A7 == 7)
            GoTo280();
        if (A1 != 4)
            GoTo180();
        else
            GoTo260();
    }

    public void GoTo130() {
        if (F[L1 - 1][L2 - 1] == ' ' && F != null)
            GoTo150();
        Gosub2010();
        if (A7 == 7)
            GoTo280();
        if (A1 != 4)
            GoTo180();
        else
            GoTo260();
    }
    public void GoTo180() //180 MB ONO RUINIT
    {
        L1++;
        A1 = 0;
        L2 += (1 + rnd.Next(1)) * 3 - 2;

        if (L2 < 2 || L2 > 15)
            L1 += (1 + rnd.Next(1)) * 3 - 2;
        if (L2 < 2 || L2 > 15)
            L2 = rnd.Next(2, 15);
        if (L1 >= 2 && L1 <= 20)
            GoTo130();
        else
        {
            L1 = rnd.Next(1, 8);
            GoTo130();
        }
        GoTo4010();
        if (A0 == 1)
            GoTo400();
        switch (X9)
        {
            case 0:
                Main2_GoTo60();
                break;
            case 1:
                GoTo340();
                break;
            default: break;
        }
    }

    public void GoTo400()
    {
        L1 = 2 + rnd.Next(8);
        L2 = 2 + rnd.Next(14);
        GoTo110();
    }

    public void GoTo110()
    {
        C = 1 + rnd.Next(8);
        A1 = 0;
        Console.WriteLine("THE BALL IS NOW AT (" + L1 + "," + L2 + ").");
        if (F[L1][L2] == ' ')
            GoTo150();
        else
            GoTo140();
        if (A7 == 7)
            GoTo280();
        if (A1 != 4)
            GoTo180();
        else
            GoTo260();
    }

    public void GoTo140()
    {
        Gosub2010();
        if (A7 == 7)
            GoTo280();

        if (A1 != 4)
            GoTo180();
        else
            GoTo260();
    }

    public void GoTo260()
    {
        GoTo4010();
        if (A0 == 1)
            GoTo400();

        switch (X9)
        {
            case 1:
                Main2_GoTo60();
                break;
            case 2:
                GoTo340();
                break;
            default: break;
        }
    }

    public void GoTo4010()
    {
        Console.WriteLine("BALL APPROACHING FLIPPERS. ENTER THE TWO FLIPPERS YOU WISH TO FLIP");
        Console.Write("IN THE FORM: X,Y\n");
        int V = Convert.ToInt32(Console.ReadLine());
        int W = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if (V == D || W == D)
            GoTo4110();
        else
        {
            Console.WriteLine("NO, YOU HAVE CHOSEN TO PROTECT THE WRONG FLIPPERS. YOU NOW HAVE");
            Console.WriteLine(B - 1 + " BALLS LEFT.");
            B--;
            if (B <= 0)
                GoTo9999();
            A0 = 0;
            GoSub5010();
        }

    }

    public void GoTo4110()
    {
        A0 = 1;
        C = 1 + Convert.ToInt32(rnd.NextDouble() * 5);
        return;
    }

    public void GoTo280()
    {
        switch (X9)
        {
            case 1:
                Main2_GoTo60();
                break;
            case 2:
                GoTo340();
                break;
            default:
                break;
        }
    }

    public void GoTo340()
    {
        Console.WriteLine("YOU HAVE PLAYED YOUR SIXTH BALL AND SCORED " + P + " POINTS!");
        X9 = 2;
        if (P < 2200 || B <= 0)
            GoTo9999();
    }

    public void GoTo9999()
    {
        Console.WriteLine("COME PLAY AGAIN SOMETIME!!");
        Environment .Exit(0);
    }

    public void Welcome()
    {
        L1 = 2 + rnd.Next(6);
        L2 = rnd.Next(1, 15);
        C = 1 + rnd.Next(7);
        F = Gosub9500();
        for (int Z = 0; Z < 10; Z++)
            R[Z] = " ";
        Console.WriteLine("PINBALL\nCREATIVE COMPUTING\nMORRISTOWN, NEW JERSEY\n\n");
        Console.WriteLine("WELCOME TO COMPUTER PINBALL!!\nWOULD YOU LIKE INSTRUCTIONS TO THIS \nFANTASTIC GAME");
        string Q1 = Console.ReadLine();
        if (Q1 == "Y")
            Gosub1010();
        else
        {
            Console.WriteLine("HOW ABOUT A PICTURE OF THE TABLE");
            string Q2 = Console.ReadLine();
            if (Q2 == "Y")
                Gosub6010();
        }
        Console.WriteLine("\n\n");
    }


    public void Gosub6010() {
        Console.WriteLine("\n\n P I C T U R E \n" +
                    "****************:\n\n" +
            "  ]]]]]]]]]]]]\n" +
            " O            O\n" +
            "O   *  *  *    O\n" +
            "O  A  B  C  D  O\n" +
            "O    *   *     O\n" +
            "O * #  $  *  * O\n" +
            "O    *   *     O\n" +
            "O* E  F  G  H *O\n" +
            "O   *  *  *    O\n" +
            "O===        ===O\n" +
            "O  1 2 3 4 5   O\n" +
            "O * 6 7 8 9  * O\n" +
            "O===   0    ===O\n" +
            "O  0   0    0  O\n" +
            "!!!          !!!\n" +
            "O  \\        /  O\n" +
            "O   \\  I J /   O\n" +
            "O    \\    /    O\n" +
            "O     \\  /     O\n" +
            "\\------!!----^-/\n\n\n" +
            "****************\n\n");
        Main2_GoTo60();
    }

    public void Gosub1010()
    {
        Console.WriteLine("\n\n" +
            "THE RULES OF COMPUTER PINBALL ARE FAIRLY SIMPLE.  YOU GET A TOTAL OF\n" +
            "FIVE BALLS.  IF YOU SCORE MORE THAN 1600, YOU GET A SIXTH BALL.  IF\n" +
            "YOUR SIX BALL SCORE IS MORE THAN 2200, YOU GET A SEVENTH BALL.\n\n" +
            "THIS TABLE HAS THREE FLIPPERS, EACH OF OF WHICH PROTECT AN OUT CHUTE.\n" +
            "HOWEVER, THIS SET DIFFERS FROM OTHER SETS, SINCE YOU MAY ONLY FLIP\n" +
            "TWO OF THE FLIPPERS ANY TIME THE BALL APPROACHES THE CHUTE.\n" +
            "NOTA BENE:  YOU DO NOT!!! KNOW FOR SURE WHERE THE BALL IS!!\n" +
            "SO, IF YOU FLIP THE WRONG TWO FLIPPERS, YOU LOSE THE BALL, AND THE\n" +
            "NEXT BALL IS PUT INTO PLAY.\n" +
            "     YOU CAN GET A PICTURE OF THE TABLE EVERY TIME THE BALL HITS\n" +
            "AN OBJECT, SO THAT MAY HELP YOU SOMEWHAT. ALSO, YOU ARE TOLD WHERE\n" +
            "THE BALL IS EACH TIME IT HITS(EVEN IF YOU DON'T GET A PICTURE).\n" +
            "THERE IS SOME LOGIC TO THE CHOICE OF FLIPPERS, BUT SOME LUCK IS INVOLVED, TOO.\n" +
            "THE FLIPPERS ARE NUMBERED 1,2, AND 3 FROM LEFT TO RIGHT, AND ARE SHOWN\n" +
            "ON THE PICTURE BELOW AS '!' MARKS.\n" +
            "SINCE LUCK PLAYS ONLY A SMALL PART IN CHOOSING THE CORRECT FLIPPER,\n" +
            "YOU WILL DO POORLY IF YOU JUST GUESS WHICH FLIPPER THE BALL IS\n" +
            "HEADED TOWARD...\n\n\n" +
            "THE TABLE LOOKS LIKE THIS:\n" +
            "****************:\n\n" +
            "  ]]]]]]]]]]]]\n" +
            " O            O\n" +
            "O   *  *  *    O\n" +
            "O  A  B  C  D  O\n" +
            "O    *   *     O\n" +
            "O * #  $  *  * O\n" +
            "O    *   *     O\n" +
            "O* E  F  G  H *O\n" +
            "O   *  *  *    O\n" +
            "O===        ===O\n" +
            "O  1 2 3 4 5   O\n" +
            "O * 6 7 8 9  * O\n" +
            "O===   0    ===O\n" +
            "O  0   0    0  O\n" +
            "!!!          !!!\n" +
            "O  \\        /  O\n" +
            "O   \\  I J /   O\n" +
            "O    \\    /    O\n" +
            "O     \\  /     O\n" +
            "\\------!!----^-/\n\n\n" +
            "****************\n" +
            "THE CENTER BUMPER($) IS THE JACKPOT!\n" +
            "THE BALL IS PUT INTO PLAY THROUGH THE UP ARROW(^), AND GOES UP AND\n" +
            "AROUND, WHERE IT IS DEPOSITED ON THE UPPER HALF OF THE TABLE.  THE BALL\n" +
            "MAY BOUNCE FROM THE SIDE OF THE TABLE, AND MAY BOUNCE UP FROM THE\n" +
            "LINES ON THE SIDE(=) AND FROM THE DIAGONALS(\\ AND /) AT THE BOTTOM\n" +
            "OF THE TABLE.  THE BUMPERS ARE INDICATED BY STARS(*).\n" +
            "     FLIPPERS ARE SHOWN AS EXCLAMATION POINTS(! OR !!).\n" +
            "THE BALL MAY GO OUT OF PLAY THROUGH ONE OF THE FOUR HOLES IN THE BOARD(0),\n" +
            "IN WHICH CASE YOU WILL GET A BONUS BUT LOSE THE BALL.\n" +
            "     GATES ARE SHOWN BY THE NUMBERS 1-9, AND KNOCK-DOWN TABS ARE SHOWN\n" +
            "AS THE LETTERS A-J.  YOU GET A BONUS FOR THESE AT THE END OF\n" +
            "A BALL, AND IF YOU KNOCK ALL OF THEM DOWN YOU GET A SPECIAL BONUS...\n\n" +
            "***EVERY ONCE IN A WHILE, I WILL SHOW YOU A PICTURE OF THE\n" +
            "TABLE AS IT HITS SOMETHING.  THE BALL IS SHOWN AS THE #.\n\n\n\n\n\n");
        Main2_GoTo60();
    }

    public string[] Gosub9500() {
        F[0] = "  ";
        for (int Q = 1; Q <= 12; Q++)
            F[0] = F[0] + "[" + ((char)8) + "]";
        F[0] = F[0] + "  ";
        F[1] = " O            O ";
        F[2] = "O   *  *  *    O";
        F[3] = "O  A  B  C  D  O";
        F[4] = "O    *   *     O";
        F[5] = "O * *  $  *  * O";
        F[6] = "O    *   *     O";
        F[7] = "O* E  F  G  H *O";
        F[8] = "O   *  *  *    O";
        F[9] = "O===        ===O";
        F[10] = "O  1 2 3 4 5   O";
        F[11] = "O * 6 7 8 9  * O";
        F[12] = "O===   0    ===O";
        F[13] = "O  0   0    0  O";
        F[14] = "!!!          !!!";
        F[15] = "O  \\        /  O";
        F[16] = "O   \\  I J /   O";
        F[17] = "O    \\    /    O";
        F[18] = "O     \\  /     O";
        F[19] = "\\------!!----^-/";
        return F;
    }

    public void Gosub2010() //Самый сомнительный метод
    {
        if (F[L1 - 1][L2 - 1] == '0')
            GoTo2070();
        if (rnd.Next(0, 2) != 1)
        {
            if (F[L1 - 1][L2 - 1] == '/' || F[L1 - 1][L2 - 1] == '\\')
                GoTo2160();
        }
        else
        {
            int S8 = rnd.Next(1, 7);
            for (int S7 = 1; S7 <= S8; S7++)
                Console.Write((char)7);

            if (F[L1 - 1][L2 - 1] <= 'J' && F[L1 - 1][L2 - 1] >= 'A')
                GoTo2190();
            else
                GoTo3010();
        }
    }

    public void GoTo3110() {
        A1 = 4;
        GoTo3390();
    }

    public void GoTo3390() {
        GoTo7850();
        GoTo3130();
    }

    public void GoTo3180()
    {
        D = 1;
        if (1 + rnd.Next(1) * 2 == 1)
            D += rnd.Next(1) * 3;
        return;
    }

    public void GoTo3200() {
        D = 2;
        if (1 + rnd.Next(1) * 2 == 1)
        {
            D += rnd.Next(1) * 3;
            if (D > 3)
                D -= 3;
        }
        return;
    }

    public void GoTo3130()
    {
        D = 2;
        if (L1 < 6)
            GoTo3180();
        if (L1 < 11)
            GoTo3200();
        
        if (1 + rnd.Next(1) * 2 == 1)
        {
            D += (1 + rnd.Next(1) * 3) - 2;
            if (D > 3)
                D -= 3;
        }
        return;
    }

    public void GoTo7850()
    {
        L1 = Math.Abs(L1 - 2 + 1 + rnd.Next(1, 5));
        if (L1 <= 15)
            return;
        L1 = 1 + rnd.Next(0, 15);
        return;
    }

    public void GoTo3010()
    {
        if (L1 > 19)
            L1 = 19;
        if (L2 > 15)
            L2 = 15;
        if ((L1 > 0 && F[L1 - 1].Substring(L2 - 1, 1) == "\x08") ||
            (L1 > 0 && F[L1 - 1].Substring(L2 - 1, 1) == "]") ||
            (L1 < F.Length && F[L1].Substring(L2 - 1, 1) == "["))
        {
            return;
        }
        if (F[L1 - 1].Substring(L2 - 1, 1) == "^")
            GoTo3110();
        A1 = 0;
        if (F[L1 - 1].Substring(L2 - 1, 1) == "=")
            GoTo3410();
        C--;
        if (C == 0)
            GoTo3110();
        if (L1 > 19)
            L1 = 19;
        if (L2 > 15)
            L2 = 15;
        if (F[L1 - 1].Substring(L2 - 1, 1) == "!" || F[L1 - 1].Substring(L2 - 1, 1) == "\\")
            GoTo3110();
        if (F[L1-1] != null && F[L1 - 1].Substring(L2 - 1, 1) == "/" || F[L1 - 1].Substring(L2 - 1, 1) == "-")
            GoTo3110();
        if (1 + new Random().Next(1, 26) == 4)
            Gosub6010();
        if (F[L1 - 1].Substring(L2 - 1, 1) == "$")
            GoTo3230();
        if (F[L1 - 1].Substring(L2 - 1, 1) == "*")
            GoTo3280();
        GoTo3320();
    }

    public void GoTo3410()
    {
        L1 -= (1 + (int)(rnd.NextDouble() * 5));
        L2 = L2 - 2 + (1 + (int)(rnd.NextDouble() * 4));
        return;
    }

    public void GoTo3320()
    {
        Q = 15 * (1 + (int)(new Random().NextDouble() * 6));
        P += Q;
        Console.WriteLine("YOU GET " + Q + " POINTS FROM GATE " + F[L1].Substring(L2 - 1, 1));
        Console.WriteLine("SCORE: " + P);
        L1 = (L1 - (int)(1 + new Random().NextDouble() * 3)) - (int)(1 + new Random().NextDouble() * 2);
        L2 = L2 - 3 + (int)(new Random().NextDouble() * 5) + 1;
        return;
    }

    public void GoTo3230()
    {
        Q = 45 + (int)(new Random().NextDouble() * 146);
        Console.WriteLine("YOU HAVE HIT THE JACKPOT!!!! YOU HAVE JUST WON " + Q + " POINTS!!");
        P += Q;
        Console.WriteLine("YOU NOW HAVE " + P + " POINTS!");
    }

    public void GoTo3280()
    {
        Q = rnd.Next(1) * 64 + 1;
        P += Q;
        Console.WriteLine("YOU RECEIVE " + Q + " POINTS FROM THE BUMPER AT " + L1 + "," + L2 + ".");
        Console.WriteLine("YOU NOW HAVE " + P + " POINTS!");
    }

    public void GoTo2190() //Не понятно что я наделал с переменными
    {
        Console.WriteLine("\n");
        for (int Q = 1; Q <= 10; Q++)
        {
            if (R[Q] == F[L1].Substring(L2 - 1, 1))
                return;
        }
        Z3++;
        R[Z3] = F[L1].Substring(L2 - 1, 1);
        Console.WriteLine("TAB " + R[Z3] + " DOWN...");
        if (Z3 == 10)
            GoSub5010();
        return;
    }

    public void GoTo2160()
    {
        L1 = (1 + rnd.Next(4)) - (1 + rnd.Next(4));
        L2 = 2 + rnd.Next(14);
    }

    public void GoSub5010()
    {
        if (Z3 == 10)
        {
            GoTo5090();
            Main2_GoTo60();
        }
        if (Z3 == 0)
            return;
        Console.WriteLine("YOUR BALL KNOCKED DOWN " + Z3 + " TAGS!!");
        Console.WriteLine("FOR THIS STELLAR PERFORMANCE, YOU ARE AWARDED ");
        Console.WriteLine("*****" + 10 * Z3 + "*****" + "  POINTS!!");
        P += 10 * Z3;
        Console.WriteLine("SCORE: " + P);
    }

    public void GoTo5090()
    {
        P += 250;
        Console.WriteLine("*****YOU KNOCKED DOWN ALL 10 TAGS!!!*****");
        Console.WriteLine("YOU ARE AWARDED 250 POINTS AND AN EXTRA BALL!!!");
        B++;
        Console.WriteLine("SCORE: " + P);
    }

    public void GoTo2070() {
        Console.WriteLine("TOO BAD... YOU HAVE GONE STRAIGHT OUT A CHUTE HOLE('0' ON THE TABLE).\n" +
            "TO CONSOLE YOU, I WILL GIVE YOU AN EXTRA\n");
        Q = (int)(rnd.NextDouble() * 141);
        P += Q;
        Console.WriteLine("\n"+Q+";POINTS, TO BRING YOUR TOTAL TO "+P+"\nYOU NOW HAVE HAVE "+(B-1)+" BALLS LEFT.\n");
        B--;
        A7 = 7;
        GoSub5010();
    }
}