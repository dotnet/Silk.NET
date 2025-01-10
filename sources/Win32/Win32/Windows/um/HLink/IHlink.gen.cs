// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9C3-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHlink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHlink : IHlink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHlink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHlink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHlink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHlink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetHlinkSite(IHlinkSite pihlSite, [NativeTypeName("DWORD")] uint dwSiteData)
    {
        return ((delegate* unmanaged<IHlink, IHlinkSite, uint, int>)((*lpVtbl)[3]))(
            this,
            pihlSite,
            dwSiteData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHlinkSite(
        IHlinkSite* ppihlSite,
        [NativeTypeName("DWORD *")] uint* pdwSiteData
    )
    {
        return ((delegate* unmanaged<IHlink, IHlinkSite*, uint*, int>)((*lpVtbl)[4]))(
            this,
            ppihlSite,
            pdwSiteData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMonikerReference(
        [NativeTypeName("DWORD")] uint grfHLSETF,
        IMoniker pimkTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation
    )
    {
        return ((delegate* unmanaged<IHlink, uint, IMoniker, ushort*, int>)((*lpVtbl)[5]))(
            this,
            grfHLSETF,
            pimkTarget,
            pwzLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMonikerReference(
        [NativeTypeName("DWORD")] uint dwWhichRef,
        IMoniker* ppimkTarget,
        [NativeTypeName("LPWSTR *")] ushort** ppwzLocation
    )
    {
        return ((delegate* unmanaged<IHlink, uint, IMoniker*, ushort**, int>)((*lpVtbl)[6]))(
            this,
            dwWhichRef,
            ppimkTarget,
            ppwzLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetStringReference(
        [NativeTypeName("DWORD")] uint grfHLSETF,
        [NativeTypeName("LPCWSTR")] ushort* pwzTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation
    )
    {
        return ((delegate* unmanaged<IHlink, uint, ushort*, ushort*, int>)((*lpVtbl)[7]))(
            this,
            grfHLSETF,
            pwzTarget,
            pwzLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStringReference(
        [NativeTypeName("DWORD")] uint dwWhichRef,
        [NativeTypeName("LPWSTR *")] ushort** ppwzTarget,
        [NativeTypeName("LPWSTR *")] ushort** ppwzLocation
    )
    {
        return ((delegate* unmanaged<IHlink, uint, ushort**, ushort**, int>)((*lpVtbl)[8]))(
            this,
            dwWhichRef,
            ppwzTarget,
            ppwzLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetFriendlyName([NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName)
    {
        return ((delegate* unmanaged<IHlink, ushort*, int>)((*lpVtbl)[9]))(this, pwzFriendlyName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(
        [NativeTypeName("DWORD")] uint grfHLFNAMEF,
        [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName
    )
    {
        return ((delegate* unmanaged<IHlink, uint, ushort**, int>)((*lpVtbl)[10]))(
            this,
            grfHLFNAMEF,
            ppwzFriendlyName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetTargetFrameName([NativeTypeName("LPCWSTR")] ushort* pwzTargetFrameName)
    {
        return ((delegate* unmanaged<IHlink, ushort*, int>)((*lpVtbl)[11]))(
            this,
            pwzTargetFrameName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetTargetFrameName([NativeTypeName("LPWSTR *")] ushort** ppwzTargetFrameName)
    {
        return ((delegate* unmanaged<IHlink, ushort**, int>)((*lpVtbl)[12]))(
            this,
            ppwzTargetFrameName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<IHlink, uint*, int>)((*lpVtbl)[13]))(this, pdwStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Navigate(
        [NativeTypeName("DWORD")] uint grfHLNF,
        [NativeTypeName("LPBC")] IBindCtx pibc,
        IBindStatusCallback pibsc,
        IHlinkBrowseContext pihlbc
    )
    {
        return (
            (delegate* unmanaged<
                IHlink,
                uint,
                IBindCtx,
                IBindStatusCallback,
                IHlinkBrowseContext,
                int>)((*lpVtbl)[14])
        )(this, grfHLNF, pibc, pibsc, pihlbc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetAdditionalParams([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalParams)
    {
        return ((delegate* unmanaged<IHlink, ushort*, int>)((*lpVtbl)[15]))(
            this,
            pwzAdditionalParams
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAdditionalParams([NativeTypeName("LPWSTR *")] ushort** ppwzAdditionalParams)
    {
        return ((delegate* unmanaged<IHlink, ushort**, int>)((*lpVtbl)[16]))(
            this,
            ppwzAdditionalParams
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetHlinkSite(IHlinkSite pihlSite, [NativeTypeName("DWORD")] uint dwSiteData);

        [VtblIndex(4)]
        HRESULT GetHlinkSite(IHlinkSite* ppihlSite, [NativeTypeName("DWORD *")] uint* pdwSiteData);

        [VtblIndex(5)]
        HRESULT SetMonikerReference(
            [NativeTypeName("DWORD")] uint grfHLSETF,
            IMoniker pimkTarget,
            [NativeTypeName("LPCWSTR")] ushort* pwzLocation
        );

        [VtblIndex(6)]
        HRESULT GetMonikerReference(
            [NativeTypeName("DWORD")] uint dwWhichRef,
            IMoniker* ppimkTarget,
            [NativeTypeName("LPWSTR *")] ushort** ppwzLocation
        );

        [VtblIndex(7)]
        HRESULT SetStringReference(
            [NativeTypeName("DWORD")] uint grfHLSETF,
            [NativeTypeName("LPCWSTR")] ushort* pwzTarget,
            [NativeTypeName("LPCWSTR")] ushort* pwzLocation
        );

        [VtblIndex(8)]
        HRESULT GetStringReference(
            [NativeTypeName("DWORD")] uint dwWhichRef,
            [NativeTypeName("LPWSTR *")] ushort** ppwzTarget,
            [NativeTypeName("LPWSTR *")] ushort** ppwzLocation
        );

        [VtblIndex(9)]
        HRESULT SetFriendlyName([NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName);

        [VtblIndex(10)]
        HRESULT GetFriendlyName(
            [NativeTypeName("DWORD")] uint grfHLFNAMEF,
            [NativeTypeName("LPWSTR *")] ushort** ppwzFriendlyName
        );

        [VtblIndex(11)]
        HRESULT SetTargetFrameName([NativeTypeName("LPCWSTR")] ushort* pwzTargetFrameName);

        [VtblIndex(12)]
        HRESULT GetTargetFrameName([NativeTypeName("LPWSTR *")] ushort** ppwzTargetFrameName);

        [VtblIndex(13)]
        HRESULT GetMiscStatus([NativeTypeName("DWORD *")] uint* pdwStatus);

        [VtblIndex(14)]
        HRESULT Navigate(
            [NativeTypeName("DWORD")] uint grfHLNF,
            [NativeTypeName("LPBC")] IBindCtx pibc,
            IBindStatusCallback pibsc,
            IHlinkBrowseContext pihlbc
        );

        [VtblIndex(15)]
        HRESULT SetAdditionalParams([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalParams);

        [VtblIndex(16)]
        HRESULT GetAdditionalParams([NativeTypeName("LPWSTR *")] ushort** ppwzAdditionalParams);
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

        [NativeTypeName("HRESULT (IHlinkSite *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkSite, uint, int> SetHlinkSite;

        [NativeTypeName("HRESULT (IHlinkSite **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkSite*, uint*, int> GetHlinkSite;

        [NativeTypeName("HRESULT (DWORD, IMoniker *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMoniker, ushort*, int> SetMonikerReference;

        [NativeTypeName("HRESULT (DWORD, IMoniker **, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMoniker*, ushort**, int> GetMonikerReference;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, int> SetStringReference;

        [NativeTypeName("HRESULT (DWORD, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, ushort**, int> GetStringReference;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetFriendlyName;

        [NativeTypeName("HRESULT (DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetFriendlyName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetTargetFrameName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetTargetFrameName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMiscStatus;

        [NativeTypeName(
            "HRESULT (DWORD, LPBC, IBindStatusCallback *, IHlinkBrowseContext *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IBindCtx,
            IBindStatusCallback,
            IHlinkBrowseContext,
            int> Navigate;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetAdditionalParams;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAdditionalParams;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHlink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHlink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHlink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHlink(Silk.NET.Windows.IUnknown value)
    {
        return new IHlink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHlink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHlink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHlink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
