// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2"]/*'/>
public unsafe partial struct STORAGE_HW_FIRMWARE_DOWNLOAD_V2
{
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Slot"]/*'/>
    public byte Slot;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Reserved"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved[3];
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Offset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.BufferSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BufferSize;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.ImageSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImageSize;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.Reserved2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved2;
    /// <include file='STORAGE_HW_FIRMWARE_DOWNLOAD_V2.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_DOWNLOAD_V2.ImageBuffer"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte ImageBuffer[1];
}