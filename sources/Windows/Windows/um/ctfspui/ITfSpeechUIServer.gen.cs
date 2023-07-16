// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfspui.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfSpeechUIServer.xml' path='doc/member[@name="ITfSpeechUIServer"]/*'/>
[Guid("90E9A944-9244-489F-A78F-DE67AFC013A7")]
[NativeTypeName("struct ITfSpeechUIServer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSpeechUIServer : ITfSpeechUIServer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSpeechUIServer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSpeechUIServer*, Guid*, void**, int> )(lpVtbl[0]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfSpeechUIServer*, uint> )(lpVtbl[1]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSpeechUIServer*, uint> )(lpVtbl[2]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfSpeechUIServer.xml' path='doc/member[@name="ITfSpeechUIServer.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize()
    {
        return ((delegate* unmanaged<ITfSpeechUIServer*, int> )(lpVtbl[3]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfSpeechUIServer.xml' path='doc/member[@name="ITfSpeechUIServer.ShowUI"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowUI(BOOL fShow)
    {
        return ((delegate* unmanaged<ITfSpeechUIServer*, BOOL, int> )(lpVtbl[4]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this), fShow);
    }

    /// <include file='ITfSpeechUIServer.xml' path='doc/member[@name="ITfSpeechUIServer.UpdateBalloon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch)
    {
        return ((delegate* unmanaged<ITfSpeechUIServer*, TfLBBalloonStyle, ushort*, uint, int> )(lpVtbl[5]))((ITfSpeechUIServer*)Unsafe.AsPointer(ref this), style, pch, cch);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize();
        [VtblIndex(4)]
        HRESULT ShowUI(BOOL fShow);
        [VtblIndex(5)]
        HRESULT UpdateBalloon(TfLBBalloonStyle style, [NativeTypeName("const WCHAR *")] ushort* pch, [NativeTypeName("ULONG")] uint cch);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Initialize;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> ShowUI;
        [NativeTypeName("HRESULT (TfLBBalloonStyle, const WCHAR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfLBBalloonStyle, ushort*, uint, int> UpdateBalloon;
    }
}