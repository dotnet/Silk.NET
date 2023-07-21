// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='ECHOWAVEFILTER.xml' path='doc/member[@name="ECHOWAVEFILTER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ECHOWAVEFILTER
{
    /// <include file='ECHOWAVEFILTER.xml' path='doc/member[@name="ECHOWAVEFILTER.wfltr"]/*' />
    public WAVEFILTER wfltr;

    /// <include file='ECHOWAVEFILTER.xml' path='doc/member[@name="ECHOWAVEFILTER.dwVolume"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVolume;

    /// <include file='ECHOWAVEFILTER.xml' path='doc/member[@name="ECHOWAVEFILTER.dwDelay"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDelay;
}
