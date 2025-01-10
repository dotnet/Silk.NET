// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8EF6ADFE-3762-4A8F-9373-2FC5D444C8D2")]
[NativeTypeName("struct IAppxManifestQualifiedResourcesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestQualifiedResourcesEnumerator
    : IAppxManifestQualifiedResourcesEnumerator.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestQualifiedResourcesEnumerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent(IAppxManifestQualifiedResource* resource)
    {
        return (
            (delegate* unmanaged<
                IAppxManifestQualifiedResourcesEnumerator,
                IAppxManifestQualifiedResource*,
                int>)((*lpVtbl)[3])
        )(this, resource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator, BOOL*, int>)(
                (*lpVtbl)[4]
            )
        )(this, hasCurrent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResourcesEnumerator, BOOL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent(IAppxManifestQualifiedResource* resource);

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

        [NativeTypeName("HRESULT (IAppxManifestQualifiedResource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestQualifiedResource*, int> GetCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestQualifiedResourcesEnumerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestQualifiedResourcesEnumerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestQualifiedResourcesEnumerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestQualifiedResourcesEnumerator(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxManifestQualifiedResourcesEnumerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestQualifiedResourcesEnumerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestQualifiedResourcesEnumerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxManifestQualifiedResourcesEnumerator value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
