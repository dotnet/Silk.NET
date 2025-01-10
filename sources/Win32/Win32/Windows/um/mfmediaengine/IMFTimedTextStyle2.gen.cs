// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DB639199-C809-4C89-BFCA-D0BBB9729D6E")]
[NativeTypeName("struct IMFTimedTextStyle2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTimedTextStyle2 : IMFTimedTextStyle2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedTextStyle2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTimedTextStyle2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRuby(IMFTimedTextRuby* ruby)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2, IMFTimedTextRuby*, int>)((*lpVtbl)[3]))(
            this,
            ruby
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBouten(IMFTimedTextBouten* bouten)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2, IMFTimedTextBouten*, int>)((*lpVtbl)[4]))(
            this,
            bouten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsTextCombined(BOOL* value)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2, BOOL*, int>)((*lpVtbl)[5]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFontAngleInDegrees(double* value)
    {
        return ((delegate* unmanaged<IMFTimedTextStyle2, double*, int>)((*lpVtbl)[6]))(this, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRuby(IMFTimedTextRuby* ruby);

        [VtblIndex(4)]
        HRESULT GetBouten(IMFTimedTextBouten* bouten);

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
        public delegate* unmanaged<TSelf*, IMFTimedTextRuby*, int> GetRuby;

        [NativeTypeName("HRESULT (IMFTimedTextBouten **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTimedTextBouten*, int> GetBouten;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsTextCombined;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetFontAngleInDegrees;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTimedTextStyle2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTimedTextStyle2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTimedTextStyle2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTimedTextStyle2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTimedTextStyle2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTimedTextStyle2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTimedTextStyle2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTimedTextStyle2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
