// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_RESOURCE_DIRECTORY_STRING.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY_STRING"]/*'/>
public unsafe partial struct IMAGE_RESOURCE_DIRECTORY_STRING
{
    /// <include file='IMAGE_RESOURCE_DIRECTORY_STRING.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY_STRING.Length"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Length;
    /// <include file='IMAGE_RESOURCE_DIRECTORY_STRING.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY_STRING.NameString"]/*'/>
    [NativeTypeName("CHAR[1]")]
    public fixed sbyte NameString[1];
}