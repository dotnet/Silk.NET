// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPersistStreamInit.xml' path='doc/member[@name="IPersistStreamInit"]/*' />
[Guid("7FD52380-4E07-101B-AE2D-08002B2EC713")]
[NativeTypeName("struct IPersistStreamInit : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistStreamInit : IPersistStreamInit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStreamInit));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistStreamInit*, Guid*, void**, int>)(lpVtbl[0]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistStreamInit*, uint>)(lpVtbl[1]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistStreamInit*, uint>)(lpVtbl[2]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistStreamInit*, Guid*, int>)(lpVtbl[3]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistStreamInit.xml' path='doc/member[@name="IPersistStreamInit.IsDirty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistStreamInit*, int>)(lpVtbl[4]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistStreamInit.xml' path='doc/member[@name="IPersistStreamInit.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load([NativeTypeName("LPSTREAM")] IStream* pStm)
    {
        return ((delegate* unmanaged<IPersistStreamInit*, IStream*, int>)(lpVtbl[5]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <include file='IPersistStreamInit.xml' path='doc/member[@name="IPersistStreamInit.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save([NativeTypeName("LPSTREAM")] IStream* pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<IPersistStreamInit*, IStream*, BOOL, int>)(lpVtbl[6]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <include file='IPersistStreamInit.xml' path='doc/member[@name="IPersistStreamInit.GetSizeMax"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pCbSize)
    {
        return ((delegate* unmanaged<IPersistStreamInit*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pCbSize);
    }

    /// <include file='IPersistStreamInit.xml' path='doc/member[@name="IPersistStreamInit.InitNew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistStreamInit*, int>)(lpVtbl[8]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load([NativeTypeName("LPSTREAM")] IStream* pStm);

        [VtblIndex(6)]
        HRESULT Save([NativeTypeName("LPSTREAM")] IStream* pStm, BOOL fClearDirty);

        [VtblIndex(7)]
        HRESULT GetSizeMax(ULARGE_INTEGER* pCbSize);

        [VtblIndex(8)]
        HRESULT InitNew();
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

        [NativeTypeName("HRESULT (LPSTREAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> Load;

        [NativeTypeName("HRESULT (LPSTREAM, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, BOOL, int> Save;

        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InitNew;
    }
}
