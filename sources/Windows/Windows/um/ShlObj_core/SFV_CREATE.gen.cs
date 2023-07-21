// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SFV_CREATE.xml' path='doc/member[@name="SFV_CREATE"]/*' />
public unsafe partial struct SFV_CREATE
{
    /// <include file='SFV_CREATE.xml' path='doc/member[@name="SFV_CREATE.cbSize"]/*' />
    public uint cbSize;

    /// <include file='SFV_CREATE.xml' path='doc/member[@name="SFV_CREATE.pshf"]/*' />
    public IShellFolder* pshf;

    /// <include file='SFV_CREATE.xml' path='doc/member[@name="SFV_CREATE.psvOuter"]/*' />
    public IShellView* psvOuter;

    /// <include file='SFV_CREATE.xml' path='doc/member[@name="SFV_CREATE.psfvcb"]/*' />
    public IShellFolderViewCB* psfvcb;
}
