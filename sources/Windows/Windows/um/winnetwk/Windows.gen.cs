// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnectionA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnectionA([NativeTypeName("LPCSTR")] sbyte* lpRemoteName, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpLocalName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnectionW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnectionW([NativeTypeName("LPCWSTR")] ushort* lpRemoteName, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpLocalName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnection2A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnection2A([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnection2W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnection2W([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnection3A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnection3A(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnection3W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnection3W(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpUserName, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnection4A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnection4A(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetAddConnection4W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetAddConnection4W(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetCancelConnectionA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetCancelConnectionA([NativeTypeName("LPCSTR")] sbyte* lpName, BOOL fForce);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetCancelConnectionW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetCancelConnectionW([NativeTypeName("LPCWSTR")] ushort* lpName, BOOL fForce);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetCancelConnection2A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetCancelConnection2A([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint dwFlags, BOOL fForce);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetCancelConnection2W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetCancelConnection2W([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint dwFlags, BOOL fForce);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetConnectionA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetConnectionA([NativeTypeName("LPCSTR")] sbyte* lpLocalName, [NativeTypeName("LPSTR")] sbyte* lpRemoteName, [NativeTypeName("LPDWORD")] uint* lpnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetConnectionW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetConnectionW([NativeTypeName("LPCWSTR")] ushort* lpLocalName, [NativeTypeName("LPWSTR")] ushort* lpRemoteName, [NativeTypeName("LPDWORD")] uint* lpnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetRestoreSingleConnectionW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetRestoreSingleConnectionW(HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* lpDevice, BOOL fUseUI);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetUseConnectionA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetUseConnectionA(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPCSTR")] sbyte* lpPassword, [NativeTypeName("LPCSTR")] sbyte* lpUserId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetUseConnectionW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetUseConnectionW(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPCWSTR")] ushort* lpPassword, [NativeTypeName("LPCWSTR")] ushort* lpUserId, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetUseConnection4A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetUseConnection4A(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions, [NativeTypeName("LPSTR")] sbyte* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetUseConnection4W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetUseConnection4W(HWND hwndOwner, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("PVOID")] void* pAuthBuffer, [NativeTypeName("DWORD")] uint cbAuthBuffer, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PBYTE")] byte* lpUseOptions, [NativeTypeName("DWORD")] uint cbUseOptions, [NativeTypeName("LPWSTR")] ushort* lpAccessName, [NativeTypeName("LPDWORD")] uint* lpBufferSize, [NativeTypeName("LPDWORD")] uint* lpResult);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetConnectionDialog"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetConnectionDialog(HWND hwnd, [NativeTypeName("DWORD")] uint dwType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetDisconnectDialog"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetDisconnectDialog(HWND hwnd, [NativeTypeName("DWORD")] uint dwType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetConnectionDialog1A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetConnectionDialog1A([NativeTypeName("LPCONNECTDLGSTRUCTA")] CONNECTDLGSTRUCTA* lpConnDlgStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetConnectionDialog1W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetConnectionDialog1W([NativeTypeName("LPCONNECTDLGSTRUCTW")] CONNECTDLGSTRUCTW* lpConnDlgStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetDisconnectDialog1A"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetDisconnectDialog1A([NativeTypeName("LPDISCDLGSTRUCTA")] DISCDLGSTRUCTA* lpConnDlgStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetDisconnectDialog1W"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetDisconnectDialog1W([NativeTypeName("LPDISCDLGSTRUCTW")] DISCDLGSTRUCTW* lpConnDlgStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetOpenEnumA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetOpenEnumA([NativeTypeName("DWORD")] uint dwScope, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwUsage, [NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPHANDLE")] HANDLE* lphEnum);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetOpenEnumW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetOpenEnumW([NativeTypeName("DWORD")] uint dwScope, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("DWORD")] uint dwUsage, [NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPHANDLE")] HANDLE* lphEnum);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetEnumResourceA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetEnumResourceA(HANDLE hEnum, [NativeTypeName("LPDWORD")] uint* lpcCount, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetEnumResourceW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetEnumResourceW(HANDLE hEnum, [NativeTypeName("LPDWORD")] uint* lpcCount, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetCloseEnum"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetCloseEnum(HANDLE hEnum);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetResourceParentA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetResourceParentA([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetResourceParentW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetResourceParentW([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetResourceInformationA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetResourceInformationA([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer, [NativeTypeName("LPSTR *")] sbyte** lplpSystem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetResourceInformationW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetResourceInformationW([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpcbBuffer, [NativeTypeName("LPWSTR *")] ushort** lplpSystem);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetUniversalNameA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetUniversalNameA([NativeTypeName("LPCSTR")] sbyte* lpLocalPath, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetUniversalNameW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetUniversalNameW([NativeTypeName("LPCWSTR")] ushort* lpLocalPath, [NativeTypeName("DWORD")] uint dwInfoLevel, [NativeTypeName("LPVOID")] void* lpBuffer, [NativeTypeName("LPDWORD")] uint* lpBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetUserA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetUserA([NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("LPSTR")] sbyte* lpUserName, [NativeTypeName("LPDWORD")] uint* lpnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetUserW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetUserW([NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPWSTR")] ushort* lpUserName, [NativeTypeName("LPDWORD")] uint* lpnLength);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetProviderNameA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetProviderNameA([NativeTypeName("DWORD")] uint dwNetType, [NativeTypeName("LPSTR")] sbyte* lpProviderName, [NativeTypeName("LPDWORD")] uint* lpBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetProviderNameW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetProviderNameW([NativeTypeName("DWORD")] uint dwNetType, [NativeTypeName("LPWSTR")] ushort* lpProviderName, [NativeTypeName("LPDWORD")] uint* lpBufferSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetNetworkInformationA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetNetworkInformationA([NativeTypeName("LPCSTR")] sbyte* lpProvider, [NativeTypeName("LPNETINFOSTRUCT")] NETINFOSTRUCT* lpNetInfoStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetNetworkInformationW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetNetworkInformationW([NativeTypeName("LPCWSTR")] ushort* lpProvider, [NativeTypeName("LPNETINFOSTRUCT")] NETINFOSTRUCT* lpNetInfoStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetLastErrorA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetLastErrorA([NativeTypeName("LPDWORD")] uint* lpError, [NativeTypeName("LPSTR")] sbyte* lpErrorBuf, [NativeTypeName("DWORD")] uint nErrorBufSize, [NativeTypeName("LPSTR")] sbyte* lpNameBuf, [NativeTypeName("DWORD")] uint nNameBufSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WNetGetLastErrorW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint WNetGetLastErrorW([NativeTypeName("LPDWORD")] uint* lpError, [NativeTypeName("LPWSTR")] ushort* lpErrorBuf, [NativeTypeName("DWORD")] uint nErrorBufSize, [NativeTypeName("LPWSTR")] ushort* lpNameBuf, [NativeTypeName("DWORD")] uint nNameBufSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MultinetGetConnectionPerformanceA"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MultinetGetConnectionPerformanceA([NativeTypeName("LPNETRESOURCEA")] NETRESOURCEA* lpNetResource, [NativeTypeName("LPNETCONNECTINFOSTRUCT")] NETCONNECTINFOSTRUCT* lpNetConnectInfoStruct);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MultinetGetConnectionPerformanceW"]/*'/>
    [DllImport("mpr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MultinetGetConnectionPerformanceW([NativeTypeName("LPNETRESOURCEW")] NETRESOURCEW* lpNetResource, [NativeTypeName("LPNETCONNECTINFOSTRUCT")] NETCONNECTINFOSTRUCT* lpNetConnectInfoStruct);
    [NativeTypeName("#define RESOURCETYPE_ANY 0x00000000")]
    public const int RESOURCETYPE_ANY = 0x00000000;
    [NativeTypeName("#define RESOURCETYPE_DISK 0x00000001")]
    public const int RESOURCETYPE_DISK = 0x00000001;
    [NativeTypeName("#define RESOURCETYPE_PRINT 0x00000002")]
    public const int RESOURCETYPE_PRINT = 0x00000002;
    [NativeTypeName("#define RESOURCETYPE_RESERVED 0x00000008")]
    public const int RESOURCETYPE_RESERVED = 0x00000008;
    [NativeTypeName("#define RESOURCETYPE_UNKNOWN 0xFFFFFFFF")]
    public const uint RESOURCETYPE_UNKNOWN = 0xFFFFFFFF;
    [NativeTypeName("#define RESOURCEUSAGE_CONNECTABLE 0x00000001")]
    public const int RESOURCEUSAGE_CONNECTABLE = 0x00000001;
    [NativeTypeName("#define RESOURCEUSAGE_CONTAINER 0x00000002")]
    public const int RESOURCEUSAGE_CONTAINER = 0x00000002;
    [NativeTypeName("#define RESOURCEUSAGE_NOLOCALDEVICE 0x00000004")]
    public const int RESOURCEUSAGE_NOLOCALDEVICE = 0x00000004;
    [NativeTypeName("#define RESOURCEUSAGE_SIBLING 0x00000008")]
    public const int RESOURCEUSAGE_SIBLING = 0x00000008;
    [NativeTypeName("#define RESOURCEUSAGE_ATTACHED 0x00000010")]
    public const int RESOURCEUSAGE_ATTACHED = 0x00000010;
    [NativeTypeName("#define RESOURCEUSAGE_ALL (RESOURCEUSAGE_CONNECTABLE | RESOURCEUSAGE_CONTAINER | RESOURCEUSAGE_ATTACHED)")]
    public const int RESOURCEUSAGE_ALL = (0x00000001 | 0x00000002 | 0x00000010);
    [NativeTypeName("#define RESOURCEUSAGE_RESERVED 0x80000000")]
    public const uint RESOURCEUSAGE_RESERVED = 0x80000000;
    [NativeTypeName("#define NETPROPERTY_PERSISTENT 1")]
    public const int NETPROPERTY_PERSISTENT = 1;
    [NativeTypeName("#define WNetAddConnection WNetAddConnectionW")]
    public static delegate*<ushort*, ushort*, ushort*, uint> WNetAddConnection => &WNetAddConnectionW;

    [NativeTypeName("#define WNetAddConnection2 WNetAddConnection2W")]
    public static delegate*<NETRESOURCEW*, ushort*, ushort*, uint, uint> WNetAddConnection2 => &WNetAddConnection2W;

    [NativeTypeName("#define WNetAddConnection3 WNetAddConnection3W")]
    public static delegate*<HWND, NETRESOURCEW*, ushort*, ushort*, uint, uint> WNetAddConnection3 => &WNetAddConnection3W;

    [NativeTypeName("#define WNetAddConnection4 WNetAddConnection4W")]
    public static delegate*<HWND, NETRESOURCEW*, void*, uint, uint, byte*, uint, uint> WNetAddConnection4 => &WNetAddConnection4W;

    [NativeTypeName("#define WNetCancelConnection WNetCancelConnectionW")]
    public static delegate*<ushort*, BOOL, uint> WNetCancelConnection => &WNetCancelConnectionW;

    [NativeTypeName("#define WNetCancelConnection2 WNetCancelConnection2W")]
    public static delegate*<ushort*, uint, BOOL, uint> WNetCancelConnection2 => &WNetCancelConnection2W;

    [NativeTypeName("#define WNetGetConnection WNetGetConnectionW")]
    public static delegate*<ushort*, ushort*, uint*, uint> WNetGetConnection => &WNetGetConnectionW;

    [NativeTypeName("#define WNetUseConnection WNetUseConnectionW")]
    public static delegate*<HWND, NETRESOURCEW*, ushort*, ushort*, uint, ushort*, uint*, uint*, uint> WNetUseConnection => &WNetUseConnectionW;

    [NativeTypeName("#define WNetUseConnection4 WNetUseConnection4W")]
    public static delegate*<HWND, NETRESOURCEW*, void*, uint, uint, byte*, uint, ushort*, uint*, uint*, uint> WNetUseConnection4 => &WNetUseConnection4W;

    [NativeTypeName("#define CONNDLG_RO_PATH 0x00000001")]
    public const int CONNDLG_RO_PATH = 0x00000001;
    [NativeTypeName("#define CONNDLG_CONN_POINT 0x00000002")]
    public const int CONNDLG_CONN_POINT = 0x00000002;
    [NativeTypeName("#define CONNDLG_USE_MRU 0x00000004")]
    public const int CONNDLG_USE_MRU = 0x00000004;
    [NativeTypeName("#define CONNDLG_HIDE_BOX 0x00000008")]
    public const int CONNDLG_HIDE_BOX = 0x00000008;
    [NativeTypeName("#define CONNDLG_PERSIST 0x00000010")]
    public const int CONNDLG_PERSIST = 0x00000010;
    [NativeTypeName("#define CONNDLG_NOT_PERSIST 0x00000020")]
    public const int CONNDLG_NOT_PERSIST = 0x00000020;
    [NativeTypeName("#define WNetConnectionDialog1 WNetConnectionDialog1W")]
    public static delegate*<CONNECTDLGSTRUCTW*, uint> WNetConnectionDialog1 => &WNetConnectionDialog1W;

    [NativeTypeName("#define DISC_UPDATE_PROFILE 0x00000001")]
    public const int DISC_UPDATE_PROFILE = 0x00000001;
    [NativeTypeName("#define DISC_NO_FORCE 0x00000040")]
    public const int DISC_NO_FORCE = 0x00000040;
    [NativeTypeName("#define WNetDisconnectDialog1 WNetDisconnectDialog1W")]
    public static delegate*<DISCDLGSTRUCTW*, uint> WNetDisconnectDialog1 => &WNetDisconnectDialog1W;

    [NativeTypeName("#define WNetOpenEnum WNetOpenEnumW")]
    public static delegate*<uint, uint, uint, NETRESOURCEW*, HANDLE*, uint> WNetOpenEnum => &WNetOpenEnumW;

    [NativeTypeName("#define WNetEnumResource WNetEnumResourceW")]
    public static delegate*<HANDLE, uint*, void*, uint*, uint> WNetEnumResource => &WNetEnumResourceW;

    [NativeTypeName("#define WNetGetResourceParent WNetGetResourceParentW")]
    public static delegate*<NETRESOURCEW*, void*, uint*, uint> WNetGetResourceParent => &WNetGetResourceParentW;

    [NativeTypeName("#define WNetGetResourceInformation WNetGetResourceInformationW")]
    public static delegate*<NETRESOURCEW*, void*, uint*, ushort**, uint> WNetGetResourceInformation => &WNetGetResourceInformationW;

    [NativeTypeName("#define UNIVERSAL_NAME_INFO_LEVEL 0x00000001")]
    public const int UNIVERSAL_NAME_INFO_LEVEL = 0x00000001;
    [NativeTypeName("#define REMOTE_NAME_INFO_LEVEL 0x00000002")]
    public const int REMOTE_NAME_INFO_LEVEL = 0x00000002;
    [NativeTypeName("#define WNetGetUniversalName WNetGetUniversalNameW")]
    public static delegate*<ushort*, uint, void*, uint*, uint> WNetGetUniversalName => &WNetGetUniversalNameW;

    [NativeTypeName("#define WNetGetUser WNetGetUserW")]
    public static delegate*<ushort*, ushort*, uint*, uint> WNetGetUser => &WNetGetUserW;

    [NativeTypeName("#define WNFMT_MULTILINE 0x01")]
    public const int WNFMT_MULTILINE = 0x01;
    [NativeTypeName("#define WNFMT_ABBREVIATED 0x02")]
    public const int WNFMT_ABBREVIATED = 0x02;
    [NativeTypeName("#define WNFMT_INENUM 0x10")]
    public const int WNFMT_INENUM = 0x10;
    [NativeTypeName("#define WNFMT_CONNECTION 0x20")]
    public const int WNFMT_CONNECTION = 0x20;
    [NativeTypeName("#define WNetGetProviderName WNetGetProviderNameW")]
    public static delegate*<uint, ushort*, uint*, uint> WNetGetProviderName => &WNetGetProviderNameW;

    [NativeTypeName("#define NETINFO_DLL16 0x00000001")]
    public const int NETINFO_DLL16 = 0x00000001;
    [NativeTypeName("#define NETINFO_DISKRED 0x00000004")]
    public const int NETINFO_DISKRED = 0x00000004;
    [NativeTypeName("#define NETINFO_PRINTERRED 0x00000008")]
    public const int NETINFO_PRINTERRED = 0x00000008;
    [NativeTypeName("#define WNetGetNetworkInformation WNetGetNetworkInformationW")]
    public static delegate*<ushort*, NETINFOSTRUCT*, uint> WNetGetNetworkInformation => &WNetGetNetworkInformationW;

    [NativeTypeName("#define WNetGetLastError WNetGetLastErrorW")]
    public static delegate*<uint*, ushort*, uint, ushort*, uint, uint> WNetGetLastError => &WNetGetLastErrorW;

    [NativeTypeName("#define WNCON_FORNETCARD 0x00000001")]
    public const int WNCON_FORNETCARD = 0x00000001;
    [NativeTypeName("#define WNCON_NOTROUTED 0x00000002")]
    public const int WNCON_NOTROUTED = 0x00000002;
    [NativeTypeName("#define WNCON_SLOWLINK 0x00000004")]
    public const int WNCON_SLOWLINK = 0x00000004;
    [NativeTypeName("#define WNCON_DYNAMIC 0x00000008")]
    public const int WNCON_DYNAMIC = 0x00000008;
    [NativeTypeName("#define MultinetGetConnectionPerformance MultinetGetConnectionPerformanceW")]
    public static delegate*<NETRESOURCEW*, NETCONNECTINFOSTRUCT*, uint> MultinetGetConnectionPerformance => &MultinetGetConnectionPerformanceW;
}