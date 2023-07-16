// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IOleCacheControl.xml' path='doc/member[@name="IOleCacheControl"]/*'/>
[Guid("00000129-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleCacheControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleCacheControl : IOleCacheControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleCacheControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleCacheControl*, Guid*, void**, int> )(lpVtbl[0]))((IOleCacheControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleCacheControl*, uint> )(lpVtbl[1]))((IOleCacheControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleCacheControl*, uint> )(lpVtbl[2]))((IOleCacheControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleCacheControl.xml' path='doc/member[@name="IOleCacheControl.OnRun"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnRun([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IOleCacheControl*, IDataObject*, int> )(lpVtbl[3]))((IOleCacheControl*)Unsafe.AsPointer(ref this), pDataObject);
    }

    /// <include file='IOleCacheControl.xml' path='doc/member[@name="IOleCacheControl.OnStop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnStop()
    {
        return ((delegate* unmanaged<IOleCacheControl*, int> )(lpVtbl[4]))((IOleCacheControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnRun([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject);
        [VtblIndex(4)]
        HRESULT OnStop();
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
        [NativeTypeName("HRESULT (LPDATAOBJECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, int> OnRun;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnStop;
    }
}