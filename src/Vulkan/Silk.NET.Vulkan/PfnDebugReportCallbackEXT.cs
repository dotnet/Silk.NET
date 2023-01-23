using System;
using Silk.NET.Core;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnDebugReportCallbackEXT : IDisposable
    {
        private readonly void* _handle;

        public delegate* unmanaged[Cdecl]<DebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, nuint, int,
            byte*, byte*, void*, Bool32> Handle =>
            (delegate* unmanaged[Cdecl]<DebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, nuint, int,
                byte*, byte*, void*, Bool32>) _handle;

        public PfnDebugReportCallbackEXT
        (
            delegate* unmanaged[Cdecl]<DebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*,
                void*, Bool32> ptr
        ) => _handle = ptr;

        public void Dispose() => SilkMarshal.Free((nint) _handle);
        public static implicit operator nint(PfnDebugReportCallbackEXT pfn) => (nint) pfn.Handle;

        public PfnDebugReportCallbackEXT
            (DebugReportCallbackFunctionEXT func) => _handle =
            (delegate* unmanaged[Cdecl]<DebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*,
                void*, Bool32>) SilkMarshal.DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<DebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong,
            nuint, int, byte*, byte*, void*, Bool32>(PfnDebugReportCallbackEXT pfn) => pfn.Handle;

        public static implicit operator PfnDebugReportCallbackEXT
        (
            delegate* unmanaged[Cdecl]<DebugReportFlagsEXT, DebugReportObjectTypeEXT, ulong, nuint, int, byte*, byte*,
                void*, Bool32> func
        ) => new(func);

        public static implicit operator PfnDebugReportCallbackEXT(DebugReportCallbackFunctionEXT func) => new(func);

        public static explicit operator DebugReportCallbackFunctionEXT
            (PfnDebugReportCallbackEXT pfn) => SilkMarshal.PtrToDelegate<DebugReportCallbackFunctionEXT>
            ((nint) pfn.Handle);
    }
}
