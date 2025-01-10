// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6DFC60FB-F2E9-459B-BEB5-288F1A7C7D54")]
[NativeTypeName("struct ISortColumnArray : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISortColumnArray : ISortColumnArray.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISortColumnArray));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISortColumnArray, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISortColumnArray, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISortColumnArray, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount(uint* columnCount)
    {
        return ((delegate* unmanaged<ISortColumnArray, uint*, int>)((*lpVtbl)[3]))(
            this,
            columnCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt(uint index, SORTCOLUMN* sortcolumn)
    {
        return ((delegate* unmanaged<ISortColumnArray, uint, SORTCOLUMN*, int>)((*lpVtbl)[4]))(
            this,
            index,
            sortcolumn
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSortType([NativeTypeName("enum SORT_ORDER_TYPE *")] SORT_ORDER_TYPE* type)
    {
        return ((delegate* unmanaged<ISortColumnArray, SORT_ORDER_TYPE*, int>)((*lpVtbl)[5]))(
            this,
            type
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount(uint* columnCount);

        [VtblIndex(4)]
        HRESULT GetAt(uint index, SORTCOLUMN* sortcolumn);

        [VtblIndex(5)]
        HRESULT GetSortType([NativeTypeName("enum SORT_ORDER_TYPE *")] SORT_ORDER_TYPE* type);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, SORTCOLUMN *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SORTCOLUMN*, int> GetAt;

        [NativeTypeName("HRESULT (enum SORT_ORDER_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SORT_ORDER_TYPE*, int> GetSortType;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISortColumnArray"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISortColumnArray(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISortColumnArray"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISortColumnArray(Silk.NET.Windows.IUnknown value)
    {
        return new ISortColumnArray(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISortColumnArray"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISortColumnArray"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISortColumnArray value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
