// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFTimedTextRuby.xml' path='doc/member[@name="IMFTimedTextRuby"]/*'/>
[Guid("76C6A6F5-4955-4DE5-B27B-14B734CC14B4")]
[NativeTypeName("struct IMFTimedTextRuby : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextRuby : IMFTimedTextRuby.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextRuby));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, Guid*, void**, int> )(lpVtbl[0]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, uint> )(lpVtbl[1]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, uint> )(lpVtbl[2]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextRuby.xml' path='doc/member[@name="IMFTimedTextRuby.GetRubyText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRubyText([NativeTypeName("LPWSTR *")] ushort** rubyText)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, ushort**, int> )(lpVtbl[3]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), rubyText);
    }

    /// <include file='IMFTimedTextRuby.xml' path='doc/member[@name="IMFTimedTextRuby.GetRubyPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRubyPosition(MF_TIMED_TEXT_RUBY_POSITION* value)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, MF_TIMED_TEXT_RUBY_POSITION*, int> )(lpVtbl[4]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMFTimedTextRuby.xml' path='doc/member[@name="IMFTimedTextRuby.GetRubyAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRubyAlign(MF_TIMED_TEXT_RUBY_ALIGN* value)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, MF_TIMED_TEXT_RUBY_ALIGN*, int> )(lpVtbl[5]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMFTimedTextRuby.xml' path='doc/member[@name="IMFTimedTextRuby.GetRubyReserve"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRubyReserve(MF_TIMED_TEXT_RUBY_RESERVE* value)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby*, MF_TIMED_TEXT_RUBY_RESERVE*, int> )(lpVtbl[6]))((IMFTimedTextRuby*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRubyText([NativeTypeName("LPWSTR *")] ushort** rubyText);
        [VtblIndex(4)]
        HRESULT GetRubyPosition(MF_TIMED_TEXT_RUBY_POSITION* value);
        [VtblIndex(5)]
        HRESULT GetRubyAlign(MF_TIMED_TEXT_RUBY_ALIGN* value);
        [VtblIndex(6)]
        HRESULT GetRubyReserve(MF_TIMED_TEXT_RUBY_RESERVE* value);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetRubyText;
        [NativeTypeName("HRESULT (MF_TIMED_TEXT_RUBY_POSITION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_RUBY_POSITION*, int> GetRubyPosition;
        [NativeTypeName("HRESULT (MF_TIMED_TEXT_RUBY_ALIGN *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_RUBY_ALIGN*, int> GetRubyAlign;
        [NativeTypeName("HRESULT (MF_TIMED_TEXT_RUBY_RESERVE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TIMED_TEXT_RUBY_RESERVE*, int> GetRubyReserve;
    }
}