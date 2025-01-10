// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct JOBOBJECT_BASIC_PROCESS_ID_LIST
{
    [NativeTypeName("DWORD")]
    public uint NumberOfAssignedProcesses;

    [NativeTypeName("DWORD")]
    public uint NumberOfProcessIdsInList;

    [NativeTypeName("ULONG_PTR[1]")]
    public _ProcessIdList_e__FixedBuffer ProcessIdList;

    public partial struct _ProcessIdList_e__FixedBuffer
    {
        public nuint e0;

        [UnscopedRef]
        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<nuint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
