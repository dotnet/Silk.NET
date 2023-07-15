// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IRpcSyntaxNegotiate.xml' path='doc/member[@name="IRpcSyntaxNegotiate"]/*'/>
[Guid("58A08519-24C8-4935-B482-3FD823333A4F")]
[NativeTypeName("struct IRpcSyntaxNegotiate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcSyntaxNegotiate : IRpcSyntaxNegotiate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcSyntaxNegotiate));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcSyntaxNegotiate*, Guid*, void**, int> )(lpVtbl[0]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRpcSyntaxNegotiate*, uint> )(lpVtbl[1]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcSyntaxNegotiate*, uint> )(lpVtbl[2]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRpcSyntaxNegotiate.xml' path='doc/member[@name="IRpcSyntaxNegotiate.NegotiateSyntax"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NegotiateSyntax(RPCOLEMESSAGE* pMsg)
    {
        return ((delegate* unmanaged<IRpcSyntaxNegotiate*, RPCOLEMESSAGE*, int> )(lpVtbl[3]))((IRpcSyntaxNegotiate*)Unsafe.AsPointer(ref this), pMsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT NegotiateSyntax(RPCOLEMESSAGE* pMsg);
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
        [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, int> NegotiateSyntax;
    }
}