// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace SumExample
{
    [NativeApi(Convention = CallingConvention.Cdecl)]
    unsafe partial class SumAPI : NativeApiContainer
    {
        public static SumAPI GetApi()
        {
            return new(CreateDefaultContext(new SumAPINameContainer().GetLibraryName()));
        }
        
        public SumAPI(INativeContext ctx) : base(ctx) { }
        
        [NativeApi(EntryPoint = "sum")]
        public partial int Sum(int length, int* values);
        
        [NativeApi(EntryPoint = "sum")]
        public partial int Sum(int length, Span<int> values);
    }
}
