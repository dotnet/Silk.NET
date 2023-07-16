// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TP_POOL_STACK_INFORMATION.xml' path='doc/member[@name="TP_POOL_STACK_INFORMATION"]/*'/>
public partial struct TP_POOL_STACK_INFORMATION
{
    /// <include file='TP_POOL_STACK_INFORMATION.xml' path='doc/member[@name="TP_POOL_STACK_INFORMATION.StackReserve"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint StackReserve;
    /// <include file='TP_POOL_STACK_INFORMATION.xml' path='doc/member[@name="TP_POOL_STACK_INFORMATION.StackCommit"]/*'/>
    [NativeTypeName("SIZE_T")]
    public nuint StackCommit;
}