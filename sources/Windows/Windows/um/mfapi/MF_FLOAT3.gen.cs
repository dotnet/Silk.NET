// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_FLOAT3.xml' path='doc/member[@name="MF_FLOAT3"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct MF_FLOAT3
{
    /// <include file='MF_FLOAT3.xml' path='doc/member[@name="MF_FLOAT3.x"]/*' />
    public float x;

    /// <include file='MF_FLOAT3.xml' path='doc/member[@name="MF_FLOAT3.y"]/*' />
    public float y;

    /// <include file='MF_FLOAT3.xml' path='doc/member[@name="MF_FLOAT3.z"]/*' />
    public float z;
}
