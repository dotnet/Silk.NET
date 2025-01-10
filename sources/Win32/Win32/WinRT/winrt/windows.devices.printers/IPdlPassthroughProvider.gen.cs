// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("23C71DD2-6117-553F-9378-180AF5849A49")]
[NativeTypeName("struct IPdlPassthroughProvider : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPdlPassthroughProvider
    : IPdlPassthroughProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPdlPassthroughProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPdlPassthroughProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPdlPassthroughProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPdlPassthroughProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPdlPassthroughProvider, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPdlPassthroughProvider, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPdlPassthroughProvider, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedPdlContentTypes(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** value
    )
    {
        return (
            (delegate* unmanaged<IPdlPassthroughProvider, IVectorView<HSTRING>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartPrintJobWithTaskOptions(
        HSTRING jobName,
        HSTRING pdlContentType,
        [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore *")]
            IPrintTaskOptionsCore taskOptions,
        [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")]
            IPageConfigurationSettings pageConfigurationSettings,
        [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")]
            IPdlPassthroughTarget* result
    )
    {
        return (
            (delegate* unmanaged<
                IPdlPassthroughProvider,
                HSTRING,
                HSTRING,
                IPrintTaskOptionsCore,
                IPageConfigurationSettings,
                IPdlPassthroughTarget*,
                int>)((*lpVtbl)[7])
        )(this, jobName, pdlContentType, taskOptions, pageConfigurationSettings, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StartPrintJobWithPrintTicket(
        HSTRING jobName,
        HSTRING pdlContentType,
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream printTicket,
        [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")]
            IPageConfigurationSettings pageConfigurationSettings,
        [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")]
            IPdlPassthroughTarget* result
    )
    {
        return (
            (delegate* unmanaged<
                IPdlPassthroughProvider,
                HSTRING,
                HSTRING,
                IInputStream,
                IPageConfigurationSettings,
                IPdlPassthroughTarget*,
                int>)((*lpVtbl)[8])
        )(this, jobName, pdlContentType, printTicket, pageConfigurationSettings, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedPdlContentTypes(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** value
        );

        [VtblIndex(7)]
        HRESULT StartPrintJobWithTaskOptions(
            HSTRING jobName,
            HSTRING pdlContentType,
            [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore *")]
                IPrintTaskOptionsCore taskOptions,
            [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")]
                IPageConfigurationSettings pageConfigurationSettings,
            [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")]
                IPdlPassthroughTarget* result
        );

        [VtblIndex(8)]
        HRESULT StartPrintJobWithPrintTicket(
            HSTRING jobName,
            HSTRING pdlContentType,
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
                IInputStream printTicket,
            [NativeTypeName("ABI::Windows::Devices::Printers::IPageConfigurationSettings *")]
                IPageConfigurationSettings pageConfigurationSettings,
            [NativeTypeName("ABI::Windows::Devices::Printers::IPdlPassthroughTarget **")]
                IPdlPassthroughTarget* result
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<HSTRING>**,
            int> get_SupportedPdlContentTypes;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Graphics::Printing::IPrintTaskOptionsCore *, ABI::Windows::Devices::Printers::IPageConfigurationSettings *, ABI::Windows::Devices::Printers::IPdlPassthroughTarget **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IPrintTaskOptionsCore,
            IPageConfigurationSettings,
            IPdlPassthroughTarget*,
            int> StartPrintJobWithTaskOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Devices::Printers::IPageConfigurationSettings *, ABI::Windows::Devices::Printers::IPdlPassthroughTarget **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IInputStream,
            IPageConfigurationSettings,
            IPdlPassthroughTarget*,
            int> StartPrintJobWithPrintTicket;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPdlPassthroughProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPdlPassthroughProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPdlPassthroughProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPdlPassthroughProvider(Silk.NET.WinRT.IInspectable value)
    {
        return new IPdlPassthroughProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPdlPassthroughProvider"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPdlPassthroughProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPdlPassthroughProvider value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPdlPassthroughProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPdlPassthroughProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IPdlPassthroughProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPdlPassthroughProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPdlPassthroughProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPdlPassthroughProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
