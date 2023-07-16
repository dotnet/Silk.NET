// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_RESOURCE_DIR_STRING_U.xml' path='doc/member[@name="IMAGE_RESOURCE_DIR_STRING_U"]/*'/>
public unsafe partial struct IMAGE_RESOURCE_DIR_STRING_U
{
    /// <include file='IMAGE_RESOURCE_DIR_STRING_U.xml' path='doc/member[@name="IMAGE_RESOURCE_DIR_STRING_U.Length"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Length;
    /// <include file='IMAGE_RESOURCE_DIR_STRING_U.xml' path='doc/member[@name="IMAGE_RESOURCE_DIR_STRING_U.NameString"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort NameString[1];
}