// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4CF504B0-DE96-11D0-8B3F-00A0C911E8E5")]
[NativeTypeName("struct IBandSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBandSite : IBandSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBandSite));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBandSite, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBandSite, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBandSite, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddBand(IUnknown punk)
    {
        return ((delegate* unmanaged<IBandSite, IUnknown, int>)((*lpVtbl)[3]))(this, punk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumBands(uint uBand, [NativeTypeName("DWORD *")] uint* pdwBandID)
    {
        return ((delegate* unmanaged<IBandSite, uint, uint*, int>)((*lpVtbl)[4]))(
            this,
            uBand,
            pdwBandID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryBand(
        [NativeTypeName("DWORD")] uint dwBandID,
        IDeskBand* ppstb,
        [NativeTypeName("DWORD *")] uint* pdwState,
        [NativeTypeName("LPWSTR")] ushort* pszName,
        int cchName
    )
    {
        return (
            (delegate* unmanaged<IBandSite, uint, IDeskBand*, uint*, ushort*, int, int>)(
                (*lpVtbl)[5]
            )
        )(this, dwBandID, ppstb, pdwState, pszName, cchName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetBandState(
        [NativeTypeName("DWORD")] uint dwBandID,
        [NativeTypeName("DWORD")] uint dwMask,
        [NativeTypeName("DWORD")] uint dwState
    )
    {
        return ((delegate* unmanaged<IBandSite, uint, uint, uint, int>)((*lpVtbl)[6]))(
            this,
            dwBandID,
            dwMask,
            dwState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveBand([NativeTypeName("DWORD")] uint dwBandID)
    {
        return ((delegate* unmanaged<IBandSite, uint, int>)((*lpVtbl)[7]))(this, dwBandID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetBandObject(
        [NativeTypeName("DWORD")] uint dwBandID,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return ((delegate* unmanaged<IBandSite, uint, Guid*, void**, int>)((*lpVtbl)[8]))(
            this,
            dwBandID,
            riid,
            ppv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBandSiteInfo([NativeTypeName("const BANDSITEINFO *")] BANDSITEINFO* pbsinfo)
    {
        return ((delegate* unmanaged<IBandSite, BANDSITEINFO*, int>)((*lpVtbl)[9]))(this, pbsinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBandSiteInfo(BANDSITEINFO* pbsinfo)
    {
        return ((delegate* unmanaged<IBandSite, BANDSITEINFO*, int>)((*lpVtbl)[10]))(this, pbsinfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddBand(IUnknown punk);

        [VtblIndex(4)]
        HRESULT EnumBands(uint uBand, [NativeTypeName("DWORD *")] uint* pdwBandID);

        [VtblIndex(5)]
        HRESULT QueryBand(
            [NativeTypeName("DWORD")] uint dwBandID,
            IDeskBand* ppstb,
            [NativeTypeName("DWORD *")] uint* pdwState,
            [NativeTypeName("LPWSTR")] ushort* pszName,
            int cchName
        );

        [VtblIndex(6)]
        HRESULT SetBandState(
            [NativeTypeName("DWORD")] uint dwBandID,
            [NativeTypeName("DWORD")] uint dwMask,
            [NativeTypeName("DWORD")] uint dwState
        );

        [VtblIndex(7)]
        HRESULT RemoveBand([NativeTypeName("DWORD")] uint dwBandID);

        [VtblIndex(8)]
        HRESULT GetBandObject(
            [NativeTypeName("DWORD")] uint dwBandID,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(9)]
        HRESULT SetBandSiteInfo([NativeTypeName("const BANDSITEINFO *")] BANDSITEINFO* pbsinfo);

        [VtblIndex(10)]
        HRESULT GetBandSiteInfo(BANDSITEINFO* pbsinfo);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> AddBand;

        [NativeTypeName("HRESULT (UINT, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> EnumBands;

        [NativeTypeName(
            "HRESULT (DWORD, IDeskBand **, DWORD *, LPWSTR, int) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDeskBand*, uint*, ushort*, int, int> QueryBand;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> SetBandState;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveBand;

        [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> GetBandObject;

        [NativeTypeName("HRESULT (const BANDSITEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANDSITEINFO*, int> SetBandSiteInfo;

        [NativeTypeName("HRESULT (BANDSITEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BANDSITEINFO*, int> GetBandSiteInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBandSite"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBandSite(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBandSite"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBandSite(Silk.NET.Windows.IUnknown value)
    {
        return new IBandSite(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBandSite"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBandSite"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBandSite value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
