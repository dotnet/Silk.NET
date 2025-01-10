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

[Guid("F329791D-540B-4A9F-BC75-3282B7D73193")]
[NativeTypeName("struct IAppxSourceContentGroupMapReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxSourceContentGroupMapReader
    : IAppxSourceContentGroupMapReader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxSourceContentGroupMapReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxSourceContentGroupMapReader, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRequiredGroup(IAppxContentGroup* requiredGroup)
    {
        return (
            (delegate* unmanaged<IAppxSourceContentGroupMapReader, IAppxContentGroup*, int>)(
                (*lpVtbl)[3]
            )
        )(this, requiredGroup);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator* automaticGroupsEnumerator)
    {
        return (
            (delegate* unmanaged<
                IAppxSourceContentGroupMapReader,
                IAppxContentGroupsEnumerator*,
                int>)((*lpVtbl)[4])
        )(this, automaticGroupsEnumerator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRequiredGroup(IAppxContentGroup* requiredGroup);

        [VtblIndex(4)]
        HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator* automaticGroupsEnumerator);
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

        [NativeTypeName("HRESULT (IAppxContentGroup **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxContentGroup*, int> GetRequiredGroup;

        [NativeTypeName("HRESULT (IAppxContentGroupsEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxContentGroupsEnumerator*, int> GetAutomaticGroups;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxSourceContentGroupMapReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxSourceContentGroupMapReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxSourceContentGroupMapReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxSourceContentGroupMapReader(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxSourceContentGroupMapReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxSourceContentGroupMapReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxSourceContentGroupMapReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxSourceContentGroupMapReader value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
