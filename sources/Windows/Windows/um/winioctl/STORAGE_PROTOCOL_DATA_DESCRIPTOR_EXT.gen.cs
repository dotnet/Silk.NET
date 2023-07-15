// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT"]/*'/>
public partial struct STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT
{
    /// <include file='STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_DATA_DESCRIPTOR_EXT.ProtocolSpecificData"]/*'/>
    public STORAGE_PROTOCOL_SPECIFIC_DATA_EXT ProtocolSpecificData;
}