// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class NERR
{
    [NativeTypeName("#define NERR_Success 0")]
    public const int NERR_Success = 0;
    [NativeTypeName("#define NERR_BASE 2100")]
    public const int NERR_BASE = 2100;
    [NativeTypeName("#define NERR_NetNotStarted (NERR_BASE+2)")]
    public const int NERR_NetNotStarted = (2100 + 2);
    [NativeTypeName("#define NERR_UnknownServer (NERR_BASE+3)")]
    public const int NERR_UnknownServer = (2100 + 3);
    [NativeTypeName("#define NERR_ShareMem (NERR_BASE+4)")]
    public const int NERR_ShareMem = (2100 + 4);
    [NativeTypeName("#define NERR_NoNetworkResource (NERR_BASE+5)")]
    public const int NERR_NoNetworkResource = (2100 + 5);
    [NativeTypeName("#define NERR_RemoteOnly (NERR_BASE+6)")]
    public const int NERR_RemoteOnly = (2100 + 6);
    [NativeTypeName("#define NERR_DevNotRedirected (NERR_BASE+7)")]
    public const int NERR_DevNotRedirected = (2100 + 7);
    [NativeTypeName("#define NERR_ServerNotStarted (NERR_BASE+14)")]
    public const int NERR_ServerNotStarted = (2100 + 14);
    [NativeTypeName("#define NERR_ItemNotFound (NERR_BASE+15)")]
    public const int NERR_ItemNotFound = (2100 + 15);
    [NativeTypeName("#define NERR_UnknownDevDir (NERR_BASE+16)")]
    public const int NERR_UnknownDevDir = (2100 + 16);
    [NativeTypeName("#define NERR_RedirectedPath (NERR_BASE+17)")]
    public const int NERR_RedirectedPath = (2100 + 17);
    [NativeTypeName("#define NERR_DuplicateShare (NERR_BASE+18)")]
    public const int NERR_DuplicateShare = (2100 + 18);
    [NativeTypeName("#define NERR_NoRoom (NERR_BASE+19)")]
    public const int NERR_NoRoom = (2100 + 19);
    [NativeTypeName("#define NERR_TooManyItems (NERR_BASE+21)")]
    public const int NERR_TooManyItems = (2100 + 21);
    [NativeTypeName("#define NERR_InvalidMaxUsers (NERR_BASE+22)")]
    public const int NERR_InvalidMaxUsers = (2100 + 22);
    [NativeTypeName("#define NERR_BufTooSmall (NERR_BASE+23)")]
    public const int NERR_BufTooSmall = (2100 + 23);
    [NativeTypeName("#define NERR_RemoteErr (NERR_BASE+27)")]
    public const int NERR_RemoteErr = (2100 + 27);
    [NativeTypeName("#define NERR_LanmanIniError (NERR_BASE+31)")]
    public const int NERR_LanmanIniError = (2100 + 31);
    [NativeTypeName("#define NERR_NetworkError (NERR_BASE+36)")]
    public const int NERR_NetworkError = (2100 + 36);
    [NativeTypeName("#define NERR_WkstaInconsistentState (NERR_BASE+37)")]
    public const int NERR_WkstaInconsistentState = (2100 + 37);
    [NativeTypeName("#define NERR_WkstaNotStarted (NERR_BASE+38)")]
    public const int NERR_WkstaNotStarted = (2100 + 38);
    [NativeTypeName("#define NERR_BrowserNotStarted (NERR_BASE+39)")]
    public const int NERR_BrowserNotStarted = (2100 + 39);
    [NativeTypeName("#define NERR_InternalError (NERR_BASE+40)")]
    public const int NERR_InternalError = (2100 + 40);
    [NativeTypeName("#define NERR_BadTransactConfig (NERR_BASE+41)")]
    public const int NERR_BadTransactConfig = (2100 + 41);
    [NativeTypeName("#define NERR_InvalidAPI (NERR_BASE+42)")]
    public const int NERR_InvalidAPI = (2100 + 42);
    [NativeTypeName("#define NERR_BadEventName (NERR_BASE+43)")]
    public const int NERR_BadEventName = (2100 + 43);
    [NativeTypeName("#define NERR_DupNameReboot (NERR_BASE+44)")]
    public const int NERR_DupNameReboot = (2100 + 44);
    [NativeTypeName("#define NERR_CfgCompNotFound (NERR_BASE+46)")]
    public const int NERR_CfgCompNotFound = (2100 + 46);
    [NativeTypeName("#define NERR_CfgParamNotFound (NERR_BASE+47)")]
    public const int NERR_CfgParamNotFound = (2100 + 47);
    [NativeTypeName("#define NERR_LineTooLong (NERR_BASE+49)")]
    public const int NERR_LineTooLong = (2100 + 49);
    [NativeTypeName("#define NERR_QNotFound (NERR_BASE+50)")]
    public const int NERR_QNotFound = (2100 + 50);
    [NativeTypeName("#define NERR_JobNotFound (NERR_BASE+51)")]
    public const int NERR_JobNotFound = (2100 + 51);
    [NativeTypeName("#define NERR_DestNotFound (NERR_BASE+52)")]
    public const int NERR_DestNotFound = (2100 + 52);
    [NativeTypeName("#define NERR_DestExists (NERR_BASE+53)")]
    public const int NERR_DestExists = (2100 + 53);
    [NativeTypeName("#define NERR_QExists (NERR_BASE+54)")]
    public const int NERR_QExists = (2100 + 54);
    [NativeTypeName("#define NERR_QNoRoom (NERR_BASE+55)")]
    public const int NERR_QNoRoom = (2100 + 55);
    [NativeTypeName("#define NERR_JobNoRoom (NERR_BASE+56)")]
    public const int NERR_JobNoRoom = (2100 + 56);
    [NativeTypeName("#define NERR_DestNoRoom (NERR_BASE+57)")]
    public const int NERR_DestNoRoom = (2100 + 57);
    [NativeTypeName("#define NERR_DestIdle (NERR_BASE+58)")]
    public const int NERR_DestIdle = (2100 + 58);
    [NativeTypeName("#define NERR_DestInvalidOp (NERR_BASE+59)")]
    public const int NERR_DestInvalidOp = (2100 + 59);
    [NativeTypeName("#define NERR_ProcNoRespond (NERR_BASE+60)")]
    public const int NERR_ProcNoRespond = (2100 + 60);
    [NativeTypeName("#define NERR_SpoolerNotLoaded (NERR_BASE+61)")]
    public const int NERR_SpoolerNotLoaded = (2100 + 61);
    [NativeTypeName("#define NERR_DestInvalidState (NERR_BASE+62)")]
    public const int NERR_DestInvalidState = (2100 + 62);
    [NativeTypeName("#define NERR_QInvalidState (NERR_BASE+63)")]
    public const int NERR_QInvalidState = (2100 + 63);
    [NativeTypeName("#define NERR_JobInvalidState (NERR_BASE+64)")]
    public const int NERR_JobInvalidState = (2100 + 64);
    [NativeTypeName("#define NERR_SpoolNoMemory (NERR_BASE+65)")]
    public const int NERR_SpoolNoMemory = (2100 + 65);
    [NativeTypeName("#define NERR_DriverNotFound (NERR_BASE+66)")]
    public const int NERR_DriverNotFound = (2100 + 66);
    [NativeTypeName("#define NERR_DataTypeInvalid (NERR_BASE+67)")]
    public const int NERR_DataTypeInvalid = (2100 + 67);
    [NativeTypeName("#define NERR_ProcNotFound (NERR_BASE+68)")]
    public const int NERR_ProcNotFound = (2100 + 68);
    [NativeTypeName("#define NERR_ServiceTableLocked (NERR_BASE+80)")]
    public const int NERR_ServiceTableLocked = (2100 + 80);
    [NativeTypeName("#define NERR_ServiceTableFull (NERR_BASE+81)")]
    public const int NERR_ServiceTableFull = (2100 + 81);
    [NativeTypeName("#define NERR_ServiceInstalled (NERR_BASE+82)")]
    public const int NERR_ServiceInstalled = (2100 + 82);
    [NativeTypeName("#define NERR_ServiceEntryLocked (NERR_BASE+83)")]
    public const int NERR_ServiceEntryLocked = (2100 + 83);
    [NativeTypeName("#define NERR_ServiceNotInstalled (NERR_BASE+84)")]
    public const int NERR_ServiceNotInstalled = (2100 + 84);
    [NativeTypeName("#define NERR_BadServiceName (NERR_BASE+85)")]
    public const int NERR_BadServiceName = (2100 + 85);
    [NativeTypeName("#define NERR_ServiceCtlTimeout (NERR_BASE+86)")]
    public const int NERR_ServiceCtlTimeout = (2100 + 86);
    [NativeTypeName("#define NERR_ServiceCtlBusy (NERR_BASE+87)")]
    public const int NERR_ServiceCtlBusy = (2100 + 87);
    [NativeTypeName("#define NERR_BadServiceProgName (NERR_BASE+88)")]
    public const int NERR_BadServiceProgName = (2100 + 88);
    [NativeTypeName("#define NERR_ServiceNotCtrl (NERR_BASE+89)")]
    public const int NERR_ServiceNotCtrl = (2100 + 89);
    [NativeTypeName("#define NERR_ServiceKillProc (NERR_BASE+90)")]
    public const int NERR_ServiceKillProc = (2100 + 90);
    [NativeTypeName("#define NERR_ServiceCtlNotValid (NERR_BASE+91)")]
    public const int NERR_ServiceCtlNotValid = (2100 + 91);
    [NativeTypeName("#define NERR_NotInDispatchTbl (NERR_BASE+92)")]
    public const int NERR_NotInDispatchTbl = (2100 + 92);
    [NativeTypeName("#define NERR_BadControlRecv (NERR_BASE+93)")]
    public const int NERR_BadControlRecv = (2100 + 93);
    [NativeTypeName("#define NERR_ServiceNotStarting (NERR_BASE+94)")]
    public const int NERR_ServiceNotStarting = (2100 + 94);
    [NativeTypeName("#define NERR_AlreadyLoggedOn (NERR_BASE+100)")]
    public const int NERR_AlreadyLoggedOn = (2100 + 100);
    [NativeTypeName("#define NERR_NotLoggedOn (NERR_BASE+101)")]
    public const int NERR_NotLoggedOn = (2100 + 101);
    [NativeTypeName("#define NERR_BadUsername (NERR_BASE+102)")]
    public const int NERR_BadUsername = (2100 + 102);
    [NativeTypeName("#define NERR_BadPassword (NERR_BASE+103)")]
    public const int NERR_BadPassword = (2100 + 103);
    [NativeTypeName("#define NERR_UnableToAddName_W (NERR_BASE+104)")]
    public const int NERR_UnableToAddName_W = (2100 + 104);
    [NativeTypeName("#define NERR_UnableToAddName_F (NERR_BASE+105)")]
    public const int NERR_UnableToAddName_F = (2100 + 105);
    [NativeTypeName("#define NERR_UnableToDelName_W (NERR_BASE+106)")]
    public const int NERR_UnableToDelName_W = (2100 + 106);
    [NativeTypeName("#define NERR_UnableToDelName_F (NERR_BASE+107)")]
    public const int NERR_UnableToDelName_F = (2100 + 107);
    [NativeTypeName("#define NERR_LogonsPaused (NERR_BASE+109)")]
    public const int NERR_LogonsPaused = (2100 + 109);
    [NativeTypeName("#define NERR_LogonServerConflict (NERR_BASE+110)")]
    public const int NERR_LogonServerConflict = (2100 + 110);
    [NativeTypeName("#define NERR_LogonNoUserPath (NERR_BASE+111)")]
    public const int NERR_LogonNoUserPath = (2100 + 111);
    [NativeTypeName("#define NERR_LogonScriptError (NERR_BASE+112)")]
    public const int NERR_LogonScriptError = (2100 + 112);
    [NativeTypeName("#define NERR_StandaloneLogon (NERR_BASE+114)")]
    public const int NERR_StandaloneLogon = (2100 + 114);
    [NativeTypeName("#define NERR_LogonServerNotFound (NERR_BASE+115)")]
    public const int NERR_LogonServerNotFound = (2100 + 115);
    [NativeTypeName("#define NERR_LogonDomainExists (NERR_BASE+116)")]
    public const int NERR_LogonDomainExists = (2100 + 116);
    [NativeTypeName("#define NERR_NonValidatedLogon (NERR_BASE+117)")]
    public const int NERR_NonValidatedLogon = (2100 + 117);
    [NativeTypeName("#define NERR_ACFNotFound (NERR_BASE+119)")]
    public const int NERR_ACFNotFound = (2100 + 119);
    [NativeTypeName("#define NERR_GroupNotFound (NERR_BASE+120)")]
    public const int NERR_GroupNotFound = (2100 + 120);
    [NativeTypeName("#define NERR_UserNotFound (NERR_BASE+121)")]
    public const int NERR_UserNotFound = (2100 + 121);
    [NativeTypeName("#define NERR_ResourceNotFound (NERR_BASE+122)")]
    public const int NERR_ResourceNotFound = (2100 + 122);
    [NativeTypeName("#define NERR_GroupExists (NERR_BASE+123)")]
    public const int NERR_GroupExists = (2100 + 123);
    [NativeTypeName("#define NERR_UserExists (NERR_BASE+124)")]
    public const int NERR_UserExists = (2100 + 124);
    [NativeTypeName("#define NERR_ResourceExists (NERR_BASE+125)")]
    public const int NERR_ResourceExists = (2100 + 125);
    [NativeTypeName("#define NERR_NotPrimary (NERR_BASE+126)")]
    public const int NERR_NotPrimary = (2100 + 126);
    [NativeTypeName("#define NERR_ACFNotLoaded (NERR_BASE+127)")]
    public const int NERR_ACFNotLoaded = (2100 + 127);
    [NativeTypeName("#define NERR_ACFNoRoom (NERR_BASE+128)")]
    public const int NERR_ACFNoRoom = (2100 + 128);
    [NativeTypeName("#define NERR_ACFFileIOFail (NERR_BASE+129)")]
    public const int NERR_ACFFileIOFail = (2100 + 129);
    [NativeTypeName("#define NERR_ACFTooManyLists (NERR_BASE+130)")]
    public const int NERR_ACFTooManyLists = (2100 + 130);
    [NativeTypeName("#define NERR_UserLogon (NERR_BASE+131)")]
    public const int NERR_UserLogon = (2100 + 131);
    [NativeTypeName("#define NERR_ACFNoParent (NERR_BASE+132)")]
    public const int NERR_ACFNoParent = (2100 + 132);
    [NativeTypeName("#define NERR_CanNotGrowSegment (NERR_BASE+133)")]
    public const int NERR_CanNotGrowSegment = (2100 + 133);
    [NativeTypeName("#define NERR_SpeGroupOp (NERR_BASE+134)")]
    public const int NERR_SpeGroupOp = (2100 + 134);
    [NativeTypeName("#define NERR_NotInCache (NERR_BASE+135)")]
    public const int NERR_NotInCache = (2100 + 135);
    [NativeTypeName("#define NERR_UserInGroup (NERR_BASE+136)")]
    public const int NERR_UserInGroup = (2100 + 136);
    [NativeTypeName("#define NERR_UserNotInGroup (NERR_BASE+137)")]
    public const int NERR_UserNotInGroup = (2100 + 137);
    [NativeTypeName("#define NERR_AccountUndefined (NERR_BASE+138)")]
    public const int NERR_AccountUndefined = (2100 + 138);
    [NativeTypeName("#define NERR_AccountExpired (NERR_BASE+139)")]
    public const int NERR_AccountExpired = (2100 + 139);
    [NativeTypeName("#define NERR_InvalidWorkstation (NERR_BASE+140)")]
    public const int NERR_InvalidWorkstation = (2100 + 140);
    [NativeTypeName("#define NERR_InvalidLogonHours (NERR_BASE+141)")]
    public const int NERR_InvalidLogonHours = (2100 + 141);
    [NativeTypeName("#define NERR_PasswordExpired (NERR_BASE+142)")]
    public const int NERR_PasswordExpired = (2100 + 142);
    [NativeTypeName("#define NERR_PasswordCantChange (NERR_BASE+143)")]
    public const int NERR_PasswordCantChange = (2100 + 143);
    [NativeTypeName("#define NERR_PasswordHistConflict (NERR_BASE+144)")]
    public const int NERR_PasswordHistConflict = (2100 + 144);
    [NativeTypeName("#define NERR_PasswordTooShort (NERR_BASE+145)")]
    public const int NERR_PasswordTooShort = (2100 + 145);
    [NativeTypeName("#define NERR_PasswordTooRecent (NERR_BASE+146)")]
    public const int NERR_PasswordTooRecent = (2100 + 146);
    [NativeTypeName("#define NERR_InvalidDatabase (NERR_BASE+147)")]
    public const int NERR_InvalidDatabase = (2100 + 147);
    [NativeTypeName("#define NERR_DatabaseUpToDate (NERR_BASE+148)")]
    public const int NERR_DatabaseUpToDate = (2100 + 148);
    [NativeTypeName("#define NERR_SyncRequired (NERR_BASE+149)")]
    public const int NERR_SyncRequired = (2100 + 149);
    [NativeTypeName("#define NERR_UseNotFound (NERR_BASE+150)")]
    public const int NERR_UseNotFound = (2100 + 150);
    [NativeTypeName("#define NERR_BadAsgType (NERR_BASE+151)")]
    public const int NERR_BadAsgType = (2100 + 151);
    [NativeTypeName("#define NERR_DeviceIsShared (NERR_BASE+152)")]
    public const int NERR_DeviceIsShared = (2100 + 152);
    [NativeTypeName("#define NERR_SameAsComputerName (NERR_BASE+153)")]
    public const int NERR_SameAsComputerName = (2100 + 153);
    [NativeTypeName("#define NERR_NoComputerName (NERR_BASE+170)")]
    public const int NERR_NoComputerName = (2100 + 170);
    [NativeTypeName("#define NERR_MsgAlreadyStarted (NERR_BASE+171)")]
    public const int NERR_MsgAlreadyStarted = (2100 + 171);
    [NativeTypeName("#define NERR_MsgInitFailed (NERR_BASE+172)")]
    public const int NERR_MsgInitFailed = (2100 + 172);
    [NativeTypeName("#define NERR_NameNotFound (NERR_BASE+173)")]
    public const int NERR_NameNotFound = (2100 + 173);
    [NativeTypeName("#define NERR_AlreadyForwarded (NERR_BASE+174)")]
    public const int NERR_AlreadyForwarded = (2100 + 174);
    [NativeTypeName("#define NERR_AddForwarded (NERR_BASE+175)")]
    public const int NERR_AddForwarded = (2100 + 175);
    [NativeTypeName("#define NERR_AlreadyExists (NERR_BASE+176)")]
    public const int NERR_AlreadyExists = (2100 + 176);
    [NativeTypeName("#define NERR_TooManyNames (NERR_BASE+177)")]
    public const int NERR_TooManyNames = (2100 + 177);
    [NativeTypeName("#define NERR_DelComputerName (NERR_BASE+178)")]
    public const int NERR_DelComputerName = (2100 + 178);
    [NativeTypeName("#define NERR_LocalForward (NERR_BASE+179)")]
    public const int NERR_LocalForward = (2100 + 179);
    [NativeTypeName("#define NERR_GrpMsgProcessor (NERR_BASE+180)")]
    public const int NERR_GrpMsgProcessor = (2100 + 180);
    [NativeTypeName("#define NERR_PausedRemote (NERR_BASE+181)")]
    public const int NERR_PausedRemote = (2100 + 181);
    [NativeTypeName("#define NERR_BadReceive (NERR_BASE+182)")]
    public const int NERR_BadReceive = (2100 + 182);
    [NativeTypeName("#define NERR_NameInUse (NERR_BASE+183)")]
    public const int NERR_NameInUse = (2100 + 183);
    [NativeTypeName("#define NERR_MsgNotStarted (NERR_BASE+184)")]
    public const int NERR_MsgNotStarted = (2100 + 184);
    [NativeTypeName("#define NERR_NotLocalName (NERR_BASE+185)")]
    public const int NERR_NotLocalName = (2100 + 185);
    [NativeTypeName("#define NERR_NoForwardName (NERR_BASE+186)")]
    public const int NERR_NoForwardName = (2100 + 186);
    [NativeTypeName("#define NERR_RemoteFull (NERR_BASE+187)")]
    public const int NERR_RemoteFull = (2100 + 187);
    [NativeTypeName("#define NERR_NameNotForwarded (NERR_BASE+188)")]
    public const int NERR_NameNotForwarded = (2100 + 188);
    [NativeTypeName("#define NERR_TruncatedBroadcast (NERR_BASE+189)")]
    public const int NERR_TruncatedBroadcast = (2100 + 189);
    [NativeTypeName("#define NERR_InvalidDevice (NERR_BASE+194)")]
    public const int NERR_InvalidDevice = (2100 + 194);
    [NativeTypeName("#define NERR_WriteFault (NERR_BASE+195)")]
    public const int NERR_WriteFault = (2100 + 195);
    [NativeTypeName("#define NERR_DuplicateName (NERR_BASE+197)")]
    public const int NERR_DuplicateName = (2100 + 197);
    [NativeTypeName("#define NERR_DeleteLater (NERR_BASE+198)")]
    public const int NERR_DeleteLater = (2100 + 198);
    [NativeTypeName("#define NERR_IncompleteDel (NERR_BASE+199)")]
    public const int NERR_IncompleteDel = (2100 + 199);
    [NativeTypeName("#define NERR_MultipleNets (NERR_BASE+200)")]
    public const int NERR_MultipleNets = (2100 + 200);
    [NativeTypeName("#define NERR_NetNameNotFound (NERR_BASE+210)")]
    public const int NERR_NetNameNotFound = (2100 + 210);
    [NativeTypeName("#define NERR_DeviceNotShared (NERR_BASE+211)")]
    public const int NERR_DeviceNotShared = (2100 + 211);
    [NativeTypeName("#define NERR_ClientNameNotFound (NERR_BASE+212)")]
    public const int NERR_ClientNameNotFound = (2100 + 212);
    [NativeTypeName("#define NERR_FileIdNotFound (NERR_BASE+214)")]
    public const int NERR_FileIdNotFound = (2100 + 214);
    [NativeTypeName("#define NERR_ExecFailure (NERR_BASE+215)")]
    public const int NERR_ExecFailure = (2100 + 215);
    [NativeTypeName("#define NERR_TmpFile (NERR_BASE+216)")]
    public const int NERR_TmpFile = (2100 + 216);
    [NativeTypeName("#define NERR_TooMuchData (NERR_BASE+217)")]
    public const int NERR_TooMuchData = (2100 + 217);
    [NativeTypeName("#define NERR_DeviceShareConflict (NERR_BASE+218)")]
    public const int NERR_DeviceShareConflict = (2100 + 218);
    [NativeTypeName("#define NERR_BrowserTableIncomplete (NERR_BASE+219)")]
    public const int NERR_BrowserTableIncomplete = (2100 + 219);
    [NativeTypeName("#define NERR_NotLocalDomain (NERR_BASE+220)")]
    public const int NERR_NotLocalDomain = (2100 + 220);
    [NativeTypeName("#define NERR_IsDfsShare (NERR_BASE+221)")]
    public const int NERR_IsDfsShare = (2100 + 221);
    [NativeTypeName("#define NERR_DevInvalidOpCode (NERR_BASE+231)")]
    public const int NERR_DevInvalidOpCode = (2100 + 231);
    [NativeTypeName("#define NERR_DevNotFound (NERR_BASE+232)")]
    public const int NERR_DevNotFound = (2100 + 232);
    [NativeTypeName("#define NERR_DevNotOpen (NERR_BASE+233)")]
    public const int NERR_DevNotOpen = (2100 + 233);
    [NativeTypeName("#define NERR_BadQueueDevString (NERR_BASE+234)")]
    public const int NERR_BadQueueDevString = (2100 + 234);
    [NativeTypeName("#define NERR_BadQueuePriority (NERR_BASE+235)")]
    public const int NERR_BadQueuePriority = (2100 + 235);
    [NativeTypeName("#define NERR_NoCommDevs (NERR_BASE+237)")]
    public const int NERR_NoCommDevs = (2100 + 237);
    [NativeTypeName("#define NERR_QueueNotFound (NERR_BASE+238)")]
    public const int NERR_QueueNotFound = (2100 + 238);
    [NativeTypeName("#define NERR_BadDevString (NERR_BASE+240)")]
    public const int NERR_BadDevString = (2100 + 240);
    [NativeTypeName("#define NERR_BadDev (NERR_BASE+241)")]
    public const int NERR_BadDev = (2100 + 241);
    [NativeTypeName("#define NERR_InUseBySpooler (NERR_BASE+242)")]
    public const int NERR_InUseBySpooler = (2100 + 242);
    [NativeTypeName("#define NERR_CommDevInUse (NERR_BASE+243)")]
    public const int NERR_CommDevInUse = (2100 + 243);
    [NativeTypeName("#define NERR_InvalidComputer (NERR_BASE+251)")]
    public const int NERR_InvalidComputer = (2100 + 251);
    [NativeTypeName("#define NERR_MaxLenExceeded (NERR_BASE+254)")]
    public const int NERR_MaxLenExceeded = (2100 + 254);
    [NativeTypeName("#define NERR_BadComponent (NERR_BASE+256)")]
    public const int NERR_BadComponent = (2100 + 256);
    [NativeTypeName("#define NERR_CantType (NERR_BASE+257)")]
    public const int NERR_CantType = (2100 + 257);
    [NativeTypeName("#define NERR_TooManyEntries (NERR_BASE+262)")]
    public const int NERR_TooManyEntries = (2100 + 262);
    [NativeTypeName("#define NERR_ProfileFileTooBig (NERR_BASE+270)")]
    public const int NERR_ProfileFileTooBig = (2100 + 270);
    [NativeTypeName("#define NERR_ProfileOffset (NERR_BASE+271)")]
    public const int NERR_ProfileOffset = (2100 + 271);
    [NativeTypeName("#define NERR_ProfileCleanup (NERR_BASE+272)")]
    public const int NERR_ProfileCleanup = (2100 + 272);
    [NativeTypeName("#define NERR_ProfileUnknownCmd (NERR_BASE+273)")]
    public const int NERR_ProfileUnknownCmd = (2100 + 273);
    [NativeTypeName("#define NERR_ProfileLoadErr (NERR_BASE+274)")]
    public const int NERR_ProfileLoadErr = (2100 + 274);
    [NativeTypeName("#define NERR_ProfileSaveErr (NERR_BASE+275)")]
    public const int NERR_ProfileSaveErr = (2100 + 275);
    [NativeTypeName("#define NERR_LogOverflow (NERR_BASE+277)")]
    public const int NERR_LogOverflow = (2100 + 277);
    [NativeTypeName("#define NERR_LogFileChanged (NERR_BASE+278)")]
    public const int NERR_LogFileChanged = (2100 + 278);
    [NativeTypeName("#define NERR_LogFileCorrupt (NERR_BASE+279)")]
    public const int NERR_LogFileCorrupt = (2100 + 279);
    [NativeTypeName("#define NERR_SourceIsDir (NERR_BASE+280)")]
    public const int NERR_SourceIsDir = (2100 + 280);
    [NativeTypeName("#define NERR_BadSource (NERR_BASE+281)")]
    public const int NERR_BadSource = (2100 + 281);
    [NativeTypeName("#define NERR_BadDest (NERR_BASE+282)")]
    public const int NERR_BadDest = (2100 + 282);
    [NativeTypeName("#define NERR_DifferentServers (NERR_BASE+283)")]
    public const int NERR_DifferentServers = (2100 + 283);
    [NativeTypeName("#define NERR_RunSrvPaused (NERR_BASE+285)")]
    public const int NERR_RunSrvPaused = (2100 + 285);
    [NativeTypeName("#define NERR_ErrCommRunSrv (NERR_BASE+289)")]
    public const int NERR_ErrCommRunSrv = (2100 + 289);
    [NativeTypeName("#define NERR_ErrorExecingGhost (NERR_BASE+291)")]
    public const int NERR_ErrorExecingGhost = (2100 + 291);
    [NativeTypeName("#define NERR_ShareNotFound (NERR_BASE+292)")]
    public const int NERR_ShareNotFound = (2100 + 292);
    [NativeTypeName("#define NERR_InvalidLana (NERR_BASE+300)")]
    public const int NERR_InvalidLana = (2100 + 300);
    [NativeTypeName("#define NERR_OpenFiles (NERR_BASE+301)")]
    public const int NERR_OpenFiles = (2100 + 301);
    [NativeTypeName("#define NERR_ActiveConns (NERR_BASE+302)")]
    public const int NERR_ActiveConns = (2100 + 302);
    [NativeTypeName("#define NERR_BadPasswordCore (NERR_BASE+303)")]
    public const int NERR_BadPasswordCore = (2100 + 303);
    [NativeTypeName("#define NERR_DevInUse (NERR_BASE+304)")]
    public const int NERR_DevInUse = (2100 + 304);
    [NativeTypeName("#define NERR_LocalDrive (NERR_BASE+305)")]
    public const int NERR_LocalDrive = (2100 + 305);
    [NativeTypeName("#define NERR_AlertExists (NERR_BASE+330)")]
    public const int NERR_AlertExists = (2100 + 330);
    [NativeTypeName("#define NERR_TooManyAlerts (NERR_BASE+331)")]
    public const int NERR_TooManyAlerts = (2100 + 331);
    [NativeTypeName("#define NERR_NoSuchAlert (NERR_BASE+332)")]
    public const int NERR_NoSuchAlert = (2100 + 332);
    [NativeTypeName("#define NERR_BadRecipient (NERR_BASE+333)")]
    public const int NERR_BadRecipient = (2100 + 333);
    [NativeTypeName("#define NERR_AcctLimitExceeded (NERR_BASE+334)")]
    public const int NERR_AcctLimitExceeded = (2100 + 334);
    [NativeTypeName("#define NERR_InvalidLogSeek (NERR_BASE+340)")]
    public const int NERR_InvalidLogSeek = (2100 + 340);
    [NativeTypeName("#define NERR_BadUasConfig (NERR_BASE+350)")]
    public const int NERR_BadUasConfig = (2100 + 350);
    [NativeTypeName("#define NERR_InvalidUASOp (NERR_BASE+351)")]
    public const int NERR_InvalidUASOp = (2100 + 351);
    [NativeTypeName("#define NERR_LastAdmin (NERR_BASE+352)")]
    public const int NERR_LastAdmin = (2100 + 352);
    [NativeTypeName("#define NERR_DCNotFound (NERR_BASE+353)")]
    public const int NERR_DCNotFound = (2100 + 353);
    [NativeTypeName("#define NERR_LogonTrackingError (NERR_BASE+354)")]
    public const int NERR_LogonTrackingError = (2100 + 354);
    [NativeTypeName("#define NERR_NetlogonNotStarted (NERR_BASE+355)")]
    public const int NERR_NetlogonNotStarted = (2100 + 355);
    [NativeTypeName("#define NERR_CanNotGrowUASFile (NERR_BASE+356)")]
    public const int NERR_CanNotGrowUASFile = (2100 + 356);
    [NativeTypeName("#define NERR_TimeDiffAtDC (NERR_BASE+357)")]
    public const int NERR_TimeDiffAtDC = (2100 + 357);
    [NativeTypeName("#define NERR_PasswordMismatch (NERR_BASE+358)")]
    public const int NERR_PasswordMismatch = (2100 + 358);
    [NativeTypeName("#define NERR_NoSuchServer (NERR_BASE+360)")]
    public const int NERR_NoSuchServer = (2100 + 360);
    [NativeTypeName("#define NERR_NoSuchSession (NERR_BASE+361)")]
    public const int NERR_NoSuchSession = (2100 + 361);
    [NativeTypeName("#define NERR_NoSuchConnection (NERR_BASE+362)")]
    public const int NERR_NoSuchConnection = (2100 + 362);
    [NativeTypeName("#define NERR_TooManyServers (NERR_BASE+363)")]
    public const int NERR_TooManyServers = (2100 + 363);
    [NativeTypeName("#define NERR_TooManySessions (NERR_BASE+364)")]
    public const int NERR_TooManySessions = (2100 + 364);
    [NativeTypeName("#define NERR_TooManyConnections (NERR_BASE+365)")]
    public const int NERR_TooManyConnections = (2100 + 365);
    [NativeTypeName("#define NERR_TooManyFiles (NERR_BASE+366)")]
    public const int NERR_TooManyFiles = (2100 + 366);
    [NativeTypeName("#define NERR_NoAlternateServers (NERR_BASE+367)")]
    public const int NERR_NoAlternateServers = (2100 + 367);
    [NativeTypeName("#define NERR_TryDownLevel (NERR_BASE+370)")]
    public const int NERR_TryDownLevel = (2100 + 370);
    [NativeTypeName("#define NERR_UPSDriverNotStarted (NERR_BASE+380)")]
    public const int NERR_UPSDriverNotStarted = (2100 + 380);
    [NativeTypeName("#define NERR_UPSInvalidConfig (NERR_BASE+381)")]
    public const int NERR_UPSInvalidConfig = (2100 + 381);
    [NativeTypeName("#define NERR_UPSInvalidCommPort (NERR_BASE+382)")]
    public const int NERR_UPSInvalidCommPort = (2100 + 382);
    [NativeTypeName("#define NERR_UPSSignalAsserted (NERR_BASE+383)")]
    public const int NERR_UPSSignalAsserted = (2100 + 383);
    [NativeTypeName("#define NERR_UPSShutdownFailed (NERR_BASE+384)")]
    public const int NERR_UPSShutdownFailed = (2100 + 384);
    [NativeTypeName("#define NERR_BadDosRetCode (NERR_BASE+400)")]
    public const int NERR_BadDosRetCode = (2100 + 400);
    [NativeTypeName("#define NERR_ProgNeedsExtraMem (NERR_BASE+401)")]
    public const int NERR_ProgNeedsExtraMem = (2100 + 401);
    [NativeTypeName("#define NERR_BadDosFunction (NERR_BASE+402)")]
    public const int NERR_BadDosFunction = (2100 + 402);
    [NativeTypeName("#define NERR_RemoteBootFailed (NERR_BASE+403)")]
    public const int NERR_RemoteBootFailed = (2100 + 403);
    [NativeTypeName("#define NERR_BadFileCheckSum (NERR_BASE+404)")]
    public const int NERR_BadFileCheckSum = (2100 + 404);
    [NativeTypeName("#define NERR_NoRplBootSystem (NERR_BASE+405)")]
    public const int NERR_NoRplBootSystem = (2100 + 405);
    [NativeTypeName("#define NERR_RplLoadrNetBiosErr (NERR_BASE+406)")]
    public const int NERR_RplLoadrNetBiosErr = (2100 + 406);
    [NativeTypeName("#define NERR_RplLoadrDiskErr (NERR_BASE+407)")]
    public const int NERR_RplLoadrDiskErr = (2100 + 407);
    [NativeTypeName("#define NERR_ImageParamErr (NERR_BASE+408)")]
    public const int NERR_ImageParamErr = (2100 + 408);
    [NativeTypeName("#define NERR_TooManyImageParams (NERR_BASE+409)")]
    public const int NERR_TooManyImageParams = (2100 + 409);
    [NativeTypeName("#define NERR_NonDosFloppyUsed (NERR_BASE+410)")]
    public const int NERR_NonDosFloppyUsed = (2100 + 410);
    [NativeTypeName("#define NERR_RplBootRestart (NERR_BASE+411)")]
    public const int NERR_RplBootRestart = (2100 + 411);
    [NativeTypeName("#define NERR_RplSrvrCallFailed (NERR_BASE+412)")]
    public const int NERR_RplSrvrCallFailed = (2100 + 412);
    [NativeTypeName("#define NERR_CantConnectRplSrvr (NERR_BASE+413)")]
    public const int NERR_CantConnectRplSrvr = (2100 + 413);
    [NativeTypeName("#define NERR_CantOpenImageFile (NERR_BASE+414)")]
    public const int NERR_CantOpenImageFile = (2100 + 414);
    [NativeTypeName("#define NERR_CallingRplSrvr (NERR_BASE+415)")]
    public const int NERR_CallingRplSrvr = (2100 + 415);
    [NativeTypeName("#define NERR_StartingRplBoot (NERR_BASE+416)")]
    public const int NERR_StartingRplBoot = (2100 + 416);
    [NativeTypeName("#define NERR_RplBootServiceTerm (NERR_BASE+417)")]
    public const int NERR_RplBootServiceTerm = (2100 + 417);
    [NativeTypeName("#define NERR_RplBootStartFailed (NERR_BASE+418)")]
    public const int NERR_RplBootStartFailed = (2100 + 418);
    [NativeTypeName("#define NERR_RPL_CONNECTED (NERR_BASE+419)")]
    public const int NERR_RPL_CONNECTED = (2100 + 419);
    [NativeTypeName("#define NERR_BrowserConfiguredToNotRun (NERR_BASE+450)")]
    public const int NERR_BrowserConfiguredToNotRun = (2100 + 450);
    [NativeTypeName("#define NERR_RplNoAdaptersStarted (NERR_BASE+510)")]
    public const int NERR_RplNoAdaptersStarted = (2100 + 510);
    [NativeTypeName("#define NERR_RplBadRegistry (NERR_BASE+511)")]
    public const int NERR_RplBadRegistry = (2100 + 511);
    [NativeTypeName("#define NERR_RplBadDatabase (NERR_BASE+512)")]
    public const int NERR_RplBadDatabase = (2100 + 512);
    [NativeTypeName("#define NERR_RplRplfilesShare (NERR_BASE+513)")]
    public const int NERR_RplRplfilesShare = (2100 + 513);
    [NativeTypeName("#define NERR_RplNotRplServer (NERR_BASE+514)")]
    public const int NERR_RplNotRplServer = (2100 + 514);
    [NativeTypeName("#define NERR_RplCannotEnum (NERR_BASE+515)")]
    public const int NERR_RplCannotEnum = (2100 + 515);
    [NativeTypeName("#define NERR_RplWkstaInfoCorrupted (NERR_BASE+516)")]
    public const int NERR_RplWkstaInfoCorrupted = (2100 + 516);
    [NativeTypeName("#define NERR_RplWkstaNotFound (NERR_BASE+517)")]
    public const int NERR_RplWkstaNotFound = (2100 + 517);
    [NativeTypeName("#define NERR_RplWkstaNameUnavailable (NERR_BASE+518)")]
    public const int NERR_RplWkstaNameUnavailable = (2100 + 518);
    [NativeTypeName("#define NERR_RplProfileInfoCorrupted (NERR_BASE+519)")]
    public const int NERR_RplProfileInfoCorrupted = (2100 + 519);
    [NativeTypeName("#define NERR_RplProfileNotFound (NERR_BASE+520)")]
    public const int NERR_RplProfileNotFound = (2100 + 520);
    [NativeTypeName("#define NERR_RplProfileNameUnavailable (NERR_BASE+521)")]
    public const int NERR_RplProfileNameUnavailable = (2100 + 521);
    [NativeTypeName("#define NERR_RplProfileNotEmpty (NERR_BASE+522)")]
    public const int NERR_RplProfileNotEmpty = (2100 + 522);
    [NativeTypeName("#define NERR_RplConfigInfoCorrupted (NERR_BASE+523)")]
    public const int NERR_RplConfigInfoCorrupted = (2100 + 523);
    [NativeTypeName("#define NERR_RplConfigNotFound (NERR_BASE+524)")]
    public const int NERR_RplConfigNotFound = (2100 + 524);
    [NativeTypeName("#define NERR_RplAdapterInfoCorrupted (NERR_BASE+525)")]
    public const int NERR_RplAdapterInfoCorrupted = (2100 + 525);
    [NativeTypeName("#define NERR_RplInternal (NERR_BASE+526)")]
    public const int NERR_RplInternal = (2100 + 526);
    [NativeTypeName("#define NERR_RplVendorInfoCorrupted (NERR_BASE+527)")]
    public const int NERR_RplVendorInfoCorrupted = (2100 + 527);
    [NativeTypeName("#define NERR_RplBootInfoCorrupted (NERR_BASE+528)")]
    public const int NERR_RplBootInfoCorrupted = (2100 + 528);
    [NativeTypeName("#define NERR_RplWkstaNeedsUserAcct (NERR_BASE+529)")]
    public const int NERR_RplWkstaNeedsUserAcct = (2100 + 529);
    [NativeTypeName("#define NERR_RplNeedsRPLUSERAcct (NERR_BASE+530)")]
    public const int NERR_RplNeedsRPLUSERAcct = (2100 + 530);
    [NativeTypeName("#define NERR_RplBootNotFound (NERR_BASE+531)")]
    public const int NERR_RplBootNotFound = (2100 + 531);
    [NativeTypeName("#define NERR_RplIncompatibleProfile (NERR_BASE+532)")]
    public const int NERR_RplIncompatibleProfile = (2100 + 532);
    [NativeTypeName("#define NERR_RplAdapterNameUnavailable (NERR_BASE+533)")]
    public const int NERR_RplAdapterNameUnavailable = (2100 + 533);
    [NativeTypeName("#define NERR_RplConfigNotEmpty (NERR_BASE+534)")]
    public const int NERR_RplConfigNotEmpty = (2100 + 534);
    [NativeTypeName("#define NERR_RplBootInUse (NERR_BASE+535)")]
    public const int NERR_RplBootInUse = (2100 + 535);
    [NativeTypeName("#define NERR_RplBackupDatabase (NERR_BASE+536)")]
    public const int NERR_RplBackupDatabase = (2100 + 536);
    [NativeTypeName("#define NERR_RplAdapterNotFound (NERR_BASE+537)")]
    public const int NERR_RplAdapterNotFound = (2100 + 537);
    [NativeTypeName("#define NERR_RplVendorNotFound (NERR_BASE+538)")]
    public const int NERR_RplVendorNotFound = (2100 + 538);
    [NativeTypeName("#define NERR_RplVendorNameUnavailable (NERR_BASE+539)")]
    public const int NERR_RplVendorNameUnavailable = (2100 + 539);
    [NativeTypeName("#define NERR_RplBootNameUnavailable (NERR_BASE+540)")]
    public const int NERR_RplBootNameUnavailable = (2100 + 540);
    [NativeTypeName("#define NERR_RplConfigNameUnavailable (NERR_BASE+541)")]
    public const int NERR_RplConfigNameUnavailable = (2100 + 541);
    [NativeTypeName("#define NERR_DfsInternalCorruption (NERR_BASE+560)")]
    public const int NERR_DfsInternalCorruption = (2100 + 560);
    [NativeTypeName("#define NERR_DfsVolumeDataCorrupt (NERR_BASE+561)")]
    public const int NERR_DfsVolumeDataCorrupt = (2100 + 561);
    [NativeTypeName("#define NERR_DfsNoSuchVolume (NERR_BASE+562)")]
    public const int NERR_DfsNoSuchVolume = (2100 + 562);
    [NativeTypeName("#define NERR_DfsVolumeAlreadyExists (NERR_BASE+563)")]
    public const int NERR_DfsVolumeAlreadyExists = (2100 + 563);
    [NativeTypeName("#define NERR_DfsAlreadyShared (NERR_BASE+564)")]
    public const int NERR_DfsAlreadyShared = (2100 + 564);
    [NativeTypeName("#define NERR_DfsNoSuchShare (NERR_BASE+565)")]
    public const int NERR_DfsNoSuchShare = (2100 + 565);
    [NativeTypeName("#define NERR_DfsNotALeafVolume (NERR_BASE+566)")]
    public const int NERR_DfsNotALeafVolume = (2100 + 566);
    [NativeTypeName("#define NERR_DfsLeafVolume (NERR_BASE+567)")]
    public const int NERR_DfsLeafVolume = (2100 + 567);
    [NativeTypeName("#define NERR_DfsVolumeHasMultipleServers (NERR_BASE+568)")]
    public const int NERR_DfsVolumeHasMultipleServers = (2100 + 568);
    [NativeTypeName("#define NERR_DfsCantCreateJunctionPoint (NERR_BASE+569)")]
    public const int NERR_DfsCantCreateJunctionPoint = (2100 + 569);
    [NativeTypeName("#define NERR_DfsServerNotDfsAware (NERR_BASE+570)")]
    public const int NERR_DfsServerNotDfsAware = (2100 + 570);
    [NativeTypeName("#define NERR_DfsBadRenamePath (NERR_BASE+571)")]
    public const int NERR_DfsBadRenamePath = (2100 + 571);
    [NativeTypeName("#define NERR_DfsVolumeIsOffline (NERR_BASE+572)")]
    public const int NERR_DfsVolumeIsOffline = (2100 + 572);
    [NativeTypeName("#define NERR_DfsNoSuchServer (NERR_BASE+573)")]
    public const int NERR_DfsNoSuchServer = (2100 + 573);
    [NativeTypeName("#define NERR_DfsCyclicalName (NERR_BASE+574)")]
    public const int NERR_DfsCyclicalName = (2100 + 574);
    [NativeTypeName("#define NERR_DfsNotSupportedInServerDfs (NERR_BASE+575)")]
    public const int NERR_DfsNotSupportedInServerDfs = (2100 + 575);
    [NativeTypeName("#define NERR_DfsDuplicateService (NERR_BASE+576)")]
    public const int NERR_DfsDuplicateService = (2100 + 576);
    [NativeTypeName("#define NERR_DfsCantRemoveLastServerShare (NERR_BASE+577)")]
    public const int NERR_DfsCantRemoveLastServerShare = (2100 + 577);
    [NativeTypeName("#define NERR_DfsVolumeIsInterDfs (NERR_BASE+578)")]
    public const int NERR_DfsVolumeIsInterDfs = (2100 + 578);
    [NativeTypeName("#define NERR_DfsInconsistent (NERR_BASE+579)")]
    public const int NERR_DfsInconsistent = (2100 + 579);
    [NativeTypeName("#define NERR_DfsServerUpgraded (NERR_BASE+580)")]
    public const int NERR_DfsServerUpgraded = (2100 + 580);
    [NativeTypeName("#define NERR_DfsDataIsIdentical (NERR_BASE+581)")]
    public const int NERR_DfsDataIsIdentical = (2100 + 581);
    [NativeTypeName("#define NERR_DfsCantRemoveDfsRoot (NERR_BASE+582)")]
    public const int NERR_DfsCantRemoveDfsRoot = (2100 + 582);
    [NativeTypeName("#define NERR_DfsChildOrParentInDfs (NERR_BASE+583)")]
    public const int NERR_DfsChildOrParentInDfs = (2100 + 583);
    [NativeTypeName("#define NERR_DfsInternalError (NERR_BASE+590)")]
    public const int NERR_DfsInternalError = (2100 + 590);
    [NativeTypeName("#define NERR_SetupAlreadyJoined (NERR_BASE+591)")]
    public const int NERR_SetupAlreadyJoined = (2100 + 591);
    [NativeTypeName("#define NERR_SetupNotJoined (NERR_BASE+592)")]
    public const int NERR_SetupNotJoined = (2100 + 592);
    [NativeTypeName("#define NERR_SetupDomainController (NERR_BASE+593)")]
    public const int NERR_SetupDomainController = (2100 + 593);
    [NativeTypeName("#define NERR_DefaultJoinRequired (NERR_BASE+594)")]
    public const int NERR_DefaultJoinRequired = (2100 + 594);
    [NativeTypeName("#define NERR_InvalidWorkgroupName (NERR_BASE+595)")]
    public const int NERR_InvalidWorkgroupName = (2100 + 595);
    [NativeTypeName("#define NERR_NameUsesIncompatibleCodePage (NERR_BASE+596)")]
    public const int NERR_NameUsesIncompatibleCodePage = (2100 + 596);
    [NativeTypeName("#define NERR_ComputerAccountNotFound (NERR_BASE+597)")]
    public const int NERR_ComputerAccountNotFound = (2100 + 597);
    [NativeTypeName("#define NERR_PersonalSku (NERR_BASE+598)")]
    public const int NERR_PersonalSku = (2100 + 598);
    [NativeTypeName("#define NERR_SetupCheckDNSConfig (NERR_BASE+599)")]
    public const int NERR_SetupCheckDNSConfig = (2100 + 599);
    [NativeTypeName("#define NERR_AlreadyCloudDomainJoined (NERR_BASE+600)")]
    public const int NERR_AlreadyCloudDomainJoined = (2100 + 600);
    [NativeTypeName("#define NERR_PasswordMustChange (NERR_BASE + 601)")]
    public const int NERR_PasswordMustChange = (2100 + 601);
    [NativeTypeName("#define NERR_AccountLockedOut (NERR_BASE + 602)")]
    public const int NERR_AccountLockedOut = (2100 + 602);
    [NativeTypeName("#define NERR_PasswordTooLong (NERR_BASE + 603)")]
    public const int NERR_PasswordTooLong = (2100 + 603);
    [NativeTypeName("#define NERR_PasswordNotComplexEnough (NERR_BASE + 604)")]
    public const int NERR_PasswordNotComplexEnough = (2100 + 604);
    [NativeTypeName("#define NERR_PasswordFilterError (NERR_BASE + 605)")]
    public const int NERR_PasswordFilterError = (2100 + 605);
    [NativeTypeName("#define NERR_NoOfflineJoinInfo (NERR_BASE + 609)")]
    public const int NERR_NoOfflineJoinInfo = (2100 + 609);
    [NativeTypeName("#define NERR_BadOfflineJoinInfo (NERR_BASE + 610)")]
    public const int NERR_BadOfflineJoinInfo = (2100 + 610);
    [NativeTypeName("#define NERR_CantCreateJoinInfo (NERR_BASE + 611)")]
    public const int NERR_CantCreateJoinInfo = (2100 + 611);
    [NativeTypeName("#define NERR_BadDomainJoinInfo (NERR_BASE + 612)")]
    public const int NERR_BadDomainJoinInfo = (2100 + 612);
    [NativeTypeName("#define NERR_JoinPerformedMustRestart (NERR_BASE + 613)")]
    public const int NERR_JoinPerformedMustRestart = (2100 + 613);
    [NativeTypeName("#define NERR_NoJoinPending (NERR_BASE + 614)")]
    public const int NERR_NoJoinPending = (2100 + 614);
    [NativeTypeName("#define NERR_ValuesNotSet (NERR_BASE + 615)")]
    public const int NERR_ValuesNotSet = (2100 + 615);
    [NativeTypeName("#define NERR_CantVerifyHostname (NERR_BASE + 616)")]
    public const int NERR_CantVerifyHostname = (2100 + 616);
    [NativeTypeName("#define NERR_CantLoadOfflineHive (NERR_BASE + 617)")]
    public const int NERR_CantLoadOfflineHive = (2100 + 617);
    [NativeTypeName("#define NERR_ConnectionInsecure (NERR_BASE + 618)")]
    public const int NERR_ConnectionInsecure = (2100 + 618);
    [NativeTypeName("#define NERR_ProvisioningBlobUnsupported (NERR_BASE + 619)")]
    public const int NERR_ProvisioningBlobUnsupported = (2100 + 619);
    [NativeTypeName("#define NERR_DS8DCRequired (NERR_BASE + 620)")]
    public const int NERR_DS8DCRequired = (2100 + 620);
    [NativeTypeName("#define NERR_LDAPCapableDCRequired (NERR_BASE + 621)")]
    public const int NERR_LDAPCapableDCRequired = (2100 + 621);
    [NativeTypeName("#define NERR_DS8DCNotFound (NERR_BASE + 622)")]
    public const int NERR_DS8DCNotFound = (2100 + 622);
    [NativeTypeName("#define NERR_TargetVersionUnsupported (NERR_BASE + 623)")]
    public const int NERR_TargetVersionUnsupported = (2100 + 623);
    [NativeTypeName("#define NERR_InvalidMachineNameForJoin (NERR_BASE + 624)")]
    public const int NERR_InvalidMachineNameForJoin = (2100 + 624);
    [NativeTypeName("#define NERR_DS9DCNotFound (NERR_BASE + 625)")]
    public const int NERR_DS9DCNotFound = (2100 + 625);
    [NativeTypeName("#define NERR_PlainTextSecretsRequired (NERR_BASE + 626)")]
    public const int NERR_PlainTextSecretsRequired = (2100 + 626);
    [NativeTypeName("#define NERR_CannotUnjoinAadDomain (NERR_BASE + 627)")]
    public const int NERR_CannotUnjoinAadDomain = (2100 + 627);
    [NativeTypeName("#define NERR_CannotUpdateAadHostName (NERR_BASE + 628)")]
    public const int NERR_CannotUpdateAadHostName = (2100 + 628);
    [NativeTypeName("#define NERR_DuplicateHostName (NERR_BASE + 629)")]
    public const int NERR_DuplicateHostName = (2100 + 629);
    [NativeTypeName("#define NERR_HostNameTooLong (NERR_BASE + 630)")]
    public const int NERR_HostNameTooLong = (2100 + 630);
    [NativeTypeName("#define NERR_TooManyHostNames (NERR_BASE + 631)")]
    public const int NERR_TooManyHostNames = (2100 + 631);
    [NativeTypeName("#define NERR_AccountReuseBlockedByPolicy (NERR_BASE + 632)")]
    public const int NERR_AccountReuseBlockedByPolicy = (2100 + 632);
}