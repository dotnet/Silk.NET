// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SpatialAudioHrtfDistanceDecay.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecay"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDistanceDecay
{
    /// <include file='SpatialAudioHrtfDistanceDecay.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecay.Type"]/*' />
    public SpatialAudioHrtfDistanceDecayType Type;

    /// <include file='SpatialAudioHrtfDistanceDecay.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecay.MaxGain"]/*' />
    public float MaxGain;

    /// <include file='SpatialAudioHrtfDistanceDecay.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecay.MinGain"]/*' />
    public float MinGain;

    /// <include file='SpatialAudioHrtfDistanceDecay.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecay.UnityGainDistance"]/*' />
    public float UnityGainDistance;

    /// <include file='SpatialAudioHrtfDistanceDecay.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecay.CutoffDistance"]/*' />
    public float CutoffDistance;
}
