/*using System;
using System.Collections.Generic;
using System.Text;

namespace MTFDTests.Resources
{
    class Class1
    {
    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;

namespace TopLevel
{
    using Microsoft;
    using System.ComponentModel;

    /*namespace customer_relationship
    {
        public interface ICustomer
        {
            IEnumerable<IOrder> PreviousOrders { get; }

            DateTime DateJoined { get; }
            DateTime? LastOrder { get; }
            string Name { get; }
            IDictionary<DateTime, string> Reminders { get; }

            public decimal LoyaltyDiscount();

            // Version 3:
            public static void SetLoyaltyThresholds(TimeSpan ago, int minimumOrders, decimal percentageDiscount)
            {
                length = ago;
                orderCount = minimumOrders;
                discountPercent = percentageDiscount;
            }
            private static TimeSpan length = new TimeSpan(365 * 2, 0, 0, 0); // two years
            private static int orderCount = 10;
            private static decimal discountPercent = 0.10m;

            // <SnippetFinalVersion>
            public decimal ComputeLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
            protected static decimal DefaultLoyaltyDiscount(ICustomer c)
            {
                DateTime start = DateTime.Now - length;

                if ((c.DateJoined < start) && (c.PreviousOrders.Count() > orderCount))
                {
                    return discountPercent;
                }
                return 0;
            }
            // </SnippetFinalVersion>
        }
    }*/


    namespace Child1
    {
        using Microsoft.Win32;
        using System.Runtime.InteropServices;

        public interface ICustomer
        {
            string Name { get; }
            IDictionary<DateTime, string> Reminders { get; }

            public decimal ComputeLoyaltyDiscount()
            {
                DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
                if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))
                {
                    return 0.10m;
                }
                return 0;
            }
            public string someMethod();

        }

        public interface IOrder
        {
            DateTime Purchased { get; }
            decimal Cost { get; }
            string newMethod()
            {
                return "string";
            }
        }

        class Foo
        {


        public interface ICustomer
        {
            IEnumerable<IOrder> PreviousOrders { get; }

            DateTime DateJoined { get; }
            DateTime? LastOrder { get; }
            string Name { get; }
            IDictionary<DateTime, string> Reminders { get; }

            public decimal ComputeLoyaltyDiscount()
            {
                DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
                if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))
                {
                    return 0.10m;
                }
                return 0;
            }
            public string someMethod();

        }
            public static RGBColor FromRainbow(Rainbow colorBand) =>
                colorBand switch
                {
                    Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
                    Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                    Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                    Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
                    Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
                    Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                    Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                    _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
                };


            public static RGBColor FromRainbow2(Rainbow colorBand) =>
          colorBand2 switch
          {
              Rainbow.Red => new RGBColor(0xFF, 0x00, 0x00),
              Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
              Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
              Rainbow.Green => new RGBColor(0x00, 0xFF, 0x00),
              Rainbow.Blue => new RGBColor(0x00, 0x00, 0xFF),
              Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
              Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
              _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
          };

            static int WriteLinesToFile(IEnumerable<string> lines)
            {
                // We must declare the variable outside of the using block
                // so that it is in scope to be returned.
                int skippedLines = 0;
                using (var file = new System.IO.StreamWriter("WriteLines1.txt"))
                {
                    foreach (string line in lines)
                    {
                        if (!line.Contains("Second"))
                        {
                            file.WriteLine(line);
                        }
                        else
                        {
                            skippedLines++;
                        }
                    }
                } // file is disposed here
                return skippedLines;
            }


        }
    }

    namespace Child2
    {
        using System.CodeDom;
        using Microsoft.CSharp;

        class Bar
        {

            public static RGBColor FromRainbowClassic(Rainbow colorBand)
            {
                switch (colorBand)
                {
                    case Rainbow.Red:
                        return new RGBColor(0xFF, 0x00, 0x00);
                    case Rainbow.Orange:
                        return new RGBColor(0xFF, 0x7F, 0x00);
                    case Rainbow.Yellow:
                        return new RGBColor(0xFF, 0xFF, 0x00);
                    case Rainbow.Green:
                        return new RGBColor(0x00, 0xFF, 0x00);
                    case Rainbow.Blue:
                        return new RGBColor(0x00, 0x00, 0xFF);
                    case Rainbow.Indigo:
                        return new RGBColor(0x4B, 0x00, 0x82);
                    case Rainbow.Violet:
                        return new RGBColor(0x94, 0x00, 0xD3);
                    default:
                        throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand));
                };
            }

            static int WriteLinesToFile(IEnumerable<string> lines)
            {
                using var file = new System.IO.StreamWriter("WriteLines2.txt");
                // Notice how we declare skippedLines after the using statement.
                int skippedLines = 0;
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                    else
                    {
                        skippedLines++;
                    }
                }
                // Notice how skippedLines is in scope here.
                return skippedLines;
                // file is disposed here
            }


        }
    }
}