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

[Guid("AE755344-E268-4D35-ADCF-E995D31A8D34")]
[NativeTypeName("struct IBitmapTransform : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBitmapTransform : IBitmapTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBitmapTransform, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBitmapTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBitmapTransform, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IBitmapTransform, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ScaledWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapTransform, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ScaledWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IBitmapTransform, uint, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ScaledHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IBitmapTransform, uint*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ScaledHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IBitmapTransform, uint, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InterpolationMode(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode *")]
            BitmapInterpolationMode* value
    )
    {
        return (
            (delegate* unmanaged<IBitmapTransform, BitmapInterpolationMode*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InterpolationMode(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode")]
            BitmapInterpolationMode value
    )
    {
        return (
            (delegate* unmanaged<IBitmapTransform, BitmapInterpolationMode, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Flip(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip *")] BitmapFlip* value
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, BitmapFlip*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Flip(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip")] BitmapFlip value
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, BitmapFlip, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Rotation(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation *")] BitmapRotation* value
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, BitmapRotation*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Rotation(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation")] BitmapRotation value
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, BitmapRotation, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Bounds(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds *")] BitmapBounds* value
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, BitmapBounds*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Bounds(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds")] BitmapBounds value
    )
    {
        return ((delegate* unmanaged<IBitmapTransform, BitmapBounds, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ScaledWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_ScaledWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_ScaledHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT put_ScaledHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(10)]
        HRESULT get_InterpolationMode(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode *")]
                BitmapInterpolationMode* value
        );

        [VtblIndex(11)]
        HRESULT put_InterpolationMode(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapInterpolationMode")]
                BitmapInterpolationMode value
        );

        [VtblIndex(12)]
        HRESULT get_Flip(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip *")] BitmapFlip* value
        );

        [VtblIndex(13)]
        HRESULT put_Flip(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapFlip")] BitmapFlip value
        );

        [VtblIndex(14)]
        HRESULT get_Rotation(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation *")]
                BitmapRotation* value
        );

        [VtblIndex(15)]
        HRESULT put_Rotation(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapRotation")] BitmapRotation value
        );

        [VtblIndex(16)]
        HRESULT get_Bounds(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds *")] BitmapBounds* value
        );

        [VtblIndex(17)]
        HRESULT put_Bounds(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapBounds")] BitmapBounds value
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ScaledWidth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_ScaledWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ScaledHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_ScaledHeight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapInterpolationMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapInterpolationMode*, int> get_InterpolationMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapInterpolationMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapInterpolationMode, int> put_InterpolationMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapFlip *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapFlip*, int> get_Flip;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapFlip) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapFlip, int> put_Flip;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapRotation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapRotation*, int> get_Rotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapRotation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapRotation, int> put_Rotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapBounds *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapBounds*, int> get_Bounds;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapBounds) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapBounds, int> put_Bounds;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBitmapTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBitmapTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBitmapTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBitmapTransform(Silk.NET.WinRT.IInspectable value)
    {
        return new IBitmapTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapTransform"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBitmapTransform value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBitmapTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBitmapTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IBitmapTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBitmapTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
