// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPixelFormatNumericRepresentation")]
    public enum PixelFormatNumericRepresentation : int
    {
        [NativeName("Name", "WICPixelFormatNumericRepresentationUnspecified")]
        Unspecified = 0x0,
        [NativeName("Name", "WICPixelFormatNumericRepresentationIndexed")]
        Indexed = 0x1,
        [NativeName("Name", "WICPixelFormatNumericRepresentationUnsignedInteger")]
        UnsignedInteger = 0x2,
        [NativeName("Name", "WICPixelFormatNumericRepresentationSignedInteger")]
        SignedInteger = 0x3,
        [NativeName("Name", "WICPixelFormatNumericRepresentationFixed")]
        Fixed = 0x4,
        [NativeName("Name", "WICPixelFormatNumericRepresentationFloat")]
        Float = 0x5,
        [NativeName("Name", "WICPixelFormatNumericRepresentation_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
