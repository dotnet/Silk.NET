// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Native;

namespace Silk.NET.EGL.Extensions.ANDROID
{
    public readonly unsafe struct PfnGetBlobFuncANDROID
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<int, int, void*, int, int> Handle =>
            (delegate* unmanaged[Cdecl]<int, int, void*, int, int>) _handle;

        public PfnGetBlobFuncANDROID
            (delegate* unmanaged[Cdecl]<int, int, void*, int, int> ptr) => _handle = ptr;

        public static implicit operator nint(PfnGetBlobFuncANDROID pfn) => (nint) pfn.Handle;

        public PfnGetBlobFuncANDROID
            (GetBlobFuncANDROID func) => _handle =
            (delegate* unmanaged[Cdecl]<int, int, void*, int, int>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<int, int, void*, int, int>
            (PfnGetBlobFuncANDROID pfn) => pfn.Handle;

        public static implicit operator PfnGetBlobFuncANDROID
            (delegate* unmanaged[Cdecl]<int, int, void*, int, int> func) => new(func);

        public static implicit operator PfnGetBlobFuncANDROID(GetBlobFuncANDROID func) => new(func);

        public static explicit operator GetBlobFuncANDROID
            (PfnGetBlobFuncANDROID pfn) => SilkMarshal.PtrToDelegate<GetBlobFuncANDROID>((nint) pfn.Handle);
    }
    
    public unsafe delegate int GetBlobFuncANDROID(
        void* key,
        int keySize,
        void* value,
        int valueSize);
}
