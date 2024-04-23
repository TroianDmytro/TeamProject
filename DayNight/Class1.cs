namespace DayNight
{
    public class Class1
    {
        public static bool TimeDay()
        {
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
