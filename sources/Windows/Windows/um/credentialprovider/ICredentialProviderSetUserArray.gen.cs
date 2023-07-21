// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICredentialProviderSetUserArray.xml' path='doc/member[@name="ICredentialProviderSetUserArray"]/*' />
[Guid("095C1484-1C0C-4388-9C6D-500E61BF84BD")]
[NativeTypeName("struct ICredentialProviderSetUserArray : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ICredentialProviderSetUserArray : ICredentialProviderSetUserArray.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderSetUserArray));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderSetUserArray*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderSetUserArray*, uint>)(lpVtbl[1]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderSetUserArray*, uint>)(lpVtbl[2]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderSetUserArray.xml' path='doc/member[@name="ICredentialProviderSetUserArray.SetUserArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetUserArray(ICredentialProviderUserArray* users)
    {
        return ((delegate* unmanaged<ICredentialProviderSetUserArray*, ICredentialProviderUserArray*, int>)(lpVtbl[3]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this), users);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetUserArray(ICredentialProviderUserArray* users);
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

        [NativeTypeName("HRESULT (ICredentialProviderUserArray *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderUserArray*, int> SetUserArray;
    }
}
