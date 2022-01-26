using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ConsoleApp1;
using EnigmaWrapper;
using EnigmaWrapper.Delegates;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            var a = CzmEnigma.CzmEnigmaInit();
            //AdminITCheck();
           // ServiceCheck();
            //Getversion();
            //FSECheck();
            CzmEnigma.CzmEnigmaDeinit();
        }

        //    static void FSECheck()
        //    {
        //        CzmFactoryResult result = new CzmFactoryResult();

        //        Response wrapper = new Response();
        //        result.Notify = new Action___IntPtr_EnigmaWrapper_CzmError(wrapper.Action___IntPtr_EnigmaWrapper_CzmError);
        //        result.NotifyV2 = new Action___IntPtr_EnigmaWrapper_CzmError_long_long(wrapper.Action___IntPtr_EnigmaWrapper_CzmError_long_long);

        //        var admin = CzmFactory.CzmEnigmaFactoryMakeInstance(result);

        //        string[] strArray = new string[] { "6640" };

        //        var time = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

        //        var error = CzmFactory.CzmEnigmaFactoryValidatePasscode(admin, time, strArray, 1, "2F4E7472117921B028BDDAC0062CF059");

        //        string filePath = @"C:\Users\Customer\Downloads\FSE\POC\ConsoleApp1\ConsoleApp1\czm_admin_factory.master.key";
        //        var a = Marshal.StringToHGlobalUni(filePath);
        //        var UTF16data = Encoding.Unicode.GetBytes(filePath);
        //        var length = UTF16data.Length;

        //        error = CzmFactory.CzmEnigmaFactoryValidatePasscodeFromFile(admin, time, strArray, 1, a, (ulong)length);
        //        admin.Dispose();
        //        result.Dispose();
        //    }
        //    static void AdminITCheck()
        //    {
        //        CzmAdminITResult result = new CzmAdminITResult();


        //        Response wrapper = new Response();
        //        result.Notify = new Action___IntPtr_EnigmaWrapper_CzmError(wrapper.Action___IntPtr_EnigmaWrapper_CzmError);
        //        result.NotifyV2 = new Action___IntPtr_EnigmaWrapper_CzmError_long(wrapper.Action___IntPtr_EnigmaWrapper_CzmError_long);

        //        var admin = CzmAdminIT.CzmEnigmaAdminITMakeInstance(result);          

        //        var error = CzmAdminIT.CzmEnigmaAdminITValidateDefaultPasscode(admin, "6640101612", "524D84DB9BA405867F5B0DC108F3E651");
        //        admin.Dispose();
        //        result.Dispose();
        //    }

        //    static void ServiceCheck()
        //    {
        //        CzmServiceResult result = new CzmServiceResult();

        //        Response wrapper = new Response();
        //        result.Notify = new Action___IntPtr_EnigmaWrapper_CzmError___IntPtr_ulong_long_long(wrapper.Action___IntPtr_EnigmaWrapper_CzmError___IntPtr_ulong_long_long);

        //        var service = CzmService.CzmEnigmaServiceMakeInstance(result);

        //        var time = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        //        string[] strArray = new string[] { "6640" };



        //        string filePath = @"C:\Users\Customer\Downloads\FSE\POC\ConsoleApp1\ConsoleApp1\czm_admin_service.master.key";
        //        var a = Marshal.StringToHGlobalUni(filePath);
        //        var UTF16data = Encoding.Unicode.GetBytes(filePath);
        //        var length = UTF16data.Length;

        //        var error = CzmService.CzmEnigmaServiceValidateMasterPasscodeFromFile(service, time, strArray, 1, a,(ulong)length);
        //    }


        //    static void Getversion()
        //    {
        //        int major = -1;
        //        int minor = -1;
        //        int patch = -1;
        //        var c = CzmVersion.CzmEnigmaVersionMakeInstance;
        //        var f = CzmVersion.CzmEnigmaVersionGetVersion(c, ref major, ref minor, ref patch);
        //        var g = CzmVersion.CzmEnigmaVersionGetVersionNumber(c);
        //        var h = CzmVersion.CzmEnigmaVersionGetVersionString(c);
        //        var i = CzmVersion.CzmEnigmaVersionGetSourceRev(c);
        //    }

        }


    }
