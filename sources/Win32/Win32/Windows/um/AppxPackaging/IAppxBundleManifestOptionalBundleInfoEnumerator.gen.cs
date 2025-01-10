// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9A178793-F97E-46AC-AACA-DD5BA4C177C8")]
[NativeTypeName("struct IAppxBundleManifestOptionalBundleInfoEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestOptionalBundleInfoEnumerator
    : IAppxBundleManifestOptionalBundleInfoEnumerator.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IAppxBundleManifestOptionalBundleInfoEnumerator)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IAppxBundleManifestOptionalBundleInfoEnumerator,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxBundleManifestOptionalBundleInfo* optionalBundle)
    {
        return (
            (delegate* unmanaged<
                IAppxBundleManifestOptionalBundleInfoEnumerator,
                IAppxBundleManifestOptionalBundleInfo*,
                int>)((*lpVtbl)[3])
        )(this, optionalBundle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator, BOOL*, int>)(
                (*lpVtbl)[4]
            )
        )(this, hasCurrent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestOptionalBundleInfoEnumerator, BOOL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxBundleManifestOptionalBundleInfo* optionalBundle);

        [VtblIndex(4)]
        HRESULT GetHasCurrent(BOOL* hasCurrent);

        [VtblIndex(5)]
        HRESULT MoveNext(BOOL* hasNext);
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
            "HRESULT (IAppxBundleManifestOptionalBundleInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestOptionalBundleInfo*, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleManifestOptionalBundleInfoEnumerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleManifestOptionalBundleInfoEnumerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleManifestOptionalBundleInfoEnumerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleManifestOptionalBundleInfoEnumerator(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxBundleManifestOptionalBundleInfoEnumerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleManifestOptionalBundleInfoEnumerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleManifestOptionalBundleInfoEnumerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxBundleManifestOptionalBundleInfoEnumerator value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
