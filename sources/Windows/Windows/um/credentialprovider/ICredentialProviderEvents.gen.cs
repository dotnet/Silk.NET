// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICredentialProviderEvents.xml' path='doc/member[@name="ICredentialProviderEvents"]/*'/>
[Guid("34201E5A-A787-41A3-A5A4-BD6DCF2A854E")]
[NativeTypeName("struct ICredentialProviderEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICredentialProviderEvents : ICredentialProviderEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderEvents));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderEvents*, Guid*, void**, int> )(lpVtbl[0]))((ICredentialProviderEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderEvents*, uint> )(lpVtbl[1]))((ICredentialProviderEvents*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderEvents*, uint> )(lpVtbl[2]))((ICredentialProviderEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderEvents.xml' path='doc/member[@name="ICredentialProviderEvents.CredentialsChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CredentialsChanged([NativeTypeName("UINT_PTR")] nuint upAdviseContext)
    {
        return ((delegate* unmanaged<ICredentialProviderEvents*, nuint, int> )(lpVtbl[3]))((ICredentialProviderEvents*)Unsafe.AsPointer(ref this), upAdviseContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CredentialsChanged([NativeTypeName("UINT_PTR")] nuint upAdviseContext);
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
        [NativeTypeName("HRESULT (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> CredentialsChanged;
    }
}