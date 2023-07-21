// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SONARCWAVEFORMAT.xml' path='doc/member[@name="SONARCWAVEFORMAT"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SONARCWAVEFORMAT
{
    /// <include file='SONARCWAVEFORMAT.xml' path='doc/member[@name="SONARCWAVEFORMAT.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='SONARCWAVEFORMAT.xml' path='doc/member[@name="SONARCWAVEFORMAT.wCompType"]/*' />
    [NativeTypeName("WORD")]
    public ushort wCompType;
}
