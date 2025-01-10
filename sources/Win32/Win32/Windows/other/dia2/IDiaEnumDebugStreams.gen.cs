// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
[NativeTypeName("struct IDiaEnumDebugStreams : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumDebugStreams : IDiaEnumDebugStreams.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumDebugStreams));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreams, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaEnumDebugStreams, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreams, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreams, IUnknown*, int>)((*lpVtbl)[3]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreams, int*, int>)((*lpVtbl)[4]))(
            this,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item(VARIANT index, IDiaEnumDebugStreamData* stream)
    {
        return (
            (delegate* unmanaged<IDiaEnumDebugStreams, VARIANT, IDiaEnumDebugStreamData*, int>)(
                (*lpVtbl)[5]
            )
        )(this, index, stream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next(
        [NativeTypeName("ULONG")] uint celt,
        IDiaEnumDebugStreamData* rgelt,
        [NativeTypeName("ULONG *")] uint* pceltFetched
    )
    {
        return (
            (delegate* unmanaged<IDiaEnumDebugStreams, uint, IDiaEnumDebugStreamData*, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, celt, rgelt, pceltFetched);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreams, uint, int>)((*lpVtbl)[7]))(this, celt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumDebugStreams, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumDebugStreams* ppenum)
    {
        return (
            (delegate* unmanaged<IDiaEnumDebugStreams, IDiaEnumDebugStreams*, int>)((*lpVtbl)[9])
        )(this, ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown* pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item(VARIANT index, IDiaEnumDebugStreamData* stream);

        [VtblIndex(6)]
        HRESULT Next(
            [NativeTypeName("ULONG")] uint celt,
            IDiaEnumDebugStreamData* rgelt,
            [NativeTypeName("ULONG *")] uint* pceltFetched
        );

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumDebugStreams* ppenum);
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

        [NativeTypeName("HRESULT (VARIANT, IDiaEnumDebugStreamData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IDiaEnumDebugStreamData*, int> Item;

        [NativeTypeName(
            "HRESULT (ULONG, IDiaEnumDebugStreamData **, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDiaEnumDebugStreamData*, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumDebugStreams **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumDebugStreams*, int> Clone;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaEnumDebugStreams"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaEnumDebugStreams(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaEnumDebugStreams"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaEnumDebugStreams(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaEnumDebugStreams(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaEnumDebugStreams"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaEnumDebugStreams"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaEnumDebugStreams value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
