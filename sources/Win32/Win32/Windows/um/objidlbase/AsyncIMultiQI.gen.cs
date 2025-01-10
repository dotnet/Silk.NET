// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000E0020-0000-0000-C000-000000000046")]
[NativeTypeName("struct AsyncIMultiQI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct AsyncIMultiQI : AsyncIMultiQI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AsyncIMultiQI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<AsyncIMultiQI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<AsyncIMultiQI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<AsyncIMultiQI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Begin_QueryMultipleInterfaces(
        [NativeTypeName("ULONG")] uint cMQIs,
        MULTI_QI* pMQIs
    )
    {
        return ((delegate* unmanaged<AsyncIMultiQI, uint, MULTI_QI*, int>)((*lpVtbl)[3]))(
            this,
            cMQIs,
            pMQIs
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Finish_QueryMultipleInterfaces(MULTI_QI* pMQIs)
    {
        return ((delegate* unmanaged<AsyncIMultiQI, MULTI_QI*, int>)((*lpVtbl)[4]))(this, pMQIs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Begin_QueryMultipleInterfaces(
            [NativeTypeName("ULONG")] uint cMQIs,
            MULTI_QI* pMQIs
        );

        [VtblIndex(4)]
        HRESULT Finish_QueryMultipleInterfaces(MULTI_QI* pMQIs);
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

        [NativeTypeName("HRESULT (ULONG, MULTI_QI *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MULTI_QI*, int> Begin_QueryMultipleInterfaces;

        [NativeTypeName("HRESULT (MULTI_QI *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MULTI_QI*, int> Finish_QueryMultipleInterfaces;
    }

    /// <summary>Initializes a new instance of the <see cref = "AsyncIMultiQI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public AsyncIMultiQI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "AsyncIMultiQI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator AsyncIMultiQI(Silk.NET.Windows.IUnknown value)
    {
        return new AsyncIMultiQI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "AsyncIMultiQI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "AsyncIMultiQI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(AsyncIMultiQI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
