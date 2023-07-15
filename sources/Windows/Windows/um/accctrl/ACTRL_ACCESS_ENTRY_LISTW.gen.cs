// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_ACCESS_ENTRY_LISTW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRY_LISTW"]/*'/>
public unsafe partial struct ACTRL_ACCESS_ENTRY_LISTW
{
    /// <include file='ACTRL_ACCESS_ENTRY_LISTW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRY_LISTW.cEntries"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cEntries;
    /// <include file='ACTRL_ACCESS_ENTRY_LISTW.xml' path='doc/member[@name="ACTRL_ACCESS_ENTRY_LISTW.pAccessList"]/*'/>
    public ACTRL_ACCESS_ENTRYW* pAccessList;
}