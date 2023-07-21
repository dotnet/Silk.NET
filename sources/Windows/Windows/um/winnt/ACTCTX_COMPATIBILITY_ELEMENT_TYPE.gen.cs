// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTCTX_COMPATIBILITY_ELEMENT_TYPE.xml' path='doc/member[@name="ACTCTX_COMPATIBILITY_ELEMENT_TYPE"]/*' />
public enum ACTCTX_COMPATIBILITY_ELEMENT_TYPE
{
    /// <include file='ACTCTX_COMPATIBILITY_ELEMENT_TYPE.xml' path='doc/member[@name="ACTCTX_COMPATIBILITY_ELEMENT_TYPE.ACTCTX_COMPATIBILITY_ELEMENT_TYPE_UNKNOWN"]/*' />
    ACTCTX_COMPATIBILITY_ELEMENT_TYPE_UNKNOWN = 0,

    /// <include file='ACTCTX_COMPATIBILITY_ELEMENT_TYPE.xml' path='doc/member[@name="ACTCTX_COMPATIBILITY_ELEMENT_TYPE.ACTCTX_COMPATIBILITY_ELEMENT_TYPE_OS"]/*' />
    ACTCTX_COMPATIBILITY_ELEMENT_TYPE_OS,

    /// <include file='ACTCTX_COMPATIBILITY_ELEMENT_TYPE.xml' path='doc/member[@name="ACTCTX_COMPATIBILITY_ELEMENT_TYPE.ACTCTX_COMPATIBILITY_ELEMENT_TYPE_MITIGATION"]/*' />
    ACTCTX_COMPATIBILITY_ELEMENT_TYPE_MITIGATION,

    /// <include file='ACTCTX_COMPATIBILITY_ELEMENT_TYPE.xml' path='doc/member[@name="ACTCTX_COMPATIBILITY_ELEMENT_TYPE.ACTCTX_COMPATIBILITY_ELEMENT_TYPE_MAXVERSIONTESTED"]/*' />
    ACTCTX_COMPATIBILITY_ELEMENT_TYPE_MAXVERSIONTESTED,
}
