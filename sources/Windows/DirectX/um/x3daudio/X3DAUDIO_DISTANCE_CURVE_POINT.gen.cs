// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='X3DAUDIO_DISTANCE_CURVE_POINT.xml' path='doc/member[@name="X3DAUDIO_DISTANCE_CURVE_POINT"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct X3DAUDIO_DISTANCE_CURVE_POINT
{
    /// <include file='X3DAUDIO_DISTANCE_CURVE_POINT.xml' path='doc/member[@name="X3DAUDIO_DISTANCE_CURVE_POINT.Distance"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float Distance;
    /// <include file='X3DAUDIO_DISTANCE_CURVE_POINT.xml' path='doc/member[@name="X3DAUDIO_DISTANCE_CURVE_POINT.DSPSetting"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float DSPSetting;
}