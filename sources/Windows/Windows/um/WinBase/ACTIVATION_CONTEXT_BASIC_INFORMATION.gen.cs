// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTIVATION_CONTEXT_BASIC_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_BASIC_INFORMATION"]/*'/>
public partial struct ACTIVATION_CONTEXT_BASIC_INFORMATION
{
    /// <include file='ACTIVATION_CONTEXT_BASIC_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_BASIC_INFORMATION.hActCtx"]/*'/>
    public HANDLE hActCtx;
    /// <include file='ACTIVATION_CONTEXT_BASIC_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_BASIC_INFORMATION.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}