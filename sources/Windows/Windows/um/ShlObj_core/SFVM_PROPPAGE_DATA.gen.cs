// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SFVM_PROPPAGE_DATA.xml' path='doc/member[@name="SFVM_PROPPAGE_DATA"]/*'/>
public unsafe partial struct SFVM_PROPPAGE_DATA
{
    /// <include file='SFVM_PROPPAGE_DATA.xml' path='doc/member[@name="SFVM_PROPPAGE_DATA.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='SFVM_PROPPAGE_DATA.xml' path='doc/member[@name="SFVM_PROPPAGE_DATA.pfn"]/*'/>
    [NativeTypeName("LPFNADDPROPSHEETPAGE")]
    public delegate* unmanaged<HPROPSHEETPAGE, LPARAM, BOOL> pfn;
    /// <include file='SFVM_PROPPAGE_DATA.xml' path='doc/member[@name="SFVM_PROPPAGE_DATA.lParam"]/*'/>
    public LPARAM lParam;
}