// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IKsJackSinkInformation.xml' path='doc/member[@name="IKsJackSinkInformation"]/*'/>
[Guid("D9BD72ED-290F-4581-9FF3-61027A8FE532")]
[NativeTypeName("struct IKsJackSinkInformation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKsJackSinkInformation : IKsJackSinkInformation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IKsJackSinkInformation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKsJackSinkInformation*, Guid*, void**, int> )(lpVtbl[0]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKsJackSinkInformation*, uint> )(lpVtbl[1]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKsJackSinkInformation*, uint> )(lpVtbl[2]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IKsJackSinkInformation.xml' path='doc/member[@name="IKsJackSinkInformation.GetJackSinkInformation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetJackSinkInformation(KSJACK_SINK_INFORMATION* pJackSinkInformation)
    {
        return ((delegate* unmanaged<IKsJackSinkInformation*, KSJACK_SINK_INFORMATION*, int> )(lpVtbl[3]))((IKsJackSinkInformation*)Unsafe.AsPointer(ref this), pJackSinkInformation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetJackSinkInformation(KSJACK_SINK_INFORMATION* pJackSinkInformation);
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
        [NativeTypeName("HRESULT (KSJACK_SINK_INFORMATION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, KSJACK_SINK_INFORMATION*, int> GetJackSinkInformation;
    }
}