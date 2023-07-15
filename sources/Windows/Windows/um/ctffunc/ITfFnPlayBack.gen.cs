// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfFnPlayBack.xml' path='doc/member[@name="ITfFnPlayBack"]/*'/>
[Guid("A3A416A4-0F64-11D3-B5B7-00C04FC324A1")]
[NativeTypeName("struct ITfFnPlayBack : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnPlayBack : ITfFnPlayBack.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnPlayBack));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnPlayBack*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnPlayBack*, uint> )(lpVtbl[1]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnPlayBack*, uint> )(lpVtbl[2]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnPlayBack*, ushort**, int> )(lpVtbl[3]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnPlayBack.xml' path='doc/member[@name="ITfFnPlayBack.QueryRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryRange(ITfRange* pRange, ITfRange** ppNewRange, BOOL* pfPlayable)
    {
        return ((delegate* unmanaged<ITfFnPlayBack*, ITfRange*, ITfRange**, BOOL*, int> )(lpVtbl[4]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfPlayable);
    }

    /// <include file='ITfFnPlayBack.xml' path='doc/member[@name="ITfFnPlayBack.Play"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Play(ITfRange* pRange)
    {
        return ((delegate* unmanaged<ITfFnPlayBack*, ITfRange*, int> )(lpVtbl[5]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), pRange);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT QueryRange(ITfRange* pRange, ITfRange** ppNewRange, BOOL* pfPlayable);
        [VtblIndex(5)]
        HRESULT Play(ITfRange* pRange);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (ITfRange *, ITfRange **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, ITfRange**, BOOL*, int> QueryRange;
        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, int> Play;
    }
}