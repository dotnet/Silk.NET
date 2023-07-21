// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DCOMPOSITION_DEPTH_MODE.xml' path='doc/member[@name="DCOMPOSITION_DEPTH_MODE"]/*' />
public enum DCOMPOSITION_DEPTH_MODE
{
    /// <include file='DCOMPOSITION_DEPTH_MODE.xml' path='doc/member[@name="DCOMPOSITION_DEPTH_MODE.DCOMPOSITION_DEPTH_MODE_TREE"]/*' />
    DCOMPOSITION_DEPTH_MODE_TREE = 0,

    /// <include file='DCOMPOSITION_DEPTH_MODE.xml' path='doc/member[@name="DCOMPOSITION_DEPTH_MODE.DCOMPOSITION_DEPTH_MODE_SPATIAL"]/*' />
    DCOMPOSITION_DEPTH_MODE_SPATIAL = 1,

    /// <include file='DCOMPOSITION_DEPTH_MODE.xml' path='doc/member[@name="DCOMPOSITION_DEPTH_MODE.DCOMPOSITION_DEPTH_MODE_SORTED"]/*' />
    DCOMPOSITION_DEPTH_MODE_SORTED = 3,

    /// <include file='DCOMPOSITION_DEPTH_MODE.xml' path='doc/member[@name="DCOMPOSITION_DEPTH_MODE.DCOMPOSITION_DEPTH_MODE_INHERIT"]/*' />
    DCOMPOSITION_DEPTH_MODE_INHERIT = unchecked((int)(0xffffffff)),
}
