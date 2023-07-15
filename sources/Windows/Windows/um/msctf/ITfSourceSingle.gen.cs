// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfSourceSingle.xml' path='doc/member[@name="ITfSourceSingle"]/*'/>
[Guid("73131F9C-56A9-49DD-B0EE-D046633F7528")]
[NativeTypeName("struct ITfSourceSingle : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSourceSingle : ITfSourceSingle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSourceSingle));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSourceSingle*, Guid*, void**, int> )(lpVtbl[0]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfSourceSingle*, uint> )(lpVtbl[1]))((ITfSourceSingle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSourceSingle*, uint> )(lpVtbl[2]))((ITfSourceSingle*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfSourceSingle.xml' path='doc/member[@name="ITfSourceSingle.AdviseSingleSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid, IUnknown* punk)
    {
        return ((delegate* unmanaged<ITfSourceSingle*, uint, Guid*, IUnknown*, int> )(lpVtbl[3]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), tid, riid, punk);
    }

    /// <include file='ITfSourceSingle.xml' path='doc/member[@name="ITfSourceSingle.UnadviseSingleSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid)
    {
        return ((delegate* unmanaged<ITfSourceSingle*, uint, Guid*, int> )(lpVtbl[4]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), tid, riid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid, IUnknown* punk);
        [VtblIndex(4)]
        HRESULT UnadviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid);
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
        [NativeTypeName("HRESULT (TfClientId, const IID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, IUnknown*, int> AdviseSingleSink;
        [NativeTypeName("HRESULT (TfClientId, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> UnadviseSingleSink;
    }
}