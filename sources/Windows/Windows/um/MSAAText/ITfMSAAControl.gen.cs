// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfMSAAControl.xml' path='doc/member[@name="ITfMSAAControl"]/*'/>
[Guid("B5F8FB3B-393F-4F7C-84CB-504924C2705A")]
[NativeTypeName("struct ITfMSAAControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMSAAControl : ITfMSAAControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMSAAControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMSAAControl*, Guid*, void**, int> )(lpVtbl[0]))((ITfMSAAControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfMSAAControl*, uint> )(lpVtbl[1]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMSAAControl*, uint> )(lpVtbl[2]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfMSAAControl.xml' path='doc/member[@name="ITfMSAAControl.SystemEnableMSAA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SystemEnableMSAA()
    {
        return ((delegate* unmanaged<ITfMSAAControl*, int> )(lpVtbl[3]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfMSAAControl.xml' path='doc/member[@name="ITfMSAAControl.SystemDisableMSAA"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SystemDisableMSAA()
    {
        return ((delegate* unmanaged<ITfMSAAControl*, int> )(lpVtbl[4]))((ITfMSAAControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SystemEnableMSAA();
        [VtblIndex(4)]
        HRESULT SystemDisableMSAA();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SystemEnableMSAA;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SystemDisableMSAA;
    }
}