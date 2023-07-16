// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectDrawColorControl.xml' path='doc/member[@name="IDirectDrawColorControl"]/*'/>
[Guid("4B9F0EE0-0D7E-11D0-9B06-00A0C903A3B8")]
[NativeTypeName("struct IDirectDrawColorControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawColorControl : IDirectDrawColorControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawColorControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawColorControl*, Guid*, void**, int> )(lpVtbl[0]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawColorControl*, uint> )(lpVtbl[1]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawColorControl*, uint> )(lpVtbl[2]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawColorControl.xml' path='doc/member[@name="IDirectDrawColorControl.GetColorControls"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
    {
        return ((delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int> )(lpVtbl[3]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawColorControl.xml' path='doc/member[@name="IDirectDrawColorControl.SetColorControls"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
    {
        return ((delegate* unmanaged<IDirectDrawColorControl*, DDCOLORCONTROL*, int> )(lpVtbl[4]))((IDirectDrawColorControl*)Unsafe.AsPointer(ref this), param0);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0);
        [VtblIndex(4)]
        HRESULT SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0);
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
        [NativeTypeName("HRESULT (LPDDCOLORCONTROL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCOLORCONTROL*, int> GetColorControls;
        [NativeTypeName("HRESULT (LPDDCOLORCONTROL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DDCOLORCONTROL*, int> SetColorControls;
    }
}