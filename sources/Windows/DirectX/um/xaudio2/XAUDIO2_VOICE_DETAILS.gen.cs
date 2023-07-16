// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='XAUDIO2_VOICE_DETAILS.xml' path='doc/member[@name="XAUDIO2_VOICE_DETAILS"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_VOICE_DETAILS
{
    /// <include file='XAUDIO2_VOICE_DETAILS.xml' path='doc/member[@name="XAUDIO2_VOICE_DETAILS.CreationFlags"]/*'/>
    [NativeTypeName("UINT32")]
    public uint CreationFlags;
    /// <include file='XAUDIO2_VOICE_DETAILS.xml' path='doc/member[@name="XAUDIO2_VOICE_DETAILS.ActiveFlags"]/*'/>
    [NativeTypeName("UINT32")]
    public uint ActiveFlags;
    /// <include file='XAUDIO2_VOICE_DETAILS.xml' path='doc/member[@name="XAUDIO2_VOICE_DETAILS.InputChannels"]/*'/>
    [NativeTypeName("UINT32")]
    public uint InputChannels;
    /// <include file='XAUDIO2_VOICE_DETAILS.xml' path='doc/member[@name="XAUDIO2_VOICE_DETAILS.InputSampleRate"]/*'/>
    [NativeTypeName("UINT32")]
    public uint InputSampleRate;
}