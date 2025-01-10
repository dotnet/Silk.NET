// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("130B3C0A-F565-476E-ABD5-EA05AEE74C69")]
[NativeTypeName("struct IHdmiDisplayInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHdmiDisplayInformation
    : IHdmiDisplayInformation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHdmiDisplayInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHdmiDisplayInformation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHdmiDisplayInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHdmiDisplayInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHdmiDisplayInformation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHdmiDisplayInformation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHdmiDisplayInformation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSupportedDisplayModes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayMode_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IHdmiDisplayInformation, IVectorView<IntPtr>**, int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCurrentDisplayMode(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode **")]
            IHdmiDisplayMode* result
    )
    {
        return (
            (delegate* unmanaged<IHdmiDisplayInformation, IHdmiDisplayMode*, int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDefaultDisplayModeAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IHdmiDisplayInformation, IAsyncAction*, int>)((*lpVtbl)[8]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestSetCurrentDisplayModeAsync(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
            IHdmiDisplayMode mode,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHdmiDisplayInformation,
                IHdmiDisplayMode,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[9])
        )(this, mode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestSetCurrentDisplayModeWithHdrAsync(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
            IHdmiDisplayMode mode,
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")]
            HdmiDisplayHdrOption hdrOption,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHdmiDisplayInformation,
                IHdmiDisplayMode,
                HdmiDisplayHdrOption,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[10])
        )(this, mode, hdrOption, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestSetCurrentDisplayModeWithHdrAndMetadataAsync(
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
            IHdmiDisplayMode mode,
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")]
            HdmiDisplayHdrOption hdrOption,
        [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdr2086Metadata")]
            HdmiDisplayHdr2086Metadata hdrMetadata,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHdmiDisplayInformation,
                IHdmiDisplayMode,
                HdmiDisplayHdrOption,
                HdmiDisplayHdr2086Metadata,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[11])
        )(this, mode, hdrOption, hdrMetadata, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_DisplayModesChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayInformation_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IHdmiDisplayInformation,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_DisplayModesChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IHdmiDisplayInformation, EventRegistrationToken, int>)(
                (*lpVtbl)[13]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSupportedDisplayModes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayMode_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT GetCurrentDisplayMode(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode **")]
                IHdmiDisplayMode* result
        );

        [VtblIndex(8)]
        HRESULT SetDefaultDisplayModeAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(9)]
        HRESULT RequestSetCurrentDisplayModeAsync(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
                IHdmiDisplayMode mode,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(10)]
        HRESULT RequestSetCurrentDisplayModeWithHdrAsync(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
                IHdmiDisplayMode mode,
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")]
                HdmiDisplayHdrOption hdrOption,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(11)]
        HRESULT RequestSetCurrentDisplayModeWithHdrAndMetadataAsync(
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *")]
                IHdmiDisplayMode mode,
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption")]
                HdmiDisplayHdrOption hdrOption,
            [NativeTypeName("ABI::Windows::Graphics::Display::Core::HdmiDisplayHdr2086Metadata")]
                HdmiDisplayHdr2086Metadata hdrMetadata,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(12)]
        HRESULT add_DisplayModesChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayInformation_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_DisplayModesChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayMode_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetSupportedDisplayModes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHdmiDisplayMode*, int> GetCurrentDisplayMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> SetDefaultDisplayModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHdmiDisplayMode,
            IAsyncOperation<byte>**,
            int> RequestSetCurrentDisplayModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHdmiDisplayMode,
            HdmiDisplayHdrOption,
            IAsyncOperation<byte>**,
            int> RequestSetCurrentDisplayModeWithHdrAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::Core::IHdmiDisplayMode *, ABI::Windows::Graphics::Display::Core::HdmiDisplayHdrOption, ABI::Windows::Graphics::Display::Core::HdmiDisplayHdr2086Metadata, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHdmiDisplayMode,
            HdmiDisplayHdrOption,
            HdmiDisplayHdr2086Metadata,
            IAsyncOperation<byte>**,
            int> RequestSetCurrentDisplayModeWithHdrAndMetadataAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CDisplay__CCore__CHdmiDisplayInformation_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DisplayModesChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_DisplayModesChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHdmiDisplayInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHdmiDisplayInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHdmiDisplayInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHdmiDisplayInformation(Silk.NET.WinRT.IInspectable value)
    {
        return new IHdmiDisplayInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHdmiDisplayInformation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHdmiDisplayInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHdmiDisplayInformation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHdmiDisplayInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHdmiDisplayInformation(Silk.NET.Windows.IUnknown value)
    {
        return new IHdmiDisplayInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHdmiDisplayInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHdmiDisplayInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHdmiDisplayInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
