// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_result")]
    public enum Result : int
    {
        [NativeName("Name", "SPVC_SUCCESS")]
        Success = 0x0,
        [NativeName("Name", "SPVC_ERROR_INVALID_SPIRV")]
        ErrorInvalidSpirv = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SPVC_ERROR_UNSUPPORTED_SPIRV")]
        ErrorUnsupportedSpirv = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "SPVC_ERROR_OUT_OF_MEMORY")]
        ErrorOutOfMemory = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "SPVC_ERROR_INVALID_ARGUMENT")]
        ErrorInvalidArgument = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "SPVC_ERROR_INT_MAX")]
        ErrorIntMax = 0x7FFFFFFF,
    }
}
