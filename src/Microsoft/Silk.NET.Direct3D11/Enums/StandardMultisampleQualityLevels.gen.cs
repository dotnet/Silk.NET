// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_STANDARD_MULTISAMPLE_QUALITY_LEVELS")]
    public enum StandardMultisampleQualityLevels : int
    {
        [NativeName("Name", "D3D11_STANDARD_MULTISAMPLE_PATTERN")]
        StandardMultisamplePattern = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3D11_CENTER_MULTISAMPLE_PATTERN")]
        CenterMultisamplePattern = unchecked((int) 0xFFFFFFFFFFFFFFFE),
    }
}
