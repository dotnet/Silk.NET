// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CO
{
    [NativeTypeName("#define CO_E_INIT_TLS _HRESULT_TYPEDEF_(0x80004006L)")]
    public const int CO_E_INIT_TLS = unchecked((int)(0x80004006));
    [NativeTypeName("#define CO_E_INIT_SHARED_ALLOCATOR _HRESULT_TYPEDEF_(0x80004007L)")]
    public const int CO_E_INIT_SHARED_ALLOCATOR = unchecked((int)(0x80004007));
    [NativeTypeName("#define CO_E_INIT_MEMORY_ALLOCATOR _HRESULT_TYPEDEF_(0x80004008L)")]
    public const int CO_E_INIT_MEMORY_ALLOCATOR = unchecked((int)(0x80004008));
    [NativeTypeName("#define CO_E_INIT_CLASS_CACHE _HRESULT_TYPEDEF_(0x80004009L)")]
    public const int CO_E_INIT_CLASS_CACHE = unchecked((int)(0x80004009));
    [NativeTypeName("#define CO_E_INIT_RPC_CHANNEL _HRESULT_TYPEDEF_(0x8000400AL)")]
    public const int CO_E_INIT_RPC_CHANNEL = unchecked((int)(0x8000400A));
    [NativeTypeName("#define CO_E_INIT_TLS_SET_CHANNEL_CONTROL _HRESULT_TYPEDEF_(0x8000400BL)")]
    public const int CO_E_INIT_TLS_SET_CHANNEL_CONTROL = unchecked((int)(0x8000400B));
    [NativeTypeName("#define CO_E_INIT_TLS_CHANNEL_CONTROL _HRESULT_TYPEDEF_(0x8000400CL)")]
    public const int CO_E_INIT_TLS_CHANNEL_CONTROL = unchecked((int)(0x8000400C));
    [NativeTypeName("#define CO_E_INIT_UNACCEPTED_USER_ALLOCATOR _HRESULT_TYPEDEF_(0x8000400DL)")]
    public const int CO_E_INIT_UNACCEPTED_USER_ALLOCATOR = unchecked((int)(0x8000400D));
    [NativeTypeName("#define CO_E_INIT_SCM_MUTEX_EXISTS _HRESULT_TYPEDEF_(0x8000400EL)")]
    public const int CO_E_INIT_SCM_MUTEX_EXISTS = unchecked((int)(0x8000400E));
    [NativeTypeName("#define CO_E_INIT_SCM_FILE_MAPPING_EXISTS _HRESULT_TYPEDEF_(0x8000400FL)")]
    public const int CO_E_INIT_SCM_FILE_MAPPING_EXISTS = unchecked((int)(0x8000400F));
    [NativeTypeName("#define CO_E_INIT_SCM_MAP_VIEW_OF_FILE _HRESULT_TYPEDEF_(0x80004010L)")]
    public const int CO_E_INIT_SCM_MAP_VIEW_OF_FILE = unchecked((int)(0x80004010));
    [NativeTypeName("#define CO_E_INIT_SCM_EXEC_FAILURE _HRESULT_TYPEDEF_(0x80004011L)")]
    public const int CO_E_INIT_SCM_EXEC_FAILURE = unchecked((int)(0x80004011));
    [NativeTypeName("#define CO_E_INIT_ONLY_SINGLE_THREADED _HRESULT_TYPEDEF_(0x80004012L)")]
    public const int CO_E_INIT_ONLY_SINGLE_THREADED = unchecked((int)(0x80004012));
    [NativeTypeName("#define CO_E_CANT_REMOTE _HRESULT_TYPEDEF_(0x80004013L)")]
    public const int CO_E_CANT_REMOTE = unchecked((int)(0x80004013));
    [NativeTypeName("#define CO_E_BAD_SERVER_NAME _HRESULT_TYPEDEF_(0x80004014L)")]
    public const int CO_E_BAD_SERVER_NAME = unchecked((int)(0x80004014));
    [NativeTypeName("#define CO_E_WRONG_SERVER_IDENTITY _HRESULT_TYPEDEF_(0x80004015L)")]
    public const int CO_E_WRONG_SERVER_IDENTITY = unchecked((int)(0x80004015));
    [NativeTypeName("#define CO_E_OLE1DDE_DISABLED _HRESULT_TYPEDEF_(0x80004016L)")]
    public const int CO_E_OLE1DDE_DISABLED = unchecked((int)(0x80004016));
    [NativeTypeName("#define CO_E_RUNAS_SYNTAX _HRESULT_TYPEDEF_(0x80004017L)")]
    public const int CO_E_RUNAS_SYNTAX = unchecked((int)(0x80004017));
    [NativeTypeName("#define CO_E_CREATEPROCESS_FAILURE _HRESULT_TYPEDEF_(0x80004018L)")]
    public const int CO_E_CREATEPROCESS_FAILURE = unchecked((int)(0x80004018));
    [NativeTypeName("#define CO_E_RUNAS_CREATEPROCESS_FAILURE _HRESULT_TYPEDEF_(0x80004019L)")]
    public const int CO_E_RUNAS_CREATEPROCESS_FAILURE = unchecked((int)(0x80004019));
    [NativeTypeName("#define CO_E_RUNAS_LOGON_FAILURE _HRESULT_TYPEDEF_(0x8000401AL)")]
    public const int CO_E_RUNAS_LOGON_FAILURE = unchecked((int)(0x8000401A));
    [NativeTypeName("#define CO_E_LAUNCH_PERMSSION_DENIED _HRESULT_TYPEDEF_(0x8000401BL)")]
    public const int CO_E_LAUNCH_PERMSSION_DENIED = unchecked((int)(0x8000401B));
    [NativeTypeName("#define CO_E_START_SERVICE_FAILURE _HRESULT_TYPEDEF_(0x8000401CL)")]
    public const int CO_E_START_SERVICE_FAILURE = unchecked((int)(0x8000401C));
    [NativeTypeName("#define CO_E_REMOTE_COMMUNICATION_FAILURE _HRESULT_TYPEDEF_(0x8000401DL)")]
    public const int CO_E_REMOTE_COMMUNICATION_FAILURE = unchecked((int)(0x8000401D));
    [NativeTypeName("#define CO_E_SERVER_START_TIMEOUT _HRESULT_TYPEDEF_(0x8000401EL)")]
    public const int CO_E_SERVER_START_TIMEOUT = unchecked((int)(0x8000401E));
    [NativeTypeName("#define CO_E_CLSREG_INCONSISTENT _HRESULT_TYPEDEF_(0x8000401FL)")]
    public const int CO_E_CLSREG_INCONSISTENT = unchecked((int)(0x8000401F));
    [NativeTypeName("#define CO_E_IIDREG_INCONSISTENT _HRESULT_TYPEDEF_(0x80004020L)")]
    public const int CO_E_IIDREG_INCONSISTENT = unchecked((int)(0x80004020));
    [NativeTypeName("#define CO_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80004021L)")]
    public const int CO_E_NOT_SUPPORTED = unchecked((int)(0x80004021));
    [NativeTypeName("#define CO_E_RELOAD_DLL _HRESULT_TYPEDEF_(0x80004022L)")]
    public const int CO_E_RELOAD_DLL = unchecked((int)(0x80004022));
    [NativeTypeName("#define CO_E_MSI_ERROR _HRESULT_TYPEDEF_(0x80004023L)")]
    public const int CO_E_MSI_ERROR = unchecked((int)(0x80004023));
    [NativeTypeName("#define CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT _HRESULT_TYPEDEF_(0x80004024L)")]
    public const int CO_E_ATTEMPT_TO_CREATE_OUTSIDE_CLIENT_CONTEXT = unchecked((int)(0x80004024));
    [NativeTypeName("#define CO_E_SERVER_PAUSED _HRESULT_TYPEDEF_(0x80004025L)")]
    public const int CO_E_SERVER_PAUSED = unchecked((int)(0x80004025));
    [NativeTypeName("#define CO_E_SERVER_NOT_PAUSED _HRESULT_TYPEDEF_(0x80004026L)")]
    public const int CO_E_SERVER_NOT_PAUSED = unchecked((int)(0x80004026));
    [NativeTypeName("#define CO_E_CLASS_DISABLED _HRESULT_TYPEDEF_(0x80004027L)")]
    public const int CO_E_CLASS_DISABLED = unchecked((int)(0x80004027));
    [NativeTypeName("#define CO_E_CLRNOTAVAILABLE _HRESULT_TYPEDEF_(0x80004028L)")]
    public const int CO_E_CLRNOTAVAILABLE = unchecked((int)(0x80004028));
    [NativeTypeName("#define CO_E_ASYNC_WORK_REJECTED _HRESULT_TYPEDEF_(0x80004029L)")]
    public const int CO_E_ASYNC_WORK_REJECTED = unchecked((int)(0x80004029));
    [NativeTypeName("#define CO_E_SERVER_INIT_TIMEOUT _HRESULT_TYPEDEF_(0x8000402AL)")]
    public const int CO_E_SERVER_INIT_TIMEOUT = unchecked((int)(0x8000402A));
    [NativeTypeName("#define CO_E_NO_SECCTX_IN_ACTIVATE _HRESULT_TYPEDEF_(0x8000402BL)")]
    public const int CO_E_NO_SECCTX_IN_ACTIVATE = unchecked((int)(0x8000402B));
    [NativeTypeName("#define CO_E_TRACKER_CONFIG _HRESULT_TYPEDEF_(0x80004030L)")]
    public const int CO_E_TRACKER_CONFIG = unchecked((int)(0x80004030));
    [NativeTypeName("#define CO_E_THREADPOOL_CONFIG _HRESULT_TYPEDEF_(0x80004031L)")]
    public const int CO_E_THREADPOOL_CONFIG = unchecked((int)(0x80004031));
    [NativeTypeName("#define CO_E_SXS_CONFIG _HRESULT_TYPEDEF_(0x80004032L)")]
    public const int CO_E_SXS_CONFIG = unchecked((int)(0x80004032));
    [NativeTypeName("#define CO_E_MALFORMED_SPN _HRESULT_TYPEDEF_(0x80004033L)")]
    public const int CO_E_MALFORMED_SPN = unchecked((int)(0x80004033));
    [NativeTypeName("#define CO_E_UNREVOKED_REGISTRATION_ON_APARTMENT_SHUTDOWN _HRESULT_TYPEDEF_(0x80004034L)")]
    public const int CO_E_UNREVOKED_REGISTRATION_ON_APARTMENT_SHUTDOWN = unchecked((int)(0x80004034));
    [NativeTypeName("#define CO_E_PREMATURE_STUB_RUNDOWN _HRESULT_TYPEDEF_(0x80004035L)")]
    public const int CO_E_PREMATURE_STUB_RUNDOWN = unchecked((int)(0x80004035));
    [NativeTypeName("#define CO_E_FIRST 0x800401F0L")]
    public const uint CO_E_FIRST = 0x800401F0;
    [NativeTypeName("#define CO_E_LAST 0x800401FFL")]
    public const uint CO_E_LAST = 0x800401FF;
    [NativeTypeName("#define CO_S_FIRST 0x000401F0L")]
    public const int CO_S_FIRST = 0x000401F0;
    [NativeTypeName("#define CO_S_LAST 0x000401FFL")]
    public const int CO_S_LAST = 0x000401FF;
    [NativeTypeName("#define CO_E_NOTINITIALIZED _HRESULT_TYPEDEF_(0x800401F0L)")]
    public const int CO_E_NOTINITIALIZED = unchecked((int)(0x800401F0));
    [NativeTypeName("#define CO_E_ALREADYINITIALIZED _HRESULT_TYPEDEF_(0x800401F1L)")]
    public const int CO_E_ALREADYINITIALIZED = unchecked((int)(0x800401F1));
    [NativeTypeName("#define CO_E_CANTDETERMINECLASS _HRESULT_TYPEDEF_(0x800401F2L)")]
    public const int CO_E_CANTDETERMINECLASS = unchecked((int)(0x800401F2));
    [NativeTypeName("#define CO_E_CLASSSTRING _HRESULT_TYPEDEF_(0x800401F3L)")]
    public const int CO_E_CLASSSTRING = unchecked((int)(0x800401F3));
    [NativeTypeName("#define CO_E_IIDSTRING _HRESULT_TYPEDEF_(0x800401F4L)")]
    public const int CO_E_IIDSTRING = unchecked((int)(0x800401F4));
    [NativeTypeName("#define CO_E_APPNOTFOUND _HRESULT_TYPEDEF_(0x800401F5L)")]
    public const int CO_E_APPNOTFOUND = unchecked((int)(0x800401F5));
    [NativeTypeName("#define CO_E_APPSINGLEUSE _HRESULT_TYPEDEF_(0x800401F6L)")]
    public const int CO_E_APPSINGLEUSE = unchecked((int)(0x800401F6));
    [NativeTypeName("#define CO_E_ERRORINAPP _HRESULT_TYPEDEF_(0x800401F7L)")]
    public const int CO_E_ERRORINAPP = unchecked((int)(0x800401F7));
    [NativeTypeName("#define CO_E_DLLNOTFOUND _HRESULT_TYPEDEF_(0x800401F8L)")]
    public const int CO_E_DLLNOTFOUND = unchecked((int)(0x800401F8));
    [NativeTypeName("#define CO_E_ERRORINDLL _HRESULT_TYPEDEF_(0x800401F9L)")]
    public const int CO_E_ERRORINDLL = unchecked((int)(0x800401F9));
    [NativeTypeName("#define CO_E_WRONGOSFORAPP _HRESULT_TYPEDEF_(0x800401FAL)")]
    public const int CO_E_WRONGOSFORAPP = unchecked((int)(0x800401FA));
    [NativeTypeName("#define CO_E_OBJNOTREG _HRESULT_TYPEDEF_(0x800401FBL)")]
    public const int CO_E_OBJNOTREG = unchecked((int)(0x800401FB));
    [NativeTypeName("#define CO_E_OBJISREG _HRESULT_TYPEDEF_(0x800401FCL)")]
    public const int CO_E_OBJISREG = unchecked((int)(0x800401FC));
    [NativeTypeName("#define CO_E_OBJNOTCONNECTED _HRESULT_TYPEDEF_(0x800401FDL)")]
    public const int CO_E_OBJNOTCONNECTED = unchecked((int)(0x800401FD));
    [NativeTypeName("#define CO_E_APPDIDNTREG _HRESULT_TYPEDEF_(0x800401FEL)")]
    public const int CO_E_APPDIDNTREG = unchecked((int)(0x800401FE));
    [NativeTypeName("#define CO_E_RELEASED _HRESULT_TYPEDEF_(0x800401FFL)")]
    public const int CO_E_RELEASED = unchecked((int)(0x800401FF));
    [NativeTypeName("#define CO_E_ACTIVATIONFAILED _HRESULT_TYPEDEF_(0x8004E021L)")]
    public const int CO_E_ACTIVATIONFAILED = unchecked((int)(0x8004E021));
    [NativeTypeName("#define CO_E_ACTIVATIONFAILED_EVENTLOGGED _HRESULT_TYPEDEF_(0x8004E022L)")]
    public const int CO_E_ACTIVATIONFAILED_EVENTLOGGED = unchecked((int)(0x8004E022));
    [NativeTypeName("#define CO_E_ACTIVATIONFAILED_CATALOGERROR _HRESULT_TYPEDEF_(0x8004E023L)")]
    public const int CO_E_ACTIVATIONFAILED_CATALOGERROR = unchecked((int)(0x8004E023));
    [NativeTypeName("#define CO_E_ACTIVATIONFAILED_TIMEOUT _HRESULT_TYPEDEF_(0x8004E024L)")]
    public const int CO_E_ACTIVATIONFAILED_TIMEOUT = unchecked((int)(0x8004E024));
    [NativeTypeName("#define CO_E_INITIALIZATIONFAILED _HRESULT_TYPEDEF_(0x8004E025L)")]
    public const int CO_E_INITIALIZATIONFAILED = unchecked((int)(0x8004E025));
    [NativeTypeName("#define CO_E_THREADINGMODEL_CHANGED _HRESULT_TYPEDEF_(0x8004E028L)")]
    public const int CO_E_THREADINGMODEL_CHANGED = unchecked((int)(0x8004E028));
    [NativeTypeName("#define CO_E_NOIISINTRINSICS _HRESULT_TYPEDEF_(0x8004E029L)")]
    public const int CO_E_NOIISINTRINSICS = unchecked((int)(0x8004E029));
    [NativeTypeName("#define CO_E_NOCOOKIES _HRESULT_TYPEDEF_(0x8004E02AL)")]
    public const int CO_E_NOCOOKIES = unchecked((int)(0x8004E02A));
    [NativeTypeName("#define CO_E_DBERROR _HRESULT_TYPEDEF_(0x8004E02BL)")]
    public const int CO_E_DBERROR = unchecked((int)(0x8004E02B));
    [NativeTypeName("#define CO_E_NOTPOOLED _HRESULT_TYPEDEF_(0x8004E02CL)")]
    public const int CO_E_NOTPOOLED = unchecked((int)(0x8004E02C));
    [NativeTypeName("#define CO_E_NOTCONSTRUCTED _HRESULT_TYPEDEF_(0x8004E02DL)")]
    public const int CO_E_NOTCONSTRUCTED = unchecked((int)(0x8004E02D));
    [NativeTypeName("#define CO_E_NOSYNCHRONIZATION _HRESULT_TYPEDEF_(0x8004E02EL)")]
    public const int CO_E_NOSYNCHRONIZATION = unchecked((int)(0x8004E02E));
    [NativeTypeName("#define CO_E_ISOLEVELMISMATCH _HRESULT_TYPEDEF_(0x8004E02FL)")]
    public const int CO_E_ISOLEVELMISMATCH = unchecked((int)(0x8004E02F));
    [NativeTypeName("#define CO_E_CALL_OUT_OF_TX_SCOPE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8004E030L)")]
    public const int CO_E_CALL_OUT_OF_TX_SCOPE_NOT_ALLOWED = unchecked((int)(0x8004E030));
    [NativeTypeName("#define CO_E_EXIT_TRANSACTION_SCOPE_NOT_CALLED _HRESULT_TYPEDEF_(0x8004E031L)")]
    public const int CO_E_EXIT_TRANSACTION_SCOPE_NOT_CALLED = unchecked((int)(0x8004E031));
    [NativeTypeName("#define CO_E_CLASS_CREATE_FAILED _HRESULT_TYPEDEF_(0x80080001L)")]
    public const int CO_E_CLASS_CREATE_FAILED = unchecked((int)(0x80080001));
    [NativeTypeName("#define CO_E_SCM_ERROR _HRESULT_TYPEDEF_(0x80080002L)")]
    public const int CO_E_SCM_ERROR = unchecked((int)(0x80080002));
    [NativeTypeName("#define CO_E_SCM_RPC_FAILURE _HRESULT_TYPEDEF_(0x80080003L)")]
    public const int CO_E_SCM_RPC_FAILURE = unchecked((int)(0x80080003));
    [NativeTypeName("#define CO_E_BAD_PATH _HRESULT_TYPEDEF_(0x80080004L)")]
    public const int CO_E_BAD_PATH = unchecked((int)(0x80080004));
    [NativeTypeName("#define CO_E_SERVER_EXEC_FAILURE _HRESULT_TYPEDEF_(0x80080005L)")]
    public const int CO_E_SERVER_EXEC_FAILURE = unchecked((int)(0x80080005));
    [NativeTypeName("#define CO_E_OBJSRV_RPC_FAILURE _HRESULT_TYPEDEF_(0x80080006L)")]
    public const int CO_E_OBJSRV_RPC_FAILURE = unchecked((int)(0x80080006));
    [NativeTypeName("#define CO_E_SERVER_STOPPING _HRESULT_TYPEDEF_(0x80080008L)")]
    public const int CO_E_SERVER_STOPPING = unchecked((int)(0x80080008));
    [NativeTypeName("#define CO_S_NOTALLINTERFACES _HRESULT_TYPEDEF_(0x00080012L)")]
    public const int CO_S_NOTALLINTERFACES = ((int)(0x00080012));
    [NativeTypeName("#define CO_S_MACHINENAMENOTFOUND _HRESULT_TYPEDEF_(0x00080013L)")]
    public const int CO_S_MACHINENAMENOTFOUND = ((int)(0x00080013));
    [NativeTypeName("#define CO_E_MISSING_DISPLAYNAME _HRESULT_TYPEDEF_(0x80080015L)")]
    public const int CO_E_MISSING_DISPLAYNAME = unchecked((int)(0x80080015));
    [NativeTypeName("#define CO_E_RUNAS_VALUE_MUST_BE_AAA _HRESULT_TYPEDEF_(0x80080016L)")]
    public const int CO_E_RUNAS_VALUE_MUST_BE_AAA = unchecked((int)(0x80080016));
    [NativeTypeName("#define CO_E_ELEVATION_DISABLED _HRESULT_TYPEDEF_(0x80080017L)")]
    public const int CO_E_ELEVATION_DISABLED = unchecked((int)(0x80080017));
    [NativeTypeName("#define CO_E_FAILEDTOIMPERSONATE _HRESULT_TYPEDEF_(0x80010123L)")]
    public const int CO_E_FAILEDTOIMPERSONATE = unchecked((int)(0x80010123));
    [NativeTypeName("#define CO_E_FAILEDTOGETSECCTX _HRESULT_TYPEDEF_(0x80010124L)")]
    public const int CO_E_FAILEDTOGETSECCTX = unchecked((int)(0x80010124));
    [NativeTypeName("#define CO_E_FAILEDTOOPENTHREADTOKEN _HRESULT_TYPEDEF_(0x80010125L)")]
    public const int CO_E_FAILEDTOOPENTHREADTOKEN = unchecked((int)(0x80010125));
    [NativeTypeName("#define CO_E_FAILEDTOGETTOKENINFO _HRESULT_TYPEDEF_(0x80010126L)")]
    public const int CO_E_FAILEDTOGETTOKENINFO = unchecked((int)(0x80010126));
    [NativeTypeName("#define CO_E_TRUSTEEDOESNTMATCHCLIENT _HRESULT_TYPEDEF_(0x80010127L)")]
    public const int CO_E_TRUSTEEDOESNTMATCHCLIENT = unchecked((int)(0x80010127));
    [NativeTypeName("#define CO_E_FAILEDTOQUERYCLIENTBLANKET _HRESULT_TYPEDEF_(0x80010128L)")]
    public const int CO_E_FAILEDTOQUERYCLIENTBLANKET = unchecked((int)(0x80010128));
    [NativeTypeName("#define CO_E_FAILEDTOSETDACL _HRESULT_TYPEDEF_(0x80010129L)")]
    public const int CO_E_FAILEDTOSETDACL = unchecked((int)(0x80010129));
    [NativeTypeName("#define CO_E_ACCESSCHECKFAILED _HRESULT_TYPEDEF_(0x8001012AL)")]
    public const int CO_E_ACCESSCHECKFAILED = unchecked((int)(0x8001012A));
    [NativeTypeName("#define CO_E_NETACCESSAPIFAILED _HRESULT_TYPEDEF_(0x8001012BL)")]
    public const int CO_E_NETACCESSAPIFAILED = unchecked((int)(0x8001012B));
    [NativeTypeName("#define CO_E_WRONGTRUSTEENAMESYNTAX _HRESULT_TYPEDEF_(0x8001012CL)")]
    public const int CO_E_WRONGTRUSTEENAMESYNTAX = unchecked((int)(0x8001012C));
    [NativeTypeName("#define CO_E_INVALIDSID _HRESULT_TYPEDEF_(0x8001012DL)")]
    public const int CO_E_INVALIDSID = unchecked((int)(0x8001012D));
    [NativeTypeName("#define CO_E_CONVERSIONFAILED _HRESULT_TYPEDEF_(0x8001012EL)")]
    public const int CO_E_CONVERSIONFAILED = unchecked((int)(0x8001012E));
    [NativeTypeName("#define CO_E_NOMATCHINGSIDFOUND _HRESULT_TYPEDEF_(0x8001012FL)")]
    public const int CO_E_NOMATCHINGSIDFOUND = unchecked((int)(0x8001012F));
    [NativeTypeName("#define CO_E_LOOKUPACCSIDFAILED _HRESULT_TYPEDEF_(0x80010130L)")]
    public const int CO_E_LOOKUPACCSIDFAILED = unchecked((int)(0x80010130));
    [NativeTypeName("#define CO_E_NOMATCHINGNAMEFOUND _HRESULT_TYPEDEF_(0x80010131L)")]
    public const int CO_E_NOMATCHINGNAMEFOUND = unchecked((int)(0x80010131));
    [NativeTypeName("#define CO_E_LOOKUPACCNAMEFAILED _HRESULT_TYPEDEF_(0x80010132L)")]
    public const int CO_E_LOOKUPACCNAMEFAILED = unchecked((int)(0x80010132));
    [NativeTypeName("#define CO_E_SETSERLHNDLFAILED _HRESULT_TYPEDEF_(0x80010133L)")]
    public const int CO_E_SETSERLHNDLFAILED = unchecked((int)(0x80010133));
    [NativeTypeName("#define CO_E_FAILEDTOGETWINDIR _HRESULT_TYPEDEF_(0x80010134L)")]
    public const int CO_E_FAILEDTOGETWINDIR = unchecked((int)(0x80010134));
    [NativeTypeName("#define CO_E_PATHTOOLONG _HRESULT_TYPEDEF_(0x80010135L)")]
    public const int CO_E_PATHTOOLONG = unchecked((int)(0x80010135));
    [NativeTypeName("#define CO_E_FAILEDTOGENUUID _HRESULT_TYPEDEF_(0x80010136L)")]
    public const int CO_E_FAILEDTOGENUUID = unchecked((int)(0x80010136));
    [NativeTypeName("#define CO_E_FAILEDTOCREATEFILE _HRESULT_TYPEDEF_(0x80010137L)")]
    public const int CO_E_FAILEDTOCREATEFILE = unchecked((int)(0x80010137));
    [NativeTypeName("#define CO_E_FAILEDTOCLOSEHANDLE _HRESULT_TYPEDEF_(0x80010138L)")]
    public const int CO_E_FAILEDTOCLOSEHANDLE = unchecked((int)(0x80010138));
    [NativeTypeName("#define CO_E_EXCEEDSYSACLLIMIT _HRESULT_TYPEDEF_(0x80010139L)")]
    public const int CO_E_EXCEEDSYSACLLIMIT = unchecked((int)(0x80010139));
    [NativeTypeName("#define CO_E_ACESINWRONGORDER _HRESULT_TYPEDEF_(0x8001013AL)")]
    public const int CO_E_ACESINWRONGORDER = unchecked((int)(0x8001013A));
    [NativeTypeName("#define CO_E_INCOMPATIBLESTREAMVERSION _HRESULT_TYPEDEF_(0x8001013BL)")]
    public const int CO_E_INCOMPATIBLESTREAMVERSION = unchecked((int)(0x8001013B));
    [NativeTypeName("#define CO_E_FAILEDTOOPENPROCESSTOKEN _HRESULT_TYPEDEF_(0x8001013CL)")]
    public const int CO_E_FAILEDTOOPENPROCESSTOKEN = unchecked((int)(0x8001013C));
    [NativeTypeName("#define CO_E_DECODEFAILED _HRESULT_TYPEDEF_(0x8001013DL)")]
    public const int CO_E_DECODEFAILED = unchecked((int)(0x8001013D));
    [NativeTypeName("#define CO_E_ACNOTINITIALIZED _HRESULT_TYPEDEF_(0x8001013FL)")]
    public const int CO_E_ACNOTINITIALIZED = unchecked((int)(0x8001013F));
    [NativeTypeName("#define CO_E_CANCEL_DISABLED _HRESULT_TYPEDEF_(0x80010140L)")]
    public const int CO_E_CANCEL_DISABLED = unchecked((int)(0x80010140));
}