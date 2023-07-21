// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker"]/*' />
[Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IPersistMoniker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPersistMoniker : IPersistMoniker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistMoniker));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[1]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[2]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker.GetClassID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistMoniker*, Guid*, int>)(lpVtbl[3]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker.IsDirty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistMoniker*, int>)(lpVtbl[4]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(BOOL fFullyAvailable, IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
    {
        return ((delegate* unmanaged<IPersistMoniker*, BOOL, IMoniker*, IBindCtx*, uint, int>)(lpVtbl[5]))((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
    }

    /// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, BOOL fRemember)
    {
        return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, BOOL, int>)(lpVtbl[6]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
    }

    /// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker.SaveCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SaveCompleted(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
    {
        return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, int>)(lpVtbl[7]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
    }

    /// <include file='IPersistMoniker.xml' path='doc/member[@name="IPersistMoniker.GetCurMoniker"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurMoniker(IMoniker** ppimkName)
    {
        return ((delegate* unmanaged<IPersistMoniker*, IMoniker**, int>)(lpVtbl[8]))((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID);

        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load(BOOL fFullyAvailable, IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode);

        [VtblIndex(6)]
        HRESULT Save(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, BOOL fRemember);

        [VtblIndex(7)]
        HRESULT SaveCompleted(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc);

        [VtblIndex(8)]
        HRESULT GetCurMoniker(IMoniker** ppimkName);
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
        public delegate* unmanaged<TSelf*, BOOL, IMoniker*, IBindCtx*, uint, int> Load;

        [NativeTypeName("HRESULT (IMoniker *, LPBC, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, IBindCtx*, BOOL, int> Save;

        [NativeTypeName("HRESULT (IMoniker *, LPBC) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, IBindCtx*, int> SaveCompleted;

        [NativeTypeName("HRESULT (IMoniker **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker**, int> GetCurMoniker;
    }
}
