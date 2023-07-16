// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITrackingProtection.xml' path='doc/member[@name="ITrackingProtection"]/*'/>
[Guid("30510803-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ITrackingProtection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITrackingProtection : ITrackingProtection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITrackingProtection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITrackingProtection*, Guid*, void**, int> )(lpVtbl[0]))((ITrackingProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITrackingProtection*, uint> )(lpVtbl[1]))((ITrackingProtection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITrackingProtection*, uint> )(lpVtbl[2]))((ITrackingProtection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITrackingProtection.xml' path='doc/member[@name="ITrackingProtection.EvaluateUrl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EvaluateUrl([NativeTypeName("BSTR")] ushort* bstrUrl, BOOL* pfAllowed)
    {
        return ((delegate* unmanaged<ITrackingProtection*, ushort*, BOOL*, int> )(lpVtbl[3]))((ITrackingProtection*)Unsafe.AsPointer(ref this), bstrUrl, pfAllowed);
    }

    /// <include file='ITrackingProtection.xml' path='doc/member[@name="ITrackingProtection.GetEnabled"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnabled(BOOL* pfEnabled)
    {
        return ((delegate* unmanaged<ITrackingProtection*, BOOL*, int> )(lpVtbl[4]))((ITrackingProtection*)Unsafe.AsPointer(ref this), pfEnabled);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EvaluateUrl([NativeTypeName("BSTR")] ushort* bstrUrl, BOOL* pfAllowed);
        [VtblIndex(4)]
        HRESULT GetEnabled(BOOL* pfEnabled);
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
        [NativeTypeName("HRESULT (BSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> EvaluateUrl;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetEnabled;
    }
}