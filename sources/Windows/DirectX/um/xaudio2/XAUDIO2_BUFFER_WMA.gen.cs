// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='XAUDIO2_BUFFER_WMA.xml' path='doc/member[@name="XAUDIO2_BUFFER_WMA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2_BUFFER_WMA
{
    /// <include file='XAUDIO2_BUFFER_WMA.xml' path='doc/member[@name="XAUDIO2_BUFFER_WMA.pDecodedPacketCumulativeBytes"]/*' />
    [NativeTypeName("const UINT32 *")]
    public uint* pDecodedPacketCumulativeBytes;

    /// <include file='XAUDIO2_BUFFER_WMA.xml' path='doc/member[@name="XAUDIO2_BUFFER_WMA.PacketCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint PacketCount;
}
