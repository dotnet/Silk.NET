// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000013D-0000-0000-C000-000000000046")]
[NativeTypeName("struct IClientSecurity : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IClientSecurity : IClientSecurity.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClientSecurity));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClientSecurity, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IClientSecurity, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IClientSecurity, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryBlanket(
        IUnknown pProxy,
        [NativeTypeName("DWORD *")] uint* pAuthnSvc,
        [NativeTypeName("DWORD *")] uint* pAuthzSvc,
        [NativeTypeName("OLECHAR **")] ushort** pServerPrincName,
        [NativeTypeName("DWORD *")] uint* pAuthnLevel,
        [NativeTypeName("DWORD *")] uint* pImpLevel,
        void** pAuthInfo,
        [NativeTypeName("DWORD *")] uint* pCapabilites
    )
    {
        return (
            (delegate* unmanaged<
                IClientSecurity,
                IUnknown,
                uint*,
                uint*,
                ushort**,
                uint*,
                uint*,
                void**,
                uint*,
                int>)((*lpVtbl)[3])
        )(
            this,
            pProxy,
            pAuthnSvc,
            pAuthzSvc,
            pServerPrincName,
            pAuthnLevel,
            pImpLevel,
            pAuthInfo,
            pCapabilites
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBlanket(
        IUnknown pProxy,
        [NativeTypeName("DWORD")] uint dwAuthnSvc,
        [NativeTypeName("DWORD")] uint dwAuthzSvc,
        [NativeTypeName("OLECHAR *")] ushort* pServerPrincName,
        [NativeTypeName("DWORD")] uint dwAuthnLevel,
        [NativeTypeName("DWORD")] uint dwImpLevel,
        void* pAuthInfo,
        [NativeTypeName("DWORD")] uint dwCapabilities
    )
    {
        return (
            (delegate* unmanaged<
                IClientSecurity,
                IUnknown,
                uint,
                uint,
                ushort*,
                uint,
                uint,
                void*,
                uint,
                int>)((*lpVtbl)[4])
        )(
            this,
            pProxy,
            dwAuthnSvc,
            dwAuthzSvc,
            pServerPrincName,
            dwAuthnLevel,
            dwImpLevel,
            pAuthInfo,
            dwCapabilities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CopyProxy(IUnknown pProxy, IUnknown* ppCopy)
    {
        return ((delegate* unmanaged<IClientSecurity, IUnknown, IUnknown*, int>)((*lpVtbl)[5]))(
            this,
            pProxy,
            ppCopy
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryBlanket(
            IUnknown pProxy,
            [NativeTypeName("DWORD *")] uint* pAuthnSvc,
            [NativeTypeName("DWORD *")] uint* pAuthzSvc,
            [NativeTypeName("OLECHAR **")] ushort** pServerPrincName,
            [NativeTypeName("DWORD *")] uint* pAuthnLevel,
            [NativeTypeName("DWORD *")] uint* pImpLevel,
            void** pAuthInfo,
            [NativeTypeName("DWORD *")] uint* pCapabilites
        );

        [VtblIndex(4)]
        HRESULT SetBlanket(
            IUnknown pProxy,
            [NativeTypeName("DWORD")] uint dwAuthnSvc,
            [NativeTypeName("DWORD")] uint dwAuthzSvc,
            [NativeTypeName("OLECHAR *")] ushort* pServerPrincName,
            [NativeTypeName("DWORD")] uint dwAuthnLevel,
            [NativeTypeName("DWORD")] uint dwImpLevel,
            void* pAuthInfo,
            [NativeTypeName("DWORD")] uint dwCapabilities
        );

        [VtblIndex(5)]
        HRESULT CopyProxy(IUnknown pProxy, IUnknown* ppCopy);
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
            "HRESULT (IUnknown *, DWORD *, DWORD *, OLECHAR **, DWORD *, DWORD *, void **, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint*,
            uint*,
            ushort**,
            uint*,
            uint*,
            void**,
            uint*,
            int> QueryBlanket;

        [NativeTypeName(
            "HRESULT (IUnknown *, DWORD, DWORD, OLECHAR *, DWORD, DWORD, void *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            uint,
            uint,
            ushort*,
            uint,
            uint,
            void*,
            uint,
            int> SetBlanket;

        [NativeTypeName("HRESULT (IUnknown *, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, IUnknown*, int> CopyProxy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IClientSecurity"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IClientSecurity(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IClientSecurity"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IClientSecurity(Silk.NET.Windows.IUnknown value)
    {
        return new IClientSecurity(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IClientSecurity"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IClientSecurity"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IClientSecurity value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
