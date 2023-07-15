// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_CODEINTEGRITY_INFORMATION.xml' path='doc/member[@name="SYSTEM_CODEINTEGRITY_INFORMATION"]/*'/>
public partial struct SYSTEM_CODEINTEGRITY_INFORMATION
{
    /// <include file='SYSTEM_CODEINTEGRITY_INFORMATION.xml' path='doc/member[@name="SYSTEM_CODEINTEGRITY_INFORMATION.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='SYSTEM_CODEINTEGRITY_INFORMATION.xml' path='doc/member[@name="SYSTEM_CODEINTEGRITY_INFORMATION.CodeIntegrityOptions"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CodeIntegrityOptions;
}