// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_ERROR_CODE")]
    public enum TimedTextErrorCode : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_ERROR_CODE_NOERROR")]
        Noerror = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_ERROR_CODE_FATAL")]
        Fatal = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_ERROR_CODE_DATA_FORMAT")]
        DataFormat = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_ERROR_CODE_NETWORK")]
        Network = 0x3,
        [NativeName("Name", "MF_TIMED_TEXT_ERROR_CODE_INTERNAL")]
        Internal = 0x4,
    }
}
