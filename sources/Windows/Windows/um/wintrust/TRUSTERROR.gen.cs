// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TRUSTERROR
{
    [NativeTypeName("#define TRUSTERROR_STEP_WVTPARAMS 0")]
    public const int TRUSTERROR_STEP_WVTPARAMS = 0;
    [NativeTypeName("#define TRUSTERROR_STEP_FILEIO 2")]
    public const int TRUSTERROR_STEP_FILEIO = 2;
    [NativeTypeName("#define TRUSTERROR_STEP_SIP 3")]
    public const int TRUSTERROR_STEP_SIP = 3;
    [NativeTypeName("#define TRUSTERROR_STEP_SIPSUBJINFO 5")]
    public const int TRUSTERROR_STEP_SIPSUBJINFO = 5;
    [NativeTypeName("#define TRUSTERROR_STEP_CATALOGFILE 6")]
    public const int TRUSTERROR_STEP_CATALOGFILE = 6;
    [NativeTypeName("#define TRUSTERROR_STEP_CERTSTORE 7")]
    public const int TRUSTERROR_STEP_CERTSTORE = 7;
    [NativeTypeName("#define TRUSTERROR_STEP_MESSAGE 8")]
    public const int TRUSTERROR_STEP_MESSAGE = 8;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERCOUNT 9")]
    public const int TRUSTERROR_STEP_MSG_SIGNERCOUNT = 9;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_INNERCNTTYPE 10")]
    public const int TRUSTERROR_STEP_MSG_INNERCNTTYPE = 10;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_INNERCNT 11")]
    public const int TRUSTERROR_STEP_MSG_INNERCNT = 11;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_STORE 12")]
    public const int TRUSTERROR_STEP_MSG_STORE = 12;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERINFO 13")]
    public const int TRUSTERROR_STEP_MSG_SIGNERINFO = 13;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_SIGNERCERT 14")]
    public const int TRUSTERROR_STEP_MSG_SIGNERCERT = 14;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_CERTCHAIN 15")]
    public const int TRUSTERROR_STEP_MSG_CERTCHAIN = 15;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_COUNTERSIGINFO 16")]
    public const int TRUSTERROR_STEP_MSG_COUNTERSIGINFO = 16;
    [NativeTypeName("#define TRUSTERROR_STEP_MSG_COUNTERSIGCERT 17")]
    public const int TRUSTERROR_STEP_MSG_COUNTERSIGCERT = 17;
    [NativeTypeName("#define TRUSTERROR_STEP_VERIFY_MSGHASH 18")]
    public const int TRUSTERROR_STEP_VERIFY_MSGHASH = 18;
    [NativeTypeName("#define TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA 19")]
    public const int TRUSTERROR_STEP_VERIFY_MSGINDIRECTDATA = 19;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_WVTINIT 30")]
    public const int TRUSTERROR_STEP_FINAL_WVTINIT = 30;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_INITPROV 31")]
    public const int TRUSTERROR_STEP_FINAL_INITPROV = 31;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_OBJPROV 32")]
    public const int TRUSTERROR_STEP_FINAL_OBJPROV = 32;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_SIGPROV 33")]
    public const int TRUSTERROR_STEP_FINAL_SIGPROV = 33;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_CERTPROV 34")]
    public const int TRUSTERROR_STEP_FINAL_CERTPROV = 34;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_CERTCHKPROV 35")]
    public const int TRUSTERROR_STEP_FINAL_CERTCHKPROV = 35;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_POLICYPROV 36")]
    public const int TRUSTERROR_STEP_FINAL_POLICYPROV = 36;
    [NativeTypeName("#define TRUSTERROR_STEP_FINAL_UIPROV 37")]
    public const int TRUSTERROR_STEP_FINAL_UIPROV = 37;
    [NativeTypeName("#define TRUSTERROR_MAX_STEPS 38")]
    public const int TRUSTERROR_MAX_STEPS = 38;
}