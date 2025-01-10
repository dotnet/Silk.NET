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

[Guid("3F7CFF48-C534-4E9E-94C3-52EF2AFD5D07")]
[NativeTypeName("struct IFocusControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFocusControl2 : IFocusControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFocusControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFocusControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFocusControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFocusControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFocusControl2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFocusControl2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFocusControl2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FocusChangedSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFocusControl2, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_WaitForFocusSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFocusControl2, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedFocusModes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CFocusMode_t **"
        )]
            IVectorView<FocusMode>** value
    )
    {
        return ((delegate* unmanaged<IFocusControl2, IVectorView<FocusMode>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedFocusDistances(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CManualFocusDistance_t **"
        )]
            IVectorView<ManualFocusDistance>** value
    )
    {
        return (
            (delegate* unmanaged<IFocusControl2, IVectorView<ManualFocusDistance>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SupportedFocusRanges(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAutoFocusRange_t **"
        )]
            IVectorView<AutoFocusRange>** value
    )
    {
        return (
            (delegate* unmanaged<IFocusControl2, IVectorView<AutoFocusRange>**, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Mode(
        [NativeTypeName("ABI::Windows::Media::Devices::FocusMode *")] FocusMode* value
    )
    {
        return ((delegate* unmanaged<IFocusControl2, FocusMode*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_FocusState(
        [NativeTypeName("ABI::Windows::Media::Devices::MediaCaptureFocusState *")]
            MediaCaptureFocusState* value
    )
    {
        return ((delegate* unmanaged<IFocusControl2, MediaCaptureFocusState*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT UnlockAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IFocusControl2, IAsyncAction*, int>)((*lpVtbl)[13]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT LockAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
    )
    {
        return ((delegate* unmanaged<IFocusControl2, IAsyncAction*, int>)((*lpVtbl)[14]))(
            this,
            asyncInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT Configure(
        [NativeTypeName("ABI::Windows::Media::Devices::IFocusSettings *")] IFocusSettings settings
    )
    {
        return ((delegate* unmanaged<IFocusControl2, IFocusSettings, int>)((*lpVtbl)[15]))(
            this,
            settings
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FocusChangedSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_WaitForFocusSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_SupportedFocusModes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CFocusMode_t **"
            )]
                IVectorView<FocusMode>** value
        );

        [VtblIndex(9)]
        HRESULT get_SupportedFocusDistances(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CManualFocusDistance_t **"
            )]
                IVectorView<ManualFocusDistance>** value
        );

        [VtblIndex(10)]
        HRESULT get_SupportedFocusRanges(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAutoFocusRange_t **"
            )]
                IVectorView<AutoFocusRange>** value
        );

        [VtblIndex(11)]
        HRESULT get_Mode(
            [NativeTypeName("ABI::Windows::Media::Devices::FocusMode *")] FocusMode* value
        );

        [VtblIndex(12)]
        HRESULT get_FocusState(
            [NativeTypeName("ABI::Windows::Media::Devices::MediaCaptureFocusState *")]
                MediaCaptureFocusState* value
        );

        [VtblIndex(13)]
        HRESULT UnlockAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(14)]
        HRESULT LockAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* asyncInfo
        );

        [VtblIndex(15)]
        HRESULT Configure(
            [NativeTypeName("ABI::Windows::Media::Devices::IFocusSettings *")]
                IFocusSettings settings
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
        public delegate* unmanaged<TSelf*, byte*, int> get_FocusChangedSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_WaitForFocusSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CFocusMode_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<FocusMode>**, int> get_SupportedFocusModes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CManualFocusDistance_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<ManualFocusDistance>**,
            int> get_SupportedFocusDistances;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CDevices__CAutoFocusRange_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<AutoFocusRange>**,
            int> get_SupportedFocusRanges;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::FocusMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FocusMode*, int> get_Mode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::MediaCaptureFocusState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCaptureFocusState*, int> get_FocusState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> UnlockAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> LockAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IFocusSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFocusSettings, int> Configure;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFocusControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFocusControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFocusControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFocusControl2(Silk.NET.WinRT.IInspectable value)
    {
        return new IFocusControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFocusControl2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFocusControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFocusControl2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFocusControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFocusControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IFocusControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFocusControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFocusControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFocusControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
