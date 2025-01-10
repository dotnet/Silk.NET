// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8565572F-C094-41CC-B56E-10BD9C3FF044")]
[NativeTypeName("struct ISpContainerLexicon : ISpLexicon")]
[NativeInheritance("ISpLexicon")]
public unsafe partial struct ISpContainerLexicon : ISpContainerLexicon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpContainerLexicon));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpContainerLexicon, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpContainerLexicon, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpContainerLexicon, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPronunciations(
        [NativeTypeName("LPCWSTR")] ushort* pszWord,
        [NativeTypeName("WORD")] ushort LangID,
        [NativeTypeName("DWORD")] uint dwFlags,
        SPWORDPRONUNCIATIONLIST* pWordPronunciationList
    )
    {
        return (
            (delegate* unmanaged<
                ISpContainerLexicon,
                ushort*,
                ushort,
                uint,
                SPWORDPRONUNCIATIONLIST*,
                int>)((*lpVtbl)[3])
        )(this, pszWord, LangID, dwFlags, pWordPronunciationList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPronunciation(
        [NativeTypeName("LPCWSTR")] ushort* pszWord,
        [NativeTypeName("WORD")] ushort LangID,
        SPPARTOFSPEECH ePartOfSpeech,
        [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation
    )
    {
        return (
            (delegate* unmanaged<
                ISpContainerLexicon,
                ushort*,
                ushort,
                SPPARTOFSPEECH,
                ushort*,
                int>)((*lpVtbl)[4])
        )(this, pszWord, LangID, ePartOfSpeech, pszPronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemovePronunciation(
        [NativeTypeName("LPCWSTR")] ushort* pszWord,
        [NativeTypeName("WORD")] ushort LangID,
        SPPARTOFSPEECH ePartOfSpeech,
        [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation
    )
    {
        return (
            (delegate* unmanaged<
                ISpContainerLexicon,
                ushort*,
                ushort,
                SPPARTOFSPEECH,
                ushort*,
                int>)((*lpVtbl)[5])
        )(this, pszWord, LangID, ePartOfSpeech, pszPronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
    {
        return ((delegate* unmanaged<ISpContainerLexicon, uint*, int>)((*lpVtbl)[6]))(
            this,
            pdwGeneration
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetGenerationChange(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwGeneration,
        SPWORDLIST* pWordList
    )
    {
        return (
            (delegate* unmanaged<ISpContainerLexicon, uint, uint*, SPWORDLIST*, int>)((*lpVtbl)[7])
        )(this, dwFlags, pdwGeneration, pWordList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWords(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pdwGeneration,
        [NativeTypeName("DWORD *")] uint* pdwCookie,
        SPWORDLIST* pWordList
    )
    {
        return (
            (delegate* unmanaged<ISpContainerLexicon, uint, uint*, uint*, SPWORDLIST*, int>)(
                (*lpVtbl)[8]
            )
        )(this, dwFlags, pdwGeneration, pdwCookie, pWordList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AddLexicon(ISpLexicon pAddLexicon, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ISpContainerLexicon, ISpLexicon, uint, int>)((*lpVtbl)[9]))(
            this,
            pAddLexicon,
            dwFlags
        );
    }

    public interface Interface : ISpLexicon.Interface
    {
        [VtblIndex(9)]
        HRESULT AddLexicon(ISpLexicon pAddLexicon, [NativeTypeName("DWORD")] uint dwFlags);
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, WORD, DWORD, SPWORDPRONUNCIATIONLIST *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort,
            uint,
            SPWORDPRONUNCIATIONLIST*,
            int> GetPronunciations;

        [NativeTypeName(
            "HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort,
            SPPARTOFSPEECH,
            ushort*,
            int> AddPronunciation;

        [NativeTypeName(
            "HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort,
            SPPARTOFSPEECH,
            ushort*,
            int> RemovePronunciation;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetGeneration;

        [NativeTypeName("HRESULT (DWORD, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, SPWORDLIST*, int> GetGenerationChange;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, SPWORDLIST*, int> GetWords;

        [NativeTypeName("HRESULT (ISpLexicon *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpLexicon, uint, int> AddLexicon;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpContainerLexicon"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpContainerLexicon(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpLexicon"/> to <see cref = "ISpContainerLexicon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpLexicon"/> instance to be converted </param>
    public static explicit operator ISpContainerLexicon(Silk.NET.Windows.ISpLexicon value)
    {
        return new ISpContainerLexicon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpContainerLexicon"/> to <see cref = "Silk.NET.Windows.ISpLexicon"/>.</summary>
    /// <param name = "value">The <see cref = "ISpContainerLexicon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpLexicon(ISpContainerLexicon value)
    {
        return new Silk.NET.Windows.ISpLexicon(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpContainerLexicon"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpContainerLexicon(Silk.NET.Windows.IUnknown value)
    {
        return new ISpContainerLexicon(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpContainerLexicon"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpContainerLexicon"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpContainerLexicon value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
