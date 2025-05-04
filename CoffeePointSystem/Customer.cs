using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePointSystem
{
    public class Customer
    {
        public string PhoneNumber { get; private set; }
        public DateTime DateCreated { get; private set; }
        public double Points { get; set; }
        private int t;
        public double PointMultiplier { get; private set; }
        private int visitsThisMonth;
        private DateTime lastMonthlyUpdate;
        public int VisitsThisMonth
        {
            get { return visitsThisMonth; }
        }
        public Customer(string phoneNumber)
        {
            if (phoneNumber.Length != 10 || !long.TryParse(phoneNumber, out _))
            {
                throw new ArgumentException("Phone number must be a 10-digit numeric string.");
            }

            PhoneNumber = phoneNumber;
            DateCreated = DateTime.Now;
            Points = 0;
            t = 0;
            visitsThisMonth = 0;
            lastMonthlyUpdate = DateTime.Now;
            UpdatePointMultiplier();
        }

        public void AddPoints(double amount)
        {
            Points += amount;
        }

        public void RemovePoints(double amount)
        {
            Points = Math.Max(0, Points - amount);
        }

        public void RegisterVisit()
        {
            visitsThisMonth++;
        }

        public void UpdateMonthlyStatus()
        {
            DateTime now = DateTime.Now;
            int monthsPassed = ((now.Year - lastMonthlyUpdate.Year) * 12) + now.Month - lastMonthlyUpdate.Month;

            for (int i = 0; i < monthsPassed; i++)
            {
                ApplyMonthlyUpdate();
            }

            if (monthsPassed > 0)
            {
                visitsThisMonth = 0;
                lastMonthlyUpdate = new DateTime(now.Year, now.Month, 1);
            }
        }

        private void ApplyMonthlyUpdate()
        {
            int earnedT = 0;
            int tier;
            if (visitsThisMonth >= 4)
                tier = 4;
            else if (visitsThisMonth == 3)
                tier = 3;
            else if (visitsThisMonth == 2)
                tier = 2;
            else if (visitsThisMonth == 1)
                tier = 1;
            else
                tier = 0;

            switch (tier)
            {
                case 4: earnedT = 200; break;
                case 3: earnedT = 150; break;
                case 2: earnedT = 100; break;
                case 1: earnedT = 50; break;
            }

            int currentTier = GetTierFromT();
            if (tier >= currentTier)
            {
                int cap = 0;
                switch (tier)
                {
                    case 4:
                        cap = 600;
                        break;
                    case 3:
                        cap = 399;
                        break;
                    case 2:
                        cap = 299;
                        break;
                    case 1:
                        cap = 199;
                        break;
                    default:
                        cap = 0;
                        break;
                }

                t = Math.Min(t + earnedT, cap);
            }
            else
            {
                int tierDifference = currentTier - tier;
                int penalty = 0;

                switch (tierDifference)
                {
                    case 1:
                        penalty = 20;
                        break;
                    case 2:
                        penalty = 40;
                        break;
                    case 3:
                        penalty = 60;
                        break;
                    case 4:
                        penalty = 80;
                        break;
                    default:
                        penalty = 0;
                        break;
                }

                t = Math.Max(0, t - penalty);
            }

            UpdatePointMultiplier();
        }

        private int GetTierFromT()
        {
            if (t >= 400) return 4;
            if (t >= 300) return 3;
            if (t >= 200) return 2;
            if (t >= 100) return 1;
            return 0;
        }

        private void UpdatePointMultiplier()
        {
            if (t >= 400)
                PointMultiplier = 2.0;
            else if (t >= 300)
                PointMultiplier = 1.75;
            else if (t >= 200)
                PointMultiplier = 1.5;
            else if (t >= 100)
                PointMultiplier = 1.25;
            else
                PointMultiplier = 1.0;
        }
    }
}

