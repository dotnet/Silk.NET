// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY"]/*'/>
public partial struct IMAGE_FUNCTION_ENTRY
{
    /// <include file='IMAGE_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY.StartingAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StartingAddress;
    /// <include file='IMAGE_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY.EndingAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EndingAddress;
    /// <include file='IMAGE_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_FUNCTION_ENTRY.EndOfPrologue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EndOfPrologue;
}