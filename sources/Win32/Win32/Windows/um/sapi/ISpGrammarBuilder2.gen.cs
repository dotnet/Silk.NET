// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8AB10026-20CC-4B20-8C22-A49C9BA78F60")]
[NativeTypeName("struct ISpGrammarBuilder2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpGrammarBuilder2 : ISpGrammarBuilder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpGrammarBuilder2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpGrammarBuilder2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpGrammarBuilder2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddTextSubset(
        SPSTATEHANDLE hFromState,
        SPSTATEHANDLE hToState,
        [NativeTypeName("LPCWSTR")] ushort* psz,
        SPMATCHINGMODE eMatchMode
    )
    {
        return (
            (delegate* unmanaged<
                ISpGrammarBuilder2,
                SPSTATEHANDLE,
                SPSTATEHANDLE,
                ushort*,
                SPMATCHINGMODE,
                int>)((*lpVtbl)[3])
        )(this, hFromState, hToState, psz, eMatchMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPhoneticAlphabet(PHONETICALPHABET phoneticALphabet)
    {
        return ((delegate* unmanaged<ISpGrammarBuilder2, PHONETICALPHABET, int>)((*lpVtbl)[4]))(
            this,
            phoneticALphabet
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddTextSubset(
            SPSTATEHANDLE hFromState,
            SPSTATEHANDLE hToState,
            [NativeTypeName("LPCWSTR")] ushort* psz,
            SPMATCHINGMODE eMatchMode
        );

        [VtblIndex(4)]
        HRESULT SetPhoneticAlphabet(PHONETICALPHABET phoneticALphabet);
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
            "HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, LPCWSTR, SPMATCHINGMODE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPSTATEHANDLE,
            SPSTATEHANDLE,
            ushort*,
            SPMATCHINGMODE,
            int> AddTextSubset;

        [NativeTypeName("HRESULT (PHONETICALPHABET) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PHONETICALPHABET, int> SetPhoneticAlphabet;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpGrammarBuilder2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpGrammarBuilder2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpGrammarBuilder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpGrammarBuilder2(Silk.NET.Windows.IUnknown value)
    {
        return new ISpGrammarBuilder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpGrammarBuilder2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpGrammarBuilder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpGrammarBuilder2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
