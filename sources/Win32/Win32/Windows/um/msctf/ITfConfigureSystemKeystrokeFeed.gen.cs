// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0D2C969A-BC9C-437C-84EE-951C49B1A764")]
[NativeTypeName("struct ITfConfigureSystemKeystrokeFeed : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfConfigureSystemKeystrokeFeed
    : ITfConfigureSystemKeystrokeFeed.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfConfigureSystemKeystrokeFeed));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfConfigureSystemKeystrokeFeed, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DisableSystemKeystrokeFeed()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnableSystemKeystrokeFeed()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DisableSystemKeystrokeFeed();

        [VtblIndex(4)]
        HRESULT EnableSystemKeystrokeFeed();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisableSystemKeystrokeFeed;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EnableSystemKeystrokeFeed;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfConfigureSystemKeystrokeFeed"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfConfigureSystemKeystrokeFeed(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfConfigureSystemKeystrokeFeed"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfConfigureSystemKeystrokeFeed(Silk.NET.Windows.IUnknown value)
    {
        return new ITfConfigureSystemKeystrokeFeed(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfConfigureSystemKeystrokeFeed"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfConfigureSystemKeystrokeFeed"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfConfigureSystemKeystrokeFeed value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
