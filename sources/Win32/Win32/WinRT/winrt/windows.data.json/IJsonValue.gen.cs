// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A3219ECB-F0B3-4DCD-BEEE-19D48CD3ED1E")]
[NativeTypeName("struct IJsonValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonValue : IJsonValue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonValue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IJsonValue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IJsonValue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IJsonValue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IJsonValue, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IJsonValue, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IJsonValue, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ValueType(
        [NativeTypeName("ABI::Windows::Data::Json::JsonValueType *")] JsonValueType* value
    )
    {
        return ((delegate* unmanaged<IJsonValue, JsonValueType*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Stringify(HSTRING* returnValue)
    {
        return ((delegate* unmanaged<IJsonValue, HSTRING*, int>)((*lpVtbl)[7]))(this, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetString(HSTRING* returnValue)
    {
        return ((delegate* unmanaged<IJsonValue, HSTRING*, int>)((*lpVtbl)[8]))(this, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNumber(double* returnValue)
    {
        return ((delegate* unmanaged<IJsonValue, double*, int>)((*lpVtbl)[9]))(this, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBoolean([NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged<IJsonValue, byte*, int>)((*lpVtbl)[10]))(this, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetArray(
        [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray* returnValue
    )
    {
        return ((delegate* unmanaged<IJsonValue, IJsonArray*, int>)((*lpVtbl)[11]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetObjectW(
        [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject* returnValue
    )
    {
        return ((delegate* unmanaged<IJsonValue, IJsonObject*, int>)((*lpVtbl)[12]))(
            this,
            returnValue
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ValueType(
            [NativeTypeName("ABI::Windows::Data::Json::JsonValueType *")] JsonValueType* value
        );

        [VtblIndex(7)]
        HRESULT Stringify(HSTRING* returnValue);

        [VtblIndex(8)]
        HRESULT GetString(HSTRING* returnValue);

        [VtblIndex(9)]
        HRESULT GetNumber(double* returnValue);

        [VtblIndex(10)]
        HRESULT GetBoolean([NativeTypeName("boolean *")] byte* returnValue);

        [VtblIndex(11)]
        HRESULT GetArray(
            [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray* returnValue
        );

        [VtblIndex(12)]
        HRESULT GetObjectW(
            [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject* returnValue
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
            "HRESULT (ABI::Windows::Data::Json::JsonValueType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, JsonValueType*, int> get_ValueType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> Stringify;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetString;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetNumber;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> GetBoolean;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IJsonArray*, int> GetArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IJsonObject*, int> GetObjectW;
    }

    /// <summary>Initializes a new instance of the <see cref = "IJsonValue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IJsonValue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IJsonValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IJsonValue(Silk.NET.WinRT.IInspectable value)
    {
        return new IJsonValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonValue"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IJsonValue value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IJsonValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IJsonValue(Silk.NET.Windows.IUnknown value)
    {
        return new IJsonValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonValue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IJsonValue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
