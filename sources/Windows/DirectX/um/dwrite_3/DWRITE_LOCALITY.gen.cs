// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DWRITE_LOCALITY.xml' path='doc/member[@name="DWRITE_LOCALITY"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum DWRITE_LOCALITY
{
    /// <include file='DWRITE_LOCALITY.xml' path='doc/member[@name="DWRITE_LOCALITY.DWRITE_LOCALITY_REMOTE"]/*' />
    DWRITE_LOCALITY_REMOTE,

    /// <include file='DWRITE_LOCALITY.xml' path='doc/member[@name="DWRITE_LOCALITY.DWRITE_LOCALITY_PARTIAL"]/*' />
    DWRITE_LOCALITY_PARTIAL,

    /// <include file='DWRITE_LOCALITY.xml' path='doc/member[@name="DWRITE_LOCALITY.DWRITE_LOCALITY_LOCAL"]/*' />
    DWRITE_LOCALITY_LOCAL,
}
