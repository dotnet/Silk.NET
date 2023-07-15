// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;
using static TerraFX.Interop.Windows.SpeechLoadOption;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar"]/*'/>
[Guid("B6D6F79F-2158-4E50-B5BC-9A9CCD852A09")]
[NativeTypeName("struct ISpeechRecoGrammar : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechRecoGrammar : ISpeechRecoGrammar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecoGrammar));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, uint> )(lpVtbl[1]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, uint> )(lpVtbl[2]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, uint*, int> )(lpVtbl[3]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.get_Id"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Id(VARIANT* Id)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, VARIANT*, int> )(lpVtbl[7]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Id);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.get_RecoContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RecoContext(ISpeechRecoContext** RecoContext)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ISpeechRecoContext**, int> )(lpVtbl[8]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), RecoContext);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.put_State"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_State(SpeechGrammarState State)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, SpeechGrammarState, int> )(lpVtbl[9]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.get_State"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_State(SpeechGrammarState* State)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, SpeechGrammarState*, int> )(lpVtbl[10]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.get_Rules"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Rules(ISpeechGrammarRules** Rules)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ISpeechGrammarRules**, int> )(lpVtbl[11]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Rules);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset([NativeTypeName("SpeechLanguageId")] int NewLanguage = 0)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, int, int> )(lpVtbl[12]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), NewLanguage);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdLoadFromFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CmdLoadFromFile([NativeTypeName("const BSTR")] ushort* FileName, SpeechLoadOption LoadOption = SLOStatic)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechLoadOption, int> )(lpVtbl[13]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), FileName, LoadOption);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdLoadFromObject"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CmdLoadFromObject([NativeTypeName("const BSTR")] ushort* ClassId, [NativeTypeName("const BSTR")] ushort* GrammarName, SpeechLoadOption LoadOption = SLOStatic)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, ushort*, SpeechLoadOption, int> )(lpVtbl[14]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), ClassId, GrammarName, LoadOption);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdLoadFromResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CmdLoadFromResource([NativeTypeName("long")] int hModule, VARIANT ResourceName, VARIANT ResourceType, [NativeTypeName("SpeechLanguageId")] int LanguageId, SpeechLoadOption LoadOption = SLOStatic)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, int, VARIANT, VARIANT, int, SpeechLoadOption, int> )(lpVtbl[15]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), hModule, ResourceName, ResourceType, LanguageId, LoadOption);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdLoadFromMemory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CmdLoadFromMemory(VARIANT GrammarData, SpeechLoadOption LoadOption = SLOStatic)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, VARIANT, SpeechLoadOption, int> )(lpVtbl[16]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), GrammarData, LoadOption);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdLoadFromProprietaryGrammar"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CmdLoadFromProprietaryGrammar([NativeTypeName("const BSTR")] ushort* ProprietaryGuid, [NativeTypeName("const BSTR")] ushort* ProprietaryString, VARIANT ProprietaryData, SpeechLoadOption LoadOption = SLOStatic)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, ushort*, VARIANT, SpeechLoadOption, int> )(lpVtbl[17]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), ProprietaryGuid, ProprietaryString, ProprietaryData, LoadOption);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdSetRuleState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CmdSetRuleState([NativeTypeName("const BSTR")] ushort* Name, SpeechRuleState State)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechRuleState, int> )(lpVtbl[18]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Name, State);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.CmdSetRuleIdState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CmdSetRuleIdState([NativeTypeName("long")] int RuleId, SpeechRuleState State)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, int, SpeechRuleState, int> )(lpVtbl[19]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), RuleId, State);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.DictationLoad"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DictationLoad([NativeTypeName("const BSTR")] ushort* TopicName = null, SpeechLoadOption LoadOption = SLOStatic)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechLoadOption, int> )(lpVtbl[20]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), TopicName, LoadOption);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.DictationUnload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DictationUnload()
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, int> )(lpVtbl[21]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.DictationSetState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT DictationSetState(SpeechRuleState State)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, SpeechRuleState, int> )(lpVtbl[22]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), State);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.SetWordSequenceData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetWordSequenceData([NativeTypeName("const BSTR")] ushort* Text, [NativeTypeName("long")] int TextLength, ISpeechTextSelectionInformation* Info)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, int, ISpeechTextSelectionInformation*, int> )(lpVtbl[23]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Text, TextLength, Info);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.SetTextSelection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetTextSelection(ISpeechTextSelectionInformation* Info)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ISpeechTextSelectionInformation*, int> )(lpVtbl[24]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Info);
    }

    /// <include file='ISpeechRecoGrammar.xml' path='doc/member[@name="ISpeechRecoGrammar.IsPronounceable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT IsPronounceable([NativeTypeName("const BSTR")] ushort* Word, SpeechWordPronounceable* WordPronounceable)
    {
        return ((delegate* unmanaged<ISpeechRecoGrammar*, ushort*, SpeechWordPronounceable*, int> )(lpVtbl[25]))((ISpeechRecoGrammar*)Unsafe.AsPointer(ref this), Word, WordPronounceable);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Id(VARIANT* Id);
        [VtblIndex(8)]
        HRESULT get_RecoContext(ISpeechRecoContext** RecoContext);
        [VtblIndex(9)]
        HRESULT put_State(SpeechGrammarState State);
        [VtblIndex(10)]
        HRESULT get_State(SpeechGrammarState* State);
        [VtblIndex(11)]
        HRESULT get_Rules(ISpeechGrammarRules** Rules);
        [VtblIndex(12)]
        HRESULT Reset([NativeTypeName("SpeechLanguageId")] int NewLanguage = 0);
        [VtblIndex(13)]
        HRESULT CmdLoadFromFile([NativeTypeName("const BSTR")] ushort* FileName, SpeechLoadOption LoadOption = SLOStatic);
        [VtblIndex(14)]
        HRESULT CmdLoadFromObject([NativeTypeName("const BSTR")] ushort* ClassId, [NativeTypeName("const BSTR")] ushort* GrammarName, SpeechLoadOption LoadOption = SLOStatic);
        [VtblIndex(15)]
        HRESULT CmdLoadFromResource([NativeTypeName("long")] int hModule, VARIANT ResourceName, VARIANT ResourceType, [NativeTypeName("SpeechLanguageId")] int LanguageId, SpeechLoadOption LoadOption = SLOStatic);
        [VtblIndex(16)]
        HRESULT CmdLoadFromMemory(VARIANT GrammarData, SpeechLoadOption LoadOption = SLOStatic);
        [VtblIndex(17)]
        HRESULT CmdLoadFromProprietaryGrammar([NativeTypeName("const BSTR")] ushort* ProprietaryGuid, [NativeTypeName("const BSTR")] ushort* ProprietaryString, VARIANT ProprietaryData, SpeechLoadOption LoadOption = SLOStatic);
        [VtblIndex(18)]
        HRESULT CmdSetRuleState([NativeTypeName("const BSTR")] ushort* Name, SpeechRuleState State);
        [VtblIndex(19)]
        HRESULT CmdSetRuleIdState([NativeTypeName("long")] int RuleId, SpeechRuleState State);
        [VtblIndex(20)]
        HRESULT DictationLoad([NativeTypeName("const BSTR")] ushort* TopicName = null, SpeechLoadOption LoadOption = SLOStatic);
        [VtblIndex(21)]
        HRESULT DictationUnload();
        [VtblIndex(22)]
        HRESULT DictationSetState(SpeechRuleState State);
        [VtblIndex(23)]
        HRESULT SetWordSequenceData([NativeTypeName("const BSTR")] ushort* Text, [NativeTypeName("long")] int TextLength, ISpeechTextSelectionInformation* Info);
        [VtblIndex(24)]
        HRESULT SetTextSelection(ISpeechTextSelectionInformation* Info);
        [VtblIndex(25)]
        HRESULT IsPronounceable([NativeTypeName("const BSTR")] ushort* Word, SpeechWordPronounceable* WordPronounceable);
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
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_Id;
        [NativeTypeName("HRESULT (ISpeechRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechRecoContext**, int> get_RecoContext;
        [NativeTypeName("HRESULT (SpeechGrammarState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechGrammarState, int> put_State;
        [NativeTypeName("HRESULT (SpeechGrammarState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechGrammarState*, int> get_State;
        [NativeTypeName("HRESULT (ISpeechGrammarRules **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechGrammarRules**, int> get_Rules;
        [NativeTypeName("HRESULT (SpeechLanguageId) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Reset;
        [NativeTypeName("HRESULT (const BSTR, SpeechLoadOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SpeechLoadOption, int> CmdLoadFromFile;
        [NativeTypeName("HRESULT (const BSTR, const BSTR, SpeechLoadOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, SpeechLoadOption, int> CmdLoadFromObject;
        [NativeTypeName("HRESULT (long, VARIANT, VARIANT, SpeechLanguageId, SpeechLoadOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, VARIANT, VARIANT, int, SpeechLoadOption, int> CmdLoadFromResource;
        [NativeTypeName("HRESULT (VARIANT, SpeechLoadOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, SpeechLoadOption, int> CmdLoadFromMemory;
        [NativeTypeName("HRESULT (const BSTR, const BSTR, VARIANT, SpeechLoadOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, VARIANT, SpeechLoadOption, int> CmdLoadFromProprietaryGrammar;
        [NativeTypeName("HRESULT (const BSTR, SpeechRuleState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SpeechRuleState, int> CmdSetRuleState;
        [NativeTypeName("HRESULT (long, SpeechRuleState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, SpeechRuleState, int> CmdSetRuleIdState;
        [NativeTypeName("HRESULT (const BSTR, SpeechLoadOption) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SpeechLoadOption, int> DictationLoad;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DictationUnload;
        [NativeTypeName("HRESULT (SpeechRuleState) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpeechRuleState, int> DictationSetState;
        [NativeTypeName("HRESULT (const BSTR, long, ISpeechTextSelectionInformation *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, ISpeechTextSelectionInformation*, int> SetWordSequenceData;
        [NativeTypeName("HRESULT (ISpeechTextSelectionInformation *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechTextSelectionInformation*, int> SetTextSelection;
        [NativeTypeName("HRESULT (const BSTR, SpeechWordPronounceable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SpeechWordPronounceable*, int> IsPronounceable;
    }
}