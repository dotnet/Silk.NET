// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SRWLOCK.xml' path='doc/member[@name="SRWLOCK"]/*'/>
public unsafe partial struct SRWLOCK
{
    /// <include file='SRWLOCK.xml' path='doc/member[@name="SRWLOCK.Ptr"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Ptr;
}