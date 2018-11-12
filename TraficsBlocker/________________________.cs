using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

namespace _
{
    [SuppressUnmanagedCodeSecurity]
    internal sealed class ________________________ : SafeHandleZeroOrMinusOneIsInvalid
    {
        public static ________________________ Zero = new ________________________(false);
        private const int LMEM_FIXED = 0;
        private const int NULL = 0;

        static ________________________()
        {
        }

        public ________________________()
            : base(true)
        {
        }

        private ________________________(bool ownsHandle)
            : base(ownsHandle)
        {
        }
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [DllImport("kernel32.dll", SetLastError = true)]
        internal extern static IntPtr LocalFree(IntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal extern static ________________________ LocalAlloc(int uFlags, UIntPtr sizetdwBytes);

        public static ________________________ LocalAlloc(int cb)
        {
            ________________________ safeLocalFree = LocalAlloc(0, (UIntPtr) ((ulong) cb));
            if (!safeLocalFree.IsInvalid)
                return safeLocalFree;
            safeLocalFree.SetHandleAsInvalid();
            throw new OutOfMemoryException();
        }

        protected override bool ReleaseHandle()
        {
            return LocalFree(handle) == IntPtr.Zero;
        }
    }
}