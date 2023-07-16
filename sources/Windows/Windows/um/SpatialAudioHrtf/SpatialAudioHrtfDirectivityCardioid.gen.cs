// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SpatialAudioHrtfDirectivityCardioid.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCardioid"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SpatialAudioHrtfDirectivityCardioid
{
    /// <include file='SpatialAudioHrtfDirectivityCardioid.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCardioid.directivity"]/*'/>
    public SpatialAudioHrtfDirectivity directivity;
    /// <include file='SpatialAudioHrtfDirectivityCardioid.xml' path='doc/member[@name="SpatialAudioHrtfDirectivityCardioid.Order"]/*'/>
    public float Order;
}