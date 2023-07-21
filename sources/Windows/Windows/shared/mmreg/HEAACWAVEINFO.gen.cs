// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct HEAACWAVEINFO
{
    /// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO.wfx"]/*' />
    public WAVEFORMATEX wfx;

    /// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO.wPayloadType"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPayloadType;

    /// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO.wAudioProfileLevelIndication"]/*' />
    [NativeTypeName("WORD")]
    public ushort wAudioProfileLevelIndication;

    /// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO.wStructType"]/*' />
    [NativeTypeName("WORD")]
    public ushort wStructType;

    /// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='HEAACWAVEINFO.xml' path='doc/member[@name="HEAACWAVEINFO.dwReserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved2;
}
