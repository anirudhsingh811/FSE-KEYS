using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaWrapper
{
    /// <summary>Closure type used to publish processing results.</summary>
    public unsafe partial class CzmFactoryResult : IDisposable, ICzmFactoryResult
    {
        [StructLayout(LayoutKind.Sequential, Size = 24)]
        public partial struct Internal
        {
            internal IntPtr args;
            internal IntPtr notify;
            internal IntPtr notifyV2;

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "??0CzmFactoryResult@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr constructor(IntPtr instance, IntPtr zero);
        }

        public IntPtr Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmFactoryResult> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmFactoryResult>();

        protected bool ownsNativeInstance;

        internal static CzmFactoryResult CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CzmFactoryResult(native.ToPointer(), skipVTables);
        }

        internal static CzmFactoryResult GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CzmFactoryResult)managed;
            var result = CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CzmFactoryResult CreateInstance(Internal native, bool skipVTables = false)
        {
            return new CzmFactoryResult(native, skipVTables);
        }

        private static void* CopyValue(Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Internal));
            *(Internal*)ret = native;
            return ret.ToPointer();
        }

        private CzmFactoryResult(Internal native, bool skipVTables = false)
            : this(CopyValue(native), skipVTables)
        {
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        protected CzmFactoryResult(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            Instance = new IntPtr(native);
        }

        public CzmFactoryResult()
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmFactoryResult.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        public CzmFactoryResult(CzmFactoryResult czmFactoryResult)
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmFactoryResult.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
            *((CzmFactoryResult.Internal*)Instance) = *((CzmFactoryResult.Internal*)czmFactoryResult.Instance);
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
        public Delegates.Action_IntPtr_EnigmaWrapper_CzmError_long_long NotifyV2
        {
            get
            {
                var ptr0 = ((Internal*)Instance)->notifyV2;
                return ptr0 == IntPtr.Zero ? null : (Delegates.Action_IntPtr_EnigmaWrapper_CzmError_long_long)Marshal.GetDelegateForFunctionPointer(ptr0, typeof(Delegates.Action_IntPtr_EnigmaWrapper_CzmError_long_long));
            }

            set
            {
                ((Internal*)Instance)->notifyV2 = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }
    }

    /// <summary>Representation of the in-house technicians within the assembly line.</summary>
    public unsafe partial class CzmFactory : IDisposable, ICzmFactory
    {
        [StructLayout(LayoutKind.Sequential, Size = 24)]
        public partial struct Internal
        {
            internal CzmFactoryResult.Internal result;

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "??0CzmFactory@@QEAA@AEBU0@@Z", CallingConvention = CallingConvention.Cdecl)]
            internal static extern IntPtr constructor(IntPtr instance, IntPtr zero);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaFactoryMakeInstance", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void CzmEnigmaFactoryMakeInstance(IntPtr @return, IntPtr result);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaFactoryValidatePasscode", CallingConvention = CallingConvention.Cdecl)]
            internal static extern CzmError CzmEnigmaFactoryValidatePasscode(IntPtr admin, long today, [MarshalAs(UnmanagedType.LPArray)] string[] prod, ulong prodCnt, [MarshalAs(UnmanagedType.LPStr)] string pass);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaFactoryValidatePasscodeFromFile", CallingConvention = CallingConvention.Cdecl)]
            internal static extern CzmError CzmEnigmaFactoryValidatePasscodeFromFile(IntPtr admin, long today, [MarshalAs(UnmanagedType.LPArray)] string[] prod, ulong prodCnt, IntPtr root, ulong rootLen);
        }

        public IntPtr Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmFactory> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, CzmFactory>();

        protected bool ownsNativeInstance;

        internal static CzmFactory CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CzmFactory(native.ToPointer(), skipVTables);
        }

        internal static CzmFactory GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CzmFactory)managed;
            var result = CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CzmFactory CreateInstance(Internal native, bool skipVTables = false)
        {
            return new CzmFactory(native, skipVTables);
        }

        private static void* CopyValue(Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Internal));
            *(Internal*)ret = native;
            return ret.ToPointer();
        }

        private CzmFactory(Internal native, bool skipVTables = false)
            : this(CopyValue(native), skipVTables)
        {
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        protected CzmFactory(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            Instance = new IntPtr(native);
        }

        public CzmFactory()
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmFactory.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
        }

        public CzmFactory(CzmFactory czmFactory)
        {
            Instance = Marshal.AllocHGlobal(sizeof(CzmFactory.Internal));
            ownsNativeInstance = true;
            NativeToManagedMap[Instance] = this;
            *((CzmFactory.Internal*)Instance) = *((CzmFactory.Internal*)czmFactory.Instance);
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

        /// <summary>Returns an initialized instance of #CzmFactory</summary>
        /// <param name="result">- closure invoked to publish processing results</param>
        /// <remarks>#CzmFactory</remarks>
        public static CzmFactory CzmEnigmaFactoryMakeInstance(CzmFactoryResult result)
        {
            if (ReferenceEquals(result, null))
                throw new global::System.ArgumentNullException("result", "Cannot be null because it is passed by value.");
            var arg0 = result.Instance;
            var ret = new CzmFactory.Internal();
            Internal.CzmEnigmaFactoryMakeInstance(new IntPtr(&ret), arg0);
            return CzmFactory.CreateInstance(ret);
        }

        /// <summary>
        /// <para>Validates whether the passcode authenticates the in-house technician domain for at least</para>
        /// <para>one product specified.</para>
        /// </summary>
        /// <param name="admin">- #CzmFactory instance</param>
        /// <param name="today">- Current calendar date in seconds since UTC 01-JAN-1970 00:00:00</param>
        /// <param name="prod">- Product codes to check</param>
        /// <param name="pass">- Passcode</param>
        /// <remarks>
        /// <para>Authentication is granted for the defined range of consecutive calendar days.</para>
        /// <para>#ENIGMA_NOERROR if validation succeeded for at least one product</para>
        /// <para>code in</para>
        /// </remarks>
        public static CzmError CzmEnigmaFactoryValidatePasscode(CzmFactory admin, long today, string[] prod, ulong prodCnt, string pass)
        {
            var arg0 = admin is null ? IntPtr.Zero : admin.Instance;
            var ret = Internal.CzmEnigmaFactoryValidatePasscode(arg0, today, prod, prodCnt, pass);
            return ret;
        }

        /// <summary>
        /// <para>Validates whether the passcode stored in a keyfile authenticates the in-house</para>
        /// <para>technician domain for at least one product specified.</para>
        /// </summary>
        /// <param name="admin">- #CzmFactory instance</param>
        /// <param name="today">- Current calendar date in seconds since UTC 01-JAN-1970 00:00:00</param>
        /// <param name="prod">- Product codes to check</param>
        /// <param name="root">- UTF16-encoded path to file storage loading the keyfile from</param>
        /// <remarks>
        /// <para>Authentication is granted for the defined range of consecutive calendar days.</para>
        /// <para>#ENIGMA_NOERROR if validation succeeded for at least one product</para>
        /// <para>code in</para>
        /// </remarks>
        public static CzmError CzmEnigmaFactoryValidatePasscodeFromFile(CzmFactory admin, long today, string[] prod, ulong prodCnt, IntPtr root, ulong rootLen)
        {
            var arg0 = admin is null ? IntPtr.Zero : admin.Instance;
            var ret = Internal.CzmEnigmaFactoryValidatePasscodeFromFile(arg0, today, prod, prodCnt, root, rootLen);
            return ret;
        }

        public CzmFactoryResult Result
        {
            get
            {
                return CzmFactoryResult.CreateInstance(new IntPtr(&((Internal*)Instance)->result));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((Internal*)Instance)->result = *(CzmFactoryResult.Internal*)value.Instance;
            }
        }
    }
}
