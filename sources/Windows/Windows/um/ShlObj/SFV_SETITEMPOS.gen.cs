// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SFV_SETITEMPOS.xml' path='doc/member[@name="SFV_SETITEMPOS"]/*' />
public unsafe partial struct SFV_SETITEMPOS
{
    /// <include file='SFV_SETITEMPOS.xml' path='doc/member[@name="SFV_SETITEMPOS.pidl"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidl;

    /// <include file='SFV_SETITEMPOS.xml' path='doc/member[@name="SFV_SETITEMPOS.pt"]/*' />
    public POINT pt;
}
