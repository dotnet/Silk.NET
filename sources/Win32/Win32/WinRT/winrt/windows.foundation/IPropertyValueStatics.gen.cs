// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("629BDBC8-D932-4FF4-96B9-8D96C5C1E858")]
[NativeTypeName("struct IPropertyValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPropertyValueStatics : IPropertyValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyValueStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyValueStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyValueStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyValueStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPropertyValueStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPropertyValueStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPropertyValueStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateEmpty(IInspectable* propertyValue)
    {
        return ((delegate* unmanaged<IPropertyValueStatics, IInspectable*, int>)((*lpVtbl)[6]))(
            this,
            propertyValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateUInt8(byte value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, byte, IInspectable*, int>)((*lpVtbl)[7])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateInt16([NativeTypeName("INT16")] short value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, short, IInspectable*, int>)((*lpVtbl)[8])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateUInt16(
        [NativeTypeName("UINT16")] ushort value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, ushort, IInspectable*, int>)((*lpVtbl)[9])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateInt32([NativeTypeName("INT32")] int value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, int, IInspectable*, int>)((*lpVtbl)[10])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateUInt32([NativeTypeName("UINT32")] uint value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, IInspectable*, int>)((*lpVtbl)[11])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateInt64([NativeTypeName("INT64")] long value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, long, IInspectable*, int>)((*lpVtbl)[12])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateUInt64([NativeTypeName("UINT64")] ulong value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, ulong, IInspectable*, int>)((*lpVtbl)[13])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateSingle(float value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, float, IInspectable*, int>)((*lpVtbl)[14])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateDouble(double value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, double, IInspectable*, int>)((*lpVtbl)[15])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateChar16([NativeTypeName("WCHAR")] ushort value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, ushort, IInspectable*, int>)((*lpVtbl)[16])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateBoolean(
        [NativeTypeName("boolean")] byte value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, byte, IInspectable*, int>)((*lpVtbl)[17])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateString(HSTRING value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, HSTRING, IInspectable*, int>)((*lpVtbl)[18])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateInspectable(IInspectable value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, IInspectable, IInspectable*, int>)(
                (*lpVtbl)[19]
            )
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateGuid(Guid value, IInspectable* propertyValue)
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, Guid, IInspectable*, int>)((*lpVtbl)[20])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, WinRTDateTime, IInspectable*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateTimeSpan(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, TimeSpan, IInspectable*, int>)(
                (*lpVtbl)[22]
            )
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreatePoint(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, Point, IInspectable*, int>)((*lpVtbl)[23])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateSize(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, Size, IInspectable*, int>)((*lpVtbl)[24])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateRect(
        [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, Rect, IInspectable*, int>)((*lpVtbl)[25])
        )(this, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateUInt8Array(
        [NativeTypeName("UINT32")] uint valueLength,
        byte* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, byte*, IInspectable*, int>)(
                (*lpVtbl)[26]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateInt16Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("INT16 *")] short* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, short*, IInspectable*, int>)(
                (*lpVtbl)[27]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateUInt16Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("UINT16 *")] ushort* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, ushort*, IInspectable*, int>)(
                (*lpVtbl)[28]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT CreateInt32Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("INT32 *")] int* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, int*, IInspectable*, int>)(
                (*lpVtbl)[29]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT CreateUInt32Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("UINT32 *")] uint* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, uint*, IInspectable*, int>)(
                (*lpVtbl)[30]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CreateInt64Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("INT64 *")] long* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, long*, IInspectable*, int>)(
                (*lpVtbl)[31]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CreateUInt64Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("UINT64 *")] ulong* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, ulong*, IInspectable*, int>)(
                (*lpVtbl)[32]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT CreateSingleArray(
        [NativeTypeName("UINT32")] uint valueLength,
        float* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, float*, IInspectable*, int>)(
                (*lpVtbl)[33]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT CreateDoubleArray(
        [NativeTypeName("UINT32")] uint valueLength,
        double* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, double*, IInspectable*, int>)(
                (*lpVtbl)[34]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT CreateChar16Array(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("WCHAR *")] ushort* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, ushort*, IInspectable*, int>)(
                (*lpVtbl)[35]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CreateBooleanArray(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("boolean *")] byte* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, byte*, IInspectable*, int>)(
                (*lpVtbl)[36]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT CreateStringArray(
        [NativeTypeName("UINT32")] uint valueLength,
        HSTRING* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, HSTRING*, IInspectable*, int>)(
                (*lpVtbl)[37]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT CreateInspectableArray(
        [NativeTypeName("UINT32")] uint valueLength,
        IInspectable* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, IInspectable*, IInspectable*, int>)(
                (*lpVtbl)[38]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT CreateGuidArray(
        [NativeTypeName("UINT32")] uint valueLength,
        Guid* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, Guid*, IInspectable*, int>)(
                (*lpVtbl)[39]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT CreateDateTimeArray(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, WinRTDateTime*, IInspectable*, int>)(
                (*lpVtbl)[40]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT CreateTimeSpanArray(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, TimeSpan*, IInspectable*, int>)(
                (*lpVtbl)[41]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT CreatePointArray(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, Point*, IInspectable*, int>)(
                (*lpVtbl)[42]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT CreateSizeArray(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, Size*, IInspectable*, int>)(
                (*lpVtbl)[43]
            )
        )(this, valueLength, value, propertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT CreateRectArray(
        [NativeTypeName("UINT32")] uint valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value,
        IInspectable* propertyValue
    )
    {
        return (
            (delegate* unmanaged<IPropertyValueStatics, uint, Rect*, IInspectable*, int>)(
                (*lpVtbl)[44]
            )
        )(this, valueLength, value, propertyValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateEmpty(IInspectable* propertyValue);

        [VtblIndex(7)]
        HRESULT CreateUInt8(byte value, IInspectable* propertyValue);

        [VtblIndex(8)]
        HRESULT CreateInt16([NativeTypeName("INT16")] short value, IInspectable* propertyValue);

        [VtblIndex(9)]
        HRESULT CreateUInt16([NativeTypeName("UINT16")] ushort value, IInspectable* propertyValue);

        [VtblIndex(10)]
        HRESULT CreateInt32([NativeTypeName("INT32")] int value, IInspectable* propertyValue);

        [VtblIndex(11)]
        HRESULT CreateUInt32([NativeTypeName("UINT32")] uint value, IInspectable* propertyValue);

        [VtblIndex(12)]
        HRESULT CreateInt64([NativeTypeName("INT64")] long value, IInspectable* propertyValue);

        [VtblIndex(13)]
        HRESULT CreateUInt64([NativeTypeName("UINT64")] ulong value, IInspectable* propertyValue);

        [VtblIndex(14)]
        HRESULT CreateSingle(float value, IInspectable* propertyValue);

        [VtblIndex(15)]
        HRESULT CreateDouble(double value, IInspectable* propertyValue);

        [VtblIndex(16)]
        HRESULT CreateChar16([NativeTypeName("WCHAR")] ushort value, IInspectable* propertyValue);

        [VtblIndex(17)]
        HRESULT CreateBoolean([NativeTypeName("boolean")] byte value, IInspectable* propertyValue);

        [VtblIndex(18)]
        HRESULT CreateString(HSTRING value, IInspectable* propertyValue);

        [VtblIndex(19)]
        HRESULT CreateInspectable(IInspectable value, IInspectable* propertyValue);

        [VtblIndex(20)]
        HRESULT CreateGuid(Guid value, IInspectable* propertyValue);

        [VtblIndex(21)]
        HRESULT CreateDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value,
            IInspectable* propertyValue
        );

        [VtblIndex(22)]
        HRESULT CreateTimeSpan(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value,
            IInspectable* propertyValue
        );

        [VtblIndex(23)]
        HRESULT CreatePoint(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point value,
            IInspectable* propertyValue
        );

        [VtblIndex(24)]
        HRESULT CreateSize(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size value,
            IInspectable* propertyValue
        );

        [VtblIndex(25)]
        HRESULT CreateRect(
            [NativeTypeName("ABI::Windows::Foundation::Rect")] Rect value,
            IInspectable* propertyValue
        );

        [VtblIndex(26)]
        HRESULT CreateUInt8Array(
            [NativeTypeName("UINT32")] uint valueLength,
            byte* value,
            IInspectable* propertyValue
        );

        [VtblIndex(27)]
        HRESULT CreateInt16Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("INT16 *")] short* value,
            IInspectable* propertyValue
        );

        [VtblIndex(28)]
        HRESULT CreateUInt16Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("UINT16 *")] ushort* value,
            IInspectable* propertyValue
        );

        [VtblIndex(29)]
        HRESULT CreateInt32Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("INT32 *")] int* value,
            IInspectable* propertyValue
        );

        [VtblIndex(30)]
        HRESULT CreateUInt32Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("UINT32 *")] uint* value,
            IInspectable* propertyValue
        );

        [VtblIndex(31)]
        HRESULT CreateInt64Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("INT64 *")] long* value,
            IInspectable* propertyValue
        );

        [VtblIndex(32)]
        HRESULT CreateUInt64Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("UINT64 *")] ulong* value,
            IInspectable* propertyValue
        );

        [VtblIndex(33)]
        HRESULT CreateSingleArray(
            [NativeTypeName("UINT32")] uint valueLength,
            float* value,
            IInspectable* propertyValue
        );

        [VtblIndex(34)]
        HRESULT CreateDoubleArray(
            [NativeTypeName("UINT32")] uint valueLength,
            double* value,
            IInspectable* propertyValue
        );

        [VtblIndex(35)]
        HRESULT CreateChar16Array(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("WCHAR *")] ushort* value,
            IInspectable* propertyValue
        );

        [VtblIndex(36)]
        HRESULT CreateBooleanArray(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("boolean *")] byte* value,
            IInspectable* propertyValue
        );

        [VtblIndex(37)]
        HRESULT CreateStringArray(
            [NativeTypeName("UINT32")] uint valueLength,
            HSTRING* value,
            IInspectable* propertyValue
        );

        [VtblIndex(38)]
        HRESULT CreateInspectableArray(
            [NativeTypeName("UINT32")] uint valueLength,
            IInspectable* value,
            IInspectable* propertyValue
        );

        [VtblIndex(39)]
        HRESULT CreateGuidArray(
            [NativeTypeName("UINT32")] uint valueLength,
            Guid* value,
            IInspectable* propertyValue
        );

        [VtblIndex(40)]
        HRESULT CreateDateTimeArray(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value,
            IInspectable* propertyValue
        );

        [VtblIndex(41)]
        HRESULT CreateTimeSpanArray(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value,
            IInspectable* propertyValue
        );

        [VtblIndex(42)]
        HRESULT CreatePointArray(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value,
            IInspectable* propertyValue
        );

        [VtblIndex(43)]
        HRESULT CreateSizeArray(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value,
            IInspectable* propertyValue
        );

        [VtblIndex(44)]
        HRESULT CreateRectArray(
            [NativeTypeName("UINT32")] uint valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value,
            IInspectable* propertyValue
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, int> CreateEmpty;

        [NativeTypeName("HRESULT (BYTE, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, IInspectable*, int> CreateUInt8;

        [NativeTypeName("HRESULT (INT16, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IInspectable*, int> CreateInt16;

        [NativeTypeName("HRESULT (UINT16, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, IInspectable*, int> CreateUInt16;

        [NativeTypeName("HRESULT (INT32, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IInspectable*, int> CreateInt32;

        [NativeTypeName("HRESULT (UINT32, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IInspectable*, int> CreateUInt32;

        [NativeTypeName("HRESULT (INT64, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, IInspectable*, int> CreateInt64;

        [NativeTypeName("HRESULT (UINT64, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, IInspectable*, int> CreateUInt64;

        [NativeTypeName("HRESULT (FLOAT, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, IInspectable*, int> CreateSingle;

        [NativeTypeName("HRESULT (DOUBLE, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, IInspectable*, int> CreateDouble;

        [NativeTypeName("HRESULT (WCHAR, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, IInspectable*, int> CreateChar16;

        [NativeTypeName("HRESULT (boolean, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, IInspectable*, int> CreateBoolean;

        [NativeTypeName("HRESULT (HSTRING, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, IInspectable*, int> CreateString;

        [NativeTypeName("HRESULT (IInspectable *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable, IInspectable*, int> CreateInspectable;

        [NativeTypeName("HRESULT (GUID, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, IInspectable*, int> CreateGuid;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::DateTime, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, WinRTDateTime, IInspectable*, int> CreateDateTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::TimeSpan, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimeSpan, IInspectable*, int> CreateTimeSpan;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Point, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Point, IInspectable*, int> CreatePoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Size, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Size, IInspectable*, int> CreateSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Rect, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Rect, IInspectable*, int> CreateRect;

        [NativeTypeName("HRESULT (UINT32, BYTE *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, IInspectable*, int> CreateUInt8Array;

        [NativeTypeName("HRESULT (UINT32, INT16 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, short*, IInspectable*, int> CreateInt16Array;

        [NativeTypeName("HRESULT (UINT32, UINT16 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, IInspectable*, int> CreateUInt16Array;

        [NativeTypeName("HRESULT (UINT32, INT32 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, IInspectable*, int> CreateInt32Array;

        [NativeTypeName("HRESULT (UINT32, UINT32 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, IInspectable*, int> CreateUInt32Array;

        [NativeTypeName("HRESULT (UINT32, INT64 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, long*, IInspectable*, int> CreateInt64Array;

        [NativeTypeName("HRESULT (UINT32, UINT64 *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ulong*, IInspectable*, int> CreateUInt64Array;

        [NativeTypeName("HRESULT (UINT32, FLOAT *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, IInspectable*, int> CreateSingleArray;

        [NativeTypeName("HRESULT (UINT32, DOUBLE *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, double*, IInspectable*, int> CreateDoubleArray;

        [NativeTypeName("HRESULT (UINT32, WCHAR *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, IInspectable*, int> CreateChar16Array;

        [NativeTypeName("HRESULT (UINT32, boolean *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, IInspectable*, int> CreateBooleanArray;

        [NativeTypeName("HRESULT (UINT32, HSTRING *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HSTRING*, IInspectable*, int> CreateStringArray;

        [NativeTypeName(
            "HRESULT (UINT32, IInspectable **, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IInspectable*,
            IInspectable*,
            int> CreateInspectableArray;

        [NativeTypeName("HRESULT (UINT32, GUID *, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, IInspectable*, int> CreateGuidArray;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::DateTime *, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            WinRTDateTime*,
            IInspectable*,
            int> CreateDateTimeArray;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::TimeSpan *, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, TimeSpan*, IInspectable*, int> CreateTimeSpanArray;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Point *, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Point*, IInspectable*, int> CreatePointArray;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Size *, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Size*, IInspectable*, int> CreateSizeArray;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::Rect *, IInspectable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Rect*, IInspectable*, int> CreateRectArray;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyValueStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyValueStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPropertyValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPropertyValueStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IPropertyValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyValueStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPropertyValueStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyValueStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyValueStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyValueStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
