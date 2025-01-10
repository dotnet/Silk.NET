// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetNumberOfInterfaces([NativeTypeName("PDWORD")] uint* pdwNumIf);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetIfEntry([NativeTypeName("PMIB_IFROW")] MIB_IFROW* pIfRow);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetIfTable(
        [NativeTypeName("PMIB_IFTABLE")] MIB_IFTABLE* pIfTable,
        [NativeTypeName("PULONG")] uint* pdwSize,
        BOOL bOrder
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetIpAddrTable(
        [NativeTypeName("PMIB_IPADDRTABLE")] MIB_IPADDRTABLE* pIpAddrTable,
        [NativeTypeName("PULONG")] uint* pdwSize,
        BOOL bOrder
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetIpNetTable(
        [NativeTypeName("PMIB_IPNETTABLE")] MIB_IPNETTABLE* IpNetTable,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetIpForwardTable(
        [NativeTypeName("PMIB_IPFORWARDTABLE")] MIB_IPFORWARDTABLE* pIpForwardTable,
        [NativeTypeName("PULONG")] uint* pdwSize,
        BOOL bOrder
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetTcpTable(
        [NativeTypeName("PMIB_TCPTABLE")] MIB_TCPTABLE* TcpTable,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetExtendedTcpTable(
        [NativeTypeName("PVOID")] void* pTcpTable,
        [NativeTypeName("PDWORD")] uint* pdwSize,
        BOOL bOrder,
        [NativeTypeName("ULONG")] uint ulAf,
        TCP_TABLE_CLASS TableClass,
        [NativeTypeName("ULONG")] uint Reserved
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetOwnerModuleFromTcpEntry(
        [NativeTypeName("PMIB_TCPROW_OWNER_MODULE")] MIB_TCPROW_OWNER_MODULE* pTcpEntry,
        TCPIP_OWNER_MODULE_INFO_CLASS Class,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("PDWORD")] uint* pdwSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetUdpTable(
        [NativeTypeName("PMIB_UDPTABLE")] MIB_UDPTABLE* UdpTable,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetExtendedUdpTable(
        [NativeTypeName("PVOID")] void* pUdpTable,
        [NativeTypeName("PDWORD")] uint* pdwSize,
        BOOL bOrder,
        [NativeTypeName("ULONG")] uint ulAf,
        UDP_TABLE_CLASS TableClass,
        [NativeTypeName("ULONG")] uint Reserved
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetOwnerModuleFromUdpEntry(
        [NativeTypeName("PMIB_UDPROW_OWNER_MODULE")] MIB_UDPROW_OWNER_MODULE* pUdpEntry,
        TCPIP_OWNER_MODULE_INFO_CLASS Class,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("PDWORD")] uint* pdwSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetTcpTable2(
        [NativeTypeName("PMIB_TCPTABLE2")] MIB_TCPTABLE2* TcpTable,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetTcp6Table(
        [NativeTypeName("PMIB_TCP6TABLE")] MIB_TCP6TABLE* TcpTable,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetTcp6Table2(
        [NativeTypeName("PMIB_TCP6TABLE2")] MIB_TCP6TABLE2* TcpTable,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetPerTcpConnectionEStats(
        [NativeTypeName("PMIB_TCPROW")] MIB_TCPROW_LH* Row,
        TCP_ESTATS_TYPE EstatsType,
        [NativeTypeName("PUCHAR")] byte* Rw,
        [NativeTypeName("ULONG")] uint RwVersion,
        [NativeTypeName("ULONG")] uint RwSize,
        [NativeTypeName("PUCHAR")] byte* Ros,
        [NativeTypeName("ULONG")] uint RosVersion,
        [NativeTypeName("ULONG")] uint RosSize,
        [NativeTypeName("PUCHAR")] byte* Rod,
        [NativeTypeName("ULONG")] uint RodVersion,
        [NativeTypeName("ULONG")] uint RodSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint SetPerTcpConnectionEStats(
        [NativeTypeName("PMIB_TCPROW")] MIB_TCPROW_LH* Row,
        TCP_ESTATS_TYPE EstatsType,
        [NativeTypeName("PUCHAR")] byte* Rw,
        [NativeTypeName("ULONG")] uint RwVersion,
        [NativeTypeName("ULONG")] uint RwSize,
        [NativeTypeName("ULONG")] uint Offset
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetPerTcp6ConnectionEStats(
        [NativeTypeName("PMIB_TCP6ROW")] MIB_TCP6ROW* Row,
        TCP_ESTATS_TYPE EstatsType,
        [NativeTypeName("PUCHAR")] byte* Rw,
        [NativeTypeName("ULONG")] uint RwVersion,
        [NativeTypeName("ULONG")] uint RwSize,
        [NativeTypeName("PUCHAR")] byte* Ros,
        [NativeTypeName("ULONG")] uint RosVersion,
        [NativeTypeName("ULONG")] uint RosSize,
        [NativeTypeName("PUCHAR")] byte* Rod,
        [NativeTypeName("ULONG")] uint RodVersion,
        [NativeTypeName("ULONG")] uint RodSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint SetPerTcp6ConnectionEStats(
        [NativeTypeName("PMIB_TCP6ROW")] MIB_TCP6ROW* Row,
        TCP_ESTATS_TYPE EstatsType,
        [NativeTypeName("PUCHAR")] byte* Rw,
        [NativeTypeName("ULONG")] uint RwVersion,
        [NativeTypeName("ULONG")] uint RwSize,
        [NativeTypeName("ULONG")] uint Offset
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetOwnerModuleFromTcp6Entry(
        [NativeTypeName("PMIB_TCP6ROW_OWNER_MODULE")] MIB_TCP6ROW_OWNER_MODULE* pTcpEntry,
        TCPIP_OWNER_MODULE_INFO_CLASS Class,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("PDWORD")] uint* pdwSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetUdp6Table(
        [NativeTypeName("PMIB_UDP6TABLE")] MIB_UDP6TABLE* Udp6Table,
        [NativeTypeName("PULONG")] uint* SizePointer,
        BOOL Order
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetOwnerModuleFromUdp6Entry(
        [NativeTypeName("PMIB_UDP6ROW_OWNER_MODULE")] MIB_UDP6ROW_OWNER_MODULE* pUdpEntry,
        TCPIP_OWNER_MODULE_INFO_CLASS Class,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("PDWORD")] uint* pdwSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetOwnerModuleFromPidAndInfo(
        [NativeTypeName("ULONG")] uint ulPid,
        [NativeTypeName("ULONGLONG *")] ulong* pInfo,
        TCPIP_OWNER_MODULE_INFO_CLASS Class,
        [NativeTypeName("PVOID")] void* pBuffer,
        [NativeTypeName("PDWORD")] uint* pdwSize
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetIpStatistics(
        [NativeTypeName("PMIB_IPSTATS")] MIB_IPSTATS_LH* Statistics
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetIcmpStatistics([NativeTypeName("PMIB_ICMP")] MIB_ICMP* Statistics);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetTcpStatistics(
        [NativeTypeName("PMIB_TCPSTATS")] MIB_TCPSTATS_LH* Statistics
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetUdpStatistics(
        [NativeTypeName("PMIB_UDPSTATS")] MIB_UDPSTATS* Stats
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint SetIpStatisticsEx(
        [NativeTypeName("PMIB_IPSTATS")] MIB_IPSTATS_LH* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetIpStatisticsEx(
        [NativeTypeName("PMIB_IPSTATS")] MIB_IPSTATS_LH* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetIcmpStatisticsEx(
        [NativeTypeName("PMIB_ICMP_EX")] MIB_ICMP_EX_XPSP1* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetTcpStatisticsEx(
        [NativeTypeName("PMIB_TCPSTATS")] MIB_TCPSTATS_LH* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetUdpStatisticsEx(
        [NativeTypeName("PMIB_UDPSTATS")] MIB_UDPSTATS* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern uint GetTcpStatisticsEx2(
        [NativeTypeName("PMIB_TCPSTATS2")] MIB_TCPSTATS2* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.16299.0")]
    public static extern uint GetUdpStatisticsEx2(
        [NativeTypeName("PMIB_UDPSTATS2")] MIB_UDPSTATS2* Statistics,
        [NativeTypeName("ULONG")] uint Family
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetIfEntry([NativeTypeName("PMIB_IFROW")] MIB_IFROW* pIfRow);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CreateIpForwardEntry(
        [NativeTypeName("PMIB_IPFORWARDROW")] MIB_IPFORWARDROW* pRoute
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetIpForwardEntry(
        [NativeTypeName("PMIB_IPFORWARDROW")] MIB_IPFORWARDROW* pRoute
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DeleteIpForwardEntry(
        [NativeTypeName("PMIB_IPFORWARDROW")] MIB_IPFORWARDROW* pRoute
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetIpStatistics(
        [NativeTypeName("PMIB_IPSTATS")] MIB_IPSTATS_LH* pIpStats
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetIpTTL(uint nTTL);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CreateIpNetEntry(
        [NativeTypeName("PMIB_IPNETROW")] MIB_IPNETROW_LH* pArpEntry
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetIpNetEntry(
        [NativeTypeName("PMIB_IPNETROW")] MIB_IPNETROW_LH* pArpEntry
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DeleteIpNetEntry(
        [NativeTypeName("PMIB_IPNETROW")] MIB_IPNETROW_LH* pArpEntry
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint FlushIpNetTable([NativeTypeName("DWORD")] uint dwIfIndex);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CreateProxyArpEntry(
        [NativeTypeName("DWORD")] uint dwAddress,
        [NativeTypeName("DWORD")] uint dwMask,
        [NativeTypeName("DWORD")] uint dwIfIndex
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DeleteProxyArpEntry(
        [NativeTypeName("DWORD")] uint dwAddress,
        [NativeTypeName("DWORD")] uint dwMask,
        [NativeTypeName("DWORD")] uint dwIfIndex
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SetTcpEntry([NativeTypeName("PMIB_TCPROW")] MIB_TCPROW_LH* pTcpRow);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetInterfaceInfo(
        [NativeTypeName("PIP_INTERFACE_INFO")] IP_INTERFACE_INFO* pIfTable,
        [NativeTypeName("PULONG")] uint* dwOutBufLen
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetUniDirectionalAdapterInfo(
        [NativeTypeName("PIP_UNIDIRECTIONAL_ADAPTER_ADDRESS")]
            IP_UNIDIRECTIONAL_ADAPTER_ADDRESS* pIPIfInfo,
        [NativeTypeName("PULONG")] uint* dwOutBufLen
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint NhpAllocateAndGetInterfaceInfoFromStack(
        [NativeTypeName("IP_INTERFACE_NAME_INFO **")] IP_INTERFACE_NAME_INFO_W2KSP1** ppTable,
        [NativeTypeName("PDWORD")] uint* pdwCount,
        BOOL bOrder,
        HANDLE hHeap,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetBestInterface(
        [NativeTypeName("IPAddr")] uint dwDestAddr,
        [NativeTypeName("PDWORD")] uint* pdwBestIfIndex
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetBestInterfaceEx(
        [NativeTypeName("struct sockaddr *")] SOCKADDR* pDestAddr,
        [NativeTypeName("PDWORD")] uint* pdwBestIfIndex
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetBestRoute(
        [NativeTypeName("DWORD")] uint dwDestAddr,
        [NativeTypeName("DWORD")] uint dwSourceAddr,
        [NativeTypeName("PMIB_IPFORWARDROW")] MIB_IPFORWARDROW* pBestRoute
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint NotifyAddrChange(
        [NativeTypeName("PHANDLE")] HANDLE* Handle,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* overlapped
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint NotifyRouteChange(
        [NativeTypeName("PHANDLE")] HANDLE* Handle,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* overlapped
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    public static extern BOOL CancelIPChangeNotify(
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* notifyOverlapped
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetAdapterIndex(
        [NativeTypeName("LPWSTR")] ushort* AdapterName,
        [NativeTypeName("PULONG")] uint* IfIndex
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint AddIPAddress(
        [NativeTypeName("IPAddr")] uint Address,
        [NativeTypeName("IPMask")] uint IpMask,
        [NativeTypeName("DWORD")] uint IfIndex,
        [NativeTypeName("PULONG")] uint* NTEContext,
        [NativeTypeName("PULONG")] uint* NTEInstance
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DeleteIPAddress([NativeTypeName("ULONG")] uint NTEContext);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetNetworkParams(
        [NativeTypeName("PFIXED_INFO")] FIXED_INFO* pFixedInfo,
        [NativeTypeName("PULONG")] uint* pOutBufLen
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetAdaptersInfo(
        [NativeTypeName("PIP_ADAPTER_INFO")] IP_ADAPTER_INFO* AdapterInfo,
        [NativeTypeName("PULONG")] uint* SizePointer
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("PIP_ADAPTER_ORDER_MAP")]
    public static extern IP_ADAPTER_ORDER_MAP* GetAdapterOrderMap();

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint GetAdaptersAddresses(
        [NativeTypeName("ULONG")] uint Family,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PVOID")] void* Reserved,
        [NativeTypeName("PIP_ADAPTER_ADDRESSES")] IP_ADAPTER_ADDRESSES_LH* AdapterAddresses,
        [NativeTypeName("PULONG")] uint* SizePointer
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetPerAdapterInfo(
        [NativeTypeName("ULONG")] uint IfIndex,
        [NativeTypeName("PIP_PER_ADAPTER_INFO")] IP_PER_ADAPTER_INFO_W2KSP1* pPerAdapterInfo,
        [NativeTypeName("PULONG")] uint* pOutBufLen
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint GetInterfaceActiveTimestampCapabilities(
        [NativeTypeName("const NET_LUID *")] NET_LUID_LH* InterfaceLuid,
        [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")]
            INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint GetInterfaceSupportedTimestampCapabilities(
        [NativeTypeName("const NET_LUID *")] NET_LUID_LH* InterfaceLuid,
        [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")]
            INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern uint CaptureInterfaceHardwareCrossTimestamp(
        [NativeTypeName("const NET_LUID *")] NET_LUID_LH* InterfaceLuid,
        [NativeTypeName("PINTERFACE_HARDWARE_CROSSTIMESTAMP")]
            INTERFACE_HARDWARE_CROSSTIMESTAMP* CrossTimestamp
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint RegisterInterfaceTimestampConfigChange(
        [NativeTypeName("PINTERFACE_TIMESTAMP_CONFIG_CHANGE_CALLBACK")]
            delegate* unmanaged<void*, void> Callback,
        [NativeTypeName("PVOID")] void* CallerContext,
        HIFTIMESTAMPCHANGE* NotificationHandle
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern void UnregisterInterfaceTimestampConfigChange(
        HIFTIMESTAMPCHANGE NotificationHandle
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetInterfaceCurrentTimestampCapabilities(
        [NativeTypeName("const NET_LUID *")] NET_LUID_LH* InterfaceLuid,
        [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")]
            INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetInterfaceHardwareTimestampCapabilities(
        [NativeTypeName("const NET_LUID *")] NET_LUID_LH* InterfaceLuid,
        [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")]
            INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint NotifyIfTimestampConfigChange(
        [NativeTypeName("PVOID")] void* CallerContext,
        [NativeTypeName("PINTERFACE_TIMESTAMP_CONFIG_CHANGE_CALLBACK")]
            delegate* unmanaged<void*, void> Callback,
        HIFTIMESTAMPCHANGE* NotificationHandle
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    public static extern void CancelIfTimestampConfigChange(HIFTIMESTAMPCHANGE NotificationHandle);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint IpReleaseAddress(
        [NativeTypeName("PIP_ADAPTER_INDEX_MAP")] IP_ADAPTER_INDEX_MAP* AdapterInfo
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint IpRenewAddress(
        [NativeTypeName("PIP_ADAPTER_INDEX_MAP")] IP_ADAPTER_INDEX_MAP* AdapterInfo
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SendARP(
        [NativeTypeName("IPAddr")] uint DestIP,
        [NativeTypeName("IPAddr")] uint SrcIP,
        [NativeTypeName("PVOID")] void* pMacAddr,
        [NativeTypeName("PULONG")] uint* PhyAddrLen
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetRTTAndHopCount(
        [NativeTypeName("IPAddr")] uint DestIpAddress,
        [NativeTypeName("PULONG")] uint* HopCount,
        [NativeTypeName("ULONG")] uint MaxHops,
        [NativeTypeName("PULONG")] uint* RTT
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetFriendlyIfIndex([NativeTypeName("DWORD")] uint IfIndex);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint EnableRouter(HANDLE* pHandle, OVERLAPPED* pOverlapped);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint UnenableRouter(
        OVERLAPPED* pOverlapped,
        [NativeTypeName("LPDWORD")] uint* lpdwEnableCount
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DisableMediaSense(HANDLE* pHandle, OVERLAPPED* pOverLapped);

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RestoreMediaSense(
        OVERLAPPED* pOverlapped,
        [NativeTypeName("LPDWORD")] uint* lpdwEnableCount
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetIpErrorString(
        [NativeTypeName("IP_STATUS")] uint ErrorCode,
        [NativeTypeName("PWSTR")] ushort* Buffer,
        [NativeTypeName("PDWORD")] uint* Size
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint ResolveNeighbor(
        SOCKADDR* NetworkAddress,
        [NativeTypeName("PVOID")] void* PhysicalAddress,
        [NativeTypeName("PULONG")] uint* PhysicalAddressLength
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint CreatePersistentTcpPortReservation(
        ushort StartPort,
        ushort NumberOfPorts,
        [NativeTypeName("PULONG64")] ulong* Token
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint CreatePersistentUdpPortReservation(
        ushort StartPort,
        ushort NumberOfPorts,
        [NativeTypeName("PULONG64")] ulong* Token
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint DeletePersistentTcpPortReservation(
        ushort StartPort,
        ushort NumberOfPorts
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint DeletePersistentUdpPortReservation(
        ushort StartPort,
        ushort NumberOfPorts
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint LookupPersistentTcpPortReservation(
        ushort StartPort,
        ushort NumberOfPorts,
        [NativeTypeName("PULONG64")] ulong* Token
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint LookupPersistentUdpPortReservation(
        ushort StartPort,
        ushort NumberOfPorts,
        [NativeTypeName("PULONG64")] ulong* Token
    );

    [DllImport("iphlpapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint ParseNetworkString(
        [NativeTypeName("const WCHAR *")] ushort* NetworkString,
        [NativeTypeName("DWORD")] uint Types,
        [NativeTypeName("PNET_ADDRESS_INFO")] NET_ADDRESS_INFO* AddressInfo,
        ushort* PortNumber,
        byte* PrefixLength
    );
}
