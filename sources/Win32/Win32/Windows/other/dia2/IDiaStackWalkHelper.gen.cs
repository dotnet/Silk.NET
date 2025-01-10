// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("21F81B1B-C5BB-42A3-BC4F-CCBAA75B9F19")]
[NativeTypeName("struct IDiaStackWalkHelper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaStackWalkHelper : IDiaStackWalkHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaStackWalkHelper));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaStackWalkHelper, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_registerValue(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("ULONGLONG *")] ulong* pRetVal
    )
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, uint, ulong*, int>)((*lpVtbl)[3]))(
            this,
            index,
            pRetVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_registerValue(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("ULONGLONG")] ulong NewVal
    )
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, uint, ulong, int>)((*lpVtbl)[4]))(
            this,
            index,
            NewVal
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT readMemory(
        [NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type,
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        byte* pbData
    )
    {
        return (
            (delegate* unmanaged<
                IDiaStackWalkHelper,
                MemoryTypeEnum,
                ulong,
                uint,
                uint*,
                byte*,
                int>)((*lpVtbl)[5])
        )(this, type, va, cbData, pcbData, pbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT searchForReturnAddress(
        IDiaFrameData frame,
        [NativeTypeName("ULONGLONG *")] ulong* returnAddress
    )
    {
        return (
            (delegate* unmanaged<IDiaStackWalkHelper, IDiaFrameData, ulong*, int>)((*lpVtbl)[6])
        )(this, frame, returnAddress);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT searchForReturnAddressStart(
        IDiaFrameData frame,
        [NativeTypeName("ULONGLONG")] ulong startAddress,
        [NativeTypeName("ULONGLONG *")] ulong* returnAddress
    )
    {
        return (
            (delegate* unmanaged<IDiaStackWalkHelper, IDiaFrameData, ulong, ulong*, int>)(
                (*lpVtbl)[7]
            )
        )(this, frame, startAddress, returnAddress);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT frameForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaFrameData* ppFrame)
    {
        return (
            (delegate* unmanaged<IDiaStackWalkHelper, ulong, IDiaFrameData*, int>)((*lpVtbl)[8])
        )(this, va, ppFrame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT symbolForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaSymbol* ppSymbol)
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, ulong, IDiaSymbol*, int>)((*lpVtbl)[9]))(
            this,
            va,
            ppSymbol
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT pdataForVA(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD")] uint cbData,
        [NativeTypeName("DWORD *")] uint* pcbData,
        byte* pbData
    )
    {
        return (
            (delegate* unmanaged<IDiaStackWalkHelper, ulong, uint, uint*, byte*, int>)(
                (*lpVtbl)[10]
            )
        )(this, va, cbData, pcbData, pbData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT imageForVA(
        [NativeTypeName("ULONGLONG")] ulong vaContext,
        [NativeTypeName("ULONGLONG *")] ulong* pvaImageStart
    )
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, ulong, ulong*, int>)((*lpVtbl)[11]))(
            this,
            vaContext,
            pvaImageStart
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT addressForVA(
        [NativeTypeName("ULONGLONG")] ulong va,
        [NativeTypeName("DWORD *")] uint* pISect,
        [NativeTypeName("DWORD *")] uint* pOffset
    )
    {
        return (
            (delegate* unmanaged<IDiaStackWalkHelper, ulong, uint*, uint*, int>)((*lpVtbl)[12])
        )(this, va, pISect, pOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT numberOfFunctionFragmentsForVA(
        [NativeTypeName("ULONGLONG")] ulong vaFunc,
        [NativeTypeName("DWORD")] uint cbFunc,
        [NativeTypeName("DWORD *")] uint* pNumFragments
    )
    {
        return ((delegate* unmanaged<IDiaStackWalkHelper, ulong, uint, uint*, int>)((*lpVtbl)[13]))(
            this,
            vaFunc,
            cbFunc,
            pNumFragments
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT functionFragmentsForVA(
        [NativeTypeName("ULONGLONG")] ulong vaFunc,
        [NativeTypeName("DWORD")] uint cbFunc,
        [NativeTypeName("DWORD")] uint cFragments,
        [NativeTypeName("ULONGLONG *")] ulong* pVaFragment,
        [NativeTypeName("DWORD *")] uint* pLenFragment
    )
    {
        return (
            (delegate* unmanaged<IDiaStackWalkHelper, ulong, uint, uint, ulong*, uint*, int>)(
                (*lpVtbl)[14]
            )
        )(this, vaFunc, cbFunc, cFragments, pVaFragment, pLenFragment);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_registerValue(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("ULONGLONG *")] ulong* pRetVal
        );

        [VtblIndex(4)]
        HRESULT put_registerValue(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("ULONGLONG")] ulong NewVal
        );

        [VtblIndex(5)]
        HRESULT readMemory(
            [NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type,
            [NativeTypeName("ULONGLONG")] ulong va,
            [NativeTypeName("DWORD")] uint cbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            byte* pbData
        );

        [VtblIndex(6)]
        HRESULT searchForReturnAddress(
            IDiaFrameData frame,
            [NativeTypeName("ULONGLONG *")] ulong* returnAddress
        );

        [VtblIndex(7)]
        HRESULT searchForReturnAddressStart(
            IDiaFrameData frame,
            [NativeTypeName("ULONGLONG")] ulong startAddress,
            [NativeTypeName("ULONGLONG *")] ulong* returnAddress
        );

        [VtblIndex(8)]
        HRESULT frameForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaFrameData* ppFrame);

        [VtblIndex(9)]
        HRESULT symbolForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaSymbol* ppSymbol);

        [VtblIndex(10)]
        HRESULT pdataForVA(
            [NativeTypeName("ULONGLONG")] ulong va,
            [NativeTypeName("DWORD")] uint cbData,
            [NativeTypeName("DWORD *")] uint* pcbData,
            byte* pbData
        );

        [VtblIndex(11)]
        HRESULT imageForVA(
            [NativeTypeName("ULONGLONG")] ulong vaContext,
            [NativeTypeName("ULONGLONG *")] ulong* pvaImageStart
        );

        [VtblIndex(12)]
        HRESULT addressForVA(
            [NativeTypeName("ULONGLONG")] ulong va,
            [NativeTypeName("DWORD *")] uint* pISect,
            [NativeTypeName("DWORD *")] uint* pOffset
        );

        [VtblIndex(13)]
        HRESULT numberOfFunctionFragmentsForVA(
            [NativeTypeName("ULONGLONG")] ulong vaFunc,
            [NativeTypeName("DWORD")] uint cbFunc,
            [NativeTypeName("DWORD *")] uint* pNumFragments
        );

        [VtblIndex(14)]
        HRESULT functionFragmentsForVA(
            [NativeTypeName("ULONGLONG")] ulong vaFunc,
            [NativeTypeName("DWORD")] uint cbFunc,
            [NativeTypeName("DWORD")] uint cFragments,
            [NativeTypeName("ULONGLONG *")] ulong* pVaFragment,
            [NativeTypeName("DWORD *")] uint* pLenFragment
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

        [NativeTypeName("HRESULT (DWORD, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong*, int> get_registerValue;

        [NativeTypeName("HRESULT (DWORD, ULONGLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong, int> put_registerValue;

        [NativeTypeName(
            "HRESULT (enum MemoryTypeEnum, ULONGLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MemoryTypeEnum,
            ulong,
            uint,
            uint*,
            byte*,
            int> readMemory;

        [NativeTypeName("HRESULT (IDiaFrameData *, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaFrameData, ulong*, int> searchForReturnAddress;

        [NativeTypeName(
            "HRESULT (IDiaFrameData *, ULONGLONG, ULONGLONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDiaFrameData,
            ulong,
            ulong*,
            int> searchForReturnAddressStart;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, IDiaFrameData*, int> frameForVA;

        [NativeTypeName("HRESULT (ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, IDiaSymbol*, int> symbolForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint*, byte*, int> pdataForVA;

        [NativeTypeName("HRESULT (ULONGLONG, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, ulong*, int> imageForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint*, uint*, int> addressForVA;

        [NativeTypeName("HRESULT (ULONGLONG, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, uint, uint*, int> numberOfFunctionFragmentsForVA;

        [NativeTypeName(
            "HRESULT (ULONGLONG, DWORD, DWORD, ULONGLONG *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            uint,
            uint,
            ulong*,
            uint*,
            int> functionFragmentsForVA;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaStackWalkHelper"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaStackWalkHelper(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaStackWalkHelper"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaStackWalkHelper(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaStackWalkHelper(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaStackWalkHelper"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaStackWalkHelper"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaStackWalkHelper value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
