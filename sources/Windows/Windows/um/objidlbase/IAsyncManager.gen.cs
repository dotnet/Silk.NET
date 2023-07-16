// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAsyncManager.xml' path='doc/member[@name="IAsyncManager"]/*'/>
[Guid("0000002A-0000-0000-C000-000000000046")]
[NativeTypeName("struct IAsyncManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAsyncManager : IAsyncManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsyncManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncManager*, Guid*, void**, int> )(lpVtbl[0]))((IAsyncManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncManager*, uint> )(lpVtbl[1]))((IAsyncManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncManager*, uint> )(lpVtbl[2]))((IAsyncManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAsyncManager.xml' path='doc/member[@name="IAsyncManager.CompleteCall"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CompleteCall(HRESULT Result)
    {
        return ((delegate* unmanaged<IAsyncManager*, HRESULT, int> )(lpVtbl[3]))((IAsyncManager*)Unsafe.AsPointer(ref this), Result);
    }

    /// <include file='IAsyncManager.xml' path='doc/member[@name="IAsyncManager.GetCallContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCallContext([NativeTypeName("const IID &")] Guid* riid, void** pInterface)
    {
        return ((delegate* unmanaged<IAsyncManager*, Guid*, void**, int> )(lpVtbl[4]))((IAsyncManager*)Unsafe.AsPointer(ref this), riid, pInterface);
    }

    /// <include file='IAsyncManager.xml' path='doc/member[@name="IAsyncManager.GetState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetState([NativeTypeName("ULONG *")] uint* pulStateFlags)
    {
        return ((delegate* unmanaged<IAsyncManager*, uint*, int> )(lpVtbl[5]))((IAsyncManager*)Unsafe.AsPointer(ref this), pulStateFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CompleteCall(HRESULT Result);
        [VtblIndex(4)]
        HRESULT GetCallContext([NativeTypeName("const IID &")] Guid* riid, void** pInterface);
        [VtblIndex(5)]
        HRESULT GetState([NativeTypeName("ULONG *")] uint* pulStateFlags);
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
        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> CompleteCall;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetCallContext;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetState;
    }
}