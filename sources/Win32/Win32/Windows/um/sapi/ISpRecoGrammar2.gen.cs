// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4B37BC9E-9ED6-44A3-93D3-18F022B79EC3")]
[NativeTypeName("struct ISpRecoGrammar2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecoGrammar2 : ISpRecoGrammar2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoGrammar2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecoGrammar2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRules(SPRULE** ppCoMemRules, uint* puNumRules)
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, SPRULE**, uint*, int>)((*lpVtbl)[3]))(
            this,
            ppCoMemRules,
            puNumRules
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LoadCmdFromFile2(
        [NativeTypeName("LPCWSTR")] ushort* pszFileName,
        SPLOADOPTIONS Options,
        [NativeTypeName("LPCWSTR")] ushort* pszSharingUri,
        [NativeTypeName("LPCWSTR")] ushort* pszBaseUri
    )
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar2, ushort*, SPLOADOPTIONS, ushort*, ushort*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pszFileName, Options, pszSharingUri, pszBaseUri);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadCmdFromMemory2(
        [NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar,
        SPLOADOPTIONS Options,
        [NativeTypeName("LPCWSTR")] ushort* pszSharingUri,
        [NativeTypeName("LPCWSTR")] ushort* pszBaseUri
    )
    {
        return (
            (delegate* unmanaged<
                ISpRecoGrammar2,
                SPBINARYGRAMMAR*,
                SPLOADOPTIONS,
                ushort*,
                ushort*,
                int>)((*lpVtbl)[5])
        )(this, pGrammar, Options, pszSharingUri, pszBaseUri);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRulePriority(
        [NativeTypeName("LPCWSTR")] ushort* pszRuleName,
        [NativeTypeName("ULONG")] uint ulRuleId,
        int nRulePriority
    )
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, ushort*, uint, int, int>)((*lpVtbl)[6]))(
            this,
            pszRuleName,
            ulRuleId,
            nRulePriority
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRuleWeight(
        [NativeTypeName("LPCWSTR")] ushort* pszRuleName,
        [NativeTypeName("ULONG")] uint ulRuleId,
        float flWeight
    )
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, ushort*, uint, float, int>)((*lpVtbl)[7]))(
            this,
            pszRuleName,
            ulRuleId,
            flWeight
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDictationWeight(float flWeight)
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, float, int>)((*lpVtbl)[8]))(this, flWeight);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGrammarLoader(ISpeechResourceLoader pLoader)
    {
        return ((delegate* unmanaged<ISpRecoGrammar2, ISpeechResourceLoader, int>)((*lpVtbl)[9]))(
            this,
            pLoader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSMLSecurityManager(IInternetSecurityManager pSMLSecurityManager)
    {
        return (
            (delegate* unmanaged<ISpRecoGrammar2, IInternetSecurityManager, int>)((*lpVtbl)[10])
        )(this, pSMLSecurityManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRules(SPRULE** ppCoMemRules, uint* puNumRules);

        [VtblIndex(4)]
        HRESULT LoadCmdFromFile2(
            [NativeTypeName("LPCWSTR")] ushort* pszFileName,
            SPLOADOPTIONS Options,
            [NativeTypeName("LPCWSTR")] ushort* pszSharingUri,
            [NativeTypeName("LPCWSTR")] ushort* pszBaseUri
        );

        [VtblIndex(5)]
        HRESULT LoadCmdFromMemory2(
            [NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar,
            SPLOADOPTIONS Options,
            [NativeTypeName("LPCWSTR")] ushort* pszSharingUri,
            [NativeTypeName("LPCWSTR")] ushort* pszBaseUri
        );

        [VtblIndex(6)]
        HRESULT SetRulePriority(
            [NativeTypeName("LPCWSTR")] ushort* pszRuleName,
            [NativeTypeName("ULONG")] uint ulRuleId,
            int nRulePriority
        );

        [VtblIndex(7)]
        HRESULT SetRuleWeight(
            [NativeTypeName("LPCWSTR")] ushort* pszRuleName,
            [NativeTypeName("ULONG")] uint ulRuleId,
            float flWeight
        );

        [VtblIndex(8)]
        HRESULT SetDictationWeight(float flWeight);

        [VtblIndex(9)]
        HRESULT SetGrammarLoader(ISpeechResourceLoader pLoader);

        [VtblIndex(10)]
        HRESULT SetSMLSecurityManager(IInternetSecurityManager pSMLSecurityManager);
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

        [NativeTypeName("HRESULT (SPRULE **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SPRULE**, uint*, int> GetRules;

        [NativeTypeName(
            "HRESULT (LPCWSTR, SPLOADOPTIONS, LPCWSTR, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            SPLOADOPTIONS,
            ushort*,
            ushort*,
            int> LoadCmdFromFile2;

        [NativeTypeName(
            "HRESULT (const SPBINARYGRAMMAR *, SPLOADOPTIONS, LPCWSTR, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPBINARYGRAMMAR*,
            SPLOADOPTIONS,
            ushort*,
            ushort*,
            int> LoadCmdFromMemory2;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int, int> SetRulePriority;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, float, int> SetRuleWeight;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetDictationWeight;

        [NativeTypeName("HRESULT (ISpeechResourceLoader *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechResourceLoader, int> SetGrammarLoader;

        [NativeTypeName("HRESULT (IInternetSecurityManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInternetSecurityManager, int> SetSMLSecurityManager;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecoGrammar2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecoGrammar2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecoGrammar2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecoGrammar2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecoGrammar2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoGrammar2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoGrammar2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecoGrammar2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
