// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVICEDUMP_RESTRICTED_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_RESTRICTED_SUBSECTION"]/*' />
public unsafe partial struct DEVICEDUMP_RESTRICTED_SUBSECTION
{
    /// <include file='DEVICEDUMP_RESTRICTED_SUBSECTION.xml' path='doc/member[@name="DEVICEDUMP_RESTRICTED_SUBSECTION.bData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte bData[1];
}
