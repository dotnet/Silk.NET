// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4E530B0A-E611-4C77-A3AC-9031D022281B")]
[NativeTypeName("struct IApplicationAssociationRegistration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationAssociationRegistration
    : IApplicationAssociationRegistration.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationAssociationRegistration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IApplicationAssociationRegistration, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryCurrentDefault(
        [NativeTypeName("LPCWSTR")] ushort* pszQuery,
        ASSOCIATIONTYPE atQueryType,
        ASSOCIATIONLEVEL alQueryLevel,
        [NativeTypeName("LPWSTR *")] ushort** ppszAssociation
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationAssociationRegistration,
                ushort*,
                ASSOCIATIONTYPE,
                ASSOCIATIONLEVEL,
                ushort**,
                int>)((*lpVtbl)[3])
        )(this, pszQuery, atQueryType, alQueryLevel, ppszAssociation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryAppIsDefault(
        [NativeTypeName("LPCWSTR")] ushort* pszQuery,
        ASSOCIATIONTYPE atQueryType,
        ASSOCIATIONLEVEL alQueryLevel,
        [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName,
        BOOL* pfDefault
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationAssociationRegistration,
                ushort*,
                ASSOCIATIONTYPE,
                ASSOCIATIONLEVEL,
                ushort*,
                BOOL*,
                int>)((*lpVtbl)[4])
        )(this, pszQuery, atQueryType, alQueryLevel, pszAppRegistryName, pfDefault);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryAppIsDefaultAll(
        ASSOCIATIONLEVEL alQueryLevel,
        [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName,
        BOOL* pfDefault
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationAssociationRegistration,
                ASSOCIATIONLEVEL,
                ushort*,
                BOOL*,
                int>)((*lpVtbl)[5])
        )(this, alQueryLevel, pszAppRegistryName, pfDefault);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAppAsDefault(
        [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName,
        [NativeTypeName("LPCWSTR")] ushort* pszSet,
        ASSOCIATIONTYPE atSetType
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationAssociationRegistration,
                ushort*,
                ushort*,
                ASSOCIATIONTYPE,
                int>)((*lpVtbl)[6])
        )(this, pszAppRegistryName, pszSet, atSetType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAppAsDefaultAll([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName)
    {
        return (
            (delegate* unmanaged<IApplicationAssociationRegistration, ushort*, int>)((*lpVtbl)[7])
        )(this, pszAppRegistryName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearUserAssociations()
    {
        return ((delegate* unmanaged<IApplicationAssociationRegistration, int>)((*lpVtbl)[8]))(
            this
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryCurrentDefault(
            [NativeTypeName("LPCWSTR")] ushort* pszQuery,
            ASSOCIATIONTYPE atQueryType,
            ASSOCIATIONLEVEL alQueryLevel,
            [NativeTypeName("LPWSTR *")] ushort** ppszAssociation
        );

        [VtblIndex(4)]
        HRESULT QueryAppIsDefault(
            [NativeTypeName("LPCWSTR")] ushort* pszQuery,
            ASSOCIATIONTYPE atQueryType,
            ASSOCIATIONLEVEL alQueryLevel,
            [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName,
            BOOL* pfDefault
        );

        [VtblIndex(5)]
        HRESULT QueryAppIsDefaultAll(
            ASSOCIATIONLEVEL alQueryLevel,
            [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName,
            BOOL* pfDefault
        );

        [VtblIndex(6)]
        HRESULT SetAppAsDefault(
            [NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName,
            [NativeTypeName("LPCWSTR")] ushort* pszSet,
            ASSOCIATIONTYPE atSetType
        );

        [VtblIndex(7)]
        HRESULT SetAppAsDefaultAll([NativeTypeName("LPCWSTR")] ushort* pszAppRegistryName);

        [VtblIndex(8)]
        HRESULT ClearUserAssociations();
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
            "HRESULT (LPCWSTR, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, LPWSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ASSOCIATIONTYPE,
            ASSOCIATIONLEVEL,
            ushort**,
            int> QueryCurrentDefault;

        [NativeTypeName(
            "HRESULT (LPCWSTR, ASSOCIATIONTYPE, ASSOCIATIONLEVEL, LPCWSTR, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ASSOCIATIONTYPE,
            ASSOCIATIONLEVEL,
            ushort*,
            BOOL*,
            int> QueryAppIsDefault;

        [NativeTypeName("HRESULT (ASSOCIATIONLEVEL, LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ASSOCIATIONLEVEL,
            ushort*,
            BOOL*,
            int> QueryAppIsDefaultAll;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ASSOCIATIONTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ASSOCIATIONTYPE, int> SetAppAsDefault;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetAppAsDefaultAll;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearUserAssociations;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationAssociationRegistration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationAssociationRegistration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationAssociationRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationAssociationRegistration(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IApplicationAssociationRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationAssociationRegistration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationAssociationRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IApplicationAssociationRegistration value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
