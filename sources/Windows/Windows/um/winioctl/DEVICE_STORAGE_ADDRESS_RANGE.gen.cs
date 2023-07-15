// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_STORAGE_ADDRESS_RANGE.xml' path='doc/member[@name="DEVICE_STORAGE_ADDRESS_RANGE"]/*'/>
public partial struct DEVICE_STORAGE_ADDRESS_RANGE
{
    /// <include file='DEVICE_STORAGE_ADDRESS_RANGE.xml' path='doc/member[@name="DEVICE_STORAGE_ADDRESS_RANGE.StartAddress"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long StartAddress;
    /// <include file='DEVICE_STORAGE_ADDRESS_RANGE.xml' path='doc/member[@name="DEVICE_STORAGE_ADDRESS_RANGE.LengthInBytes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LengthInBytes;
}