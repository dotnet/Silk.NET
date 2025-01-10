// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("57F2E7BC-0BCF-4A9F-94A4-10E55C6E5B51")]
[NativeTypeName("struct ISendResponseProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct ISendResponseProvider : ISendResponseProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISendResponseProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<ISendResponseProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public BOOL GetHeadersBeingSent()
    {
        return ((delegate* unmanaged<ISendResponseProvider*, int>)((*lpVtbl)[1]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("DWORD")]
    public uint GetFlags()
    {
        return ((delegate* unmanaged<ISendResponseProvider*, uint>)((*lpVtbl)[2]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetFlags([NativeTypeName("DWORD")] uint dwFlags)
    {
        ((delegate* unmanaged<ISendResponseProvider*, uint, void>)((*lpVtbl)[3]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this),
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HTTP_LOG_DATA* GetLogData()
    {
        return ((delegate* unmanaged<ISendResponseProvider*, HTTP_LOG_DATA*>)((*lpVtbl)[4]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetLogData(HTTP_LOG_DATA* pLogData)
    {
        return ((delegate* unmanaged<ISendResponseProvider*, HTTP_LOG_DATA*, int>)((*lpVtbl)[5]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this),
            pLogData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetReadyToLogData()
    {
        return ((delegate* unmanaged<ISendResponseProvider*, int>)((*lpVtbl)[6]))(
            (ISendResponseProvider*)Unsafe.AsPointer(ref this)
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        BOOL GetHeadersBeingSent();

        [VtblIndex(2)]
        [return: NativeTypeName("DWORD")]
        uint GetFlags();

        [VtblIndex(3)]
        void SetFlags([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HTTP_LOG_DATA* GetLogData();

        [VtblIndex(5)]
        HRESULT SetLogData(HTTP_LOG_DATA* pLogData);

        [VtblIndex(6)]
        BOOL GetReadyToLogData();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetHeadersBeingSent;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged<TSelf*, uint> GetFlags;

        [NativeTypeName("void (DWORD)")]
        public delegate* unmanaged<TSelf*, uint, void> SetFlags;

        [NativeTypeName("HTTP_LOG_DATA *() const")]
        public delegate* unmanaged<TSelf*, HTTP_LOG_DATA*> GetLogData;

        [NativeTypeName("HRESULT (HTTP_LOG_DATA *)")]
        public delegate* unmanaged<TSelf*, HTTP_LOG_DATA*, int> SetLogData;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged<TSelf*, int> GetReadyToLogData;
    }
}
