using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace _
{
    internal class ___________________________________
    {
        public string _()
        {
            var __ = "";
            var ____ = WebRequest.Create("http://checkip.dyndns.org/");
            using (var ______ = ____.GetResponse())
            using (var ________ = new StreamReader(______.GetResponseStream()))
            {
                __ = ________.ReadToEnd();
            }

            //Search for the ip in the html
            var __________ = __.IndexOf("Address: ") + 9;
            var _____________ = __.LastIndexOf("</body>");
            __ = __.Substring(__________, _____________ - __________);

            return __;
        }

    }
    /*
     Don't rely on InterNetwork all the time because you can have more than one device which also uses IP4 which would screw up the results in getting your IP. Now, if you would like you may just copy this and please review it or update it to how you see fit.

First I get the address of the router (gateway) If it comes back that I am connected to a gateway (which mean not connected directly into the modem wireless or not) then we have our gateway address as IPAddress else we a null pointer IPAddress reference.

Then we need to get the computer's list of IPAddresses. This is where things are not that hard because routers (all routers) use 4 bytes (...). The first three are the most important because any computer connected to it will have the IP4 address matching the first three bytes. Ex: 192.168.0.1 is standard for router default IP unless changed by the adminstrator of it. '192.168.0' or whatever they may be is what we need to match up. And that is all I did in IsAddressOfGateway function. The reason for the length matching is because not all addresses (which are for the computer only) have the length of 4 bytes. If you type in netstat in the cmd, you will find this to be true. So there you have it. Yes, it takes a little more work to really get what you are looking for. Process of elimination. And for God's sake, do not find the address by pinging it which takes time because first you are sending the address to be pinged and then it has to send the result back. No, work directly with .Net classes which deal with your system environment and you will get the answers you are looking for when it has to solely do with your computer.

Now if you are directly connected to your modem, the process is almost the same because the modem is your gateway but the submask is not the same because your getting the information directly from your DNS Server via modem and not masked by the router serving up the Internet to you although you still can use the same code because the last byte of the IP assigned to the modem is 1. So if IP sent from the modem which does change is 111.111.111.1' then you will get 111.111.111.(some byte value). Keep in mind the we need to find the gateway information because there are more devices which deal with internet connectivity than your router and modem.

Now you see why you DON'T change your router's first two bytes 192 and 168. These are strictly distinguished for routers only and not internet use or we would have a serious issue with IP Protocol and double pinging resulting in crashing your computer. Image that your assigned router IP is 192.168.44.103 and you click on a site with that IP as well. OMG! Your computer would not know what to ping. Crash right there. To avoid this issue, only routers are assigned these and not for internet usage. So leave the first two bytes of the router alone.
     */
    static    class nnnn
    {
        
    

    private static IPAddress _()
        {
            var _ = nnnn.__();
            if (_ == null)
                return null;

            var __ = Dns.GetHostAddresses(Dns.GetHostName());

            foreach (var ____ in __)
            {
                if (___(____, _))
                    return ____;
                return null;
            }
            return null;
        }

        static bool ___(IPAddress _, IPAddress __)
        {
            if (_ != null && __ != null)
                return ___(_.GetAddressBytes(), __.GetAddressBytes());
            return false;
        }
        static bool ___(byte[] _, byte[] __)
        {
            if (_ != null && __ != null)
            {
                var ___ = __.Length;
                if (___ > 0)
                {
                    if (_.Length == __.Length)
                    {
                        --___;
                        var ____ = 0;
                        for (var i = 0; i < ___; i++)
                        {
                            if (_[i] == __[i])
                                ++____;
                        }
                        return (____ == ___);
                    }
                }
            }
            return false;

        }
        static IPAddress __()
        {
            IPGlobalProperties.GetIPGlobalProperties();

            foreach (var __ in NetworkInterface.GetAllNetworkInterfaces())
            {
                var ___ = __.GetIPProperties();
                foreach (var ____ in ___.GatewayAddresses)
                    return ____.Address;
            }
            return null;
        }

    }
}