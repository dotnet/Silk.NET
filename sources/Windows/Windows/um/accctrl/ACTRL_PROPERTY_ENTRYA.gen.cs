// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACTRL_PROPERTY_ENTRYA.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYA"]/*'/>
public unsafe partial struct ACTRL_PROPERTY_ENTRYA
{
    /// <include file='ACTRL_PROPERTY_ENTRYA.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYA.lpProperty"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpProperty;
    /// <include file='ACTRL_PROPERTY_ENTRYA.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYA.pAccessEntryList"]/*'/>
    [NativeTypeName("PACTRL_ACCESS_ENTRY_LISTA")]
    public ACTRL_ACCESS_ENTRY_LISTA* pAccessEntryList;
    /// <include file='ACTRL_PROPERTY_ENTRYA.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYA.fListFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fListFlags;
}