// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [Flags]
    [NativeName("Name", "XrDigitalLensControlFlagsALMALENCE")]
    public enum DigitalLensControlFlagsALMALENCE : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ProcessingDisableBitAlmalence\"")]
        [NativeName("Name", "XR_DIGITAL_LENS_CONTROL_PROCESSING_DISABLE_BIT_ALMALENCE")]
        DigitalLensControlProcessingDisableBitAlmalence = 1,
        [NativeName("Name", "XR_DIGITAL_LENS_CONTROL_PROCESSING_DISABLE_BIT_ALMALENCE")]
        ProcessingDisableBitAlmalence = 1,
    }
}
