// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Numerics;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='X3DAUDIO_LISTENER.xml' path='doc/member[@name="X3DAUDIO_LISTENER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct X3DAUDIO_LISTENER
{
    /// <include file='X3DAUDIO_LISTENER.xml' path='doc/member[@name="X3DAUDIO_LISTENER.OrientFront"]/*'/>
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 OrientFront;
    /// <include file='X3DAUDIO_LISTENER.xml' path='doc/member[@name="X3DAUDIO_LISTENER.OrientTop"]/*'/>
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 OrientTop;
    /// <include file='X3DAUDIO_LISTENER.xml' path='doc/member[@name="X3DAUDIO_LISTENER.Position"]/*'/>
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 Position;
    /// <include file='X3DAUDIO_LISTENER.xml' path='doc/member[@name="X3DAUDIO_LISTENER.Velocity"]/*'/>
    [NativeTypeName("X3DAUDIO_VECTOR")]
    public Vector3 Velocity;
    /// <include file='X3DAUDIO_LISTENER.xml' path='doc/member[@name="X3DAUDIO_LISTENER.pCone"]/*'/>
    public X3DAUDIO_CONE* pCone;
}