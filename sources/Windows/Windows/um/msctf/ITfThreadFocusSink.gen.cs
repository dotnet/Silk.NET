// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfThreadFocusSink.xml' path='doc/member[@name="ITfThreadFocusSink"]/*'/>
[Guid("C0F1DB0C-3A20-405C-A303-96B6010A885F")]
[NativeTypeName("struct ITfThreadFocusSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfThreadFocusSink : ITfThreadFocusSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfThreadFocusSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfThreadFocusSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfThreadFocusSink*, uint> )(lpVtbl[1]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfThreadFocusSink*, uint> )(lpVtbl[2]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfThreadFocusSink.xml' path='doc/member[@name="ITfThreadFocusSink.OnSetThreadFocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSetThreadFocus()
    {
        return ((delegate* unmanaged<ITfThreadFocusSink*, int> )(lpVtbl[3]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfThreadFocusSink.xml' path='doc/member[@name="ITfThreadFocusSink.OnKillThreadFocus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnKillThreadFocus()
    {
        return ((delegate* unmanaged<ITfThreadFocusSink*, int> )(lpVtbl[4]))((ITfThreadFocusSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnSetThreadFocus();
        [VtblIndex(4)]
        HRESULT OnKillThreadFocus();
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
        public delegate* unmanaged<TSelf*, int> OnSetThreadFocus;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnKillThreadFocus;
    }
}