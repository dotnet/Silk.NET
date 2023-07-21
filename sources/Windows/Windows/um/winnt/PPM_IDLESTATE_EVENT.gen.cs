// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PPM_IDLESTATE_EVENT.xml' path='doc/member[@name="PPM_IDLESTATE_EVENT"]/*' />
public partial struct PPM_IDLESTATE_EVENT
{
    /// <include file='PPM_IDLESTATE_EVENT.xml' path='doc/member[@name="PPM_IDLESTATE_EVENT.NewState"]/*' />
    [NativeTypeName("DWORD")]
    public uint NewState;

    /// <include file='PPM_IDLESTATE_EVENT.xml' path='doc/member[@name="PPM_IDLESTATE_EVENT.OldState"]/*' />
    [NativeTypeName("DWORD")]
    public uint OldState;

    /// <include file='PPM_IDLESTATE_EVENT.xml' path='doc/member[@name="PPM_IDLESTATE_EVENT.Processors"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Processors;
}
