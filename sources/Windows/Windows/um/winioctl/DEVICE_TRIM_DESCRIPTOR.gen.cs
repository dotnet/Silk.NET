// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_TRIM_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_TRIM_DESCRIPTOR"]/*'/>
public partial struct DEVICE_TRIM_DESCRIPTOR
{
    /// <include file='DEVICE_TRIM_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_TRIM_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_TRIM_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_TRIM_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_TRIM_DESCRIPTOR.xml' path='doc/member[@name="DEVICE_TRIM_DESCRIPTOR.TrimEnabled"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte TrimEnabled;
}