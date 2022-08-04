// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    [Flags]
    [NativeName("Name", "COMPOSITION_FRAME_ID_TYPE")]
    public enum CompositionFrameIDType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Created\"")]
        [NativeName("Name", "COMPOSITION_FRAME_ID_CREATED")]
        CompositionFrameIDCreated = 0x0,
        [Obsolete("Deprecated in favour of \"Confirmed\"")]
        [NativeName("Name", "COMPOSITION_FRAME_ID_CONFIRMED")]
        CompositionFrameIDConfirmed = 0x1,
        [Obsolete("Deprecated in favour of \"Completed\"")]
        [NativeName("Name", "COMPOSITION_FRAME_ID_COMPLETED")]
        CompositionFrameIDCompleted = 0x2,
        [NativeName("Name", "COMPOSITION_FRAME_ID_CREATED")]
        Created = 0x0,
        [NativeName("Name", "COMPOSITION_FRAME_ID_CONFIRMED")]
        Confirmed = 0x1,
        [NativeName("Name", "COMPOSITION_FRAME_ID_COMPLETED")]
        Completed = 0x2,
    }
}
