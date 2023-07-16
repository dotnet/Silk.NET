// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REDIRECTION_DESCRIPTOR.xml' path='doc/member[@name="REDIRECTION_DESCRIPTOR"]/*'/>
public unsafe partial struct REDIRECTION_DESCRIPTOR
{
    /// <include file='REDIRECTION_DESCRIPTOR.xml' path='doc/member[@name="REDIRECTION_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Version;
    /// <include file='REDIRECTION_DESCRIPTOR.xml' path='doc/member[@name="REDIRECTION_DESCRIPTOR.FunctionCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint FunctionCount;
    /// <include file='REDIRECTION_DESCRIPTOR.xml' path='doc/member[@name="REDIRECTION_DESCRIPTOR.Redirections"]/*'/>
    [NativeTypeName("PCREDIRECTION_FUNCTION_DESCRIPTOR")]
    public REDIRECTION_FUNCTION_DESCRIPTOR* Redirections;
}