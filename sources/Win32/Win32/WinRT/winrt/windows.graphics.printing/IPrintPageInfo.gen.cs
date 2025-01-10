// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DD4BE9C9-A6A1-4ADA-930E-DA872A4F23D3")]
[NativeTypeName("struct IPrintPageInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintPageInfo : IPrintPageInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintPageInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintPageInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrintPageInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintPageInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrintPageInfo, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintPageInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintPageInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_MediaSize(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize")] PrintMediaSize value
    )
    {
        return ((delegate* unmanaged<IPrintPageInfo, PrintMediaSize, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MediaSize(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize *")] PrintMediaSize* value
    )
    {
        return ((delegate* unmanaged<IPrintPageInfo, PrintMediaSize*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_PageSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value)
    {
        return ((delegate* unmanaged<IPrintPageInfo, Size, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_PageSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged<IPrintPageInfo, Size*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_DpiX([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IPrintPageInfo, uint, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DpiX([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IPrintPageInfo, uint*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DpiY([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IPrintPageInfo, uint, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DpiY([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IPrintPageInfo, uint*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Orientation(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation")]
            PrintOrientation value
    )
    {
        return ((delegate* unmanaged<IPrintPageInfo, PrintOrientation, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Orientation(
        [NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation *")]
            PrintOrientation* value
    )
    {
        return ((delegate* unmanaged<IPrintPageInfo, PrintOrientation*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_MediaSize(
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize")]
                PrintMediaSize value
        );

        [VtblIndex(7)]
        HRESULT get_MediaSize(
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintMediaSize *")]
                PrintMediaSize* value
        );

        [VtblIndex(8)]
        HRESULT put_PageSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size value);

        [VtblIndex(9)]
        HRESULT get_PageSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT put_DpiX([NativeTypeName("UINT32")] uint value);

        [VtblIndex(11)]
        HRESULT get_DpiX([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        HRESULT put_DpiY([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_DpiY([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_Orientation(
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation")]
                PrintOrientation value
        );

        [VtblIndex(15)]
        HRESULT get_Orientation(
            [NativeTypeName("ABI::Windows::Graphics::Printing::PrintOrientation *")]
                PrintOrientation* value
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
            "HRESULT (ABI::Windows::Graphics::Printing::PrintMediaSize) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintMediaSize, int> put_MediaSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintMediaSize *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintMediaSize*, int> get_MediaSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size, int> put_PageSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_PageSize;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_DpiX;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_DpiX;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_DpiY;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_DpiY;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintOrientation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintOrientation, int> put_Orientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::PrintOrientation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintOrientation*, int> get_Orientation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintPageInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintPageInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintPageInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintPageInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintPageInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintPageInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintPageInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintPageInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintPageInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintPageInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintPageInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintPageInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintPageInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintPageInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
