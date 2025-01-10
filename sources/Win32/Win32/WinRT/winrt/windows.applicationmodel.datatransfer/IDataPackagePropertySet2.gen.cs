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

[Guid("EB505D4A-9800-46AA-B181-7B6F0F2B919A")]
[NativeTypeName("struct IDataPackagePropertySet2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackagePropertySet2
    : IDataPackagePropertySet2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackagePropertySet2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataPackagePropertySet2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ContentSourceWebLink(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySet2, IUriRuntimeClass*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ContentSourceWebLink(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySet2, IUriRuntimeClass, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContentSourceApplicationLink(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySet2, IUriRuntimeClass*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContentSourceApplicationLink(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySet2, IUriRuntimeClass, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PackageFamilyName(HSTRING* value)
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PackageFamilyName(HSTRING value)
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Square30x30Logo(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySet2, IRandomAccessStreamReference*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Square30x30Logo(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IDataPackagePropertySet2, IRandomAccessStreamReference, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LogoBackgroundColor(
        [NativeTypeName("ABI::Windows::UI::Color *")] Color* value
    )
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, Color*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_LogoBackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<IDataPackagePropertySet2, Color, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ContentSourceWebLink(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(7)]
        HRESULT put_ContentSourceWebLink(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(8)]
        HRESULT get_ContentSourceApplicationLink(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(9)]
        HRESULT put_ContentSourceApplicationLink(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(10)]
        HRESULT get_PackageFamilyName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_PackageFamilyName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Square30x30Logo(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* value
        );

        [VtblIndex(13)]
        HRESULT put_Square30x30Logo(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(14)]
        HRESULT get_LogoBackgroundColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(15)]
        HRESULT put_LogoBackgroundColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);
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
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ContentSourceWebLink;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_ContentSourceWebLink;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ContentSourceApplicationLink;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_ContentSourceApplicationLink;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PackageFamilyName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_PackageFamilyName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference*, int> get_Square30x30Logo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> put_Square30x30Logo;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_LogoBackgroundColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_LogoBackgroundColor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataPackagePropertySet2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataPackagePropertySet2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataPackagePropertySet2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataPackagePropertySet2(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataPackagePropertySet2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackagePropertySet2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackagePropertySet2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataPackagePropertySet2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataPackagePropertySet2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataPackagePropertySet2(Silk.NET.Windows.IUnknown value)
    {
        return new IDataPackagePropertySet2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackagePropertySet2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackagePropertySet2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataPackagePropertySet2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
