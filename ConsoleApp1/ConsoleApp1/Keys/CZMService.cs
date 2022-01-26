using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
//using IntPtr = global::System.IntPtr;

namespace EnigmaWrapper
{
    public unsafe partial class CzmService : IDisposable, ICzmService
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public partial struct Internal
        {
            internal CzmServiceResult.Internal result;

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "??0CzmService@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaServiceMakeInstance", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void CzmEnigmaServiceMakeInstance(IntPtr @return, IntPtr result);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaServiceValidateOnedayPasscode", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::EnigmaWrapper.CzmError CzmEnigmaServiceValidateOnedayPasscode(IntPtr admin, long today, IntPtr user, ulong userLen, [MarshalAs(UnmanagedType.LPArray)] string[] prod, ulong prodCnt, [MarshalAs(UnmanagedType.LPStr)] string pass);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaServiceValidateOnedayPasscodeFromFile", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::EnigmaWrapper.CzmError CzmEnigmaServiceValidateOnedayPasscodeFromFile(IntPtr admin, long today, IntPtr user, ulong userLen, [MarshalAs(UnmanagedType.LPArray)] string[] prod, ulong prodCnt, IntPtr root, ulong rootLen);

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "CzmEnigmaServiceValidateMasterPasscodeFromFile", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern global::EnigmaWrapper.CzmError CzmEnigmaServiceValidateMasterPasscodeFromFile(IntPtr admin, long today, [MarshalAs(UnmanagedType.LPArray)] string[] prod, ulong prodCnt, IntPtr root, ulong rootLen);
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EnigmaWrapper.CzmService> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EnigmaWrapper.CzmService>();

        protected bool __ownsNativeInstance;

        internal static CzmService __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CzmService(native.ToPointer(), skipVTables);
        }

        internal static CzmService __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CzmService)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CzmService __CreateInstance(Internal native, bool skipVTables = false)
        {
            return new CzmService(native, skipVTables);
        }

        private static void* __CopyValue(Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Internal));
            *(Internal*)ret = native;
            return ret.ToPointer();
        }

        private CzmService(Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CzmService(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public CzmService()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EnigmaWrapper.CzmService.Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CzmService(global::EnigmaWrapper.CzmService _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EnigmaWrapper.CzmService.Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::EnigmaWrapper.CzmService.Internal*)__Instance) = *((global::EnigmaWrapper.CzmService.Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Returns an initialized instance of #CzmService</summary>
        /// <param name="result">- closure invoked to publish processing results</param>
        /// <remarks>#CzmService</remarks>
        public static global::EnigmaWrapper.CzmService CzmEnigmaServiceMakeInstance(global::EnigmaWrapper.CzmServiceResult result)
        {
            if (ReferenceEquals(result, null))
                throw new global::System.ArgumentNullException("result", "Cannot be null because it is passed by value.");
            var __arg0 = result.__Instance;
            var __ret = new global::EnigmaWrapper.CzmService.Internal();
            Internal.CzmEnigmaServiceMakeInstance(new IntPtr(&__ret), __arg0);
            return global::EnigmaWrapper.CzmService.__CreateInstance(__ret);
        }

        /// <summary>
        /// <para>Validates whether the passcode authenticates the field service engineer domain for at least</para>
        /// <para>one product specified.</para>
        /// </summary>
        /// <param name="admin">- #CzmService instance</param>
        /// <param name="today">- Current calendar date in seconds since UTC 01-JAN-1970 00:00:00</param>
        /// <param name="user">- Service username [UTF16]</param>
        /// <param name="prod">- Product codes to check</param>
        /// <param name="pass">- Passcode</param>
        /// <remarks>
        /// <para>Authentication is granted for the single calendar dayonly.</para>
        /// <para>#ENIGMA_NOERROR if validation succeeded for at least one product</para>
        /// <para>code inand service engineer</para>
        /// </remarks>
        public static global::EnigmaWrapper.CzmError CzmEnigmaServiceValidateOnedayPasscode(global::EnigmaWrapper.CzmService admin, long today, IntPtr user, ulong userLen, string[] prod, ulong prodCnt, string pass)
        {
            var __arg0 = admin is null ? IntPtr.Zero : admin.__Instance;
            var __ret = Internal.CzmEnigmaServiceValidateOnedayPasscode(__arg0, today, user, userLen, prod, prodCnt, pass);
            return __ret;
        }

        /// <summary>
        /// <para>Validates whether the passcode stored in a keyfile authenticates the field service</para>
        /// <para>engineer domain for at least one product specified.</para>
        /// </summary>
        /// <param name="admin">- #CzmService instance</param>
        /// <param name="today">- Current calendar date in seconds since UTC 01-JAN-1970 00:00:00</param>
        /// <param name="user">- Service username [UTF16]</param>
        /// <param name="prod">- Product codes to check</param>
        /// <param name="root">- UTF16-encoded path to file storage loading the keyfile from</param>
        /// <remarks>
        /// <para>Authentication is granted for the single calendar dayonly.</para>
        /// <para>#ENIGMA_NOERROR if validation succeeded for at least one product</para>
        /// <para>code inand service engineer</para>
        /// </remarks>
        public static global::EnigmaWrapper.CzmError CzmEnigmaServiceValidateOnedayPasscodeFromFile(global::EnigmaWrapper.CzmService admin, long today, IntPtr user, ulong userLen, string[] prod, ulong prodCnt, IntPtr root, ulong rootLen)
        {
            var __arg0 = admin is null ? IntPtr.Zero : admin.__Instance;
            var __ret = Internal.CzmEnigmaServiceValidateOnedayPasscodeFromFile(__arg0, today, user, userLen, prod, prodCnt, root, rootLen);
            return __ret;
        }

        /// <summary>
        /// <para>Validates whether the passcode stored in a keyfile authenticates the field service</para>
        /// <para>engineer domain for at least one product specified.</para>
        /// </summary>
        /// <param name="admin">- #CzmService instance</param>
        /// <param name="today">- Current calendar date in seconds since UTC 01-JAN-1970 00:00:00</param>
        /// <param name="prod">- Product codes to check</param>
        /// <param name="root">- UTF16-encoded path to file storage loading the keyfile from</param>
        /// <remarks>
        /// <para>Authentication is granted for the defined range of consecutive calendar days.</para>
        /// <para>#ENIGMA_NOERROR if validation succeeded for at least one product</para>
        /// <para>code in</para>
        /// </remarks>
        public static global::EnigmaWrapper.CzmError CzmEnigmaServiceValidateMasterPasscodeFromFile(global::EnigmaWrapper.CzmService admin, long today, string[] prod, ulong prodCnt, IntPtr root, ulong rootLen)
        {
            var __arg0 = admin is null ? IntPtr.Zero : admin.__Instance;
            var __ret = Internal.CzmEnigmaServiceValidateMasterPasscodeFromFile(__arg0, today, prod, prodCnt, root, rootLen);
            return __ret;
        }

        public global::EnigmaWrapper.CzmServiceResult Result
        {
            get
            {
                return global::EnigmaWrapper.CzmServiceResult.__CreateInstance(new IntPtr(&((Internal*)__Instance)->result));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((Internal*)__Instance)->result = *(CzmServiceResult.Internal*)value.__Instance;
            }
        }
    }

    /// <summary>Closure type used to publish processing results.</summary>
    public unsafe partial class CzmServiceResult : IDisposable, ICzmServiceResult
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public partial struct Internal
        {
            internal IntPtr args;
            internal IntPtr notify;

            [SuppressUnmanagedCodeSecurity, DllImport(@"C:\Users\Customer\Downloads\FSE\Czm_Enigma_2.0.0\build\native\bin\x64\v141\Debug\Enigma.dll", EntryPoint = "??0CzmServiceResult@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern IntPtr cctor(IntPtr __instance, IntPtr _0);
        }

        public IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EnigmaWrapper.CzmServiceResult> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EnigmaWrapper.CzmServiceResult>();

        protected bool __ownsNativeInstance;

        internal static CzmServiceResult __CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new CzmServiceResult(native.ToPointer(), skipVTables);
        }

        internal static CzmServiceResult __GetOrCreateInstance(IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CzmServiceResult)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static CzmServiceResult __CreateInstance(Internal native, bool skipVTables = false)
        {
            return new CzmServiceResult(native, skipVTables);
        }

        private static void* __CopyValue(Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Internal));
            *(Internal*)ret = native;
            return ret.ToPointer();
        }

        private CzmServiceResult(Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CzmServiceResult(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new IntPtr(native);
        }

        public CzmServiceResult()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EnigmaWrapper.CzmServiceResult.Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CzmServiceResult(global::EnigmaWrapper.CzmServiceResult _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EnigmaWrapper.CzmServiceResult.Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::EnigmaWrapper.CzmServiceResult.Internal*)__Instance) = *((global::EnigmaWrapper.CzmServiceResult.Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>optional arguments</summary>
        public IntPtr Args
        {
            get
            {
                return ((Internal*)__Instance)->args;
            }

            set
            {
                ((Internal*)__Instance)->args = (IntPtr)value;
            }
        }

        /// <summary>callback function to invoke</summary>
        public global::EnigmaWrapper.Delegates.Action_IntPtr_EnigmaWrapper_CzmError_IntPtr_ulong_long_long Notify
        {
            get
            {
                var __ptr0 = ((Internal*)__Instance)->notify;
                return __ptr0 == IntPtr.Zero ? null : (global::EnigmaWrapper.Delegates.Action_IntPtr_EnigmaWrapper_CzmError_IntPtr_ulong_long_long)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::EnigmaWrapper.Delegates.Action_IntPtr_EnigmaWrapper_CzmError_IntPtr_ulong_long_long));
            }

            set
            {
                ((Internal*)__Instance)->notify = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }
    }
}
