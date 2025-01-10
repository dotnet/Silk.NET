// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.faceanalysis.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("16B672DC-FE6F-3117-8D95-C3F04D51630C")]
[NativeTypeName("struct IFaceDetector : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFaceDetector : IFaceDetector.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFaceDetector));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFaceDetector, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFaceDetector, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFaceDetector, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFaceDetector, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFaceDetector, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFaceDetector, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DetectFacesAsync(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap image,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **"
        )]
            IAsyncOperation<IntPtr>** returnValue
    )
    {
        return (
            (delegate* unmanaged<IFaceDetector, ISoftwareBitmap, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, image, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT DetectFacesWithSearchAreaAsync(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap image,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds")] BitmapBounds searchArea,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **"
        )]
            IAsyncOperation<IntPtr>** returnValue
    )
    {
        return (
            (delegate* unmanaged<
                IFaceDetector,
                ISoftwareBitmap,
                BitmapBounds,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, image, searchArea, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinDetectableFaceSize(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")] BitmapSize* returnValue
    )
    {
        return ((delegate* unmanaged<IFaceDetector, BitmapSize*, int>)((*lpVtbl)[8]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MinDetectableFaceSize(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value
    )
    {
        return ((delegate* unmanaged<IFaceDetector, BitmapSize, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxDetectableFaceSize(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")] BitmapSize* returnValue
    )
    {
        return ((delegate* unmanaged<IFaceDetector, BitmapSize*, int>)((*lpVtbl)[10]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MaxDetectableFaceSize(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value
    )
    {
        return ((delegate* unmanaged<IFaceDetector, BitmapSize, int>)((*lpVtbl)[11]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT DetectFacesAsync(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap image,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **"
            )]
                IAsyncOperation<IntPtr>** returnValue
        );

        [VtblIndex(7)]
        HRESULT DetectFacesWithSearchAreaAsync(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap image,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds")]
                BitmapBounds searchArea,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **"
            )]
                IAsyncOperation<IntPtr>** returnValue
        );

        [VtblIndex(8)]
        HRESULT get_MinDetectableFaceSize(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")]
                BitmapSize* returnValue
        );

        [VtblIndex(9)]
        HRESULT put_MinDetectableFaceSize(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value
        );

        [VtblIndex(10)]
        HRESULT get_MaxDetectableFaceSize(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize *")]
                BitmapSize* returnValue
        );

        [VtblIndex(11)]
        HRESULT put_MaxDetectableFaceSize(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapSize")] BitmapSize value
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
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISoftwareBitmap,
            IAsyncOperation<IntPtr>**,
            int> DetectFacesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *, ABI::Windows::Graphics::Imaging::BitmapBounds, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_Windows__CMedia__CFaceAnalysis__CDetectedFace_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISoftwareBitmap,
            BitmapBounds,
            IAsyncOperation<IntPtr>**,
            int> DetectFacesWithSearchAreaAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapSize*, int> get_MinDetectableFaceSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapSize, int> put_MinDetectableFaceSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapSize*, int> get_MaxDetectableFaceSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapSize) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapSize, int> put_MaxDetectableFaceSize;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFaceDetector"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFaceDetector(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFaceDetector"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFaceDetector(Silk.NET.WinRT.IInspectable value)
    {
        return new IFaceDetector(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFaceDetector"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFaceDetector"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFaceDetector value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFaceDetector"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFaceDetector(Silk.NET.Windows.IUnknown value)
    {
        return new IFaceDetector(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFaceDetector"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFaceDetector"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFaceDetector value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
