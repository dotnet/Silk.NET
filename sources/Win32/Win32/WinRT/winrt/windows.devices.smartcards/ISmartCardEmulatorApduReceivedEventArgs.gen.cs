// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D55D1576-69D2-5333-5B5F-F8C0D6E9F09F")]
[NativeTypeName("struct ISmartCardEmulatorApduReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorApduReceivedEventArgs
    : ISmartCardEmulatorApduReceivedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulatorApduReceivedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CommandApdu(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgs, IBuffer*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ConnectionProperties(
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **"
        )]
            ISmartCardEmulatorConnectionProperties* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgs,
                ISmartCardEmulatorConnectionProperties*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryRespondAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer responseApdu,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgs,
                IBuffer,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[8])
        )(this, responseApdu, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AutomaticResponseStatus(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardAutomaticResponseStatus *")]
            SmartCardAutomaticResponseStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgs,
                SmartCardAutomaticResponseStatus*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CommandApdu(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(7)]
        HRESULT get_ConnectionProperties(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **"
            )]
                ISmartCardEmulatorConnectionProperties* value
        );

        [VtblIndex(8)]
        HRESULT TryRespondAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer responseApdu,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(9)]
        HRESULT get_AutomaticResponseStatus(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardAutomaticResponseStatus *"
            )]
                SmartCardAutomaticResponseStatus* value
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_CommandApdu;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardEmulatorConnectionProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmartCardEmulatorConnectionProperties*,
            int> get_ConnectionProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, IAsyncOperation<byte>**, int> TryRespondAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardAutomaticResponseStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardAutomaticResponseStatus*,
            int> get_AutomaticResponseStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardEmulatorApduReceivedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardEmulatorApduReceivedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardEmulatorApduReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardEmulatorApduReceivedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardEmulatorApduReceivedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardEmulatorApduReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardEmulatorApduReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardEmulatorApduReceivedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
