// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IRestrictedErrorInfo.xml' path='doc/member[@name="IRestrictedErrorInfo"]/*'/>
[Guid("82BA7092-4C88-427D-A7BC-16DD93FEB67E")]
[NativeTypeName("struct IRestrictedErrorInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IRestrictedErrorInfo : IRestrictedErrorInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRestrictedErrorInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo*, Guid*, void**, int> )(lpVtbl[0]))((IRestrictedErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo*, uint> )(lpVtbl[1]))((IRestrictedErrorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo*, uint> )(lpVtbl[2]))((IRestrictedErrorInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRestrictedErrorInfo.xml' path='doc/member[@name="IRestrictedErrorInfo.GetErrorDetails"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetErrorDetails([NativeTypeName("BSTR *")] ushort** description, HRESULT* error, [NativeTypeName("BSTR *")] ushort** restrictedDescription, [NativeTypeName("BSTR *")] ushort** capabilitySid)
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo*, ushort**, HRESULT*, ushort**, ushort**, int> )(lpVtbl[3]))((IRestrictedErrorInfo*)Unsafe.AsPointer(ref this), description, error, restrictedDescription, capabilitySid);
    }

    /// <include file='IRestrictedErrorInfo.xml' path='doc/member[@name="IRestrictedErrorInfo.GetReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetReference([NativeTypeName("BSTR *")] ushort** reference)
    {
        return ((delegate* unmanaged<IRestrictedErrorInfo*, ushort**, int> )(lpVtbl[4]))((IRestrictedErrorInfo*)Unsafe.AsPointer(ref this), reference);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetErrorDetails([NativeTypeName("BSTR *")] ushort** description, HRESULT* error, [NativeTypeName("BSTR *")] ushort** restrictedDescription, [NativeTypeName("BSTR *")] ushort** capabilitySid);
        [VtblIndex(4)]
        HRESULT GetReference([NativeTypeName("BSTR *")] ushort** reference);
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
        [NativeTypeName("HRESULT (BSTR *, HRESULT *, BSTR *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, HRESULT*, ushort**, ushort**, int> GetErrorDetails;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetReference;
    }
}