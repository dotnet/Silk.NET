// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FUNCKIND.xml' path='doc/member[@name="FUNCKIND"]/*' />
public enum FUNCKIND
{
    /// <include file='FUNCKIND.xml' path='doc/member[@name="FUNCKIND.FUNC_VIRTUAL"]/*' />
    FUNC_VIRTUAL = 0,

    /// <include file='FUNCKIND.xml' path='doc/member[@name="FUNCKIND.FUNC_PUREVIRTUAL"]/*' />
    FUNC_PUREVIRTUAL = (FUNC_VIRTUAL + 1),

    /// <include file='FUNCKIND.xml' path='doc/member[@name="FUNCKIND.FUNC_NONVIRTUAL"]/*' />
    FUNC_NONVIRTUAL = (FUNC_PUREVIRTUAL + 1),

    /// <include file='FUNCKIND.xml' path='doc/member[@name="FUNCKIND.FUNC_STATIC"]/*' />
    FUNC_STATIC = (FUNC_NONVIRTUAL + 1),

    /// <include file='FUNCKIND.xml' path='doc/member[@name="FUNCKIND.FUNC_DISPATCH"]/*' />
    FUNC_DISPATCH = (FUNC_STATIC + 1),
}
