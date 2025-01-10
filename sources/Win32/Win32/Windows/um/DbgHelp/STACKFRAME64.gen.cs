// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct STACKFRAME64
{
    public ADDRESS64 AddrPC;
    public ADDRESS64 AddrReturn;
    public ADDRESS64 AddrFrame;
    public ADDRESS64 AddrStack;
    public ADDRESS64 AddrBStore;

    [NativeTypeName("PVOID")]
    public void* FuncTableEntry;

    [NativeTypeName("DWORD64[4]")]
    public _Params_e__FixedBuffer Params;
    public BOOL Far;
    public BOOL Virtual;

    [NativeTypeName("DWORD64[3]")]
    public _Reserved_e__FixedBuffer Reserved;
    public KDHELP64 KdHelp;

    [InlineArray(4)]
    public partial struct _Params_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }
}
