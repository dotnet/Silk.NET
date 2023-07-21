// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT"]/*' />
public partial struct COLORADJUSTMENT
{
    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caSize"]/*' />
    [NativeTypeName("WORD")]
    public ushort caSize;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort caFlags;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caIlluminantIndex"]/*' />
    [NativeTypeName("WORD")]
    public ushort caIlluminantIndex;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caRedGamma"]/*' />
    [NativeTypeName("WORD")]
    public ushort caRedGamma;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caGreenGamma"]/*' />
    [NativeTypeName("WORD")]
    public ushort caGreenGamma;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caBlueGamma"]/*' />
    [NativeTypeName("WORD")]
    public ushort caBlueGamma;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caReferenceBlack"]/*' />
    [NativeTypeName("WORD")]
    public ushort caReferenceBlack;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caReferenceWhite"]/*' />
    [NativeTypeName("WORD")]
    public ushort caReferenceWhite;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caContrast"]/*' />
    public short caContrast;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caBrightness"]/*' />
    public short caBrightness;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caColorfulness"]/*' />
    public short caColorfulness;

    /// <include file='COLORADJUSTMENT.xml' path='doc/member[@name="COLORADJUSTMENT.caRedGreenTint"]/*' />
    public short caRedGreenTint;
}
