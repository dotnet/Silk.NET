// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFDepthMeasurement.xml' path='doc/member[@name="MFDepthMeasurement"]/*'/>
public enum MFDepthMeasurement
{
    /// <include file='MFDepthMeasurement.xml' path='doc/member[@name="MFDepthMeasurement.DistanceToFocalPlane"]/*'/>
    DistanceToFocalPlane = 0,
    /// <include file='MFDepthMeasurement.xml' path='doc/member[@name="MFDepthMeasurement.DistanceToOpticalCenter"]/*'/>
    DistanceToOpticalCenter = 1,
}