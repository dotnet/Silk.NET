// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000026-0000-0000-C000-000000000046")]
[NativeTypeName("struct IUrlMon : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUrlMon : IUrlMon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUrlMon));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUrlMon, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUrlMon, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUrlMon, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AsyncGetClassBits(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LPCWSTR")] ushort* pszTYPE,
        [NativeTypeName("LPCWSTR")] ushort* pszExt,
        [NativeTypeName("DWORD")] uint dwFileVersionMS,
        [NativeTypeName("DWORD")] uint dwFileVersionLS,
        [NativeTypeName("LPCWSTR")] ushort* pszCodeBase,
        IBindCtx pbc,
        [NativeTypeName("DWORD")] uint dwClassContext,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("DWORD")] uint flags
    )
    {
        return (
            (delegate* unmanaged<
                IUrlMon,
                Guid*,
                ushort*,
                ushort*,
                uint,
                uint,
                ushort*,
                IBindCtx,
                uint,
                Guid*,
                uint,
                int>)((*lpVtbl)[3])
        )(
            this,
            rclsid,
            pszTYPE,
            pszExt,
            dwFileVersionMS,
            dwFileVersionLS,
            pszCodeBase,
            pbc,
            dwClassContext,
            riid,
            flags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AsyncGetClassBits(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LPCWSTR")] ushort* pszTYPE,
            [NativeTypeName("LPCWSTR")] ushort* pszExt,
            [NativeTypeName("DWORD")] uint dwFileVersionMS,
            [NativeTypeName("DWORD")] uint dwFileVersionLS,
            [NativeTypeName("LPCWSTR")] ushort* pszCodeBase,
            IBindCtx pbc,
            [NativeTypeName("DWORD")] uint dwClassContext,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("DWORD")] uint flags
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

        [NativeTypeName(
            "HRESULT (const IID &, LPCWSTR, LPCWSTR, DWORD, DWORD, LPCWSTR, IBindCtx *, DWORD, const IID &, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort*,
            ushort*,
            uint,
            uint,
            ushort*,
            IBindCtx,
            uint,
            Guid*,
            uint,
            int> AsyncGetClassBits;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUrlMon"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUrlMon(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUrlMon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUrlMon(Silk.NET.Windows.IUnknown value)
    {
        return new IUrlMon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUrlMon"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUrlMon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUrlMon value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
