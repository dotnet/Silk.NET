// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_DSP_SETTINGS
{
    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.pMatrixCoefficients"]/*' />
    [NativeTypeName("FLOAT32 *")]
    public float* pMatrixCoefficients;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.pDelayTimes"]/*' />
    [NativeTypeName("FLOAT32 *")]
    public float* pDelayTimes;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.SrcChannelCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint SrcChannelCount;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.DstChannelCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint DstChannelCount;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.LPFDirectCoefficient"]/*' />
    [NativeTypeName("FLOAT32")]
    public float LPFDirectCoefficient;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.LPFReverbCoefficient"]/*' />
    [NativeTypeName("FLOAT32")]
    public float LPFReverbCoefficient;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.ReverbLevel"]/*' />
    [NativeTypeName("FLOAT32")]
    public float ReverbLevel;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.DopplerFactor"]/*' />
    [NativeTypeName("FLOAT32")]
    public float DopplerFactor;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.EmitterToListenerAngle"]/*' />
    [NativeTypeName("FLOAT32")]
    public float EmitterToListenerAngle;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.EmitterToListenerDistance"]/*' />
    [NativeTypeName("FLOAT32")]
    public float EmitterToListenerDistance;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.EmitterVelocityComponent"]/*' />
    [NativeTypeName("FLOAT32")]
    public float EmitterVelocityComponent;

    /// <include file='X3DAUDIO_DSP_SETTINGS.xml' path='doc/member[@name="X3DAUDIO_DSP_SETTINGS.ListenerVelocityComponent"]/*' />
    [NativeTypeName("FLOAT32")]
    public float ListenerVelocityComponent;
}
