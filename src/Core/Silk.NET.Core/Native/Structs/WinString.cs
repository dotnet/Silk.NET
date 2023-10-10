// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Silk.NET.Core.Native;

public unsafe struct WinString : IDisposable
{
    public struct Header
    {
        public uint Flags;
        public uint Length;
        public uint Reserved0;
        public uint Reserved1;
        public ushort* Data;
        public int RefCount;
        public ushort BufferStart;
    }
    public Header* HString;

    public WinString(string str) : this((nuint)str.Length)
        => str.AsSpan().CopyTo(new Span<char>(HString->Data, str.Length));

    public WinString(WinString other) : this(other.HString->Length)
        => new Span<ushort>(other.HString->Data, (int) other.HString->Length)
            .CopyTo(new Span<ushort>(HString->Data, (int) other.HString->Length));

    public WinString(nuint nChars)
    {
        [DllImport("kernel32.dll")]
        static extern void* HeapAlloc(void* heap, uint dwFlags, nuint dwBytes);

        HString = (Header*)HeapAlloc(ProcessHeap, 0, (nuint)sizeof(Header) + 2 * nChars);
        HString->Flags = 0;
        HString->Length = (uint)nChars;
        HString->Reserved0 = 0;
        HString->Reserved1 = 0;
        HString->Data = &HString->BufferStart;
        HString->RefCount = 1;
    }

    public void AddRef()
    {
        Interlocked.Increment(ref HString->RefCount);
    }

    public void Release()
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern uint HeapFree(void* hHeap, uint dwFlags, void* lpMem);

        if (Interlocked.Decrement(ref HString->RefCount) < 1)
        {
            if (HeapFree(ProcessHeap, 0, HString) == 0)
            {
                SilkMarshal.ThrowHResult(Marshal.GetHRForLastWin32Error());
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)768)]
    public static WinString DangerousCreate(char* str, uint length, Header* header)
    {
        header->Flags = 1; // reference flag
        header->Length = length;
        header->Reserved0 = 0;
        header->Reserved1 = 0;
        header->Data = (ushort*)str;
        header->RefCount = 1;
        header->BufferStart = 0;
        return new WinString { HString = header };
    }
    
    [DllImport("kernel32.dll")]
    private static extern void* GetProcessHeap();

    private static readonly void* ProcessHeap = GetProcessHeap();

    public void Dispose() => Release();

    public static implicit operator string(WinString winString) => winString.ToString();
    public static explicit operator WinString(string str) => new(str);

    public override string ToString()
        => HString is null || HString->Data is null
            ? string.Empty
            : new ReadOnlySpan<char>(HString->Data, (int) HString->Length).ToString();
}
