// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DVD_DECODER_CAPS
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwAudioCaps;
    public double dFwdMaxRateVideo;
    public double dFwdMaxRateAudio;
    public double dFwdMaxRateSP;
    public double dBwdMaxRateVideo;
    public double dBwdMaxRateAudio;
    public double dBwdMaxRateSP;

    [NativeTypeName("DWORD")]
    public uint dwRes1;

    [NativeTypeName("DWORD")]
    public uint dwRes2;

    [NativeTypeName("DWORD")]
    public uint dwRes3;

    [NativeTypeName("DWORD")]
    public uint dwRes4;
}
