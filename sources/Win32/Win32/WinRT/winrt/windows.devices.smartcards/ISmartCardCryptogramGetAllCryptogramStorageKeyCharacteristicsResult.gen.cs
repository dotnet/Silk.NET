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

[Guid("8C7CE857-A7E7-489D-B9D6-368061515012")]
[NativeTypeName(
    "struct ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult : IInspectable"
)]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
    : ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(
                    in IID_ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult
                )
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OperationStatus(
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *"
        )]
            SmartCardCryptogramGeneratorOperationStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                SmartCardCryptogramGeneratorOperationStatus*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Characteristics(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCharacteristics_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OperationStatus(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *"
            )]
                SmartCardCryptogramGeneratorOperationStatus* value
        );

        [VtblIndex(7)]
        HRESULT get_Characteristics(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCharacteristics_t **"
            )]
                IVectorView<IntPtr>** value
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
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramGeneratorOperationStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardCryptogramGeneratorOperationStatus*,
            int> get_OperationStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCharacteristics_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_Characteristics;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult(
            value.lpVtbl
        );
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult(
            value.lpVtbl
        );
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
