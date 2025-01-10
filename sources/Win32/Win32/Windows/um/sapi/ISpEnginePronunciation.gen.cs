// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C360CE4B-76D1-4214-AD68-52657D5083DA")]
[NativeTypeName("struct ISpEnginePronunciation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpEnginePronunciation : ISpEnginePronunciation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpEnginePronunciation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpEnginePronunciation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpEnginePronunciation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpEnginePronunciation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Normalize(
        [NativeTypeName("LPCWSTR")] ushort* pszWord,
        [NativeTypeName("LPCWSTR")] ushort* pszLeftContext,
        [NativeTypeName("LPCWSTR")] ushort* pszRightContext,
        [NativeTypeName("WORD")] ushort LangID,
        SPNORMALIZATIONLIST* pNormalizationList
    )
    {
        return (
            (delegate* unmanaged<
                ISpEnginePronunciation,
                ushort*,
                ushort*,
                ushort*,
                ushort,
                SPNORMALIZATIONLIST*,
                int>)((*lpVtbl)[3])
        )(this, pszWord, pszLeftContext, pszRightContext, LangID, pNormalizationList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPronunciations(
        [NativeTypeName("LPCWSTR")] ushort* pszWord,
        [NativeTypeName("LPCWSTR")] ushort* pszLeftContext,
        [NativeTypeName("LPCWSTR")] ushort* pszRightContext,
        [NativeTypeName("WORD")] ushort LangID,
        SPWORDPRONUNCIATIONLIST* pEnginePronunciationList
    )
    {
        return (
            (delegate* unmanaged<
                ISpEnginePronunciation,
                ushort*,
                ushort*,
                ushort*,
                ushort,
                SPWORDPRONUNCIATIONLIST*,
                int>)((*lpVtbl)[4])
        )(this, pszWord, pszLeftContext, pszRightContext, LangID, pEnginePronunciationList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Normalize(
            [NativeTypeName("LPCWSTR")] ushort* pszWord,
            [NativeTypeName("LPCWSTR")] ushort* pszLeftContext,
            [NativeTypeName("LPCWSTR")] ushort* pszRightContext,
            [NativeTypeName("WORD")] ushort LangID,
            SPNORMALIZATIONLIST* pNormalizationList
        );

        [VtblIndex(4)]
        HRESULT GetPronunciations(
            [NativeTypeName("LPCWSTR")] ushort* pszWord,
            [NativeTypeName("LPCWSTR")] ushort* pszLeftContext,
            [NativeTypeName("LPCWSTR")] ushort* pszRightContext,
            [NativeTypeName("WORD")] ushort LangID,
            SPWORDPRONUNCIATIONLIST* pEnginePronunciationList
        );
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
            "HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, WORD, SPNORMALIZATIONLIST *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            ushort,
            SPNORMALIZATIONLIST*,
            int> Normalize;

        [NativeTypeName(
            "HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, WORD, SPWORDPRONUNCIATIONLIST *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            ushort,
            SPWORDPRONUNCIATIONLIST*,
            int> GetPronunciations;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpEnginePronunciation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpEnginePronunciation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpEnginePronunciation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpEnginePronunciation(Silk.NET.Windows.IUnknown value)
    {
        return new ISpEnginePronunciation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpEnginePronunciation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpEnginePronunciation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpEnginePronunciation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
