// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct UNWIND_HISTORY_TABLE
{
    [NativeTypeName("DWORD")]
    public uint Count;
    public byte LocalHint;
    public byte GlobalHint;
    public byte Search;
    public byte Once;

    [NativeTypeName("ULONG_PTR")]
    public nuint LowAddress;

    [NativeTypeName("ULONG_PTR")]
    public nuint HighAddress;

    [NativeTypeName("UNWIND_HISTORY_TABLE_ENTRY[12]")]
    public _Entry_e__FixedBuffer Entry;

    [InlineArray(12)]
    public partial struct _Entry_e__FixedBuffer
    {
        public UNWIND_HISTORY_TABLE_ENTRY e0;
    }
}
