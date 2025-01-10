// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000016-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMessageFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMessageFilter : IMessageFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMessageFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMessageFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMessageFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint HandleInComingCall(
        [NativeTypeName("DWORD")] uint dwCallType,
        HTASK htaskCaller,
        [NativeTypeName("DWORD")] uint dwTickCount,
        [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo
    )
    {
        return (
            (delegate* unmanaged<IMessageFilter, uint, HTASK, uint, INTERFACEINFO*, uint>)(
                (*lpVtbl)[3]
            )
        )(this, dwCallType, htaskCaller, dwTickCount, lpInterfaceInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("DWORD")]
    public uint RetryRejectedCall(
        HTASK htaskCallee,
        [NativeTypeName("DWORD")] uint dwTickCount,
        [NativeTypeName("DWORD")] uint dwRejectType
    )
    {
        return ((delegate* unmanaged<IMessageFilter, HTASK, uint, uint, uint>)((*lpVtbl)[4]))(
            this,
            htaskCallee,
            dwTickCount,
            dwRejectType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("DWORD")]
    public uint MessagePending(
        HTASK htaskCallee,
        [NativeTypeName("DWORD")] uint dwTickCount,
        [NativeTypeName("DWORD")] uint dwPendingType
    )
    {
        return ((delegate* unmanaged<IMessageFilter, HTASK, uint, uint, uint>)((*lpVtbl)[5]))(
            this,
            htaskCallee,
            dwTickCount,
            dwPendingType
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint HandleInComingCall(
            [NativeTypeName("DWORD")] uint dwCallType,
            HTASK htaskCaller,
            [NativeTypeName("DWORD")] uint dwTickCount,
            [NativeTypeName("LPINTERFACEINFO")] INTERFACEINFO* lpInterfaceInfo
        );

        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        uint RetryRejectedCall(
            HTASK htaskCallee,
            [NativeTypeName("DWORD")] uint dwTickCount,
            [NativeTypeName("DWORD")] uint dwRejectType
        );

        [VtblIndex(5)]
        [return: NativeTypeName("DWORD")]
        uint MessagePending(
            HTASK htaskCallee,
            [NativeTypeName("DWORD")] uint dwTickCount,
            [NativeTypeName("DWORD")] uint dwPendingType
        );
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("DWORD (DWORD, HTASK, DWORD, LPINTERFACEINFO) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            HTASK,
            uint,
            INTERFACEINFO*,
            uint> HandleInComingCall;

        [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HTASK, uint, uint, uint> RetryRejectedCall;

        [NativeTypeName("DWORD (HTASK, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HTASK, uint, uint, uint> MessagePending;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMessageFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMessageFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMessageFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMessageFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IMessageFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMessageFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
