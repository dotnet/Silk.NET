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

[Guid("27B6C322-25AD-4F1B-AAAB-524AB376CA33")]
[NativeTypeName("struct IIsoSpeedControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIsoSpeedControl : IIsoSpeedControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIsoSpeedControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIsoSpeedControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIsoSpeedControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIsoSpeedControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIsoSpeedControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIsoSpeedControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIsoSpeedControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IIsoSpeedControl, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
    )]
    public HRESULT get_SupportedPresets(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CIsoSpeedPreset_t **"
        )]
            IVectorView<IsoSpeedPreset>** value
    )
    {
        return (
            (delegate* unmanaged<IIsoSpeedControl, IVectorView<IsoSpeedPreset>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
    )]
    public HRESULT get_Preset(
        [NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset *")] IsoSpeedPreset* value
    )
    {
        return ((delegate* unmanaged<IIsoSpeedControl, IsoSpeedPreset*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
    )]
    public HRESULT SetPresetAsync(
        [NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset")] IsoSpeedPreset preset,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IIsoSpeedControl, IsoSpeedPreset, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, preset, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        [Obsolete(
            "SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
        )]
        HRESULT get_SupportedPresets(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CIsoSpeedPreset_t **"
            )]
                IVectorView<IsoSpeedPreset>** value
        );

        [VtblIndex(8)]
        [Obsolete(
            "Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
        )]
        HRESULT get_Preset(
            [NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset *")] IsoSpeedPreset* value
        );

        [VtblIndex(9)]
        [Obsolete(
            "SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
        )]
        HRESULT SetPresetAsync(
            [NativeTypeName("ABI::Windows::Media::Devices::IsoSpeedPreset")] IsoSpeedPreset preset,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
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
        public delegate* unmanaged<TSelf*, byte*, int> get_Supported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CIsoSpeedPreset_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SupportedPresets may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IsoSpeedPreset>**, int> get_SupportedPresets;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IsoSpeedPreset *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Preset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
        )]
        public delegate* unmanaged<TSelf*, IsoSpeedPreset*, int> get_Preset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IsoSpeedPreset, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SetPresetAsync may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead"
        )]
        public delegate* unmanaged<TSelf*, IsoSpeedPreset, IAsyncAction*, int> SetPresetAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIsoSpeedControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIsoSpeedControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIsoSpeedControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIsoSpeedControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IIsoSpeedControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIsoSpeedControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIsoSpeedControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIsoSpeedControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIsoSpeedControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIsoSpeedControl(Silk.NET.Windows.IUnknown value)
    {
        return new IIsoSpeedControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIsoSpeedControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIsoSpeedControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIsoSpeedControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
