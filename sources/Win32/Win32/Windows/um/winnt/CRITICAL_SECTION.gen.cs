// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRITICAL_SECTION
{
    [NativeTypeName("PRTL_CRITICAL_SECTION_DEBUG")]
    public CRITICAL_SECTION_DEBUG* DebugInfo;

    [NativeTypeName("LONG")]
    public int LockCount;

    [NativeTypeName("LONG")]
    public int RecursionCount;
    public HANDLE OwningThread;
    public HANDLE LockSemaphore;

    [NativeTypeName("ULONG_PTR")]
    public nuint SpinCount;
}
