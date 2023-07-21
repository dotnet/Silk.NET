// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTRL_ACCESS_ENTRY_LISTA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRY_LISTA"]/*' />
public unsafe partial struct ACTRL_ACCESS_ENTRY_LISTA
{
    /// <include file='ACTRL_ACCESS_ENTRY_LISTA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRY_LISTA.cEntries"]/*' />
    [NativeTypeName("ULONG")]
    public uint cEntries;

    /// <include file='ACTRL_ACCESS_ENTRY_LISTA.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRY_LISTA.pAccessList"]/*' />
    public ACTRL_ACCESS_ENTRYA* pAccessList;
}
