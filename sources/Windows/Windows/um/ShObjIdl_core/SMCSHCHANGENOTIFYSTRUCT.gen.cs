// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SMCSHCHANGENOTIFYSTRUCT.xml' path='doc/member[@name="SMCSHCHANGENOTIFYSTRUCT"]/*' />
public unsafe partial struct SMCSHCHANGENOTIFYSTRUCT
{
    /// <include file='SMCSHCHANGENOTIFYSTRUCT.xml' path='doc/member[@name="SMCSHCHANGENOTIFYSTRUCT.lEvent"]/*' />
    [NativeTypeName("long")]
    public int lEvent;

    /// <include file='SMCSHCHANGENOTIFYSTRUCT.xml' path='doc/member[@name="SMCSHCHANGENOTIFYSTRUCT.pidl1"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidl1;

    /// <include file='SMCSHCHANGENOTIFYSTRUCT.xml' path='doc/member[@name="SMCSHCHANGENOTIFYSTRUCT.pidl2"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidl2;
}
