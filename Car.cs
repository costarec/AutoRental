using System;

namespace AutoRental
{
    // The class Car figures heavily in the operation of an auto rental
    // business, so this is one of the fundamental object classes that
    // our system will use.
    internal class Car // : object
    {
        // currently, we are thinking that this class will consist
        // mainly of properties to hold the data model and maybe
        // 1 or 2 util functions

        // Properties - all curently auto-implemented
        public int YearModel { get; set; }
        public string PaintColor { get; set; }
        public string MakeModel { get; set; }
        public decimal RentalPrice { get; set; }

        // Constructors
        // fully specified ctor providing all data needed for props
        public Car(int year, string paint, string model, decimal price)
        {
            // assign all the passed in formal parameters to the properties
            // above
            YearModel = year;
            PaintColor = paint;
            MakeModel = model;
            RentalPrice = price;
        }

        // adding back in default no-arg do nothing ctor
        public Car()
        {
        }

        // override the to string method so that we can print a car
        // with all the data attributes having to do with a car
        // overriding is a form of polymorphism
        public override string ToString()
        {
            // declare a temp string var buffer
            string str = string.Empty;

            // fill the buffer with the data and info that we want to see printed out
            str += "******************************************\n";
            str += $" Year: {YearModel}\n";
            str += $"Color: {PaintColor}\n";
            str += $"Model: {MakeModel}\n";
            str += $"Price: {RentalPrice}\n";


            // return the string buffer that we created and filled
            return str;
        }
    }
}