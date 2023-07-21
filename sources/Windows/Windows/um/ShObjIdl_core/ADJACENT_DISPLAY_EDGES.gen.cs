// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ADJACENT_DISPLAY_EDGES.xml' path='doc/member[@name="ADJACENT_DISPLAY_EDGES"]/*' />
public enum ADJACENT_DISPLAY_EDGES
{
    /// <include file='ADJACENT_DISPLAY_EDGES.xml' path='doc/member[@name="ADJACENT_DISPLAY_EDGES.ADE_NONE"]/*' />
    ADE_NONE = 0,

    /// <include file='ADJACENT_DISPLAY_EDGES.xml' path='doc/member[@name="ADJACENT_DISPLAY_EDGES.ADE_LEFT"]/*' />
    ADE_LEFT = 0x1,

    /// <include file='ADJACENT_DISPLAY_EDGES.xml' path='doc/member[@name="ADJACENT_DISPLAY_EDGES.ADE_RIGHT"]/*' />
    ADE_RIGHT = 0x2,
}
