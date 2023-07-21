// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE"]/*' />
public enum WBEM_FLAVOR_TYPE
{
    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_DONT_PROPAGATE"]/*' />
    WBEM_FLAVOR_DONT_PROPAGATE = 0,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_FLAG_PROPAGATE_TO_INSTANCE"]/*' />
    WBEM_FLAVOR_FLAG_PROPAGATE_TO_INSTANCE = 0x1,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_FLAG_PROPAGATE_TO_DERIVED_CLASS"]/*' />
    WBEM_FLAVOR_FLAG_PROPAGATE_TO_DERIVED_CLASS = 0x2,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_MASK_PROPAGATION"]/*' />
    WBEM_FLAVOR_MASK_PROPAGATION = 0xf,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_OVERRIDABLE"]/*' />
    WBEM_FLAVOR_OVERRIDABLE = 0,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_NOT_OVERRIDABLE"]/*' />
    WBEM_FLAVOR_NOT_OVERRIDABLE = 0x10,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_MASK_PERMISSIONS"]/*' />
    WBEM_FLAVOR_MASK_PERMISSIONS = 0x10,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_ORIGIN_LOCAL"]/*' />
    WBEM_FLAVOR_ORIGIN_LOCAL = 0,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_ORIGIN_PROPAGATED"]/*' />
    WBEM_FLAVOR_ORIGIN_PROPAGATED = 0x20,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_ORIGIN_SYSTEM"]/*' />
    WBEM_FLAVOR_ORIGIN_SYSTEM = 0x40,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_MASK_ORIGIN"]/*' />
    WBEM_FLAVOR_MASK_ORIGIN = 0x60,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_NOT_AMENDED"]/*' />
    WBEM_FLAVOR_NOT_AMENDED = 0,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_AMENDED"]/*' />
    WBEM_FLAVOR_AMENDED = 0x80,

    /// <include file='WBEM_FLAVOR_TYPE.xml' path='doc/member[@name="WBEM_FLAVOR_TYPE.WBEM_FLAVOR_MASK_AMENDED"]/*' />
    WBEM_FLAVOR_MASK_AMENDED = 0x80,
}
