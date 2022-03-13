using System;
using System.Collections.Generic;
using System.Text;

// ####################################################################################################################
// #                                                  ENUMS
// # If a program uses set of numbers, consider replacing them with enums, which makes the program more
// #
// #    Readable
// #    Maintainable
// #
// # 1. Enums are enumerations.
// #
// # 2. Enums are strongly typed constants. Hence, an explicit cast is needed to convert from enum type to an integral type  
// #    and vice versa. Also, an enum of one type cannot be implicitly assigned to an enum of another type even though
// #    the underlying value of their members are the same.
// #
// # 3. The default underlying type of an enum is int.
// #
// # 4. The default value for first element is ZERO and gets incremented by 1.      
// #
// # 5. It is possible to customize the underlying type and values.  
// #
// # 6. Enums are value types.
// #
// # 7. Enum keyword(all samll letteres) is used to create enumerations, where as Enum class, contains static GetValues()
// #    and GetNames() methods which can be used to list Enum underlying type values and Names
// #      
// #   
// #
// ####################################################################################################################

class Program
{
      
      public static string UTF8ToUnicode(string text)
      {
            try
            {
                  byte[] bytes = Encoding.GetEncoding(1252).GetBytes(text);
                  string result = Encoding.UTF32.GetString(bytes);
                  return result;
            }
            catch { }
            return text;
      }

      public static string UnicodeToUTF8(string text)
      {
            System.Text.Encoding utf_8 = System.Text.Encoding.UTF8;
            string s = "unicode";
            //string to utf
            byte[] utf = System.Text.Encoding.UTF8.GetBytes(text);
            //utf to string
            string result = System.Text.Encoding.UTF8.GetString(utf);
            return result;
      }

   
      public static string TDC_Func_UTH2UTF(string str)
      {
            string result = string.Empty;
            result = str.Replace("á", "á")
                .Replace("à", "à")
                .Replace("ả", "ả")
                .Replace("ã", "ã")
                .Replace("ạ", "ạ")
                .Replace("ắ", "ắ")
                .Replace("ằ", "ằ")
                .Replace("ẳ", "ẳ")
                .Replace("ẵ", "ẵ")
                .Replace("ặ", "ặ")
                .Replace("ấ", "ấ")
                .Replace("ầ", "ầ")
                .Replace("ẩ", "ẩ")
                .Replace("ẫ", "ẫ")
                .Replace("ậ", "ậ")
                .Replace("é", "é")
                .Replace("è", "è")
                .Replace("ẻ", "ẻ")
                .Replace("ẽ", "ẽ")
                .Replace("ẹ", "ẹ")
                .Replace("ế", "ế")
                .Replace("ề", "ề")
                .Replace("ể", "ể")
                .Replace("ễ", "ễ")
                .Replace("ệ", "ệ")
                .Replace("í", "í")
                .Replace("ì", "ì")
                .Replace("ỉ", "ỉ")
                .Replace("ĩ", "ĩ")
                .Replace("ị", "ị")
                .Replace("ó", "ó")
                .Replace("ò", "ò")
                .Replace("ỏ", "ỏ")
                .Replace("õ", "õ")
                .Replace("ọ", "ọ")
                .Replace("ố", "ố")
                .Replace("ồ", "ồ")
                .Replace("ổ", "ổ")
                .Replace("ỗ", "ỗ")
                .Replace("ộ", "ộ")
                .Replace("ớ", "ớ")
                .Replace("ờ", "ờ")
                .Replace("ở", "ở")
                .Replace("ỡ", "ỡ")
                .Replace("ợ", "ợ")
                .Replace("ú", "ú")
                .Replace("ù", "ù")
                .Replace("ủ", "ủ")
                .Replace("ũ", "ũ")
                .Replace("ụ", "ụ")
                .Replace("ứ", "ứ")
                .Replace("ừ", "ừ")
                .Replace("ử", "ử")
                .Replace("ữ", "ữ")
                .Replace("ự", "ự")
                .Replace("ý", "ý")
                .Replace("ỳ", "ỳ")
                .Replace("ỷ", "ỷ")
                .Replace("ỹ", "ỹ")
                .Replace("ỵ", "ỵ")
                .Replace("Á", "Á")
                .Replace("À", "À")
                .Replace("Ả", "Ả")
                .Replace("Ã", "Ã")
                .Replace("Ạ", "Ạ")
                .Replace("Ấ", "Ấ")
                .Replace("Ầ", "Ầ")
                .Replace("Ẩ", "Ẩ")
                .Replace("Ẫ", "Ẫ")
                .Replace("Ậ", "Ậ")
                .Replace("Ắ", "Ắ")
                .Replace("Ằ", "Ằ")
                .Replace("Ẳ", "Ẳ")
                .Replace("Ẵ", "Ẵ")
                .Replace("Ặ", "Ặ")
                .Replace("É", "É")
                .Replace("È", "È")
                .Replace("Ẻ", "Ẻ")
                .Replace("Ẽ", "Ẽ")
                .Replace("Ẹ", "Ẹ")
                .Replace("Ế", "Ế")
                .Replace("Ề", "Ề")
                .Replace("Ể", "Ể")
                .Replace("Ễ", "Ễ")
                .Replace("Ệ", "Ệ")
                .Replace("Í", "Í")
                .Replace("Ì", "Ì")
                .Replace("Ỉ", "Ỉ")
                .Replace("Ĩ", "Ĩ")
                .Replace("Ị", "Ị")
                .Replace("Ó", "Ó")
                .Replace("Ò", "Ò")
                .Replace("Ỏ", "Ỏ")
                .Replace("Õ", "Õ")
                .Replace("Ọ", "Ọ")
                .Replace("Ố", "Ố")
                .Replace("Ồ", "Ồ")
                .Replace("Ổ", "Ổ")
                .Replace("Ỗ", "Ỗ")
                .Replace("Ộ", "Ộ")
                .Replace("Ớ", "Ớ")
                .Replace("Ờ", "Ờ")
                .Replace("Ở", "Ở")
                .Replace("Ỡ", "Ỡ")
                .Replace("Ợ", "Ợ")
                .Replace("Ú", "Ú")
                .Replace("Ù", "Ù")
                .Replace("Ủ", "Ủ")
                .Replace("Ũ", "Ũ")
                .Replace("Ụ", "Ụ")
                .Replace("Ứ", "Ứ")
                .Replace("Ừ", "Ừ")
                .Replace("Ử", "Ử")
                .Replace("Ữ", "Ữ")
                .Replace("Ự", "Ự")
                .Replace("Ý", "Ý")
                .Replace("Ỳ", "Ỳ")
                .Replace("Ỷ", "Ỷ")
                .Replace("Ỹ", "Ỹ")
                .Replace("Ỵ", "Ỵ")
                ;
            return result;
      }
   



      static void Main(string[] args)
      {

            string s = UnicodeToUTF8("Trần thành luân");

            string s1 = TDC_Func_UTH2UTF("Trần thành luân");

            string  k= "2850/UBND";
           s= s.Substring(0, k.IndexOf("/"));
            string b=k.Substring(k.IndexOf('/')+1);


            //##################################################################################
            //#       Cast

            //Gender gender = (Gender) 1;
            //Console.WriteLine(gender);

            //int number = (int) Gender.Female;
            //Console.WriteLine(number);

            //Gender gender = (Gender) Season.Summer;
            //Console.WriteLine(gender);
            //#
            //##################################################################################

            //int[] values = (int[]) Enum.GetValues(typeof(Gender));
            //foreach(var value in values)
            //{
            //      Console.WriteLine(value);
            //}
            //string[] Names = Enum.GetNames(typeof(Gender));
            //foreach(var name in Names)
            //{
            //      Console.WriteLine(name);
            //}

            //##################################################################################
            //#              Using extension

            //object i=2;
            //Gender genGer=  i.AsDocType<Gender>();
            //Console.WriteLine(genGer);


            var a=new {Id=1};

           DateTime dt= DateTime.MaxValue;
      }

}

enum Season
{
      Winter=1,
      Spring =2,
      Summer= 3
}
// default underlying type is int and the value starts at ZERO
enum Gender 
{
      Unknow,
      Male,
      Female
}

//################################################################
//#                         Invalid

// Gender enum underlying tuype is now short and the value starts at ONE
//enum Gender:short 
//{
//      Unknow=1,
//      Male=2,
//      Female=3
//}

//Enum values need not be in sequential order Any valid underlying type value is allowed
//enum Gender:short 
//{
//      Unknow=10,
//      Male=22,
//      Female=35
//}

//This enum will not compile, bcos the maxium value allowed for short data type is 32767.
//enum Gender:short 
//{
//      Unknow=10,
//      Male=32767,
//      Female=35
//}

//################################################################
//#                       extension Method Convert object to enum
static class Extension
{
      public static T AsDocType<T>(this object item, T defaultT = default(T)) where T: struct
      {
            if(item == null || item.Equals(string.Empty))
                  return defaultT;

            var sourceType = item.GetType();
            //if(!sourceType.IsEnum)
            //      throw new ArgumentException("Source type is not enum");
            if(!typeof(T).IsEnum)
                  throw new ArgumentException("Destination type is not enum");
            return (T) Enum.Parse(typeof(T), item.ToString());
      }
}