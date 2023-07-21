// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INTERFACEDATA.xml' path='doc/member[@name="INTERFACEDATA"]/*' />
public unsafe partial struct INTERFACEDATA
{
    /// <include file='INTERFACEDATA.xml' path='doc/member[@name="INTERFACEDATA.pmethdata"]/*' />
    public METHODDATA* pmethdata;

    /// <include file='INTERFACEDATA.xml' path='doc/member[@name="INTERFACEDATA.cMembers"]/*' />
    public uint cMembers;
}
