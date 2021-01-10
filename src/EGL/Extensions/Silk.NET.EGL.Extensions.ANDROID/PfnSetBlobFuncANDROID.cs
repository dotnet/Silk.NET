// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Native;

namespace Silk.NET.EGL.Extensions.ANDROID
{
    public readonly unsafe struct PfnSetBlobFuncANDROID
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<void*, int, void*, int, void> Handle =>
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, void>) _handle;

        public PfnSetBlobFuncANDROID
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, void> ptr) => _handle = ptr;

        public static implicit operator nint(PfnSetBlobFuncANDROID pfn) => (nint) pfn.Handle;

        public PfnSetBlobFuncANDROID
            (SetBlobFuncANDROID func) => _handle =
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, void>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, int, void*, int, void>
            (PfnSetBlobFuncANDROID pfn) => pfn.Handle;

        public static implicit operator PfnSetBlobFuncANDROID
            (delegate* unmanaged[Cdecl]<void*, int, void*, int, void> func) => new(func);

        public static implicit operator PfnSetBlobFuncANDROID(SetBlobFuncANDROID func) => new(func);

        public static explicit operator SetBlobFuncANDROID
            (PfnSetBlobFuncANDROID pfn) => SilkMarshal.PtrToDelegate<SetBlobFuncANDROID>((nint) pfn.Handle);
    }
    
    public unsafe delegate void SetBlobFuncANDROID(
        void* key,
        int keySize,
        void* value,
        int valueSize);
}
