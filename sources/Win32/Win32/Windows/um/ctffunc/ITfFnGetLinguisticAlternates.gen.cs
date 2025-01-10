// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EA163CE2-7A65-4506-82A3-C528215DA64E")]
[NativeTypeName("struct ITfFnGetLinguisticAlternates : ITfFunction")]
[NativeInheritance("ITfFunction")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct ITfFnGetLinguisticAlternates
    : ITfFnGetLinguisticAlternates.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnGetLinguisticAlternates));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfFnGetLinguisticAlternates, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnGetLinguisticAlternates, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnGetLinguisticAlternates, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnGetLinguisticAlternates, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAlternates(ITfRange pRange, ITfCandidateList* ppCandidateList)
    {
        return (
            (delegate* unmanaged<ITfFnGetLinguisticAlternates, ITfRange, ITfCandidateList*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pRange, ppCandidateList);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetAlternates(ITfRange pRange, ITfCandidateList* ppCandidateList);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (ITfRange *, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, ITfCandidateList*, int> GetAlternates;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnGetLinguisticAlternates"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnGetLinguisticAlternates(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnGetLinguisticAlternates"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnGetLinguisticAlternates(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnGetLinguisticAlternates(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnGetLinguisticAlternates"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnGetLinguisticAlternates"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnGetLinguisticAlternates value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnGetLinguisticAlternates"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnGetLinguisticAlternates(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnGetLinguisticAlternates(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnGetLinguisticAlternates"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnGetLinguisticAlternates"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnGetLinguisticAlternates value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
