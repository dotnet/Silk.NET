// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Win32Extras
{
    // BuildTools should generate these types, but for some reason it's not. It's probably something I should look into
    // to be honest, but realistically we're so late into the 2.X maintenance cycle that it's probably not going to pose
    // too much of an issue.
    // PAST PRESENT DYLAN: Lol nice joke past past Dylan. REALLY APPRECIATED IT.
    public struct Filetime
    {
        public uint DwLowDateTime;
        public uint DwHighDateTime;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct TimeZoneInformation
    {
        public int Bias;
        public fixed char StandardName[32];
        public Systemtime StandardDate;
        public int StandardBias;
        public fixed char DaylightName[32];
        public Systemtime DaylightDate;
        public int DaylightBias;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct WnodeHeader
    {
        [FieldOffset(0)] public uint BufferSize;

        [FieldOffset(sizeof(uint))] public uint ProviderId;

        // Begin Union
        // Union Field 1
        [FieldOffset(sizeof(uint) * 2)] public ulong HistoricalContext;

        // Union Field 2 - Begin Nested Struct
        [FieldOffset(sizeof(uint) * 2)] public uint Version;

        [FieldOffset(sizeof(uint) * 3)] public uint Linkage;

        // End Nested Struct
        // End Union
        // Begin Union
        // Union Field 1
        [FieldOffset(sizeof(uint) * 2 + sizeof(ulong))]
        public uint CountLost;

        // Union Field 2
        [FieldOffset(sizeof(uint) * 2 + sizeof(ulong))]
        public nint KernelHandle;

        // Union Field 3
        [FieldOffset(sizeof(uint) * 2 + sizeof(ulong))]
        public long TimeStamp;

        // End Union
        [FieldOffset(sizeof(uint) * 2 + sizeof(ulong) * 2)]
        public Guid Guid;

        [FieldOffset(sizeof(uint) * 2 + sizeof(ulong) * 2 + /* sizeof(Guid) */ 16)]
        public uint ClientContext;

        [FieldOffset(sizeof(uint) * 3 + sizeof(ulong) * 2 + /* sizeof(Guid) */ 16)]
        public uint Flags;
    }

    public unsafe struct ExceptionRecord
    {
        public uint ExceptionCode;
        public uint ExceptionFlags;
        public ExceptionRecord* Next;
        public void* ExceptionAddress;
        public uint NumberParameters;
        public ExceptionRecordBuffer ExceptionInformation;

        public struct ExceptionRecordBuffer
        {
            public uint* Element0;
            public uint* Element1;
            public uint* Element2;
            public uint* Element3;
            public uint* Element4;
            public uint* Element5;
            public uint* Element6;
            public uint* Element7;
            public uint* Element8;
            public uint* Element9;
            public uint* Element10;
            public uint* Element11;
            public uint* Element12;
            public uint* Element13;
            public uint* Element14;

            public ref uint* this[int index]
            {
                get
                {
                    if (index > 7 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (uint** ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }
        }
    }

    public enum Wmidprequestcode : uint
    {
        WmiEnableEvents = 4,
        WmiDisableEvents = 5
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct FileSegmentElement
    {
        [FieldOffset(0)]
        public void* Buffer;
        [FieldOffset(0)]
        public ulong Alignment;
    }

    public struct RPCVersion
    {
        public ushort MajorVersion;
        public ushort MinorVersion;
    }

    public struct RPCSyntaxIdentifier
    {
        public Guid SyntaxGUID;
        public RPCVersion SyntaxVersion;
    }

    public unsafe struct RPCMessage
    {
        public void* Handle;
        public uint DataRepresentation;
        public void* Buffer;
        public uint BufferLength;
        public uint ProcNum;
        public RPCSyntaxIdentifier* TransferSyntax;
        public void* RpcInterfaceInformation;
        public void* ReservedForRuntime;
        public void* ManagerEpv;
        public void* ImportContext;
        public uint RpcFlags;
    }
}
