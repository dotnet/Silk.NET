// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX"]/*' />
public enum MSHCTX
{
    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_LOCAL"]/*' />
    MSHCTX_LOCAL = 0,

    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_NOSHAREDMEM"]/*' />
    MSHCTX_NOSHAREDMEM = 1,

    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_DIFFERENTMACHINE"]/*' />
    MSHCTX_DIFFERENTMACHINE = 2,

    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_INPROC"]/*' />
    MSHCTX_INPROC = 3,

    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_CROSSCTX"]/*' />
    MSHCTX_CROSSCTX = 4,

    /// <include file='MSHCTX.xml' path='doc/member[@name="MSHCTX.MSHCTX_CONTAINER"]/*' />
    MSHCTX_CONTAINER = 5,
}
