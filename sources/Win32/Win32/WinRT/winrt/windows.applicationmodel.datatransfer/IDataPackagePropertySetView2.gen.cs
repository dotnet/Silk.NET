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

[Guid("6054509B-8EBE-4FEB-9C1E-75E69DE54B84")]
[NativeTypeName("struct IDataPackagePropertySetView2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackagePropertySetView2
    : IDataPackagePropertySetView2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackagePropertySetView2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySetView2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDataPackagePropertySetView2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataPackagePropertySetView2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySetView2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataPackagePropertySetView2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySetView2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged<IDataPackagePropertySetView2, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContentSourceWebLink(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySetView2, IUriRuntimeClass*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContentSourceApplicationLink(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySetView2, IUriRuntimeClass*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Square30x30Logo(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySetView2, IRandomAccessStreamReference*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LogoBackgroundColor(
        [NativeTypeName("ABI::Windows::UI::Color *")] Color* value
    )
    {
        return ((delegate* unmanaged<IDataPackagePropertySetView2, Color*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PackageFamilyName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ContentSourceWebLink(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(8)]
        HRESULT get_ContentSourceApplicationLink(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(9)]
        HRESULT get_Square30x30Logo(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(10)]
        HRESULT get_LogoBackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PackageFamilyName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ContentSourceWebLink;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ContentSourceApplicationLink;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Square30x30Logo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LogoBackgroundColor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataPackagePropertySetView2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataPackagePropertySetView2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataPackagePropertySetView2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataPackagePropertySetView2(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataPackagePropertySetView2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackagePropertySetView2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackagePropertySetView2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataPackagePropertySetView2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataPackagePropertySetView2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataPackagePropertySetView2(Silk.NET.Windows.IUnknown value)
    {
        return new IDataPackagePropertySetView2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackagePropertySetView2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackagePropertySetView2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataPackagePropertySetView2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
