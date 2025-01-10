// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9C2-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHlinkSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHlinkSite : IHlinkSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHlinkSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHlinkSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHlinkSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHlinkSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryService(
        [NativeTypeName("DWORD")] uint dwSiteData,
        [NativeTypeName("const GUID &")] Guid* guidService,
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown* ppiunk
    )
    {
        return (
            (delegate* unmanaged<IHlinkSite, uint, Guid*, Guid*, IUnknown*, int>)((*lpVtbl)[3])
        )(this, dwSiteData, guidService, riid, ppiunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMoniker(
        [NativeTypeName("DWORD")] uint dwSiteData,
        [NativeTypeName("DWORD")] uint dwAssign,
        [NativeTypeName("DWORD")] uint dwWhich,
        IMoniker* ppimk
    )
    {
        return ((delegate* unmanaged<IHlinkSite, uint, uint, uint, IMoniker*, int>)((*lpVtbl)[4]))(
            this,
            dwSiteData,
            dwAssign,
            dwWhich,
            ppimk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ReadyToNavigate(
        [NativeTypeName("DWORD")] uint dwSiteData,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return ((delegate* unmanaged<IHlinkSite, uint, uint, int>)((*lpVtbl)[5]))(
            this,
            dwSiteData,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNavigationComplete(
        [NativeTypeName("DWORD")] uint dwSiteData,
        [NativeTypeName("DWORD")] uint dwreserved,
        HRESULT hrError,
        [NativeTypeName("LPCWSTR")] ushort* pwzError
    )
    {
        return ((delegate* unmanaged<IHlinkSite, uint, uint, HRESULT, ushort*, int>)((*lpVtbl)[6]))(
            this,
            dwSiteData,
            dwreserved,
            hrError,
            pwzError
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryService(
            [NativeTypeName("DWORD")] uint dwSiteData,
            [NativeTypeName("const GUID &")] Guid* guidService,
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown* ppiunk
        );

        [VtblIndex(4)]
        HRESULT GetMoniker(
            [NativeTypeName("DWORD")] uint dwSiteData,
            [NativeTypeName("DWORD")] uint dwAssign,
            [NativeTypeName("DWORD")] uint dwWhich,
            IMoniker* ppimk
        );

        [VtblIndex(5)]
        HRESULT ReadyToNavigate(
            [NativeTypeName("DWORD")] uint dwSiteData,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(6)]
        HRESULT OnNavigationComplete(
            [NativeTypeName("DWORD")] uint dwSiteData,
            [NativeTypeName("DWORD")] uint dwreserved,
            HRESULT hrError,
            [NativeTypeName("LPCWSTR")] ushort* pwzError
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
            "HRESULT (DWORD, const GUID &, const IID &, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, Guid*, Guid*, IUnknown*, int> QueryService;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, IMoniker*, int> GetMoniker;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> ReadyToNavigate;

        [NativeTypeName("HRESULT (DWORD, DWORD, HRESULT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, HRESULT, ushort*, int> OnNavigationComplete;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHlinkSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHlinkSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHlinkSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHlinkSite(Silk.NET.Windows.IUnknown value)
    {
        return new IHlinkSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHlinkSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHlinkSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHlinkSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
