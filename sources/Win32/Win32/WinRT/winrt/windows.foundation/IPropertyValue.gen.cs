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

[Guid("4BD682DD-7554-40E9-9A9B-82654EDE7E62")]
[NativeTypeName("struct IPropertyValue : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPropertyValue : IPropertyValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyValue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyValue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyValue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyValue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPropertyValue, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPropertyValue, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::Foundation::PropertyType *")] PropertyType* value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, PropertyType*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsNumericScalar([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPropertyValue, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUInt8(byte* value)
    {
        return ((delegate* unmanaged<IPropertyValue, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetInt16([NativeTypeName("INT16 *")] short* value)
    {
        return ((delegate* unmanaged<IPropertyValue, short*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetUInt16([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IPropertyValue, ushort*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetInt32([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IPropertyValue, int*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetUInt32([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInt64([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged<IPropertyValue, long*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetUInt64([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IPropertyValue, ulong*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetSingle(float* value)
    {
        return ((delegate* unmanaged<IPropertyValue, float*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDouble(double* value)
    {
        return ((delegate* unmanaged<IPropertyValue, double*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetChar16([NativeTypeName("WCHAR *")] ushort* value)
    {
        return ((delegate* unmanaged<IPropertyValue, ushort*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBoolean([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPropertyValue, byte*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetString(HSTRING* value)
    {
        return ((delegate* unmanaged<IPropertyValue, HSTRING*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetGuid(Guid* value)
    {
        return ((delegate* unmanaged<IPropertyValue, Guid*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, WinRTDateTime*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetTimeSpan(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, TimeSpan*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetPoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
    {
        return ((delegate* unmanaged<IPropertyValue, Point*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged<IPropertyValue, Size*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
    {
        return ((delegate* unmanaged<IPropertyValue, Rect*, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetUInt8Array([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, byte**, int>)((*lpVtbl)[26]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetInt16Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("INT16 **")] short** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, short**, int>)((*lpVtbl)[27]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetUInt16Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("UINT16 **")] ushort** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, ushort**, int>)((*lpVtbl)[28]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetInt32Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("INT32 **")] int** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, int**, int>)((*lpVtbl)[29]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetUInt32Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("UINT32 **")] uint** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, uint**, int>)((*lpVtbl)[30]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetInt64Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("INT64 **")] long** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, long**, int>)((*lpVtbl)[31]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetUInt64Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("UINT64 **")] ulong** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, ulong**, int>)((*lpVtbl)[32]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT GetSingleArray([NativeTypeName("UINT32 *")] uint* valueLength, float** value)
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, float**, int>)((*lpVtbl)[33]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT GetDoubleArray([NativeTypeName("UINT32 *")] uint* valueLength, double** value)
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, double**, int>)((*lpVtbl)[34]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetChar16Array(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("WCHAR **")] ushort** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, ushort**, int>)((*lpVtbl)[35]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT GetBooleanArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("boolean **")] byte** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, byte**, int>)((*lpVtbl)[36]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetStringArray([NativeTypeName("UINT32 *")] uint* valueLength, HSTRING** value)
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, HSTRING**, int>)((*lpVtbl)[37]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT GetInspectableArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        IInspectable** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, IInspectable**, int>)((*lpVtbl)[38]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT GetGuidArray([NativeTypeName("UINT32 *")] uint* valueLength, Guid** value)
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, Guid**, int>)((*lpVtbl)[39]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetDateTimeArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("ABI::Windows::Foundation::DateTime **")] WinRTDateTime** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, WinRTDateTime**, int>)((*lpVtbl)[40]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT GetTimeSpanArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan **")] TimeSpan** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, TimeSpan**, int>)((*lpVtbl)[41]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT GetPointArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Point **")] Point** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, Point**, int>)((*lpVtbl)[42]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT GetSizeArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Size **")] Size** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, Size**, int>)((*lpVtbl)[43]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT GetRectArray(
        [NativeTypeName("UINT32 *")] uint* valueLength,
        [NativeTypeName("ABI::Windows::Foundation::Rect **")] Rect** value
    )
    {
        return ((delegate* unmanaged<IPropertyValue, uint*, Rect**, int>)((*lpVtbl)[44]))(
            this,
            valueLength,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::Foundation::PropertyType *")] PropertyType* value
        );

        [VtblIndex(7)]
        HRESULT get_IsNumericScalar([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT GetUInt8(byte* value);

        [VtblIndex(9)]
        HRESULT GetInt16([NativeTypeName("INT16 *")] short* value);

        [VtblIndex(10)]
        HRESULT GetUInt16([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(11)]
        HRESULT GetInt32([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT GetUInt32([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT GetInt64([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(14)]
        HRESULT GetUInt64([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(15)]
        HRESULT GetSingle(float* value);

        [VtblIndex(16)]
        HRESULT GetDouble(double* value);

        [VtblIndex(17)]
        HRESULT GetChar16([NativeTypeName("WCHAR *")] ushort* value);

        [VtblIndex(18)]
        HRESULT GetBoolean([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT GetString(HSTRING* value);

        [VtblIndex(20)]
        HRESULT GetGuid(Guid* value);

        [VtblIndex(21)]
        HRESULT GetDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(22)]
        HRESULT GetTimeSpan(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(23)]
        HRESULT GetPoint([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value);

        [VtblIndex(24)]
        HRESULT GetSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(25)]
        HRESULT GetRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(26)]
        HRESULT GetUInt8Array([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(27)]
        HRESULT GetInt16Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("INT16 **")] short** value
        );

        [VtblIndex(28)]
        HRESULT GetUInt16Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("UINT16 **")] ushort** value
        );

        [VtblIndex(29)]
        HRESULT GetInt32Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("INT32 **")] int** value
        );

        [VtblIndex(30)]
        HRESULT GetUInt32Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("UINT32 **")] uint** value
        );

        [VtblIndex(31)]
        HRESULT GetInt64Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("INT64 **")] long** value
        );

        [VtblIndex(32)]
        HRESULT GetUInt64Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("UINT64 **")] ulong** value
        );

        [VtblIndex(33)]
        HRESULT GetSingleArray([NativeTypeName("UINT32 *")] uint* valueLength, float** value);

        [VtblIndex(34)]
        HRESULT GetDoubleArray([NativeTypeName("UINT32 *")] uint* valueLength, double** value);

        [VtblIndex(35)]
        HRESULT GetChar16Array(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("WCHAR **")] ushort** value
        );

        [VtblIndex(36)]
        HRESULT GetBooleanArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("boolean **")] byte** value
        );

        [VtblIndex(37)]
        HRESULT GetStringArray([NativeTypeName("UINT32 *")] uint* valueLength, HSTRING** value);

        [VtblIndex(38)]
        HRESULT GetInspectableArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            IInspectable** value
        );

        [VtblIndex(39)]
        HRESULT GetGuidArray([NativeTypeName("UINT32 *")] uint* valueLength, Guid** value);

        [VtblIndex(40)]
        HRESULT GetDateTimeArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("ABI::Windows::Foundation::DateTime **")] WinRTDateTime** value
        );

        [VtblIndex(41)]
        HRESULT GetTimeSpanArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan **")] TimeSpan** value
        );

        [VtblIndex(42)]
        HRESULT GetPointArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Point **")] Point** value
        );

        [VtblIndex(43)]
        HRESULT GetSizeArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Size **")] Size** value
        );

        [VtblIndex(44)]
        HRESULT GetRectArray(
            [NativeTypeName("UINT32 *")] uint* valueLength,
            [NativeTypeName("ABI::Windows::Foundation::Rect **")] Rect** value
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
            "HRESULT (ABI::Windows::Foundation::PropertyType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PropertyType*, int> get_Type;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsNumericScalar;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> GetUInt8;

        [NativeTypeName("HRESULT (INT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> GetInt16;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetUInt16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetInt32;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUInt32;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetInt64;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetUInt64;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetSingle;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetDouble;

        [NativeTypeName("HRESULT (WCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetChar16;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> GetBoolean;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetString;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGuid;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> GetDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> GetTimeSpan;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point*, int> GetPoint;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> GetSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> GetRect;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetUInt8Array;

        [NativeTypeName("HRESULT (UINT32 *, INT16 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, short**, int> GetInt16Array;

        [NativeTypeName("HRESULT (UINT32 *, UINT16 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetUInt16Array;

        [NativeTypeName("HRESULT (UINT32 *, INT32 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int**, int> GetInt32Array;

        [NativeTypeName("HRESULT (UINT32 *, UINT32 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint**, int> GetUInt32Array;

        [NativeTypeName("HRESULT (UINT32 *, INT64 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, long**, int> GetInt64Array;

        [NativeTypeName("HRESULT (UINT32 *, UINT64 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ulong**, int> GetUInt64Array;

        [NativeTypeName("HRESULT (UINT32 *, FLOAT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, float**, int> GetSingleArray;

        [NativeTypeName("HRESULT (UINT32 *, DOUBLE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, double**, int> GetDoubleArray;

        [NativeTypeName("HRESULT (UINT32 *, WCHAR **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetChar16Array;

        [NativeTypeName("HRESULT (UINT32 *, boolean **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetBooleanArray;

        [NativeTypeName("HRESULT (UINT32 *, HSTRING **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, HSTRING**, int> GetStringArray;

        [NativeTypeName("HRESULT (UINT32 *, IInspectable ***) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, IInspectable**, int> GetInspectableArray;

        [NativeTypeName("HRESULT (UINT32 *, GUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetGuidArray;

        [NativeTypeName(
            "HRESULT (UINT32 *, ABI::Windows::Foundation::DateTime **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, WinRTDateTime**, int> GetDateTimeArray;

        [NativeTypeName(
            "HRESULT (UINT32 *, ABI::Windows::Foundation::TimeSpan **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, TimeSpan**, int> GetTimeSpanArray;

        [NativeTypeName(
            "HRESULT (UINT32 *, ABI::Windows::Foundation::Point **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, Point**, int> GetPointArray;

        [NativeTypeName(
            "HRESULT (UINT32 *, ABI::Windows::Foundation::Size **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, Size**, int> GetSizeArray;

        [NativeTypeName(
            "HRESULT (UINT32 *, ABI::Windows::Foundation::Rect **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, Rect**, int> GetRectArray;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyValue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyValue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPropertyValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPropertyValue(Silk.NET.WinRT.IInspectable value)
    {
        return new IPropertyValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyValue"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPropertyValue value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyValue(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyValue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyValue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
