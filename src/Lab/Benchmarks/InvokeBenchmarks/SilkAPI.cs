// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace InvokeBenchmarks
{
    public sealed partial class SilkAPI : NativeApiContainer
    {
        public SilkAPI(INativeContext ctx) : base(ctx) { }

        [NativeApi(EntryPoint = "Test1")]
        public partial void RawInvoke();
        [NativeApi(EntryPoint = "Test2")]
        public partial int WithReturn();
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPStrMarshal([UnmanagedType(UnmanagedType.LPStr)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPTStrMarshal([UnmanagedType(UnmanagedType.LPTStr)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPUTF8StrMarshal([UnmanagedType(UnmanagedType.LPUTF8Str)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPWStrMarshal([UnmanagedType(UnmanagedType.LPWStr)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndBStrMarshal([UnmanagedType(UnmanagedType.BStr)] string s);
        [NativeApi(EntryPoint = "Test5")]
        public partial int WithReturnAndSpanMarshal(Span<byte> span);
        [NativeApi(EntryPoint = "Test6")]
        public partial int WithReturnAndVariantBoolMarshal([UnmanagedType(UnmanagedType.VariantBool)] bool b);
        [NativeApi(EntryPoint = "Test7")]
        public partial int WithReturnAndSystemBoolMarshal([UnmanagedType(UnmanagedType.Bool)] bool b);
        [NativeApi(EntryPoint = "Test6")]
        public partial int WithReturnAndU2BoolMarshal([UnmanagedType(UnmanagedType.U2)] bool b);
        [NativeApi(EntryPoint = "Test7")]
        public partial int WithReturnAndU4BoolMarshal([UnmanagedType(UnmanagedType.U4)] bool b);
        [NativeApi(EntryPoint = "Test6")]
        public partial int WithReturnAndI2BoolMarshal([UnmanagedType(UnmanagedType.I2)] bool b);
        [NativeApi(EntryPoint = "Test7")]
        public partial int WithReturnAndI4BoolMarshal([UnmanagedType(UnmanagedType.I4)] bool b);
    }
}
