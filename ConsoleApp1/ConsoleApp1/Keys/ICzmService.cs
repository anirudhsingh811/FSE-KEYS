using EnigmaWrapper.Delegates;
using System;

namespace EnigmaWrapper
{
    public interface ICzmService
    {
        IntPtr __Instance { get; }
        CzmServiceResult Result { get; set; }

        void Dispose();
    }
    public interface ICzmServiceResult
    {
        IntPtr __Instance { get; }
        IntPtr Args { get; set; }
        Action_IntPtr_EnigmaWrapper_CzmError_IntPtr_ulong_long_long Notify { get; set; }

        void Dispose();
    }
}