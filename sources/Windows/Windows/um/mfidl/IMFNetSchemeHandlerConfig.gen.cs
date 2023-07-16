// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFNetSchemeHandlerConfig.xml' path='doc/member[@name="IMFNetSchemeHandlerConfig"]/*'/>
[Guid("7BE19E73-C9BF-468A-AC5A-A5E8653BEC87")]
[NativeTypeName("struct IMFNetSchemeHandlerConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetSchemeHandlerConfig : IMFNetSchemeHandlerConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetSchemeHandlerConfig));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, Guid*, void**, int> )(lpVtbl[0]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint> )(lpVtbl[1]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint> )(lpVtbl[2]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFNetSchemeHandlerConfig.xml' path='doc/member[@name="IMFNetSchemeHandlerConfig.GetNumberOfSupportedProtocols"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNumberOfSupportedProtocols([NativeTypeName("ULONG *")] uint* pcProtocols)
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint*, int> )(lpVtbl[3]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this), pcProtocols);
    }

    /// <include file='IMFNetSchemeHandlerConfig.xml' path='doc/member[@name="IMFNetSchemeHandlerConfig.GetSupportedProtocolType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSupportedProtocolType([NativeTypeName("ULONG")] uint nProtocolIndex, MFNETSOURCE_PROTOCOL_TYPE* pnProtocolType)
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, uint, MFNETSOURCE_PROTOCOL_TYPE*, int> )(lpVtbl[4]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this), nProtocolIndex, pnProtocolType);
    }

    /// <include file='IMFNetSchemeHandlerConfig.xml' path='doc/member[@name="IMFNetSchemeHandlerConfig.ResetProtocolRolloverSettings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ResetProtocolRolloverSettings()
    {
        return ((delegate* unmanaged<IMFNetSchemeHandlerConfig*, int> )(lpVtbl[5]))((IMFNetSchemeHandlerConfig*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNumberOfSupportedProtocols([NativeTypeName("ULONG *")] uint* pcProtocols);
        [VtblIndex(4)]
        HRESULT GetSupportedProtocolType([NativeTypeName("ULONG")] uint nProtocolIndex, MFNETSOURCE_PROTOCOL_TYPE* pnProtocolType);
        [VtblIndex(5)]
        HRESULT ResetProtocolRolloverSettings();
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
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfSupportedProtocols;
        [NativeTypeName("HRESULT (ULONG, MFNETSOURCE_PROTOCOL_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, MFNETSOURCE_PROTOCOL_TYPE*, int> GetSupportedProtocolType;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetProtocolRolloverSettings;
    }
}