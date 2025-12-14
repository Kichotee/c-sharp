    static class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            if (speed == 0)
            {
                return 0;
            }
            else if (speed >= 1 & speed <= 4)
            {
                return (double)100/100;
            }
            else if (speed >= 5 & speed <= 8)
            {
                return (double)90/100;
    
            }
            else if (speed == 9)
            {
                return (double)80.0/100;
    
            }
            else if (speed == 10)
            {
                return (double)77.0/100;
    
            }
            return 0;
        }
    
        public static double ProductionRatePerHour(int speed)
        {
            int carProducdPerour = speed * 221;
            return carProducdPerour * (SuccessRate(speed));
        }
    
        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)(ProductionRatePerHour(speed) / 60);
        }
    }
