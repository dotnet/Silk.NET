// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfFnLMInternal.xml' path='doc/member[@name="ITfFnLMInternal"]/*'/>
[Guid("04B825B1-AC9A-4F7B-B5AD-C7168F1EE445")]
[NativeTypeName("struct ITfFnLMInternal : ITfFnLMProcessor")]
[NativeInheritance("ITfFnLMProcessor")]
public unsafe partial struct ITfFnLMInternal : ITfFnLMInternal.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnLMInternal));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, uint> )(lpVtbl[1]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, uint> )(lpVtbl[2]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ushort**, int> )(lpVtbl[3]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.QueryRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryRange(ITfRange* pRange, ITfRange** ppNewRange, BOOL* pfAccepted)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, ITfRange**, BOOL*, int> )(lpVtbl[4]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfAccepted);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.QueryLangID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryLangID([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccepted)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ushort, BOOL*, int> )(lpVtbl[5]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), langid, pfAccepted);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.GetReconversion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetReconversion(ITfRange* pRange, ITfCandidateList** ppCandList)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, ITfCandidateList**, int> )(lpVtbl[6]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange, ppCandList);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.Reconvert"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reconvert(ITfRange* pRange)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, int> )(lpVtbl[7]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.QueryKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeydata, BOOL* pfInterested)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, BOOL, WPARAM, LPARAM, BOOL*, int> )(lpVtbl[8]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeydata, pfInterested);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.InvokeKey"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvokeKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeyData)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, BOOL, WPARAM, LPARAM, int> )(lpVtbl[9]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), fUp, vKey, lparamKeyData);
    }

    /// <inheritdoc cref = "ITfFnLMProcessor.InvokeFunc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InvokeFunc(ITfContext* pic, [NativeTypeName("const GUID &")] Guid* refguidFunc)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ITfContext*, Guid*, int> )(lpVtbl[10]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pic, refguidFunc);
    }

    /// <include file='ITfFnLMInternal.xml' path='doc/member[@name="ITfFnLMInternal.ProcessLattice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProcessLattice(ITfRange* pRange)
    {
        return ((delegate* unmanaged<ITfFnLMInternal*, ITfRange*, int> )(lpVtbl[11]))((ITfFnLMInternal*)Unsafe.AsPointer(ref this), pRange);
    }

    public interface Interface : ITfFnLMProcessor.Interface
    {
        [VtblIndex(11)]
        HRESULT ProcessLattice(ITfRange* pRange);
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
        [NativeTypeName("HRESULT (LANGID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, BOOL*, int> QueryLangID;
        [NativeTypeName("HRESULT (ITfRange *, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, ITfCandidateList**, int> GetReconversion;
        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, int> Reconvert;
        [NativeTypeName("HRESULT (BOOL, WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, WPARAM, LPARAM, BOOL*, int> QueryKey;
        [NativeTypeName("HRESULT (BOOL, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, WPARAM, LPARAM, int> InvokeKey;
        [NativeTypeName("HRESULT (ITfContext *, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext*, Guid*, int> InvokeFunc;
        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, int> ProcessLattice;
    }
}