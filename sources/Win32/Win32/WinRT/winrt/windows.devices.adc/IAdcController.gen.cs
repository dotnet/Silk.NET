// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.adc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2A76E4B0-A896-4219-86B6-EA8CDCE98F56")]
[NativeTypeName("struct IAdcController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdcController : IAdcController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdcController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdcController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAdcController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdcController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAdcController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAdcController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAdcController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ChannelCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAdcController, int*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResolutionInBits([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAdcController, int*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MinValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAdcController, int*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MaxValue([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAdcController, int*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ChannelMode(
        [NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode *")] AdcChannelMode* value
    )
    {
        return ((delegate* unmanaged<IAdcController, AdcChannelMode*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ChannelMode(
        [NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode value
    )
    {
        return ((delegate* unmanaged<IAdcController, AdcChannelMode, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsChannelModeSupported(
        [NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode channelMode,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return ((delegate* unmanaged<IAdcController, AdcChannelMode, byte*, int>)((*lpVtbl)[12]))(
            this,
            channelMode,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OpenChannel(
        [NativeTypeName("INT32")] int channelNumber,
        [NativeTypeName("ABI::Windows::Devices::Adc::IAdcChannel **")] IAdcChannel* result
    )
    {
        return ((delegate* unmanaged<IAdcController, int, IAdcChannel*, int>)((*lpVtbl)[13]))(
            this,
            channelNumber,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ChannelCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_ResolutionInBits([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MinValue([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_MaxValue([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_ChannelMode(
            [NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode *")] AdcChannelMode* value
        );

        [VtblIndex(11)]
        HRESULT put_ChannelMode(
            [NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")] AdcChannelMode value
        );

        [VtblIndex(12)]
        HRESULT IsChannelModeSupported(
            [NativeTypeName("ABI::Windows::Devices::Adc::AdcChannelMode")]
                AdcChannelMode channelMode,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(13)]
        HRESULT OpenChannel(
            [NativeTypeName("INT32")] int channelNumber,
            [NativeTypeName("ABI::Windows::Devices::Adc::IAdcChannel **")] IAdcChannel* result
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ChannelCount;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ResolutionInBits;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MinValue;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MaxValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Adc::AdcChannelMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AdcChannelMode*, int> get_ChannelMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Adc::AdcChannelMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AdcChannelMode, int> put_ChannelMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Adc::AdcChannelMode, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AdcChannelMode, byte*, int> IsChannelModeSupported;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Devices::Adc::IAdcChannel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, IAdcChannel*, int> OpenChannel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdcController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdcController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdcController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdcController(Silk.NET.WinRT.IInspectable value)
    {
        return new IAdcController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdcController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdcController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAdcController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdcController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdcController(Silk.NET.Windows.IUnknown value)
    {
        return new IAdcController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdcController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdcController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAdcController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
