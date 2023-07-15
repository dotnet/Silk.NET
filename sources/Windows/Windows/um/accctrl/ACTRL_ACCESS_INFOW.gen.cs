// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_ACCESS_INFOW.xml' path='doc/member[@name="ACTRL_ACCESS_INFOW"]/*'/>
public unsafe partial struct ACTRL_ACCESS_INFOW
{
    /// <include file='ACTRL_ACCESS_INFOW.xml' path='doc/member[@name="ACTRL_ACCESS_INFOW.fAccessPermission"]/*'/>
    [NativeTypeName("ULONG")]
    public uint fAccessPermission;
    /// <include file='ACTRL_ACCESS_INFOW.xml' path='doc/member[@name="ACTRL_ACCESS_INFOW.lpAccessPermissionName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpAccessPermissionName;
}