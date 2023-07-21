// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION"]/*' />
public unsafe partial struct CRITICAL_SECTION
{
    /// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION.DebugInfo"]/*' />
    [NativeTypeName("PRTL_CRITICAL_SECTION_DEBUG")]
    public CRITICAL_SECTION_DEBUG* DebugInfo;

    /// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION.LockCount"]/*' />
    [NativeTypeName("LONG")]
    public int LockCount;

    /// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION.RecursionCount"]/*' />
    [NativeTypeName("LONG")]
    public int RecursionCount;

    /// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION.OwningThread"]/*' />
    public HANDLE OwningThread;

    /// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION.LockSemaphore"]/*' />
    public HANDLE LockSemaphore;

    /// <include file='CRITICAL_SECTION.xml' path='doc/member[@name="CRITICAL_SECTION.SpinCount"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint SpinCount;
}
