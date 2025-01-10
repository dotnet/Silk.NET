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

[Guid("5F6B544A-2F53-48E1-91A3-F78B50A6345C")]
[NativeTypeName("struct IJsonValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IJsonValueStatics : IJsonValueStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IJsonValueStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IJsonValueStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IJsonValueStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IJsonValueStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IJsonValueStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IJsonValueStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IJsonValueStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
    )
    {
        return ((delegate* unmanaged<IJsonValueStatics, HSTRING, IJsonValue*, int>)((*lpVtbl)[6]))(
            this,
            input,
            jsonValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* result,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return (
            (delegate* unmanaged<IJsonValueStatics, HSTRING, IJsonValue*, byte*, int>)((*lpVtbl)[7])
        )(this, input, result, succeeded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBooleanValue(
        [NativeTypeName("boolean")] byte input,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
    )
    {
        return ((delegate* unmanaged<IJsonValueStatics, byte, IJsonValue*, int>)((*lpVtbl)[8]))(
            this,
            input,
            jsonValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateNumberValue(
        double input,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
    )
    {
        return ((delegate* unmanaged<IJsonValueStatics, double, IJsonValue*, int>)((*lpVtbl)[9]))(
            this,
            input,
            jsonValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateStringValue(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
    )
    {
        return ((delegate* unmanaged<IJsonValueStatics, HSTRING, IJsonValue*, int>)((*lpVtbl)[10]))(
            this,
            input,
            jsonValue
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
        );

        [VtblIndex(7)]
        HRESULT TryParse(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* result,
            [NativeTypeName("boolean *")] byte* succeeded
        );

        [VtblIndex(8)]
        HRESULT CreateBooleanValue(
            [NativeTypeName("boolean")] byte input,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
        );

        [VtblIndex(9)]
        HRESULT CreateNumberValue(
            double input,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
        );

        [VtblIndex(10)]
        HRESULT CreateStringValue(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Data::Json::IJsonValue **")] IJsonValue* jsonValue
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
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonValue*, int> Parse;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonValue*, byte*, int> TryParse;

        [NativeTypeName(
            "HRESULT (boolean, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte, IJsonValue*, int> CreateBooleanValue;

        [NativeTypeName(
            "HRESULT (DOUBLE, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, double, IJsonValue*, int> CreateNumberValue;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Data::Json::IJsonValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IJsonValue*, int> CreateStringValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IJsonValueStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IJsonValueStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IJsonValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IJsonValueStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IJsonValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonValueStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IJsonValueStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IJsonValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IJsonValueStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IJsonValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IJsonValueStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IJsonValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IJsonValueStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
