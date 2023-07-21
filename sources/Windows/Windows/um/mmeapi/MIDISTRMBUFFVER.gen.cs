// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIDISTRMBUFFVER.xml' path='doc/member[@name="MIDISTRMBUFFVER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDISTRMBUFFVER
{
    /// <include file='MIDISTRMBUFFVER.xml' path='doc/member[@name="MIDISTRMBUFFVER.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='MIDISTRMBUFFVER.xml' path='doc/member[@name="MIDISTRMBUFFVER.dwMid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMid;

    /// <include file='MIDISTRMBUFFVER.xml' path='doc/member[@name="MIDISTRMBUFFVER.dwOEMVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOEMVersion;
}
