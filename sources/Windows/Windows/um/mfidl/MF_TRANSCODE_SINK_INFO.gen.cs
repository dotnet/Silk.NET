// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_TRANSCODE_SINK_INFO.xml' path='doc/member[@name="MF_TRANSCODE_SINK_INFO"]/*'/>
public unsafe partial struct MF_TRANSCODE_SINK_INFO
{
    /// <include file='MF_TRANSCODE_SINK_INFO.xml' path='doc/member[@name="MF_TRANSCODE_SINK_INFO.dwVideoStreamID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVideoStreamID;
    /// <include file='MF_TRANSCODE_SINK_INFO.xml' path='doc/member[@name="MF_TRANSCODE_SINK_INFO.pVideoMediaType"]/*'/>
    public IMFMediaType* pVideoMediaType;
    /// <include file='MF_TRANSCODE_SINK_INFO.xml' path='doc/member[@name="MF_TRANSCODE_SINK_INFO.dwAudioStreamID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAudioStreamID;
    /// <include file='MF_TRANSCODE_SINK_INFO.xml' path='doc/member[@name="MF_TRANSCODE_SINK_INFO.pAudioMediaType"]/*'/>
    public IMFMediaType* pAudioMediaType;
}