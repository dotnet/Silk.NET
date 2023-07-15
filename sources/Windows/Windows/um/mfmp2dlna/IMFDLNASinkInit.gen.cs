// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFDLNASinkInit.xml' path='doc/member[@name="IMFDLNASinkInit"]/*'/>
[Guid("0C012799-1B61-4C10-BDA9-04445BE5F561")]
[NativeTypeName("struct IMFDLNASinkInit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFDLNASinkInit : IMFDLNASinkInit.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFDLNASinkInit));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFDLNASinkInit*, Guid*, void**, int> )(lpVtbl[0]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFDLNASinkInit*, uint> )(lpVtbl[1]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFDLNASinkInit*, uint> )(lpVtbl[2]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFDLNASinkInit.xml' path='doc/member[@name="IMFDLNASinkInit.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IMFByteStream* pByteStream, BOOL fPal)
    {
        return ((delegate* unmanaged<IMFDLNASinkInit*, IMFByteStream*, BOOL, int> )(lpVtbl[3]))((IMFDLNASinkInit*)Unsafe.AsPointer(ref this), pByteStream, fPal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IMFByteStream* pByteStream, BOOL fPal);
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
        [NativeTypeName("HRESULT (IMFByteStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFByteStream*, BOOL, int> Initialize;
    }
}