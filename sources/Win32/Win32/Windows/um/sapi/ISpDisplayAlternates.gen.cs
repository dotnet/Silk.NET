// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C8D7C7E2-0DDE-44B7-AFE3-B0C991FBEB5E")]
[NativeTypeName("struct ISpDisplayAlternates : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpDisplayAlternates : ISpDisplayAlternates.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpDisplayAlternates));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpDisplayAlternates, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpDisplayAlternates, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpDisplayAlternates, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayAlternates(
        [NativeTypeName("const SPDISPLAYPHRASE *")] SPDISPLAYPHRASE* pPhrase,
        [NativeTypeName("ULONG")] uint cRequestCount,
        SPDISPLAYPHRASE** ppCoMemPhrases,
        [NativeTypeName("ULONG *")] uint* pcPhrasesReturned
    )
    {
        return (
            (delegate* unmanaged<
                ISpDisplayAlternates,
                SPDISPLAYPHRASE*,
                uint,
                SPDISPLAYPHRASE**,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, pPhrase, cRequestCount, ppCoMemPhrases, pcPhrasesReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFullStopTrailSpace([NativeTypeName("ULONG")] uint ulTrailSpace)
    {
        return ((delegate* unmanaged<ISpDisplayAlternates, uint, int>)((*lpVtbl)[4]))(
            this,
            ulTrailSpace
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDisplayAlternates(
            [NativeTypeName("const SPDISPLAYPHRASE *")] SPDISPLAYPHRASE* pPhrase,
            [NativeTypeName("ULONG")] uint cRequestCount,
            SPDISPLAYPHRASE** ppCoMemPhrases,
            [NativeTypeName("ULONG *")] uint* pcPhrasesReturned
        );

        [VtblIndex(4)]
        HRESULT SetFullStopTrailSpace([NativeTypeName("ULONG")] uint ulTrailSpace);
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
            "HRESULT (const SPDISPLAYPHRASE *, ULONG, SPDISPLAYPHRASE **, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SPDISPLAYPHRASE*,
            uint,
            SPDISPLAYPHRASE**,
            uint*,
            int> GetDisplayAlternates;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetFullStopTrailSpace;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpDisplayAlternates"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpDisplayAlternates(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpDisplayAlternates"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpDisplayAlternates(Silk.NET.Windows.IUnknown value)
    {
        return new ISpDisplayAlternates(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpDisplayAlternates"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpDisplayAlternates"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpDisplayAlternates value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
