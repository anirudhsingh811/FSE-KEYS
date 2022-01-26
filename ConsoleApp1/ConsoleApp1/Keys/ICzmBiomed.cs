using EnigmaWrapper.Delegates;
using System;

namespace EnigmaWrapper
{
    public interface ICzmBiomed
    {
        IntPtr Instance { get; }
        CzmBiomedResult Result { get; set; }

        void Dispose();
    }
    public interface ICzmBiomedResult
    {
        IntPtr Args { get; set; }
        IntPtr Instance { get; }
        Action_IntPtr_EnigmaWrapper_CzmError Notify { get; set; }
        Action_IntPtr_EnigmaWrapper_CzmError_long NotifyV2 { get; set; }

        void Dispose();
    }
}