// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransitions"]/*'/>
[Guid("EABCE657-75BC-44A2-AA7F-C56476742963")]
[NativeTypeName("struct ISpeechGrammarRuleStateTransitions : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechGrammarRuleStateTransitions : ISpeechGrammarRuleStateTransitions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechGrammarRuleStateTransitions));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint> )(lpVtbl[1]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint> )(lpVtbl[2]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint*, int> )(lpVtbl[3]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransitions.get_Count"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Count([NativeTypeName("long *")] int* Count)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, int*, int> )(lpVtbl[7]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), Count);
    }

    /// <include file='ISpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransitions.Item"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Item([NativeTypeName("long")] int Index, ISpeechGrammarRuleStateTransition** Transition)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, int, ISpeechGrammarRuleStateTransition**, int> )(lpVtbl[8]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), Index, Transition);
    }

    /// <include file='ISpeechGrammarRuleStateTransitions.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransitions.get__NewEnum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get__NewEnum(IUnknown** EnumVARIANT)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransitions*, IUnknown**, int> )(lpVtbl[9]))((ISpeechGrammarRuleStateTransitions*)Unsafe.AsPointer(ref this), EnumVARIANT);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Count([NativeTypeName("long *")] int* Count);
        [VtblIndex(8)]
        HRESULT Item([NativeTypeName("long")] int Index, ISpeechGrammarRuleStateTransition** Transition);
        [VtblIndex(9)]
        HRESULT get__NewEnum(IUnknown** EnumVARIANT);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;
        [NativeTypeName("HRESULT (long, ISpeechGrammarRuleStateTransition **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISpeechGrammarRuleStateTransition**, int> Item;
        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__NewEnum;
    }
}