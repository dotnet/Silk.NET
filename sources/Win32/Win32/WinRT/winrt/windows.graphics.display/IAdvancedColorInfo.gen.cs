// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8797DCFB-B229-4081-AE9A-2CC85E34AD6A")]
[NativeTypeName("struct IAdvancedColorInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdvancedColorInfo : IAdvancedColorInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedColorInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAdvancedColorInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CurrentAdvancedColorKind(
        [NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind *")]
            AdvancedColorKind* value
    )
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, AdvancedColorKind*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RedPrimary(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, Point*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_GreenPrimary(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, Point*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_BluePrimary(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, Point*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_WhitePoint(
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
    )
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, Point*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MaxLuminanceInNits(float* value)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, float*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MinLuminanceInNits(float* value)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, float*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MaxAverageFullFrameLuminanceInNits(float* value)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, float*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_SdrWhiteLevelInNits(float* value)
    {
        return ((delegate* unmanaged<IAdvancedColorInfo, float*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsHdrMetadataFormatCurrentlySupported(
        [NativeTypeName("ABI::Windows::Graphics::Display::HdrMetadataFormat")]
            HdrMetadataFormat format,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IAdvancedColorInfo, HdrMetadataFormat, byte*, int>)((*lpVtbl)[15])
        )(this, format, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT IsAdvancedColorKindAvailable(
        [NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind")]
            AdvancedColorKind kind,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IAdvancedColorInfo, AdvancedColorKind, byte*, int>)((*lpVtbl)[16])
        )(this, kind, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CurrentAdvancedColorKind(
            [NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind *")]
                AdvancedColorKind* value
        );

        [VtblIndex(7)]
        HRESULT get_RedPrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(8)]
        HRESULT get_GreenPrimary(
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value
        );

        [VtblIndex(9)]
        HRESULT get_BluePrimary([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(10)]
        HRESULT get_WhitePoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(11)]
        HRESULT get_MaxLuminanceInNits(float* value);

        [VtblIndex(12)]
        HRESULT get_MinLuminanceInNits(float* value);

        [VtblIndex(13)]
        HRESULT get_MaxAverageFullFrameLuminanceInNits(float* value);

        [VtblIndex(14)]
        HRESULT get_SdrWhiteLevelInNits(float* value);

        [VtblIndex(15)]
        HRESULT IsHdrMetadataFormatCurrentlySupported(
            [NativeTypeName("ABI::Windows::Graphics::Display::HdrMetadataFormat")]
                HdrMetadataFormat format,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(16)]
        HRESULT IsAdvancedColorKindAvailable(
            [NativeTypeName("ABI::Windows::Graphics::Display::AdvancedColorKind")]
                AdvancedColorKind kind,
            [NativeTypeName("boolean *")] byte* result
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
            "HRESULT (ABI::Windows::Graphics::Display::AdvancedColorKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AdvancedColorKind*, int> get_CurrentAdvancedColorKind;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_RedPrimary;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_GreenPrimary;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_BluePrimary;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> get_WhitePoint;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MaxLuminanceInNits;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MinLuminanceInNits;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MaxAverageFullFrameLuminanceInNits;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_SdrWhiteLevelInNits;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::HdrMetadataFormat, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HdrMetadataFormat,
            byte*,
            int> IsHdrMetadataFormatCurrentlySupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::AdvancedColorKind, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AdvancedColorKind,
            byte*,
            int> IsAdvancedColorKindAvailable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdvancedColorInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdvancedColorInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdvancedColorInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdvancedColorInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IAdvancedColorInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedColorInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedColorInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAdvancedColorInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdvancedColorInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdvancedColorInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IAdvancedColorInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdvancedColorInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdvancedColorInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAdvancedColorInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
