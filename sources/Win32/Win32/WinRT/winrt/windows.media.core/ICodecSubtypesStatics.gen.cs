// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A66AC4F2-888B-4224-8CF6-2A8D4EB02382")]
[NativeTypeName("struct ICodecSubtypesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICodecSubtypesStatics : ICodecSubtypesStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICodecSubtypesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICodecSubtypesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoFormatDV25(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoFormatDV50(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoFormatDvc(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoFormatDvh1(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoFormatDvhD(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_VideoFormatDvsd(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_VideoFormatDvsl(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_VideoFormatH263(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VideoFormatH264(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_VideoFormatH265(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_VideoFormatH264ES(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_VideoFormatHevc(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_VideoFormatHevcES(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_VideoFormatM4S2(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_VideoFormatMjpg(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_VideoFormatMP43(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_VideoFormatMP4S(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_VideoFormatMP4V(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_VideoFormatMpeg2(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_VideoFormatVP80(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_VideoFormatVP90(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_VideoFormatMpg1(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_VideoFormatMss1(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_VideoFormatMss2(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_VideoFormatWmv1(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_VideoFormatWmv2(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_VideoFormatWmv3(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_VideoFormatWvc1(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_VideoFormat420O(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_AudioFormatAac(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[35]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_AudioFormatAdts(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[36]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_AudioFormatAlac(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[37]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_AudioFormatAmrNB(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[38]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_AudioFormatAmrWB(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[39]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_AudioFormatAmrWP(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_AudioFormatDolbyAC3(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[41]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_AudioFormatDolbyAC3Spdif(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[42]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_AudioFormatDolbyDDPlus(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[43]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_AudioFormatDrm(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[44]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_AudioFormatDts(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[45]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_AudioFormatFlac(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[46]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_AudioFormatFloat(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[47]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_AudioFormatMP3(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[48]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_AudioFormatMPeg(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[49]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_AudioFormatMsp1(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[50]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_AudioFormatOpus(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[51]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_AudioFormatPcm(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[52]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_AudioFormatWmaSpdif(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[53]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_AudioFormatWMAudioLossless(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[54]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_AudioFormatWMAudioV8(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[55]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_AudioFormatWMAudioV9(HSTRING* value)
    {
        return ((delegate* unmanaged<ICodecSubtypesStatics, HSTRING*, int>)((*lpVtbl)[56]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoFormatDV25(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_VideoFormatDV50(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_VideoFormatDvc(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_VideoFormatDvh1(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_VideoFormatDvhD(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_VideoFormatDvsd(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_VideoFormatDvsl(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_VideoFormatH263(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_VideoFormatH264(HSTRING* value);

        [VtblIndex(15)]
        HRESULT get_VideoFormatH265(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_VideoFormatH264ES(HSTRING* value);

        [VtblIndex(17)]
        HRESULT get_VideoFormatHevc(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_VideoFormatHevcES(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_VideoFormatM4S2(HSTRING* value);

        [VtblIndex(20)]
        HRESULT get_VideoFormatMjpg(HSTRING* value);

        [VtblIndex(21)]
        HRESULT get_VideoFormatMP43(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_VideoFormatMP4S(HSTRING* value);

        [VtblIndex(23)]
        HRESULT get_VideoFormatMP4V(HSTRING* value);

        [VtblIndex(24)]
        HRESULT get_VideoFormatMpeg2(HSTRING* value);

        [VtblIndex(25)]
        HRESULT get_VideoFormatVP80(HSTRING* value);

        [VtblIndex(26)]
        HRESULT get_VideoFormatVP90(HSTRING* value);

        [VtblIndex(27)]
        HRESULT get_VideoFormatMpg1(HSTRING* value);

        [VtblIndex(28)]
        HRESULT get_VideoFormatMss1(HSTRING* value);

        [VtblIndex(29)]
        HRESULT get_VideoFormatMss2(HSTRING* value);

        [VtblIndex(30)]
        HRESULT get_VideoFormatWmv1(HSTRING* value);

        [VtblIndex(31)]
        HRESULT get_VideoFormatWmv2(HSTRING* value);

        [VtblIndex(32)]
        HRESULT get_VideoFormatWmv3(HSTRING* value);

        [VtblIndex(33)]
        HRESULT get_VideoFormatWvc1(HSTRING* value);

        [VtblIndex(34)]
        HRESULT get_VideoFormat420O(HSTRING* value);

        [VtblIndex(35)]
        HRESULT get_AudioFormatAac(HSTRING* value);

        [VtblIndex(36)]
        HRESULT get_AudioFormatAdts(HSTRING* value);

        [VtblIndex(37)]
        HRESULT get_AudioFormatAlac(HSTRING* value);

        [VtblIndex(38)]
        HRESULT get_AudioFormatAmrNB(HSTRING* value);

        [VtblIndex(39)]
        HRESULT get_AudioFormatAmrWB(HSTRING* value);

        [VtblIndex(40)]
        HRESULT get_AudioFormatAmrWP(HSTRING* value);

        [VtblIndex(41)]
        HRESULT get_AudioFormatDolbyAC3(HSTRING* value);

        [VtblIndex(42)]
        HRESULT get_AudioFormatDolbyAC3Spdif(HSTRING* value);

        [VtblIndex(43)]
        HRESULT get_AudioFormatDolbyDDPlus(HSTRING* value);

        [VtblIndex(44)]
        HRESULT get_AudioFormatDrm(HSTRING* value);

        [VtblIndex(45)]
        HRESULT get_AudioFormatDts(HSTRING* value);

        [VtblIndex(46)]
        HRESULT get_AudioFormatFlac(HSTRING* value);

        [VtblIndex(47)]
        HRESULT get_AudioFormatFloat(HSTRING* value);

        [VtblIndex(48)]
        HRESULT get_AudioFormatMP3(HSTRING* value);

        [VtblIndex(49)]
        HRESULT get_AudioFormatMPeg(HSTRING* value);

        [VtblIndex(50)]
        HRESULT get_AudioFormatMsp1(HSTRING* value);

        [VtblIndex(51)]
        HRESULT get_AudioFormatOpus(HSTRING* value);

        [VtblIndex(52)]
        HRESULT get_AudioFormatPcm(HSTRING* value);

        [VtblIndex(53)]
        HRESULT get_AudioFormatWmaSpdif(HSTRING* value);

        [VtblIndex(54)]
        HRESULT get_AudioFormatWMAudioLossless(HSTRING* value);

        [VtblIndex(55)]
        HRESULT get_AudioFormatWMAudioV8(HSTRING* value);

        [VtblIndex(56)]
        HRESULT get_AudioFormatWMAudioV9(HSTRING* value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDV25;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDV50;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDvc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDvh1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDvhD;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDvsd;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatDvsl;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatH263;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatH264;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatH265;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatH264ES;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatHevc;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatHevcES;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatM4S2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMjpg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMP43;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMP4S;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMP4V;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMpeg2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatVP80;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatVP90;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMpg1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMss1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatMss2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatWmv1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatWmv2;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatWmv3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormatWvc1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_VideoFormat420O;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatAac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatAdts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatAlac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatAmrNB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatAmrWB;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatAmrWP;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatDolbyAC3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatDolbyAC3Spdif;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatDolbyDDPlus;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatDrm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatDts;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatFlac;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatFloat;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatMP3;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatMPeg;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatMsp1;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatOpus;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatPcm;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatWmaSpdif;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatWMAudioLossless;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatWMAudioV8;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AudioFormatWMAudioV9;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICodecSubtypesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICodecSubtypesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICodecSubtypesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICodecSubtypesStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICodecSubtypesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICodecSubtypesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICodecSubtypesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICodecSubtypesStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICodecSubtypesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICodecSubtypesStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ICodecSubtypesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICodecSubtypesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICodecSubtypesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICodecSubtypesStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
