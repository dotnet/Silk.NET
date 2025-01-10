// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("4606AA89-F563-4D0A-8F6E-F0CDDFF35D84")]
[NativeTypeName("struct IReverbEffectDefinition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IReverbEffectDefinition
    : IReverbEffectDefinition.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReverbEffectDefinition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IReverbEffectDefinition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_WetDryMix(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_WetDryMix(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ReflectionsDelay([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, uint, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReflectionsDelay([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, uint*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ReverbDelay(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ReverbDelay(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_RearDelay(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RearDelay(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_PositionLeft(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PositionLeft(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_PositionRight(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_PositionRight(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_PositionMatrixLeft(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_PositionMatrixLeft(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_PositionMatrixRight(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_PositionMatrixRight(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_EarlyDiffusion(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_EarlyDiffusion(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_LateDiffusion(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_LateDiffusion(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_LowEQGain(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_LowEQGain(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_LowEQCutoff(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_LowEQCutoff(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_HighEQGain(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_HighEQGain(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_HighEQCutoff(byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_HighEQCutoff(byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[33]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_RoomFilterFreq(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[34]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_RoomFilterFreq(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[35]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_RoomFilterMain(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[36]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_RoomFilterMain(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[37]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_RoomFilterHF(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[38]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_RoomFilterHF(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[39]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_ReflectionsGain(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[40]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_ReflectionsGain(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[41]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_ReverbGain(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[42]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_ReverbGain(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[43]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_DecayTime(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[44]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_DecayTime(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[45]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_Density(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[46]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_Density(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[47]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_RoomSize(double value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double, int>)((*lpVtbl)[48]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_RoomSize(double* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, double*, int>)((*lpVtbl)[49]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_DisableLateField([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte, int>)((*lpVtbl)[50]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_DisableLateField([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IReverbEffectDefinition, byte*, int>)((*lpVtbl)[51]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_WetDryMix(double value);

        [VtblIndex(7)]
        HRESULT get_WetDryMix(double* value);

        [VtblIndex(8)]
        HRESULT put_ReflectionsDelay([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_ReflectionsDelay([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_ReverbDelay(byte value);

        [VtblIndex(11)]
        HRESULT get_ReverbDelay(byte* value);

        [VtblIndex(12)]
        HRESULT put_RearDelay(byte value);

        [VtblIndex(13)]
        HRESULT get_RearDelay(byte* value);

        [VtblIndex(14)]
        HRESULT put_PositionLeft(byte value);

        [VtblIndex(15)]
        HRESULT get_PositionLeft(byte* value);

        [VtblIndex(16)]
        HRESULT put_PositionRight(byte value);

        [VtblIndex(17)]
        HRESULT get_PositionRight(byte* value);

        [VtblIndex(18)]
        HRESULT put_PositionMatrixLeft(byte value);

        [VtblIndex(19)]
        HRESULT get_PositionMatrixLeft(byte* value);

        [VtblIndex(20)]
        HRESULT put_PositionMatrixRight(byte value);

        [VtblIndex(21)]
        HRESULT get_PositionMatrixRight(byte* value);

        [VtblIndex(22)]
        HRESULT put_EarlyDiffusion(byte value);

        [VtblIndex(23)]
        HRESULT get_EarlyDiffusion(byte* value);

        [VtblIndex(24)]
        HRESULT put_LateDiffusion(byte value);

        [VtblIndex(25)]
        HRESULT get_LateDiffusion(byte* value);

        [VtblIndex(26)]
        HRESULT put_LowEQGain(byte value);

        [VtblIndex(27)]
        HRESULT get_LowEQGain(byte* value);

        [VtblIndex(28)]
        HRESULT put_LowEQCutoff(byte value);

        [VtblIndex(29)]
        HRESULT get_LowEQCutoff(byte* value);

        [VtblIndex(30)]
        HRESULT put_HighEQGain(byte value);

        [VtblIndex(31)]
        HRESULT get_HighEQGain(byte* value);

        [VtblIndex(32)]
        HRESULT put_HighEQCutoff(byte value);

        [VtblIndex(33)]
        HRESULT get_HighEQCutoff(byte* value);

        [VtblIndex(34)]
        HRESULT put_RoomFilterFreq(double value);

        [VtblIndex(35)]
        HRESULT get_RoomFilterFreq(double* value);

        [VtblIndex(36)]
        HRESULT put_RoomFilterMain(double value);

        [VtblIndex(37)]
        HRESULT get_RoomFilterMain(double* value);

        [VtblIndex(38)]
        HRESULT put_RoomFilterHF(double value);

        [VtblIndex(39)]
        HRESULT get_RoomFilterHF(double* value);

        [VtblIndex(40)]
        HRESULT put_ReflectionsGain(double value);

        [VtblIndex(41)]
        HRESULT get_ReflectionsGain(double* value);

        [VtblIndex(42)]
        HRESULT put_ReverbGain(double value);

        [VtblIndex(43)]
        HRESULT get_ReverbGain(double* value);

        [VtblIndex(44)]
        HRESULT put_DecayTime(double value);

        [VtblIndex(45)]
        HRESULT get_DecayTime(double* value);

        [VtblIndex(46)]
        HRESULT put_Density(double value);

        [VtblIndex(47)]
        HRESULT get_Density(double* value);

        [VtblIndex(48)]
        HRESULT put_RoomSize(double value);

        [VtblIndex(49)]
        HRESULT get_RoomSize(double* value);

        [VtblIndex(50)]
        HRESULT put_DisableLateField([NativeTypeName("boolean")] byte value);

        [VtblIndex(51)]
        HRESULT get_DisableLateField([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_WetDryMix;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_WetDryMix;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_ReflectionsDelay;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ReflectionsDelay;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ReverbDelay;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ReverbDelay;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_RearDelay;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_RearDelay;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_PositionLeft;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_PositionLeft;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_PositionRight;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_PositionRight;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_PositionMatrixLeft;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_PositionMatrixLeft;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_PositionMatrixRight;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_PositionMatrixRight;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_EarlyDiffusion;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_EarlyDiffusion;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_LateDiffusion;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_LateDiffusion;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_LowEQGain;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_LowEQGain;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_LowEQCutoff;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_LowEQCutoff;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_HighEQGain;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HighEQGain;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_HighEQCutoff;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HighEQCutoff;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_RoomFilterFreq;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_RoomFilterFreq;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_RoomFilterMain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_RoomFilterMain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_RoomFilterHF;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_RoomFilterHF;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_ReflectionsGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_ReflectionsGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_ReverbGain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_ReverbGain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_DecayTime;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DecayTime;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Density;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Density;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_RoomSize;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_RoomSize;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_DisableLateField;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DisableLateField;
    }

    /// <summary>Initializes a new instance of the <see cref = "IReverbEffectDefinition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IReverbEffectDefinition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IReverbEffectDefinition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IReverbEffectDefinition(Silk.NET.WinRT.IInspectable value)
    {
        return new IReverbEffectDefinition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IReverbEffectDefinition"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IReverbEffectDefinition"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IReverbEffectDefinition value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IReverbEffectDefinition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IReverbEffectDefinition(Silk.NET.Windows.IUnknown value)
    {
        return new IReverbEffectDefinition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IReverbEffectDefinition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IReverbEffectDefinition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IReverbEffectDefinition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
