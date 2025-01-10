// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CF4401F0-9BF2-4C39-9F41-E022514A8468")]
[NativeTypeName("struct IVideoTransformSphericalProjection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoTransformSphericalProjection
    : IVideoTransformSphericalProjection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoTransformSphericalProjection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVideoTransformSphericalProjection, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoTransformSphericalProjection, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, byte*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IVideoTransformSphericalProjection, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat *")]
            SphericalVideoFrameFormat* value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoTransformSphericalProjection,
                SphericalVideoFrameFormat*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_FrameFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat")]
            SphericalVideoFrameFormat value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoTransformSphericalProjection,
                SphericalVideoFrameFormat,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ProjectionMode(
        [NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode *")]
            SphericalVideoProjectionMode* value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoTransformSphericalProjection,
                SphericalVideoProjectionMode*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ProjectionMode(
        [NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode")]
            SphericalVideoProjectionMode value
    )
    {
        return (
            (delegate* unmanaged<
                IVideoTransformSphericalProjection,
                SphericalVideoProjectionMode,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_HorizontalFieldOfViewInDegrees(double* value)
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, double*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_HorizontalFieldOfViewInDegrees(double value)
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, double, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ViewOrientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, Quaternion*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_ViewOrientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
    )
    {
        return (
            (delegate* unmanaged<IVideoTransformSphericalProjection, Quaternion, int>)(
                (*lpVtbl)[15]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_FrameFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat *")]
                SphericalVideoFrameFormat* value
        );

        [VtblIndex(9)]
        HRESULT put_FrameFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat")]
                SphericalVideoFrameFormat value
        );

        [VtblIndex(10)]
        HRESULT get_ProjectionMode(
            [NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode *")]
                SphericalVideoProjectionMode* value
        );

        [VtblIndex(11)]
        HRESULT put_ProjectionMode(
            [NativeTypeName("ABI::Windows::Media::Playback::SphericalVideoProjectionMode")]
                SphericalVideoProjectionMode value
        );

        [VtblIndex(12)]
        HRESULT get_HorizontalFieldOfViewInDegrees(double* value);

        [VtblIndex(13)]
        HRESULT put_HorizontalFieldOfViewInDegrees(double value);

        [VtblIndex(14)]
        HRESULT get_ViewOrientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
        );

        [VtblIndex(15)]
        HRESULT put_ViewOrientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SphericalVideoFrameFormat*, int> get_FrameFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::SphericalVideoFrameFormat) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SphericalVideoFrameFormat, int> put_FrameFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::SphericalVideoProjectionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SphericalVideoProjectionMode*, int> get_ProjectionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::SphericalVideoProjectionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SphericalVideoProjectionMode, int> put_ProjectionMode;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_HorizontalFieldOfViewInDegrees;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_HorizontalFieldOfViewInDegrees;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Quaternion*, int> get_ViewOrientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Quaternion, int> put_ViewOrientation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoTransformSphericalProjection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoTransformSphericalProjection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoTransformSphericalProjection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoTransformSphericalProjection(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IVideoTransformSphericalProjection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoTransformSphericalProjection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoTransformSphericalProjection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IVideoTransformSphericalProjection value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoTransformSphericalProjection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoTransformSphericalProjection(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IVideoTransformSphericalProjection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoTransformSphericalProjection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoTransformSphericalProjection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IVideoTransformSphericalProjection value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
