// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_RATIONAL.xml' path='doc/member[@name="DISPLAYCONFIG_RATIONAL"]/*' />
public partial struct DISPLAYCONFIG_RATIONAL
{
    /// <include file='DISPLAYCONFIG_RATIONAL.xml' path='doc/member[@name="DISPLAYCONFIG_RATIONAL.Numerator"]/*' />
    [NativeTypeName("UINT32")]
    public uint Numerator;

    /// <include file='DISPLAYCONFIG_RATIONAL.xml' path='doc/member[@name="DISPLAYCONFIG_RATIONAL.Denominator"]/*' />
    [NativeTypeName("UINT32")]
    public uint Denominator;
}
