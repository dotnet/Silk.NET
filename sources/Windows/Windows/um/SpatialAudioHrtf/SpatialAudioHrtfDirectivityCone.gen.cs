// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SpatialAudioHrtfDirectivityCone.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCone"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDirectivityCone
{
    /// <include file='SpatialAudioHrtfDirectivityCone.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCone.directivity"]/*'/>
    public SpatialAudioHrtfDirectivity directivity;
    /// <include file='SpatialAudioHrtfDirectivityCone.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCone.InnerAngle"]/*'/>
    public float InnerAngle;
    /// <include file='SpatialAudioHrtfDirectivityCone.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCone.OuterAngle"]/*'/>
    public float OuterAngle;
}