// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("69843DB0-2E99-4641-8529-184F319D1671")]
[NativeTypeName("struct IZoomControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IZoomControl2 : IZoomControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoomControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IZoomControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IZoomControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IZoomControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IZoomControl2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IZoomControl2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IZoomControl2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedModes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CZoomTransitionMode_t **"
        )]
            IVectorView<ZoomTransitionMode>** value
    )
    {
        return (
            (delegate* unmanaged<IZoomControl2, IVectorView<ZoomTransitionMode>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Mode(
        [NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode *")]
            ZoomTransitionMode* value
    )
    {
        return ((delegate* unmanaged<IZoomControl2, ZoomTransitionMode*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Configure(
        [NativeTypeName("ABI::Windows::Media::Devices::IZoomSettings *")] IZoomSettings settings
    )
    {
        return ((delegate* unmanaged<IZoomControl2, IZoomSettings, int>)((*lpVtbl)[8]))(
            this,
            settings
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedModes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CZoomTransitionMode_t **"
            )]
                IVectorView<ZoomTransitionMode>** value
        );

        [VtblIndex(7)]
        HRESULT get_Mode(
            [NativeTypeName("ABI::Windows::Media::Devices::ZoomTransitionMode *")]
                ZoomTransitionMode* value
        );

        [VtblIndex(8)]
        HRESULT Configure(
            [NativeTypeName("ABI::Windows::Media::Devices::IZoomSettings *")] IZoomSettings settings
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CZoomTransitionMode_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<ZoomTransitionMode>**,
            int> get_SupportedModes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ZoomTransitionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ZoomTransitionMode*, int> get_Mode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IZoomSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IZoomSettings, int> Configure;
    }

    /// <summary>Initializes a new instance of the <see cref = "IZoomControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IZoomControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IZoomControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IZoomControl2(Silk.NET.WinRT.IInspectable value)
    {
        return new IZoomControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IZoomControl2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IZoomControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IZoomControl2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IZoomControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IZoomControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IZoomControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IZoomControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IZoomControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IZoomControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
