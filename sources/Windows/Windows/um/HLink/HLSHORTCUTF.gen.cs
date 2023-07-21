// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HLSHORTCUTF.xml' path='doc/member[@name="HLSHORTCUTF"]/*' />
public enum HLSHORTCUTF
{
    /// <include file='HLSHORTCUTF.xml' path='doc/member[@name="HLSHORTCUTF.HLSHORTCUTF_DEFAULT"]/*' />
    HLSHORTCUTF_DEFAULT = 0,

    /// <include file='HLSHORTCUTF.xml' path='doc/member[@name="HLSHORTCUTF.HLSHORTCUTF_DONTACTUALLYCREATE"]/*' />
    HLSHORTCUTF_DONTACTUALLYCREATE = 0x1,

    /// <include file='HLSHORTCUTF.xml' path='doc/member[@name="HLSHORTCUTF.HLSHORTCUTF_USEFILENAMEFROMFRIENDLYNAME"]/*' />
    HLSHORTCUTF_USEFILENAMEFROMFRIENDLYNAME = 0x2,

    /// <include file='HLSHORTCUTF.xml' path='doc/member[@name="HLSHORTCUTF.HLSHORTCUTF_USEUNIQUEFILENAME"]/*' />
    HLSHORTCUTF_USEUNIQUEFILENAME = 0x4,

    /// <include file='HLSHORTCUTF.xml' path='doc/member[@name="HLSHORTCUTF.HLSHORTCUTF_MAYUSEEXISTINGSHORTCUT"]/*' />
    HLSHORTCUTF_MAYUSEEXISTINGSHORTCUT = 0x8,
}
