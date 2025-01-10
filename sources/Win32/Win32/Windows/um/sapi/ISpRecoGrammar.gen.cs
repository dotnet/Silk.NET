// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2177DB29-7F45-47D0-8554-067E91C80502")]
[NativeTypeName("struct ISpRecoGrammar : ISpGrammarBuilder")]
[NativeInheritance("ISpGrammarBuilder")]
public unsafe partial struct ISpRecoGrammar : ISpRecoGrammar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoGrammar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecoGrammar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoGrammar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ResetGrammar([NativeTypeName("WORD")] ushort NewLanguage)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, ushort, int>)((*lpVtbl)[3]))(
            this,
            NewLanguage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRule(
        [NativeTypeName("LPCWSTR")] ushort* pszRuleName,
        [NativeTypeName("DWORD")] uint dwRuleId,
        [NativeTypeName("DWORD")] uint dwAttributes,
        BOOL fCreateIfNotExist,
        SPSTATEHANDLE* phInitialState
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pszRuleName, dwRuleId, dwAttributes, fCreateIfNotExist, phInitialState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearRule(SPSTATEHANDLE hState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, SPSTATEHANDLE, int>)((*lpVtbl)[5]))(
            this,
            hState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateNewState(SPSTATEHANDLE hState, SPSTATEHANDLE* phState)
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, SPSTATEHANDLE, SPSTATEHANDLE*, int>)((*lpVtbl)[6])
        )(this, hState, phState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWordTransition(
        SPSTATEHANDLE hFromState,
        SPSTATEHANDLE hToState,
        [NativeTypeName("LPCWSTR")] ushort* psz,
        [NativeTypeName("LPCWSTR")] ushort* pszSeparators,
        SPGRAMMARWORDTYPE eWordType,
        float Weight,
        [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo
    )
    {
        return (
            (delegate* unmanaged<
                ISpRecoGrammar,
                SPSTATEHANDLE,
                SPSTATEHANDLE,
                ushort*,
                ushort*,
                SPGRAMMARWORDTYPE,
                float,
                SPPROPERTYINFO*,
                int>)((*lpVtbl)[7])
        )(this, hFromState, hToState, psz, pszSeparators, eWordType, Weight, pPropInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddRuleTransition(
        SPSTATEHANDLE hFromState,
        SPSTATEHANDLE hToState,
        SPSTATEHANDLE hRule,
        float Weight,
        [NativeTypeName("const SPPROPERTYINFO *")] SPPROPERTYINFO* pPropInfo
    )
    {
        return (
            (delegate* unmanaged<
                ISpRecoGrammar,
                SPSTATEHANDLE,
                SPSTATEHANDLE,
                SPSTATEHANDLE,
                float,
                SPPROPERTYINFO*,
                int>)((*lpVtbl)[8])
        )(this, hFromState, hToState, hRule, Weight, pPropInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddResource(
        SPSTATEHANDLE hRuleState,
        [NativeTypeName("LPCWSTR")] ushort* pszResourceName,
        [NativeTypeName("LPCWSTR")] ushort* pszResourceValue
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, SPSTATEHANDLE, ushort*, ushort*, int>)(
                (*lpVtbl)[9]
            )
        )(this, hRuleState, pszResourceName, pszResourceValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, uint, int>)((*lpVtbl)[10]))(this, dwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetGrammarId([NativeTypeName("ULONGLONG *")] ulong* pullGrammarId)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, ulong*, int>)((*lpVtbl)[11]))(
            this,
            pullGrammarId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetRecoContext(ISpRecoContext* ppRecoCtxt)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, ISpRecoContext*, int>)((*lpVtbl)[12]))(
            this,
            ppRecoCtxt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT LoadCmdFromFile(
        [NativeTypeName("LPCWSTR")] ushort* pszFileName,
        SPLOADOPTIONS Options
    )
    {
        return ((delegate* unmanaged<ISpRecoGrammar, ushort*, SPLOADOPTIONS, int>)((*lpVtbl)[13]))(
            this,
            pszFileName,
            Options
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT LoadCmdFromObject(
        [NativeTypeName("const IID &")] Guid* rcid,
        [NativeTypeName("LPCWSTR")] ushort* pszGrammarName,
        SPLOADOPTIONS Options
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, Guid*, ushort*, SPLOADOPTIONS, int>)((*lpVtbl)[14])
        )(this, rcid, pszGrammarName, Options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT LoadCmdFromResource(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* pszResourceName,
        [NativeTypeName("LPCWSTR")] ushort* pszResourceType,
        [NativeTypeName("WORD")] ushort wLanguage,
        SPLOADOPTIONS Options
    )
    {
        return (
            (delegate* unmanaged<
                ISpRecoGrammar,
                HMODULE,
                ushort*,
                ushort*,
                ushort,
                SPLOADOPTIONS,
                int>)((*lpVtbl)[15])
        )(this, hModule, pszResourceName, pszResourceType, wLanguage, Options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT LoadCmdFromMemory(
        [NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar,
        SPLOADOPTIONS Options
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, SPBINARYGRAMMAR*, SPLOADOPTIONS, int>)(
                (*lpVtbl)[16]
            )
        )(this, pGrammar, Options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT LoadCmdFromProprietaryGrammar(
        [NativeTypeName("const GUID &")] Guid* rguidParam,
        [NativeTypeName("LPCWSTR")] ushort* pszStringParam,
        [NativeTypeName("const void *")] void* pvDataPrarm,
        [NativeTypeName("ULONG")] uint cbDataSize,
        SPLOADOPTIONS Options
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, Guid*, ushort*, void*, uint, SPLOADOPTIONS, int>)(
                (*lpVtbl)[17]
            )
        )(this, rguidParam, pszStringParam, pvDataPrarm, cbDataSize, Options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetRuleState(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        void* pReserved,
        SPRULESTATE NewState
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, ushort*, void*, SPRULESTATE, int>)((*lpVtbl)[18])
        )(this, pszName, pReserved, NewState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetRuleIdState([NativeTypeName("ULONG")] uint ulRuleId, SPRULESTATE NewState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, uint, SPRULESTATE, int>)((*lpVtbl)[19]))(
            this,
            ulRuleId,
            NewState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT LoadDictation(
        [NativeTypeName("LPCWSTR")] ushort* pszTopicName,
        SPLOADOPTIONS Options
    )
    {
        return ((delegate* unmanaged<ISpRecoGrammar, ushort*, SPLOADOPTIONS, int>)((*lpVtbl)[20]))(
            this,
            pszTopicName,
            Options
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT UnloadDictation()
    {
        return ((delegate* unmanaged<ISpRecoGrammar, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDictationState(SPRULESTATE NewState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, SPRULESTATE, int>)((*lpVtbl)[22]))(
            this,
            NewState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetWordSequenceData(
        [NativeTypeName("const WCHAR *")] ushort* pText,
        [NativeTypeName("ULONG")] uint cchText,
        [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, ushort*, uint, SPTEXTSELECTIONINFO*, int>)(
                (*lpVtbl)[23]
            )
        )(this, pText, cchText, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetTextSelection(
        [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo
    )
    {
        return ((delegate* unmanaged<ISpRecoGrammar, SPTEXTSELECTIONINFO*, int>)((*lpVtbl)[24]))(
            this,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT IsPronounceable(
        [NativeTypeName("LPCWSTR")] ushort* pszWord,
        SPWORDPRONOUNCEABLE* pWordPronounceable
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar, ushort*, SPWORDPRONOUNCEABLE*, int>)((*lpVtbl)[25])
        )(this, pszWord, pWordPronounceable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetGrammarState(SPGRAMMARSTATE eGrammarState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, SPGRAMMARSTATE, int>)((*lpVtbl)[26]))(
            this,
            eGrammarState
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SaveCmd(
        IStream pStream,
        [NativeTypeName("LPWSTR *")] ushort** ppszCoMemErrorText
    )
    {
        return ((delegate* unmanaged<ISpRecoGrammar, IStream, ushort**, int>)((*lpVtbl)[27]))(
            this,
            pStream,
            ppszCoMemErrorText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetGrammarState(SPGRAMMARSTATE* peGrammarState)
    {
        return ((delegate* unmanaged<ISpRecoGrammar, SPGRAMMARSTATE*, int>)((*lpVtbl)[28]))(
            this,
            peGrammarState
        );
    }

    public interface Interface : ISpGrammarBuilder.Interface
    {
        [VtblIndex(11)]
        HRESULT GetGrammarId([NativeTypeName("ULONGLONG *")] ulong* pullGrammarId);

        [VtblIndex(12)]
        HRESULT GetRecoContext(ISpRecoContext* ppRecoCtxt);

        [VtblIndex(13)]
        HRESULT LoadCmdFromFile(
            [NativeTypeName("LPCWSTR")] ushort* pszFileName,
            SPLOADOPTIONS Options
        );

        [VtblIndex(14)]
        HRESULT LoadCmdFromObject(
            [NativeTypeName("const IID &")] Guid* rcid,
            [NativeTypeName("LPCWSTR")] ushort* pszGrammarName,
            SPLOADOPTIONS Options
        );

        [VtblIndex(15)]
        HRESULT LoadCmdFromResource(
            HMODULE hModule,
            [NativeTypeName("LPCWSTR")] ushort* pszResourceName,
            [NativeTypeName("LPCWSTR")] ushort* pszResourceType,
            [NativeTypeName("WORD")] ushort wLanguage,
            SPLOADOPTIONS Options
        );

        [VtblIndex(16)]
        HRESULT LoadCmdFromMemory(
            [NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar,
            SPLOADOPTIONS Options
        );

        [VtblIndex(17)]
        HRESULT LoadCmdFromProprietaryGrammar(
            [NativeTypeName("const GUID &")] Guid* rguidParam,
            [NativeTypeName("LPCWSTR")] ushort* pszStringParam,
            [NativeTypeName("const void *")] void* pvDataPrarm,
            [NativeTypeName("ULONG")] uint cbDataSize,
            SPLOADOPTIONS Options
        );

        [VtblIndex(18)]
        HRESULT SetRuleState(
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            void* pReserved,
            SPRULESTATE NewState
        );

        [VtblIndex(19)]
        HRESULT SetRuleIdState([NativeTypeName("ULONG")] uint ulRuleId, SPRULESTATE NewState);

        [VtblIndex(20)]
        HRESULT LoadDictation(
            [NativeTypeName("LPCWSTR")] ushort* pszTopicName,
            SPLOADOPTIONS Options
        );

        [VtblIndex(21)]
        HRESULT UnloadDictation();

        [VtblIndex(22)]
        HRESULT SetDictationState(SPRULESTATE NewState);

        [VtblIndex(23)]
        HRESULT SetWordSequenceData(
            [NativeTypeName("const WCHAR *")] ushort* pText,
            [NativeTypeName("ULONG")] uint cchText,
            [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo
        );

        [VtblIndex(24)]
        HRESULT SetTextSelection(
            [NativeTypeName("const SPTEXTSELECTIONINFO *")] SPTEXTSELECTIONINFO* pInfo
        );

        [VtblIndex(25)]
        HRESULT IsPronounceable(
            [NativeTypeName("LPCWSTR")] ushort* pszWord,
            SPWORDPRONOUNCEABLE* pWordPronounceable
        );

        [VtblIndex(26)]
        HRESULT SetGrammarState(SPGRAMMARSTATE eGrammarState);

        [VtblIndex(27)]
        HRESULT SaveCmd(IStream pStream, [NativeTypeName("LPWSTR *")] ushort** ppszCoMemErrorText);

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

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, DWORD, BOOL, SPSTATEHANDLE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, BOOL, SPSTATEHANDLE*, int> GetRule;

        [NativeTypeName("HRESULT (SPSTATEHANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, int> ClearRule;

        [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, SPSTATEHANDLE*, int> CreateNewState;

        [NativeTypeName(
            "HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, LPCWSTR, LPCWSTR, SPGRAMMARWORDTYPE, float, const SPPROPERTYINFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPSTATEHANDLE,
            SPSTATEHANDLE,
            ushort*,
            ushort*,
            SPGRAMMARWORDTYPE,
            float,
            SPPROPERTYINFO*,
            int> AddWordTransition;

        [NativeTypeName(
            "HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, SPSTATEHANDLE, float, const SPPROPERTYINFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPSTATEHANDLE,
            SPSTATEHANDLE,
            SPSTATEHANDLE,
            float,
            SPPROPERTYINFO*,
            int> AddRuleTransition;

        [NativeTypeName("HRESULT (SPSTATEHANDLE, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPSTATEHANDLE, ushort*, ushort*, int> AddResource;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetGrammarId;

        [NativeTypeName("HRESULT (ISpRecoContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpRecoContext*, int> GetRecoContext;

        [NativeTypeName("HRESULT (LPCWSTR, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SPLOADOPTIONS, int> LoadCmdFromFile;

        [NativeTypeName("HRESULT (const IID &, LPCWSTR, SPLOADOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, SPLOADOPTIONS, int> LoadCmdFromObject;

        [NativeTypeName(
            "HRESULT (HMODULE, LPCWSTR, LPCWSTR, WORD, SPLOADOPTIONS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HMODULE,
            ushort*,
            ushort*,
            ushort,
            SPLOADOPTIONS,
            int> LoadCmdFromResource;

        [NativeTypeName(
            "HRESULT (const SPBINARYGRAMMAR *, SPLOADOPTIONS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SPBINARYGRAMMAR*, SPLOADOPTIONS, int> LoadCmdFromMemory;

        [NativeTypeName(
            "HRESULT (const GUID &, LPCWSTR, const void *, ULONG, SPLOADOPTIONS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort*,
            void*,
            uint,
            SPLOADOPTIONS,
            int> LoadCmdFromProprietaryGrammar;

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

        [NativeTypeName(
            "HRESULT (const WCHAR *, ULONG, const SPTEXTSELECTIONINFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            SPTEXTSELECTIONINFO*,
            int> SetWordSequenceData;

        [NativeTypeName("HRESULT (const SPTEXTSELECTIONINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPTEXTSELECTIONINFO*, int> SetTextSelection;

        [NativeTypeName("HRESULT (LPCWSTR, SPWORDPRONOUNCEABLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SPWORDPRONOUNCEABLE*, int> IsPronounceable;

        [NativeTypeName("HRESULT (SPGRAMMARSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPGRAMMARSTATE, int> SetGrammarState;

        [NativeTypeName("HRESULT (IStream *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, ushort**, int> SaveCmd;

        [NativeTypeName("HRESULT (SPGRAMMARSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPGRAMMARSTATE*, int> GetGrammarState;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecoGrammar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecoGrammar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpGrammarBuilder"/> to <see cref = "ISpRecoGrammar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpGrammarBuilder"/> instance to be converted </param>
    public static explicit operator ISpRecoGrammar(Silk.NET.Windows.ISpGrammarBuilder value)
    {
        return new ISpRecoGrammar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoGrammar"/> to <see cref = "Silk.NET.Windows.ISpGrammarBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoGrammar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpGrammarBuilder(ISpRecoGrammar value)
    {
        return new Silk.NET.Windows.ISpGrammarBuilder(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecoGrammar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecoGrammar(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecoGrammar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoGrammar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoGrammar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecoGrammar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
