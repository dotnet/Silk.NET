// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FIND_BY_SID_DATA.xml' path='doc/member[@name="FIND_BY_SID_DATA"]/*' />
public partial struct FIND_BY_SID_DATA
{
    /// <include file='FIND_BY_SID_DATA.xml' path='doc/member[@name="FIND_BY_SID_DATA.Restart"]/*' />
    [NativeTypeName("DWORD")]
    public uint Restart;

    /// <include file='FIND_BY_SID_DATA.xml' path='doc/member[@name="FIND_BY_SID_DATA.Sid"]/*' />
    public SID Sid;
}
