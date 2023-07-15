// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxSourceContentGroupMapReader.xml' path='doc/member[@name="IAppxSourceContentGroupMapReader"]/*'/>
[Guid("F329791D-540B-4A9F-BC75-3282B7D73193")]
[NativeTypeName("struct IAppxSourceContentGroupMapReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxSourceContentGroupMapReader : IAppxSourceContentGroupMapReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxSourceContentGroupMapReader));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, Guid*, void**, int> )(lpVtbl[0]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, uint> )(lpVtbl[1]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, uint> )(lpVtbl[2]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxSourceContentGroupMapReader.xml' path='doc/member[@name="IAppxSourceContentGroupMapReader.GetRequiredGroup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRequiredGroup(IAppxContentGroup** requiredGroup)
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, IAppxContentGroup**, int> )(lpVtbl[3]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this), requiredGroup);
    }

    /// <include file='IAppxSourceContentGroupMapReader.xml' path='doc/member[@name="IAppxSourceContentGroupMapReader.GetAutomaticGroups"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator** automaticGroupsEnumerator)
    {
        return ((delegate* unmanaged<IAppxSourceContentGroupMapReader*, IAppxContentGroupsEnumerator**, int> )(lpVtbl[4]))((IAppxSourceContentGroupMapReader*)Unsafe.AsPointer(ref this), automaticGroupsEnumerator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRequiredGroup(IAppxContentGroup** requiredGroup);
        [VtblIndex(4)]
        HRESULT GetAutomaticGroups(IAppxContentGroupsEnumerator** automaticGroupsEnumerator);
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
        public delegate* unmanaged<TSelf*, IAppxContentGroup**, int> GetRequiredGroup;
        [NativeTypeName("HRESULT (IAppxContentGroupsEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxContentGroupsEnumerator**, int> GetAutomaticGroups;
    }
}