// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='XAUDIO2_EFFECT_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_EFFECT_DESCRIPTOR"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2_EFFECT_DESCRIPTOR
{
    /// <include file='XAUDIO2_EFFECT_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_EFFECT_DESCRIPTOR.pEffect"]/*' />
    public IUnknown* pEffect;

    /// <include file='XAUDIO2_EFFECT_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_EFFECT_DESCRIPTOR.InitialState"]/*' />
    public BOOL InitialState;

    /// <include file='XAUDIO2_EFFECT_DESCRIPTOR.xml' path='doc/member[@name="XAUDIO2_EFFECT_DESCRIPTOR.OutputChannels"]/*' />
    [NativeTypeName("UINT32")]
    public uint OutputChannels;
}
