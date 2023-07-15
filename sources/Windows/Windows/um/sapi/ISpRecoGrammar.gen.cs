// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar"]/*'/>
[Guid("2177DB29-7F45-47D0-8554-067E91C80502")]
[NativeTypeName("struct ISpRecoGrammar : ISpGrammarBuilder")]
[NativeInheritance("ISpGrammarBuilder")]
public unsafe partial struct ISpRecoGrammar : ISpRecoGrammar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoGrammar));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, Guid*, void**, int> )(lpVtbl[0]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, uint> )(lpVtbl[1]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, uint> )(lpVtbl[2]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.ResetGrammar"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort, int> )(lpVtbl[3]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), NewLanguage);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.GetRule"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRule([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("DWORD")] uint dwRuleId, [NativeTypeName("DWORD")] uint dwAttributes, BOOL fCreateIfNotExist, SPSTATEHANDLE* phInitialState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int> )(lpVtbl[4]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.ClearRule"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearRule(SPSTATEHANDLE hState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPSTATEHANDLE, int> )(lpVtbl[5]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hState);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.CreateNewState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateNewState(SPSTATEHANDLE hState, SPSTATEHANDLE* phState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPSTATEHANDLE, SPSTATEHANDLE*, int> )(lpVtbl[6]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hState, phState);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.AddWordTransition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWordTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, [NativeTypeName("LPCWSTR")] ushort* psz, [NativeTypeName("LPCWSTR")] ushort* pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, ushort*, SPGRAMMARWORDTYPE, float, SPPROPERTYINFO*, int> )(lpVtbl[7]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.AddRuleTransition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddRuleTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, SPSTATEHANDLE hRule, float Weight, [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, SPPROPERTYINFO*, int> )(lpVtbl[8]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hFromState, hToState, hRule, Weight, pPropInfo);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.AddResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddResource(SPSTATEHANDLE hRuleState, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceValue)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPSTATEHANDLE, ushort*, ushort*, int> )(lpVtbl[9]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hRuleState, pszResourceName, pszResourceValue);
    }

    /// <inheritdoc cref = "ISpGrammarBuilder.Commit"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, uint, int> )(lpVtbl[10]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), dwReserved);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.GetGrammarId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGrammarId([NativeTypeName("ULONGLONG *")] ulong* pullGrammarId)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ulong*, int> )(lpVtbl[11]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pullGrammarId);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.GetRecoContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetRecoContext(ISpRecoContext** ppRecoCtxt)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ISpRecoContext**, int> )(lpVtbl[12]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), ppRecoCtxt);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.LoadCmdFromFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT LoadCmdFromFile([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPLOADOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, SPLOADOPTIONS, int> )(lpVtbl[13]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszFileName, Options);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.LoadCmdFromObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT LoadCmdFromObject([NativeTypeName("const IID &")] Guid* rcid, [NativeTypeName("LPCWSTR")] ushort* pszGrammarName, SPLOADOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, Guid*, ushort*, SPLOADOPTIONS, int> )(lpVtbl[14]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), rcid, pszGrammarName, Options);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.LoadCmdFromResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT LoadCmdFromResource(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceType, [NativeTypeName("WORD")] ushort wLanguage, SPLOADOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, HMODULE, ushort*, ushort*, ushort, SPLOADOPTIONS, int> )(lpVtbl[15]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), hModule, pszResourceName, pszResourceType, wLanguage, Options);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.LoadCmdFromMemory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT LoadCmdFromMemory([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPBINARYGRAMMAR*, SPLOADOPTIONS, int> )(lpVtbl[16]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pGrammar, Options);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.LoadCmdFromProprietaryGrammar"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT LoadCmdFromProprietaryGrammar([NativeTypeName("const GUID &")] Guid* rguidParam, [NativeTypeName("LPCWSTR")] ushort* pszStringParam, [NativeTypeName("const void *")] void* pvDataPrarm, [NativeTypeName("ULONG")] uint cbDataSize, SPLOADOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, Guid*, ushort*, void*, uint, SPLOADOPTIONS, int> )(lpVtbl[17]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), rguidParam, pszStringParam, pvDataPrarm, cbDataSize, Options);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SetRuleState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetRuleState([NativeTypeName("LPCWSTR")] ushort* pszName, void* pReserved, SPRULESTATE NewState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, void*, SPRULESTATE, int> )(lpVtbl[18]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszName, pReserved, NewState);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SetRuleIdState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetRuleIdState([NativeTypeName("ULONG")] uint ulRuleId, SPRULESTATE NewState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, uint, SPRULESTATE, int> )(lpVtbl[19]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), ulRuleId, NewState);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.LoadDictation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT LoadDictation([NativeTypeName("LPCWSTR")] ushort* pszTopicName, SPLOADOPTIONS Options)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, SPLOADOPTIONS, int> )(lpVtbl[20]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszTopicName, Options);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.UnloadDictation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT UnloadDictation()
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, int> )(lpVtbl[21]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SetDictationState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDictationState(SPRULESTATE NewState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPRULESTATE, int> )(lpVtbl[22]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), NewState);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SetWordSequenceData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetWordSequenceData([NativeTypeName("const WCHAR *")] ushort* pText, [NativeTypeName("ULONG")] uint cchText, [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, uint, SPTEXTSELECTIONINFO*, int> )(lpVtbl[23]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pText, cchText, pInfo);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SetTextSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetTextSelection([NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPTEXTSELECTIONINFO*, int> )(lpVtbl[24]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pInfo);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.IsPronounceable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT IsPronounceable([NativeTypeName("LPCWSTR")] ushort* pszWord, SPWORDPRONOUNCEABLE* pWordPronounceable)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, ushort*, SPWORDPRONOUNCEABLE*, int> )(lpVtbl[25]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pszWord, pWordPronounceable);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SetGrammarState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetGrammarState(SPGRAMMARSTATE eGrammarState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPGRAMMARSTATE, int> )(lpVtbl[26]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), eGrammarState);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.SaveCmd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SaveCmd(IStream* pStream, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemErrorText)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, IStream*, ushort**, int> )(lpVtbl[27]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), pStream, ppszCoMemErrorText);
    }

    /// <include file='ISpRecoGrammar.xml' path='doc/member[@name="ISpRecoGrammar.GetGrammarState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetGrammarState(SPGRAMMARSTATE* peGrammarState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar*, SPGRAMMARSTATE*, int> )(lpVtbl[28]))((ISpRecoGrammar*)Unsafe.AsPointer(ref this), peGrammarState);
    }

    public interface Interface : ISpGrammarBuilder.Interface
    {
        [VtblIndex(11)]
        HRESULT GetGrammarId([NativeTypeName("ULONGLONG *")] ulong* pullGrammarId);
        [VtblIndex(12)]
        HRESULT GetRecoContext(ISpRecoContext** ppRecoCtxt);
        [VtblIndex(13)]
        HRESULT LoadCmdFromFile([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPLOADOPTIONS Options);
        [VtblIndex(14)]
        HRESULT LoadCmdFromObject([NativeTypeName("const IID &")] Guid* rcid, [NativeTypeName("LPCWSTR")] ushort* pszGrammarName, SPLOADOPTIONS Options);
        [VtblIndex(15)]
        HRESULT LoadCmdFromResource(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* pszResourceName, [NativeTypeName("LPCWSTR")] ushort* pszResourceType, [NativeTypeName("WORD")] ushort wLanguage, SPLOADOPTIONS Options);
        [VtblIndex(16)]
        HRESULT LoadCmdFromMemory([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options);
        [VtblIndex(17)]
        HRESULT LoadCmdFromProprietaryGrammar([NativeTypeName("const GUID &")] Guid* rguidParam, [NativeTypeName("LPCWSTR")] ushort* pszStringParam, [NativeTypeName("const void *")] void* pvDataPrarm, [NativeTypeName("ULONG")] uint cbDataSize, SPLOADOPTIONS Options);
        [VtblIndex(18)]
        HRESULT SetRuleState([NativeTypeName("LPCWSTR")] ushort* pszName, void* pReserved, SPRULESTATE NewState);
        [VtblIndex(19)]
        HRESULT SetRuleIdState([NativeTypeName("ULONG")] uint ulRuleId, SPRULESTATE NewState);
        [VtblIndex(20)]
        HRESULT LoadDictation([NativeTypeName("LPCWSTR")] ushort* pszTopicName, SPLOADOPTIONS Options);
        [VtblIndex(21)]
        HRESULT UnloadDictation();
        [VtblIndex(22)]
        HRESULT SetDictationState(SPRULESTATE NewState);
        [VtblIndex(23)]
        HRESULT SetWordSequenceData([NativeTypeName("const WCHAR *")] ushort* pText, [NativeTypeName("ULONG")] uint cchText, [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo);
        [VtblIndex(24)]
        HRESULT SetTextSelection([NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo);
        [VtblIndex(25)]
        HRESULT IsPronounceable([NativeTypeName("LPCWSTR")] ushort* pszWord, SPWORDPRONOUNCEABLE* pWordPronounceable);
        [VtblIndex(26)]
        HRESULT SetGrammarState(SPGRAMMARSTATE eGrammarState);
        [VtblIndex(27)]
        HRESULT SaveCmd(IStream* pStream, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemErrorText);
        [VtblIndex(28)]
        HRESULT GetGrammarState(SPGRAMMARSTATE* peGrammarState);
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
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetGrammarId;
        [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoContext**, int> GetRecoContext;
        [NativeTypeName("HRESULT (LPCWSTR, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SPLOADOPTIONS, int> LoadCmdFromFile;
        [NativeTypeName("HRESULT (const IID &, LPCWSTR, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, SPLOADOPTIONS, int> LoadCmdFromObject;
        [NativeTypeName("HRESULT (HMODULE, LPCWSTR, LPCWSTR, WORD, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMODULE, ushort*, ushort*, ushort, SPLOADOPTIONS, int> LoadCmdFromResource;
        [NativeTypeName("HRESULT (const SPBINARYGRAMMAR *, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPBINARYGRAMMAR*, SPLOADOPTIONS, int> LoadCmdFromMemory;
        [NativeTypeName("HRESULT (const GUID &, LPCWSTR, const void *, ULONG, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, void*, uint, SPLOADOPTIONS, int> LoadCmdFromProprietaryGrammar;
        [NativeTypeName("HRESULT (LPCWSTR, void *, SPRULESTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*, SPRULESTATE, int> SetRuleState;
        [NativeTypeName("HRESULT (ULONG, SPRULESTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SPRULESTATE, int> SetRuleIdState;
        [NativeTypeName("HRESULT (LPCWSTR, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SPLOADOPTIONS, int> LoadDictation;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnloadDictation;
        [NativeTypeName("HRESULT (SPRULESTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPRULESTATE, int> SetDictationState;
        [NativeTypeName("HRESULT (const WCHAR *, ULONG, const SPTEXTSELECTIONINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, SPTEXTSELECTIONINFO*, int> SetWordSequenceData;
        [NativeTypeName("HRESULT (const SPTEXTSELECTIONINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPTEXTSELECTIONINFO*, int> SetTextSelection;
        [NativeTypeName("HRESULT (LPCWSTR, SPWORDPRONOUNCEABLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SPWORDPRONOUNCEABLE*, int> IsPronounceable;
        [NativeTypeName("HRESULT (SPGRAMMARSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPGRAMMARSTATE, int> SetGrammarState;
        [NativeTypeName("HRESULT (IStream *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ushort**, int> SaveCmd;
        [NativeTypeName("HRESULT (SPGRAMMARSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPGRAMMARSTATE*, int> GetGrammarState;
    }
}