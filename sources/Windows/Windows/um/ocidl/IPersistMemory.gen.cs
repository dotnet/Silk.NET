// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPersistMemory.xml' path='doc/member[@name="IPersistMemory"]/*' />
[Guid("BD1AE5E0-A6AE-11CE-BD37-504200C10000")]
[NativeTypeName("struct IPersistMemory : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistMemory : IPersistMemory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistMemory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistMemory*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMemory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistMemory*, uint>)(lpVtbl[1]))((IPersistMemory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistMemory*, uint>)(lpVtbl[2]))((IPersistMemory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistMemory*, Guid*, int>)(lpVtbl[3]))((IPersistMemory*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistMemory.xml' path='doc/member[@name="IPersistMemory.IsDirty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistMemory*, int>)(lpVtbl[4]))((IPersistMemory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistMemory.xml' path='doc/member[@name="IPersistMemory.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize)
    {
        return ((delegate* unmanaged<IPersistMemory*, void*, uint, int>)(lpVtbl[5]))((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, cbSize);
    }

    /// <include file='IPersistMemory.xml' path='doc/member[@name="IPersistMemory.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save([NativeTypeName("LPVOID")] void* pMem, BOOL fClearDirty, [NativeTypeName("ULONG")] uint cbSize)
    {
        return ((delegate* unmanaged<IPersistMemory*, void*, BOOL, uint, int>)(lpVtbl[6]))((IPersistMemory*)Unsafe.AsPointer(ref this), pMem, fClearDirty, cbSize);
    }

    /// <include file='IPersistMemory.xml' path='doc/member[@name="IPersistMemory.GetSizeMax"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize)
    {
        return ((delegate* unmanaged<IPersistMemory*, uint*, int>)(lpVtbl[7]))((IPersistMemory*)Unsafe.AsPointer(ref this), pCbSize);
    }

    /// <include file='IPersistMemory.xml' path='doc/member[@name="IPersistMemory.InitNew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InitNew()
    {
        return ((delegate* unmanaged<IPersistMemory*, int>)(lpVtbl[8]))((IPersistMemory*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load([NativeTypeName("LPVOID")] void* pMem, [NativeTypeName("ULONG")] uint cbSize);

        [VtblIndex(6)]
        HRESULT Save([NativeTypeName("LPVOID")] void* pMem, BOOL fClearDirty, [NativeTypeName("ULONG")] uint cbSize);

        [VtblIndex(7)]
        HRESULT GetSizeMax([NativeTypeName("ULONG *")] uint* pCbSize);

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

        [NativeTypeName("HRESULT (LPVOID, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, int> Load;

        [NativeTypeName("HRESULT (LPVOID, BOOL, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, BOOL, uint, int> Save;

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSizeMax;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InitNew;
    }
}
