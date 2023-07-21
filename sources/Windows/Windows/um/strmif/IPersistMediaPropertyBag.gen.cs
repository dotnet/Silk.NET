// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPersistMediaPropertyBag.xml' path='doc/member[@name="IPersistMediaPropertyBag"]/*' />
[Guid("5738E040-B67F-11D0-BD4D-00A0C911CE86")]
[NativeTypeName("struct IPersistMediaPropertyBag : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistMediaPropertyBag : IPersistMediaPropertyBag.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistMediaPropertyBag));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, uint>)(lpVtbl[1]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, uint>)(lpVtbl[2]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, Guid*, int>)(lpVtbl[3]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistMediaPropertyBag.xml' path='doc/member[@name="IPersistMediaPropertyBag.InitNew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, int>)(lpVtbl[4]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistMediaPropertyBag.xml' path='doc/member[@name="IPersistMediaPropertyBag.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IMediaPropertyBag* pPropBag, IErrorLog* pErrorLog)
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, IMediaPropertyBag*, IErrorLog*, int>)(lpVtbl[5]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, pErrorLog);
    }

    /// <include file='IPersistMediaPropertyBag.xml' path='doc/member[@name="IPersistMediaPropertyBag.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IMediaPropertyBag* pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties)
    {
        return ((delegate* unmanaged<IPersistMediaPropertyBag*, IMediaPropertyBag*, BOOL, BOOL, int>)(lpVtbl[6]))((IPersistMediaPropertyBag*)Unsafe.AsPointer(ref this), pPropBag, fClearDirty, fSaveAllProperties);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT InitNew();

        [VtblIndex(5)]
        HRESULT Load(IMediaPropertyBag* pPropBag, IErrorLog* pErrorLog);

        [VtblIndex(6)]
        HRESULT Save(IMediaPropertyBag* pPropBag, BOOL fClearDirty, BOOL fSaveAllProperties);
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
        public delegate* unmanaged<TSelf*, int> InitNew;

        [NativeTypeName("HRESULT (IMediaPropertyBag *, IErrorLog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaPropertyBag*, IErrorLog*, int> Load;

        [NativeTypeName("HRESULT (IMediaPropertyBag *, BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaPropertyBag*, BOOL, BOOL, int> Save;
    }
}
