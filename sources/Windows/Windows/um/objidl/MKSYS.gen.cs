// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MKSYS.xml' path='doc/member[@name="MKSYS"]/*' />
public enum MKSYS
{
    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_NONE"]/*' />
    MKSYS_NONE = 0,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_GENERICCOMPOSITE"]/*' />
    MKSYS_GENERICCOMPOSITE = 1,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_FILEMONIKER"]/*' />
    MKSYS_FILEMONIKER = 2,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_ANTIMONIKER"]/*' />
    MKSYS_ANTIMONIKER = 3,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_ITEMMONIKER"]/*' />
    MKSYS_ITEMMONIKER = 4,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_POINTERMONIKER"]/*' />
    MKSYS_POINTERMONIKER = 5,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_CLASSMONIKER"]/*' />
    MKSYS_CLASSMONIKER = 7,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_OBJREFMONIKER"]/*' />
    MKSYS_OBJREFMONIKER = 8,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_SESSIONMONIKER"]/*' />
    MKSYS_SESSIONMONIKER = 9,

    /// <include file='MKSYS.xml' path='doc/member[@name="MKSYS.MKSYS_LUAMONIKER"]/*' />
    MKSYS_LUAMONIKER = 10,
}
