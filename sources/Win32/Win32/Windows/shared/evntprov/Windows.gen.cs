// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventRegister(
        [NativeTypeName("LPCGUID")] Guid* ProviderId,
        [NativeTypeName("PENABLECALLBACK")]
            delegate* unmanaged<
            Guid*,
            uint,
            byte,
            ulong,
            ulong,
            EVENT_FILTER_DESCRIPTOR*,
            void*,
            void> EnableCallback,
        [NativeTypeName("PVOID")] void* CallbackContext,
        [NativeTypeName("PREGHANDLE")] ulong* RegHandle
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventUnregister([NativeTypeName("REGHANDLE")] ulong RegHandle);

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint EventSetInformation(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        EVENT_INFO_CLASS InformationClass,
        [NativeTypeName("PVOID")] void* EventInformation,
        [NativeTypeName("ULONG")] uint InformationLength
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte EventEnabled(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte EventProviderEnabled(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        [NativeTypeName("UCHAR")] byte Level,
        [NativeTypeName("ULONGLONG")] ulong Keyword
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventWrite(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("ULONG")] uint UserDataCount,
        [NativeTypeName("PEVENT_DATA_DESCRIPTOR")] EVENT_DATA_DESCRIPTOR* UserData
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventWriteTransfer(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("LPCGUID")] Guid* ActivityId,
        [NativeTypeName("LPCGUID")] Guid* RelatedActivityId,
        [NativeTypeName("ULONG")] uint UserDataCount,
        [NativeTypeName("PEVENT_DATA_DESCRIPTOR")] EVENT_DATA_DESCRIPTOR* UserData
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventWriteEx(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("ULONG64")] ulong Filter,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("LPCGUID")] Guid* ActivityId,
        [NativeTypeName("LPCGUID")] Guid* RelatedActivityId,
        [NativeTypeName("ULONG")] uint UserDataCount,
        [NativeTypeName("PEVENT_DATA_DESCRIPTOR")] EVENT_DATA_DESCRIPTOR* UserData
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventWriteString(
        [NativeTypeName("REGHANDLE")] ulong RegHandle,
        [NativeTypeName("UCHAR")] byte Level,
        [NativeTypeName("ULONGLONG")] ulong Keyword,
        [NativeTypeName("PCWSTR")] ushort* String
    );

    [DllImport("Advapi32", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint EventActivityIdControl(
        [NativeTypeName("ULONG")] uint ControlCode,
        [NativeTypeName("LPGUID")] Guid* ActivityId
    );

    public static void EventDataDescCreate(
        [NativeTypeName("PEVENT_DATA_DESCRIPTOR")] EVENT_DATA_DESCRIPTOR* EventDataDescriptor,
        [NativeTypeName("const void *")] void* DataPtr,
        [NativeTypeName("ULONG")] uint DataSize
    )
    {
        EventDataDescriptor->Ptr = (ulong)((nuint)(DataPtr));
        EventDataDescriptor->Size = DataSize;
        EventDataDescriptor->Anonymous.Reserved = 0;
        return;
    }

    public static void EventDescCreate(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        ushort Id,
        [NativeTypeName("UCHAR")] byte Version,
        [NativeTypeName("UCHAR")] byte Channel,
        [NativeTypeName("UCHAR")] byte Level,
        ushort Task,
        [NativeTypeName("UCHAR")] byte Opcode,
        [NativeTypeName("ULONGLONG")] ulong Keyword
    )
    {
        EventDescriptor->Id = Id;
        EventDescriptor->Version = Version;
        EventDescriptor->Channel = Channel;
        EventDescriptor->Level = Level;
        EventDescriptor->Task = Task;
        EventDescriptor->Opcode = Opcode;
        EventDescriptor->Keyword = Keyword;
        return;
    }

    public static void EventDescZero(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        NativeMemory.Fill(EventDescriptor, (uint)(sizeof(EVENT_DESCRIPTOR)), 0);
        return;
    }

    public static ushort EventDescGetId(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Id);
    }

    [return: NativeTypeName("UCHAR")]
    public static byte EventDescGetVersion(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Version);
    }

    public static ushort EventDescGetTask(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Task);
    }

    [return: NativeTypeName("UCHAR")]
    public static byte EventDescGetOpcode(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Opcode);
    }

    [return: NativeTypeName("UCHAR")]
    public static byte EventDescGetChannel(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Channel);
    }

    [return: NativeTypeName("UCHAR")]
    public static byte EventDescGetLevel(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Level);
    }

    [return: NativeTypeName("ULONGLONG")]
    public static ulong EventDescGetKeyword(
        [NativeTypeName("PCEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor
    )
    {
        return (EventDescriptor->Keyword);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetId(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        ushort Id
    )
    {
        EventDescriptor->Id = Id;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetVersion(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("UCHAR")] byte Version
    )
    {
        EventDescriptor->Version = Version;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetTask(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        ushort Task
    )
    {
        EventDescriptor->Task = Task;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetOpcode(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("UCHAR")] byte Opcode
    )
    {
        EventDescriptor->Opcode = Opcode;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetLevel(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("UCHAR")] byte Level
    )
    {
        EventDescriptor->Level = Level;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetChannel(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("UCHAR")] byte Channel
    )
    {
        EventDescriptor->Channel = Channel;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescSetKeyword(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("ULONGLONG")] ulong Keyword
    )
    {
        EventDescriptor->Keyword = Keyword;
        return (EventDescriptor);
    }

    [return: NativeTypeName("PEVENT_DESCRIPTOR")]
    public static EVENT_DESCRIPTOR* EventDescOrKeyword(
        [NativeTypeName("PEVENT_DESCRIPTOR")] EVENT_DESCRIPTOR* EventDescriptor,
        [NativeTypeName("ULONGLONG")] ulong Keyword
    )
    {
        EventDescriptor->Keyword |= Keyword;
        return (EventDescriptor);
    }
}
