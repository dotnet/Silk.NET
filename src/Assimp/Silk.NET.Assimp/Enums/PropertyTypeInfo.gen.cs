// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiPropertyTypeInfo")]
    public enum PropertyTypeInfo : int
    {
        [Obsolete("Deprecated in favour of \"Float\"")]
        [NativeName("Name", "aiPTI_Float")]
        PtiFloat = 0x1,
        [Obsolete("Deprecated in favour of \"Double\"")]
        [NativeName("Name", "aiPTI_Double")]
        PtiDouble = 0x2,
        [Obsolete("Deprecated in favour of \"String\"")]
        [NativeName("Name", "aiPTI_String")]
        PtiString = 0x3,
        [Obsolete("Deprecated in favour of \"Integer\"")]
        [NativeName("Name", "aiPTI_Integer")]
        PtiInteger = 0x4,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "aiPTI_Buffer")]
        PtiBuffer = 0x5,
        [NativeName("Name", "aiPTI_Float")]
        Float = 0x1,
        [NativeName("Name", "aiPTI_Double")]
        Double = 0x2,
        [NativeName("Name", "aiPTI_String")]
        String = 0x3,
        [NativeName("Name", "aiPTI_Integer")]
        Integer = 0x4,
        [NativeName("Name", "aiPTI_Buffer")]
        Buffer = 0x5,
    }
}
