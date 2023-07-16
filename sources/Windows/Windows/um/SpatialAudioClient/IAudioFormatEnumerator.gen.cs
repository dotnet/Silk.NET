// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioFormatEnumerator.xml' path='doc/member[@name="IAudioFormatEnumerator"]/*'/>
[Guid("DCDAA858-895A-4A22-A5EB-67BDA506096D")]
[NativeTypeName("struct IAudioFormatEnumerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioFormatEnumerator : IAudioFormatEnumerator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioFormatEnumerator));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, Guid*, void**, int> )(lpVtbl[0]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint> )(lpVtbl[1]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint> )(lpVtbl[2]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioFormatEnumerator.xml' path='doc/member[@name="IAudioFormatEnumerator.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* count)
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint*, int> )(lpVtbl[3]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), count);
    }

    /// <include file='IAudioFormatEnumerator.xml' path='doc/member[@name="IAudioFormatEnumerator.GetFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFormat([NativeTypeName("UINT32")] uint index, WAVEFORMATEX** format)
    {
        return ((delegate* unmanaged<IAudioFormatEnumerator*, uint, WAVEFORMATEX**, int> )(lpVtbl[4]))((IAudioFormatEnumerator*)Unsafe.AsPointer(ref this), index, format);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("UINT32 *")] uint* count);
        [VtblIndex(4)]
        HRESULT GetFormat([NativeTypeName("UINT32")] uint index, WAVEFORMATEX** format);
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
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (UINT32, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WAVEFORMATEX**, int> GetFormat;
    }
}