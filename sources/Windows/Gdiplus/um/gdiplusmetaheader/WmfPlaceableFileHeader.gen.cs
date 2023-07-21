// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus;

/// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct WmfPlaceableFileHeader
{
    /// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader.Key"]/*' />
    [NativeTypeName("UINT32")]
    public uint Key;

    /// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader.Hmf"]/*' />
    [NativeTypeName("INT16")]
    public short Hmf;

    /// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader.BoundingBox"]/*' />
    [NativeTypeName("Gdiplus::PWMFRect16")]
    public PWMFRect16 BoundingBox;

    /// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader.Inch"]/*' />
    [NativeTypeName("INT16")]
    public short Inch;

    /// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader.Reserved"]/*' />
    [NativeTypeName("UINT32")]
    public uint Reserved;

    /// <include file='WmfPlaceableFileHeader.xml' path='doc/member[@name="WmfPlaceableFileHeader.Checksum"]/*' />
    [NativeTypeName("INT16")]
    public short Checksum;
}
