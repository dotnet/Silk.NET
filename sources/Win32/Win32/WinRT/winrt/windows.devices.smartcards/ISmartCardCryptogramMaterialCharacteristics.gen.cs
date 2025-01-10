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

[Guid("FC9AC5CC-C1D7-4153-923B-A2D43C6C8D49")]
[NativeTypeName("struct ISmartCardCryptogramMaterialCharacteristics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramMaterialCharacteristics
    : ISmartCardCryptogramMaterialCharacteristics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramMaterialCharacteristics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MaterialName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, HSTRING*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AllowedAlgorithms(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **"
        )]
            IVectorView<SmartCardCryptogramAlgorithm>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramMaterialCharacteristics,
                IVectorView<SmartCardCryptogramAlgorithm>**,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AllowedProofOfPossessionAlgorithms(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **"
        )]
            IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramMaterialCharacteristics,
                IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AllowedValidations(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **"
        )]
            IVectorView<SmartCardCryptogramAlgorithm>** value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramMaterialCharacteristics,
                IVectorView<SmartCardCryptogramAlgorithm>**,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaterialType(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialType *")]
            SmartCardCryptogramMaterialType* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramMaterialCharacteristics,
                SmartCardCryptogramMaterialType*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ProtectionMethod(
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialProtectionMethod *"
        )]
            SmartCardCryptogramMaterialProtectionMethod* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramMaterialCharacteristics,
                SmartCardCryptogramMaterialProtectionMethod*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ProtectionVersion([NativeTypeName("INT32 *")] int* value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, int*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MaterialLength([NativeTypeName("INT32 *")] int* value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramMaterialCharacteristics, int*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MaterialName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_AllowedAlgorithms(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **"
            )]
                IVectorView<SmartCardCryptogramAlgorithm>** value
        );

        [VtblIndex(8)]
        HRESULT get_AllowedProofOfPossessionAlgorithms(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **"
            )]
                IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** value
        );

        [VtblIndex(9)]
        HRESULT get_AllowedValidations(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **"
            )]
                IVectorView<SmartCardCryptogramAlgorithm>** value
        );

        [VtblIndex(10)]
        HRESULT get_MaterialType(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialType *")]
                SmartCardCryptogramMaterialType* value
        );

        [VtblIndex(11)]
        HRESULT get_ProtectionMethod(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialProtectionMethod *"
            )]
                SmartCardCryptogramMaterialProtectionMethod* value
        );

        [VtblIndex(12)]
        HRESULT get_ProtectionVersion([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_MaterialLength([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MaterialName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramAlgorithm>**,
            int> get_AllowedAlgorithms;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**,
            int> get_AllowedProofOfPossessionAlgorithms;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramAlgorithm>**,
            int> get_AllowedValidations;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardCryptogramMaterialType*, int> get_MaterialType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialProtectionMethod *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardCryptogramMaterialProtectionMethod*,
            int> get_ProtectionMethod;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ProtectionVersion;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MaterialLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardCryptogramMaterialCharacteristics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardCryptogramMaterialCharacteristics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardCryptogramMaterialCharacteristics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramMaterialCharacteristics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardCryptogramMaterialCharacteristics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramMaterialCharacteristics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramMaterialCharacteristics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardCryptogramMaterialCharacteristics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardCryptogramMaterialCharacteristics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramMaterialCharacteristics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardCryptogramMaterialCharacteristics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramMaterialCharacteristics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramMaterialCharacteristics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardCryptogramMaterialCharacteristics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
