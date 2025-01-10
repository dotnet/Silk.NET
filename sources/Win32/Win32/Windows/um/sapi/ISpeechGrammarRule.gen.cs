// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AFE719CF-5DD1-44F2-999C-7A399F1CFCCC")]
[NativeTypeName("struct ISpeechGrammarRule : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechGrammarRule : ISpeechGrammarRule.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechGrammarRule));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRule, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISpeechGrammarRule, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
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
                ISpeechGrammarRule,
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
    public HRESULT get_Attributes(SpeechRuleAttributes* Attributes)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRule, SpeechRuleAttributes*, int>)((*lpVtbl)[7])
        )(this, Attributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialState(ISpeechGrammarRuleState* State)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRule, ISpeechGrammarRuleState*, int>)((*lpVtbl)[8])
        )(this, State);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name)
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, ushort**, int>)((*lpVtbl)[9]))(this, Name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Id([NativeTypeName("long *")] int* Id)
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, int*, int>)((*lpVtbl)[10]))(this, Id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddResource(
        [NativeTypeName("const BSTR")] ushort* ResourceName,
        [NativeTypeName("const BSTR")] ushort* ResourceValue
    )
    {
        return ((delegate* unmanaged<ISpeechGrammarRule, ushort*, ushort*, int>)((*lpVtbl)[12]))(
            this,
            ResourceName,
            ResourceValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT AddState(ISpeechGrammarRuleState* State)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRule, ISpeechGrammarRuleState*, int>)((*lpVtbl)[13])
        )(this, State);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Attributes(SpeechRuleAttributes* Attributes);

        [VtblIndex(8)]
        HRESULT get_InitialState(ISpeechGrammarRuleState* State);

        [VtblIndex(9)]
        HRESULT get_Name([NativeTypeName("BSTR *")] ushort** Name);

        [VtblIndex(10)]
        HRESULT get_Id([NativeTypeName("long *")] int* Id);

        [VtblIndex(11)]
        HRESULT Clear();

        [VtblIndex(12)]
        HRESULT AddResource(
            [NativeTypeName("const BSTR")] ushort* ResourceName,
            [NativeTypeName("const BSTR")] ushort* ResourceValue
        );

        [VtblIndex(13)]
        HRESULT AddState(ISpeechGrammarRuleState* State);
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

        [NativeTypeName("HRESULT (SpeechRuleAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechRuleAttributes*, int> get_Attributes;

        [NativeTypeName("HRESULT (ISpeechGrammarRuleState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRuleState*, int> get_InitialState;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Id;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;

        [NativeTypeName("HRESULT (const BSTR, const BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> AddResource;

        [NativeTypeName("HRESULT (ISpeechGrammarRuleState **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRuleState*, int> AddState;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechGrammarRule"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechGrammarRule(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechGrammarRule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechGrammarRule(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechGrammarRule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechGrammarRule"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechGrammarRule"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechGrammarRule value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechGrammarRule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechGrammarRule(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechGrammarRule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechGrammarRule"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechGrammarRule"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechGrammarRule value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
