// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
[NativeTypeName("struct IDiaStackWalkFrame : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaStackWalkFrame : IDiaStackWalkFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaStackWalkFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaStackWalkFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaStackWalkFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaStackWalkFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_registerValue(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("ULONGLONG *")] ulong* pRetVal
    )
    {
        return ((delegate* unmanaged<IDiaStackWalkFrame, uint, ulong*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDiaStackWalkFrame, uint, ulong, int>)((*lpVtbl)[4]))(
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
                IDiaStackWalkFrame,
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
            (delegate* unmanaged<IDiaStackWalkFrame, IDiaFrameData, ulong*, int>)((*lpVtbl)[6])
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
            (delegate* unmanaged<IDiaStackWalkFrame, IDiaFrameData, ulong, ulong*, int>)(
                (*lpVtbl)[7]
            )
        )(this, frame, startAddress, returnAddress);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaStackWalkFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaStackWalkFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaStackWalkFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaStackWalkFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaStackWalkFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaStackWalkFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaStackWalkFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaStackWalkFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
