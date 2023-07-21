// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication"]/*' />
[Guid("191CFAC3-A341-470D-B26E-A864F428319C")]
[NativeTypeName("struct IDXGIOutputDuplication : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDXGIOutputDuplication : IDXGIOutputDuplication.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIOutputDuplication));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[0]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, uint>)(lpVtbl[1]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, uint>)(lpVtbl[2]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDXGIObject.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
    }

    /// <inheritdoc cref="IDXGIObject.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pUnknown);
    }

    /// <inheritdoc cref="IDXGIObject.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
    }

    /// <inheritdoc cref="IDXGIObject.GetParent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)(lpVtbl[6]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), riid, ppParent);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDesc(DXGI_OUTDUPL_DESC* pDesc)
    {
        ((delegate* unmanaged<IDXGIOutputDuplication*, DXGI_OUTDUPL_DESC*, void>)(lpVtbl[7]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.AcquireNextFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AcquireNextFrame(uint TimeoutInMilliseconds, DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, IDXGIResource** ppDesktopResource)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_FRAME_INFO*, IDXGIResource**, int>)(lpVtbl[8]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFrameDirtyRects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFrameDirtyRects(uint DirtyRectsBufferSize, RECT* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, RECT*, uint*, int>)(lpVtbl[9]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFrameMoveRects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFrameMoveRects(uint MoveRectsBufferSize, DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, DXGI_OUTDUPL_MOVE_RECT*, uint*, int>)(lpVtbl[10]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.GetFramePointerShape"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, DXGI_OUTDUPL_POINTER_SHAPE_INFO*, int>)(lpVtbl[11]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.MapDesktopSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MapDesktopSurface(DXGI_MAPPED_RECT* pLockedRect)
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, DXGI_MAPPED_RECT*, int>)(lpVtbl[12]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this), pLockedRect);
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.UnMapDesktopSurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnMapDesktopSurface()
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, int>)(lpVtbl[13]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIOutputDuplication.xml' path='doc/member[@name="IDXGIOutputDuplication.ReleaseFrame"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReleaseFrame()
    {
        return ((delegate* unmanaged<IDXGIOutputDuplication*, int>)(lpVtbl[14]))((IDXGIOutputDuplication*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDXGIObject.Interface
    {
        [VtblIndex(7)]
        void GetDesc(DXGI_OUTDUPL_DESC* pDesc);

        [VtblIndex(8)]
        HRESULT AcquireNextFrame(uint TimeoutInMilliseconds, DXGI_OUTDUPL_FRAME_INFO* pFrameInfo, IDXGIResource** ppDesktopResource);

        [VtblIndex(9)]
        HRESULT GetFrameDirtyRects(uint DirtyRectsBufferSize, RECT* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired);

        [VtblIndex(10)]
        HRESULT GetFrameMoveRects(uint MoveRectsBufferSize, DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired);

        [VtblIndex(11)]
        HRESULT GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo);

        [VtblIndex(12)]
        HRESULT MapDesktopSurface(DXGI_MAPPED_RECT* pLockedRect);

        [VtblIndex(13)]
        HRESULT UnMapDesktopSurface();

        [VtblIndex(14)]
        HRESULT ReleaseFrame();
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

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetParent;

        [NativeTypeName("void (DXGI_OUTDUPL_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_OUTDUPL_DESC*, void> GetDesc;

        [NativeTypeName("HRESULT (UINT, DXGI_OUTDUPL_FRAME_INFO *, IDXGIResource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DXGI_OUTDUPL_FRAME_INFO*, IDXGIResource**, int> AcquireNextFrame;

        [NativeTypeName("HRESULT (UINT, RECT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, uint*, int> GetFrameDirtyRects;

        [NativeTypeName("HRESULT (UINT, DXGI_OUTDUPL_MOVE_RECT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DXGI_OUTDUPL_MOVE_RECT*, uint*, int> GetFrameMoveRects;

        [NativeTypeName("HRESULT (UINT, void *, UINT *, DXGI_OUTDUPL_POINTER_SHAPE_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint*, DXGI_OUTDUPL_POINTER_SHAPE_INFO*, int> GetFramePointerShape;

        [NativeTypeName("HRESULT (DXGI_MAPPED_RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_MAPPED_RECT*, int> MapDesktopSurface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnMapDesktopSurface;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseFrame;
    }
}
