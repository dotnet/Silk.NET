// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("39DC7F4A-B141-4719-813C-A7F46162A2B8")]
[NativeTypeName("struct IMFSensorProcessActivity : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSensorProcessActivity
    : IMFSensorProcessActivity.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSensorProcessActivity));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSensorProcessActivity, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetProcessId([NativeTypeName("ULONG *")] uint* pPID)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity, uint*, int>)((*lpVtbl)[3]))(
            this,
            pPID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStreamingState(BOOL* pfStreaming)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity, BOOL*, int>)((*lpVtbl)[4]))(
            this,
            pfStreaming
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamingMode(MFSensorDeviceMode* pMode)
    {
        return (
            (delegate* unmanaged<IMFSensorProcessActivity, MFSensorDeviceMode*, int>)((*lpVtbl)[5])
        )(this, pMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetReportTime(FILETIME* pft)
    {
        return ((delegate* unmanaged<IMFSensorProcessActivity, FILETIME*, int>)((*lpVtbl)[6]))(
            this,
            pft
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetProcessId([NativeTypeName("ULONG *")] uint* pPID);

        [VtblIndex(4)]
        HRESULT GetStreamingState(BOOL* pfStreaming);

        [VtblIndex(5)]
        HRESULT GetStreamingMode(MFSensorDeviceMode* pMode);

        [VtblIndex(6)]
        HRESULT GetReportTime(FILETIME* pft);
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

        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProcessId;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetStreamingState;

        [NativeTypeName("HRESULT (MFSensorDeviceMode *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFSensorDeviceMode*, int> GetStreamingMode;

        [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, int> GetReportTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSensorProcessActivity"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSensorProcessActivity(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSensorProcessActivity"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSensorProcessActivity(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSensorProcessActivity(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSensorProcessActivity"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSensorProcessActivity"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSensorProcessActivity value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
