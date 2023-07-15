// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFTimedTextStyle2.xml' path='doc/member[@name="IMFTimedTextStyle2"]/*'/>
[Guid("DB639199-C809-4C89-BFCA-D0BBB9729D6E")]
[NativeTypeName("struct IMFTimedTextStyle2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextStyle2 : IMFTimedTextStyle2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextStyle2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, Guid*, void**, int> )(lpVtbl[0]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, uint> )(lpVtbl[1]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, uint> )(lpVtbl[2]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedTextStyle2.xml' path='doc/member[@name="IMFTimedTextStyle2.GetRuby"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRuby(IMFTimedTextRuby** ruby)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, IMFTimedTextRuby**, int> )(lpVtbl[3]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), ruby);
    }

    /// <include file='IMFTimedTextStyle2.xml' path='doc/member[@name="IMFTimedTextStyle2.GetBouten"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBouten(IMFTimedTextBouten** bouten)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, IMFTimedTextBouten**, int> )(lpVtbl[4]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), bouten);
    }

    /// <include file='IMFTimedTextStyle2.xml' path='doc/member[@name="IMFTimedTextStyle2.IsTextCombined"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsTextCombined(BOOL* value)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, BOOL*, int> )(lpVtbl[5]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMFTimedTextStyle2.xml' path='doc/member[@name="IMFTimedTextStyle2.GetFontAngleInDegrees"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontAngleInDegrees(double* value)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2*, double*, int> )(lpVtbl[6]))((IMFTimedTextStyle2*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRuby(IMFTimedTextRuby** ruby);
        [VtblIndex(4)]
        HRESULT GetBouten(IMFTimedTextBouten** bouten);
        [VtblIndex(5)]
        HRESULT IsTextCombined(BOOL* value);
        [VtblIndex(6)]
        HRESULT GetFontAngleInDegrees(double* value);
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
        [NativeTypeName("HRESULT (IMFTimedTextRuby **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextRuby**, int> GetRuby;
        [NativeTypeName("HRESULT (IMFTimedTextBouten **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextBouten**, int> GetBouten;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsTextCombined;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetFontAngleInDegrees;
    }
}