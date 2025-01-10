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

[Guid("2798E029-D687-4C92-86C6-399E9A0ECB09")]
[NativeTypeName(
    "struct ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult : IInspectable"
)]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult
    : ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(
                    in IID_ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult
                )
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
                SmartCardCryptogramGeneratorOperationStatus*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Characteristics(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialCharacteristics_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult,
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
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialCharacteristics_t **"
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialCharacteristics_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_Characteristics;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
