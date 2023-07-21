// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIEVENT
{
    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwDeltaTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDeltaTime;

    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwStreamID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStreamID;

    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwEvent"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEvent;

    /// <include file='MIDIEVENT.xml' path='doc/member[@name="MIDIEVENT.dwParms"]/*' />
    [NativeTypeName("DWORD[1]")]
    public fixed uint dwParms[1];
}
