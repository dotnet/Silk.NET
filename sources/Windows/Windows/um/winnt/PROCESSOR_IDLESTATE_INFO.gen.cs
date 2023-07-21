// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO"]/*' />
public unsafe partial struct PROCESSOR_IDLESTATE_INFO
{
    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.TimeCheck"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeCheck;

    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.DemotePercent"]/*' />
    public byte DemotePercent;

    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.PromotePercent"]/*' />
    public byte PromotePercent;

    /// <include file='PROCESSOR_IDLESTATE_INFO.xml' path='doc/member[@name="PROCESSOR_IDLESTATE_INFO.Spare"]/*' />
    [NativeTypeName("BYTE[2]")]
    public fixed byte Spare[2];
}
