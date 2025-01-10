// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D9A5DE00-3346-4599-9826-FE88565E1226")]
public unsafe partial struct IHttpConnection : IHttpConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpConnection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsConnected()
    {
        return ((delegate* unmanaged<IHttpConnection*, int>)((*lpVtbl)[0]))(
            (IHttpConnection*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public void* AllocateMemory([NativeTypeName("DWORD")] uint cbAllocation)
    {
        return ((delegate* unmanaged<IHttpConnection*, uint, void*>)((*lpVtbl)[1]))(
            (IHttpConnection*)Unsafe.AsPointer(ref this),
            cbAllocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpConnectionModuleContextContainer* GetModuleContextContainer()
    {
        return (
            (delegate* unmanaged<IHttpConnection*, IHttpConnectionModuleContextContainer*>)(
                (*lpVtbl)[2]
            )
        )((IHttpConnection*)Unsafe.AsPointer(ref this));
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsConnected();

        [VtblIndex(1)]
        void* AllocateMemory([NativeTypeName("DWORD")] uint cbAllocation);

        [VtblIndex(2)]
        IHttpConnectionModuleContextContainer* GetModuleContextContainer();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> IsConnected;

        [NativeTypeName("void *(DWORD)")]
        public delegate* unmanaged<TSelf*, uint, void*> AllocateMemory;

        [NativeTypeName("IHttpConnectionModuleContextContainer *()")]
        public delegate* unmanaged<
            TSelf*,
            IHttpConnectionModuleContextContainer*> GetModuleContextContainer;
    }
}
