// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_REGION.xml' path='doc/member[@name="DVD_REGION"]/*' />
public partial struct DVD_REGION
{
    /// <include file='DVD_REGION.xml' path='doc/member[@name="DVD_REGION.CopySystem"]/*' />
    [NativeTypeName("UCHAR")]
    public byte CopySystem;

    /// <include file='DVD_REGION.xml' path='doc/member[@name="DVD_REGION.RegionData"]/*' />
    [NativeTypeName("UCHAR")]
    public byte RegionData;

    /// <include file='DVD_REGION.xml' path='doc/member[@name="DVD_REGION.SystemRegion"]/*' />
    [NativeTypeName("UCHAR")]
    public byte SystemRegion;

    /// <include file='DVD_REGION.xml' path='doc/member[@name="DVD_REGION.ResetCount"]/*' />
    [NativeTypeName("UCHAR")]
    public byte ResetCount;
}
