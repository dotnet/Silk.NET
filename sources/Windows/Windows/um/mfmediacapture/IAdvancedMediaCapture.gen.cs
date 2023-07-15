// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediacapture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAdvancedMediaCapture.xml' path='doc/member[@name="IAdvancedMediaCapture"]/*'/>
[Guid("D0751585-D216-4344-B5BF-463B68F977BB")]
[NativeTypeName("struct IAdvancedMediaCapture : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAdvancedMediaCapture : IAdvancedMediaCapture.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAdvancedMediaCapture));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAdvancedMediaCapture*, Guid*, void**, int> )(lpVtbl[0]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAdvancedMediaCapture*, uint> )(lpVtbl[1]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAdvancedMediaCapture*, uint> )(lpVtbl[2]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAdvancedMediaCapture.xml' path='doc/member[@name="IAdvancedMediaCapture.GetAdvancedMediaCaptureSettings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAdvancedMediaCaptureSettings(IAdvancedMediaCaptureSettings** value)
    {
        return ((delegate* unmanaged<IAdvancedMediaCapture*, IAdvancedMediaCaptureSettings**, int> )(lpVtbl[3]))((IAdvancedMediaCapture*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAdvancedMediaCaptureSettings(IAdvancedMediaCaptureSettings** value);
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
        [NativeTypeName("HRESULT (IAdvancedMediaCaptureSettings **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAdvancedMediaCaptureSettings**, int> GetAdvancedMediaCaptureSettings;
    }
}