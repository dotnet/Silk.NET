// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NL_INTERFACE_NETWORK_CATEGORY_STATE.xml' path='doc/member[@name="NL_INTERFACE_NETWORK_CATEGORY_STATE"]/*' />
public enum NL_INTERFACE_NETWORK_CATEGORY_STATE
{
    /// <include file='NL_INTERFACE_NETWORK_CATEGORY_STATE.xml' path='doc/member[@name="NL_INTERFACE_NETWORK_CATEGORY_STATE.NlincCategoryUnknown"]/*' />
    NlincCategoryUnknown = 0,

    /// <include file='NL_INTERFACE_NETWORK_CATEGORY_STATE.xml' path='doc/member[@name="NL_INTERFACE_NETWORK_CATEGORY_STATE.NlincPublic"]/*' />
    NlincPublic = 1,

    /// <include file='NL_INTERFACE_NETWORK_CATEGORY_STATE.xml' path='doc/member[@name="NL_INTERFACE_NETWORK_CATEGORY_STATE.NlincPrivate"]/*' />
    NlincPrivate = 2,

    /// <include file='NL_INTERFACE_NETWORK_CATEGORY_STATE.xml' path='doc/member[@name="NL_INTERFACE_NETWORK_CATEGORY_STATE.NlincDomainAuthenticated"]/*' />
    NlincDomainAuthenticated = 3,

    /// <include file='NL_INTERFACE_NETWORK_CATEGORY_STATE.xml' path='doc/member[@name="NL_INTERFACE_NETWORK_CATEGORY_STATE.NlincCategoryStateMax"]/*' />
    NlincCategoryStateMax,
}
