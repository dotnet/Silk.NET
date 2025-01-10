// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C3C181EC-2914-4791-AF02-02D224A10B43")]
[NativeTypeName("struct ISoftwareBitmapNativeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmapNativeFactory
    : ISoftwareBitmapNativeFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmapNativeFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISoftwareBitmapNativeFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISoftwareBitmapNativeFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISoftwareBitmapNativeFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISoftwareBitmapNativeFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromWICBitmap(
        IWICBitmap data,
        BOOL forceReadOnly,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapNativeFactory,
                IWICBitmap,
                BOOL,
                Guid*,
                void**,
                int>)((*lpVtbl)[6])
        )(this, data, forceReadOnly, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromMF2DBuffer2(
        IMF2DBuffer2 data,
        [NativeTypeName("const GUID &")] Guid* subtype,
        [NativeTypeName("UINT32")] uint width,
        [NativeTypeName("UINT32")] uint height,
        BOOL forceReadOnly,
        [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppv
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapNativeFactory,
                IMF2DBuffer2,
                Guid*,
                uint,
                uint,
                BOOL,
                MFVideoArea*,
                Guid*,
                void**,
                int>)((*lpVtbl)[7])
        )(this, data, subtype, width, height, forceReadOnly, minDisplayAperture, riid, ppv);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromWICBitmap(
            IWICBitmap data,
            BOOL forceReadOnly,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPVOID *")] void** ppv
        );

        [VtblIndex(7)]
        HRESULT CreateFromMF2DBuffer2(
            IMF2DBuffer2 data,
            [NativeTypeName("const GUID &")] Guid* subtype,
            [NativeTypeName("UINT32")] uint width,
            [NativeTypeName("UINT32")] uint height,
            BOOL forceReadOnly,
            [NativeTypeName("const MFVideoArea *")] MFVideoArea* minDisplayAperture,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPVOID *")] void** ppv
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (IWICBitmap *, BOOL, const IID &, LPVOID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IWICBitmap,
            BOOL,
            Guid*,
            void**,
            int> CreateFromWICBitmap;

        [NativeTypeName(
            "HRESULT (IMF2DBuffer2 *, const GUID &, UINT32, UINT32, BOOL, const MFVideoArea *, const IID &, LPVOID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMF2DBuffer2,
            Guid*,
            uint,
            uint,
            BOOL,
            MFVideoArea*,
            Guid*,
            void**,
            int> CreateFromMF2DBuffer2;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISoftwareBitmapNativeFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISoftwareBitmapNativeFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISoftwareBitmapNativeFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmapNativeFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ISoftwareBitmapNativeFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmapNativeFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmapNativeFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISoftwareBitmapNativeFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISoftwareBitmapNativeFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmapNativeFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ISoftwareBitmapNativeFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmapNativeFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmapNativeFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISoftwareBitmapNativeFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
