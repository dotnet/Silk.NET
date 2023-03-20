// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_NUMBER_SUBSTITUTION_METHOD")]
    public enum NumberSubstitutionMethod : int
    {
        [NativeName("Name", "DWRITE_NUMBER_SUBSTITUTION_METHOD_FROM_CULTURE")]
        FromCulture = 0x0,
        [NativeName("Name", "DWRITE_NUMBER_SUBSTITUTION_METHOD_CONTEXTUAL")]
        Contextual = 0x1,
        [NativeName("Name", "DWRITE_NUMBER_SUBSTITUTION_METHOD_NONE")]
        None = 0x2,
        [NativeName("Name", "DWRITE_NUMBER_SUBSTITUTION_METHOD_NATIONAL")]
        National = 0x3,
        [NativeName("Name", "DWRITE_NUMBER_SUBSTITUTION_METHOD_TRADITIONAL")]
        Traditional = 0x4,
    }
}
