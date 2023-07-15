// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxManifestDeviceCapabilitiesEnumerator.xml' path='doc/member[@name="IAppxManifestDeviceCapabilitiesEnumerator"]/*'/>
[Guid("30204541-427B-4A1C-BACF-655BF463A540")]
[NativeTypeName("struct IAppxManifestDeviceCapabilitiesEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestDeviceCapabilitiesEnumerator : IAppxManifestDeviceCapabilitiesEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestDeviceCapabilitiesEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, uint> )(lpVtbl[1]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, uint> )(lpVtbl[2]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxManifestDeviceCapabilitiesEnumerator.xml' path='doc/member[@name="IAppxManifestDeviceCapabilitiesEnumerator.GetCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrent([NativeTypeName("LPWSTR *")] ushort** deviceCapability)
    {
        return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, ushort**, int> )(lpVtbl[3]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), deviceCapability);
    }

    /// <include file='IAppxManifestDeviceCapabilitiesEnumerator.xml' path='doc/member[@name="IAppxManifestDeviceCapabilitiesEnumerator.GetHasCurrent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHasCurrent(BOOL* hasCurrent)
    {
        return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, BOOL*, int> )(lpVtbl[4]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasCurrent);
    }

    /// <include file='IAppxManifestDeviceCapabilitiesEnumerator.xml' path='doc/member[@name="IAppxManifestDeviceCapabilitiesEnumerator.MoveNext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MoveNext(BOOL* hasNext)
    {
        return ((delegate* unmanaged<IAppxManifestDeviceCapabilitiesEnumerator*, BOOL*, int> )(lpVtbl[5]))((IAppxManifestDeviceCapabilitiesEnumerator*)Unsafe.AsPointer(ref this), hasNext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrent([NativeTypeName("LPWSTR *")] ushort** deviceCapability);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetHasCurrent;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> MoveNext;
    }
}