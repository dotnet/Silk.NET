// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000011D-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleLink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleLink : IOleLink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleLink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleLink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleLink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleLink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetUpdateOptions([NativeTypeName("DWORD")] uint dwUpdateOpt)
    {
        return ((delegate* unmanaged<IOleLink, uint, int>)((*lpVtbl)[3]))(this, dwUpdateOpt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUpdateOptions([NativeTypeName("DWORD *")] uint* pdwUpdateOpt)
    {
        return ((delegate* unmanaged<IOleLink, uint*, int>)((*lpVtbl)[4]))(this, pdwUpdateOpt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSourceMoniker(IMoniker pmk, [NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<IOleLink, IMoniker, Guid*, int>)((*lpVtbl)[5]))(
            this,
            pmk,
            rclsid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceMoniker(IMoniker* ppmk)
    {
        return ((delegate* unmanaged<IOleLink, IMoniker*, int>)((*lpVtbl)[6]))(this, ppmk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSourceDisplayName([NativeTypeName("LPCOLESTR")] ushort* pszStatusText)
    {
        return ((delegate* unmanaged<IOleLink, ushort*, int>)((*lpVtbl)[7]))(this, pszStatusText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSourceDisplayName([NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName)
    {
        return ((delegate* unmanaged<IOleLink, ushort**, int>)((*lpVtbl)[8]))(
            this,
            ppszDisplayName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BindToSource([NativeTypeName("DWORD")] uint bindflags, IBindCtx pbc)
    {
        return ((delegate* unmanaged<IOleLink, uint, IBindCtx, int>)((*lpVtbl)[9]))(
            this,
            bindflags,
            pbc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT BindIfRunning()
    {
        return ((delegate* unmanaged<IOleLink, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetBoundSource(IUnknown* ppunk)
    {
        return ((delegate* unmanaged<IOleLink, IUnknown*, int>)((*lpVtbl)[11]))(this, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnbindSource()
    {
        return ((delegate* unmanaged<IOleLink, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Update(IBindCtx pbc)
    {
        return ((delegate* unmanaged<IOleLink, IBindCtx, int>)((*lpVtbl)[13]))(this, pbc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetUpdateOptions([NativeTypeName("DWORD")] uint dwUpdateOpt);

        [VtblIndex(4)]
        HRESULT GetUpdateOptions([NativeTypeName("DWORD *")] uint* pdwUpdateOpt);

        [VtblIndex(5)]
        HRESULT SetSourceMoniker(IMoniker pmk, [NativeTypeName("const IID &")] Guid* rclsid);

        [VtblIndex(6)]
        HRESULT GetSourceMoniker(IMoniker* ppmk);

        [VtblIndex(7)]
        HRESULT SetSourceDisplayName([NativeTypeName("LPCOLESTR")] ushort* pszStatusText);

        [VtblIndex(8)]
        HRESULT GetSourceDisplayName([NativeTypeName("LPOLESTR *")] ushort** ppszDisplayName);

        [VtblIndex(9)]
        HRESULT BindToSource([NativeTypeName("DWORD")] uint bindflags, IBindCtx pbc);

        [VtblIndex(10)]
        HRESULT BindIfRunning();

        [VtblIndex(11)]
        HRESULT GetBoundSource(IUnknown* ppunk);

        [VtblIndex(12)]
        HRESULT UnbindSource();

        [VtblIndex(13)]
        HRESULT Update(IBindCtx pbc);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetUpdateOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUpdateOptions;

        [NativeTypeName("HRESULT (IMoniker *, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, Guid*, int> SetSourceMoniker;

        [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, int> GetSourceMoniker;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSourceDisplayName;

        [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSourceDisplayName;

        [NativeTypeName("HRESULT (DWORD, IBindCtx *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IBindCtx, int> BindToSource;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BindIfRunning;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetBoundSource;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnbindSource;

        [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx, int> Update;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleLink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleLink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleLink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleLink(Silk.NET.Windows.IUnknown value)
    {
        return new IOleLink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleLink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleLink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleLink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
