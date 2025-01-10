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

[Guid("87A2AD8F-F27B-4920-8501-67602280175D")]
[NativeTypeName("struct ITfFnSearchCandidateProvider : ITfFunction")]
[NativeInheritance("ITfFunction")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITfFnSearchCandidateProvider
    : ITfFnSearchCandidateProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnSearchCandidateProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfFnSearchCandidateProvider, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnSearchCandidateProvider, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSearchCandidates(
        [NativeTypeName("BSTR")] ushort* bstrQuery,
        [NativeTypeName("BSTR")] ushort* bstrApplicationId,
        ITfCandidateList* pplist
    )
    {
        return (
            (delegate* unmanaged<
                ITfFnSearchCandidateProvider,
                ushort*,
                ushort*,
                ITfCandidateList*,
                int>)((*lpVtbl)[4])
        )(this, bstrQuery, bstrApplicationId, pplist);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetResult(
        [NativeTypeName("BSTR")] ushort* bstrQuery,
        [NativeTypeName("BSTR")] ushort* bstrApplicationID,
        [NativeTypeName("BSTR")] ushort* bstrResult
    )
    {
        return (
            (delegate* unmanaged<ITfFnSearchCandidateProvider, ushort*, ushort*, ushort*, int>)(
                (*lpVtbl)[5]
            )
        )(this, bstrQuery, bstrApplicationID, bstrResult);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetSearchCandidates(
            [NativeTypeName("BSTR")] ushort* bstrQuery,
            [NativeTypeName("BSTR")] ushort* bstrApplicationId,
            ITfCandidateList* pplist
        );

        [VtblIndex(5)]
        HRESULT SetResult(
            [NativeTypeName("BSTR")] ushort* bstrQuery,
            [NativeTypeName("BSTR")] ushort* bstrApplicationID,
            [NativeTypeName("BSTR")] ushort* bstrResult
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (BSTR, BSTR, ITfCandidateList **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ITfCandidateList*,
            int> GetSearchCandidates;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> SetResult;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnSearchCandidateProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnSearchCandidateProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnSearchCandidateProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnSearchCandidateProvider(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnSearchCandidateProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnSearchCandidateProvider"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnSearchCandidateProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnSearchCandidateProvider value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnSearchCandidateProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnSearchCandidateProvider(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnSearchCandidateProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnSearchCandidateProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnSearchCandidateProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnSearchCandidateProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
