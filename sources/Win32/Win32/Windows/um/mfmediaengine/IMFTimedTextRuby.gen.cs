// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("76C6A6F5-4955-4DE5-B27B-14B734CC14B4")]
[NativeTypeName("struct IMFTimedTextRuby : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextRuby : IMFTimedTextRuby.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextRuby));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextRuby, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextRuby, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRubyText([NativeTypeName("LPWSTR *")] ushort** rubyText)
    {
        return ((delegate* unmanaged<IMFTimedTextRuby, ushort**, int>)((*lpVtbl)[3]))(
            this,
            rubyText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRubyPosition(MF_TIMED_TEXT_RUBY_POSITION* value)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRuby, MF_TIMED_TEXT_RUBY_POSITION*, int>)((*lpVtbl)[4])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRubyAlign(MF_TIMED_TEXT_RUBY_ALIGN* value)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRuby, MF_TIMED_TEXT_RUBY_ALIGN*, int>)((*lpVtbl)[5])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetRubyReserve(MF_TIMED_TEXT_RUBY_RESERVE* value)
    {
        return (
            (delegate* unmanaged<IMFTimedTextRuby, MF_TIMED_TEXT_RUBY_RESERVE*, int>)((*lpVtbl)[6])
        )(this, value);
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

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextRuby"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextRuby(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextRuby"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextRuby(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextRuby(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextRuby"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextRuby"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextRuby value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
