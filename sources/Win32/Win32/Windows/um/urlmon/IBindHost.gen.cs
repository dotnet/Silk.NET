// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FC4801A1-2BA9-11CF-A229-00AA003D7352")]
[NativeTypeName("struct IBindHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBindHost : IBindHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBindHost));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBindHost, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBindHost, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBindHost, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMoniker(
        [NativeTypeName("LPOLESTR")] ushort* szName,
        IBindCtx pBC,
        IMoniker* ppmk,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<IBindHost, ushort*, IBindCtx, IMoniker*, uint, int>)((*lpVtbl)[3])
        )(this, szName, pBC, ppmk, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MonikerBindToStorage(
        IMoniker pMk,
        IBindCtx pBC,
        IBindStatusCallback pBSC,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    )
    {
        return (
            (delegate* unmanaged<
                IBindHost,
                IMoniker,
                IBindCtx,
                IBindStatusCallback,
                Guid*,
                void**,
                int>)((*lpVtbl)[4])
        )(this, pMk, pBC, pBSC, riid, ppvObj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MonikerBindToObject(
        IMoniker pMk,
        IBindCtx pBC,
        IBindStatusCallback pBSC,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvObj
    )
    {
        return (
            (delegate* unmanaged<
                IBindHost,
                IMoniker,
                IBindCtx,
                IBindStatusCallback,
                Guid*,
                void**,
                int>)((*lpVtbl)[5])
        )(this, pMk, pBC, pBSC, riid, ppvObj);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMoniker(
            [NativeTypeName("LPOLESTR")] ushort* szName,
            IBindCtx pBC,
            IMoniker* ppmk,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(4)]
        HRESULT MonikerBindToStorage(
            IMoniker pMk,
            IBindCtx pBC,
            IBindStatusCallback pBSC,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvObj
        );

        [VtblIndex(5)]
        HRESULT MonikerBindToObject(
            IMoniker pMk,
            IBindCtx pBC,
            IBindStatusCallback pBSC,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvObj
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
            "HRESULT (LPOLESTR, IBindCtx *, IMoniker **, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, IBindCtx, IMoniker*, uint, int> CreateMoniker;

        [NativeTypeName(
            "HRESULT (IMoniker *, IBindCtx *, IBindStatusCallback *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMoniker,
            IBindCtx,
            IBindStatusCallback,
            Guid*,
            void**,
            int> MonikerBindToStorage;

        [NativeTypeName(
            "HRESULT (IMoniker *, IBindCtx *, IBindStatusCallback *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMoniker,
            IBindCtx,
            IBindStatusCallback,
            Guid*,
            void**,
            int> MonikerBindToObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBindHost"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBindHost(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBindHost"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBindHost(Silk.NET.Windows.IUnknown value)
    {
        return new IBindHost(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBindHost"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBindHost"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBindHost value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
