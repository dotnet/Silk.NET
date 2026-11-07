// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MSE_READY")]
    public enum MseReady : int
    {
        [NativeName("Name", "MF_MSE_READY_CLOSED")]
        Closed = 0x1,
        [NativeName("Name", "MF_MSE_READY_OPEN")]
        Open = 0x2,
        [NativeName("Name", "MF_MSE_READY_ENDED")]
        Ended = 0x3,
    }
}
