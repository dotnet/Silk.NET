// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfInputProcessorProfileActivationSink.xml' path='doc/member[@name="ITfInputProcessorProfileActivationSink"]/*'/>
[Guid("71C6E74E-0F28-11D8-A82A-00065B84435C")]
[NativeTypeName("struct ITfInputProcessorProfileActivationSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputProcessorProfileActivationSink : ITfInputProcessorProfileActivationSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfileActivationSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, Guid*, void**, int> )(lpVtbl[0]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, uint> )(lpVtbl[1]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, uint> )(lpVtbl[2]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfInputProcessorProfileActivationSink.xml' path='doc/member[@name="ITfInputProcessorProfileActivationSink.OnActivated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnActivated([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* catid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink*, uint, ushort, Guid*, Guid*, Guid*, HKL, uint, int> )(lpVtbl[3]))((ITfInputProcessorProfileActivationSink*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, catid, guidProfile, hkl, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnActivated([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* catid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, [NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (DWORD, LANGID, const IID &, const GUID &, const GUID &, HKL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort, Guid*, Guid*, Guid*, HKL, uint, int> OnActivated;
    }
}