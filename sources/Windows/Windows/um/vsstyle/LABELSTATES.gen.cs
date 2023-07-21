// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LABELSTATES.xml' path='doc/member[@name="LABELSTATES"]/*' />
public enum LABELSTATES
{
    /// <include file='LABELSTATES.xml' path='doc/member[@name="LABELSTATES.FLS_NORMAL"]/*' />
    FLS_NORMAL = 1,

    /// <include file='LABELSTATES.xml' path='doc/member[@name="LABELSTATES.FLS_SELECTED"]/*' />
    FLS_SELECTED = 2,

    /// <include file='LABELSTATES.xml' path='doc/member[@name="LABELSTATES.FLS_EMPHASIZED"]/*' />
    FLS_EMPHASIZED = 3,

    /// <include file='LABELSTATES.xml' path='doc/member[@name="LABELSTATES.FLS_DISABLED"]/*' />
    FLS_DISABLED = 4,
}
