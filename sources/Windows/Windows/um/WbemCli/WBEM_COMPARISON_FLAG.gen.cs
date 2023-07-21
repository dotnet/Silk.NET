// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG"]/*' />
public enum WBEM_COMPARISON_FLAG
{
    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_COMPARISON_INCLUDE_ALL"]/*' />
    WBEM_COMPARISON_INCLUDE_ALL = 0,

    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_FLAG_IGNORE_QUALIFIERS"]/*' />
    WBEM_FLAG_IGNORE_QUALIFIERS = 0x1,

    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_FLAG_IGNORE_OBJECT_SOURCE"]/*' />
    WBEM_FLAG_IGNORE_OBJECT_SOURCE = 0x2,

    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_FLAG_IGNORE_DEFAULT_VALUES"]/*' />
    WBEM_FLAG_IGNORE_DEFAULT_VALUES = 0x4,

    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_FLAG_IGNORE_CLASS"]/*' />
    WBEM_FLAG_IGNORE_CLASS = 0x8,

    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_FLAG_IGNORE_CASE"]/*' />
    WBEM_FLAG_IGNORE_CASE = 0x10,

    /// <include file='WBEM_COMPARISON_FLAG.xml' path='doc/member[@name="WBEM_COMPARISON_FLAG.WBEM_FLAG_IGNORE_FLAVOR"]/*' />
    WBEM_FLAG_IGNORE_FLAVOR = 0x20,
}
