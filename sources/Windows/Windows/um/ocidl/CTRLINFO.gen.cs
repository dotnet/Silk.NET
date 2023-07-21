// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CTRLINFO.xml' path='doc/member[@name="CTRLINFO"]/*' />
public enum CTRLINFO
{
    /// <include file='CTRLINFO.xml' path='doc/member[@name="CTRLINFO.CTRLINFO_EATS_RETURN"]/*' />
    CTRLINFO_EATS_RETURN = 1,

    /// <include file='CTRLINFO.xml' path='doc/member[@name="CTRLINFO.CTRLINFO_EATS_ESCAPE"]/*' />
    CTRLINFO_EATS_ESCAPE = 2,
}
