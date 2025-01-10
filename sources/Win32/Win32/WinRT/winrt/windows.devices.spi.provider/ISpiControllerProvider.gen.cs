// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C1686504-02CE-4226-A385-4F11FB04B41B")]
[NativeTypeName("struct ISpiControllerProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpiControllerProvider : ISpiControllerProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpiControllerProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpiControllerProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpiControllerProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpiControllerProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpiControllerProvider, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpiControllerProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpiControllerProvider, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceProvider(
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings *")]
            IProviderSpiConnectionSettings settings,
        [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiDeviceProvider **")]
            ISpiDeviceProvider* result
    )
    {
        return (
            (delegate* unmanaged<
                ISpiControllerProvider,
                IProviderSpiConnectionSettings,
                ISpiDeviceProvider*,
                int>)((*lpVtbl)[6])
        )(this, settings, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceProvider(
            [NativeTypeName(
                "ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings *"
            )]
                IProviderSpiConnectionSettings settings,
            [NativeTypeName("ABI::Windows::Devices::Spi::Provider::ISpiDeviceProvider **")]
                ISpiDeviceProvider* result
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
            "HRESULT (ABI::Windows::Devices::Spi::Provider::IProviderSpiConnectionSettings *, ABI::Windows::Devices::Spi::Provider::ISpiDeviceProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IProviderSpiConnectionSettings,
            ISpiDeviceProvider*,
            int> GetDeviceProvider;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpiControllerProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpiControllerProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpiControllerProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpiControllerProvider(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpiControllerProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpiControllerProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpiControllerProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpiControllerProvider value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpiControllerProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpiControllerProvider(Silk.NET.Windows.IUnknown value)
    {
        return new ISpiControllerProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpiControllerProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpiControllerProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpiControllerProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
