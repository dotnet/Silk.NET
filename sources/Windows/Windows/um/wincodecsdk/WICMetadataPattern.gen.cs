// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICMetadataPattern.xml' path='doc/member[@name="WICMetadataPattern"]/*' />
public unsafe partial struct WICMetadataPattern
{
    /// <include file='WICMetadataPattern.xml' path='doc/member[@name="WICMetadataPattern.Position"]/*' />
    public ULARGE_INTEGER Position;

    /// <include file='WICMetadataPattern.xml' path='doc/member[@name="WICMetadataPattern.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='WICMetadataPattern.xml' path='doc/member[@name="WICMetadataPattern.Pattern"]/*' />
    public byte* Pattern;

    /// <include file='WICMetadataPattern.xml' path='doc/member[@name="WICMetadataPattern.Mask"]/*' />
    public byte* Mask;

    /// <include file='WICMetadataPattern.xml' path='doc/member[@name="WICMetadataPattern.DataOffset"]/*' />
    public ULARGE_INTEGER DataOffset;
}
