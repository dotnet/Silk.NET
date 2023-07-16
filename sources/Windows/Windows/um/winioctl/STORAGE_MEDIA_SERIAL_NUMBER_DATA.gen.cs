// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_MEDIA_SERIAL_NUMBER_DATA.xml' path='doc/member[@name="STORAGE_MEDIA_SERIAL_NUMBER_DATA"]/*'/>
public unsafe partial struct STORAGE_MEDIA_SERIAL_NUMBER_DATA
{
    /// <include file='STORAGE_MEDIA_SERIAL_NUMBER_DATA.xml' path='doc/member[@name="STORAGE_MEDIA_SERIAL_NUMBER_DATA.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='STORAGE_MEDIA_SERIAL_NUMBER_DATA.xml' path='doc/member[@name="STORAGE_MEDIA_SERIAL_NUMBER_DATA.SerialNumberLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort SerialNumberLength;
    /// <include file='STORAGE_MEDIA_SERIAL_NUMBER_DATA.xml' path='doc/member[@name="STORAGE_MEDIA_SERIAL_NUMBER_DATA.SerialNumber"]/*'/>
    [NativeTypeName("BYTE[0]")]
    public fixed byte SerialNumber[1];
}