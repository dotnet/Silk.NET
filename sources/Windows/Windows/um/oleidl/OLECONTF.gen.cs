// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OLECONTF.xml' path='doc/member[@name="OLECONTF"]/*' />
public enum OLECONTF
{
    /// <include file='OLECONTF.xml' path='doc/member[@name="OLECONTF.OLECONTF_EMBEDDINGS"]/*' />
    OLECONTF_EMBEDDINGS = 1,

    /// <include file='OLECONTF.xml' path='doc/member[@name="OLECONTF.OLECONTF_LINKS"]/*' />
    OLECONTF_LINKS = 2,

    /// <include file='OLECONTF.xml' path='doc/member[@name="OLECONTF.OLECONTF_OTHERS"]/*' />
    OLECONTF_OTHERS = 4,

    /// <include file='OLECONTF.xml' path='doc/member[@name="OLECONTF.OLECONTF_ONLYUSER"]/*' />
    OLECONTF_ONLYUSER = 8,

    /// <include file='OLECONTF.xml' path='doc/member[@name="OLECONTF.OLECONTF_ONLYIFRUNNING"]/*' />
    OLECONTF_ONLYIFRUNNING = 16,
}
