// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWritePixelSnapping.xml' path='doc/member[@name="IDWritePixelSnapping"]/*' />
[Guid("EAF3A2DA-ECF4-4D24-B644-B34F6842024B")]
[NativeTypeName("struct IDWritePixelSnapping : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWritePixelSnapping : IDWritePixelSnapping.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWritePixelSnapping));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWritePixelSnapping*, Guid*, void**, int>)(lpVtbl[0]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWritePixelSnapping*, uint>)(lpVtbl[1]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWritePixelSnapping*, uint>)(lpVtbl[2]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWritePixelSnapping.xml' path='doc/member[@name="IDWritePixelSnapping.IsPixelSnappingDisabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsPixelSnappingDisabled(void* clientDrawingContext, BOOL* isDisabled)
    {
        return ((delegate* unmanaged<IDWritePixelSnapping*, void*, BOOL*, int>)(lpVtbl[3]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, isDisabled);
    }

    /// <include file='IDWritePixelSnapping.xml' path='doc/member[@name="IDWritePixelSnapping.GetCurrentTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurrentTransform(void* clientDrawingContext, DWRITE_MATRIX* transform)
    {
        return ((delegate* unmanaged<IDWritePixelSnapping*, void*, DWRITE_MATRIX*, int>)(lpVtbl[4]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, transform);
    }

    /// <include file='IDWritePixelSnapping.xml' path='doc/member[@name="IDWritePixelSnapping.GetPixelsPerDip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
    {
        return ((delegate* unmanaged<IDWritePixelSnapping*, void*, float*, int>)(lpVtbl[5]))((IDWritePixelSnapping*)Unsafe.AsPointer(ref this), clientDrawingContext, pixelsPerDip);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsPixelSnappingDisabled(void* clientDrawingContext, BOOL* isDisabled);

        [VtblIndex(4)]
        HRESULT GetCurrentTransform(void* clientDrawingContext, DWRITE_MATRIX* transform);

        [VtblIndex(5)]
        HRESULT GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip);
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

        [NativeTypeName("HRESULT (void *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, BOOL*, int> IsPixelSnappingDisabled;

        [NativeTypeName("HRESULT (void *, DWRITE_MATRIX *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, DWRITE_MATRIX*, int> GetCurrentTransform;

        [NativeTypeName("HRESULT (void *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, float*, int> GetPixelsPerDip;
    }
}
