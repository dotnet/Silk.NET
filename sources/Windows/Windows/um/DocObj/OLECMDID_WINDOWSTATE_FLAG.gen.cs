// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='OLECMDID_WINDOWSTATE_FLAG.xml' path='doc/member[@name="OLECMDID_WINDOWSTATE_FLAG"]/*' />
[Flags]
public enum OLECMDID_WINDOWSTATE_FLAG
{
    /// <include file='OLECMDID_WINDOWSTATE_FLAG.xml' path='doc/member[@name="OLECMDID_WINDOWSTATE_FLAG.OLECMDIDF_WINDOWSTATE_USERVISIBLE"]/*' />
    OLECMDIDF_WINDOWSTATE_USERVISIBLE = 0x00000001,

    /// <include file='OLECMDID_WINDOWSTATE_FLAG.xml' path='doc/member[@name="OLECMDID_WINDOWSTATE_FLAG.OLECMDIDF_WINDOWSTATE_ENABLED"]/*' />
    OLECMDIDF_WINDOWSTATE_ENABLED = 0x00000002,

    /// <include file='OLECMDID_WINDOWSTATE_FLAG.xml' path='doc/member[@name="OLECMDID_WINDOWSTATE_FLAG.OLECMDIDF_WINDOWSTATE_USERVISIBLE_VALID"]/*' />
    OLECMDIDF_WINDOWSTATE_USERVISIBLE_VALID = 0x00010000,

    /// <include file='OLECMDID_WINDOWSTATE_FLAG.xml' path='doc/member[@name="OLECMDID_WINDOWSTATE_FLAG.OLECMDIDF_WINDOWSTATE_ENABLED_VALID"]/*' />
    OLECMDIDF_WINDOWSTATE_ENABLED_VALID = 0x00020000,
}
