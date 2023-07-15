// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle"]/*'/>
[Guid("3050F6C3-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLComputedStyle : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLComputedStyle : IHTMLComputedStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLComputedStyle));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, uint> )(lpVtbl[1]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, uint> )(lpVtbl[2]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_bold"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_bold([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[3]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_italic"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_italic([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[4]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_underline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_underline([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[5]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_overline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_overline([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[6]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_strikeOut"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_strikeOut([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[7]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_subScript"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_subScript([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[8]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_superScript"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_superScript([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[9]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_explicitFace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_explicitFace([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[10]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_fontWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_fontWeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, int*, int> )(lpVtbl[11]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_fontSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_fontSize([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, int*, int> )(lpVtbl[12]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_fontName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_fontName([NativeTypeName("TCHAR *")] ushort* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, ushort*, int> )(lpVtbl[13]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_hasBgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_hasBgColor([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[14]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_textColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_textColor([NativeTypeName("DWORD *")] uint* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, uint*, int> )(lpVtbl[15]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_backgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_backgroundColor([NativeTypeName("DWORD *")] uint* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, uint*, int> )(lpVtbl[16]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_preFormatted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_preFormatted([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[17]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_direction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_direction([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[18]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_blockDirection"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_blockDirection([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[19]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.get_OL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_OL([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, short*, int> )(lpVtbl[20]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLComputedStyle.xml' path='doc/member[@name="IHTMLComputedStyle.IsEqual"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT IsEqual(IHTMLComputedStyle* pComputedStyle, [NativeTypeName("VARIANT_BOOL *")] short* pfEqual)
    {
        return ((delegate* unmanaged<IHTMLComputedStyle*, IHTMLComputedStyle*, short*, int> )(lpVtbl[21]))((IHTMLComputedStyle*)Unsafe.AsPointer(ref this), pComputedStyle, pfEqual);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_bold([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(4)]
        HRESULT get_italic([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(5)]
        HRESULT get_underline([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(6)]
        HRESULT get_overline([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(7)]
        HRESULT get_strikeOut([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(8)]
        HRESULT get_subScript([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(9)]
        HRESULT get_superScript([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(10)]
        HRESULT get_explicitFace([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(11)]
        HRESULT get_fontWeight([NativeTypeName("long *")] int* p);
        [VtblIndex(12)]
        HRESULT get_fontSize([NativeTypeName("long *")] int* p);
        [VtblIndex(13)]
        HRESULT get_fontName([NativeTypeName("TCHAR *")] ushort* p);
        [VtblIndex(14)]
        HRESULT get_hasBgColor([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(15)]
        HRESULT get_textColor([NativeTypeName("DWORD *")] uint* p);
        [VtblIndex(16)]
        HRESULT get_backgroundColor([NativeTypeName("DWORD *")] uint* p);
        [VtblIndex(17)]
        HRESULT get_preFormatted([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(18)]
        HRESULT get_direction([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(19)]
        HRESULT get_blockDirection([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(20)]
        HRESULT get_OL([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(21)]
        HRESULT IsEqual(IHTMLComputedStyle* pComputedStyle, [NativeTypeName("VARIANT_BOOL *")] short* pfEqual);
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
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_bold;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_italic;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_underline;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_overline;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_strikeOut;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_subScript;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_superScript;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_explicitFace;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_fontWeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_fontSize;
        [NativeTypeName("HRESULT (TCHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_fontName;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_hasBgColor;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_textColor;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_backgroundColor;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_preFormatted;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_direction;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_blockDirection;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_OL;
        [NativeTypeName("HRESULT (IHTMLComputedStyle *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLComputedStyle*, short*, int> IsEqual;
    }
}