// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "COMPOSITION_FRAME_ID_TYPE")]
    public enum CompositionFrameIDType : int
    {
        [NativeName("Name", "COMPOSITION_FRAME_ID_CREATED")]
        Created = 0x0,
        [NativeName("Name", "COMPOSITION_FRAME_ID_CONFIRMED")]
        Confirmed = 0x1,
        [NativeName("Name", "COMPOSITION_FRAME_ID_COMPLETED")]
        Completed = 0x2,
    }
}
