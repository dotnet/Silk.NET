// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("77E425FC-CBF9-4307-BA6A-BB5727745661")]
[NativeTypeName("struct IDeskBandInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeskBandInfo : IDeskBandInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeskBandInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDeskBandInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDeskBandInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeskBandInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDefaultBandWidth(
        [NativeTypeName("DWORD")] uint dwBandID,
        [NativeTypeName("DWORD")] uint dwViewMode,
        int* pnWidth
    )
    {
        return ((delegate* unmanaged<IDeskBandInfo, uint, uint, int*, int>)((*lpVtbl)[3]))(
            this,
            dwBandID,
            dwViewMode,
            pnWidth
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDefaultBandWidth(
            [NativeTypeName("DWORD")] uint dwBandID,
            [NativeTypeName("DWORD")] uint dwViewMode,
            int* pnWidth
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

        [NativeTypeName("HRESULT (DWORD, DWORD, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int*, int> GetDefaultBandWidth;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeskBandInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeskBandInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeskBandInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeskBandInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IDeskBandInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeskBandInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeskBandInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeskBandInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
