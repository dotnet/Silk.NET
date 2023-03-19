// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUErrorType")]
    public enum ErrorType : int
    {
        [NativeName("Name", "WGPUErrorType_NoError")]
        NoError = 0x0,
        [NativeName("Name", "WGPUErrorType_Validation")]
        Validation = 0x1,
        [NativeName("Name", "WGPUErrorType_OutOfMemory")]
        OutOfMemory = 0x2,
        [NativeName("Name", "WGPUErrorType_Internal")]
        Internal = 0x3,
        [NativeName("Name", "WGPUErrorType_Unknown")]
        Unknown = 0x4,
        [NativeName("Name", "WGPUErrorType_DeviceLost")]
        DeviceLost = 0x5,
        [NativeName("Name", "WGPUErrorType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
