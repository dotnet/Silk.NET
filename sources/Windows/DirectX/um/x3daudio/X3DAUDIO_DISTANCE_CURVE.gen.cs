// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='X3DAUDIO_DISTANCE_CURVE.xml' path='doc/member[@name="X3DAUDIO_DISTANCE_CURVE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_DISTANCE_CURVE
{
    /// <include file='X3DAUDIO_DISTANCE_CURVE.xml' path='doc/member[@name="X3DAUDIO_DISTANCE_CURVE.pPoints"]/*'/>
    public X3DAUDIO_DISTANCE_CURVE_POINT* pPoints;
    /// <include file='X3DAUDIO_DISTANCE_CURVE.xml' path='doc/member[@name="X3DAUDIO_DISTANCE_CURVE.PointCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint PointCount;
}