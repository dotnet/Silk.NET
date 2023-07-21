// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_ROUTESTATE.xml' path='doc/member[@name="MIB_ROUTESTATE"]/*' />
public partial struct MIB_ROUTESTATE
{
    /// <include file='MIB_ROUTESTATE.xml' path='doc/member[@name="MIB_ROUTESTATE.bRoutesSetToStack"]/*' />
    public BOOL bRoutesSetToStack;
}
