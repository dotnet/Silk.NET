// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0DF2C94B-F5F9-472D-AF6B-C46E0AC9CD05")]
[NativeTypeName("struct ISpatialAudioObjectForMetadataCommands : ISpatialAudioObjectBase")]
[NativeInheritance("ISpatialAudioObjectBase")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioObjectForMetadataCommands
    : ISpatialAudioObjectForMetadataCommands.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectForMetadataCommands));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, byte**, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, buffer, bufferLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, uint, int>)((*lpVtbl)[4])
        )(this, frameCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, BOOL*, int>)((*lpVtbl)[5])
        )(this, isActive);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, AudioObjectType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, audioObjectType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WriteNextMetadataCommand(
        byte commandID,
        void* valueBuffer,
        [NativeTypeName("UINT32")] uint valueBufferLength
    )
    {
        return (
            (delegate* unmanaged<ISpatialAudioObjectForMetadataCommands, byte, void*, uint, int>)(
                (*lpVtbl)[7]
            )
        )(this, commandID, valueBuffer, valueBufferLength);
    }

    public interface Interface : ISpatialAudioObjectBase.Interface
    {
        [VtblIndex(7)]
        HRESULT WriteNextMetadataCommand(
            byte commandID,
            void* valueBuffer,
            [NativeTypeName("UINT32")] uint valueBufferLength
        );
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

        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBuffer;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEndOfStream;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsActive;

        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType*, int> GetAudioObjectType;

        [NativeTypeName("HRESULT (BYTE, void *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, void*, uint, int> WriteNextMetadataCommand;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioObjectForMetadataCommands"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioObjectForMetadataCommands(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISpatialAudioObjectBase"/> to <see cref = "ISpatialAudioObjectForMetadataCommands"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISpatialAudioObjectBase"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectForMetadataCommands(
        Silk.NET.Windows.ISpatialAudioObjectBase value
    )
    {
        return new ISpatialAudioObjectForMetadataCommands(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectForMetadataCommands"/> to <see cref = "Silk.NET.Windows.ISpatialAudioObjectBase"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectForMetadataCommands"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISpatialAudioObjectBase(
        ISpatialAudioObjectForMetadataCommands value
    )
    {
        return new Silk.NET.Windows.ISpatialAudioObjectBase(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioObjectForMetadataCommands"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioObjectForMetadataCommands(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpatialAudioObjectForMetadataCommands(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioObjectForMetadataCommands"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioObjectForMetadataCommands"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpatialAudioObjectForMetadataCommands value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
