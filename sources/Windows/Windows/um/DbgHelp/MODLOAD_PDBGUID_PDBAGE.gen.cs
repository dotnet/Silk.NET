// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='MODLOAD_PDBGUID_PDBAGE.xml' path='doc/member[@name="MODLOAD_PDBGUID_PDBAGE"]/*'/>
public partial struct MODLOAD_PDBGUID_PDBAGE
{
    /// <include file='MODLOAD_PDBGUID_PDBAGE.xml' path='doc/member[@name="MODLOAD_PDBGUID_PDBAGE.PdbGuid"]/*'/>
    public Guid PdbGuid;
    /// <include file='MODLOAD_PDBGUID_PDBAGE.xml' path='doc/member[@name="MODLOAD_PDBGUID_PDBAGE.PdbAge"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PdbAge;
}