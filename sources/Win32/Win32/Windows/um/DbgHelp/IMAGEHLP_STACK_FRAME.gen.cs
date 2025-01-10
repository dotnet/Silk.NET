// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGEHLP_STACK_FRAME
{
    [NativeTypeName("ULONG64")]
    public ulong InstructionOffset;

    [NativeTypeName("ULONG64")]
    public ulong ReturnOffset;

    [NativeTypeName("ULONG64")]
    public ulong FrameOffset;

    [NativeTypeName("ULONG64")]
    public ulong StackOffset;

    [NativeTypeName("ULONG64")]
    public ulong BackingStoreOffset;

    [NativeTypeName("ULONG64")]
    public ulong FuncTableEntry;

    [NativeTypeName("ULONG64[4]")]
    public _Params_e__FixedBuffer Params;

    [NativeTypeName("ULONG64[5]")]
    public _Reserved_e__FixedBuffer Reserved;
    public BOOL Virtual;

    [NativeTypeName("ULONG")]
    public uint Reserved2;

    [InlineArray(4)]
    public partial struct _Params_e__FixedBuffer
    {
        public ulong e0;
    }

    [InlineArray(5)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }
}
