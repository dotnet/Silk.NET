// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxBlockMapBlock.xml' path='doc/member[@name="IAppxBlockMapBlock"]/*'/>
[Guid("75CF3930-3244-4FE0-A8C8-E0BCB270B889")]
[NativeTypeName("struct IAppxBlockMapBlock : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxBlockMapBlock : IAppxBlockMapBlock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBlockMapBlock));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlock*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBlockMapBlock*, uint> )(lpVtbl[1]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBlockMapBlock*, uint> )(lpVtbl[2]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBlockMapBlock.xml' path='doc/member[@name="IAppxBlockMapBlock.GetHash"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetHash([NativeTypeName("UINT32 *")] uint* bufferSize, byte** buffer)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlock*, uint*, byte**, int> )(lpVtbl[3]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this), bufferSize, buffer);
    }

    /// <include file='IAppxBlockMapBlock.xml' path='doc/member[@name="IAppxBlockMapBlock.GetCompressedSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCompressedSize([NativeTypeName("UINT32 *")] uint* size)
    {
        return ((delegate* unmanaged<IAppxBlockMapBlock*, uint*, int> )(lpVtbl[4]))((IAppxBlockMapBlock*)Unsafe.AsPointer(ref this), size);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetHash([NativeTypeName("UINT32 *")] uint* bufferSize, byte** buffer);
        [VtblIndex(4)]
        HRESULT GetCompressedSize([NativeTypeName("UINT32 *")] uint* size);
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
        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetHash;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCompressedSize;
    }
}