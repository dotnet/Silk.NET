// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICEDUMP_STRUCTURE_VERSION.xml' path='doc/member[@name="DEVICEDUMP_STRUCTURE_VERSION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_STRUCTURE_VERSION
{
    /// <include file='DEVICEDUMP_STRUCTURE_VERSION.xml' path='doc/member[@name="DEVICEDUMP_STRUCTURE_VERSION.dwSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignature;
    /// <include file='DEVICEDUMP_STRUCTURE_VERSION.xml' path='doc/member[@name="DEVICEDUMP_STRUCTURE_VERSION.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='DEVICEDUMP_STRUCTURE_VERSION.xml' path='doc/member[@name="DEVICEDUMP_STRUCTURE_VERSION.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
}