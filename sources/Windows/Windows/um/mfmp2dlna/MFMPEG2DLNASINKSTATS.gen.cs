// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS"]/*'/>
public partial struct MFMPEG2DLNASINKSTATS
{
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cBytesWritten"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cBytesWritten;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.fPAL"]/*'/>
    public BOOL fPAL;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.fccVideo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fccVideo;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.dwVideoWidth"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVideoWidth;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.dwVideoHeight"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVideoHeight;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cVideoFramesReceived"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesReceived;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cVideoFramesEncoded"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesEncoded;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cVideoFramesSkipped"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesSkipped;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cBlackVideoFramesEncoded"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cBlackVideoFramesEncoded;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cVideoFramesDuplicated"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesDuplicated;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cAudioSamplesPerSec"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAudioSamplesPerSec;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cAudioChannels"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cAudioChannels;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cAudioBytesReceived"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cAudioBytesReceived;
    /// <include file='MFMPEG2DLNASINKSTATS.xml' path='doc/member[@name="MFMPEG2DLNASINKSTATS.cAudioFramesEncoded"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong cAudioFramesEncoded;
}