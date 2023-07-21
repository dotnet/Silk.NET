// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum DCOMPOSITION_BORDER_MODE
{
    /// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE.DCOMPOSITION_BORDER_MODE_SOFT"]/*' />
    DCOMPOSITION_BORDER_MODE_SOFT = 0,

    /// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE.DCOMPOSITION_BORDER_MODE_HARD"]/*' />
    DCOMPOSITION_BORDER_MODE_HARD = 1,

    /// <include file='DCOMPOSITION_BORDER_MODE.xml' path='doc/member[@name="DCOMPOSITION_BORDER_MODE.DCOMPOSITION_BORDER_MODE_INHERIT"]/*' />
    DCOMPOSITION_BORDER_MODE_INHERIT = unchecked((int)(0xffffffff)),
}
