// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_NT_HEADERS64.xml' path='doc/member[@name="IMAGE_NT_HEADERS64"]/*'/>
public partial struct IMAGE_NT_HEADERS64
{
    /// <include file='IMAGE_NT_HEADERS64.xml' path='doc/member[@name="IMAGE_NT_HEADERS64.Signature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Signature;
    /// <include file='IMAGE_NT_HEADERS64.xml' path='doc/member[@name="IMAGE_NT_HEADERS64.FileHeader"]/*'/>
    public IMAGE_FILE_HEADER FileHeader;
    /// <include file='IMAGE_NT_HEADERS64.xml' path='doc/member[@name="IMAGE_NT_HEADERS64.OptionalHeader"]/*'/>
    public IMAGE_OPTIONAL_HEADER64 OptionalHeader;
}