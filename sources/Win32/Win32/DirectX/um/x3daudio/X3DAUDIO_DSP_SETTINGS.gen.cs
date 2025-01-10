// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_DSP_SETTINGS
{
    [NativeTypeName("FLOAT32 *")]
    public float* pMatrixCoefficients;

    [NativeTypeName("FLOAT32 *")]
    public float* pDelayTimes;

    [NativeTypeName("UINT32")]
    public uint SrcChannelCount;

    [NativeTypeName("UINT32")]
    public uint DstChannelCount;

    [NativeTypeName("FLOAT32")]
    public float LPFDirectCoefficient;

    [NativeTypeName("FLOAT32")]
    public float LPFReverbCoefficient;

    [NativeTypeName("FLOAT32")]
    public float ReverbLevel;

    [NativeTypeName("FLOAT32")]
    public float DopplerFactor;

    [NativeTypeName("FLOAT32")]
    public float EmitterToListenerAngle;

    [NativeTypeName("FLOAT32")]
    public float EmitterToListenerDistance;

    [NativeTypeName("FLOAT32")]
    public float EmitterVelocityComponent;

    [NativeTypeName("FLOAT32")]
    public float ListenerVelocityComponent;
}
