// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3AF280B6-CB3F-11D0-891E-00C04FB6BFC4")]
[NativeTypeName("struct IInternetHostSecurityManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetHostSecurityManager
    : IInternetHostSecurityManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetHostSecurityManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IInternetHostSecurityManager, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetHostSecurityManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSecurityId(
        byte* pbSecurityId,
        [NativeTypeName("DWORD *")] uint* pcbSecurityId,
        [NativeTypeName("DWORD_PTR")] nuint dwReserved
    )
    {
        return (
            (delegate* unmanaged<IInternetHostSecurityManager, byte*, uint*, nuint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pbSecurityId, pcbSecurityId, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ProcessUrlAction(
        [NativeTypeName("DWORD")] uint dwAction,
        byte* pPolicy,
        [NativeTypeName("DWORD")] uint cbPolicy,
        byte* pContext,
        [NativeTypeName("DWORD")] uint cbContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetHostSecurityManager,
                uint,
                byte*,
                uint,
                byte*,
                uint,
                uint,
                uint,
                int>)((*lpVtbl)[4])
        )(this, dwAction, pPolicy, cbPolicy, pContext, cbContext, dwFlags, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryCustomPolicy(
        [NativeTypeName("const GUID &")] Guid* guidKey,
        byte** ppPolicy,
        [NativeTypeName("DWORD *")] uint* pcbPolicy,
        byte* pContext,
        [NativeTypeName("DWORD")] uint cbContext,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IInternetHostSecurityManager,
                Guid*,
                byte**,
                uint*,
                byte*,
                uint,
                uint,
                int>)((*lpVtbl)[5])
        )(this, guidKey, ppPolicy, pcbPolicy, pContext, cbContext, dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSecurityId(
            byte* pbSecurityId,
            [NativeTypeName("DWORD *")] uint* pcbSecurityId,
            [NativeTypeName("DWORD_PTR")] nuint dwReserved
        );

        [VtblIndex(4)]
        HRESULT ProcessUrlAction(
            [NativeTypeName("DWORD")] uint dwAction,
            byte* pPolicy,
            [NativeTypeName("DWORD")] uint cbPolicy,
            byte* pContext,
            [NativeTypeName("DWORD")] uint cbContext,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(5)]
        HRESULT QueryCustomPolicy(
            [NativeTypeName("const GUID &")] Guid* guidKey,
            byte** ppPolicy,
            [NativeTypeName("DWORD *")] uint* pcbPolicy,
            byte* pContext,
            [NativeTypeName("DWORD")] uint cbContext,
            [NativeTypeName("DWORD")] uint dwReserved
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

        [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, nuint, int> GetSecurityId;

        [NativeTypeName(
            "HRESULT (DWORD, BYTE *, DWORD, BYTE *, DWORD, DWORD, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            byte*,
            uint,
            byte*,
            uint,
            uint,
            uint,
            int> ProcessUrlAction;

        [NativeTypeName(
            "HRESULT (const GUID &, BYTE **, DWORD *, BYTE *, DWORD, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            byte**,
            uint*,
            byte*,
            uint,
            uint,
            int> QueryCustomPolicy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetHostSecurityManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetHostSecurityManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetHostSecurityManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetHostSecurityManager(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetHostSecurityManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetHostSecurityManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetHostSecurityManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetHostSecurityManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
