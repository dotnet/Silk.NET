// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_PROPERTY_ENTRYW.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYW"]/*'/>
public unsafe partial struct ACTRL_PROPERTY_ENTRYW
{
    /// <include file='ACTRL_PROPERTY_ENTRYW.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYW.lpProperty"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpProperty;
    /// <include file='ACTRL_PROPERTY_ENTRYW.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYW.pAccessEntryList"]/*'/>
    [NativeTypeName("PACTRL_ACCESS_ENTRY_LISTW")]
    public ACTRL_ACCESS_ENTRY_LISTW* pAccessEntryList;
    /// <include file='ACTRL_PROPERTY_ENTRYW.xml' path='doc/member[@name="ACTRL_PROPERTY_ENTRYW.fListFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fListFlags;
}