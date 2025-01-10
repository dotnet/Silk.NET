// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xapo.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
[NativeTypeName("struct IXAPO : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXAPO : IXAPO.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXAPO));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXAPO, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXAPO, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXAPO, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRegistrationProperties(
        XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties
    )
    {
        return ((delegate* unmanaged<IXAPO, XAPO_REGISTRATION_PROPERTIES**, int>)((*lpVtbl)[3]))(
            this,
            ppRegistrationProperties
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsInputFormatSupported(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pOutputFormat,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedInputFormat,
        WAVEFORMATEX** ppSupportedInputFormat
    )
    {
        return (
            (delegate* unmanaged<IXAPO, WAVEFORMATEX*, WAVEFORMATEX*, WAVEFORMATEX**, int>)(
                (*lpVtbl)[4]
            )
        )(this, pOutputFormat, pRequestedInputFormat, ppSupportedInputFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsOutputFormatSupported(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pInputFormat,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedOutputFormat,
        WAVEFORMATEX** ppSupportedOutputFormat
    )
    {
        return (
            (delegate* unmanaged<IXAPO, WAVEFORMATEX*, WAVEFORMATEX*, WAVEFORMATEX**, int>)(
                (*lpVtbl)[5]
            )
        )(this, pInputFormat, pRequestedOutputFormat, ppSupportedOutputFormat);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Initialize(
        [NativeTypeName("const void *")] void* pData,
        [NativeTypeName("UINT32")] uint DataByteSize
    )
    {
        return ((delegate* unmanaged<IXAPO, void*, uint, int>)((*lpVtbl)[6]))(
            this,
            pData,
            DataByteSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Reset()
    {
        ((delegate* unmanaged<IXAPO, void>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LockForProcess(
        [NativeTypeName("UINT32")] uint InputLockedParameterCount,
        [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")]
            XAPO_LOCKFORPROCESS_PARAMETERS* pInputLockedParameters,
        [NativeTypeName("UINT32")] uint OutputLockedParameterCount,
        [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")]
            XAPO_LOCKFORPROCESS_PARAMETERS* pOutputLockedParameters
    )
    {
        return (
            (delegate* unmanaged<
                IXAPO,
                uint,
                XAPO_LOCKFORPROCESS_PARAMETERS*,
                uint,
                XAPO_LOCKFORPROCESS_PARAMETERS*,
                int>)((*lpVtbl)[8])
        )(
            this,
            InputLockedParameterCount,
            pInputLockedParameters,
            OutputLockedParameterCount,
            pOutputLockedParameters
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void UnlockForProcess()
    {
        ((delegate* unmanaged<IXAPO, void>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Process(
        [NativeTypeName("UINT32")] uint InputProcessParameterCount,
        [NativeTypeName("const XAPO_PROCESS_BUFFER_PARAMETERS *")]
            XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters,
        [NativeTypeName("UINT32")] uint OutputProcessParameterCount,
        XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters,
        BOOL IsEnabled
    )
    {
        (
            (delegate* unmanaged<
                IXAPO,
                uint,
                XAPO_PROCESS_BUFFER_PARAMETERS*,
                uint,
                XAPO_PROCESS_BUFFER_PARAMETERS*,
                BOOL,
                void>)((*lpVtbl)[10])
        )(
            this,
            InputProcessParameterCount,
            pInputProcessParameters,
            OutputProcessParameterCount,
            pOutputProcessParameters,
            IsEnabled
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT32")]
    public uint CalcInputFrames([NativeTypeName("UINT32")] uint OutputFrameCount)
    {
        return ((delegate* unmanaged<IXAPO, uint, uint>)((*lpVtbl)[11]))(this, OutputFrameCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [return: NativeTypeName("UINT32")]
    public uint CalcOutputFrames([NativeTypeName("UINT32")] uint InputFrameCount)
    {
        return ((delegate* unmanaged<IXAPO, uint, uint>)((*lpVtbl)[12]))(this, InputFrameCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRegistrationProperties(XAPO_REGISTRATION_PROPERTIES** ppRegistrationProperties);

        [VtblIndex(4)]
        HRESULT IsInputFormatSupported(
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pOutputFormat,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedInputFormat,
            WAVEFORMATEX** ppSupportedInputFormat
        );

        [VtblIndex(5)]
        HRESULT IsOutputFormatSupported(
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pInputFormat,
            [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pRequestedOutputFormat,
            WAVEFORMATEX** ppSupportedOutputFormat
        );

        [VtblIndex(6)]
        HRESULT Initialize(
            [NativeTypeName("const void *")] void* pData,
            [NativeTypeName("UINT32")] uint DataByteSize
        );

        [VtblIndex(7)]
        void Reset();

        [VtblIndex(8)]
        HRESULT LockForProcess(
            [NativeTypeName("UINT32")] uint InputLockedParameterCount,
            [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")]
                XAPO_LOCKFORPROCESS_PARAMETERS* pInputLockedParameters,
            [NativeTypeName("UINT32")] uint OutputLockedParameterCount,
            [NativeTypeName("const XAPO_LOCKFORPROCESS_PARAMETERS *")]
                XAPO_LOCKFORPROCESS_PARAMETERS* pOutputLockedParameters
        );

        [VtblIndex(9)]
        void UnlockForProcess();

        [VtblIndex(10)]
        void Process(
            [NativeTypeName("UINT32")] uint InputProcessParameterCount,
            [NativeTypeName("const XAPO_PROCESS_BUFFER_PARAMETERS *")]
                XAPO_PROCESS_BUFFER_PARAMETERS* pInputProcessParameters,
            [NativeTypeName("UINT32")] uint OutputProcessParameterCount,
            XAPO_PROCESS_BUFFER_PARAMETERS* pOutputProcessParameters,
            BOOL IsEnabled
        );

        [VtblIndex(11)]
        [return: NativeTypeName("UINT32")]
        uint CalcInputFrames([NativeTypeName("UINT32")] uint OutputFrameCount);

        [VtblIndex(12)]
        [return: NativeTypeName("UINT32")]
        uint CalcOutputFrames([NativeTypeName("UINT32")] uint InputFrameCount);
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

        [NativeTypeName(
            "HRESULT (XAPO_REGISTRATION_PROPERTIES **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            XAPO_REGISTRATION_PROPERTIES**,
            int> GetRegistrationProperties;

        [NativeTypeName(
            "HRESULT (const WAVEFORMATEX *, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WAVEFORMATEX*,
            WAVEFORMATEX*,
            WAVEFORMATEX**,
            int> IsInputFormatSupported;

        [NativeTypeName(
            "HRESULT (const WAVEFORMATEX *, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WAVEFORMATEX*,
            WAVEFORMATEX*,
            WAVEFORMATEX**,
            int> IsOutputFormatSupported;

        [NativeTypeName(
            "HRESULT (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, void*, uint, int> Initialize;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Reset;

        [NativeTypeName(
            "HRESULT (UINT32, const XAPO_LOCKFORPROCESS_PARAMETERS *, UINT32, const XAPO_LOCKFORPROCESS_PARAMETERS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            XAPO_LOCKFORPROCESS_PARAMETERS*,
            uint,
            XAPO_LOCKFORPROCESS_PARAMETERS*,
            int> LockForProcess;

        [NativeTypeName("void () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> UnlockForProcess;

        [NativeTypeName(
            "void (UINT32, const XAPO_PROCESS_BUFFER_PARAMETERS *, UINT32, XAPO_PROCESS_BUFFER_PARAMETERS *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            XAPO_PROCESS_BUFFER_PARAMETERS*,
            uint,
            XAPO_PROCESS_BUFFER_PARAMETERS*,
            BOOL,
            void> Process;

        [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> CalcInputFrames;

        [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> CalcOutputFrames;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXAPO"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXAPO(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXAPO"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXAPO(Silk.NET.Windows.IUnknown value)
    {
        return new IXAPO(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXAPO"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXAPO"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXAPO value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
