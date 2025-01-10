// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6FFA3B44-FC2D-40D1-8AFC-32911C7F1AD1")]
[NativeTypeName("struct ISpeechGrammarRules : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechGrammarRules : ISpeechGrammarRules.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechGrammarRules));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechGrammarRules, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRules, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISpeechGrammarRules, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISpeechGrammarRules,
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
    public HRESULT get_Count([NativeTypeName("long *")] int* Count)
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, int*, int>)((*lpVtbl)[7]))(this, Count);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindRule(VARIANT RuleNameOrId, ISpeechGrammarRule* Rule)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRules, VARIANT, ISpeechGrammarRule*, int>)(
                (*lpVtbl)[8]
            )
        )(this, RuleNameOrId, Rule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Item([NativeTypeName("long")] int Index, ISpeechGrammarRule* Rule)
    {
        return (
            (delegate* unmanaged<ISpeechGrammarRules, int, ISpeechGrammarRule*, int>)((*lpVtbl)[9])
        )(this, Index, Rule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get__NewEnum(IUnknown* EnumVARIANT)
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, IUnknown*, int>)((*lpVtbl)[10]))(
            this,
            EnumVARIANT
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Dynamic([NativeTypeName("VARIANT_BOOL *")] short* Dynamic)
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, short*, int>)((*lpVtbl)[11]))(
            this,
            Dynamic
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Add(
        [NativeTypeName("BSTR")] ushort* RuleName,
        SpeechRuleAttributes Attributes,
        [NativeTypeName("long")] int RuleId,
        ISpeechGrammarRule* Rule
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechGrammarRules,
                ushort*,
                SpeechRuleAttributes,
                int,
                ISpeechGrammarRule*,
                int>)((*lpVtbl)[12])
        )(this, RuleName, Attributes, RuleId, Rule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, int>)((*lpVtbl)[13]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CommitAndSave([NativeTypeName("BSTR *")] ushort** ErrorText, VARIANT* SaveStream)
    {
        return ((delegate* unmanaged<ISpeechGrammarRules, ushort**, VARIANT*, int>)((*lpVtbl)[14]))(
            this,
            ErrorText,
            SaveStream
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Count([NativeTypeName("long *")] int* Count);

        [VtblIndex(8)]
        HRESULT FindRule(VARIANT RuleNameOrId, ISpeechGrammarRule* Rule);

        [VtblIndex(9)]
        HRESULT Item([NativeTypeName("long")] int Index, ISpeechGrammarRule* Rule);

        [VtblIndex(10)]
        HRESULT get__NewEnum(IUnknown* EnumVARIANT);

        [VtblIndex(11)]
        HRESULT get_Dynamic([NativeTypeName("VARIANT_BOOL *")] short* Dynamic);

        [VtblIndex(12)]
        HRESULT Add(
            [NativeTypeName("BSTR")] ushort* RuleName,
            SpeechRuleAttributes Attributes,
            [NativeTypeName("long")] int RuleId,
            ISpeechGrammarRule* Rule
        );

        [VtblIndex(13)]
        HRESULT Commit();

        [VtblIndex(14)]
        HRESULT CommitAndSave([NativeTypeName("BSTR *")] ushort** ErrorText, VARIANT* SaveStream);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (VARIANT, ISpeechGrammarRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, ISpeechGrammarRule*, int> FindRule;

        [NativeTypeName("HRESULT (long, ISpeechGrammarRule **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ISpeechGrammarRule*, int> Item;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> get__NewEnum;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_Dynamic;

        [NativeTypeName(
            "HRESULT (BSTR, SpeechRuleAttributes, long, ISpeechGrammarRule **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            SpeechRuleAttributes,
            int,
            ISpeechGrammarRule*,
            int> Add;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;

        [NativeTypeName("HRESULT (BSTR *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, VARIANT*, int> CommitAndSave;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechGrammarRules"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechGrammarRules(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechGrammarRules"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechGrammarRules(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechGrammarRules(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechGrammarRules"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechGrammarRules"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechGrammarRules value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechGrammarRules"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechGrammarRules(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechGrammarRules(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechGrammarRules"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechGrammarRules"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechGrammarRules value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
