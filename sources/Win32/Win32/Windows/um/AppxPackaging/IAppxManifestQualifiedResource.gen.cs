// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3B53A497-3C5C-48D1-9EA3-BB7EAC8CD7D4")]
[NativeTypeName("struct IAppxManifestQualifiedResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestQualifiedResource
    : IAppxManifestQualifiedResource.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestQualifiedResource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResource, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** language)
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResource, ushort**, int>)((*lpVtbl)[3]))(
            this,
            language
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetScale([NativeTypeName("UINT32 *")] uint* scale)
    {
        return ((delegate* unmanaged<IAppxManifestQualifiedResource, uint*, int>)((*lpVtbl)[4]))(
            this,
            scale
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDXFeatureLevel(DX_FEATURE_LEVEL* dxFeatureLevel)
    {
        return (
            (delegate* unmanaged<IAppxManifestQualifiedResource, DX_FEATURE_LEVEL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, dxFeatureLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLanguage([NativeTypeName("LPWSTR *")] ushort** language);

        [VtblIndex(4)]
        HRESULT GetScale([NativeTypeName("UINT32 *")] uint* scale);

        [VtblIndex(5)]
        HRESULT GetDXFeatureLevel(DX_FEATURE_LEVEL* dxFeatureLevel);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLanguage;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetScale;

        [NativeTypeName("HRESULT (DX_FEATURE_LEVEL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DX_FEATURE_LEVEL*, int> GetDXFeatureLevel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestQualifiedResource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestQualifiedResource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestQualifiedResource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestQualifiedResource(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxManifestQualifiedResource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestQualifiedResource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestQualifiedResource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxManifestQualifiedResource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
