// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("63FDC43F-934A-4EE5-BCD8-7E7B50B75605")]
[NativeTypeName("struct IGlobalRSCAQueryProvider : IHttpEventProvider")]
[NativeInheritance("IHttpEventProvider")]
public unsafe partial struct IGlobalRSCAQueryProvider
    : IGlobalRSCAQueryProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalRSCAQueryProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void SetErrorStatus(HRESULT hrError)
    {
        ((delegate* unmanaged<IGlobalRSCAQueryProvider*, HRESULT, void>)((*lpVtbl)[0]))(
            (IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this),
            hrError
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetFunctionName()
    {
        return ((delegate* unmanaged<IGlobalRSCAQueryProvider*, ushort*>)((*lpVtbl)[1]))(
            (IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("PCWSTR")]
    public ushort* GetFunctionParameters()
    {
        return ((delegate* unmanaged<IGlobalRSCAQueryProvider*, ushort*>)((*lpVtbl)[2]))(
            (IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputBuffer([NativeTypeName("DWORD")] uint cbBuffer, byte** ppbBuffer)
    {
        return ((delegate* unmanaged<IGlobalRSCAQueryProvider*, uint, byte**, int>)((*lpVtbl)[3]))(
            (IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this),
            cbBuffer,
            ppbBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ResizeOutputBuffer(
        [NativeTypeName("DWORD")] uint cbNewBuffer,
        [NativeTypeName("DWORD")] uint cbBytesToCopy,
        byte** ppbBuffer
    )
    {
        return (
            (delegate* unmanaged<IGlobalRSCAQueryProvider*, uint, uint, byte**, int>)((*lpVtbl)[4])
        )(
            (IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this),
            cbNewBuffer,
            cbBytesToCopy,
            ppbBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetResult([NativeTypeName("DWORD")] uint cbData, HRESULT hr)
    {
        ((delegate* unmanaged<IGlobalRSCAQueryProvider*, uint, HRESULT, void>)((*lpVtbl)[5]))(
            (IGlobalRSCAQueryProvider*)Unsafe.AsPointer(ref this),
            cbData,
            hr
        );
    }

    public interface Interface : IHttpEventProvider.Interface
    {
        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetFunctionName();

        [VtblIndex(2)]
        [return: NativeTypeName("PCWSTR")]
        ushort* GetFunctionParameters();

        [VtblIndex(3)]
        HRESULT GetOutputBuffer([NativeTypeName("DWORD")] uint cbBuffer, byte** ppbBuffer);

        [VtblIndex(4)]
        HRESULT ResizeOutputBuffer(
            [NativeTypeName("DWORD")] uint cbNewBuffer,
            [NativeTypeName("DWORD")] uint cbBytesToCopy,
            byte** ppbBuffer
        );

        [VtblIndex(5)]
        void SetResult([NativeTypeName("DWORD")] uint cbData, HRESULT hr);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("void (HRESULT)")]
        public delegate* unmanaged<TSelf*, HRESULT, void> SetErrorStatus;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetFunctionName;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged<TSelf*, ushort*> GetFunctionParameters;

        [NativeTypeName("HRESULT (DWORD, BYTE **)")]
        public delegate* unmanaged<TSelf*, uint, byte**, int> GetOutputBuffer;

        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE **)")]
        public delegate* unmanaged<TSelf*, uint, uint, byte**, int> ResizeOutputBuffer;

        [NativeTypeName("void (DWORD, HRESULT)")]
        public delegate* unmanaged<TSelf*, uint, HRESULT, void> SetResult;
    }
}
