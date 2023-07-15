// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFNetResourceFilter.xml' path='doc/member[@name="IMFNetResourceFilter"]/*'/>
[Guid("091878A3-BF11-4A5C-BC9F-33995B06EF2D")]
[NativeTypeName("struct IMFNetResourceFilter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFNetResourceFilter : IMFNetResourceFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetResourceFilter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetResourceFilter*, Guid*, void**, int> )(lpVtbl[0]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFNetResourceFilter*, uint> )(lpVtbl[1]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetResourceFilter*, uint> )(lpVtbl[2]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFNetResourceFilter.xml' path='doc/member[@name="IMFNetResourceFilter.OnRedirect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnRedirect([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("VARIANT_BOOL *")] short* pvbCancel)
    {
        return ((delegate* unmanaged<IMFNetResourceFilter*, ushort*, short*, int> )(lpVtbl[3]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), pszUrl, pvbCancel);
    }

    /// <include file='IMFNetResourceFilter.xml' path='doc/member[@name="IMFNetResourceFilter.OnSendingRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnSendingRequest([NativeTypeName("LPCWSTR")] ushort* pszUrl)
    {
        return ((delegate* unmanaged<IMFNetResourceFilter*, ushort*, int> )(lpVtbl[4]))((IMFNetResourceFilter*)Unsafe.AsPointer(ref this), pszUrl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnRedirect([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("VARIANT_BOOL *")] short* pvbCancel);
        [VtblIndex(4)]
        HRESULT OnSendingRequest([NativeTypeName("LPCWSTR")] ushort* pszUrl);
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
        [NativeTypeName("HRESULT (LPCWSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> OnRedirect;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OnSendingRequest;
    }
}