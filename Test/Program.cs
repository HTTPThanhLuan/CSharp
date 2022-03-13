using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
      class Program
      {
            static void Main(string[] args)
            {
                  //Config con=new Config();
                  //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(con.GetType());
                  //x.Serialize(Console.Out, con);
                  //Console.WriteLine();
                  //Console.ReadLine();

                  //  var date=DateTime.Now;

                  //   var chuoiMaHoa =  Config.AsEncrypt("Trần Thành Luân","1234567890");


                  //  var tenLuan =   Config.AsEncrypt(chuoiMaHoa, "1234567890");

                  //List<A> listA = new List<A>() { new A { name = "TraVinh", price = 1 }, new A { name = "TraVinh", price = 2 } } ;

                  //var re = listA.GroupBy(t => t.name).Select(t => new { name = t.Key, price = t.Sum(x => x.price) });

                  //foreach (var item in re)
                  //{
                  //      Console.WriteLine("name {0} - price{1}", item.name , item.price.ToString());
                  //}


                 string a = "7.0";

                 string[] b =a.Split('.');
                  var c = b;


                string dateString = "2017-12-02T18:54:17.128Z";

                  DateTime d = DateTime.Parse(dateString);


                  //Datetime convert to ISO
                  var k = DateTime.UtcNow.ToString("o");

             


                  //abc

                  string s = new Uri("//khanhhoauploadservice.psctelecom.com.vn//Temp/nam2017/thang12/ngay26/892d0a41-abcd-4600-aa74-8fbf12ff22c5.txt").PathAndQuery;


                  //TypeOf

                  var i = 1;
            }
      }


      class A
      {
          public   string name;
          public  int price;
            
      }
     

      public class Config
      {
            public Config()
            {
                  DanhSachNhan=new List<string>();
                  DanhSachNhan.Add("luan.tt@gmail.com");
                  DanhSachNhan.Add("Sang@gmail.com");
                  DanhSachThamKhao =new List<string>();
                  DanhSachThamKhao.Add("Trang@gmail.com");
            }
            public List<string> DanhSachNhan { get; set; }
            public List<string> DanhSachThamKhao { get;set;}



            public static string AsEncrypt( string plainStr, string KeyString)
            {
                  RijndaelManaged aesEncryption = new RijndaelManaged();
                  aesEncryption.KeySize = 256;
                  aesEncryption.BlockSize = 128;
                  aesEncryption.Mode = CipherMode.ECB;
                  aesEncryption.Padding = PaddingMode.ISO10126;
                  byte[] KeyInBytes = Encoding.UTF8.GetBytes(KeyString);
                  aesEncryption.Key = KeyInBytes;
                  byte[] plainText = ASCIIEncoding.UTF8.GetBytes(plainStr);
                  ICryptoTransform crypto = aesEncryption.CreateEncryptor();
                  byte[] cipherText = crypto.TransformFinalBlock(plainText, 0, plainText.Length);
                  return Convert.ToBase64String(cipherText);
            }

            public static string AsDecrypt( string encryptedText, string KeyString)
            {
                  RijndaelManaged aesEncryption = new RijndaelManaged();
                  aesEncryption.KeySize = 256;
                  aesEncryption.BlockSize = 128;
                  aesEncryption.Mode = CipherMode.ECB;
                  aesEncryption.Padding = PaddingMode.ISO10126;
                  byte[] KeyInBytes = Encoding.UTF8.GetBytes(KeyString);
                  aesEncryption.Key = KeyInBytes;
                  ICryptoTransform decrypto = aesEncryption.CreateDecryptor();
                  byte[] encryptedBytes = Convert.FromBase64CharArray(encryptedText.ToCharArray(), 0, encryptedText.Length);
                  return ASCIIEncoding.UTF8.GetString(decrypto.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
            }
      }
}
