// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MFMPEG2DLNASINKSTATS
{
    [NativeTypeName("DWORDLONG")]
    public ulong cBytesWritten;
    public BOOL fPAL;

    [NativeTypeName("DWORD")]
    public uint fccVideo;

    [NativeTypeName("DWORD")]
    public uint dwVideoWidth;

    [NativeTypeName("DWORD")]
    public uint dwVideoHeight;

    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesReceived;

    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesEncoded;

    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesSkipped;

    [NativeTypeName("DWORDLONG")]
    public ulong cBlackVideoFramesEncoded;

    [NativeTypeName("DWORDLONG")]
    public ulong cVideoFramesDuplicated;

    [NativeTypeName("DWORD")]
    public uint cAudioSamplesPerSec;

    [NativeTypeName("DWORD")]
    public uint cAudioChannels;

    [NativeTypeName("DWORDLONG")]
    public ulong cAudioBytesReceived;

    [NativeTypeName("DWORDLONG")]
    public ulong cAudioFramesEncoded;
}
