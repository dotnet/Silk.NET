// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A9B3D012-3DF2-4EE3-B8D1-8695F457D3C1")]
[NativeTypeName("struct IDirect3DDxgiInterfaceAccess : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DDxgiInterfaceAccess
    : IDirect3DDxgiInterfaceAccess.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DDxgiInterfaceAccess));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirect3DDxgiInterfaceAccess, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DDxgiInterfaceAccess, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public HRESULT GetInterface([NativeTypeName("const IID &")] Guid* iid, void** p)
    {
        return (
            (delegate* unmanaged<IDirect3DDxgiInterfaceAccess, Guid*, void**, int>)((*lpVtbl)[3])
        )(this, iid, p);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [SupportedOSPlatform("windows10.0.19043.0")]
        HRESULT GetInterface([NativeTypeName("const IID &")] Guid* iid, void** p);
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

        [NativeTypeName(
            "HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        [SupportedOSPlatform("windows10.0.19043.0")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetInterface;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDxgiInterfaceAccess"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDxgiInterfaceAccess(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DDxgiInterfaceAccess"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DDxgiInterfaceAccess(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DDxgiInterfaceAccess(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DDxgiInterfaceAccess"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDxgiInterfaceAccess"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DDxgiInterfaceAccess value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
