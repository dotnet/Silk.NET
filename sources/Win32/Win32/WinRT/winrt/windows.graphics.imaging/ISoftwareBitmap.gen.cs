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

[Guid("689E0708-7EEF-483F-963F-DA938818E073")]
[NativeTypeName("struct ISoftwareBitmap : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISoftwareBitmap : ISoftwareBitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISoftwareBitmap));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISoftwareBitmap, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISoftwareBitmap, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BitmapPixelFormat(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")]
            BitmapPixelFormat* value
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, BitmapPixelFormat*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_BitmapAlphaMode(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")]
            BitmapAlphaMode* value
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, BitmapAlphaMode*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PixelWidth([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, int*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PixelHeight([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, int*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_DpiX(double value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, double, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DpiX(double* value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, double*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_DpiY(double value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, double, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DpiY(double* value)
    {
        return ((delegate* unmanaged<ISoftwareBitmap, double*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT LockBuffer(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBufferAccessMode")]
            BitmapBufferAccessMode mode,
        [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapBuffer **")] IBitmapBuffer* value
    )
    {
        return (
            (delegate* unmanaged<ISoftwareBitmap, BitmapBufferAccessMode, IBitmapBuffer*, int>)(
                (*lpVtbl)[15]
            )
        )(this, mode, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CopyTo(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
            ISoftwareBitmap bitmap
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, ISoftwareBitmap, int>)((*lpVtbl)[16]))(
            this,
            bitmap
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CopyFromBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, IBuffer, int>)((*lpVtbl)[17]))(this, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CopyToBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, IBuffer, int>)((*lpVtbl)[18]))(this, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetReadOnlyView(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return ((delegate* unmanaged<ISoftwareBitmap, ISoftwareBitmap*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BitmapPixelFormat(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")]
                BitmapPixelFormat* value
        );

        [VtblIndex(7)]
        HRESULT get_BitmapAlphaMode(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")]
                BitmapAlphaMode* value
        );

        [VtblIndex(8)]
        HRESULT get_PixelWidth([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_PixelHeight([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_DpiX(double value);

        [VtblIndex(12)]
        HRESULT get_DpiX(double* value);

        [VtblIndex(13)]
        HRESULT put_DpiY(double value);

        [VtblIndex(14)]
        HRESULT get_DpiY(double* value);

        [VtblIndex(15)]
        HRESULT LockBuffer(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBufferAccessMode")]
                BitmapBufferAccessMode mode,
            [NativeTypeName("ABI::Windows::Graphics::Imaging::IBitmapBuffer **")]
                IBitmapBuffer* value
        );

        [VtblIndex(16)]
        HRESULT CopyTo(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap *")]
                ISoftwareBitmap bitmap
        );

        [VtblIndex(17)]
        HRESULT CopyFromBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer
        );

        [VtblIndex(18)]
        HRESULT CopyToBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer
        );

        [VtblIndex(19)]
        HRESULT GetReadOnlyView(
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
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapPixelFormat*, int> get_BitmapPixelFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapAlphaMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapAlphaMode*, int> get_BitmapAlphaMode;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PixelWidth;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PixelHeight;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsReadOnly;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_DpiX;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DpiX;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_DpiY;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DpiY;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapBufferAccessMode, ABI::Windows::Graphics::Imaging::IBitmapBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapBufferAccessMode, IBitmapBuffer*, int> LockBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISoftwareBitmap, int> CopyTo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> CopyFromBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> CopyToBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISoftwareBitmap*, int> GetReadOnlyView;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISoftwareBitmap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISoftwareBitmap(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISoftwareBitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmap(Silk.NET.WinRT.IInspectable value)
    {
        return new ISoftwareBitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmap"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISoftwareBitmap value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISoftwareBitmap"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISoftwareBitmap(Silk.NET.Windows.IUnknown value)
    {
        return new ISoftwareBitmap(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISoftwareBitmap"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISoftwareBitmap"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISoftwareBitmap value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
