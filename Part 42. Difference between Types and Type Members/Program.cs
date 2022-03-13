// ##########################################################################################################################
// #                                Types Vs Type Members
// #  In this example Customer is the Type and fields, Properties, and method are type members.
// #   
// #  So, in general classes, structs, enums, interfaces, delegates are called as types and fields, properties, constructors,  
// #  methods etc., that normally reside in a type are called as type members
// #   
// #  In C# there are 5 different access modifiers:    
// #   1. Private
// #   2. Protected
// #   3. Internal
// #   4. Protected Internal
// #   5. Public   
// #   
// #   Type members can have all the access modifiers, where as types can have only 2 (internal, public) of the 5 access modifiers
// #
// ##########################################################################################################################

class Customer
{
      private int _id;
      private string _firstName;
      private string _lastName;
      public int Id
      {
            get { return _id; }
            set { _id = value; }
      }
      public string FirstName
      {
            get { return _firstName; }
            set { _firstName = value; }
      }
      public string LastName
      {
            get { return _lastName; }
            set { _lastName = value; }
      }
      public string GetFullName()
      {
            return this._firstName + " " + this._lastName;
      }
     
}
class Program
{
      static void Main(string[] args)
      {
      }
}

