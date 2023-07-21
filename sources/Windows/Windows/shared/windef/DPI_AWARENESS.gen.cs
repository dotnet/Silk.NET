// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DPI_AWARENESS.xml' path='doc/member[@name="DPI_AWARENESS"]/*' />
public enum DPI_AWARENESS
{
    /// <include file='DPI_AWARENESS.xml' path='doc/member[@name="DPI_AWARENESS.DPI_AWARENESS_INVALID"]/*' />
    DPI_AWARENESS_INVALID = -1,

    /// <include file='DPI_AWARENESS.xml' path='doc/member[@name="DPI_AWARENESS.DPI_AWARENESS_UNAWARE"]/*' />
    DPI_AWARENESS_UNAWARE = 0,

    /// <include file='DPI_AWARENESS.xml' path='doc/member[@name="DPI_AWARENESS.DPI_AWARENESS_SYSTEM_AWARE"]/*' />
    DPI_AWARENESS_SYSTEM_AWARE = 1,

    /// <include file='DPI_AWARENESS.xml' path='doc/member[@name="DPI_AWARENESS.DPI_AWARENESS_PER_MONITOR_AWARE"]/*' />
    DPI_AWARENESS_PER_MONITOR_AWARE = 2,
}
