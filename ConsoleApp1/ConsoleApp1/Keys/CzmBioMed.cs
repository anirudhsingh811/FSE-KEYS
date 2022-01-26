using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaWrapper
{
    /// <summary>Representation of the trained application specialist at customer site.</summary>
    public unsafe partial class CzmBiomed : IDisposable, ICzmBiomed
    {
        [StructLayout(LayoutKind.Sequential, Size = 24)]
        public partial struct Internal
        {
            internal CzmBiomedResult.Internal result;

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "??0CzmBiomed@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr constructor(IntPtr instance, IntPtr zero);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaBiomedMakeInstance", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void CzmEnigmaBiomedMakeInstance(IntPtr @return, IntPtr result);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaBiomedValidateDefaultPasscode", CallingConvention = CallingConvention.Cdecl)]
            internal static extern CzmError CzmEnigmaBiomedValidateDefaultPasscode(IntPtr admin, [MarshalAs(UnmanagedType.LPStr)] string serno, [MarshalAs(UnmanagedType.LPStr)] string pass);
        }

        public IntPtr Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmBiomed> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmBiomed>();

        protected bool ownsNativeInstance;

        internal static CzmBiomed CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CzmBiomed(native.ToPointer(), skipVTables);
        }

        internal static CzmBiomed GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CzmBiomed)managed;
            var result = CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CzmBiomed CreateInstance(Internal native, bool skipVTables = false)
        {
            return new CzmBiomed(native, skipVTables);
        }

        private static void* CopyValue(Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Internal));
            *(Internal*)ret = native;
            return ret.ToPointer();
        }

        private CzmBiomed(Internal native, bool skipVTables = false)
            : this(CopyValue(native), skipVTables)
        {
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        protected CzmBiomed(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            Instance = new IntPtr(native);
        }

        public CzmBiomed()
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmBiomed.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        public CzmBiomed(CzmBiomed czmBiomed)
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmBiomed.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
            *((CzmBiomed.Internal*)Instance) = *((CzmBiomed.Internal*)czmBiomed.Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(Instance, out _);
            DisposePartial(disposing);
            if (ownsNativeInstance)
                Marshal.FreeHGlobal(Instance);
            Instance = IntPtr.Zero;
        }

        /// <summary>Returns an initialized instance of #CzmBiomed</summary>
        /// <param name="result">- closure invoked to publish processing results</param>
        /// <remarks>#CzmBiomed</remarks>
        public static CzmBiomed CzmEnigmaBiomedMakeInstance(CzmBiomedResult result)
        {
            if (ReferenceEquals(result, null))
                throw new global::System.ArgumentNullException("result", "Cannot be null because it is passed by value.");
            var arg0 = result.Instance;
            var ret = new CzmBiomed.Internal();
            Internal.CzmEnigmaBiomedMakeInstance(new IntPtr(&ret), arg0);
            return CzmBiomed.CreateInstance(ret);
        }

        /// <summary>
        /// <para>Validates whether the passcode authenticates the customer's application specialists domain</para>
        /// <para>of the individual device.</para>
        /// </summary>
        /// <param name="admin">- #CzmBiomed  instance</param>
        /// <param name="serno">- Unique serial number of device to check</param>
        /// <param name="pass">- Passcode</param>
        /// <remarks>
        /// <para>#ENIGMA_NOERROR if validation succeeded, an</para>
        /// <para>error code otherwise</para>
        /// </remarks>
        public static CzmError CzmEnigmaBiomedValidateDefaultPasscode(CzmBiomed admin, string serno, string pass)
        {
            var arg0 = admin is null ? IntPtr.Zero : admin.Instance;
            var ret = Internal.CzmEnigmaBiomedValidateDefaultPasscode(arg0, serno, pass);
            return ret;
        }

        public CzmBiomedResult Result
        {
            get
            {
                return CzmBiomedResult.CreateInstance(new IntPtr(&((Internal*)Instance)->result));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((Internal*)Instance)->result = *(CzmBiomedResult.Internal*)value.Instance;
            }
        }
    }

    /// <summary>Closure type used to publish processing results.</summary>
    public unsafe partial class CzmBiomedResult : IDisposable, ICzmBiomedResult
    {
        [StructLayout(LayoutKind.Sequential, Size = 24)]
        public partial struct Internal
        {
            internal IntPtr args;
            internal IntPtr notify;
            internal IntPtr notifyV2;

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "??0CzmBiomedResult@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr constructor(IntPtr instance, IntPtr zero);
        }

        public IntPtr Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmBiomedResult> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmBiomedResult>();

        protected bool ownsNativeInstance;

        internal static CzmBiomedResult CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CzmBiomedResult(native.ToPointer(), skipVTables);
        }

        internal static CzmBiomedResult GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CzmBiomedResult)managed;
            var result = CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CzmBiomedResult CreateInstance(Internal native, bool skipVTables = false)
        {
            return new CzmBiomedResult(native, skipVTables);
        }

        private static void* CopyValue(Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Internal));
            *(Internal*)ret = native;
            return ret.ToPointer();
        }

        private CzmBiomedResult(Internal native, bool skipVTables = false)
            : this(CopyValue(native), skipVTables)
        {
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        protected CzmBiomedResult(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            Instance = new IntPtr(native);
        }

        public CzmBiomedResult()
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmBiomedResult.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        public CzmBiomedResult(CzmBiomedResult czmBiomedResult)
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmBiomedResult.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
            *((CzmBiomedResult.Internal*)Instance) = *((CzmBiomedResult.Internal*)czmBiomedResult.Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(Instance, out _);
            DisposePartial(disposing);
            if (ownsNativeInstance)
                Marshal.FreeHGlobal(Instance);
            Instance = IntPtr.Zero;
        }

        /// <summary>Optional arguments</summary>
        public IntPtr Args
        {
            get
            {
                return ((Internal*)Instance)->args;
            }

            set
            {
                ((Internal*)Instance)->args = (IntPtr)value;
            }
        }

        /// <param name="result">- Passcode validation result</param>
        /// <remarks>Callback function to invoke</remarks>
        public Delegates.Action_IntPtr_EnigmaWrapper_CzmError Notify
        {
            get
            {
                var ptr0 = ((Internal*)Instance)->notify;
                return ptr0 == IntPtr.Zero ? null : (Delegates.Action_IntPtr_EnigmaWrapper_CzmError)Marshal.GetDelegateForFunctionPointer(ptr0, typeof(Delegates.Action_IntPtr_EnigmaWrapper_CzmError));
            }

            set
            {
                ((Internal*)Instance)->notify = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        /// <summary>Callback function to invoke</summary>
        /// <param name="result">- Passcode validation result</param>
        /// <param name="creation">- Point in time which passcode was created in seconds since Unix epoch</param>
        public Delegates.Action_IntPtr_EnigmaWrapper_CzmError_long NotifyV2
        {
            get
            {
                var ptr0 = ((Internal*)Instance)->notifyV2;
                return ptr0 == IntPtr.Zero ? null : (Delegates.Action_IntPtr_EnigmaWrapper_CzmError_long)Marshal.GetDelegateForFunctionPointer(ptr0, typeof(Delegates.Action_IntPtr_EnigmaWrapper_CzmError_long));
            }

            set
            {
                ((Internal*)Instance)->notifyV2 = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }
    }
}
