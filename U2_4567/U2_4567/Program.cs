using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace U2_4567
{
    // Author : Raj Barot
    // Purpose : Complete 4 5 6 7 question of Unit test 2

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber;

        public abstract void Connect();

        public abstract void Disconnect();
    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();

        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {
            //   Console.WriteLine("RotaryPhone MakeCall");          
        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {
            //    Console.WriteLine("PushButtonPhone MakeCall");
        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;
       
        public byte WhichDrWho
        {
            get;
        }

        public string FemaleSideKick
        {
            get;
        }

        public void TimeTravel()
        {
            Console.WriteLine("Time Travel Successfull");
        }
        public static bool operator ==(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.whichDrWho == t2.whichDrWho)
            {

                status = true;
            }
            return status;
        }
        public static bool operator !=(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.whichDrWho != t2.whichDrWho)
            {

                status = true;
            }
            return status;
        }
        public static bool operator <(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.whichDrWho == 10)
            {
                status = false;
            }
            else if (t2.whichDrWho == 10)
            {
                status = true;
            }
            else if (t1.whichDrWho < t2.whichDrWho)
            {
                status = true;
            }
            return status;
        }
        public static bool operator >(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.whichDrWho == 10)
            {
                status = true;
            }
            else if (t2.whichDrWho == 10)
            {
                status = false;
            }
            else if (t1.whichDrWho > t2.whichDrWho)
            {
                status = true;
            }
            return status;
        }
        public static bool operator <=(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.whichDrWho == 10)
            {
                status = false;
            }
            else if (t2.whichDrWho == 10)
            {
                status = true;
            }
            else if (t1.whichDrWho <= t2.whichDrWho)
            {
                status = true;
            }
            return status;
        }
        public static bool operator >=(Tardis t1, Tardis t2)
        {
            bool status = false;
            if (t1.whichDrWho == 10)
            {
                status = true;
            }
            else if (t2.whichDrWho == 10)
            {
                status = false;
            }
            else if (t1.whichDrWho >= t2.whichDrWho)
            {
                status = true;
            }
            return status;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override bool Equals(object o)
        {
            return true;
        }

    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneCall;

        public void OpenDoor()
        {
            Console.WriteLine("Phonebooth -Open door");
        }

        public void CloseDoor()
        {

        }
    }
    public class Myclass
    {
        public static void Main(string[] args)
        {
            PhoneInterface t1 = new Tardis();
            PhoneInterface p1 = new PhoneBooth();
            UsePhone(t1);
            UsePhone(p1);

        }
        static void UsePhone(object obj)
        {
            ((PhoneInterface)obj).MakeCall();   // Casting the object through interface
            ((PhoneInterface)obj).HangUp();
            try
            {
                ((Tardis)obj).TimeTravel(); // if casting the object is succesfull; if its a tardis objectt then it will run timetravel function
            }
            catch
            {
                ((PhoneBooth)obj).OpenDoor(); // if casting the object is succesfull; if its a phonebooth objectt then it will run opendoor function
            }
        }
    }

}