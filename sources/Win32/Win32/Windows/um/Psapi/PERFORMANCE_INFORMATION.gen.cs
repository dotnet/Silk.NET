// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct PERFORMANCE_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint cb;

    [NativeTypeName("SIZE_T")]
    public nuint CommitTotal;

    [NativeTypeName("SIZE_T")]
    public nuint CommitLimit;

    [NativeTypeName("SIZE_T")]
    public nuint CommitPeak;

    [NativeTypeName("SIZE_T")]
    public nuint PhysicalTotal;

    [NativeTypeName("SIZE_T")]
    public nuint PhysicalAvailable;

    [NativeTypeName("SIZE_T")]
    public nuint SystemCache;

    [NativeTypeName("SIZE_T")]
    public nuint KernelTotal;

    [NativeTypeName("SIZE_T")]
    public nuint KernelPaged;

    [NativeTypeName("SIZE_T")]
    public nuint KernelNonpaged;

    [NativeTypeName("SIZE_T")]
    public nuint PageSize;

    [NativeTypeName("DWORD")]
    public uint HandleCount;

    [NativeTypeName("DWORD")]
    public uint ProcessCount;

    [NativeTypeName("DWORD")]
    public uint ThreadCount;
}
