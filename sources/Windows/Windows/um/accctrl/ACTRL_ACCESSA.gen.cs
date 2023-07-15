// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_ACCESSA.xml' path='doc/member[@name="ACTRL_ACCESSA"]/*'/>
public unsafe partial struct ACTRL_ACCESSA
{
    /// <include file='ACTRL_ACCESSA.xml' path='doc/member[@name="ACTRL_ACCESSA.cEntries"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cEntries;
    /// <include file='ACTRL_ACCESSA.xml' path='doc/member[@name="ACTRL_ACCESSA.pPropertyAccessList"]/*'/>
    [NativeTypeName("PACTRL_PROPERTY_ENTRYA")]
    public ACTRL_PROPERTY_ENTRYA* pPropertyAccessList;
}