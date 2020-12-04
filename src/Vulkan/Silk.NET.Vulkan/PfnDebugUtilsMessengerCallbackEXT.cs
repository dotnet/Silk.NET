using System;
using Silk.NET.Core;
using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public readonly unsafe struct PfnDebugUtilsMessengerCallbackEXT
    {
        public readonly delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
            DebugUtilsMessengerCallbackDataEXT*, void*, Bool32> Handle;

        public PfnDebugUtilsMessengerCallbackEXT
        (
            delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32> ptr
        ) => Handle = ptr;

        public static implicit operator IntPtr(PfnDebugUtilsMessengerCallbackEXT pfn) => (IntPtr) pfn.Handle;

        public PfnDebugUtilsMessengerCallbackEXT(DebugUtilsMessengerCallbackFunctionEXT func) => Handle =
            (delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32>) SilkMarshal.DelegateToPtr(func);

        public static implicit operator delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT,
            DebugUtilsMessageTypeFlagsEXT, DebugUtilsMessengerCallbackDataEXT*, void*, Bool32>
            (PfnDebugUtilsMessengerCallbackEXT pfn) => pfn.Handle;

        public static implicit operator PfnDebugUtilsMessengerCallbackEXT
        (
            delegate* unmanaged[Cdecl]<DebugUtilsMessageSeverityFlagsEXT, DebugUtilsMessageTypeFlagsEXT,
                DebugUtilsMessengerCallbackDataEXT*, void*, Bool32> func
        ) => new(func);

        public static implicit operator PfnDebugUtilsMessengerCallbackEXT
            (DebugUtilsMessengerCallbackFunctionEXT func) => new(func);

        public static explicit operator DebugUtilsMessengerCallbackFunctionEXT
            (PfnDebugUtilsMessengerCallbackEXT pfn) => SilkMarshal.PtrToDelegate<DebugUtilsMessengerCallbackFunctionEXT>
            ((IntPtr) pfn.Handle);
    }
}