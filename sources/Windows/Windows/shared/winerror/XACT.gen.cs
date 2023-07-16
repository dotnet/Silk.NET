// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
public static partial class XACT
{
    [NativeTypeName("#define XACT_E_FIRST 0x8004D000")]
    public const uint XACT_E_FIRST = 0x8004D000;
    [NativeTypeName("#define XACT_E_LAST 0x8004D02B")]
    public const uint XACT_E_LAST = 0x8004D02B;
    [NativeTypeName("#define XACT_S_FIRST 0x0004D000")]
    public const int XACT_S_FIRST = 0x0004D000;
    [NativeTypeName("#define XACT_S_LAST 0x0004D010")]
    public const int XACT_S_LAST = 0x0004D010;
    [NativeTypeName("#define XACT_E_ALREADYOTHERSINGLEPHASE _HRESULT_TYPEDEF_(0x8004D000L)")]
    public const int XACT_E_ALREADYOTHERSINGLEPHASE = unchecked((int)(0x8004D000));
    [NativeTypeName("#define XACT_E_CANTRETAIN _HRESULT_TYPEDEF_(0x8004D001L)")]
    public const int XACT_E_CANTRETAIN = unchecked((int)(0x8004D001));
    [NativeTypeName("#define XACT_E_COMMITFAILED _HRESULT_TYPEDEF_(0x8004D002L)")]
    public const int XACT_E_COMMITFAILED = unchecked((int)(0x8004D002));
    [NativeTypeName("#define XACT_E_COMMITPREVENTED _HRESULT_TYPEDEF_(0x8004D003L)")]
    public const int XACT_E_COMMITPREVENTED = unchecked((int)(0x8004D003));
    [NativeTypeName("#define XACT_E_HEURISTICABORT _HRESULT_TYPEDEF_(0x8004D004L)")]
    public const int XACT_E_HEURISTICABORT = unchecked((int)(0x8004D004));
    [NativeTypeName("#define XACT_E_HEURISTICCOMMIT _HRESULT_TYPEDEF_(0x8004D005L)")]
    public const int XACT_E_HEURISTICCOMMIT = unchecked((int)(0x8004D005));
    [NativeTypeName("#define XACT_E_HEURISTICDAMAGE _HRESULT_TYPEDEF_(0x8004D006L)")]
    public const int XACT_E_HEURISTICDAMAGE = unchecked((int)(0x8004D006));
    [NativeTypeName("#define XACT_E_HEURISTICDANGER _HRESULT_TYPEDEF_(0x8004D007L)")]
    public const int XACT_E_HEURISTICDANGER = unchecked((int)(0x8004D007));
    [NativeTypeName("#define XACT_E_ISOLATIONLEVEL _HRESULT_TYPEDEF_(0x8004D008L)")]
    public const int XACT_E_ISOLATIONLEVEL = unchecked((int)(0x8004D008));
    [NativeTypeName("#define XACT_E_NOASYNC _HRESULT_TYPEDEF_(0x8004D009L)")]
    public const int XACT_E_NOASYNC = unchecked((int)(0x8004D009));
    [NativeTypeName("#define XACT_E_NOENLIST _HRESULT_TYPEDEF_(0x8004D00AL)")]
    public const int XACT_E_NOENLIST = unchecked((int)(0x8004D00A));
    [NativeTypeName("#define XACT_E_NOISORETAIN _HRESULT_TYPEDEF_(0x8004D00BL)")]
    public const int XACT_E_NOISORETAIN = unchecked((int)(0x8004D00B));
    [NativeTypeName("#define XACT_E_NORESOURCE _HRESULT_TYPEDEF_(0x8004D00CL)")]
    public const int XACT_E_NORESOURCE = unchecked((int)(0x8004D00C));
    [NativeTypeName("#define XACT_E_NOTCURRENT _HRESULT_TYPEDEF_(0x8004D00DL)")]
    public const int XACT_E_NOTCURRENT = unchecked((int)(0x8004D00D));
    [NativeTypeName("#define XACT_E_NOTRANSACTION _HRESULT_TYPEDEF_(0x8004D00EL)")]
    public const int XACT_E_NOTRANSACTION = unchecked((int)(0x8004D00E));
    [NativeTypeName("#define XACT_E_NOTSUPPORTED _HRESULT_TYPEDEF_(0x8004D00FL)")]
    public const int XACT_E_NOTSUPPORTED = unchecked((int)(0x8004D00F));
    [NativeTypeName("#define XACT_E_UNKNOWNRMGRID _HRESULT_TYPEDEF_(0x8004D010L)")]
    public const int XACT_E_UNKNOWNRMGRID = unchecked((int)(0x8004D010));
    [NativeTypeName("#define XACT_E_WRONGSTATE _HRESULT_TYPEDEF_(0x8004D011L)")]
    public const int XACT_E_WRONGSTATE = unchecked((int)(0x8004D011));
    [NativeTypeName("#define XACT_E_WRONGUOW _HRESULT_TYPEDEF_(0x8004D012L)")]
    public const int XACT_E_WRONGUOW = unchecked((int)(0x8004D012));
    [NativeTypeName("#define XACT_E_XTIONEXISTS _HRESULT_TYPEDEF_(0x8004D013L)")]
    public const int XACT_E_XTIONEXISTS = unchecked((int)(0x8004D013));
    [NativeTypeName("#define XACT_E_NOIMPORTOBJECT _HRESULT_TYPEDEF_(0x8004D014L)")]
    public const int XACT_E_NOIMPORTOBJECT = unchecked((int)(0x8004D014));
    [NativeTypeName("#define XACT_E_INVALIDCOOKIE _HRESULT_TYPEDEF_(0x8004D015L)")]
    public const int XACT_E_INVALIDCOOKIE = unchecked((int)(0x8004D015));
    [NativeTypeName("#define XACT_E_INDOUBT _HRESULT_TYPEDEF_(0x8004D016L)")]
    public const int XACT_E_INDOUBT = unchecked((int)(0x8004D016));
    [NativeTypeName("#define XACT_E_NOTIMEOUT _HRESULT_TYPEDEF_(0x8004D017L)")]
    public const int XACT_E_NOTIMEOUT = unchecked((int)(0x8004D017));
    [NativeTypeName("#define XACT_E_ALREADYINPROGRESS _HRESULT_TYPEDEF_(0x8004D018L)")]
    public const int XACT_E_ALREADYINPROGRESS = unchecked((int)(0x8004D018));
    [NativeTypeName("#define XACT_E_ABORTED _HRESULT_TYPEDEF_(0x8004D019L)")]
    public const int XACT_E_ABORTED = unchecked((int)(0x8004D019));
    [NativeTypeName("#define XACT_E_LOGFULL _HRESULT_TYPEDEF_(0x8004D01AL)")]
    public const int XACT_E_LOGFULL = unchecked((int)(0x8004D01A));
    [NativeTypeName("#define XACT_E_TMNOTAVAILABLE _HRESULT_TYPEDEF_(0x8004D01BL)")]
    public const int XACT_E_TMNOTAVAILABLE = unchecked((int)(0x8004D01B));
    [NativeTypeName("#define XACT_E_CONNECTION_DOWN _HRESULT_TYPEDEF_(0x8004D01CL)")]
    public const int XACT_E_CONNECTION_DOWN = unchecked((int)(0x8004D01C));
    [NativeTypeName("#define XACT_E_CONNECTION_DENIED _HRESULT_TYPEDEF_(0x8004D01DL)")]
    public const int XACT_E_CONNECTION_DENIED = unchecked((int)(0x8004D01D));
    [NativeTypeName("#define XACT_E_REENLISTTIMEOUT _HRESULT_TYPEDEF_(0x8004D01EL)")]
    public const int XACT_E_REENLISTTIMEOUT = unchecked((int)(0x8004D01E));
    [NativeTypeName("#define XACT_E_TIP_CONNECT_FAILED _HRESULT_TYPEDEF_(0x8004D01FL)")]
    public const int XACT_E_TIP_CONNECT_FAILED = unchecked((int)(0x8004D01F));
    [NativeTypeName("#define XACT_E_TIP_PROTOCOL_ERROR _HRESULT_TYPEDEF_(0x8004D020L)")]
    public const int XACT_E_TIP_PROTOCOL_ERROR = unchecked((int)(0x8004D020));
    [NativeTypeName("#define XACT_E_TIP_PULL_FAILED _HRESULT_TYPEDEF_(0x8004D021L)")]
    public const int XACT_E_TIP_PULL_FAILED = unchecked((int)(0x8004D021));
    [NativeTypeName("#define XACT_E_DEST_TMNOTAVAILABLE _HRESULT_TYPEDEF_(0x8004D022L)")]
    public const int XACT_E_DEST_TMNOTAVAILABLE = unchecked((int)(0x8004D022));
    [NativeTypeName("#define XACT_E_TIP_DISABLED _HRESULT_TYPEDEF_(0x8004D023L)")]
    public const int XACT_E_TIP_DISABLED = unchecked((int)(0x8004D023));
    [NativeTypeName("#define XACT_E_NETWORK_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D024L)")]
    public const int XACT_E_NETWORK_TX_DISABLED = unchecked((int)(0x8004D024));
    [NativeTypeName("#define XACT_E_PARTNER_NETWORK_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D025L)")]
    public const int XACT_E_PARTNER_NETWORK_TX_DISABLED = unchecked((int)(0x8004D025));
    [NativeTypeName("#define XACT_E_XA_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D026L)")]
    public const int XACT_E_XA_TX_DISABLED = unchecked((int)(0x8004D026));
    [NativeTypeName("#define XACT_E_UNABLE_TO_READ_DTC_CONFIG _HRESULT_TYPEDEF_(0x8004D027L)")]
    public const int XACT_E_UNABLE_TO_READ_DTC_CONFIG = unchecked((int)(0x8004D027));
    [NativeTypeName("#define XACT_E_UNABLE_TO_LOAD_DTC_PROXY _HRESULT_TYPEDEF_(0x8004D028L)")]
    public const int XACT_E_UNABLE_TO_LOAD_DTC_PROXY = unchecked((int)(0x8004D028));
    [NativeTypeName("#define XACT_E_ABORTING _HRESULT_TYPEDEF_(0x8004D029L)")]
    public const int XACT_E_ABORTING = unchecked((int)(0x8004D029));
    [NativeTypeName("#define XACT_E_PUSH_COMM_FAILURE _HRESULT_TYPEDEF_(0x8004D02AL)")]
    public const int XACT_E_PUSH_COMM_FAILURE = unchecked((int)(0x8004D02A));
    [NativeTypeName("#define XACT_E_PULL_COMM_FAILURE _HRESULT_TYPEDEF_(0x8004D02BL)")]
    public const int XACT_E_PULL_COMM_FAILURE = unchecked((int)(0x8004D02B));
    [NativeTypeName("#define XACT_E_LU_TX_DISABLED _HRESULT_TYPEDEF_(0x8004D02CL)")]
    public const int XACT_E_LU_TX_DISABLED = unchecked((int)(0x8004D02C));
    [NativeTypeName("#define XACT_E_CLERKNOTFOUND _HRESULT_TYPEDEF_(0x8004D080L)")]
    public const int XACT_E_CLERKNOTFOUND = unchecked((int)(0x8004D080));
    [NativeTypeName("#define XACT_E_CLERKEXISTS _HRESULT_TYPEDEF_(0x8004D081L)")]
    public const int XACT_E_CLERKEXISTS = unchecked((int)(0x8004D081));
    [NativeTypeName("#define XACT_E_RECOVERYINPROGRESS _HRESULT_TYPEDEF_(0x8004D082L)")]
    public const int XACT_E_RECOVERYINPROGRESS = unchecked((int)(0x8004D082));
    [NativeTypeName("#define XACT_E_TRANSACTIONCLOSED _HRESULT_TYPEDEF_(0x8004D083L)")]
    public const int XACT_E_TRANSACTIONCLOSED = unchecked((int)(0x8004D083));
    [NativeTypeName("#define XACT_E_INVALIDLSN _HRESULT_TYPEDEF_(0x8004D084L)")]
    public const int XACT_E_INVALIDLSN = unchecked((int)(0x8004D084));
    [NativeTypeName("#define XACT_E_REPLAYREQUEST _HRESULT_TYPEDEF_(0x8004D085L)")]
    public const int XACT_E_REPLAYREQUEST = unchecked((int)(0x8004D085));
    [NativeTypeName("#define XACT_S_ASYNC _HRESULT_TYPEDEF_(0x0004D000L)")]
    public const int XACT_S_ASYNC = ((int)(0x0004D000));
    [NativeTypeName("#define XACT_S_DEFECT _HRESULT_TYPEDEF_(0x0004D001L)")]
    public const int XACT_S_DEFECT = ((int)(0x0004D001));
    [NativeTypeName("#define XACT_S_READONLY _HRESULT_TYPEDEF_(0x0004D002L)")]
    public const int XACT_S_READONLY = ((int)(0x0004D002));
    [NativeTypeName("#define XACT_S_SOMENORETAIN _HRESULT_TYPEDEF_(0x0004D003L)")]
    public const int XACT_S_SOMENORETAIN = ((int)(0x0004D003));
    [NativeTypeName("#define XACT_S_OKINFORM _HRESULT_TYPEDEF_(0x0004D004L)")]
    public const int XACT_S_OKINFORM = ((int)(0x0004D004));
    [NativeTypeName("#define XACT_S_MADECHANGESCONTENT _HRESULT_TYPEDEF_(0x0004D005L)")]
    public const int XACT_S_MADECHANGESCONTENT = ((int)(0x0004D005));
    [NativeTypeName("#define XACT_S_MADECHANGESINFORM _HRESULT_TYPEDEF_(0x0004D006L)")]
    public const int XACT_S_MADECHANGESINFORM = ((int)(0x0004D006));
    [NativeTypeName("#define XACT_S_ALLNORETAIN _HRESULT_TYPEDEF_(0x0004D007L)")]
    public const int XACT_S_ALLNORETAIN = ((int)(0x0004D007));
    [NativeTypeName("#define XACT_S_ABORTING _HRESULT_TYPEDEF_(0x0004D008L)")]
    public const int XACT_S_ABORTING = ((int)(0x0004D008));
    [NativeTypeName("#define XACT_S_SINGLEPHASE _HRESULT_TYPEDEF_(0x0004D009L)")]
    public const int XACT_S_SINGLEPHASE = ((int)(0x0004D009));
    [NativeTypeName("#define XACT_S_LOCALLY_OK _HRESULT_TYPEDEF_(0x0004D00AL)")]
    public const int XACT_S_LOCALLY_OK = ((int)(0x0004D00A));
    [NativeTypeName("#define XACT_S_LASTRESOURCEMANAGER _HRESULT_TYPEDEF_(0x0004D010L)")]
    public const int XACT_S_LASTRESOURCEMANAGER = ((int)(0x0004D010));
}