// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoCompressedInfo.xml' path='doc/member[@name="MFVideoCompressedInfo"]/*' />
public partial struct MFVideoCompressedInfo
{
    /// <include file='MFVideoCompressedInfo.xml' path='doc/member[@name="MFVideoCompressedInfo.AvgBitrate"]/*' />
    [NativeTypeName("LONGLONG")]
    public long AvgBitrate;

    /// <include file='MFVideoCompressedInfo.xml' path='doc/member[@name="MFVideoCompressedInfo.AvgBitErrorRate"]/*' />
    [NativeTypeName("LONGLONG")]
    public long AvgBitErrorRate;

    /// <include file='MFVideoCompressedInfo.xml' path='doc/member[@name="MFVideoCompressedInfo.MaxKeyFrameSpacing"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxKeyFrameSpacing;
}
