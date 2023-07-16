// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SpatialAudioHrtfDirectivity.xml' path='doc/member[@name="SpatialAudioHrtfDirectivity"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDirectivity
{
    /// <include file='SpatialAudioHrtfDirectivity.xml' path='doc/member[@name="SpatialAudioHrtfDirectivity.Type"]/*'/>
    public SpatialAudioHrtfDirectivityType Type;
    /// <include file='SpatialAudioHrtfDirectivity.xml' path='doc/member[@name="SpatialAudioHrtfDirectivity.Scaling"]/*'/>
    public float Scaling;
}