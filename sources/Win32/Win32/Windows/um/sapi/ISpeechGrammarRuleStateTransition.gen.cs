// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CAFD1DB1-41D1-4A06-9863-E2E81DA17A9A")]
[NativeTypeName("struct ISpeechGrammarRuleStateTransition : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechGrammarRuleStateTransition
    : ISpeechGrammarRuleStateTransition.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechGrammarRuleStateTransition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
        )(this, iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechGrammarRuleStateTransition,
                Guid*,
                ushort**,
                uint,
                uint,
                int*,
                int>)((*lpVtbl)[5])
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechGrammarRuleStateTransition,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Type(SpeechGrammarRuleStateTransitionType* Type)
    {
        return (
            (delegate* unmanaged<
                ISpeechGrammarRuleStateTransition,
                SpeechGrammarRuleStateTransitionType*,
                int>)((*lpVtbl)[7])
        )(this, Type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Text([NativeTypeName("BSTR *")] ushort** Text)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, ushort**, int>)((*lpVtbl)[8])
        )(this, Text);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Rule(ISpeechGrammarRule* Rule)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, ISpeechGrammarRule*, int>)(
                (*lpVtbl)[9]
            )
        )(this, Rule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Weight(VARIANT* Weight)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, VARIANT*, int>)((*lpVtbl)[10])
        )(this, Weight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, ushort**, int>)((*lpVtbl)[11])
        )(this, PropertyName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_PropertyId([NativeTypeName("long *")] int* PropertyId)
    {
        return ((delegate* unmanaged<ISpeechGrammarRuleStateTransition, int*, int>)((*lpVtbl)[12]))(
            this,
            PropertyId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_PropertyValue(VARIANT* PropertyValue)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, VARIANT*, int>)((*lpVtbl)[13])
        )(this, PropertyValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_NextState(ISpeechGrammarRuleState* NextState)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRuleStateTransition, ISpeechGrammarRuleState*, int>)(
                (*lpVtbl)[14]
            )
        )(this, NextState);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Type(SpeechGrammarRuleStateTransitionType* Type);

        [VtblIndex(8)]
        HRESULT get_Text([NativeTypeName("BSTR *")] ushort** Text);

        [VtblIndex(9)]
        HRESULT get_Rule(ISpeechGrammarRule* Rule);

        [VtblIndex(10)]
        HRESULT get_Weight(VARIANT* Weight);

        [VtblIndex(11)]
        HRESULT get_PropertyName([NativeTypeName("BSTR *")] ushort** PropertyName);

        [VtblIndex(12)]
        HRESULT get_PropertyId([NativeTypeName("long *")] int* PropertyId);

        [VtblIndex(13)]
        HRESULT get_PropertyValue(VARIANT* PropertyValue);

        [VtblIndex(14)]
        HRESULT get_NextState(ISpeechGrammarRuleState* NextState);
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
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName(
            "HRESULT (SpeechGrammarRuleStateTransitionType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SpeechGrammarRuleStateTransitionType*, int> get_Type;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Text;

        [NativeTypeName("HRESULT (ISpeechGrammarRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRule*, int> get_Rule;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Weight;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_PropertyName;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PropertyId;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_PropertyValue;

        [NativeTypeName("HRESULT (ISpeechGrammarRuleState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRuleState*, int> get_NextState;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechGrammarRuleStateTransition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechGrammarRuleStateTransition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechGrammarRuleStateTransition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechGrammarRuleStateTransition(
        Silk.NET.Windows.IDispatch value
    )
    {
        return new ISpeechGrammarRuleStateTransition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechGrammarRuleStateTransition"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechGrammarRuleStateTransition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(
        ISpeechGrammarRuleStateTransition value
    )
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechGrammarRuleStateTransition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechGrammarRuleStateTransition(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpeechGrammarRuleStateTransition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechGrammarRuleStateTransition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechGrammarRuleStateTransition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpeechGrammarRuleStateTransition value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
