// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTRL_ACCESS_INFOA.xml' path='doc/member[@name="ACTRL_ACCESS_INFOA"]/*' />
public unsafe partial struct ACTRL_ACCESS_INFOA
{
    /// <include file='ACTRL_ACCESS_INFOA.xml' path='doc/member[@name="ACTRL_ACCESS_INFOA.fAccessPermission"]/*' />
    [NativeTypeName("ULONG")]
    public uint fAccessPermission;

    /// <include file='ACTRL_ACCESS_INFOA.xml' path='doc/member[@name="ACTRL_ACCESS_INFOA.lpAccessPermissionName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpAccessPermissionName;
}
