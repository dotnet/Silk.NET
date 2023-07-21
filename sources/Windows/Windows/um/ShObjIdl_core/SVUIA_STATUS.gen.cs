// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SVUIA_STATUS.xml' path='doc/member[@name="SVUIA_STATUS"]/*' />
public enum SVUIA_STATUS
{
    /// <include file='SVUIA_STATUS.xml' path='doc/member[@name="SVUIA_STATUS.SVUIA_DEACTIVATE"]/*' />
    SVUIA_DEACTIVATE = 0,

    /// <include file='SVUIA_STATUS.xml' path='doc/member[@name="SVUIA_STATUS.SVUIA_ACTIVATE_NOFOCUS"]/*' />
    SVUIA_ACTIVATE_NOFOCUS = 1,

    /// <include file='SVUIA_STATUS.xml' path='doc/member[@name="SVUIA_STATUS.SVUIA_ACTIVATE_FOCUS"]/*' />
    SVUIA_ACTIVATE_FOCUS = 2,

    /// <include file='SVUIA_STATUS.xml' path='doc/member[@name="SVUIA_STATUS.SVUIA_INPLACEACTIVATE"]/*' />
    SVUIA_INPLACEACTIVATE = 3,
}
