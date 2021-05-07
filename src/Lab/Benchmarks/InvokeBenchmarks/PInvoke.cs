// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace InvokeBenchmarks
{
    public static class PInvoke
    {
        const string Library = "TestLib.dll";
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test1")]
        public static extern void RawInvoke();
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test2")]
        public static extern int WithReturn();
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test3")]
        public static extern int WithReturnAndLPStrMarshal([MarshalAs(UnmanagedType.LPStr)] string s);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test3")]
        public static extern int WithReturnAndLPTStrMarshal([MarshalAs(UnmanagedType.LPTStr)] string s);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test3")]
        public static extern int WithReturnAndLPUTF8StrMarshal([MarshalAs(UnmanagedType.LPUTF8Str)] string s);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test3")]
        public static extern int WithReturnAndLPWStrMarshal([MarshalAs(UnmanagedType.LPWStr)] string s);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test3")]
        public static extern int WithReturnAndBStrMarshal([MarshalAs(UnmanagedType.BStr)] string s);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test5")]
        public static extern int WithReturnAndSpanMarshal(Span<byte> span);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test6")]
        public static extern int WithReturnAndVariantBoolMarshal([MarshalAs(UnmanagedType.VariantBool)] bool b);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test7")]
        public static extern int WithReturnAndSystemBoolMarshal([MarshalAs(UnmanagedType.Bool)] bool b);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test6")]
        public static extern int WithReturnAndU2BoolMarshal([MarshalAs(UnmanagedType.U2)] bool b);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test7")]
        public static extern int WithReturnAndU4BoolMarshal([MarshalAs(UnmanagedType.U4)] bool b);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test6")]
        public static extern int WithReturnAndI2BoolMarshal([MarshalAs(UnmanagedType.I2)] bool b);
        [DllImport(Library, CallingConvention = CallingConvention.Cdecl, EntryPoint = "Test7")]
        public static extern int WithReturnAndI4BoolMarshal([MarshalAs(UnmanagedType.I4)] bool b);
    }
}
