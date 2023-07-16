// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfFnGetPreferredTouchKeyboardLayout.xml' path='doc/member[@name="ITfFnGetPreferredTouchKeyboardLayout"]/*'/>
[Guid("5F309A41-590A-4ACC-A97F-D8EFFF13FDFC")]
[NativeTypeName("struct ITfFnGetPreferredTouchKeyboardLayout : ITfFunction")]
[NativeInheritance("ITfFunction")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITfFnGetPreferredTouchKeyboardLayout : ITfFnGetPreferredTouchKeyboardLayout.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnGetPreferredTouchKeyboardLayout));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, Guid*, void**, int> )(lpVtbl[0]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, uint> )(lpVtbl[1]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, uint> )(lpVtbl[2]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ITfFunction.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, ushort**, int> )(lpVtbl[3]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='ITfFnGetPreferredTouchKeyboardLayout.xml' path='doc/member[@name="ITfFnGetPreferredTouchKeyboardLayout.GetLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLayout(TKBLayoutType* pTKBLayoutType, [NativeTypeName("WORD *")] ushort* pwPreferredLayoutId)
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout*, TKBLayoutType*, ushort*, int> )(lpVtbl[4]))((ITfFnGetPreferredTouchKeyboardLayout*)Unsafe.AsPointer(ref this), pTKBLayoutType, pwPreferredLayoutId);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetLayout(TKBLayoutType* pTKBLayoutType, [NativeTypeName("WORD *")] ushort* pwPreferredLayoutId);
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
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (TKBLayoutType *, WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TKBLayoutType*, ushort*, int> GetLayout;
    }
}