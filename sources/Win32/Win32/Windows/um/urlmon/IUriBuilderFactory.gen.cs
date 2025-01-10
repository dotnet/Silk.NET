// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E982CE48-0B96-440C-BC37-0C869B27A29E")]
[NativeTypeName("struct IUriBuilderFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUriBuilderFactory : IUriBuilderFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUriBuilderFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUriBuilderFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUriBuilderFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUriBuilderFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateIUriBuilder(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD_PTR")] nuint dwReserved,
        IUriBuilder* ppIUriBuilder
    )
    {
        return (
            (delegate* unmanaged<IUriBuilderFactory, uint, nuint, IUriBuilder*, int>)((*lpVtbl)[3])
        )(this, dwFlags, dwReserved, ppIUriBuilder);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateInitializedIUriBuilder(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD_PTR")] nuint dwReserved,
        IUriBuilder* ppIUriBuilder
    )
    {
        return (
            (delegate* unmanaged<IUriBuilderFactory, uint, nuint, IUriBuilder*, int>)((*lpVtbl)[4])
        )(this, dwFlags, dwReserved, ppIUriBuilder);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateIUriBuilder(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD_PTR")] nuint dwReserved,
            IUriBuilder* ppIUriBuilder
        );

        [VtblIndex(4)]
        HRESULT CreateInitializedIUriBuilder(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD_PTR")] nuint dwReserved,
            IUriBuilder* ppIUriBuilder
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

        [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, nuint, IUriBuilder*, int> CreateIUriBuilder;

        [NativeTypeName("HRESULT (DWORD, DWORD_PTR, IUriBuilder **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            nuint,
            IUriBuilder*,
            int> CreateInitializedIUriBuilder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUriBuilderFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUriBuilderFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUriBuilderFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUriBuilderFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IUriBuilderFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUriBuilderFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUriBuilderFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUriBuilderFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
