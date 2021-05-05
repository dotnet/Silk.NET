// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using UnmanagedType = System.Runtime.InteropServices.UnmanagedType;

namespace InvokeBenchmarks
{
    public sealed partial class RawAPI : NativeApiContainer
    {
        public RawAPI(INativeContext ctx) : base(ctx) { }

        [NativeApi(EntryPoint = "Test1")]
        public partial void RawInvoke();
            
        [NativeApi(EntryPoint = "Test2")]
        public partial int WithReturn();

        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPStrMarshal([MarshalAs(UnmanagedType.LPStr)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPTStrMarshal([MarshalAs(UnmanagedType.LPTStr)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPUTF8StrMarshal([MarshalAs(UnmanagedType.LPUTF8Str)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndLPWStrMarshal([MarshalAs(UnmanagedType.LPWStr)] string s);
        [NativeApi(EntryPoint = "Test3")]
        public partial int WithReturnAndBStrMarshal([MarshalAs(UnmanagedType.BStr)] string s);

        [NativeApi(EntryPoint = "Test5")]
        public partial int WithReturnAndSpanMarshal(Span<byte> span);

        [NativeApi(EntryPoint = "Test6")]
        public partial int WithReturnAndBoolMarshal([MarshalAs(UnmanagedType.VariantBool)] bool b);
    }
}
