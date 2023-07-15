// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAMCopyCaptureFileProgress.xml' path='doc/member[@name="IAMCopyCaptureFileProgress"]/*'/>
[Guid("670D1D20-A068-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct IAMCopyCaptureFileProgress : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMCopyCaptureFileProgress : IAMCopyCaptureFileProgress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMCopyCaptureFileProgress));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, Guid*, void**, int> )(lpVtbl[0]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, uint> )(lpVtbl[1]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, uint> )(lpVtbl[2]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMCopyCaptureFileProgress.xml' path='doc/member[@name="IAMCopyCaptureFileProgress.Progress"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Progress(int iProgress)
    {
        return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, int, int> )(lpVtbl[3]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this), iProgress);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Progress(int iProgress);
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
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> Progress;
    }
}