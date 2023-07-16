// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_ADAPTER_SERIAL_NUMBER
{
    /// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_ADAPTER_SERIAL_NUMBER.xml' path='doc/member[@name="STORAGE_ADAPTER_SERIAL_NUMBER.SerialNumber"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort SerialNumber[128];
}