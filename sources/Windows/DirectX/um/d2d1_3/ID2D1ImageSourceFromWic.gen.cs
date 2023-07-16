// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='ID2D1ImageSourceFromWic.xml' path='doc/member[@name="ID2D1ImageSourceFromWic"]/*'/>
[Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
[NativeTypeName("struct ID2D1ImageSourceFromWic : ID2D1ImageSource")]
[NativeInheritance("ID2D1ImageSource")]
public unsafe partial struct ID2D1ImageSourceFromWic : ID2D1ImageSourceFromWic.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ImageSourceFromWic));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, uint> )(lpVtbl[1]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, uint> )(lpVtbl[2]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1ImageSourceFromWic*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref = "ID2D1ImageSource.OfferResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OfferResources()
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, int> )(lpVtbl[4]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1ImageSource.TryReclaimResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT TryReclaimResources(BOOL* resourcesDiscarded)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, BOOL*, int> )(lpVtbl[5]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), resourcesDiscarded);
    }

    /// <include file='ID2D1ImageSourceFromWic.xml' path='doc/member[@name="ID2D1ImageSourceFromWic.EnsureCached"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, D2D_RECT_U*, int> )(lpVtbl[6]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToFill);
    }

    /// <include file='ID2D1ImageSourceFromWic.xml' path='doc/member[@name="ID2D1ImageSourceFromWic.TrimCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TrimCache([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve)
    {
        return ((delegate* unmanaged<ID2D1ImageSourceFromWic*, D2D_RECT_U*, int> )(lpVtbl[7]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), rectangleToPreserve);
    }

    /// <include file='ID2D1ImageSourceFromWic.xml' path='doc/member[@name="ID2D1ImageSourceFromWic.GetSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetSource(IWICBitmapSource** wicBitmapSource)
    {
        ((delegate* unmanaged<ID2D1ImageSourceFromWic*, IWICBitmapSource**, void> )(lpVtbl[8]))((ID2D1ImageSourceFromWic*)Unsafe.AsPointer(ref this), wicBitmapSource);
    }

    public interface Interface : ID2D1ImageSource.Interface
    {
        [VtblIndex(6)]
        HRESULT EnsureCached([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToFill);
        [VtblIndex(7)]
        HRESULT TrimCache([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* rectangleToPreserve);
        [VtblIndex(8)]
        void GetSource(IWICBitmapSource** wicBitmapSource);
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
        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OfferResources;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> TryReclaimResources;
        [NativeTypeName("HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, int> EnsureCached;
        [NativeTypeName("HRESULT (const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_RECT_U*, int> TrimCache;
        [NativeTypeName("void (IWICBitmapSource **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICBitmapSource**, void> GetSource;
    }
}