// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("04B825B1-AC9A-4F7B-B5AD-C7168F1EE445")]
[NativeTypeName("struct ITfFnLMInternal : ITfFnLMProcessor")]
[NativeInheritance("ITfFnLMProcessor")]
public unsafe partial struct ITfFnLMInternal : ITfFnLMInternal.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnLMInternal));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfFnLMInternal, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnLMInternal, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryRange(ITfRange pRange, ITfRange* ppNewRange, BOOL* pfAccepted)
    {
        return (
            (delegate* unmanaged<ITfFnLMInternal, ITfRange, ITfRange*, BOOL*, int>)((*lpVtbl)[4])
        )(this, pRange, ppNewRange, pfAccepted);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryLangID([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccepted)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, ushort, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            langid,
            pfAccepted
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetReconversion(ITfRange pRange, ITfCandidateList* ppCandList)
    {
        return (
            (delegate* unmanaged<ITfFnLMInternal, ITfRange, ITfCandidateList*, int>)((*lpVtbl)[6])
        )(this, pRange, ppCandList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reconvert(ITfRange pRange)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, ITfRange, int>)((*lpVtbl)[7]))(this, pRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeydata, BOOL* pfInterested)
    {
        return (
            (delegate* unmanaged<ITfFnLMInternal, BOOL, WPARAM, LPARAM, BOOL*, int>)((*lpVtbl)[8])
        )(this, fUp, vKey, lparamKeydata, pfInterested);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvokeKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeyData)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, BOOL, WPARAM, LPARAM, int>)((*lpVtbl)[9]))(
            this,
            fUp,
            vKey,
            lparamKeyData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InvokeFunc(ITfContext pic, [NativeTypeName("const GUID &")] Guid* refguidFunc)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, ITfContext, Guid*, int>)((*lpVtbl)[10]))(
            this,
            pic,
            refguidFunc
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProcessLattice(ITfRange pRange)
    {
        return ((delegate* unmanaged<ITfFnLMInternal, ITfRange, int>)((*lpVtbl)[11]))(this, pRange);
    }

    public interface Interface : ITfFnLMProcessor.Interface
    {
        [VtblIndex(11)]
        HRESULT ProcessLattice(ITfRange pRange);
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

        [NativeTypeName("HRESULT (ITfRange *, ITfRange **, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, ITfRange*, BOOL*, int> QueryRange;

        [NativeTypeName("HRESULT (LANGID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, BOOL*, int> QueryLangID;

        [NativeTypeName("HRESULT (ITfRange *, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, ITfCandidateList*, int> GetReconversion;

        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, int> Reconvert;

        [NativeTypeName("HRESULT (BOOL, WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, WPARAM, LPARAM, BOOL*, int> QueryKey;

        [NativeTypeName("HRESULT (BOOL, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, WPARAM, LPARAM, int> InvokeKey;

        [NativeTypeName("HRESULT (ITfContext *, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext, Guid*, int> InvokeFunc;

        [NativeTypeName("HRESULT (ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, int> ProcessLattice;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnLMInternal"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnLMInternal(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFnLMProcessor"/> to <see cref = "ITfFnLMInternal"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFnLMProcessor"/> instance to be converted </param>
    public static explicit operator ITfFnLMInternal(Silk.NET.Windows.ITfFnLMProcessor value)
    {
        return new ITfFnLMInternal(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLMInternal"/> to <see cref = "Silk.NET.Windows.ITfFnLMProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLMInternal"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFnLMProcessor(ITfFnLMInternal value)
    {
        return new Silk.NET.Windows.ITfFnLMProcessor(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnLMInternal"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnLMInternal(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnLMInternal(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLMInternal"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLMInternal"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnLMInternal value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnLMInternal"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnLMInternal(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnLMInternal(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLMInternal"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLMInternal"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnLMInternal value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
