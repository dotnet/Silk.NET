// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IRpcProxyBuffer.xml' path='doc/member[@name="IRpcProxyBuffer"]/*'/>
[Guid("D5F56A34-593B-101A-B569-08002B2DBF7A")]
[NativeTypeName("struct IRpcProxyBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcProxyBuffer : IRpcProxyBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcProxyBuffer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcProxyBuffer*, Guid*, void**, int> )(lpVtbl[0]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRpcProxyBuffer*, uint> )(lpVtbl[1]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcProxyBuffer*, uint> )(lpVtbl[2]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcProxyBuffer.xml' path='doc/member[@name="IRpcProxyBuffer.Connect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(IRpcChannelBuffer* pRpcChannelBuffer)
    {
        return ((delegate* unmanaged<IRpcProxyBuffer*, IRpcChannelBuffer*, int> )(lpVtbl[3]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this), pRpcChannelBuffer);
    }

    /// <include file='IRpcProxyBuffer.xml' path='doc/member[@name="IRpcProxyBuffer.Disconnect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Disconnect()
    {
        ((delegate* unmanaged<IRpcProxyBuffer*, void> )(lpVtbl[4]))((IRpcProxyBuffer*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Connect(IRpcChannelBuffer* pRpcChannelBuffer);
        [VtblIndex(4)]
        void Disconnect();
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
        [NativeTypeName("HRESULT (IRpcChannelBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRpcChannelBuffer*, int> Connect;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Disconnect;
    }
}