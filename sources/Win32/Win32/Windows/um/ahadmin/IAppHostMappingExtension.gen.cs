// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("31A83EA0-C0E4-4A2C-8A01-353CC2A4C60A")]
[NativeTypeName("struct IAppHostMappingExtension : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostMappingExtension
    : IAppHostMappingExtension.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostMappingExtension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostMappingExtension, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostMappingExtension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostMappingExtension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSiteNameFromSiteId(
        [NativeTypeName("DWORD")] uint dwSiteId,
        [NativeTypeName("BSTR *")] ushort** pbstrSiteName
    )
    {
        return ((delegate* unmanaged<IAppHostMappingExtension, uint, ushort**, int>)((*lpVtbl)[3]))(
            this,
            dwSiteId,
            pbstrSiteName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSiteIdFromSiteName(
        [NativeTypeName("BSTR")] ushort* bstrSiteName,
        [NativeTypeName("DWORD *")] uint* pdwSiteId
    )
    {
        return ((delegate* unmanaged<IAppHostMappingExtension, ushort*, uint*, int>)((*lpVtbl)[4]))(
            this,
            bstrSiteName,
            pdwSiteId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSiteElementFromSiteId(
        [NativeTypeName("DWORD")] uint dwSiteId,
        IAppHostElement* ppSiteElement
    )
    {
        return (
            (delegate* unmanaged<IAppHostMappingExtension, uint, IAppHostElement*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dwSiteId, ppSiteElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT MapPath(
        [NativeTypeName("BSTR")] ushort* bstrSiteName,
        [NativeTypeName("BSTR")] ushort* bstrVirtualPath,
        [NativeTypeName("BSTR *")] ushort** pbstrPhysicalPath,
        IAppHostElement* ppVirtualDirectoryElement,
        IAppHostElement* ppApplicationElement
    )
    {
        return (
            (delegate* unmanaged<
                IAppHostMappingExtension,
                ushort*,
                ushort*,
                ushort**,
                IAppHostElement*,
                IAppHostElement*,
                int>)((*lpVtbl)[6])
        )(
            this,
            bstrSiteName,
            bstrVirtualPath,
            pbstrPhysicalPath,
            ppVirtualDirectoryElement,
            ppApplicationElement
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSiteNameFromSiteId(
            [NativeTypeName("DWORD")] uint dwSiteId,
            [NativeTypeName("BSTR *")] ushort** pbstrSiteName
        );

        [VtblIndex(4)]
        HRESULT GetSiteIdFromSiteName(
            [NativeTypeName("BSTR")] ushort* bstrSiteName,
            [NativeTypeName("DWORD *")] uint* pdwSiteId
        );

        [VtblIndex(5)]
        HRESULT GetSiteElementFromSiteId(
            [NativeTypeName("DWORD")] uint dwSiteId,
            IAppHostElement* ppSiteElement
        );

        [VtblIndex(6)]
        HRESULT MapPath(
            [NativeTypeName("BSTR")] ushort* bstrSiteName,
            [NativeTypeName("BSTR")] ushort* bstrVirtualPath,
            [NativeTypeName("BSTR *")] ushort** pbstrPhysicalPath,
            IAppHostElement* ppVirtualDirectoryElement,
            IAppHostElement* ppApplicationElement
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

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetSiteNameFromSiteId;

        [NativeTypeName("HRESULT (BSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetSiteIdFromSiteName;

        [NativeTypeName("HRESULT (DWORD, IAppHostElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IAppHostElement*, int> GetSiteElementFromSiteId;

        [NativeTypeName(
            "HRESULT (BSTR, BSTR, BSTR *, IAppHostElement **, IAppHostElement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort**,
            IAppHostElement*,
            IAppHostElement*,
            int> MapPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostMappingExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostMappingExtension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostMappingExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostMappingExtension(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostMappingExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostMappingExtension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostMappingExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostMappingExtension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
