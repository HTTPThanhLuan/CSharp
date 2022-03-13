using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Part_7.Datatypes_Conversion
{
      enum LoaiVanBan
      {
            VanBanDen=1,
            VanBanDi=2,
            VanBanNoiBo=3
      };
      class Program
      {
            static void Main(string[] args)
            {

                  DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
                  DateTime date1 = new DateTime(2015, 6 , 16);
                  Calendar cal = dfi.Calendar;

                  Console.WriteLine("{0:d}: Week {1} ({2})", date1,
                                    cal.GetWeekOfYear(date1, dfi.CalendarWeekRule,
                                                      dfi.FirstDayOfWeek),
                                    cal.ToString().Substring(cal.ToString().LastIndexOf(".") + 1));     


                  string defaultString    = default(string);
                  Guid defaultGuid        = default(Guid);
                  DateTime defautDateTime = default(DateTime);
                  bool defaultBool        = default(bool);
                  int defaultInt          = default(int);
                  double defaultDupble    = default(double);
                  float defaultFloat      = default(float);
                  LoaiVanBan loaiVanBan = default(LoaiVanBan);

                  string g= (string)null;

                  Cat cat=new Cat();
                  cat.Id=1;
                  cat.Name="";
                  List<string> error= cat.Errors;


                  //List<string> listString =new List<string>();
                  //string s= listString.Aggregate((cur,next)=> cur + "</br>"+next);

                  bool resul= false && false;

                // bool i=  Uri.TryCreate(.IsWellFormedUriString("sttt.khanhhoa.gov.vn/", UriKind.RelativeOrAbsolute);


                  bool a = Regex.Match("http://sttt.khanhhoa.gov.vn/", @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-‌​\.\?\,\'\/\\\+&amp;%\$#_]*)?$").Success;
            
                  object i=Guid.NewGuid();
                  
                  bool c= (i is Guid);


                  Dog dog=new Dog(){
                        Id=Guid.NewGuid(),
                        Name="Luan"
                  };
                  Dog dog2=new Dog(){
                        Id=Guid.NewGuid(),
                        Name="Luan"
                  };

                  List<Dog> list1=new List<Dog>();
                  list1.Add(dog2);
                 list1.Add(dog);

                  List<Dog> list2=new List<Dog>();
                 list2.Add(dog);

                  List<Dog> temp=list1.Except(list2).ToList();




            }
      }
     
      class Dog//:IEquatable<Dog>
      {
            public Guid Id { get; set; }
            public string Name{get;set;}
            //public override bool Equals(object obj)
            //{
            //      return Id==((Dog)obj).Id;
            //}
            //public override int GetHashCode()
            //{
            //      return base.GetHashCode();
            //}

            public override string ToString()
            {
                  return Id.ToString() +" $$$ "+ Name;
            }

          
      }



      abstract class BusinessRule
      {
            public string Property { get; set; }
            public string Error { get; set; }

            public BusinessRule(string proPerty, string error)
            {
                  Property=proPerty;
                  Error=error;
            }
            public BusinessRule(string proPerty)
            {
                  Error=proPerty +" is not valid";
            }
            public abstract bool Validate(BusinessObject ob);
            protected object GetPropertyValue(BusinessObject businessObject)
            {
                  // note: reflection is relatively slow
                  return businessObject.GetType().GetProperty(Property).GetValue(businessObject, null);
            }
      }
       
      abstract class BusinessObject
      {
            List<BusinessRule> rules=new List<BusinessRule>();

            List<string> errors=new List<string>();

            public List<string> Errors
            { get { return errors;} 
            
            }
            protected void AddRule(BusinessRule rule)
            {
                  rules.Add(rule);
            }
            public bool IsValid()
            {
                  bool valid=true;
                  errors.Clear();
                  foreach(var rule in rules)
                  {
                        if(!rule.Validate(this))
                        {
                              valid=false;
                              errors.Add(rule.Error);
                        }
                  }
                  return valid;
            }
      }

      class Cat: BusinessObject
      {
            public int Id { get; set; }
            public string Name { get; set; }

            public Cat()
            {
                  AddRule(new ValidateExisting("Name"));
            }
      }

      class ValidateExisting: BusinessRule
      {
            public ValidateExisting(string proPerty)
                  :base(proPerty)
            {
                  Error="this is exist";
            }
            public override bool Validate(BusinessObject ob)
            {
                return GetPropertyValue(ob).ToString().Length > 0? true:false; // TODO kiem tra trong database
            }
      }

}
