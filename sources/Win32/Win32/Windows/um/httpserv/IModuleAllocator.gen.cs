// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("85C1679C-0B21-491C-AFB5-C7B5C86464C4")]
public unsafe partial struct IModuleAllocator : IModuleAllocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IModuleAllocator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void* AllocateMemory([NativeTypeName("DWORD")] uint cbAllocation)
    {
        return ((delegate* unmanaged<IModuleAllocator*, uint, void*>)((*lpVtbl)[0]))(
            (IModuleAllocator*)Unsafe.AsPointer(ref this),
            cbAllocation
        );
    }

    public interface Interface
    {
        [VtblIndex(0)]
        void* AllocateMemory([NativeTypeName("DWORD")] uint cbAllocation);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void *(DWORD)")]
        public delegate* unmanaged<TSelf*, uint, void*> AllocateMemory;
    }
}
