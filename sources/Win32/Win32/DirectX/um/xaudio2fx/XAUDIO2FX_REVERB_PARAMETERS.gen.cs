// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2FX_REVERB_PARAMETERS
{
    public float WetDryMix;

    [NativeTypeName("UINT32")]
    public uint ReflectionsDelay;
    public byte ReverbDelay;
    public byte RearDelay;
    public byte SideDelay;
    public byte PositionLeft;
    public byte PositionRight;
    public byte PositionMatrixLeft;
    public byte PositionMatrixRight;
    public byte EarlyDiffusion;
    public byte LateDiffusion;
    public byte LowEQGain;
    public byte LowEQCutoff;
    public byte HighEQGain;
    public byte HighEQCutoff;
    public float RoomFilterFreq;
    public float RoomFilterMain;
    public float RoomFilterHF;
    public float ReflectionsGain;
    public float ReverbGain;
    public float DecayTime;
    public float Density;
    public float RoomSize;
    public BOOL DisableLateField;
}
