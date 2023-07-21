// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition"]/*' />
[Guid("CAFD1DB1-41D1-4A06-9863-E2E81DA17A9A")]
[NativeTypeName("struct ISpeechGrammarRuleStateTransition : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechGrammarRuleStateTransition : ISpeechGrammarRuleStateTransition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechGrammarRuleStateTransition));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[1]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint>)(lpVtbl[2]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint*, int>)(lpVtbl[3]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_Type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Type(SpeechGrammarRuleStateTransitionType* Type)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, SpeechGrammarRuleStateTransitionType*, int>)(lpVtbl[7]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Type);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_Text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Text([NativeTypeName("BSTR *")] ushort** Text)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[8]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Text);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_Rule"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Rule(ISpeechGrammarRule** Rule)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRule**, int>)(lpVtbl[9]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Rule);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_Weight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Weight(VARIANT* Weight)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[10]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), Weight);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_PropertyName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ushort**, int>)(lpVtbl[11]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyName);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_PropertyId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PropertyId([NativeTypeName("long *")] int* PropertyId)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, int*, int>)(lpVtbl[12]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyId);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_PropertyValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PropertyValue(VARIANT* PropertyValue)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, VARIANT*, int>)(lpVtbl[13]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), PropertyValue);
    }

    /// <include file='ISpeechGrammarRuleStateTransition.xml' path='doc/member[@name="ISpeechGrammarRuleStateTransition.get_NextState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_NextState(ISpeechGrammarRuleState** NextState)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition*, ISpeechGrammarRuleState**, int>)(lpVtbl[14]))((ISpeechGrammarRuleStateTransition*)Unsafe.AsPointer(ref this), NextState);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Type(SpeechGrammarRuleStateTransitionType* Type);

        [VtblIndex(8)]
        HRESULT get_Text([NativeTypeName("BSTR *")] ushort** Text);

        [VtblIndex(9)]
        HRESULT get_Rule(ISpeechGrammarRule** Rule);

        [VtblIndex(10)]
        HRESULT get_Weight(VARIANT* Weight);

        [VtblIndex(11)]
        HRESULT get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName);

        [VtblIndex(12)]
        HRESULT get_PropertyId([NativeTypeName("long *")] int* PropertyId);

        [VtblIndex(13)]
        HRESULT get_PropertyValue(VARIANT* PropertyValue);

        [VtblIndex(14)]
        HRESULT get_NextState(ISpeechGrammarRuleState** NextState);
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

        [NativeTypeName("HRESULT (SpeechGrammarRuleStateTransitionType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechGrammarRuleStateTransitionType*, int> get_Type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Text;

        [NativeTypeName("HRESULT (ISpeechGrammarRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRule**, int> get_Rule;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Weight;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_PropertyName;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PropertyId;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_PropertyValue;

        [NativeTypeName("HRESULT (ISpeechGrammarRuleState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRuleState**, int> get_NextState;
    }
}
