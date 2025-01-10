// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("172A174C-E79E-4F6D-B07D-128F469E0296")]
[NativeTypeName("struct IShareProviderFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IShareProviderFactory : IShareProviderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShareProviderFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShareProviderFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShareProviderFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShareProviderFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IShareProviderFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IShareProviderFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IShareProviderFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        HSTRING title,
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference displayIcon,
        [NativeTypeName("ABI::Windows::UI::Color")] Color backgroundColor,
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProviderHandler *")]
            IShareProviderHandler handler,
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **")]
            IShareProvider* result
    )
    {
        return (
            (delegate* unmanaged<
                IShareProviderFactory,
                HSTRING,
                IRandomAccessStreamReference,
                Color,
                IShareProviderHandler,
                IShareProvider*,
                int>)((*lpVtbl)[6])
        )(this, title, displayIcon, backgroundColor, handler, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            HSTRING title,
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference displayIcon,
            [NativeTypeName("ABI::Windows::UI::Color")] Color backgroundColor,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IShareProviderHandler *"
            )]
                IShareProviderHandler handler,
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **")]
                IShareProvider* result
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
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, ABI::Windows::UI::Color, ABI::Windows::ApplicationModel::DataTransfer::IShareProviderHandler *, ABI::Windows::ApplicationModel::DataTransfer::IShareProvider **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IRandomAccessStreamReference,
            Color,
            IShareProviderHandler,
            IShareProvider*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShareProviderFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShareProviderFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IShareProviderFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IShareProviderFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IShareProviderFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShareProviderFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IShareProviderFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IShareProviderFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShareProviderFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShareProviderFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IShareProviderFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShareProviderFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShareProviderFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShareProviderFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
