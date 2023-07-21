// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WBEM_QUERY_FLAG_TYPE.xml' path='doc/member[@name="WBEM_QUERY_FLAG_TYPE"]/*' />
public enum WBEM_QUERY_FLAG_TYPE
{
    /// <include file='WBEM_QUERY_FLAG_TYPE.xml' path='doc/member[@name="WBEM_QUERY_FLAG_TYPE.WBEM_FLAG_DEEP"]/*' />
    WBEM_FLAG_DEEP = 0,

    /// <include file='WBEM_QUERY_FLAG_TYPE.xml' path='doc/member[@name="WBEM_QUERY_FLAG_TYPE.WBEM_FLAG_SHALLOW"]/*' />
    WBEM_FLAG_SHALLOW = 1,

    /// <include file='WBEM_QUERY_FLAG_TYPE.xml' path='doc/member[@name="WBEM_QUERY_FLAG_TYPE.WBEM_FLAG_PROTOTYPE"]/*' />
    WBEM_FLAG_PROTOTYPE = 2,
}
