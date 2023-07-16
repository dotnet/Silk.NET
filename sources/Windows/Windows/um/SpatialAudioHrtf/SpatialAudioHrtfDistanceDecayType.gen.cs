// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SpatialAudioHrtfDistanceDecayType.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecayType"]/*'/>
public enum SpatialAudioHrtfDistanceDecayType
{
    /// <include file='SpatialAudioHrtfDistanceDecayType.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecayType.SpatialAudioHrtfDistanceDecay_NaturalDecay"]/*'/>
    SpatialAudioHrtfDistanceDecay_NaturalDecay = 0,
    /// <include file='SpatialAudioHrtfDistanceDecayType.xml' path='doc/member[@name="SpatialAudioHrtfDistanceDecayType.SpatialAudioHrtfDistanceDecay_CustomDecay"]/*'/>
    SpatialAudioHrtfDistanceDecay_CustomDecay = (SpatialAudioHrtfDistanceDecay_NaturalDecay + 1),
}