// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUCompilationMessageType")]
    public enum CompilationMessageType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "WGPUCompilationMessageType_Error")]
        CompilationMessageTypeError = 0x0,
        [Obsolete("Deprecated in favour of \"Warning\"")]
        [NativeName("Name", "WGPUCompilationMessageType_Warning")]
        CompilationMessageTypeWarning = 0x1,
        [Obsolete("Deprecated in favour of \"Info\"")]
        [NativeName("Name", "WGPUCompilationMessageType_Info")]
        CompilationMessageTypeInfo = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUCompilationMessageType_Force32")]
        CompilationMessageTypeForce32 = 0x7FFFFFFF,
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
