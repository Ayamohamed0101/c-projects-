using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ladies_GYM
{
    internal class ClsControlFilesGYM
    {
        static string path = "Ladies_GYM.txt";
    public struct  playerInfo 

        { // struct deafult is private
            public int ID;
            public string Name;
            public short Age;
            public float Weight;
            public float Height;
            public string Level;
            public string Number;
            public double Cost;
            public string Note;
            public bool IsExistID;

        };
        private playerInfo EmptyPlayerInfo()
        {
            return new playerInfo 
            { ID = 0, Name = null, Age = 0, Weight = 0, Height = 0,
                Level = "NO Selection", Number = "NOT FOUND", Cost = 0,
                Note = "NOT FOUND", IsExistID = false
            };
        }
    private  playerInfo convertlinetoInfo( string line)
        { // intilize deafult object of struct then fill it with data
            playerInfo info = EmptyPlayerInfo();
            string[] arrayInfo = line.Split('#'); // seprator must be one char
            info.Name = arrayInfo[1];
            info.ID = int.Parse(arrayInfo[0]);
            info.Number = arrayInfo[2];
            info.Height = float.Parse(arrayInfo[3]);
            info.Weight = float.Parse(arrayInfo[4]);
            info.Age = short.Parse(arrayInfo[5]);
            info.Cost = double.Parse(arrayInfo[6]);
            info.Level = arrayInfo[7];
            info.Note = arrayInfo[8];
            return info;

        }
        public bool checkExistId(int id)
        {
            bool check = false; // flag
            string line;
            playerInfo p1;
            StreamReader sr = new StreamReader(path); // find file path then loop on file
            while((line = sr.ReadLine())!=null ) 
            {
                p1 = convertlinetoInfo(line);

                if (p1.ID == id)
                {
                    check = true;
                    break;
                }

            }
            sr.Close();
            return check;
        }

        //
        public bool checkExistId(int id, ref int countline)
        {
            countline = 0;
            bool check = false; // flag
            string line;
            playerInfo p1;
            StreamReader sr = new StreamReader(path); // find file path then loop on file
            while (   (line = sr.ReadLine())   != null)
            {
                countline++;
                p1 = convertlinetoInfo(line);

                if (p1.ID == id)
                {
                    check = true;
                    break;
                }

            }
            sr.Close();
            return check;
        }
      public playerInfo  ReloadInfoPlayer(int id)
        {

            playerInfo player;
            string line;
            StreamReader sr=new StreamReader(path);
            while (  (line=sr.ReadLine() ) != null )
            {
                player= convertlinetoInfo(line);
                if (player.ID==id)
                {
                    Console.WriteLine("Participant Existe ");
                    sr.Close() ;
                    player.IsExistID = true;
                    return player;
                }
            }
            Console.WriteLine("Participant Not Existe ");
            sr.Close();
            player.IsExistID = false;
            player = EmptyPlayerInfo();
            return player;

        }
        static void AddParticipantToFile(string lineInfo)
        { // stream writter
            StreamWriter sr = new StreamWriter(path,true);  
            sr.Close ();

            sr=new StreamWriter(path,true);
            sr.WriteLine(lineInfo);
            sr.Close ();
            Console.WriteLine ("Done successfully");

        }

       public  playerInfo[] LoadinfotoFile( )
            // if file not existe create one
        { StreamWriter newfile =new StreamWriter(path); newfile.Close ();
          StreamReader sr =new StreamReader(path);
            string line;
            int c = 0;
            playerInfo info;
            // creat array
            playerInfo[] array = new playerInfo[100];
            while( (line=sr.ReadLine()  ) !=null      )
            {
                info = convertlinetoInfo(line);
                array[c++] = info;

            }
            sr.Close();
            return array;


        }
      public bool Deleteparticipant(int id)
      {
            int numline = 0;
           
            int count = 0;
            if ( checkExistId ( id, ref numline) )            
            {
                string path2 = "Change Info.txt";
                string line;
                StreamReader sr1 = new StreamReader(path); sr1.Close();
                StreamWriter sw2 = new StreamWriter(path2); sw2.Close();

                while ((line = sr1.ReadLine()) != null)
                {
                    count++;
                    if (count != numline)
                    {
                        sw2.WriteLine(line); // new file
                    }
                }
                sr1.Close();
                sw2.Close();
                File.Delete(path);
                File.Copy(path2, path);
                File.Delete(path2);
                Console.WriteLine("Done.");
                return true;

            }
            return false;
        }

        public bool EditPlayer(int id, string NewLine)
        {

            int NumberLine = 0;
            int count = 0;
            if (checkExistId(id, ref NumberLine))
            {
                string path2 = "Change Info.txt";
                string line;
                StreamReader sr = new StreamReader(path);
                StreamWriter sw = new StreamWriter(path2);
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    if (count != NumberLine)
                    {
                        sw.WriteLine(line);
                    }
                    else
                    {
                        sw.WriteLine(NewLine);
                    }
                }
                sw.Close();
                sr.Close();
                File.Delete(path);
                File.Copy(path2, path);
                File.Delete(path2);
                Console.WriteLine("Done.");
                return true;
            }
            return false;
        }
        public string AddNewCost(ref playerInfo info,double subscription,string sepretor="#")
        {
            if(subscription>0)
            {
                info.Cost += subscription;
            }

            string Line = "";
            Line += info.ID + sepretor;
            Line += info.Name + sepretor;
            Line += info.Number + sepretor;
            Line += info.Height + sepretor;
            Line += info.Weight + sepretor;
            Line += info.Age + sepretor;
            Line += info.Cost + sepretor;
            Line += info.Level + sepretor;
            Line += info.Note;
            return Line;
        }


        public string NewCostLoss(ref playerInfo info, double NewSubscription, string spreter = "#")
        {
            if (NewSubscription > 0)
            {
                info.Cost -= NewSubscription;
            }

            string Line = "";
            Line += info.ID + spreter;
            Line += info.Name + spreter;
            Line += info.Number + spreter;
            Line += info.Height + spreter;
            Line += info.Weight + spreter;
            Line += info.Age + spreter;
            Line += info.Cost + spreter;
            Line += info.Level + spreter;
            Line += info.Note;
            return Line;
        }

        public void RenewSubscription(int id, double NewSubscription)
        {
            string path2 = "Change Info.txt";
            playerInfo info;
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(path2, true);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                info = convertlinetoInfo(line);
                if (id == info.ID)
                {
                    sw.WriteLine(AddNewCost(ref info, NewSubscription));

                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete(path);
            File.Copy(path2, path);
            File.Delete(path2);
        }
        public bool PaySubscription(int id, double PaySubscription)
        {
            string path2 = "Change Info.txt";
            playerInfo info;
            StreamReader sr = new StreamReader(path);
            StreamWriter sw = new StreamWriter(path2, true);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                info = convertlinetoInfo(line);
                if (id == info.ID)
                {
                    sw.WriteLine(NewCostLoss(ref info, PaySubscription));
                    if (info.Cost < 0)
                    {
                        return true;
                    }
                }
                else
                {
                    sw.WriteLine(line);
                }
            }
            sr.Close();
            sw.Close();
            File.Delete(path);
            File.Copy(path2, path);
            File.Delete(path2);
            return false;
        }




    }
}
