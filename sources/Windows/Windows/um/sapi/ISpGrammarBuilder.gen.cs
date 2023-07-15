// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder"]/*'/>
[Guid("8137828F-591A-4A42-BE58-49EA7EBAAC68")]
[NativeTypeName("struct ISpGrammarBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpGrammarBuilder : ISpGrammarBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpGrammarBuilder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, Guid*, void**, int> )(lpVtbl[0]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, uint> )(lpVtbl[1]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, uint> )(lpVtbl[2]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.ResetGrammar"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, ushort, int> )(lpVtbl[3]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), NewLanguage);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.GetRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, BOOL fCreateIfNotExist, SPSTATEHANDLE* phInitialState)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int> )(lpVtbl[4]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.ClearRule"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearRule(SPSTATEHANDLE hState)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, int> )(lpVtbl[5]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.CreateNewState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateNewState(SPSTATEHANDLE hState, SPSTATEHANDLE* phState)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE*, int> )(lpVtbl[6]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hState, phState);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.AddWordTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWordTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int> )(lpVtbl[7]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.AddRuleTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddRuleTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, SPSTATEHANDLE hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, SPPROPERTYINFO*, int> )(lpVtbl[8]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.AddResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddResource(SPSTATEHANDLE hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, SPSTATEHANDLE, ushort*, ushort*, int> )(lpVtbl[9]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
    }

    /// <include file='ISpGrammarBuilder.xml' path='doc/member[@name="ISpGrammarBuilder.Commit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder*, uint, int> )(lpVtbl[10]))((ISpGrammarBuilder*)Unsafe.AsPointer(ref this), dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage);
        [VtblIndex(4)]
        HRESULT GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, BOOL fCreateIfNotExist, SPSTATEHANDLE* phInitialState);
        [VtblIndex(5)]
        HRESULT ClearRule(SPSTATEHANDLE hState);
        [VtblIndex(6)]
        HRESULT CreateNewState(SPSTATEHANDLE hState, SPSTATEHANDLE* phState);
        [VtblIndex(7)]
        HRESULT AddWordTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo);
        [VtblIndex(8)]
        HRESULT AddRuleTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, SPSTATEHANDLE hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo);
        [VtblIndex(9)]
        HRESULT AddResource(SPSTATEHANDLE hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue);
        [VtblIndex(10)]
        HRESULT Commit([NativeTypeName("DWORD")] uint dwReserved);
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
        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> ResetGrammar;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, BOOL, SPSTATEHANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int> GetRule;
        [NativeTypeName("HRESULT (SPSTATEHANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, int> ClearRule;
        [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, SPSTATEHANDLE*, int> CreateNewState;
        [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, LPCWSTR, LPCWSTR, SPGRAMMARWORDTYPE, float, const SPPROPERTYINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int> AddWordTransition;
        [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, const SPPROPERTYINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, SPPROPERTYINFO*, int> AddRuleTransition;
        [NativeTypeName("HRESULT (SPSTATEHANDLE, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, ushort*, ushort*, int> AddResource;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Commit;
    }
}