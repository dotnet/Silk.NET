// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUCompilationMessageType")]
    public enum CompilationMessageType : int
    {
        [NativeName("Name", "WGPUCompilationMessageType_Error")]
        Error = 0x0,
        [NativeName("Name", "WGPUCompilationMessageType_Warning")]
        Warning = 0x1,
        [NativeName("Name", "WGPUCompilationMessageType_Info")]
        Info = 0x2,
        [NativeName("Name", "WGPUCompilationMessageType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
