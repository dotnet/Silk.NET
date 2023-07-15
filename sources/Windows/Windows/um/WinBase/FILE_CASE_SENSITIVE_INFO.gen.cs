// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_CASE_SENSITIVE_INFO.xml' path='doc/member[@name="FILE_CASE_SENSITIVE_INFO"]/*'/>
public partial struct FILE_CASE_SENSITIVE_INFO
{
    /// <include file='FILE_CASE_SENSITIVE_INFO.xml' path='doc/member[@name="FILE_CASE_SENSITIVE_INFO.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
}