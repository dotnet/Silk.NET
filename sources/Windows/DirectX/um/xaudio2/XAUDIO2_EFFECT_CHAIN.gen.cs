// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='XAUDIO2_EFFECT_CHAIN.xml' path='doc/member[@name="XAUDIO2_EFFECT_CHAIN"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2_EFFECT_CHAIN
{
    /// <include file='XAUDIO2_EFFECT_CHAIN.xml' path='doc/member[@name="XAUDIO2_EFFECT_CHAIN.EffectCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint EffectCount;
    /// <include file='XAUDIO2_EFFECT_CHAIN.xml' path='doc/member[@name="XAUDIO2_EFFECT_CHAIN.pEffectDescriptors"]/*'/>
    public XAUDIO2_EFFECT_DESCRIPTOR* pEffectDescriptors;
}