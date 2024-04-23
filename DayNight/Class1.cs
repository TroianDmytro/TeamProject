namespace DayNight
{
    public static class Class1
    {
        public static bool IsNight()
        {
            int hour = DateTime.Now.Hour;

            if ((hour >= 0 && hour < 6) || ( hour > 19 && hour <= 23) )
            {
                return true;
            }
            return false;
        }
    }
}
