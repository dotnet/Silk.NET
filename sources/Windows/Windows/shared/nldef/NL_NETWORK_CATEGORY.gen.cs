// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NL_NETWORK_CATEGORY.xml' path='doc/member[@name="NL_NETWORK_CATEGORY"]/*' />
public enum NL_NETWORK_CATEGORY
{
    /// <include file='NL_NETWORK_CATEGORY.xml' path='doc/member[@name="NL_NETWORK_CATEGORY.NetworkCategoryPublic"]/*' />
    NetworkCategoryPublic,

    /// <include file='NL_NETWORK_CATEGORY.xml' path='doc/member[@name="NL_NETWORK_CATEGORY.NetworkCategoryPrivate"]/*' />
    NetworkCategoryPrivate,

    /// <include file='NL_NETWORK_CATEGORY.xml' path='doc/member[@name="NL_NETWORK_CATEGORY.NetworkCategoryDomainAuthenticated"]/*' />
    NetworkCategoryDomainAuthenticated,

    /// <include file='NL_NETWORK_CATEGORY.xml' path='doc/member[@name="NL_NETWORK_CATEGORY.NetworkCategoryUnchanged"]/*' />
    NetworkCategoryUnchanged = -1,

    /// <include file='NL_NETWORK_CATEGORY.xml' path='doc/member[@name="NL_NETWORK_CATEGORY.NetworkCategoryUnknown"]/*' />
    NetworkCategoryUnknown = -1,
}
