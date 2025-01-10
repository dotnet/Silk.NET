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

[Guid("781F047E-7162-49C8-A8F9-9481C565363E")]
[NativeTypeName("struct IWhiteBalanceControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWhiteBalanceControl : IWhiteBalanceControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWhiteBalanceControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWhiteBalanceControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Supported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Preset(
        [NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset *")]
            ColorTemperaturePreset* value
    )
    {
        return (
            (delegate* unmanaged<IWhiteBalanceControl, ColorTemperaturePreset*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetPresetAsync(
        [NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset")]
            ColorTemperaturePreset preset,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWhiteBalanceControl, ColorTemperaturePreset, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, preset, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, uint*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, uint*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, uint*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Value([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IWhiteBalanceControl, uint*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetValueAsync(
        [NativeTypeName("UINT32")] uint temperature,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IWhiteBalanceControl, uint, IAsyncAction*, int>)((*lpVtbl)[13])
        )(this, temperature, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Supported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_Preset(
            [NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset *")]
                ColorTemperaturePreset* value
        );

        [VtblIndex(8)]
        HRESULT SetPresetAsync(
            [NativeTypeName("ABI::Windows::Media::Devices::ColorTemperaturePreset")]
                ColorTemperaturePreset preset,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(9)]
        HRESULT get_Min([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_Max([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_Step([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT get_Value([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT SetValueAsync(
            [NativeTypeName("UINT32")] uint temperature,
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
            "HRESULT (ABI::Windows::Media::Devices::ColorTemperaturePreset *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ColorTemperaturePreset*, int> get_Preset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::ColorTemperaturePreset, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ColorTemperaturePreset,
            IAsyncAction*,
            int> SetPresetAsync;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Min;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Max;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Step;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Value;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAsyncAction*, int> SetValueAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWhiteBalanceControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWhiteBalanceControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWhiteBalanceControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWhiteBalanceControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IWhiteBalanceControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWhiteBalanceControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWhiteBalanceControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWhiteBalanceControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWhiteBalanceControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWhiteBalanceControl(Silk.NET.Windows.IUnknown value)
    {
        return new IWhiteBalanceControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWhiteBalanceControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWhiteBalanceControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWhiteBalanceControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
