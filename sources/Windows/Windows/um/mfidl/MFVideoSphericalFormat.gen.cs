// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoSphericalFormat.xml' path='doc/member[@name="MFVideoSphericalFormat"]/*' />
public enum MFVideoSphericalFormat
{
    /// <include file='MFVideoSphericalFormat.xml' path='doc/member[@name="MFVideoSphericalFormat.MFVideoSphericalFormat_Unsupported"]/*' />
    MFVideoSphericalFormat_Unsupported = 0,

    /// <include file='MFVideoSphericalFormat.xml' path='doc/member[@name="MFVideoSphericalFormat.MFVideoSphericalFormat_Equirectangular"]/*' />
    MFVideoSphericalFormat_Equirectangular = 1,

    /// <include file='MFVideoSphericalFormat.xml' path='doc/member[@name="MFVideoSphericalFormat.MFVideoSphericalFormat_CubeMap"]/*' />
    MFVideoSphericalFormat_CubeMap = 2,

    /// <include file='MFVideoSphericalFormat.xml' path='doc/member[@name="MFVideoSphericalFormat.MFVideoSphericalFormat_3DMesh"]/*' />
    MFVideoSphericalFormat_3DMesh = 3,
}
