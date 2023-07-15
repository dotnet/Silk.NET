// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct STORAGE_HW_FIRMWARE_ACTIVATE
{
    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Slot"]/*'/>
    public byte Slot;
    /// <include file='STORAGE_HW_FIRMWARE_ACTIVATE.xml' path='doc/member[@name="STORAGE_HW_FIRMWARE_ACTIVATE.Reserved0"]/*'/>
    [NativeTypeName("BYTE[3]")]
    public fixed byte Reserved0[3];
}