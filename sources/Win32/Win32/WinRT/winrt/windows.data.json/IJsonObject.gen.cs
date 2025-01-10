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

[Guid("064E24DD-29C2-4F83-9AC1-9EE11578BEB3")]
[NativeTypeName("struct IJsonObject : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonObject : IJsonObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IJsonObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IJsonObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IJsonObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IJsonObject, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IJsonObject, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetNamedValue(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* returnValue
    )
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, IJsonValue*, int>)((*lpVtbl)[6]))(
            this,
            name,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetNamedValue(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue value
    )
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, IJsonValue, int>)((*lpVtbl)[7]))(
            this,
            name,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetNamedObject(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject* returnValue
    )
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, IJsonObject*, int>)((*lpVtbl)[8]))(
            this,
            name,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetNamedArray(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray* returnValue
    )
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, IJsonArray*, int>)((*lpVtbl)[9]))(
            this,
            name,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetNamedString(HSTRING name, HSTRING* returnValue)
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            name,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetNamedNumber(HSTRING name, double* returnValue)
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, double*, int>)((*lpVtbl)[11]))(
            this,
            name,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetNamedBoolean(HSTRING name, [NativeTypeName("boolean *")] byte* returnValue)
    {
        return ((delegate* unmanaged<IJsonObject, HSTRING, byte*, int>)((*lpVtbl)[12]))(
            this,
            name,
            returnValue
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetNamedValue(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* returnValue
        );

        [VtblIndex(7)]
        HRESULT SetNamedValue(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue *")] IJsonValue value
        );

        [VtblIndex(8)]
        HRESULT GetNamedObject(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonObject **")] IJsonObject* returnValue
        );

        [VtblIndex(9)]
        HRESULT GetNamedArray(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonArray **")] IJsonArray* returnValue
        );

        [VtblIndex(10)]
        HRESULT GetNamedString(HSTRING name, HSTRING* returnValue);

        [VtblIndex(11)]
        HRESULT GetNamedNumber(HSTRING name, double* returnValue);

        [VtblIndex(12)]
        HRESULT GetNamedBoolean(HSTRING name, [NativeTypeName("boolean *")] byte* returnValue);
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
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonValue*, int> GetNamedValue;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonValue, int> SetNamedValue;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonObject **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonObject*, int> GetNamedObject;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonArray **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonArray*, int> GetNamedArray;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING*, int> GetNamedString;

        [NativeTypeName("HRESULT (HSTRING, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, double*, int> GetNamedNumber;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> GetNamedBoolean;
    }

    /// <summary>Initializes a new instance of the <see cref = "IJsonObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IJsonObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IJsonObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IJsonObject(Silk.NET.WinRT.IInspectable value)
    {
        return new IJsonObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonObject"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IJsonObject value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IJsonObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IJsonObject(Silk.NET.Windows.IUnknown value)
    {
        return new IJsonObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IJsonObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
