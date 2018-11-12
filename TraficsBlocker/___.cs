using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace _
{
    class ___
    {
             
        
        [DllImport("iphlpapi.dll")]
        internal static extern uint GetTcpTable(________________________ pTcpTable, ref uint dwOutBufLen, bool order);

        public static TcpConnectionInformation[] _()
        {
            var __ = 0U;
            var ___ = (________________________) null;
            var ____ = (System.Net.NetworkInformation._[]) null;
            var _____ = GetTcpTable(________________________.Zero, ref __, true);
            while ((int) _____ == 122)
            {
                try
                {
                    ___ = ________________________.LocalAlloc((int) __);
                    _____ = GetTcpTable(___, ref __, true);
                    if ((int) _____ == 0)
                    {
                        var ________ = ___.DangerousGetHandle();
                        var mibTcpTable = (______________________) Marshal.PtrToStructure(________, typeof (______________________));
                        if (mibTcpTable._ <= 0U) continue;
                        ____ =
                            new System.Net.NetworkInformation._[mibTcpTable._];
                        var ____________________ =
                            (IntPtr) ((long) ________ + Marshal.SizeOf(mibTcpTable._));
                        for (var _____________ = 0; (long) _____________ < (long) mibTcpTable._; ++_____________)
                        {
                            var ___________ = (__________________) Marshal.PtrToStructure(____________________, typeof (__________________));
                            ____[_____________] = new System.Net.NetworkInformation._(___________);
                            ____________________ = (IntPtr) ((long) ____________________ + Marshal.SizeOf(___________));
                        }
                    }
                }
                finally
                {
                    if (___ != null)
                        ___.Close();
                }
            }
            return null;
        }
    }
}