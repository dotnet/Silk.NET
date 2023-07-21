// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='D2D1_RENDERING_PRIORITY.xml' path='doc/member[@name="D2D1_RENDERING_PRIORITY"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum D2D1_RENDERING_PRIORITY
{
    /// <include file='D2D1_RENDERING_PRIORITY.xml' path='doc/member[@name="D2D1_RENDERING_PRIORITY.D2D1_RENDERING_PRIORITY_NORMAL"]/*' />
    D2D1_RENDERING_PRIORITY_NORMAL = 0,

    /// <include file='D2D1_RENDERING_PRIORITY.xml' path='doc/member[@name="D2D1_RENDERING_PRIORITY.D2D1_RENDERING_PRIORITY_LOW"]/*' />
    D2D1_RENDERING_PRIORITY_LOW = 1,

    /// <include file='D2D1_RENDERING_PRIORITY.xml' path='doc/member[@name="D2D1_RENDERING_PRIORITY.D2D1_RENDERING_PRIORITY_FORCE_DWORD"]/*' />
    D2D1_RENDERING_PRIORITY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
