// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHELLBROWSERSHOWCONTROL.xml' path='doc/member[@name="SHELLBROWSERSHOWCONTROL"]/*' />
public enum SHELLBROWSERSHOWCONTROL
{
    /// <include file='SHELLBROWSERSHOWCONTROL.xml' path='doc/member[@name="SHELLBROWSERSHOWCONTROL.SBSC_HIDE"]/*' />
    SBSC_HIDE = 0,

    /// <include file='SHELLBROWSERSHOWCONTROL.xml' path='doc/member[@name="SHELLBROWSERSHOWCONTROL.SBSC_SHOW"]/*' />
    SBSC_SHOW = 1,

    /// <include file='SHELLBROWSERSHOWCONTROL.xml' path='doc/member[@name="SHELLBROWSERSHOWCONTROL.SBSC_TOGGLE"]/*' />
    SBSC_TOGGLE = 2,

    /// <include file='SHELLBROWSERSHOWCONTROL.xml' path='doc/member[@name="SHELLBROWSERSHOWCONTROL.SBSC_QUERY"]/*' />
    SBSC_QUERY = 3,
}
