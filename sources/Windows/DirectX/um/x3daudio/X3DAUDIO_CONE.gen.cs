// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct X3DAUDIO_CONE
{
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.InnerAngle"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float InnerAngle;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.OuterAngle"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float OuterAngle;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.InnerVolume"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float InnerVolume;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.OuterVolume"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float OuterVolume;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.InnerLPF"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float InnerLPF;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.OuterLPF"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float OuterLPF;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.InnerReverb"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float InnerReverb;
    /// <include file='X3DAUDIO_CONE.xml' path='doc/member[@name="X3DAUDIO_CONE.OuterReverb"]/*'/>
    [NativeTypeName("FLOAT32")]
    public float OuterReverb;
}