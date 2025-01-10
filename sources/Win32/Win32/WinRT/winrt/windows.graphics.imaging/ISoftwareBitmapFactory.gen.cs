// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C99FEB69-2D62-4D47-A6B3-4FDB6A07FDF8")]
[NativeTypeName("struct ISoftwareBitmapFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmapFactory : ISoftwareBitmapFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmapFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISoftwareBitmapFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISoftwareBitmapFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftwareBitmapFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmapFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISoftwareBitmapFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISoftwareBitmapFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat format,
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapFactory,
                BitmapPixelFormat,
                int,
                int,
                ISoftwareBitmap*,
                int>)((*lpVtbl)[6])
        )(this, format, width, height, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithAlpha(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
            BitmapPixelFormat format,
        [NativeTypeName("INT32")] int width,
        [NativeTypeName("INT32")] int height,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")] BitmapAlphaMode alpha,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return (
            (delegate* unmanaged<
                ISoftwareBitmapFactory,
                BitmapPixelFormat,
                int,
                int,
                BitmapAlphaMode,
                ISoftwareBitmap*,
                int>)((*lpVtbl)[7])
        )(this, format, width, height, alpha, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat format,
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithAlpha(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat")]
                BitmapPixelFormat format,
            [NativeTypeName("INT32")] int width,
            [NativeTypeName("INT32")] int height,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode")]
                BitmapAlphaMode alpha,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
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
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, INT32, INT32, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BitmapPixelFormat,
            int,
            int,
            ISoftwareBitmap*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat, INT32, INT32, ABI::Windows::Graphics::Imaging::BitmapAlphaMode, ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BitmapPixelFormat,
            int,
            int,
            BitmapAlphaMode,
            ISoftwareBitmap*,
            int> CreateWithAlpha;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISoftwareBitmapFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISoftwareBitmapFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISoftwareBitmapFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmapFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ISoftwareBitmapFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmapFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmapFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISoftwareBitmapFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISoftwareBitmapFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmapFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ISoftwareBitmapFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmapFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmapFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISoftwareBitmapFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
