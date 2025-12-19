// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MSE_ERROR")]
    public enum MseError : int
    {
        [NativeName("Name", "MF_MSE_ERROR_NOERROR")]
        Noerror = 0x0,
        [NativeName("Name", "MF_MSE_ERROR_NETWORK")]
        Network = 0x1,
        [NativeName("Name", "MF_MSE_ERROR_DECODE")]
        Decode = 0x2,
        [NativeName("Name", "MF_MSE_ERROR_UNKNOWN_ERROR")]
        UnknownError = 0x3,
    }
}
