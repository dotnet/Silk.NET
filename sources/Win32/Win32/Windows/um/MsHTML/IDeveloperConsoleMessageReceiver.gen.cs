// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("30510808-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDeveloperConsoleMessageReceiver : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDeveloperConsoleMessageReceiver
    : IDeveloperConsoleMessageReceiver.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeveloperConsoleMessageReceiver));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeveloperConsoleMessageReceiver, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeveloperConsoleMessageReceiver, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeveloperConsoleMessageReceiver, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Write(
        [NativeTypeName("LPCWSTR")] ushort* source,
        DEV_CONSOLE_MESSAGE_LEVEL level,
        int messageId,
        [NativeTypeName("LPCWSTR")] ushort* messageText
    )
    {
        return (
            (delegate* unmanaged<
                IDeveloperConsoleMessageReceiver,
                ushort*,
                DEV_CONSOLE_MESSAGE_LEVEL,
                int,
                ushort*,
                int>)((*lpVtbl)[3])
        )(this, source, level, messageId, messageText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteWithUrl(
        [NativeTypeName("LPCWSTR")] ushort* source,
        DEV_CONSOLE_MESSAGE_LEVEL level,
        int messageId,
        [NativeTypeName("LPCWSTR")] ushort* messageText,
        [NativeTypeName("LPCWSTR")] ushort* fileUrl
    )
    {
        return (
            (delegate* unmanaged<
                IDeveloperConsoleMessageReceiver,
                ushort*,
                DEV_CONSOLE_MESSAGE_LEVEL,
                int,
                ushort*,
                ushort*,
                int>)((*lpVtbl)[4])
        )(this, source, level, messageId, messageText, fileUrl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WriteWithUrlAndLine(
        [NativeTypeName("LPCWSTR")] ushort* source,
        DEV_CONSOLE_MESSAGE_LEVEL level,
        int messageId,
        [NativeTypeName("LPCWSTR")] ushort* messageText,
        [NativeTypeName("LPCWSTR")] ushort* fileUrl,
        [NativeTypeName("ULONG")] uint line
    )
    {
        return (
            (delegate* unmanaged<
                IDeveloperConsoleMessageReceiver,
                ushort*,
                DEV_CONSOLE_MESSAGE_LEVEL,
                int,
                ushort*,
                ushort*,
                uint,
                int>)((*lpVtbl)[5])
        )(this, source, level, messageId, messageText, fileUrl, line);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteWithUrlLineAndColumn(
        [NativeTypeName("LPCWSTR")] ushort* source,
        DEV_CONSOLE_MESSAGE_LEVEL level,
        int messageId,
        [NativeTypeName("LPCWSTR")] ushort* messageText,
        [NativeTypeName("LPCWSTR")] ushort* fileUrl,
        [NativeTypeName("ULONG")] uint line,
        [NativeTypeName("ULONG")] uint column
    )
    {
        return (
            (delegate* unmanaged<
                IDeveloperConsoleMessageReceiver,
                ushort*,
                DEV_CONSOLE_MESSAGE_LEVEL,
                int,
                ushort*,
                ushort*,
                uint,
                uint,
                int>)((*lpVtbl)[6])
        )(this, source, level, messageId, messageText, fileUrl, line, column);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Write(
            [NativeTypeName("LPCWSTR")] ushort* source,
            DEV_CONSOLE_MESSAGE_LEVEL level,
            int messageId,
            [NativeTypeName("LPCWSTR")] ushort* messageText
        );

        [VtblIndex(4)]
        HRESULT WriteWithUrl(
            [NativeTypeName("LPCWSTR")] ushort* source,
            DEV_CONSOLE_MESSAGE_LEVEL level,
            int messageId,
            [NativeTypeName("LPCWSTR")] ushort* messageText,
            [NativeTypeName("LPCWSTR")] ushort* fileUrl
        );

        [VtblIndex(5)]
        HRESULT WriteWithUrlAndLine(
            [NativeTypeName("LPCWSTR")] ushort* source,
            DEV_CONSOLE_MESSAGE_LEVEL level,
            int messageId,
            [NativeTypeName("LPCWSTR")] ushort* messageText,
            [NativeTypeName("LPCWSTR")] ushort* fileUrl,
            [NativeTypeName("ULONG")] uint line
        );

        [VtblIndex(6)]
        HRESULT WriteWithUrlLineAndColumn(
            [NativeTypeName("LPCWSTR")] ushort* source,
            DEV_CONSOLE_MESSAGE_LEVEL level,
            int messageId,
            [NativeTypeName("LPCWSTR")] ushort* messageText,
            [NativeTypeName("LPCWSTR")] ushort* fileUrl,
            [NativeTypeName("ULONG")] uint line,
            [NativeTypeName("ULONG")] uint column
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
            "HRESULT (LPCWSTR, DEV_CONSOLE_MESSAGE_LEVEL, int, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DEV_CONSOLE_MESSAGE_LEVEL,
            int,
            ushort*,
            int> Write;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DEV_CONSOLE_MESSAGE_LEVEL, int, LPCWSTR, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DEV_CONSOLE_MESSAGE_LEVEL,
            int,
            ushort*,
            ushort*,
            int> WriteWithUrl;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DEV_CONSOLE_MESSAGE_LEVEL, int, LPCWSTR, LPCWSTR, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DEV_CONSOLE_MESSAGE_LEVEL,
            int,
            ushort*,
            ushort*,
            uint,
            int> WriteWithUrlAndLine;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DEV_CONSOLE_MESSAGE_LEVEL, int, LPCWSTR, LPCWSTR, ULONG, ULONG) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DEV_CONSOLE_MESSAGE_LEVEL,
            int,
            ushort*,
            ushort*,
            uint,
            uint,
            int> WriteWithUrlLineAndColumn;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeveloperConsoleMessageReceiver"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeveloperConsoleMessageReceiver(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeveloperConsoleMessageReceiver"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeveloperConsoleMessageReceiver(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDeveloperConsoleMessageReceiver(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeveloperConsoleMessageReceiver"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeveloperConsoleMessageReceiver"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDeveloperConsoleMessageReceiver value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
