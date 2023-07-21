// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IRpcHelper.xml' path='doc/member[@name="IRpcHelper"]/*' />
[Guid("00000149-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRpcHelper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcHelper : IRpcHelper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcHelper));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcHelper*, Guid*, void**, int>)(lpVtbl[0]))((IRpcHelper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRpcHelper*, uint>)(lpVtbl[1]))((IRpcHelper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcHelper*, uint>)(lpVtbl[2]))((IRpcHelper*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcHelper.xml' path='doc/member[@name="IRpcHelper.GetDCOMProtocolVersion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDCOMProtocolVersion([NativeTypeName("DWORD *")] uint* pComVersion)
    {
        return ((delegate* unmanaged<IRpcHelper*, uint*, int>)(lpVtbl[3]))((IRpcHelper*)Unsafe.AsPointer(ref this), pComVersion);
    }

    /// <include file='IRpcHelper.xml' path='doc/member[@name="IRpcHelper.GetIIDFromOBJREF"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIIDFromOBJREF(void* pObjRef, [NativeTypeName("IID **")] Guid** piid)
    {
        return ((delegate* unmanaged<IRpcHelper*, void*, Guid**, int>)(lpVtbl[4]))((IRpcHelper*)Unsafe.AsPointer(ref this), pObjRef, piid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDCOMProtocolVersion([NativeTypeName("DWORD *")] uint* pComVersion);

        [VtblIndex(4)]
        HRESULT GetIIDFromOBJREF(void* pObjRef, [NativeTypeName("IID **")] Guid** piid);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDCOMProtocolVersion;

        [NativeTypeName("HRESULT (void *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, Guid**, int> GetIIDFromOBJREF;
    }
}
