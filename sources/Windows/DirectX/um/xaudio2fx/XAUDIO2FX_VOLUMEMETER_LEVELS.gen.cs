// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='XAUDIO2FX_VOLUMEMETER_LEVELS.xml' path='doc/member[@name="XAUDIO2FX_VOLUMEMETER_LEVELS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2FX_VOLUMEMETER_LEVELS
{
    /// <include file='XAUDIO2FX_VOLUMEMETER_LEVELS.xml' path='doc/member[@name="XAUDIO2FX_VOLUMEMETER_LEVELS.pPeakLevels"]/*' />
    public float* pPeakLevels;

    /// <include file='XAUDIO2FX_VOLUMEMETER_LEVELS.xml' path='doc/member[@name="XAUDIO2FX_VOLUMEMETER_LEVELS.pRMSLevels"]/*' />
    public float* pRMSLevels;

    /// <include file='XAUDIO2FX_VOLUMEMETER_LEVELS.xml' path='doc/member[@name="XAUDIO2FX_VOLUMEMETER_LEVELS.ChannelCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint ChannelCount;
}
