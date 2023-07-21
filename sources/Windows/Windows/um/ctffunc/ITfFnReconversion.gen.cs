// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfFnReconversion.xml' path='doc/member[@name="ITfFnReconversion"]/*' />
[Guid("4CEA93C0-0A58-11D3-8DF0-00105A2799B5")]
[NativeTypeName("struct ITfFnReconversion : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnReconversion : ITfFnReconversion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnReconversion));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnReconversion*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnReconversion*, uint>)(lpVtbl[1]))((ITfFnReconversion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnReconversion*, uint>)(lpVtbl[2]))((ITfFnReconversion*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfFunction.GetDisplayName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnReconversion*, ushort**, int>)(lpVtbl[3]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnReconversion.xml' path='doc/member[@name="ITfFnReconversion.QueryRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryRange(ITfRange* pRange, ITfRange** ppNewRange, BOOL* pfConvertable)
    {
        return ((delegate* unmanaged<ITfFnReconversion*, ITfRange*, ITfRange**, BOOL*, int>)(lpVtbl[4]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfConvertable);
    }

    /// <include file='ITfFnReconversion.xml' path='doc/member[@name="ITfFnReconversion.GetReconversion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList)
    {
        return ((delegate* unmanaged<ITfFnReconversion*, ITfRange*, ITfCandidateList**, int>)(lpVtbl[5]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pRange, ppCandList);
    }

    /// <include file='ITfFnReconversion.xml' path='doc/member[@name="ITfFnReconversion.Reconvert"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Reconvert(ITfRange* pRange)
    {
        return ((delegate* unmanaged<ITfFnReconversion*, ITfRange*, int>)(lpVtbl[6]))((ITfFnReconversion*)Unsafe.AsPointer(ref this), pRange);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT QueryRange(ITfRange* pRange, ITfRange** ppNewRange, BOOL* pfConvertable);

        [VtblIndex(5)]
        HRESULT GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList);

        [VtblIndex(6)]
        HRESULT Reconvert(ITfRange* pRange);
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

        [NativeTypeName("HRESULT (ITfRange *, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, ITfCandidateList**, int> GetReconversion;

        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, int> Reconvert;
    }
}
