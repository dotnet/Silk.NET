// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSourceBufferList.xml' path='doc/member[@name="IMFSourceBufferList"]/*'/>
[Guid("249981F8-8325-41F3-B80C-3B9E3AAD0CBE")]
[NativeTypeName("struct IMFSourceBufferList : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFSourceBufferList : IMFSourceBufferList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSourceBufferList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSourceBufferList*, Guid*, void**, int> )(lpVtbl[0]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSourceBufferList*, uint> )(lpVtbl[1]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSourceBufferList*, uint> )(lpVtbl[2]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBufferList.xml' path='doc/member[@name="IMFSourceBufferList.GetLength"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFSourceBufferList*, uint> )(lpVtbl[3]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSourceBufferList.xml' path='doc/member[@name="IMFSourceBufferList.GetSourceBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint index)
    {
        return ((delegate* unmanaged<IMFSourceBufferList*, uint, IMFSourceBuffer*> )(lpVtbl[4]))((IMFSourceBufferList*)Unsafe.AsPointer(ref this), index);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();
        [VtblIndex(4)]
        IMFSourceBuffer* GetSourceBuffer([NativeTypeName("DWORD")] uint index);
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
        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLength;
        [NativeTypeName("IMFSourceBuffer *(DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFSourceBuffer*> GetSourceBuffer;
    }
}