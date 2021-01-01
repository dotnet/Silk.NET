// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCOMPOSERECTSOP")]
    public enum Composerectsop : int
    {
        [NativeName("Name", "D3DCOMPOSERECTS_COPY")]
        ComposerectsCopy = 0x1,
        [NativeName("Name", "D3DCOMPOSERECTS_OR")]
        ComposerectsOr = 0x2,
        [NativeName("Name", "D3DCOMPOSERECTS_AND")]
        ComposerectsAnd = 0x3,
        [NativeName("Name", "D3DCOMPOSERECTS_NEG")]
        ComposerectsNeg = 0x4,
        [NativeName("Name", "D3DCOMPOSERECTS_FORCE_DWORD")]
        ComposerectsForceDword = 0x7FFFFFFF,
    }
}
