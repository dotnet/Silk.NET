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

[Guid("10D43942-DD94-5998-B235-AFAFB6FA7935")]
[NativeTypeName("struct IIppAttributeValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IIppAttributeValueStatics
    : IIppAttributeValueStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIppAttributeValueStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIppAttributeValueStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IIppAttributeValueStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIppAttributeValueStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IIppAttributeValueStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IIppAttributeValueStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IIppAttributeValueStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateUnsupported(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, IIppAttributeValue*, int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateUnknown(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, IIppAttributeValue*, int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateNoValue(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, IIppAttributeValue*, int>)((*lpVtbl)[8])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateInteger(
        [NativeTypeName("INT32")] int value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, int, IIppAttributeValue*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateIntegerArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")]
            IIterable<int>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<int>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[10])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateBoolean(
        [NativeTypeName("boolean")] byte value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, byte, IIppAttributeValue*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateBooleanArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_boolean_t *")]
            IIterable<byte>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<byte>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[12])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateEnum(
        [NativeTypeName("INT32")] int value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, int, IIppAttributeValue*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateEnumArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")]
            IIterable<int>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<int>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[14])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateOctetString(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, IBuffer, IIppAttributeValue*, int>)(
                (*lpVtbl)[15]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateOctetStringArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStreams__CIBuffer_t *"
        )]
            IIterable<IntPtr>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[16])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                WinRTDateTime,
                IIppAttributeValue*,
                int>)((*lpVtbl)[17])
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateDateTimeArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CDateTime_t *"
        )]
            IIterable<DateTime>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<DateTime>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[18])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateResolution(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution *")] IIppResolution value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIppResolution,
                IIppAttributeValue*,
                int>)((*lpVtbl)[19])
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateResolutionArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppResolution_t *"
        )]
            IIterable<IntPtr>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[20])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateRangeOfInteger(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppIntegerRange *")]
            IIppIntegerRange value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIppIntegerRange,
                IIppAttributeValue*,
                int>)((*lpVtbl)[21])
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateRangeOfIntegerArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppIntegerRange_t *"
        )]
            IIterable<IntPtr>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[22])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateCollection(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* memberAttributes,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[23])
        )(this, memberAttributes, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateCollectionArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
        )]
            IIterable<IntPtr>* memberAttributesArray,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[24])
        )(this, memberAttributesArray, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateTextWithLanguage(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")]
            IIppTextWithLanguage value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIppTextWithLanguage,
                IIppAttributeValue*,
                int>)((*lpVtbl)[25])
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateTextWithLanguageArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *"
        )]
            IIterable<IntPtr>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[26])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateNameWithLanguage(
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")]
            IIppTextWithLanguage value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIppTextWithLanguage,
                IIppAttributeValue*,
                int>)((*lpVtbl)[27])
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateNameWithLanguageArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *"
        )]
            IIterable<IntPtr>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[28])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateTextWithoutLanguage(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[29]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateTextWithoutLanguageArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[30])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateNameWithoutLanguage(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[31]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CreateNameWithoutLanguageArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[32])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CreateKeyword(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[33]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT CreateKeywordArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[34])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT CreateUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IUriRuntimeClass,
                IIppAttributeValue*,
                int>)((*lpVtbl)[35])
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateUriArray(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *"
        )]
            IIterable<IntPtr>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<IntPtr>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[36])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT CreateUriSchema(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[37]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT CreateUriSchemaArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[38])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateCharset(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[39]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT CreateCharsetArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[40])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CreateNaturalLanguage(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[41]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT CreateNaturalLanguageArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[42])
        )(this, values, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT CreateMimeMedia(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<IIppAttributeValueStatics, HSTRING, IIppAttributeValue*, int>)(
                (*lpVtbl)[43]
            )
        )(this, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreateMimeMediaArray(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* values,
        [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
            IIppAttributeValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IIppAttributeValueStatics,
                IIterable<HSTRING>*,
                IIppAttributeValue*,
                int>)((*lpVtbl)[44])
        )(this, values, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateUnsupported(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(7)]
        HRESULT CreateUnknown(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(8)]
        HRESULT CreateNoValue(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(9)]
        HRESULT CreateInteger(
            [NativeTypeName("INT32")] int value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(10)]
        HRESULT CreateIntegerArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")]
                IIterable<int>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(11)]
        HRESULT CreateBoolean(
            [NativeTypeName("boolean")] byte value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(12)]
        HRESULT CreateBooleanArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_boolean_t *")]
                IIterable<byte>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(13)]
        HRESULT CreateEnum(
            [NativeTypeName("INT32")] int value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(14)]
        HRESULT CreateEnumArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *")]
                IIterable<int>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(15)]
        HRESULT CreateOctetString(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(16)]
        HRESULT CreateOctetStringArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStreams__CIBuffer_t *"
            )]
                IIterable<IntPtr>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(17)]
        HRESULT CreateDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(18)]
        HRESULT CreateDateTimeArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CDateTime_t *"
            )]
                IIterable<DateTime>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(19)]
        HRESULT CreateResolution(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppResolution *")]
                IIppResolution value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(20)]
        HRESULT CreateResolutionArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppResolution_t *"
            )]
                IIterable<IntPtr>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(21)]
        HRESULT CreateRangeOfInteger(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppIntegerRange *")]
                IIppIntegerRange value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(22)]
        HRESULT CreateRangeOfIntegerArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppIntegerRange_t *"
            )]
                IIterable<IntPtr>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(23)]
        HRESULT CreateCollection(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* memberAttributes,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(24)]
        HRESULT CreateCollectionArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *"
            )]
                IIterable<IntPtr>* memberAttributesArray,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(25)]
        HRESULT CreateTextWithLanguage(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")]
                IIppTextWithLanguage value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(26)]
        HRESULT CreateTextWithLanguageArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *"
            )]
                IIterable<IntPtr>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(27)]
        HRESULT CreateNameWithLanguage(
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppTextWithLanguage *")]
                IIppTextWithLanguage value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(28)]
        HRESULT CreateNameWithLanguageArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *"
            )]
                IIterable<IntPtr>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(29)]
        HRESULT CreateTextWithoutLanguage(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(30)]
        HRESULT CreateTextWithoutLanguageArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(31)]
        HRESULT CreateNameWithoutLanguage(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(32)]
        HRESULT CreateNameWithoutLanguageArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(33)]
        HRESULT CreateKeyword(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(34)]
        HRESULT CreateKeywordArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(35)]
        HRESULT CreateUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(36)]
        HRESULT CreateUriArray(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *"
            )]
                IIterable<IntPtr>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(37)]
        HRESULT CreateUriSchema(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(38)]
        HRESULT CreateUriSchemaArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(39)]
        HRESULT CreateCharset(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(40)]
        HRESULT CreateCharsetArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(41)]
        HRESULT CreateNaturalLanguage(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(42)]
        HRESULT CreateNaturalLanguageArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(43)]
        HRESULT CreateMimeMedia(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
        );

        [VtblIndex(44)]
        HRESULT CreateMimeMediaArray(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* values,
            [NativeTypeName("ABI::Windows::Devices::Printers::IIppAttributeValue **")]
                IIppAttributeValue* result
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
            "HRESULT (ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIppAttributeValue*, int> CreateUnsupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIppAttributeValue*, int> CreateUnknown;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIppAttributeValue*, int> CreateNoValue;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, IIppAttributeValue*, int> CreateInteger;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<int>*,
            IIppAttributeValue*,
            int> CreateIntegerArray;

        [NativeTypeName(
            "HRESULT (boolean, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte, IIppAttributeValue*, int> CreateBoolean;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_boolean_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<byte>*,
            IIppAttributeValue*,
            int> CreateBooleanArray;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, IIppAttributeValue*, int> CreateEnum;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_int_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<int>*,
            IIppAttributeValue*,
            int> CreateEnumArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, IIppAttributeValue*, int> CreateOctetString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CStreams__CIBuffer_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateOctetStringArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, WinRTDateTime, IIppAttributeValue*, int> CreateDateTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CDateTime_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<DateTime>*,
            IIppAttributeValue*,
            int> CreateDateTimeArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppResolution *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIppResolution,
            IIppAttributeValue*,
            int> CreateResolution;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppResolution_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateResolutionArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppIntegerRange *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIppIntegerRange,
            IIppAttributeValue*,
            int> CreateRangeOfInteger;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppIntegerRange_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateRangeOfIntegerArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateCollection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CDevices__CPrinters__CIppAttributeValue_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateCollectionArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppTextWithLanguage *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIppTextWithLanguage,
            IIppAttributeValue*,
            int> CreateTextWithLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateTextWithLanguageArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Printers::IIppTextWithLanguage *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIppTextWithLanguage,
            IIppAttributeValue*,
            int> CreateNameWithLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CPrinters__CIppTextWithLanguage_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateNameWithLanguageArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIppAttributeValue*,
            int> CreateTextWithoutLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateTextWithoutLanguageArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIppAttributeValue*,
            int> CreateNameWithoutLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateNameWithoutLanguageArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IIppAttributeValue*, int> CreateKeyword;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateKeywordArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, IIppAttributeValue*, int> CreateUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CFoundation__CUri_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IIppAttributeValue*,
            int> CreateUriArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IIppAttributeValue*, int> CreateUriSchema;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateUriSchemaArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IIppAttributeValue*, int> CreateCharset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateCharsetArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IIppAttributeValue*, int> CreateNaturalLanguage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateNaturalLanguageArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IIppAttributeValue*, int> CreateMimeMedia;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Devices::Printers::IIppAttributeValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IIppAttributeValue*,
            int> CreateMimeMediaArray;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIppAttributeValueStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIppAttributeValueStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IIppAttributeValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IIppAttributeValueStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IIppAttributeValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppAttributeValueStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IIppAttributeValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IIppAttributeValueStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIppAttributeValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIppAttributeValueStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IIppAttributeValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIppAttributeValueStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIppAttributeValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IIppAttributeValueStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
