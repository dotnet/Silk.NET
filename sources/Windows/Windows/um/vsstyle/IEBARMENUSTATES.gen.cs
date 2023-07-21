// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IEBARMENUSTATES.xml' path='doc/member[@name="IEBARMENUSTATES"]/*' />
public enum IEBARMENUSTATES
{
    /// <include file='IEBARMENUSTATES.xml' path='doc/member[@name="IEBARMENUSTATES.EBM_NORMAL"]/*' />
    EBM_NORMAL = 1,

    /// <include file='IEBARMENUSTATES.xml' path='doc/member[@name="IEBARMENUSTATES.EBM_HOT"]/*' />
    EBM_HOT = 2,

    /// <include file='IEBARMENUSTATES.xml' path='doc/member[@name="IEBARMENUSTATES.EBM_PRESSED"]/*' />
    EBM_PRESSED = 3,
}
