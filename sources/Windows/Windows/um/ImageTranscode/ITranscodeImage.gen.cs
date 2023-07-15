// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ImageTranscode.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITranscodeImage.xml' path='doc/member[@name="ITranscodeImage"]/*'/>
[Guid("BAE86DDD-DC11-421C-B7AB-CC55D1D65C44")]
[NativeTypeName("struct ITranscodeImage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITranscodeImage : ITranscodeImage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITranscodeImage));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITranscodeImage*, Guid*, void**, int> )(lpVtbl[0]))((ITranscodeImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITranscodeImage*, uint> )(lpVtbl[1]))((ITranscodeImage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITranscodeImage*, uint> )(lpVtbl[2]))((ITranscodeImage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITranscodeImage.xml' path='doc/member[@name="ITranscodeImage.TranscodeImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TranscodeImage(IShellItem* pShellItem, uint uiMaxWidth, uint uiMaxHeight, [NativeTypeName("DWORD")] uint flags, IStream* pvImage, uint* puiWidth, uint* puiHeight)
    {
        return ((delegate* unmanaged<ITranscodeImage*, IShellItem*, uint, uint, uint, IStream*, uint*, uint*, int> )(lpVtbl[3]))((ITranscodeImage*)Unsafe.AsPointer(ref this), pShellItem, uiMaxWidth, uiMaxHeight, flags, pvImage, puiWidth, puiHeight);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TranscodeImage(IShellItem* pShellItem, uint uiMaxWidth, uint uiMaxHeight, [NativeTypeName("DWORD")] uint flags, IStream* pvImage, uint* puiWidth, uint* puiHeight);
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
        [NativeTypeName("HRESULT (IShellItem *, UINT, UINT, DWORD, IStream *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint, uint, uint, IStream*, uint*, uint*, int> TranscodeImage;
    }
}