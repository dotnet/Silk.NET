// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiPropertyTypeInfo")]
    public enum PropertyTypeInfo : int
    {
        [NativeName("Name", "aiPTI_Float")]
        PtiFloat = 0x1,
        [NativeName("Name", "aiPTI_Double")]
        PtiDouble = 0x2,
        [NativeName("Name", "aiPTI_String")]
        PtiString = 0x3,
        [NativeName("Name", "aiPTI_Integer")]
        PtiInteger = 0x4,
        [NativeName("Name", "aiPTI_Buffer")]
        PtiBuffer = 0x5,
    }
}
