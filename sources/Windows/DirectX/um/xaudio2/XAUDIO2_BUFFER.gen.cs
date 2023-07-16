// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct XAUDIO2_BUFFER
{
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.Flags"]/*'/>
    [NativeTypeName("UINT32")]
    public uint Flags;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.AudioBytes"]/*'/>
    [NativeTypeName("UINT32")]
    public uint AudioBytes;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.pAudioData"]/*'/>
    [NativeTypeName("const BYTE *")]
    public byte* pAudioData;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.PlayBegin"]/*'/>
    [NativeTypeName("UINT32")]
    public uint PlayBegin;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.PlayLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint PlayLength;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.LoopBegin"]/*'/>
    [NativeTypeName("UINT32")]
    public uint LoopBegin;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.LoopLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint LoopLength;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.LoopCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint LoopCount;
    /// <include file='XAUDIO2_BUFFER.xml' path='doc/member[@name="XAUDIO2_BUFFER.pContext"]/*'/>
    public void* pContext;
}