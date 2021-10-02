// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    public unsafe partial class EventTrace : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "KERNEL_LOGGER_NAMEW")]
        public const string KernelLoggerNamew = unchecked((string) "NT Kernel Logger");
        [NativeName("Type", "")]
        [NativeName("Name", "GLOBAL_LOGGER_NAMEW")]
        public const string GlobalLoggerNamew = unchecked((string) "GlobalLogger");
        [NativeName("Type", "")]
        [NativeName("Name", "EVENT_LOGGER_NAMEW")]
        public const string EventLoggerNamew = unchecked((string) "EventLog");
        [NativeName("Type", "")]
        [NativeName("Name", "DIAG_LOGGER_NAMEW")]
        public const string DiagLoggerNamew = unchecked((string) "DiagLog");
        [NativeName("Type", "")]
        [NativeName("Name", "KERNEL_LOGGER_NAMEA")]
        public const string KernelLoggerNamea = unchecked((string) "NT Kernel Logger");
        [NativeName("Type", "")]
        [NativeName("Name", "GLOBAL_LOGGER_NAMEA")]
        public const string GlobalLoggerNamea = unchecked((string) "GlobalLogger");
        [NativeName("Type", "")]
        [NativeName("Name", "EVENT_LOGGER_NAMEA")]
        public const string EventLoggerNamea = unchecked((string) "EventLog");
        [NativeName("Type", "")]
        [NativeName("Name", "DIAG_LOGGER_NAMEA")]
        public const string DiagLoggerNamea = unchecked((string) "DiagLog");
        [NativeName("Type", "int")]
        [NativeName("Name", "MAX_MOF_FIELDS")]
        public const int MaxMofFields = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "SYSTEM_EVENT_TYPE")]
        public const int SystemEventType = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_INFO")]
        public const int EventTraceTypeInfo = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_START")]
        public const int EventTraceTypeStart = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_END")]
        public const int EventTraceTypeEnd = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_STOP")]
        public const int EventTraceTypeStop = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DC_START")]
        public const int EventTraceTypeDCStart = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DC_END")]
        public const int EventTraceTypeDCEnd = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_EXTENSION")]
        public const int EventTraceTypeExtension = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REPLY")]
        public const int EventTraceTypeReply = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DEQUEUE")]
        public const int EventTraceTypeDequeue = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RESUME")]
        public const int EventTraceTypeResume = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CHECKPOINT")]
        public const int EventTraceTypeCheckpoint = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SUSPEND")]
        public const int EventTraceTypeSuspend = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_WINEVT_SEND")]
        public const int EventTraceTypeWinevtSend = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_WINEVT_RECEIVE")]
        public const int EventTraceTypeWinevtReceive = unchecked((int) 0xF0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_NONE")]
        public const int TraceLevelNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_CRITICAL")]
        public const int TraceLevelCritical = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_FATAL")]
        public const int TraceLevelFatal = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_ERROR")]
        public const int TraceLevelError = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_WARNING")]
        public const int TraceLevelWarning = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_INFORMATION")]
        public const int TraceLevelInformation = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_VERBOSE")]
        public const int TraceLevelVerbose = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED6")]
        public const int TraceLevelReserved6 = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED7")]
        public const int TraceLevelReserved7 = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED8")]
        public const int TraceLevelReserved8 = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_LEVEL_RESERVED9")]
        public const int TraceLevelReserved9 = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_LOAD")]
        public const int EventTraceTypeLoad = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_TERMINATE")]
        public const int EventTraceTypeTerminate = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_READ")]
        public const int EventTraceTypeIORead = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_WRITE")]
        public const int EventTraceTypeIOWrite = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_READ_INIT")]
        public const int EventTraceTypeIOReadInit = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_WRITE_INIT")]
        public const int EventTraceTypeIOWriteInit = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_FLUSH")]
        public const int EventTraceTypeIOFlush = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_FLUSH_INIT")]
        public const int EventTraceTypeIOFlushInit = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_IO_REDIRECTED_INIT")]
        public const int EventTraceTypeIORedirectedInit = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_TF")]
        public const int EventTraceTypeMMTF = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_DZF")]
        public const int EventTraceTypeMMDzf = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_COW")]
        public const int EventTraceTypeMMCow = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_GPF")]
        public const int EventTraceTypeMMGpf = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_HPF")]
        public const int EventTraceTypeMMHpf = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_MM_AV")]
        public const int EventTraceTypeMMAV = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SEND")]
        public const int EventTraceTypeSend = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RECEIVE")]
        public const int EventTraceTypeReceive = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONNECT")]
        public const int EventTraceTypeConnect = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DISCONNECT")]
        public const int EventTraceTypeDisconnect = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RETRANSMIT")]
        public const int EventTraceTypeRetransmit = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACCEPT")]
        public const int EventTraceTypeAccept = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_RECONNECT")]
        public const int EventTraceTypeReconnect = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONNFAIL")]
        public const int EventTraceTypeConnfail = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_COPY_TCP")]
        public const int EventTraceTypeCopyTcp = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_COPY_ARP")]
        public const int EventTraceTypeCopyArp = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACKFULL")]
        public const int EventTraceTypeAckfull = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACKPART")]
        public const int EventTraceTypeAckpart = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_ACKDUP")]
        public const int EventTraceTypeAckdup = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_GUIDMAP")]
        public const int EventTraceTypeGuidmap = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG")]
        public const int EventTraceTypeConfig = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SIDINFO")]
        public const int EventTraceTypeSidinfo = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_SECURITY")]
        public const int EventTraceTypeSecurity = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_DBGID_RSDS")]
        public const int EventTraceTypeDbgidRsds = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGCREATE")]
        public const int EventTraceTypeRegcreate = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGOPEN")]
        public const int EventTraceTypeRegopen = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGDELETE")]
        public const int EventTraceTypeRegdelete = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERY")]
        public const int EventTraceTypeRegquery = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGSETVALUE")]
        public const int EventTraceTypeRegsetvalue = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGDELETEVALUE")]
        public const int EventTraceTypeRegdeletevalue = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERYVALUE")]
        public const int EventTraceTypeRegqueryvalue = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGENUMERATEKEY")]
        public const int EventTraceTypeRegenumeratekey = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGENUMERATEVALUEKEY")]
        public const int EventTraceTypeRegenumeratevaluekey = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERYMULTIPLEVALUE")]
        public const int EventTraceTypeRegquerymultiplevalue = unchecked((int) 0x13);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGSETINFORMATION")]
        public const int EventTraceTypeRegsetinformation = unchecked((int) 0x14);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGFLUSH")]
        public const int EventTraceTypeRegflush = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBCREATE")]
        public const int EventTraceTypeRegkcbcreate = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBDELETE")]
        public const int EventTraceTypeRegkcbdelete = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBRUNDOWNBEGIN")]
        public const int EventTraceTypeRegkcbrundownbegin = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGKCBRUNDOWNEND")]
        public const int EventTraceTypeRegkcbrundownend = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGVIRTUALIZE")]
        public const int EventTraceTypeRegvirtualize = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGCLOSE")]
        public const int EventTraceTypeRegclose = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGSETSECURITY")]
        public const int EventTraceTypeRegsetsecurity = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGQUERYSECURITY")]
        public const int EventTraceTypeRegquerysecurity = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGCOMMIT")]
        public const int EventTraceTypeRegcommit = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGPREPARE")]
        public const int EventTraceTypeRegprepare = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGROLLBACK")]
        public const int EventTraceTypeRegrollback = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_REGMOUNTHIVE")]
        public const int EventTraceTypeRegmounthive = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_CPU")]
        public const int EventTraceTypeConfigCpu = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PHYSICALDISK")]
        public const int EventTraceTypeConfigPhysicaldisk = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_LOGICALDISK")]
        public const int EventTraceTypeConfigLogicaldisk = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_NIC")]
        public const int EventTraceTypeConfigNic = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_VIDEO")]
        public const int EventTraceTypeConfigVideo = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_SERVICES")]
        public const int EventTraceTypeConfigServices = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_POWER")]
        public const int EventTraceTypeConfigPower = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_NETINFO")]
        public const int EventTraceTypeConfigNetinfo = unchecked((int) 0x11);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_OPTICALMEDIA")]
        public const int EventTraceTypeConfigOpticalmedia = unchecked((int) 0x12);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_IRQ")]
        public const int EventTraceTypeConfigIrq = unchecked((int) 0x15);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PNP")]
        public const int EventTraceTypeConfigPnp = unchecked((int) 0x16);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_IDECHANNEL")]
        public const int EventTraceTypeConfigIdechannel = unchecked((int) 0x17);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_NUMANODE")]
        public const int EventTraceTypeConfigNumanode = unchecked((int) 0x18);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PLATFORM")]
        public const int EventTraceTypeConfigPlatform = unchecked((int) 0x19);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PROCESSORGROUP")]
        public const int EventTraceTypeConfigProcessorgroup = unchecked((int) 0x1A);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PROCESSORNUMBER")]
        public const int EventTraceTypeConfigProcessornumber = unchecked((int) 0x1B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_DPI")]
        public const int EventTraceTypeConfigDpi = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_CI_INFO")]
        public const int EventTraceTypeConfigCIInfo = unchecked((int) 0x1D);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_MACHINEID")]
        public const int EventTraceTypeConfigMachineid = unchecked((int) 0x1E);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_DEFRAG")]
        public const int EventTraceTypeConfigDefrag = unchecked((int) 0x1F);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_MOBILEPLATFORM")]
        public const int EventTraceTypeConfigMobileplatform = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_DEVICEFAMILY")]
        public const int EventTraceTypeConfigDevicefamily = unchecked((int) 0x21);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_FLIGHTID")]
        public const int EventTraceTypeConfigFlightid = unchecked((int) 0x22);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_PROCESSOR")]
        public const int EventTraceTypeConfigProcessor = unchecked((int) 0x23);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_VIRTUALIZATION")]
        public const int EventTraceTypeConfigVirtualization = unchecked((int) 0x24);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_CONFIG_BOOT")]
        public const int EventTraceTypeConfigBoot = unchecked((int) 0x25);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_READ")]
        public const int EventTraceTypeOpticalIORead = unchecked((int) 0x37);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_WRITE")]
        public const int EventTraceTypeOpticalIOWrite = unchecked((int) 0x38);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_FLUSH")]
        public const int EventTraceTypeOpticalIOFlush = unchecked((int) 0x39);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_READ_INIT")]
        public const int EventTraceTypeOpticalIOReadInit = unchecked((int) 0x3A);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_WRITE_INIT")]
        public const int EventTraceTypeOpticalIOWriteInit = unchecked((int) 0x3B);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_OPTICAL_IO_FLUSH_INIT")]
        public const int EventTraceTypeOpticalIOFlushInit = unchecked((int) 0x3C);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_PREOP_INIT")]
        public const int EventTraceTypeFltPreopInit = unchecked((int) 0x60);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_POSTOP_INIT")]
        public const int EventTraceTypeFltPostopInit = unchecked((int) 0x61);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_PREOP_COMPLETION")]
        public const int EventTraceTypeFltPreopCompletion = unchecked((int) 0x62);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_POSTOP_COMPLETION")]
        public const int EventTraceTypeFltPostopCompletion = unchecked((int) 0x63);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_PREOP_FAILURE")]
        public const int EventTraceTypeFltPreopFailure = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_TYPE_FLT_POSTOP_FAILURE")]
        public const int EventTraceTypeFltPostopFailure = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_PROCESS")]
        public const int EventTraceFlagProcess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_THREAD")]
        public const int EventTraceFlagThread = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_IMAGE_LOAD")]
        public const int EventTraceFlagImageLoad = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISK_IO")]
        public const int EventTraceFlagDiskIO = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISK_FILE_IO")]
        public const int EventTraceFlagDiskFileIO = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_MEMORY_PAGE_FAULTS")]
        public const int EventTraceFlagMemoryPageFaults = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_MEMORY_HARD_FAULTS")]
        public const int EventTraceFlagMemoryHardFaults = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_NETWORK_TCPIP")]
        public const int EventTraceFlagNetworkTcpip = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_REGISTRY")]
        public const int EventTraceFlagRegistry = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DBGPRINT")]
        public const int EventTraceFlagDbgprint = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_PROCESS_COUNTERS")]
        public const int EventTraceFlagProcessCounters = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_CSWITCH")]
        public const int EventTraceFlagCswitch = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DPC")]
        public const int EventTraceFlagDpc = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_INTERRUPT")]
        public const int EventTraceFlagInterrupt = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_SYSTEMCALL")]
        public const int EventTraceFlagSystemcall = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISK_IO_INIT")]
        public const int EventTraceFlagDiskIOInit = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_ALPC")]
        public const int EventTraceFlagAlpc = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_SPLIT_IO")]
        public const int EventTraceFlagSplitIO = unchecked((int) 0x200000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DRIVER")]
        public const int EventTraceFlagDriver = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_PROFILE")]
        public const int EventTraceFlagProfile = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_FILE_IO")]
        public const int EventTraceFlagFileIO = unchecked((int) 0x2000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_FILE_IO_INIT")]
        public const int EventTraceFlagFileIOInit = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DISPATCHER")]
        public const int EventTraceFlagDispatcher = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_VIRTUAL_ALLOC")]
        public const int EventTraceFlagVirtualAlloc = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_VAMAP")]
        public const int EventTraceFlagVamap = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_NO_SYSCONFIG")]
        public const int EventTraceFlagNoSysconfig = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_JOB")]
        public const int EventTraceFlagJob = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_DEBUG_EVENTS")]
        public const int EventTraceFlagDebugEvents = unchecked((int) 0x400000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_EXTENSION")]
        public const uint EventTraceFlagExtension = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_FORWARD_WMI")]
        public const int EventTraceFlagForwardWmi = unchecked((int) 0x40000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FLAG_ENABLE_RESERVE")]
        public const int EventTraceFlagEnableReserve = unchecked((int) 0x20000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_NONE")]
        public const int EventTraceFileModeNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_SEQUENTIAL")]
        public const int EventTraceFileModeSequential = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_CIRCULAR")]
        public const int EventTraceFileModeCircular = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_APPEND")]
        public const int EventTraceFileModeAppend = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_REAL_TIME_MODE")]
        public const int EventTraceRealTimeMode = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_DELAY_OPEN_FILE_MODE")]
        public const int EventTraceDelayOpenFileMode = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_BUFFERING_MODE")]
        public const int EventTraceBufferingMode = unchecked((int) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_PRIVATE_LOGGER_MODE")]
        public const int EventTracePrivateLoggerMode = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_ADD_HEADER_MODE")]
        public const int EventTraceAddHeaderMode = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_GLOBAL_SEQUENCE")]
        public const int EventTraceUseGlobalSequence = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_LOCAL_SEQUENCE")]
        public const int EventTraceUseLocalSequence = unchecked((int) 0x8000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_RELOG_MODE")]
        public const int EventTraceRelogMode = unchecked((int) 0x10000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_PAGED_MEMORY")]
        public const int EventTraceUsePagedMemory = unchecked((int) 0x1000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_NEWFILE")]
        public const int EventTraceFileModeNewfile = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_FILE_MODE_PREALLOCATE")]
        public const int EventTraceFileModePreallocate = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_NONSTOPPABLE_MODE")]
        public const int EventTraceNonstoppableMode = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_SECURE_MODE")]
        public const int EventTraceSecureMode = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_KBYTES_FOR_SIZE")]
        public const int EventTraceUseKbytesForSize = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_PRIVATE_IN_PROC")]
        public const int EventTracePrivateInProc = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_MODE_RESERVED")]
        public const int EventTraceModeReserved = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_NO_PER_PROCESSOR_BUFFERING")]
        public const int EventTraceNoPerProcessorBuffering = unchecked((int) 0x10000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_SYSTEM_LOGGER_MODE")]
        public const int EventTraceSystemLoggerMode = unchecked((int) 0x2000000);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "EVENT_TRACE_ADDTO_TRIAGE_DUMP")]
        public const uint EventTraceAddtoTriageDump = unchecked((uint) 0xFFFFFFFF80000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_STOP_ON_HYBRID_SHUTDOWN")]
        public const int EventTraceStopOnHybridShutdown = unchecked((int) 0x400000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_PERSIST_ON_HYBRID_SHUTDOWN")]
        public const int EventTracePersistOnHybridShutdown = unchecked((int) 0x800000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_INDEPENDENT_SESSION_MODE")]
        public const int EventTraceIndependentSessionMode = unchecked((int) 0x8000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_COMPRESSED_MODE")]
        public const int EventTraceCompressedMode = unchecked((int) 0x4000000);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_QUERY")]
        public const int EventTraceControlQuery = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_STOP")]
        public const int EventTraceControlStop = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_UPDATE")]
        public const int EventTraceControlUpdate = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_FLUSH")]
        public const int EventTraceControlFlush = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_CONTROL_INCREMENT_FILE")]
        public const int EventTraceControlIncrementFile = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_SEQUENCE")]
        public const int TraceMessageSequence = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_GUID")]
        public const int TraceMessageGuid = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_COMPONENTID")]
        public const int TraceMessageComponentid = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_TIMESTAMP")]
        public const int TraceMessageTimestamp = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_PERFORMANCE_TIMESTAMP")]
        public const int TraceMessagePerformanceTimestamp = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_SYSTEMINFO")]
        public const int TraceMessageSysteminfo = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_POINTER32")]
        public const int TraceMessagePointer32 = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_POINTER64")]
        public const int TraceMessagePointer64 = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_MESSAGE_FLAG_MASK")]
        public const int TraceMessageFlagMask = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_PROCTIME")]
        public const int EventTraceUseProctime = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_TRACE_USE_NOCPUTIME")]
        public const int EventTraceUseNocputime = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_USE_TIMESTAMP")]
        public const int TraceHeaderFlagUseTimestamp = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_TRACED_GUID")]
        public const int TraceHeaderFlagTracedGuid = unchecked((int) 0x20000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_LOG_WNODE")]
        public const int TraceHeaderFlagLogWnode = unchecked((int) 0x40000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_USE_GUID_PTR")]
        public const int TraceHeaderFlagUseGuidPtr = unchecked((int) 0x80000);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_HEADER_FLAG_USE_MOF_PTR")]
        public const int TraceHeaderFlagUseMofPtr = unchecked((int) 0x100000);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_NULL_TYPE_VALUE")]
        public const int EtwNullTypeValue = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_OBJECT_TYPE_VALUE")]
        public const int EtwObjectTypeValue = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_STRING_TYPE_VALUE")]
        public const int EtwStringTypeValue = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SBYTE_TYPE_VALUE")]
        public const int EtwSbyteTypeValue = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_BYTE_TYPE_VALUE")]
        public const int EtwByteTypeValue = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_INT16_TYPE_VALUE")]
        public const int EtwInt16TypeValue = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_UINT16_TYPE_VALUE")]
        public const int EtwUint16TypeValue = unchecked((int) 0x6);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_INT32_TYPE_VALUE")]
        public const int EtwInt32TypeValue = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_UINT32_TYPE_VALUE")]
        public const int EtwUint32TypeValue = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_INT64_TYPE_VALUE")]
        public const int EtwInt64TypeValue = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_UINT64_TYPE_VALUE")]
        public const int EtwUint64TypeValue = unchecked((int) 0xA);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_CHAR_TYPE_VALUE")]
        public const int EtwCharTypeValue = unchecked((int) 0xB);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SINGLE_TYPE_VALUE")]
        public const int EtwSingleTypeValue = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_DOUBLE_TYPE_VALUE")]
        public const int EtwDoubleTypeValue = unchecked((int) 0xD);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_BOOLEAN_TYPE_VALUE")]
        public const int EtwBooleanTypeValue = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_DECIMAL_TYPE_VALUE")]
        public const int EtwDecimalTypeValue = unchecked((int) 0xF);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_GUID_TYPE_VALUE")]
        public const int EtwGuidTypeValue = unchecked((int) 0x65);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_ASCIICHAR_TYPE_VALUE")]
        public const int EtwAsciicharTypeValue = unchecked((int) 0x66);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_ASCIISTRING_TYPE_VALUE")]
        public const int EtwAsciistringTypeValue = unchecked((int) 0x67);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_COUNTED_STRING_TYPE_VALUE")]
        public const int EtwCountedStringTypeValue = unchecked((int) 0x68);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_POINTER_TYPE_VALUE")]
        public const int EtwPointerTypeValue = unchecked((int) 0x69);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SIZET_TYPE_VALUE")]
        public const int EtwSizetTypeValue = unchecked((int) 0x6A);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_HIDDEN_TYPE_VALUE")]
        public const int EtwHiddenTypeValue = unchecked((int) 0x6B);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_BOOL_TYPE_VALUE")]
        public const int EtwBoolTypeValue = unchecked((int) 0x6C);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_COUNTED_ANSISTRING_TYPE_VALUE")]
        public const int EtwCountedAnsistringTypeValue = unchecked((int) 0x6D);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REVERSED_COUNTED_STRING_TYPE_VALUE")]
        public const int EtwReversedCountedStringTypeValue = unchecked((int) 0x6E);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REVERSED_COUNTED_ANSISTRING_TYPE_VALUE")]
        public const int EtwReversedCountedAnsistringTypeValue = unchecked((int) 0x6F);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_NON_NULL_TERMINATED_STRING_TYPE_VALUE")]
        public const int EtwNonNullTerminatedStringTypeValue = unchecked((int) 0x70);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REDUCED_ANSISTRING_TYPE_VALUE")]
        public const int EtwReducedAnsistringTypeValue = unchecked((int) 0x71);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REDUCED_STRING_TYPE_VALUE")]
        public const int EtwReducedStringTypeValue = unchecked((int) 0x72);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_SID_TYPE_VALUE")]
        public const int EtwSidTypeValue = unchecked((int) 0x73);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_VARIANT_TYPE_VALUE")]
        public const int EtwVariantTypeValue = unchecked((int) 0x74);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_PTVECTOR_TYPE_VALUE")]
        public const int EtwPtvectorTypeValue = unchecked((int) 0x75);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_WMITIME_TYPE_VALUE")]
        public const int EtwWmitimeTypeValue = unchecked((int) 0x76);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_DATETIME_TYPE_VALUE")]
        public const int EtwDatetimeTypeValue = unchecked((int) 0x77);
        [NativeName("Type", "int")]
        [NativeName("Name", "ETW_REFRENCE_TYPE_VALUE")]
        public const int EtwRefrenceTypeValue = unchecked((int) 0x78);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_PROVIDER_FLAG_LEGACY")]
        public const int TraceProviderFlagLegacy = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACE_PROVIDER_FLAG_PRE_ENABLE")]
        public const int TraceProviderFlagPreEnable = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_CONTROL_CODE_DISABLE_PROVIDER")]
        public const int EventControlCodeDisableProvider = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_CONTROL_CODE_ENABLE_PROVIDER")]
        public const int EventControlCodeEnableProvider = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "EVENT_CONTROL_CODE_CAPTURE_STATE")]
        public const int EventControlCodeCaptureState = unchecked((int) 0x2);
        [NativeName("Type", "")]
        [NativeName("Name", "KERNEL_LOGGER_NAME")]
        public const string KernelLoggerName = unchecked((string) "NT Kernel Logger");
        [NativeName("Type", "")]
        [NativeName("Name", "GLOBAL_LOGGER_NAME")]
        public const string GlobalLoggerName = unchecked((string) "GlobalLogger");
        [NativeName("Type", "")]
        [NativeName("Name", "EVENT_LOGGER_NAME")]
        public const string EventLoggerName = unchecked((string) "EventLog");
        [NativeName("Type", "int")]
        [NativeName("Name", "ENABLE_TRACE_PARAMETERS_VERSION")]
        public const int EnableTraceParametersVersion = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ENABLE_TRACE_PARAMETERS_VERSION_2")]
        public const int EnableTraceParametersVersion2 = unchecked((int) 0x2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ulong* TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public partial uint StartTraceW(ref ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public unsafe partial uint StartTraceW(ref ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1260, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceW")]
        public partial uint StartTraceW(ref ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ulong* TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public partial uint StartTraceA(ref ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public unsafe partial uint StartTraceA(ref ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1275, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StartTraceA")]
        public partial uint StartTraceA(ref ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW")]
        public unsafe partial uint StopTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW")]
        public unsafe partial uint StopTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW")]
        public unsafe partial uint StopTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW")]
        public partial uint StopTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW")]
        public unsafe partial uint StopTraceW(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1302, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceW")]
        public partial uint StopTraceW(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA")]
        public unsafe partial uint StopTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA")]
        public unsafe partial uint StopTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA")]
        public unsafe partial uint StopTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA")]
        public partial uint StopTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA")]
        public unsafe partial uint StopTraceA(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1317, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "StopTraceA")]
        public partial uint StopTraceA(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW")]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW")]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW")]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW")]
        public partial uint QueryTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW")]
        public unsafe partial uint QueryTraceW(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1343, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceW")]
        public partial uint QueryTraceW(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA")]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA")]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA")]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA")]
        public partial uint QueryTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA")]
        public unsafe partial uint QueryTraceA(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1358, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceA")]
        public partial uint QueryTraceA(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW")]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW")]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW")]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW")]
        public partial uint UpdateTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW")]
        public unsafe partial uint UpdateTraceW(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1378, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceW")]
        public partial uint UpdateTraceW(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA")]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA")]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA")]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA")]
        public partial uint UpdateTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA")]
        public unsafe partial uint UpdateTraceA(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1387, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UpdateTraceA")]
        public partial uint UpdateTraceA(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW")]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW")]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW")]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW")]
        public partial uint FlushTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW")]
        public unsafe partial uint FlushTraceW(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1415, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceW")]
        public partial uint FlushTraceW(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA")]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA")]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA")]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA")]
        public partial uint FlushTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA")]
        public unsafe partial uint FlushTraceA(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1432, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "FlushTraceA")]
        public partial uint FlushTraceA(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW")]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, char* InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW")]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, char* InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW")]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, ref char InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW")]
        public partial uint ControlTraceW(ulong TraceHandle, ref char InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW")]
        public unsafe partial uint ControlTraceW(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1451, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceW")]
        public partial uint ControlTraceW(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA")]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, byte* InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA")]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, byte* InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA")]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, ref byte InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA")]
        public partial uint ControlTraceA(ulong TraceHandle, ref byte InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA")]
        public unsafe partial uint ControlTraceA(ulong TraceHandle, string InstanceName, EventTraceProperties* Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1467, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ControlTraceA")]
        public partial uint ControlTraceA(ulong TraceHandle, string InstanceName, ref EventTraceProperties Properties, uint ControlCode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW")]
        public unsafe partial uint QueryAllTracesW(EventTraceProperties** PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW")]
        public unsafe partial uint QueryAllTracesW(EventTraceProperties** PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW")]
        public unsafe partial uint QueryAllTracesW(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1485, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesW")]
        public unsafe partial uint QueryAllTracesW(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA")]
        public unsafe partial uint QueryAllTracesA(EventTraceProperties** PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA")]
        public unsafe partial uint QueryAllTracesA(EventTraceProperties** PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA")]
        public unsafe partial uint QueryAllTracesA(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, uint* LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1494, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryAllTracesA")]
        public unsafe partial uint QueryAllTracesA(ref EventTraceProperties* PropertyArray, uint PropertyArrayCount, ref uint LoggerCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTrace")]
        public unsafe partial uint EnableTrace(uint Enable, uint EnableFlag, uint EnableLevel, Guid* ControlGuid, ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1513, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTrace")]
        public partial uint EnableTrace(uint Enable, uint EnableFlag, uint EnableLevel, ref Guid ControlGuid, ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(Guid* ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(ref Guid ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(ref Guid ProviderId, Guid* SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public unsafe partial uint EnableTraceEx(ref Guid ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, EventFilterDescriptor* EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1535, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx")]
        public partial uint EnableTraceEx(ref Guid ProviderId, ref Guid SourceId, ulong TraceHandle, uint IsEnabled, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint EnableProperty, ref EventFilterDescriptor EnableFilterDesc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2")]
        public unsafe partial uint EnableTraceEx2(ulong TraceHandle, Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2")]
        public unsafe partial uint EnableTraceEx2(ulong TraceHandle, Guid* ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, ref EnableTraceParameters EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2")]
        public unsafe partial uint EnableTraceEx2(ulong TraceHandle, ref Guid ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, EnableTraceParameters* EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1582, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnableTraceEx2")]
        public partial uint EnableTraceEx2(ulong TraceHandle, ref Guid ProviderId, uint ControlCode, byte Level, ulong MatchAnyKeyword, ulong MatchAllKeyword, uint Timeout, ref EnableTraceParameters EnableParameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx<T0>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public unsafe partial uint EnumerateTraceGuidsEx<T0, T1>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1897, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuidsEx")]
        public partial uint EnumerateTraceGuidsEx<T0, T1>(TraceQueryInfoClass TraceQueryInfoClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1943, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceSetInformation")]
        public unsafe partial uint TraceSetInformation(ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1943, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceSetInformation")]
        public partial uint TraceSetInformation<T0>(ulong SessionHandle, TraceQueryInfoClass InformationClass, ref T0 TraceInformation, uint InformationLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation")]
        public unsafe partial uint TraceQueryInformation(ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, uint* ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation")]
        public unsafe partial uint TraceQueryInformation(ulong SessionHandle, TraceQueryInfoClass InformationClass, void* TraceInformation, uint InformationLength, ref uint ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation")]
        public unsafe partial uint TraceQueryInformation<T0>(ulong SessionHandle, TraceQueryInfoClass InformationClass, ref T0 TraceInformation, uint InformationLength, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1955, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceQueryInformation")]
        public partial uint TraceQueryInformation<T0>(ulong SessionHandle, TraceQueryInfoClass InformationClass, ref T0 TraceInformation, uint InformationLength, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId")]
        public unsafe partial uint CreateTraceInstanceId(void* RegHandle, EventInstanceInfo* InstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId")]
        public unsafe partial uint CreateTraceInstanceId(void* RegHandle, ref EventInstanceInfo InstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId")]
        public unsafe partial uint CreateTraceInstanceId<T0>(ref T0 RegHandle, EventInstanceInfo* InstInfo) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1977, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CreateTraceInstanceId")]
        public partial uint CreateTraceInstanceId<T0>(ref T0 RegHandle, ref EventInstanceInfo InstInfo) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1995, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEvent")]
        public unsafe partial uint TraceEvent(ulong TraceHandle, EventTraceHeader* EventTrace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1995, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEvent")]
        public partial uint TraceEvent(ulong TraceHandle, ref EventTraceHeader EventTrace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, EventInstanceInfo* InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, ref EventInstanceInfo InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, EventInstanceHeader* EventTrace, ref EventInstanceInfo InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, EventInstanceInfo* InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, EventInstanceInfo* InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public unsafe partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, ref EventInstanceInfo InstInfo, EventInstanceInfo* ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2009, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceEventInstance")]
        public partial uint TraceEventInstance(ulong TraceHandle, ref EventInstanceHeader EventTrace, ref EventInstanceInfo InstInfo, ref EventInstanceInfo ParentInstInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, char* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref char MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, char* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref char MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public unsafe partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2043, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsW")]
        public partial uint RegisterTraceGuidsW<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA(PfnWmidprequest RequestAddress, void* RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, Guid* ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, TraceGuidRegistration* TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, byte* MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, ref byte MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, byte* MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, ref byte MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public unsafe partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ulong* RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2063, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RegisterTraceGuidsA")]
        public partial uint RegisterTraceGuidsA<T0>(PfnWmidprequest RequestAddress, ref T0 RequestContext, ref Guid ControlGuid, uint GuidCount, ref TraceGuidRegistration TraceGuidReg, string MofImagePath, string MofResourceName, ref ulong RegistrationHandle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2078, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids")]
        public unsafe partial uint EnumerateTraceGuids(TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, uint* GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2078, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids")]
        public unsafe partial uint EnumerateTraceGuids(TraceGuidProperties** GuidPropertiesArray, uint PropertyArrayCount, ref uint GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2078, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids")]
        public unsafe partial uint EnumerateTraceGuids(ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, uint* GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2078, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "EnumerateTraceGuids")]
        public unsafe partial uint EnumerateTraceGuids(ref TraceGuidProperties* GuidPropertiesArray, uint PropertyArrayCount, ref uint GuidCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2094, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "UnregisterTraceGuids")]
        public partial uint UnregisterTraceGuids(ulong RegistrationHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2101, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceLoggerHandle")]
        public unsafe partial ulong GetTraceLoggerHandle(void* Buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2101, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceLoggerHandle")]
        public partial ulong GetTraceLoggerHandle<T0>(ref T0 Buffer) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2108, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceEnableLevel")]
        public partial byte GetTraceEnableLevel(ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2115, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "GetTraceEnableFlags")]
        public partial uint GetTraceEnableFlags(ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2140, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceW")]
        public unsafe partial ulong OpenTraceW(EventTraceLogfilew* Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2140, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceW")]
        public partial ulong OpenTraceW(ref EventTraceLogfilew Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, _FILETIME* StartTime, _FILETIME* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, _FILETIME* StartTime, ref _FILETIME EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, ref _FILETIME StartTime, _FILETIME* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ulong* HandleArray, uint HandleCount, ref _FILETIME StartTime, ref _FILETIME EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, _FILETIME* StartTime, _FILETIME* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, _FILETIME* StartTime, ref _FILETIME EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public unsafe partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, ref _FILETIME StartTime, _FILETIME* EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2148, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "ProcessTrace")]
        public partial uint ProcessTrace(ref ulong HandleArray, uint HandleCount, ref _FILETIME StartTime, ref _FILETIME EndTime);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2159, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "CloseTrace")]
        public partial uint CloseTrace(ulong TraceHandle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, void* InBuffer, uint InBufferSize, ref T0 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle<T0>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, void* OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public unsafe partial uint QueryTraceProcessingHandle<T0, T1>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, uint* ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2193, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "QueryTraceProcessingHandle")]
        public partial uint QueryTraceProcessingHandle<T0, T1>(ulong ProcessingHandle, EtwProcessHandleInfoType InformationClass, ref T0 InBuffer, uint InBufferSize, ref T1 OutBuffer, uint OutBufferSize, ref uint ReturnLength) where T0 : unmanaged where T1 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2223, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceA")]
        public unsafe partial ulong OpenTraceA(EventTraceLogfilea* Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2223, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "OpenTraceA")]
        public partial ulong OpenTraceA(ref EventTraceLogfilea Logfile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2230, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "SetTraceCallback")]
        public unsafe partial uint SetTraceCallback(Guid* pGuid, PfnPeventCallback EventCallback);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2230, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "SetTraceCallback")]
        public partial uint SetTraceCallback(ref Guid pGuid, PfnPeventCallback EventCallback);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RemoveTraceCallback")]
        public unsafe partial uint RemoveTraceCallback(Guid* pGuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "RemoveTraceCallback")]
        public partial uint RemoveTraceCallback(ref Guid pGuid);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2255, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessage")]
        public unsafe partial uint TraceMessage(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2255, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessage")]
        public partial uint TraceMessage(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa")]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, byte* MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa")]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, ref byte MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa")]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, Guid* MessageGuid, ushort MessageNumber, string MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa")]
        public unsafe partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber, byte* MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa")]
        public partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber, ref byte MessageArgList);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2271, Column 1 in C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/shared\\evntrace.h")]
        [NativeApi(EntryPoint = "TraceMessageVa")]
        public partial uint TraceMessageVa(ulong LoggerHandle, uint MessageFlags, ref Guid MessageGuid, ushort MessageNumber, string MessageArgList);


        public EventTrace(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

