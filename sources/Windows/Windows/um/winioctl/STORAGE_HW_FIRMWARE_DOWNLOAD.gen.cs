// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_HW_FIRMWARE_DOWNLOAD
{
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.Slot"]/*'/>
    public byte Slot;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.Reserved"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.Offset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.BufferSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BufferSize;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD.ImageBuffer"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte ImageBuffer[1];
}