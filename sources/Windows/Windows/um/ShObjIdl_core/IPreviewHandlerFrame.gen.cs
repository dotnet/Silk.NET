// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPreviewHandlerFrame.xml' path='doc/member[@name="IPreviewHandlerFrame"]/*'/>
[Guid("FEC87AAF-35F9-447A-ADB7-20234491401A")]
[NativeTypeName("struct IPreviewHandlerFrame : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPreviewHandlerFrame : IPreviewHandlerFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreviewHandlerFrame));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPreviewHandlerFrame*, Guid*, void**, int> )(lpVtbl[0]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPreviewHandlerFrame*, uint> )(lpVtbl[1]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPreviewHandlerFrame*, uint> )(lpVtbl[2]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPreviewHandlerFrame.xml' path='doc/member[@name="IPreviewHandlerFrame.GetWindowContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindowContext(PREVIEWHANDLERFRAMEINFO* pinfo)
    {
        return ((delegate* unmanaged<IPreviewHandlerFrame*, PREVIEWHANDLERFRAMEINFO*, int> )(lpVtbl[3]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this), pinfo);
    }

    /// <include file='IPreviewHandlerFrame.xml' path='doc/member[@name="IPreviewHandlerFrame.TranslateAcceleratorW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TranslateAcceleratorW(MSG* pmsg)
    {
        return ((delegate* unmanaged<IPreviewHandlerFrame*, MSG*, int> )(lpVtbl[4]))((IPreviewHandlerFrame*)Unsafe.AsPointer(ref this), pmsg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindowContext(PREVIEWHANDLERFRAMEINFO* pinfo);
        [VtblIndex(4)]
        HRESULT TranslateAcceleratorW(MSG* pmsg);
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
        [NativeTypeName("HRESULT (PREVIEWHANDLERFRAMEINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PREVIEWHANDLERFRAMEINFO*, int> GetWindowContext;
        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MSG*, int> TranslateAcceleratorW;
    }
}