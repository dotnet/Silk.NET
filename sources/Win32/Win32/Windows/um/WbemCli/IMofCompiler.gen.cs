// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6DAF974E-2E37-11D2-AEC9-00C04FB68820")]
[NativeTypeName("struct IMofCompiler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMofCompiler : IMofCompiler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMofCompiler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMofCompiler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMofCompiler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMofCompiler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CompileFile(
        [NativeTypeName("LPWSTR")] ushort* FileName,
        [NativeTypeName("LPWSTR")] ushort* ServerAndNamespace,
        [NativeTypeName("LPWSTR")] ushort* User,
        [NativeTypeName("LPWSTR")] ushort* Authority,
        [NativeTypeName("LPWSTR")] ushort* Password,
        [NativeTypeName("LONG")] int lOptionFlags,
        [NativeTypeName("LONG")] int lClassFlags,
        [NativeTypeName("LONG")] int lInstanceFlags,
        WBEM_COMPILE_STATUS_INFO* pInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMofCompiler,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                int,
                int,
                int,
                WBEM_COMPILE_STATUS_INFO*,
                int>)((*lpVtbl)[3])
        )(
            this,
            FileName,
            ServerAndNamespace,
            User,
            Authority,
            Password,
            lOptionFlags,
            lClassFlags,
            lInstanceFlags,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CompileBuffer(
        [NativeTypeName("long")] int BuffSize,
        byte* pBuffer,
        [NativeTypeName("LPWSTR")] ushort* ServerAndNamespace,
        [NativeTypeName("LPWSTR")] ushort* User,
        [NativeTypeName("LPWSTR")] ushort* Authority,
        [NativeTypeName("LPWSTR")] ushort* Password,
        [NativeTypeName("LONG")] int lOptionFlags,
        [NativeTypeName("LONG")] int lClassFlags,
        [NativeTypeName("LONG")] int lInstanceFlags,
        WBEM_COMPILE_STATUS_INFO* pInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMofCompiler,
                int,
                byte*,
                ushort*,
                ushort*,
                ushort*,
                ushort*,
                int,
                int,
                int,
                WBEM_COMPILE_STATUS_INFO*,
                int>)((*lpVtbl)[4])
        )(
            this,
            BuffSize,
            pBuffer,
            ServerAndNamespace,
            User,
            Authority,
            Password,
            lOptionFlags,
            lClassFlags,
            lInstanceFlags,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBMOF(
        [NativeTypeName("LPWSTR")] ushort* TextFileName,
        [NativeTypeName("LPWSTR")] ushort* BMOFFileName,
        [NativeTypeName("LPWSTR")] ushort* ServerAndNamespace,
        [NativeTypeName("LONG")] int lOptionFlags,
        [NativeTypeName("LONG")] int lClassFlags,
        [NativeTypeName("LONG")] int lInstanceFlags,
        WBEM_COMPILE_STATUS_INFO* pInfo
    )
    {
        return (
            (delegate* unmanaged<
                IMofCompiler,
                ushort*,
                ushort*,
                ushort*,
                int,
                int,
                int,
                WBEM_COMPILE_STATUS_INFO*,
                int>)((*lpVtbl)[5])
        )(
            this,
            TextFileName,
            BMOFFileName,
            ServerAndNamespace,
            lOptionFlags,
            lClassFlags,
            lInstanceFlags,
            pInfo
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CompileFile(
            [NativeTypeName("LPWSTR")] ushort* FileName,
            [NativeTypeName("LPWSTR")] ushort* ServerAndNamespace,
            [NativeTypeName("LPWSTR")] ushort* User,
            [NativeTypeName("LPWSTR")] ushort* Authority,
            [NativeTypeName("LPWSTR")] ushort* Password,
            [NativeTypeName("LONG")] int lOptionFlags,
            [NativeTypeName("LONG")] int lClassFlags,
            [NativeTypeName("LONG")] int lInstanceFlags,
            WBEM_COMPILE_STATUS_INFO* pInfo
        );

        [VtblIndex(4)]
        HRESULT CompileBuffer(
            [NativeTypeName("long")] int BuffSize,
            byte* pBuffer,
            [NativeTypeName("LPWSTR")] ushort* ServerAndNamespace,
            [NativeTypeName("LPWSTR")] ushort* User,
            [NativeTypeName("LPWSTR")] ushort* Authority,
            [NativeTypeName("LPWSTR")] ushort* Password,
            [NativeTypeName("LONG")] int lOptionFlags,
            [NativeTypeName("LONG")] int lClassFlags,
            [NativeTypeName("LONG")] int lInstanceFlags,
            WBEM_COMPILE_STATUS_INFO* pInfo
        );

        [VtblIndex(5)]
        HRESULT CreateBMOF(
            [NativeTypeName("LPWSTR")] ushort* TextFileName,
            [NativeTypeName("LPWSTR")] ushort* BMOFFileName,
            [NativeTypeName("LPWSTR")] ushort* ServerAndNamespace,
            [NativeTypeName("LONG")] int lOptionFlags,
            [NativeTypeName("LONG")] int lClassFlags,
            [NativeTypeName("LONG")] int lInstanceFlags,
            WBEM_COMPILE_STATUS_INFO* pInfo
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

        [NativeTypeName(
            "HRESULT (LPWSTR, LPWSTR, LPWSTR, LPWSTR, LPWSTR, LONG, LONG, LONG, WBEM_COMPILE_STATUS_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            int,
            int,
            int,
            WBEM_COMPILE_STATUS_INFO*,
            int> CompileFile;

        [NativeTypeName(
            "HRESULT (long, BYTE *, LPWSTR, LPWSTR, LPWSTR, LPWSTR, LONG, LONG, LONG, WBEM_COMPILE_STATUS_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            byte*,
            ushort*,
            ushort*,
            ushort*,
            ushort*,
            int,
            int,
            int,
            WBEM_COMPILE_STATUS_INFO*,
            int> CompileBuffer;

        [NativeTypeName(
            "HRESULT (LPWSTR, LPWSTR, LPWSTR, LONG, LONG, LONG, WBEM_COMPILE_STATUS_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            int,
            int,
            int,
            WBEM_COMPILE_STATUS_INFO*,
            int> CreateBMOF;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMofCompiler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMofCompiler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMofCompiler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMofCompiler(Silk.NET.Windows.IUnknown value)
    {
        return new IMofCompiler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMofCompiler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMofCompiler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMofCompiler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
