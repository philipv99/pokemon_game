public static class Randomiser
{
    public static int IntGen(int max)
    {
        Random rnb = new Random();
        return rnb.Next(max);
    }

    public static int IntGen(int max, int min)
    {
        Random rnb = new Random();
        return rnb.Next(min, max);
    }
}

