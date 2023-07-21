// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CDCONTROLSTATEF.xml' path='doc/member[@name="CDCONTROLSTATEF"]/*' />
public enum CDCONTROLSTATEF
{
    /// <include file='CDCONTROLSTATEF.xml' path='doc/member[@name="CDCONTROLSTATEF.CDCS_INACTIVE"]/*' />
    CDCS_INACTIVE = 0,

    /// <include file='CDCONTROLSTATEF.xml' path='doc/member[@name="CDCONTROLSTATEF.CDCS_ENABLED"]/*' />
    CDCS_ENABLED = 0x1,

    /// <include file='CDCONTROLSTATEF.xml' path='doc/member[@name="CDCONTROLSTATEF.CDCS_VISIBLE"]/*' />
    CDCS_VISIBLE = 0x2,

    /// <include file='CDCONTROLSTATEF.xml' path='doc/member[@name="CDCONTROLSTATEF.CDCS_ENABLEDVISIBLE"]/*' />
    CDCS_ENABLEDVISIBLE = 0x3,
}
