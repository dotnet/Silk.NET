// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("79CF2233-7536-4948-9D36-1E4692DC5760")]
[NativeTypeName("struct ID3D11Debug : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D11Debug : ID3D11Debug.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11Debug));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11Debug, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D11Debug, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11Debug, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFeatureMask(uint Mask)
    {
        return ((delegate* unmanaged<ID3D11Debug, uint, int>)((*lpVtbl)[3]))(this, Mask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public uint GetFeatureMask()
    {
        return ((delegate* unmanaged<ID3D11Debug, uint>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPresentPerRenderOpDelay(uint Milliseconds)
    {
        return ((delegate* unmanaged<ID3D11Debug, uint, int>)((*lpVtbl)[5]))(this, Milliseconds);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetPresentPerRenderOpDelay()
    {
        return ((delegate* unmanaged<ID3D11Debug, uint>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSwapChain(IDXGISwapChain pSwapChain)
    {
        return ((delegate* unmanaged<ID3D11Debug, IDXGISwapChain, int>)((*lpVtbl)[7]))(
            this,
            pSwapChain
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSwapChain(IDXGISwapChain* ppSwapChain)
    {
        return ((delegate* unmanaged<ID3D11Debug, IDXGISwapChain*, int>)((*lpVtbl)[8]))(
            this,
            ppSwapChain
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ValidateContext(ID3D11DeviceContext pContext)
    {
        return ((delegate* unmanaged<ID3D11Debug, ID3D11DeviceContext, int>)((*lpVtbl)[9]))(
            this,
            pContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags)
    {
        return ((delegate* unmanaged<ID3D11Debug, D3D11_RLDO_FLAGS, int>)((*lpVtbl)[10]))(
            this,
            Flags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ValidateContextForDispatch(ID3D11DeviceContext pContext)
    {
        return ((delegate* unmanaged<ID3D11Debug, ID3D11DeviceContext, int>)((*lpVtbl)[11]))(
            this,
            pContext
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFeatureMask(uint Mask);

        [VtblIndex(4)]
        uint GetFeatureMask();

        [VtblIndex(5)]
        HRESULT SetPresentPerRenderOpDelay(uint Milliseconds);

        [VtblIndex(6)]
        uint GetPresentPerRenderOpDelay();

        [VtblIndex(7)]
        HRESULT SetSwapChain(IDXGISwapChain pSwapChain);

        [VtblIndex(8)]
        HRESULT GetSwapChain(IDXGISwapChain* ppSwapChain);

        [VtblIndex(9)]
        HRESULT ValidateContext(ID3D11DeviceContext pContext);

        [VtblIndex(10)]
        HRESULT ReportLiveDeviceObjects(D3D11_RLDO_FLAGS Flags);

        [VtblIndex(11)]
        HRESULT ValidateContextForDispatch(ID3D11DeviceContext pContext);
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

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFeatureMask;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFeatureMask;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetPresentPerRenderOpDelay;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetPresentPerRenderOpDelay;

        [NativeTypeName("HRESULT (IDXGISwapChain *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISwapChain, int> SetSwapChain;

        [NativeTypeName("HRESULT (IDXGISwapChain **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDXGISwapChain*, int> GetSwapChain;

        [NativeTypeName("HRESULT (ID3D11DeviceContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11DeviceContext, int> ValidateContext;

        [NativeTypeName("HRESULT (D3D11_RLDO_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_RLDO_FLAGS, int> ReportLiveDeviceObjects;

        [NativeTypeName("HRESULT (ID3D11DeviceContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11DeviceContext, int> ValidateContextForDispatch;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D11Debug"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D11Debug(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D11Debug"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D11Debug(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D11Debug(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D11Debug"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D11Debug"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D11Debug value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
