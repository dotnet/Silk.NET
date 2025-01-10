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

[Guid("408FD45F-E047-5F85-7129-FB085A4FAD14")]
[NativeTypeName("struct IPrintPageRangeFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintPageRangeFactory : IPrintPageRangeFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintPageRangeFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintPageRangeFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrintPageRangeFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintPageRangeFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrintPageRangeFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrintPageRangeFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrintPageRangeFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("INT32")] int firstPage,
        [NativeTypeName("INT32")] int lastPage,
        [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageRange **")]
            IPrintPageRange* result
    )
    {
        return (
            (delegate* unmanaged<IPrintPageRangeFactory, int, int, IPrintPageRange*, int>)(
                (*lpVtbl)[6]
            )
        )(this, firstPage, lastPage, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithSinglePage(
        [NativeTypeName("INT32")] int page,
        [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageRange **")]
            IPrintPageRange* result
    )
    {
        return (
            (delegate* unmanaged<IPrintPageRangeFactory, int, IPrintPageRange*, int>)((*lpVtbl)[7])
        )(this, page, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("INT32")] int firstPage,
            [NativeTypeName("INT32")] int lastPage,
            [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageRange **")]
                IPrintPageRange* result
        );

        [VtblIndex(7)]
        HRESULT CreateWithSinglePage(
            [NativeTypeName("INT32")] int page,
            [NativeTypeName("ABI::Windows::Graphics::Printing::IPrintPageRange **")]
                IPrintPageRange* result
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
            "HRESULT (INT32, INT32, ABI::Windows::Graphics::Printing::IPrintPageRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int, IPrintPageRange*, int> Create;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Graphics::Printing::IPrintPageRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, IPrintPageRange*, int> CreateWithSinglePage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintPageRangeFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintPageRangeFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintPageRangeFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintPageRangeFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrintPageRangeFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintPageRangeFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintPageRangeFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrintPageRangeFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintPageRangeFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintPageRangeFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintPageRangeFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintPageRangeFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintPageRangeFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintPageRangeFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
