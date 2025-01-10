// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7AFBF8E7-AC4B-4082-B058-890899D3A010")]
[NativeTypeName("struct ITfFnLMProcessor : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnLMProcessor : ITfFnLMProcessor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnLMProcessor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnLMProcessor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfFnLMProcessor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnLMProcessor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnLMProcessor, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryRange(ITfRange pRange, ITfRange* ppNewRange, BOOL* pfAccepted)
    {
        return (
            (delegate* unmanaged<ITfFnLMProcessor, ITfRange, ITfRange*, BOOL*, int>)((*lpVtbl)[4])
        )(this, pRange, ppNewRange, pfAccepted);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT QueryLangID([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccepted)
    {
        return ((delegate* unmanaged<ITfFnLMProcessor, ushort, BOOL*, int>)((*lpVtbl)[5]))(
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
            (delegate* unmanaged<ITfFnLMProcessor, ITfRange, ITfCandidateList*, int>)((*lpVtbl)[6])
        )(this, pRange, ppCandList);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reconvert(ITfRange pRange)
    {
        return ((delegate* unmanaged<ITfFnLMProcessor, ITfRange, int>)((*lpVtbl)[7]))(this, pRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT QueryKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeydata, BOOL* pfInterested)
    {
        return (
            (delegate* unmanaged<ITfFnLMProcessor, BOOL, WPARAM, LPARAM, BOOL*, int>)((*lpVtbl)[8])
        )(this, fUp, vKey, lparamKeydata, pfInterested);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvokeKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeyData)
    {
        return ((delegate* unmanaged<ITfFnLMProcessor, BOOL, WPARAM, LPARAM, int>)((*lpVtbl)[9]))(
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
        return ((delegate* unmanaged<ITfFnLMProcessor, ITfContext, Guid*, int>)((*lpVtbl)[10]))(
            this,
            pic,
            refguidFunc
        );
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT QueryRange(ITfRange pRange, ITfRange* ppNewRange, BOOL* pfAccepted);

        [VtblIndex(5)]
        HRESULT QueryLangID([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccepted);

        [VtblIndex(6)]
        HRESULT GetReconversion(ITfRange pRange, ITfCandidateList* ppCandList);

        [VtblIndex(7)]
        HRESULT Reconvert(ITfRange pRange);

        [VtblIndex(8)]
        HRESULT QueryKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeydata, BOOL* pfInterested);

        [VtblIndex(9)]
        HRESULT InvokeKey(BOOL fUp, WPARAM vKey, LPARAM lparamKeyData);

        [VtblIndex(10)]
        HRESULT InvokeFunc(ITfContext pic, [NativeTypeName("const GUID &")] Guid* refguidFunc);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnLMProcessor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnLMProcessor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnLMProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnLMProcessor(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnLMProcessor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLMProcessor"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLMProcessor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnLMProcessor value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnLMProcessor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnLMProcessor(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnLMProcessor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLMProcessor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLMProcessor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnLMProcessor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
