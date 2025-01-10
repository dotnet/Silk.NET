// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SYSTEM_THREAD_INFORMATION
{
    [NativeTypeName("LARGE_INTEGER[3]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [NativeTypeName("ULONG")]
    public uint Reserved2;

    [NativeTypeName("PVOID")]
    public void* StartAddress;
    public CLIENT_ID ClientId;

    [NativeTypeName("KPRIORITY")]
    public int Priority;

    [NativeTypeName("LONG")]
    public int BasePriority;

    [NativeTypeName("ULONG")]
    public uint Reserved3;

    [NativeTypeName("ULONG")]
    public uint ThreadState;

    [NativeTypeName("ULONG")]
    public uint WaitReason;

    [InlineArray(3)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
    }
}
