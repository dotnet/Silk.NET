// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BEAD311C-52FF-437F-9464-6B21054CA73D")]
[NativeTypeName("struct ISpRecoContext2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecoContext2 : ISpRecoContext2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpRecoContext2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecoContext2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpRecoContext2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecoContext2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGrammarOptions([NativeTypeName("DWORD")] uint eGrammarOptions)
    {
        return ((delegate* unmanaged<ISpRecoContext2, uint, int>)((*lpVtbl)[3]))(
            this,
            eGrammarOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGrammarOptions([NativeTypeName("DWORD *")] uint* peGrammarOptions)
    {
        return ((delegate* unmanaged<ISpRecoContext2, uint*, int>)((*lpVtbl)[4]))(
            this,
            peGrammarOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAdaptationData2(
        [NativeTypeName("LPCWSTR")] ushort* pAdaptationData,
        [NativeTypeName("const ULONG")] uint cch,
        [NativeTypeName("LPCWSTR")] ushort* pTopicName,
        [NativeTypeName("DWORD")] uint eAdaptationSettings,
        SPADAPTATIONRELEVANCE eRelevance
    )
    {
        return (
            (delegate* unmanaged<
                ISpRecoContext2,
                ushort*,
                uint,
                ushort*,
                uint,
                SPADAPTATIONRELEVANCE,
                int>)((*lpVtbl)[5])
        )(this, pAdaptationData, cch, pTopicName, eAdaptationSettings, eRelevance);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGrammarOptions([NativeTypeName("DWORD")] uint eGrammarOptions);

        [VtblIndex(4)]
        HRESULT GetGrammarOptions([NativeTypeName("DWORD *")] uint* peGrammarOptions);

        [VtblIndex(5)]
        HRESULT SetAdaptationData2(
            [NativeTypeName("LPCWSTR")] ushort* pAdaptationData,
            [NativeTypeName("const ULONG")] uint cch,
            [NativeTypeName("LPCWSTR")] ushort* pTopicName,
            [NativeTypeName("DWORD")] uint eAdaptationSettings,
            SPADAPTATIONRELEVANCE eRelevance
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetGrammarOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetGrammarOptions;

        [NativeTypeName(
            "HRESULT (LPCWSTR, const ULONG, LPCWSTR, DWORD, SPADAPTATIONRELEVANCE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            ushort*,
            uint,
            SPADAPTATIONRELEVANCE,
            int> SetAdaptationData2;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpRecoContext2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpRecoContext2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpRecoContext2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpRecoContext2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpRecoContext2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpRecoContext2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpRecoContext2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpRecoContext2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
