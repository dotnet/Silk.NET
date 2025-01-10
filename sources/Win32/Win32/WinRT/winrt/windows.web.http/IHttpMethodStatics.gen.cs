// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("64D171F0-D99A-4153-8DC6-D68CC4CCE317")]
[NativeTypeName("struct IHttpMethodStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMethodStatics : IHttpMethodStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMethodStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpMethodStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpMethodStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpMethodStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpMethodStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpMethodStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Delete(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Get(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Head(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Options(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Patch(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Post(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Put(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
    )
    {
        return ((delegate* unmanaged<IHttpMethodStatics, IHttpMethod*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Delete(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(7)]
        HRESULT get_Get(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(8)]
        HRESULT get_Head(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(9)]
        HRESULT get_Options(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(10)]
        HRESULT get_Patch(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(11)]
        HRESULT get_Post(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
        );

        [VtblIndex(12)]
        HRESULT get_Put(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpMethod **")] IHttpMethod* value
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
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Delete;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Get;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Head;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Options;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Patch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Post;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpMethod **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpMethod*, int> get_Put;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpMethodStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpMethodStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpMethodStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpMethodStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpMethodStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpMethodStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpMethodStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpMethodStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpMethodStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpMethodStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpMethodStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpMethodStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpMethodStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpMethodStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
