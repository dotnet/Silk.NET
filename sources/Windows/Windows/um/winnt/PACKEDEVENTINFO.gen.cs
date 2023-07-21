// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO"]/*' />
public unsafe partial struct PACKEDEVENTINFO
{
    /// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO.ulSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulSize;

    /// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO.ulNumEventsForLogFile"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulNumEventsForLogFile;

    /// <include file='PACKEDEVENTINFO.xml' path='doc/member[@name="PACKEDEVENTINFO.ulOffsets"]/*' />
    [NativeTypeName("DWORD[]")]
    public fixed uint ulOffsets[1];
}
