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

[Guid("99407FED-E2BB-59A3-988B-28A974052A26")]
[NativeTypeName("struct IIppAttributeValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppAttributeValue : IIppAttributeValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppAttributeValue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIppAttributeValue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIppAttributeValue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIppAttributeValue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIppAttributeValue, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIppAttributeValue, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Kind(
        [NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeValueKind *")]
            IppAttributeValueKind* value
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValue, IppAttributeValueKind*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetIntegerArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")]
            IVector<int>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<int>**, int>)((*lpVtbl)[7]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBooleanArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_boolean_t **")]
            IVector<byte>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<byte>**, int>)((*lpVtbl)[8]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEnumArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")]
            IVector<int>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<int>**, int>)((*lpVtbl)[9]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOctetStringArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[10]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDateTimeArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CDateTime_t **"
        )]
            IVector<DateTime>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<DateTime>**, int>)((*lpVtbl)[11]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetResolutionArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppResolution_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[12]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetRangeOfIntegerArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppIntegerRange_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[13]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCollectionArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1___FIMapView_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[14]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTextWithLanguageArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[15]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetNameWithLanguageArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[16]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTextWithoutLanguageArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[17]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetNameWithoutLanguageArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[18]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetKeywordArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[19]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetUriArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CUri_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<IntPtr>**, int>)((*lpVtbl)[20]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetUriSchemaArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[21]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetCharsetArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[22]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetNaturalLanguageArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[23]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetMimeMediaTypeArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** result
    )
    {
        return ((delegate* unmanaged<IIppAttributeValue, IVector<HSTRING>**, int>)((*lpVtbl)[24]))(
            this,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Kind(
            [NativeTypeName("ABI::Windows::Devices::Printers::IppAttributeValueKind *")]
                IppAttributeValueKind* value
        );

        [VtblIndex(7)]
        HRESULT GetIntegerArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")]
                IVector<int>** result
        );

        [VtblIndex(8)]
        HRESULT GetBooleanArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_boolean_t **")]
                IVector<byte>** result
        );

        [VtblIndex(9)]
        HRESULT GetEnumArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_int_t **")]
                IVector<int>** result
        );

        [VtblIndex(10)]
        HRESULT GetOctetStringArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT GetDateTimeArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CDateTime_t **"
            )]
                IVector<DateTime>** result
        );

        [VtblIndex(12)]
        HRESULT GetResolutionArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppResolution_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(13)]
        HRESULT GetRangeOfIntegerArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppIntegerRange_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(14)]
        HRESULT GetCollectionArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1___FIMapView_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(15)]
        HRESULT GetTextWithLanguageArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(16)]
        HRESULT GetNameWithLanguageArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(17)]
        HRESULT GetTextWithoutLanguageArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
        );

        [VtblIndex(18)]
        HRESULT GetNameWithoutLanguageArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
        );

        [VtblIndex(19)]
        HRESULT GetKeywordArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
        );

        [VtblIndex(20)]
        HRESULT GetUriArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CUri_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(21)]
        HRESULT GetUriSchemaArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
        );

        [VtblIndex(22)]
        HRESULT GetCharsetArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
        );

        [VtblIndex(23)]
        HRESULT GetNaturalLanguageArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
        );

        [VtblIndex(24)]
        HRESULT GetMimeMediaTypeArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** result
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
            "HRESULT (ABI::Windows::Devices::Printers::IppAttributeValueKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IppAttributeValueKind*, int> get_Kind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<int>**, int> GetIntegerArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<byte>**, int> GetBooleanArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<int>**, int> GetEnumArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetOctetStringArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<DateTime>**, int> GetDateTimeArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppResolution_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetResolutionArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppIntegerRange_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetRangeOfIntegerArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1___FIMapView_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetCollectionArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetTextWithLanguageArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetNameWithLanguageArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetTextWithoutLanguageArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetNameWithoutLanguageArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetKeywordArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> GetUriArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetUriSchemaArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetCharsetArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetNaturalLanguageArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> GetMimeMediaTypeArray;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIppAttributeValue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIppAttributeValue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIppAttributeValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIppAttributeValue(Silk.NET.WinRT.IInspectable value)
    {
        return new IIppAttributeValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppAttributeValue"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIppAttributeValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIppAttributeValue value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIppAttributeValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIppAttributeValue(Silk.NET.Windows.IUnknown value)
    {
        return new IIppAttributeValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppAttributeValue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIppAttributeValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIppAttributeValue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
