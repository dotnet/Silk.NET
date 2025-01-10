// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct KNONVOLATILE_CONTEXT_POINTERS_ARM64
{
    [NativeTypeName("PDWORD64")]
    public ulong* X19;

    [NativeTypeName("PDWORD64")]
    public ulong* X20;

    [NativeTypeName("PDWORD64")]
    public ulong* X21;

    [NativeTypeName("PDWORD64")]
    public ulong* X22;

    [NativeTypeName("PDWORD64")]
    public ulong* X23;

    [NativeTypeName("PDWORD64")]
    public ulong* X24;

    [NativeTypeName("PDWORD64")]
    public ulong* X25;

    [NativeTypeName("PDWORD64")]
    public ulong* X26;

    [NativeTypeName("PDWORD64")]
    public ulong* X27;

    [NativeTypeName("PDWORD64")]
    public ulong* X28;

    [NativeTypeName("PDWORD64")]
    public ulong* Fp;

    [NativeTypeName("PDWORD64")]
    public ulong* Lr;

    [NativeTypeName("PDWORD64")]
    public ulong* D8;

    [NativeTypeName("PDWORD64")]
    public ulong* D9;

    [NativeTypeName("PDWORD64")]
    public ulong* D10;

    [NativeTypeName("PDWORD64")]
    public ulong* D11;

    [NativeTypeName("PDWORD64")]
    public ulong* D12;

    [NativeTypeName("PDWORD64")]
    public ulong* D13;

    [NativeTypeName("PDWORD64")]
    public ulong* D14;

    [NativeTypeName("PDWORD64")]
    public ulong* D15;
}
