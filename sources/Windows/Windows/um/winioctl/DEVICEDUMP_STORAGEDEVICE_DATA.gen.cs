// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_STORAGEDEVICE_DATA
{
    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.Descriptor"]/*' />
    public DEVICEDUMP_STRUCTURE_VERSION Descriptor;

    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.SectionHeader"]/*' />
    public DEVICEDUMP_SECTION_HEADER SectionHeader;

    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.dwBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBufferSize;

    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.dwReasonForCollection"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReasonForCollection;

    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.PublicData"]/*' />
    public DEVICEDUMP_SUBSECTION_POINTER PublicData;

    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.RestrictedData"]/*' />
    public DEVICEDUMP_SUBSECTION_POINTER RestrictedData;

    /// <include file='DEVICEDUMP_STORAGEDEVICE_DATA.xml' path='doc/member[@name="DEVICEDUMP_STORAGEDEVICE_DATA.PrivateData"]/*' />
    public DEVICEDUMP_SUBSECTION_POINTER PrivateData;
}
