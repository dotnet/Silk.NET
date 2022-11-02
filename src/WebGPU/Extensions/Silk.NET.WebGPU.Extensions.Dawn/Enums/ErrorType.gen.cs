// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [Flags]
    [NativeName("Name", "WGPUErrorType")]
    public enum ErrorType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NoError\"")]
        [NativeName("Name", "WGPUErrorType_NoError")]
        ErrorTypeNoError = 0x0,
        [Obsolete("Deprecated in favour of \"Validation\"")]
        [NativeName("Name", "WGPUErrorType_Validation")]
        ErrorTypeValidation = 0x1,
        [Obsolete("Deprecated in favour of \"OutOfMemory\"")]
        [NativeName("Name", "WGPUErrorType_OutOfMemory")]
        ErrorTypeOutOfMemory = 0x2,
        [Obsolete("Deprecated in favour of \"Internal\"")]
        [NativeName("Name", "WGPUErrorType_Internal")]
        ErrorTypeInternal = 0x3,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "WGPUErrorType_Unknown")]
        ErrorTypeUnknown = 0x4,
        [Obsolete("Deprecated in favour of \"DeviceLost\"")]
        [NativeName("Name", "WGPUErrorType_DeviceLost")]
        ErrorTypeDeviceLost = 0x5,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUErrorType_Force32")]
        ErrorTypeForce32 = 0x7FFFFFFF,
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
