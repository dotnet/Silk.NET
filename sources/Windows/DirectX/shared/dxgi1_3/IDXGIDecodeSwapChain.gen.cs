// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain"]/*' />
[Guid("2633066B-4514-4C7A-8FD8-12EA98059D18")]
[NativeTypeName("struct IDXGIDecodeSwapChain : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDXGIDecodeSwapChain : IDXGIDecodeSwapChain.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIDecodeSwapChain));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint>)(lpVtbl[1]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint>)(lpVtbl[2]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.PresentBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint, uint, uint, int>)(lpVtbl[3]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), BufferToPresent, SyncInterval, Flags);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetSourceRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[4]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetTargetRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[5]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetDestSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDestSize(uint Width, uint Height)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint, uint, int>)(lpVtbl[6]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), Width, Height);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetSourceRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSourceRect(RECT* pRect)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[7]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetTargetRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTargetRect(RECT* pRect)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, RECT*, int>)(lpVtbl[8]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetDestSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDestSize(uint* pWidth, uint* pHeight)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, uint*, uint*, int>)(lpVtbl[9]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), pWidth, pHeight);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.SetColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace)
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS, int>)(lpVtbl[10]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this), ColorSpace);
    }

    /// <include file='IDXGIDecodeSwapChain.xml' path='doc/member[@name="IDXGIDecodeSwapChain.GetColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace()
    {
        return ((delegate* unmanaged<IDXGIDecodeSwapChain*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS>)(lpVtbl[11]))((IDXGIDecodeSwapChain*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags);

        [VtblIndex(4)]
        HRESULT SetSourceRect([NativeTypeName("const RECT *")] RECT* pRect);

        [VtblIndex(5)]
        HRESULT SetTargetRect([NativeTypeName("const RECT *")] RECT* pRect);

        [VtblIndex(6)]
        HRESULT SetDestSize(uint Width, uint Height);

        [VtblIndex(7)]
        HRESULT GetSourceRect(RECT* pRect);

        [VtblIndex(8)]
        HRESULT GetTargetRect(RECT* pRect);

        [VtblIndex(9)]
        HRESULT GetDestSize(uint* pWidth, uint* pHeight);

        [VtblIndex(10)]
        HRESULT SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);

        [VtblIndex(11)]
        DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace();
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

        [NativeTypeName("HRESULT (UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> PresentBuffer;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetSourceRect;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetTargetRect;

        [NativeTypeName("HRESULT (UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetDestSize;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetSourceRect;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetTargetRect;

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetDestSize;

        [NativeTypeName("HRESULT (DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS, int> SetColorSpace;

        [NativeTypeName("DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS> GetColorSpace;
    }
}
