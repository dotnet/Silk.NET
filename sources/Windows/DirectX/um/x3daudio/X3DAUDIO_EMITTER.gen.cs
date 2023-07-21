// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Numerics;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_EMITTER
{
    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pCone"]/*' />
    public X3DAUDIO_CONE* pCone;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.OrientFront"]/*' />
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 OrientFront;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.OrientTop"]/*' />
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 OrientTop;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.Position"]/*' />
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 Position;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.Velocity"]/*' />
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 Velocity;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.InnerRadius"]/*' />
    [NativeTypeName("FLOAT32")]
    public float InnerRadius;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.InnerRadiusAngle"]/*' />
    [NativeTypeName("FLOAT32")]
    public float InnerRadiusAngle;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.ChannelCount"]/*' />
    [NativeTypeName("UINT32")]
    public uint ChannelCount;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.ChannelRadius"]/*' />
    [NativeTypeName("FLOAT32")]
    public float ChannelRadius;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pChannelAzimuths"]/*' />
    [NativeTypeName("FLOAT32 *")]
    public float* pChannelAzimuths;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pVolumeCurve"]/*' />
    public X3DAUDIO_DISTANCE_CURVE* pVolumeCurve;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pLFECurve"]/*' />
    public X3DAUDIO_DISTANCE_CURVE* pLFECurve;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pLPFDirectCurve"]/*' />
    public X3DAUDIO_DISTANCE_CURVE* pLPFDirectCurve;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pLPFReverbCurve"]/*' />
    public X3DAUDIO_DISTANCE_CURVE* pLPFReverbCurve;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.pReverbCurve"]/*' />
    public X3DAUDIO_DISTANCE_CURVE* pReverbCurve;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.CurveDistanceScaler"]/*' />
    [NativeTypeName("FLOAT32")]
    public float CurveDistanceScaler;

    /// <include file='X3DAUDIO_EMITTER.xml' path='doc/member[@name="X3DAUDIO_EMITTER.DopplerScaler"]/*' />
    [NativeTypeName("FLOAT32")]
    public float DopplerScaler;
}
