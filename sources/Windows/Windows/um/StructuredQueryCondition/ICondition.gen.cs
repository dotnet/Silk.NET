// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICondition.xml' path='doc/member[@name="ICondition"]/*'/>
[Guid("0FC988D4-C935-4B97-A973-46282EA175C8")]
[NativeTypeName("struct ICondition : IPersistStream")]
[NativeInheritance("IPersistStream")]
public unsafe partial struct ICondition : ICondition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICondition));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICondition*, Guid*, void**, int> )(lpVtbl[0]))((ICondition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICondition*, uint> )(lpVtbl[1]))((ICondition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICondition*, uint> )(lpVtbl[2]))((ICondition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<ICondition*, Guid*, int> )(lpVtbl[3]))((ICondition*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref = "IPersistStream.IsDirty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<ICondition*, int> )(lpVtbl[4]))((ICondition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersistStream.Load"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream* pStm)
    {
        return ((delegate* unmanaged<ICondition*, IStream*, int> )(lpVtbl[5]))((ICondition*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <inheritdoc cref = "IPersistStream.Save"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream* pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<ICondition*, IStream*, BOOL, int> )(lpVtbl[6]))((ICondition*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <inheritdoc cref = "IPersistStream.GetSizeMax"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<ICondition*, ULARGE_INTEGER*, int> )(lpVtbl[7]))((ICondition*)Unsafe.AsPointer(ref this), pcbSize);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.GetConditionType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConditionType(CONDITION_TYPE* pNodeType)
    {
        return ((delegate* unmanaged<ICondition*, CONDITION_TYPE*, int> )(lpVtbl[8]))((ICondition*)Unsafe.AsPointer(ref this), pNodeType);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.GetSubConditions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ICondition*, Guid*, void**, int> )(lpVtbl[9]))((ICondition*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.GetComparisonInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetComparisonInfo([NativeTypeName("LPWSTR *")] ushort** ppszPropertyName, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<ICondition*, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int> )(lpVtbl[10]))((ICondition*)Unsafe.AsPointer(ref this), ppszPropertyName, pcop, ppropvar);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.GetValueType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName)
    {
        return ((delegate* unmanaged<ICondition*, ushort**, int> )(lpVtbl[11]))((ICondition*)Unsafe.AsPointer(ref this), ppszValueTypeName);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.GetValueNormalization"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization)
    {
        return ((delegate* unmanaged<ICondition*, ushort**, int> )(lpVtbl[12]))((ICondition*)Unsafe.AsPointer(ref this), ppszNormalization);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.GetInputTerms"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInputTerms(IRichChunk** ppPropertyTerm, IRichChunk** ppOperationTerm, IRichChunk** ppValueTerm)
    {
        return ((delegate* unmanaged<ICondition*, IRichChunk**, IRichChunk**, IRichChunk**, int> )(lpVtbl[13]))((ICondition*)Unsafe.AsPointer(ref this), ppPropertyTerm, ppOperationTerm, ppValueTerm);
    }

    /// <include file='ICondition.xml' path='doc/member[@name="ICondition.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Clone(ICondition** ppc)
    {
        return ((delegate* unmanaged<ICondition*, ICondition**, int> )(lpVtbl[14]))((ICondition*)Unsafe.AsPointer(ref this), ppc);
    }

    public interface Interface : IPersistStream.Interface
    {
        [VtblIndex(8)]
        HRESULT GetConditionType(CONDITION_TYPE* pNodeType);
        [VtblIndex(9)]
        HRESULT GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(10)]
        HRESULT GetComparisonInfo([NativeTypeName("LPWSTR *")] ushort** ppszPropertyName, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar);
        [VtblIndex(11)]
        HRESULT GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName);
        [VtblIndex(12)]
        HRESULT GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization);
        [VtblIndex(13)]
        HRESULT GetInputTerms(IRichChunk** ppPropertyTerm, IRichChunk** ppOperationTerm, IRichChunk** ppValueTerm);
        [VtblIndex(14)]
        HRESULT Clone(ICondition** ppc);
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
        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> Load;
        [NativeTypeName("HRESULT (IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, BOOL, int> Save;
        [NativeTypeName("HRESULT (ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER*, int> GetSizeMax;
        [NativeTypeName("HRESULT (CONDITION_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CONDITION_TYPE*, int> GetConditionType;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetSubConditions;
        [NativeTypeName("HRESULT (LPWSTR *, CONDITION_OPERATION *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int> GetComparisonInfo;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetValueType;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetValueNormalization;
        [NativeTypeName("HRESULT (IRichChunk **, IRichChunk **, IRichChunk **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRichChunk**, IRichChunk**, IRichChunk**, int> GetInputTerms;
        [NativeTypeName("HRESULT (ICondition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICondition**, int> Clone;
    }
}