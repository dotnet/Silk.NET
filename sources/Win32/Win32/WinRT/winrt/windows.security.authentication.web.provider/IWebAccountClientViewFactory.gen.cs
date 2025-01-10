// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.authentication.web.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("616D16A4-DE22-4855-A326-06CEBF2A3F23")]
[NativeTypeName("struct IWebAccountClientViewFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAccountClientViewFactory
    : IWebAccountClientViewFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAccountClientViewFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IWebAccountClientViewFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAccountClientViewFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAccountClientViewFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IWebAccountClientViewFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebAccountClientViewFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IWebAccountClientViewFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType"
        )]
            WebAccountClientViewType viewType,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass applicationCallbackUri,
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **"
        )]
            IWebAccountClientView* view
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountClientViewFactory,
                WebAccountClientViewType,
                IUriRuntimeClass,
                IWebAccountClientView*,
                int>)((*lpVtbl)[6])
        )(this, viewType, applicationCallbackUri, view);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithPairwiseId(
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType"
        )]
            WebAccountClientViewType viewType,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
            IUriRuntimeClass applicationCallbackUri,
        HSTRING accountPairwiseId,
        [NativeTypeName(
            "ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **"
        )]
            IWebAccountClientView* view
    )
    {
        return (
            (delegate* unmanaged<
                IWebAccountClientViewFactory,
                WebAccountClientViewType,
                IUriRuntimeClass,
                HSTRING,
                IWebAccountClientView*,
                int>)((*lpVtbl)[7])
        )(this, viewType, applicationCallbackUri, accountPairwiseId, view);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType"
            )]
                WebAccountClientViewType viewType,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass applicationCallbackUri,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **"
            )]
                IWebAccountClientView* view
        );

        [VtblIndex(7)]
        HRESULT CreateWithPairwiseId(
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType"
            )]
                WebAccountClientViewType viewType,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")]
                IUriRuntimeClass applicationCallbackUri,
            HSTRING accountPairwiseId,
            [NativeTypeName(
                "ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **"
            )]
                IWebAccountClientView* view
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
            "HRESULT (ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WebAccountClientViewType,
            IUriRuntimeClass,
            IWebAccountClientView*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Authentication::Web::Provider::WebAccountClientViewType, ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Security::Authentication::Web::Provider::IWebAccountClientView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WebAccountClientViewType,
            IUriRuntimeClass,
            HSTRING,
            IWebAccountClientView*,
            int> CreateWithPairwiseId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWebAccountClientViewFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebAccountClientViewFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebAccountClientViewFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebAccountClientViewFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebAccountClientViewFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountClientViewFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountClientViewFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebAccountClientViewFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebAccountClientViewFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebAccountClientViewFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IWebAccountClientViewFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebAccountClientViewFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebAccountClientViewFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebAccountClientViewFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
