// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("187AEB13-AAF5-4C59-876D-E059088C0DF8")]
[NativeTypeName("struct IDirect3D9ExOverlayExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3D9ExOverlayExtension
    : IDirect3D9ExOverlayExtension.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3D9ExOverlayExtension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirect3D9ExOverlayExtension, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirect3D9ExOverlayExtension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3D9ExOverlayExtension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckDeviceOverlayType(
        uint Adapter,
        D3DDEVTYPE DevType,
        uint OverlayWidth,
        uint OverlayHeight,
        D3DFORMAT OverlayFormat,
        D3DDISPLAYMODEEX* pDisplayMode,
        D3DDISPLAYROTATION DisplayRotation,
        D3DOVERLAYCAPS* pOverlayCaps
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3D9ExOverlayExtension,
                uint,
                D3DDEVTYPE,
                uint,
                uint,
                D3DFORMAT,
                D3DDISPLAYMODEEX*,
                D3DDISPLAYROTATION,
                D3DOVERLAYCAPS*,
                int>)((*lpVtbl)[3])
        )(
            this,
            Adapter,
            DevType,
            OverlayWidth,
            OverlayHeight,
            OverlayFormat,
            pDisplayMode,
            DisplayRotation,
            pOverlayCaps
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CheckDeviceOverlayType(
            uint Adapter,
            D3DDEVTYPE DevType,
            uint OverlayWidth,
            uint OverlayHeight,
            D3DFORMAT OverlayFormat,
            D3DDISPLAYMODEEX* pDisplayMode,
            D3DDISPLAYROTATION DisplayRotation,
            D3DOVERLAYCAPS* pOverlayCaps
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

        [NativeTypeName(
            "HRESULT (UINT, D3DDEVTYPE, UINT, UINT, D3DFORMAT, D3DDISPLAYMODEEX *, D3DDISPLAYROTATION, D3DOVERLAYCAPS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            D3DDEVTYPE,
            uint,
            uint,
            D3DFORMAT,
            D3DDISPLAYMODEEX*,
            D3DDISPLAYROTATION,
            D3DOVERLAYCAPS*,
            int> CheckDeviceOverlayType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3D9ExOverlayExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3D9ExOverlayExtension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3D9ExOverlayExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3D9ExOverlayExtension(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3D9ExOverlayExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3D9ExOverlayExtension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3D9ExOverlayExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3D9ExOverlayExtension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
