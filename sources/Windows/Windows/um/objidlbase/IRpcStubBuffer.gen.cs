// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer"]/*' />
[Guid("D5F56AFC-593B-101A-B569-08002B2DBF7A")]
[NativeTypeName("struct IRpcStubBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcStubBuffer : IRpcStubBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcStubBuffer));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[1]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[2]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.Connect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(IUnknown* pUnkServer)
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, IUnknown*, int>)(lpVtbl[3]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pUnkServer);
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.Disconnect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Disconnect()
    {
        ((delegate* unmanaged<IRpcStubBuffer*, void>)(lpVtbl[4]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Invoke(RPCOLEMESSAGE* _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer)
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, RPCOLEMESSAGE*, IRpcChannelBuffer*, int>)(lpVtbl[5]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), _prpcmsg, _pRpcChannelBuffer);
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.IsIIDSupported"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public IRpcStubBuffer* IsIIDSupported([NativeTypeName("const IID &")] Guid* riid)
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, Guid*, IRpcStubBuffer*>)(lpVtbl[6]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), riid);
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.CountRefs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("ULONG")]
    public uint CountRefs()
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, uint>)(lpVtbl[7]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.DebugServerQueryInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DebugServerQueryInterface(void** ppv)
    {
        return ((delegate* unmanaged<IRpcStubBuffer*, void**, int>)(lpVtbl[8]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), ppv);
    }

    /// <include file='IRpcStubBuffer.xml' path='doc/member[@name="IRpcStubBuffer.DebugServerRelease"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void DebugServerRelease(void* pv)
    {
        ((delegate* unmanaged<IRpcStubBuffer*, void*, void>)(lpVtbl[9]))((IRpcStubBuffer*)Unsafe.AsPointer(ref this), pv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Connect(IUnknown* pUnkServer);

        [VtblIndex(4)]
        void Disconnect();

        [VtblIndex(5)]
        HRESULT Invoke(RPCOLEMESSAGE* _prpcmsg, IRpcChannelBuffer* _pRpcChannelBuffer);

        [VtblIndex(6)]
        IRpcStubBuffer* IsIIDSupported([NativeTypeName("const IID &")] Guid* riid);

        [VtblIndex(7)]
        [return: NativeTypeName("ULONG")]
        uint CountRefs();

        [VtblIndex(8)]
        HRESULT DebugServerQueryInterface(void** ppv);

        [VtblIndex(9)]
        void DebugServerRelease(void* pv);
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

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> Connect;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Disconnect;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, IRpcChannelBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, IRpcChannelBuffer*, int> Invoke;

        [NativeTypeName("IRpcStubBuffer *(const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IRpcStubBuffer*> IsIIDSupported;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> CountRefs;

        [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void**, int> DebugServerQueryInterface;

        [NativeTypeName("void (void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void> DebugServerRelease;
    }
}
