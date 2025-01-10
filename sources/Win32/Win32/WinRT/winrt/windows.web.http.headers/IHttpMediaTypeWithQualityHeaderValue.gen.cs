// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("188D5E32-76BE-44A0-B1CD-2074BDED2DDE")]
[NativeTypeName("struct IHttpMediaTypeWithQualityHeaderValue : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMediaTypeWithQualityHeaderValue
    : IHttpMediaTypeWithQualityHeaderValue.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMediaTypeWithQualityHeaderValue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CharSet(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CharSet(HSTRING value)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, HSTRING, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MediaType(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, HSTRING*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MediaType(HSTRING value)
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, HSTRING, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Parameters(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, IVector<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Quality(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, IReference<double>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_Quality(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")]
            IReference<double>* value
    )
    {
        return (
            (delegate* unmanaged<IHttpMediaTypeWithQualityHeaderValue, IReference<double>*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CharSet(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_CharSet(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_MediaType(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_MediaType(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Parameters(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT get_Quality(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(12)]
        HRESULT put_Quality(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t *")]
                IReference<double>* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_CharSet;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_CharSet;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MediaType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_MediaType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CHttp__CHeaders__CHttpNameValueHeaderValue_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Parameters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_Quality;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>*, int> put_Quality;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpMediaTypeWithQualityHeaderValue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpMediaTypeWithQualityHeaderValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpMediaTypeWithQualityHeaderValue(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpMediaTypeWithQualityHeaderValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpMediaTypeWithQualityHeaderValue value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpMediaTypeWithQualityHeaderValue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpMediaTypeWithQualityHeaderValue(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpMediaTypeWithQualityHeaderValue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpMediaTypeWithQualityHeaderValue value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
