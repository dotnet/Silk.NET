// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCOMPOSERECTSOP")]
    public enum Composerectsop : int
    {
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "D3DCOMPOSERECTS_COPY")]
        ComposerectsCopy = 0x1,
        [Obsolete("Deprecated in favour of \"Or\"")]
        [NativeName("Name", "D3DCOMPOSERECTS_OR")]
        ComposerectsOr = 0x2,
        [Obsolete("Deprecated in favour of \"And\"")]
        [NativeName("Name", "D3DCOMPOSERECTS_AND")]
        ComposerectsAnd = 0x3,
        [Obsolete("Deprecated in favour of \"Neg\"")]
        [NativeName("Name", "D3DCOMPOSERECTS_NEG")]
        ComposerectsNeg = 0x4,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DCOMPOSERECTS_FORCE_DWORD")]
        ComposerectsForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DCOMPOSERECTS_COPY")]
        Copy = 0x1,
        [NativeName("Name", "D3DCOMPOSERECTS_OR")]
        Or = 0x2,
        [NativeName("Name", "D3DCOMPOSERECTS_AND")]
        And = 0x3,
        [NativeName("Name", "D3DCOMPOSERECTS_NEG")]
        Neg = 0x4,
        [NativeName("Name", "D3DCOMPOSERECTS_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
