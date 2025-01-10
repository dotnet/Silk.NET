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

[Guid("947B03EB-8342-4792-A2E5-925636378A53")]
[NativeTypeName("struct ISmartCardCryptogramPlacementStep : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramPlacementStep
    : ISmartCardCryptogramPlacementStep.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramPlacementStep));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Algorithm(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm *")]
            SmartCardCryptogramAlgorithm* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramPlacementStep,
                SmartCardCryptogramAlgorithm*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Algorithm(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm")]
            SmartCardCryptogramAlgorithm value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramPlacementStep,
                SmartCardCryptogramAlgorithm,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceData(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, IBuffer*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SourceData(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, IBuffer, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CryptogramMaterialPackageName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, HSTRING*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CryptogramMaterialPackageName(HSTRING value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, HSTRING, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CryptogramMaterialName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CryptogramMaterialName(HSTRING value)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramPlacementStep, HSTRING, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_TemplateOffset([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, int*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_TemplateOffset([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, int, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CryptogramOffset([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, int*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CryptogramOffset([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, int, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_CryptogramLength([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, int*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CryptogramLength([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramPlacementStep, int, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_CryptogramPlacementOptions(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions *")]
            SmartCardCryptogramPlacementOptions* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramPlacementStep,
                SmartCardCryptogramPlacementOptions*,
                int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_CryptogramPlacementOptions(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions")]
            SmartCardCryptogramPlacementOptions value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramPlacementStep,
                SmartCardCryptogramPlacementOptions,
                int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_ChainedOutputStep(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep **")]
            ISmartCardCryptogramPlacementStep* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramPlacementStep,
                ISmartCardCryptogramPlacementStep*,
                int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_ChainedOutputStep(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep *")]
            ISmartCardCryptogramPlacementStep value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramPlacementStep,
                ISmartCardCryptogramPlacementStep,
                int>)((*lpVtbl)[23])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Algorithm(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm *")]
                SmartCardCryptogramAlgorithm* value
        );

        [VtblIndex(7)]
        HRESULT put_Algorithm(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm")]
                SmartCardCryptogramAlgorithm value
        );

        [VtblIndex(8)]
        HRESULT get_SourceData(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(9)]
        HRESULT put_SourceData(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
        );

        [VtblIndex(10)]
        HRESULT get_CryptogramMaterialPackageName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_CryptogramMaterialPackageName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_CryptogramMaterialName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_CryptogramMaterialName(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_TemplateOffset([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT put_TemplateOffset([NativeTypeName("INT32")] int value);

        [VtblIndex(16)]
        HRESULT get_CryptogramOffset([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT put_CryptogramOffset([NativeTypeName("INT32")] int value);

        [VtblIndex(18)]
        HRESULT get_CryptogramLength([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT put_CryptogramLength([NativeTypeName("INT32")] int value);

        [VtblIndex(20)]
        HRESULT get_CryptogramPlacementOptions(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions *"
            )]
                SmartCardCryptogramPlacementOptions* value
        );

        [VtblIndex(21)]
        HRESULT put_CryptogramPlacementOptions(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions"
            )]
                SmartCardCryptogramPlacementOptions value
        );

        [VtblIndex(22)]
        HRESULT get_ChainedOutputStep(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep **"
            )]
                ISmartCardCryptogramPlacementStep* value
        );

        [VtblIndex(23)]
        HRESULT put_ChainedOutputStep(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep *"
            )]
                ISmartCardCryptogramPlacementStep value
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
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardCryptogramAlgorithm*, int> get_Algorithm;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramAlgorithm) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardCryptogramAlgorithm, int> put_Algorithm;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_SourceData;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> put_SourceData;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CryptogramMaterialPackageName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_CryptogramMaterialPackageName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CryptogramMaterialName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_CryptogramMaterialName;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TemplateOffset;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_TemplateOffset;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CryptogramOffset;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_CryptogramOffset;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CryptogramLength;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_CryptogramLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardCryptogramPlacementOptions*,
            int> get_CryptogramPlacementOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramPlacementOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardCryptogramPlacementOptions,
            int> put_CryptogramPlacementOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmartCardCryptogramPlacementStep*,
            int> get_ChainedOutputStep;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardCryptogramPlacementStep *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmartCardCryptogramPlacementStep,
            int> put_ChainedOutputStep;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardCryptogramPlacementStep"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardCryptogramPlacementStep(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardCryptogramPlacementStep"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramPlacementStep(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardCryptogramPlacementStep(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramPlacementStep"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramPlacementStep"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardCryptogramPlacementStep value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardCryptogramPlacementStep"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramPlacementStep(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardCryptogramPlacementStep(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramPlacementStep"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramPlacementStep"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardCryptogramPlacementStep value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
