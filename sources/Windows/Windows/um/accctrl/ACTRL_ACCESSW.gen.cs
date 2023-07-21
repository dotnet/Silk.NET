// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTRL_ACCESSW.xml' path='doc/member[@name="ACTRL_ACCESSW"]/*' />
public unsafe partial struct ACTRL_ACCESSW
{
    /// <include file='ACTRL_ACCESSW.xml' path='doc/member[@name="ACTRL_ACCESSW.cEntries"]/*' />
    [NativeTypeName("ULONG")]
    public uint cEntries;

    /// <include file='ACTRL_ACCESSW.xml' path='doc/member[@name="ACTRL_ACCESSW.pPropertyAccessList"]/*' />
    [NativeTypeName("PACTRL_PROPERTY_ENTRYW")]
    public ACTRL_PROPERTY_ENTRYW* pPropertyAccessList;
}
