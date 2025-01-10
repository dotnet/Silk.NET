// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct JOBOBJECT_BASIC_LIMIT_INFORMATION
{
    public LARGE_INTEGER PerProcessUserTimeLimit;
    public LARGE_INTEGER PerJobUserTimeLimit;

    [NativeTypeName("DWORD")]
    public uint LimitFlags;

    [NativeTypeName("SIZE_T")]
    public nuint MinimumWorkingSetSize;

    [NativeTypeName("SIZE_T")]
    public nuint MaximumWorkingSetSize;

    [NativeTypeName("DWORD")]
    public uint ActiveProcessLimit;

    [NativeTypeName("ULONG_PTR")]
    public nuint Affinity;

    [NativeTypeName("DWORD")]
    public uint PriorityClass;

    [NativeTypeName("DWORD")]
    public uint SchedulingClass;
}
