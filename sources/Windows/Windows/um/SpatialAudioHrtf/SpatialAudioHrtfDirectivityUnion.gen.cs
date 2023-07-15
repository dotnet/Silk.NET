// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SpatialAudioHrtfDirectivityUnion.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityUnion"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct SpatialAudioHrtfDirectivityUnion
{
    /// <include file='SpatialAudioHrtfDirectivityUnion.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityUnion.Cone"]/*'/>
    [FieldOffset(0)]
    public SpatialAudioHrtfDirectivityCone Cone;
    /// <include file='SpatialAudioHrtfDirectivityUnion.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityUnion.Cardiod"]/*'/>
    [FieldOffset(0)]
    public SpatialAudioHrtfDirectivityCardioid Cardiod;
    /// <include file='SpatialAudioHrtfDirectivityUnion.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityUnion.Omni"]/*'/>
    [FieldOffset(0)]
    public SpatialAudioHrtfDirectivity Omni;
}