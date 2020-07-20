using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace VinylVaultApp.Converters
{
    class IntToStringConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {


             return value.ToString();


            //List<string> numList = new List<string>();
            //numList.Add("zero");
            //numList.Add("one");
            //numList.Add("two");
            //numList.Add("three");
            //numList.Add("four");
            //numList.Add("five");
            //numList.Add("six");

            //double dblValue = (double)value;
            //int intValue = System.Convert.ToInt32(dblValue);

            //return numList[intValue];






        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int val = 0;
            int.TryParse(value.ToString(), out val);
            return val;


            //List<string> numList = new List<string>();
            //numList.Add("zero");
            //numList.Add("one");
            //numList.Add("two");
            //numList.Add("three");
            //numList.Add("four");
            //numList.Add("five");
            //numList.Add("six");

            //return numList.IndexOf(value.ToString());


        }

    }


}
