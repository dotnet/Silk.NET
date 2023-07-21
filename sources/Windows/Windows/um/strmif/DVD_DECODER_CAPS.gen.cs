// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS"]/*' />
public partial struct DVD_DECODER_CAPS
{
    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dwAudioCaps"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAudioCaps;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dFwdMaxRateVideo"]/*' />
    public double dFwdMaxRateVideo;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dFwdMaxRateAudio"]/*' />
    public double dFwdMaxRateAudio;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dFwdMaxRateSP"]/*' />
    public double dFwdMaxRateSP;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dBwdMaxRateVideo"]/*' />
    public double dBwdMaxRateVideo;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dBwdMaxRateAudio"]/*' />
    public double dBwdMaxRateAudio;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dBwdMaxRateSP"]/*' />
    public double dBwdMaxRateSP;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dwRes1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRes1;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dwRes2"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRes2;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dwRes3"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRes3;

    /// <include file='DVD_DECODER_CAPS.xml' path='doc/member[@name="DVD_DECODER_CAPS.dwRes4"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRes4;
}
