// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GPO_LINK.xml' path='doc/member[@name="GPO_LINK"]/*' />
public enum GPO_LINK
{
    /// <include file='GPO_LINK.xml' path='doc/member[@name="GPO_LINK.GPLinkUnknown"]/*' />
    GPLinkUnknown = 0,

    /// <include file='GPO_LINK.xml' path='doc/member[@name="GPO_LINK.GPLinkMachine"]/*' />
    GPLinkMachine,

    /// <include file='GPO_LINK.xml' path='doc/member[@name="GPO_LINK.GPLinkSite"]/*' />
    GPLinkSite,

    /// <include file='GPO_LINK.xml' path='doc/member[@name="GPO_LINK.GPLinkDomain"]/*' />
    GPLinkDomain,

    /// <include file='GPO_LINK.xml' path='doc/member[@name="GPO_LINK.GPLinkOrganizationalUnit"]/*' />
    GPLinkOrganizationalUnit,
}
