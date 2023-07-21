// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfFnSearchCandidateProvider.xml' path='doc/member[@name="ITfFnSearchCandidateProvider"]/*' />
[Guid("87A2AD8F-F27B-4920-8501-67602280175D")]
[NativeTypeName("struct ITfFnSearchCandidateProvider : ITfFunction")]
[NativeInheritance("ITfFunction")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITfFnSearchCandidateProvider : ITfFnSearchCandidateProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnSearchCandidateProvider));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, uint>)(lpVtbl[1]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, uint>)(lpVtbl[2]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfFunction.GetDisplayName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, ushort**, int>)(lpVtbl[3]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnSearchCandidateProvider.xml' path='doc/member[@name="ITfFnSearchCandidateProvider.GetSearchCandidates"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSearchCandidates([NativeTypeName("BSTR")] ushort* bstrQuery, [NativeTypeName("BSTR")] ushort* bstrApplicationId, ITfCandidateList** pplist)
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, ushort*, ushort*, ITfCandidateList**, int>)(lpVtbl[4]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), bstrQuery, bstrApplicationId, pplist);
    }

    /// <include file='ITfFnSearchCandidateProvider.xml' path='doc/member[@name="ITfFnSearchCandidateProvider.SetResult"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetResult([NativeTypeName("BSTR")] ushort* bstrQuery, [NativeTypeName("BSTR")] ushort* bstrApplicationID, [NativeTypeName("BSTR")] ushort* bstrResult)
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider*, ushort*, ushort*, ushort*, int>)(lpVtbl[5]))((ITfFnSearchCandidateProvider*)Unsafe.AsPointer(ref this), bstrQuery, bstrApplicationID, bstrResult);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetSearchCandidates([NativeTypeName("BSTR")] ushort* bstrQuery, [NativeTypeName("BSTR")] ushort* bstrApplicationId, ITfCandidateList** pplist);

        [VtblIndex(5)]
        HRESULT SetResult([NativeTypeName("BSTR")] ushort* bstrQuery, [NativeTypeName("BSTR")] ushort* bstrApplicationID, [NativeTypeName("BSTR")] ushort* bstrResult);
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

        [NativeTypeName("HRESULT (BSTR, BSTR, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ITfCandidateList**, int> GetSearchCandidates;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> SetResult;
    }
}
