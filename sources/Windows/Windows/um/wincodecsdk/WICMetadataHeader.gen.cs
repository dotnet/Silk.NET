// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WICMetadataHeader.xml' path='doc/member[@name="WICMetadataHeader"]/*'/>
public unsafe partial struct WICMetadataHeader
{
    /// <include file='WICMetadataHeader.xml' path='doc/member[@name="WICMetadataHeader.Position"]/*'/>
    public ULARGE_INTEGER Position;
    /// <include file='WICMetadataHeader.xml' path='doc/member[@name="WICMetadataHeader.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='WICMetadataHeader.xml' path='doc/member[@name="WICMetadataHeader.Header"]/*'/>
    public byte* Header;
    /// <include file='WICMetadataHeader.xml' path='doc/member[@name="WICMetadataHeader.DataOffset"]/*'/>
    public ULARGE_INTEGER DataOffset;
}