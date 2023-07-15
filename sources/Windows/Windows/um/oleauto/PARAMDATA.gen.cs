// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PARAMDATA.xml' path='doc/member[@name="PARAMDATA"]/*'/>
public unsafe partial struct PARAMDATA
{
    /// <include file='PARAMDATA.xml' path='doc/member[@name="PARAMDATA.szName"]/*'/>
    [NativeTypeName("OLECHAR *")]
    public ushort* szName;
    /// <include file='PARAMDATA.xml' path='doc/member[@name="PARAMDATA.vt"]/*'/>
    [NativeTypeName("VARTYPE")]
    public ushort vt;
}