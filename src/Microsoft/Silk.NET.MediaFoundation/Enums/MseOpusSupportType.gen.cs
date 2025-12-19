// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MSE_OPUS_SUPPORT_TYPE")]
    public enum MseOpusSupportType : int
    {
        [NativeName("Name", "MF_MSE_OPUS_SUPPORT_ON")]
        On = 0x0,
        [NativeName("Name", "MF_MSE_OPUS_SUPPORT_OFF")]
        Off = 0x1,
    }
}
