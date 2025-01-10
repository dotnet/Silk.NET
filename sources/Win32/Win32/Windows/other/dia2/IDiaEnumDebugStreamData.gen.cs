// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("486943E8-D187-4A6B-A3C4-291259FFF60D")]
[NativeTypeName("struct IDiaEnumDebugStreamData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumDebugStreamData
    : IDiaEnumDebugStreamData.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumDebugStreamData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, IUnknown*, int>)((*lpVtbl)[3]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, int*, int>)((*lpVtbl)[4]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, ushort**, int>)((*lpVtbl)[5]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Item(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        byte* pbData
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumDebugStreamData, uint, uint, uint*, byte*, int>)(
                (*lpVtbl)[6]
            )
        )(this, index, cbData, pcbData, pbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint celt,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        byte* pbData,
        [NativeTypeName("ULONG *")] uint* pceltFetched
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumDebugStreamData, uint, uint, uint*, byte*, uint*, int>)(
                (*lpVtbl)[7]
            )
        )(this, celt, cbData, pcbData, pbData, pceltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, uint, int>)((*lpVtbl)[8]))(
            this,
            celt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreamData, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Clone(IDiaEnumDebugStreamData* ppenum)
    {
        return (
            (delegate* unmanaged<IDiaEnumDebugStreamData, IDiaEnumDebugStreamData*, int>)(
                (*lpVtbl)[10]
            )
        )(this, ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown* pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(6)]
        HRESULT Item(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("DWORD")] uint cbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            byte* pbData
        );

        [VtblIndex(7)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint celt,
            [NativeTypeName("DWORD")] uint cbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            byte* pbData,
            [NativeTypeName("ULONG *")] uint* pceltFetched
        );

        [VtblIndex(8)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(9)]
        HRESULT Reset();

        [VtblIndex(10)]
        HRESULT Clone(IDiaEnumDebugStreamData* ppenum);
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get__NewEnum;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, byte*, int> Item;

        [NativeTypeName(
            "HRESULT (ULONG, DWORD, DWORD *, BYTE *, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, byte*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumDebugStreamData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumDebugStreamData*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaEnumDebugStreamData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaEnumDebugStreamData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaEnumDebugStreamData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaEnumDebugStreamData(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaEnumDebugStreamData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaEnumDebugStreamData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaEnumDebugStreamData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaEnumDebugStreamData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
