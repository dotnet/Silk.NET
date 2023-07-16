// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioSourceProvider.xml' path='doc/member[@name="IAudioSourceProvider"]/*'/>
[Guid("EBBAF249-AFC2-4582-91C6-B60DF2E84954")]
[NativeTypeName("struct IAudioSourceProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSourceProvider : IAudioSourceProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSourceProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSourceProvider*, Guid*, void**, int> )(lpVtbl[0]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSourceProvider*, uint> )(lpVtbl[1]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSourceProvider*, uint> )(lpVtbl[2]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSourceProvider.xml' path='doc/member[@name="IAudioSourceProvider.ProvideInput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ProvideInput([NativeTypeName("DWORD")] uint dwSampleCount, [NativeTypeName("DWORD *")] uint* pdwChannelCount, float* pInterleavedAudioData)
    {
        return ((delegate* unmanaged<IAudioSourceProvider*, uint, uint*, float*, int> )(lpVtbl[3]))((IAudioSourceProvider*)Unsafe.AsPointer(ref this), dwSampleCount, pdwChannelCount, pInterleavedAudioData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ProvideInput([NativeTypeName("DWORD")] uint dwSampleCount, [NativeTypeName("DWORD *")] uint* pdwChannelCount, float* pInterleavedAudioData);
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
        [NativeTypeName("HRESULT (DWORD, DWORD *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, float*, int> ProvideInput;
    }
}