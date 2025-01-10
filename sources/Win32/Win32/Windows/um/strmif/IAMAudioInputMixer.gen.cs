// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("54C39221-8380-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct IAMAudioInputMixer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMAudioInputMixer : IAMAudioInputMixer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMAudioInputMixer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMAudioInputMixer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, BOOL, int>)((*lpVtbl)[3]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Enable(BOOL* pfEnable)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, BOOL*, int>)((*lpVtbl)[4]))(
            this,
            pfEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_Mono(BOOL fMono)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, BOOL, int>)((*lpVtbl)[5]))(this, fMono);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Mono(BOOL* pfMono)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, BOOL*, int>)((*lpVtbl)[6]))(this, pfMono);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_MixLevel(double Level)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double, int>)((*lpVtbl)[7]))(this, Level);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MixLevel(double* pLevel)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double*, int>)((*lpVtbl)[8]))(
            this,
            pLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Pan(double Pan)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double, int>)((*lpVtbl)[9]))(this, Pan);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Pan(double* pPan)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double*, int>)((*lpVtbl)[10]))(this, pPan);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Loudness(BOOL fLoudness)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, BOOL, int>)((*lpVtbl)[11]))(
            this,
            fLoudness
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Loudness(BOOL* pfLoudness)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, BOOL*, int>)((*lpVtbl)[12]))(
            this,
            pfLoudness
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Treble(double Treble)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double, int>)((*lpVtbl)[13]))(
            this,
            Treble
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Treble(double* pTreble)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double*, int>)((*lpVtbl)[14]))(
            this,
            pTreble
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TrebleRange(double* pRange)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double*, int>)((*lpVtbl)[15]))(
            this,
            pRange
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_Bass(double Bass)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double, int>)((*lpVtbl)[16]))(this, Bass);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Bass(double* pBass)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double*, int>)((*lpVtbl)[17]))(
            this,
            pBass
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_BassRange(double* pRange)
    {
        return ((delegate* unmanaged<IAMAudioInputMixer, double*, int>)((*lpVtbl)[18]))(
            this,
            pRange
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT put_Enable(BOOL fEnable);

        [VtblIndex(4)]
        HRESULT get_Enable(BOOL* pfEnable);

        [VtblIndex(5)]
        HRESULT put_Mono(BOOL fMono);

        [VtblIndex(6)]
        HRESULT get_Mono(BOOL* pfMono);

        [VtblIndex(7)]
        HRESULT put_MixLevel(double Level);

        [VtblIndex(8)]
        HRESULT get_MixLevel(double* pLevel);

        [VtblIndex(9)]
        HRESULT put_Pan(double Pan);

        [VtblIndex(10)]
        HRESULT get_Pan(double* pPan);

        [VtblIndex(11)]
        HRESULT put_Loudness(BOOL fLoudness);

        [VtblIndex(12)]
        HRESULT get_Loudness(BOOL* pfLoudness);

        [VtblIndex(13)]
        HRESULT put_Treble(double Treble);

        [VtblIndex(14)]
        HRESULT get_Treble(double* pTreble);

        [VtblIndex(15)]
        HRESULT get_TrebleRange(double* pRange);

        [VtblIndex(16)]
        HRESULT put_Bass(double Bass);

        [VtblIndex(17)]
        HRESULT get_Bass(double* pBass);

        [VtblIndex(18)]
        HRESULT get_BassRange(double* pRange);
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

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Enable;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Enable;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Mono;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Mono;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_MixLevel;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MixLevel;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Pan;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Pan;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> put_Loudness;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_Loudness;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Treble;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Treble;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_TrebleRange;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Bass;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Bass;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_BassRange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMAudioInputMixer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMAudioInputMixer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMAudioInputMixer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMAudioInputMixer(Silk.NET.Windows.IUnknown value)
    {
        return new IAMAudioInputMixer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMAudioInputMixer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMAudioInputMixer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMAudioInputMixer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
