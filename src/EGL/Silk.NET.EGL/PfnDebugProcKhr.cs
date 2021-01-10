// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Native;

namespace Silk.NET.EGL
{
    public readonly unsafe struct PfnDebugProcKhr
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int> Handle =>
            (delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int>) _handle;

        public PfnDebugProcKhr
            (delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int> ptr) => _handle = ptr;

        public static implicit operator nint(PfnDebugProcKhr pfn) => (nint) pfn.Handle;

        public PfnDebugProcKhr
            (DebugProcKhr func) => _handle =
            (delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int>) SilkMarshal.DelegateToPtr
                (func);

        public static implicit operator delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int>
            (PfnDebugProcKhr pfn) => pfn.Handle;

        public static implicit operator PfnDebugProcKhr
            (delegate* unmanaged[Cdecl]<EGLEnum, byte*, int, nint, nint, byte*, int> func) => new(func);

        public static implicit operator PfnDebugProcKhr(DebugProcKhr func) => new(func);

        public static explicit operator DebugProcKhr
            (PfnDebugProcKhr pfn) => SilkMarshal.PtrToDelegate<DebugProcKhr>((nint) pfn.Handle);
    }
    
    public unsafe delegate int DebugProcKhr(
        EGLEnum error,
        byte* command,
        int messageType,
        nint threadLabel,
        nint objectLabel,
        byte* message);
}
