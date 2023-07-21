// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='VOLUMEWAVEFILTER.xml' path='doc/member[@name="VOLUMEWAVEFILTER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct VOLUMEWAVEFILTER
{
    /// <include file='VOLUMEWAVEFILTER.xml' path='doc/member[@name="VOLUMEWAVEFILTER.wfltr"]/*' />
    public WAVEFILTER wfltr;

    /// <include file='VOLUMEWAVEFILTER.xml' path='doc/member[@name="VOLUMEWAVEFILTER.dwVolume"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVolume;
}
