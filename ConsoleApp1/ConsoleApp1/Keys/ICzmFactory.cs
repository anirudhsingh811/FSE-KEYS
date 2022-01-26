using EnigmaWrapper.Delegates;
using System;

namespace EnigmaWrapper
{
    public interface ICzmFactory
    {
        IntPtr Instance { get; }
        CzmFactoryResult Result { get; set; }

        void Dispose();
    }
    public interface ICzmFactoryResult
    {
        IntPtr Args { get; set; }
        IntPtr Instance { get; }
        Action_IntPtr_EnigmaWrapper_CzmError Notify { get; set; }
        Action_IntPtr_EnigmaWrapper_CzmError_long_long NotifyV2 { get; set; }

        void Dispose();
    }
}