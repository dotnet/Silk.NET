// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfCandidateList.xml' path='doc/member[@name="ITfCandidateList"]/*'/>
[Guid("A3AD50FB-9BDB-49E3-A843-6C76520FBF5D")]
[NativeTypeName("struct ITfCandidateList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCandidateList : ITfCandidateList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCandidateList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCandidateList*, Guid*, void**, int> )(lpVtbl[0]))((ITfCandidateList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfCandidateList*, uint> )(lpVtbl[1]))((ITfCandidateList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCandidateList*, uint> )(lpVtbl[2]))((ITfCandidateList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfCandidateList.xml' path='doc/member[@name="ITfCandidateList.EnumCandidates"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumCandidates(IEnumTfCandidates** ppEnum)
    {
        return ((delegate* unmanaged<ITfCandidateList*, IEnumTfCandidates**, int> )(lpVtbl[3]))((ITfCandidateList*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='ITfCandidateList.xml' path='doc/member[@name="ITfCandidateList.GetCandidate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCandidate([NativeTypeName("ULONG")] uint nIndex, ITfCandidateString** ppCand)
    {
        return ((delegate* unmanaged<ITfCandidateList*, uint, ITfCandidateString**, int> )(lpVtbl[4]))((ITfCandidateList*)Unsafe.AsPointer(ref this), nIndex, ppCand);
    }

    /// <include file='ITfCandidateList.xml' path='doc/member[@name="ITfCandidateList.GetCandidateNum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCandidateNum([NativeTypeName("ULONG *")] uint* pnCnt)
    {
        return ((delegate* unmanaged<ITfCandidateList*, uint*, int> )(lpVtbl[5]))((ITfCandidateList*)Unsafe.AsPointer(ref this), pnCnt);
    }

    /// <include file='ITfCandidateList.xml' path='doc/member[@name="ITfCandidateList.SetResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetResult([NativeTypeName("ULONG")] uint nIndex, TfCandidateResult imcr)
    {
        return ((delegate* unmanaged<ITfCandidateList*, uint, TfCandidateResult, int> )(lpVtbl[6]))((ITfCandidateList*)Unsafe.AsPointer(ref this), nIndex, imcr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumCandidates(IEnumTfCandidates** ppEnum);
        [VtblIndex(4)]
        HRESULT GetCandidate([NativeTypeName("ULONG")] uint nIndex, ITfCandidateString** ppCand);
        [VtblIndex(5)]
        HRESULT GetCandidateNum([NativeTypeName("ULONG *")] uint* pnCnt);
        [VtblIndex(6)]
        HRESULT SetResult([NativeTypeName("ULONG")] uint nIndex, TfCandidateResult imcr);
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
        [NativeTypeName("HRESULT (IEnumTfCandidates **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumTfCandidates**, int> EnumCandidates;
        [NativeTypeName("HRESULT (ULONG, ITfCandidateString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfCandidateString**, int> GetCandidate;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCandidateNum;
        [NativeTypeName("HRESULT (ULONG, TfCandidateResult) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, TfCandidateResult, int> SetResult;
    }
}