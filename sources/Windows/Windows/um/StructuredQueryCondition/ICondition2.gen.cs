// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICondition2.xml' path='doc/member[@name="ICondition2"]/*'/>
[Guid("0DB8851D-2E5B-47EB-9208-D28C325A01D7")]
[NativeTypeName("struct ICondition2 : ICondition")]
[NativeInheritance("ICondition")]
public unsafe partial struct ICondition2 : ICondition2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICondition2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICondition2*, Guid*, void**, int> )(lpVtbl[0]))((ICondition2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICondition2*, uint> )(lpVtbl[1]))((ICondition2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICondition2*, uint> )(lpVtbl[2]))((ICondition2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<ICondition2*, Guid*, int> )(lpVtbl[3]))((ICondition2*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref = "IPersistStream.IsDirty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<ICondition2*, int> )(lpVtbl[4]))((ICondition2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersistStream.Load"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(IStream* pStm)
    {
        return ((delegate* unmanaged<ICondition2*, IStream*, int> )(lpVtbl[5]))((ICondition2*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <inheritdoc cref = "IPersistStream.Save"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save(IStream* pStm, BOOL fClearDirty)
    {
        return ((delegate* unmanaged<ICondition2*, IStream*, BOOL, int> )(lpVtbl[6]))((ICondition2*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
    }

    /// <inheritdoc cref = "IPersistStream.GetSizeMax"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSizeMax(ULARGE_INTEGER* pcbSize)
    {
        return ((delegate* unmanaged<ICondition2*, ULARGE_INTEGER*, int> )(lpVtbl[7]))((ICondition2*)Unsafe.AsPointer(ref this), pcbSize);
    }

    /// <inheritdoc cref = "ICondition.GetConditionType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConditionType(CONDITION_TYPE* pNodeType)
    {
        return ((delegate* unmanaged<ICondition2*, CONDITION_TYPE*, int> )(lpVtbl[8]))((ICondition2*)Unsafe.AsPointer(ref this), pNodeType);
    }

    /// <inheritdoc cref = "ICondition.GetSubConditions"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSubConditions([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ICondition2*, Guid*, void**, int> )(lpVtbl[9]))((ICondition2*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <inheritdoc cref = "ICondition.GetComparisonInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetComparisonInfo([NativeTypeName("LPWSTR *")] ushort** ppszPropertyName, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<ICondition2*, ushort**, CONDITION_OPERATION*, PROPVARIANT*, int> )(lpVtbl[10]))((ICondition2*)Unsafe.AsPointer(ref this), ppszPropertyName, pcop, ppropvar);
    }

    /// <inheritdoc cref = "ICondition.GetValueType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetValueType([NativeTypeName("LPWSTR *")] ushort** ppszValueTypeName)
    {
        return ((delegate* unmanaged<ICondition2*, ushort**, int> )(lpVtbl[11]))((ICondition2*)Unsafe.AsPointer(ref this), ppszValueTypeName);
    }

    /// <inheritdoc cref = "ICondition.GetValueNormalization"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetValueNormalization([NativeTypeName("LPWSTR *")] ushort** ppszNormalization)
    {
        return ((delegate* unmanaged<ICondition2*, ushort**, int> )(lpVtbl[12]))((ICondition2*)Unsafe.AsPointer(ref this), ppszNormalization);
    }

    /// <inheritdoc cref = "ICondition.GetInputTerms"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetInputTerms(IRichChunk** ppPropertyTerm, IRichChunk** ppOperationTerm, IRichChunk** ppValueTerm)
    {
        return ((delegate* unmanaged<ICondition2*, IRichChunk**, IRichChunk**, IRichChunk**, int> )(lpVtbl[13]))((ICondition2*)Unsafe.AsPointer(ref this), ppPropertyTerm, ppOperationTerm, ppValueTerm);
    }

    /// <inheritdoc cref = "ICondition.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Clone(ICondition** ppc)
    {
        return ((delegate* unmanaged<ICondition2*, ICondition**, int> )(lpVtbl[14]))((ICondition2*)Unsafe.AsPointer(ref this), ppc);
    }

    /// <include file='ICondition2.xml' path='doc/member[@name="ICondition2.GetLocale"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetLocale([NativeTypeName("LPWSTR *")] ushort** ppszLocaleName)
    {
        return ((delegate* unmanaged<ICondition2*, ushort**, int> )(lpVtbl[15]))((ICondition2*)Unsafe.AsPointer(ref this), ppszLocaleName);
    }

    /// <include file='ICondition2.xml' path='doc/member[@name="ICondition2.GetLeafConditionInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetLeafConditionInfo(PROPERTYKEY* ppropkey, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar)
    {
        return ((delegate* unmanaged<ICondition2*, PROPERTYKEY*, CONDITION_OPERATION*, PROPVARIANT*, int> )(lpVtbl[16]))((ICondition2*)Unsafe.AsPointer(ref this), ppropkey, pcop, ppropvar);
    }

    public interface Interface : ICondition.Interface
    {
        [VtblIndex(15)]
        HRESULT GetLocale([NativeTypeName("LPWSTR *")] ushort** ppszLocaleName);
        [VtblIndex(16)]
        HRESULT GetLeafConditionInfo(PROPERTYKEY* ppropkey, CONDITION_OPERATION* pcop, PROPVARIANT* ppropvar);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLocale;
        [NativeTypeName("HRESULT (PROPERTYKEY *, CONDITION_OPERATION *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, CONDITION_OPERATION*, PROPVARIANT*, int> GetLeafConditionInfo;
    }
}