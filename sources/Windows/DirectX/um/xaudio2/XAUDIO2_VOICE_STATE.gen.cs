// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='XAUDIO2_VOICE_STATE.xml' path='doc/member[@name="XAUDIO2_VOICE_STATE"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2_VOICE_STATE
{
    /// <include file='XAUDIO2_VOICE_STATE.xml' path='doc/member[@name="XAUDIO2_VOICE_STATE.pCurrentBufferContext"]/*' />
    public void* pCurrentBufferContext;

    /// <include file='XAUDIO2_VOICE_STATE.xml' path='doc/member[@name="XAUDIO2_VOICE_STATE.BuffersQueued"]/*' />
    [NativeTypeName("UINT32")]
    public uint BuffersQueued;

    /// <include file='XAUDIO2_VOICE_STATE.xml' path='doc/member[@name="XAUDIO2_VOICE_STATE.SamplesPlayed"]/*' />
    [NativeTypeName("UINT64")]
    public ulong SamplesPlayed;
}
