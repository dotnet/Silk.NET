// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_QUATERNION.xml' path='doc/member[@name="MF_QUATERNION"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct MF_QUATERNION
{
    /// <include file='MF_QUATERNION.xml' path='doc/member[@name="MF_QUATERNION.x"]/*' />
    public float x;

    /// <include file='MF_QUATERNION.xml' path='doc/member[@name="MF_QUATERNION.y"]/*' />
    public float y;

    /// <include file='MF_QUATERNION.xml' path='doc/member[@name="MF_QUATERNION.z"]/*' />
    public float z;

    /// <include file='MF_QUATERNION.xml' path='doc/member[@name="MF_QUATERNION.w"]/*' />
    public float w;
}
