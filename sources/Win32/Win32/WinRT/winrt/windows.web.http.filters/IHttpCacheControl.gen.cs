// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.filters.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C77E1CB4-3CEA-4EB5-AC85-04E186E63AB7")]
[NativeTypeName("struct IHttpCacheControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCacheControl : IHttpCacheControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCacheControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpCacheControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpCacheControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpCacheControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpCacheControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpCacheControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpCacheControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ReadBehavior(
        [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior *")]
            HttpCacheReadBehavior* value
    )
    {
        return (
            (delegate* unmanaged<IHttpCacheControl, HttpCacheReadBehavior*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ReadBehavior(
        [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior")]
            HttpCacheReadBehavior value
    )
    {
        return ((delegate* unmanaged<IHttpCacheControl, HttpCacheReadBehavior, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_WriteBehavior(
        [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior *")]
            HttpCacheWriteBehavior* value
    )
    {
        return (
            (delegate* unmanaged<IHttpCacheControl, HttpCacheWriteBehavior*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_WriteBehavior(
        [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior")]
            HttpCacheWriteBehavior value
    )
    {
        return (
            (delegate* unmanaged<IHttpCacheControl, HttpCacheWriteBehavior, int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ReadBehavior(
            [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior *")]
                HttpCacheReadBehavior* value
        );

        [VtblIndex(7)]
        HRESULT put_ReadBehavior(
            [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior")]
                HttpCacheReadBehavior value
        );

        [VtblIndex(8)]
        HRESULT get_WriteBehavior(
            [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior *")]
                HttpCacheWriteBehavior* value
        );

        [VtblIndex(9)]
        HRESULT put_WriteBehavior(
            [NativeTypeName("ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior")]
                HttpCacheWriteBehavior value
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
            "HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpCacheReadBehavior*, int> get_ReadBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheReadBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpCacheReadBehavior, int> put_ReadBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpCacheWriteBehavior*, int> get_WriteBehavior;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::Filters::HttpCacheWriteBehavior) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HttpCacheWriteBehavior, int> put_WriteBehavior;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpCacheControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpCacheControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpCacheControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpCacheControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpCacheControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpCacheControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpCacheControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpCacheControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpCacheControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpCacheControl(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpCacheControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpCacheControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpCacheControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpCacheControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
