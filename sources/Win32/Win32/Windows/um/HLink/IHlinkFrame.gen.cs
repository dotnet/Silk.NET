// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/HLink.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9C5-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHlinkFrame : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHlinkFrame : IHlinkFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHlinkFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHlinkFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHlinkFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHlinkFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBrowseContext(IHlinkBrowseContext pihlbc)
    {
        return ((delegate* unmanaged<IHlinkFrame, IHlinkBrowseContext, int>)((*lpVtbl)[3]))(
            this,
            pihlbc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBrowseContext(IHlinkBrowseContext* ppihlbc)
    {
        return ((delegate* unmanaged<IHlinkFrame, IHlinkBrowseContext*, int>)((*lpVtbl)[4]))(
            this,
            ppihlbc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Navigate(
        [NativeTypeName("DWORD")] uint grfHLNF,
        [NativeTypeName("LPBC")] IBindCtx pbc,
        IBindStatusCallback pibsc,
        IHlink pihlNavigate
    )
    {
        return (
            (delegate* unmanaged<IHlinkFrame, uint, IBindCtx, IBindStatusCallback, IHlink, int>)(
                (*lpVtbl)[5]
            )
        )(this, grfHLNF, pbc, pibsc, pihlNavigate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNavigate(
        [NativeTypeName("DWORD")] uint grfHLNF,
        IMoniker pimkTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName,
        [NativeTypeName("DWORD")] uint dwreserved
    )
    {
        return (
            (delegate* unmanaged<IHlinkFrame, uint, IMoniker, ushort*, ushort*, uint, int>)(
                (*lpVtbl)[6]
            )
        )(this, grfHLNF, pimkTarget, pwzLocation, pwzFriendlyName, dwreserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateHlink(
        [NativeTypeName("ULONG")] uint uHLID,
        IMoniker pimkTarget,
        [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
        [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName
    )
    {
        return (
            (delegate* unmanaged<IHlinkFrame, uint, IMoniker, ushort*, ushort*, int>)((*lpVtbl)[7])
        )(this, uHLID, pimkTarget, pwzLocation, pwzFriendlyName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBrowseContext(IHlinkBrowseContext pihlbc);

        [VtblIndex(4)]
        HRESULT GetBrowseContext(IHlinkBrowseContext* ppihlbc);

        [VtblIndex(5)]
        HRESULT Navigate(
            [NativeTypeName("DWORD")] uint grfHLNF,
            [NativeTypeName("LPBC")] IBindCtx pbc,
            IBindStatusCallback pibsc,
            IHlink pihlNavigate
        );

        [VtblIndex(6)]
        HRESULT OnNavigate(
            [NativeTypeName("DWORD")] uint grfHLNF,
            IMoniker pimkTarget,
            [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
            [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName,
            [NativeTypeName("DWORD")] uint dwreserved
        );

        [VtblIndex(7)]
        HRESULT UpdateHlink(
            [NativeTypeName("ULONG")] uint uHLID,
            IMoniker pimkTarget,
            [NativeTypeName("LPCWSTR")] ushort* pwzLocation,
            [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName
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

        [NativeTypeName("HRESULT (IHlinkBrowseContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkBrowseContext, int> SetBrowseContext;

        [NativeTypeName("HRESULT (IHlinkBrowseContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHlinkBrowseContext*, int> GetBrowseContext;

        [NativeTypeName(
            "HRESULT (DWORD, LPBC, IBindStatusCallback *, IHlink *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IBindCtx,
            IBindStatusCallback,
            IHlink,
            int> Navigate;

        [NativeTypeName(
            "HRESULT (DWORD, IMoniker *, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IMoniker, ushort*, ushort*, uint, int> OnNavigate;

        [NativeTypeName("HRESULT (ULONG, IMoniker *, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMoniker, ushort*, ushort*, int> UpdateHlink;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHlinkFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHlinkFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHlinkFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHlinkFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IHlinkFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHlinkFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHlinkFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHlinkFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
