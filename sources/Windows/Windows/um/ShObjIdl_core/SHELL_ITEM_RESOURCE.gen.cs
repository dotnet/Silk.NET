// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SHELL_ITEM_RESOURCE.xml' path='doc/member[@name="SHELL_ITEM_RESOURCE"]/*'/>
public unsafe partial struct SHELL_ITEM_RESOURCE
{
    /// <include file='SHELL_ITEM_RESOURCE.xml' path='doc/member[@name="SHELL_ITEM_RESOURCE.guidType"]/*'/>
    public Guid guidType;
    /// <include file='SHELL_ITEM_RESOURCE.xml' path='doc/member[@name="SHELL_ITEM_RESOURCE.szName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort szName[260];
}