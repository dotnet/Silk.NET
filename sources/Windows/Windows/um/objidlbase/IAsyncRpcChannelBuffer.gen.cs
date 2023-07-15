// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAsyncRpcChannelBuffer.xml' path='doc/member[@name="IAsyncRpcChannelBuffer"]/*'/>
[Guid("A5029FB6-3C34-11D1-9C99-00C04FB998AA")]
[NativeTypeName("struct IAsyncRpcChannelBuffer : IRpcChannelBuffer2")]
[NativeInheritance("IRpcChannelBuffer2")]
public unsafe partial struct IAsyncRpcChannelBuffer : IAsyncRpcChannelBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsyncRpcChannelBuffer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, Guid*, void**, int> )(lpVtbl[0]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint> )(lpVtbl[1]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint> )(lpVtbl[2]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IRpcChannelBuffer.GetBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int> )(lpVtbl[3]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
    }

    /// <inheritdoc cref = "IRpcChannelBuffer.SendReceive"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int> )(lpVtbl[4]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
    }

    /// <inheritdoc cref = "IRpcChannelBuffer.FreeBuffer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, int> )(lpVtbl[5]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
    }

    /// <inheritdoc cref = "IRpcChannelBuffer.GetDestCtx"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint*, void**, int> )(lpVtbl[6]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
    }

    /// <inheritdoc cref = "IRpcChannelBuffer.IsConnected"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected()
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, int> )(lpVtbl[7]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IRpcChannelBuffer2.GetProtocolVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint*, int> )(lpVtbl[8]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwVersion);
    }

    /// <include file='IAsyncRpcChannelBuffer.xml' path='doc/member[@name="IAsyncRpcChannelBuffer.Send"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Send(RPCOLEMESSAGE* pMsg, ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, ISynchronize*, uint*, int> )(lpVtbl[9]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pSync, pulStatus);
    }

    /// <include file='IAsyncRpcChannelBuffer.xml' path='doc/member[@name="IAsyncRpcChannelBuffer.Receive"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Receive(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int> )(lpVtbl[10]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
    }

    /// <include file='IAsyncRpcChannelBuffer.xml' path='doc/member[@name="IAsyncRpcChannelBuffer.GetDestCtxEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDestCtxEx(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
    {
        return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, void**, int> )(lpVtbl[11]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
    }

    public interface Interface : IRpcChannelBuffer2.Interface
    {
        [VtblIndex(9)]
        HRESULT Send(RPCOLEMESSAGE* pMsg, ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus);
        [VtblIndex(10)]
        HRESULT Receive(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus);
        [VtblIndex(11)]
        HRESULT GetDestCtxEx(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext);
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
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, Guid*, int> GetBuffer;
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, int> SendReceive;
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, int> FreeBuffer;
        [NativeTypeName("HRESULT (DWORD *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, void**, int> GetDestCtx;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsConnected;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProtocolVersion;
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ISynchronize *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, ISynchronize*, uint*, int> Send;
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, int> Receive;
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, void**, int> GetDestCtxEx;
    }
}