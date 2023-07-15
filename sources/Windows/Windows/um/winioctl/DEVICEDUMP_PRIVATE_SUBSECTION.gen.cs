// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICEDUMP_PRIVATE_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PRIVATE_SUBSECTION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_PRIVATE_SUBSECTION
{
    /// <include file='DEVICEDUMP_PRIVATE_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PRIVATE_SUBSECTION.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DEVICEDUMP_PRIVATE_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PRIVATE_SUBSECTION.GPLogId"]/*'/>
    public GP_LOG_PAGE_DESCRIPTOR GPLogId;
    /// <include file='DEVICEDUMP_PRIVATE_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_PRIVATE_SUBSECTION.bData"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte bData[1];
}