// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='XAUDIO2_SEND_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_SEND_DESCRIPTOR"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2_SEND_DESCRIPTOR
{
    /// <include file='XAUDIO2_SEND_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_SEND_DESCRIPTOR.Flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint Flags;

    /// <include file='XAUDIO2_SEND_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_SEND_DESCRIPTOR.pOutputVoice"]/*' />
    public IXAudio2Voice* pOutputVoice;
}
