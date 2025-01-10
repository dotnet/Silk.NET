// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IPersistMoniker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPersistMoniker : IPersistMoniker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistMoniker));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistMoniker, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistMoniker, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistMoniker, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistMoniker, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistMoniker, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(
        BOOL fFullyAvailable,
        IMoniker pimkName,
        [NativeTypeName("LPBC")] IBindCtx pibc,
        [NativeTypeName("DWORD")] uint grfMode
    )
    {
        return (
            (delegate* unmanaged<IPersistMoniker, BOOL, IMoniker, IBindCtx, uint, int>)(
                (*lpVtbl)[5]
            )
        )(this, fFullyAvailable, pimkName, pibc, grfMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IMoniker pimkName, [NativeTypeName("LPBC")] IBindCtx pbc, BOOL fRemember)
    {
        return (
            (delegate* unmanaged<IPersistMoniker, IMoniker, IBindCtx, BOOL, int>)((*lpVtbl)[6])
        )(this, pimkName, pbc, fRemember);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SaveCompleted(IMoniker pimkName, [NativeTypeName("LPBC")] IBindCtx pibc)
    {
        return ((delegate* unmanaged<IPersistMoniker, IMoniker, IBindCtx, int>)((*lpVtbl)[7]))(
            this,
            pimkName,
            pibc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurMoniker(IMoniker* ppimkName)
    {
        return ((delegate* unmanaged<IPersistMoniker, IMoniker*, int>)((*lpVtbl)[8]))(
            this,
            ppimkName
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID);

        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load(
            BOOL fFullyAvailable,
            IMoniker pimkName,
            [NativeTypeName("LPBC")] IBindCtx pibc,
            [NativeTypeName("DWORD")] uint grfMode
        );

        [VtblIndex(6)]
        HRESULT Save(IMoniker pimkName, [NativeTypeName("LPBC")] IBindCtx pbc, BOOL fRemember);

        [VtblIndex(7)]
        HRESULT SaveCompleted(IMoniker pimkName, [NativeTypeName("LPBC")] IBindCtx pibc);

        [VtblIndex(8)]
        HRESULT GetCurMoniker(IMoniker* ppimkName);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;

        [NativeTypeName("HRESULT (BOOL, IMoniker *, LPBC, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, IMoniker, IBindCtx, uint, int> Load;

        [NativeTypeName("HRESULT (IMoniker *, LPBC, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, IBindCtx, BOOL, int> Save;

        [NativeTypeName("HRESULT (IMoniker *, LPBC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker, IBindCtx, int> SaveCompleted;

        [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, int> GetCurMoniker;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistMoniker"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistMoniker(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistMoniker"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistMoniker(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistMoniker(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistMoniker"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistMoniker"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistMoniker value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
