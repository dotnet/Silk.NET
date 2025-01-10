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

[Guid("D960D2A2-B7F0-4F00-8E44-D82CF415EA13")]
[NativeTypeName("struct IJsonObjectWithDefaultValues : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonObjectWithDefaultValues
    : IJsonObjectWithDefaultValues.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonObjectWithDefaultValues));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IJsonObjectWithDefaultValues, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IJsonObjectWithDefaultValues, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IJsonObjectWithDefaultValues, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IJsonObjectWithDefaultValues, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IJsonObjectWithDefaultValues, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IJsonObjectWithDefaultValues, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNamedValueOrDefault(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue defaultValue,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                IJsonObjectWithDefaultValues,
                HSTRING,
                IJsonValue,
                IJsonValue*,
                int>)((*lpVtbl)[6])
        )(this, name, defaultValue, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNamedObjectOrDefault(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonObject *")] IJsonObject defaultValue,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                IJsonObjectWithDefaultValues,
                HSTRING,
                IJsonObject,
                IJsonObject*,
                int>)((*lpVtbl)[7])
        )(this, name, defaultValue, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNamedStringOrDefault(HSTRING name, HSTRING defaultValue, HSTRING* returnValue)
    {
        return (
            (delegate* unmanaged<IJsonObjectWithDefaultValues, HSTRING, HSTRING, HSTRING*, int>)(
                (*lpVtbl)[8]
            )
        )(this, name, defaultValue, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNamedArrayOrDefault(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonArray *")] IJsonArray defaultValue,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray* returnValue
    )
    {
        return (
            (delegate* unmanaged<
                IJsonObjectWithDefaultValues,
                HSTRING,
                IJsonArray,
                IJsonArray*,
                int>)((*lpVtbl)[9])
        )(this, name, defaultValue, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetNamedNumberOrDefault(HSTRING name, double defaultValue, double* returnValue)
    {
        return (
            (delegate* unmanaged<IJsonObjectWithDefaultValues, HSTRING, double, double*, int>)(
                (*lpVtbl)[10]
            )
        )(this, name, defaultValue, returnValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetNamedBooleanOrDefault(
        HSTRING name,
        [NativeTypeName("boolean")] byte defaultValue,
        [NativeTypeName("boolean *")] byte* returnValue
    )
    {
        return (
            (delegate* unmanaged<IJsonObjectWithDefaultValues, HSTRING, byte, byte*, int>)(
                (*lpVtbl)[11]
            )
        )(this, name, defaultValue, returnValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetNamedValueOrDefault(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue defaultValue,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* returnValue
        );

        [VtblIndex(7)]
        HRESULT GetNamedObjectOrDefault(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonObject *")] IJsonObject defaultValue,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject* returnValue
        );

        [VtblIndex(8)]
        HRESULT GetNamedStringOrDefault(HSTRING name, HSTRING defaultValue, HSTRING* returnValue);

        [VtblIndex(9)]
        HRESULT GetNamedArrayOrDefault(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonArray *")] IJsonArray defaultValue,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray* returnValue
        );

        [VtblIndex(10)]
        HRESULT GetNamedNumberOrDefault(HSTRING name, double defaultValue, double* returnValue);

        [VtblIndex(11)]
        HRESULT GetNamedBooleanOrDefault(
            HSTRING name,
            [NativeTypeName("boolean")] byte defaultValue,
            [NativeTypeName("boolean *")] byte* returnValue
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
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue *, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IJsonValue,
            IJsonValue*,
            int> GetNamedValueOrDefault;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonObject *, ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IJsonObject,
            IJsonObject*,
            int> GetNamedObjectOrDefault;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, HSTRING*, int> GetNamedStringOrDefault;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonArray *, ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IJsonArray,
            IJsonArray*,
            int> GetNamedArrayOrDefault;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, double, double*, int> GetNamedNumberOrDefault;

        [NativeTypeName("HRESULT (HSTRING, boolean, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte, byte*, int> GetNamedBooleanOrDefault;
    }

    /// <summary>Initializes a new instance of the <see cref = "IJsonObjectWithDefaultValues"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IJsonObjectWithDefaultValues(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IJsonObjectWithDefaultValues"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IJsonObjectWithDefaultValues(Silk.NET.WinRT.IInspectable value)
    {
        return new IJsonObjectWithDefaultValues(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonObjectWithDefaultValues"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonObjectWithDefaultValues"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IJsonObjectWithDefaultValues value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IJsonObjectWithDefaultValues"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IJsonObjectWithDefaultValues(Silk.NET.Windows.IUnknown value)
    {
        return new IJsonObjectWithDefaultValues(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonObjectWithDefaultValues"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonObjectWithDefaultValues"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IJsonObjectWithDefaultValues value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
