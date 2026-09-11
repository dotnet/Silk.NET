// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MSE_APPEND_MODE")]
    public enum MseAppendMode : int
    {
        [NativeName("Name", "MF_MSE_APPEND_MODE_SEGMENTS")]
        Segments = 0x0,
        [NativeName("Name", "MF_MSE_APPEND_MODE_SEQUENCE")]
        Sequence = 0x1,
    }
}
