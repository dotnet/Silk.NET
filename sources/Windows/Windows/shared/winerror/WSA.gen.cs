// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WSA
{
    [NativeTypeName("#define WSA_E_NO_MORE 10110L")]
    public const int WSA_E_NO_MORE = 10110;
    [NativeTypeName("#define WSA_E_CANCELLED 10111L")]
    public const int WSA_E_CANCELLED = 10111;
    [NativeTypeName("#define WSA_QOS_RECEIVERS 11005L")]
    public const int WSA_QOS_RECEIVERS = 11005;
    [NativeTypeName("#define WSA_QOS_SENDERS 11006L")]
    public const int WSA_QOS_SENDERS = 11006;
    [NativeTypeName("#define WSA_QOS_NO_SENDERS 11007L")]
    public const int WSA_QOS_NO_SENDERS = 11007;
    [NativeTypeName("#define WSA_QOS_NO_RECEIVERS 11008L")]
    public const int WSA_QOS_NO_RECEIVERS = 11008;
    [NativeTypeName("#define WSA_QOS_REQUEST_CONFIRMED 11009L")]
    public const int WSA_QOS_REQUEST_CONFIRMED = 11009;
    [NativeTypeName("#define WSA_QOS_ADMISSION_FAILURE 11010L")]
    public const int WSA_QOS_ADMISSION_FAILURE = 11010;
    [NativeTypeName("#define WSA_QOS_POLICY_FAILURE 11011L")]
    public const int WSA_QOS_POLICY_FAILURE = 11011;
    [NativeTypeName("#define WSA_QOS_BAD_STYLE 11012L")]
    public const int WSA_QOS_BAD_STYLE = 11012;
    [NativeTypeName("#define WSA_QOS_BAD_OBJECT 11013L")]
    public const int WSA_QOS_BAD_OBJECT = 11013;
    [NativeTypeName("#define WSA_QOS_TRAFFIC_CTRL_ERROR 11014L")]
    public const int WSA_QOS_TRAFFIC_CTRL_ERROR = 11014;
    [NativeTypeName("#define WSA_QOS_GENERIC_ERROR 11015L")]
    public const int WSA_QOS_GENERIC_ERROR = 11015;
    [NativeTypeName("#define WSA_QOS_ESERVICETYPE 11016L")]
    public const int WSA_QOS_ESERVICETYPE = 11016;
    [NativeTypeName("#define WSA_QOS_EFLOWSPEC 11017L")]
    public const int WSA_QOS_EFLOWSPEC = 11017;
    [NativeTypeName("#define WSA_QOS_EPROVSPECBUF 11018L")]
    public const int WSA_QOS_EPROVSPECBUF = 11018;
    [NativeTypeName("#define WSA_QOS_EFILTERSTYLE 11019L")]
    public const int WSA_QOS_EFILTERSTYLE = 11019;
    [NativeTypeName("#define WSA_QOS_EFILTERTYPE 11020L")]
    public const int WSA_QOS_EFILTERTYPE = 11020;
    [NativeTypeName("#define WSA_QOS_EFILTERCOUNT 11021L")]
    public const int WSA_QOS_EFILTERCOUNT = 11021;
    [NativeTypeName("#define WSA_QOS_EOBJLENGTH 11022L")]
    public const int WSA_QOS_EOBJLENGTH = 11022;
    [NativeTypeName("#define WSA_QOS_EFLOWCOUNT 11023L")]
    public const int WSA_QOS_EFLOWCOUNT = 11023;
    [NativeTypeName("#define WSA_QOS_EUNKOWNPSOBJ 11024L")]
    public const int WSA_QOS_EUNKOWNPSOBJ = 11024;
    [NativeTypeName("#define WSA_QOS_EPOLICYOBJ 11025L")]
    public const int WSA_QOS_EPOLICYOBJ = 11025;
    [NativeTypeName("#define WSA_QOS_EFLOWDESC 11026L")]
    public const int WSA_QOS_EFLOWDESC = 11026;
    [NativeTypeName("#define WSA_QOS_EPSFLOWSPEC 11027L")]
    public const int WSA_QOS_EPSFLOWSPEC = 11027;
    [NativeTypeName("#define WSA_QOS_EPSFILTERSPEC 11028L")]
    public const int WSA_QOS_EPSFILTERSPEC = 11028;
    [NativeTypeName("#define WSA_QOS_ESDMODEOBJ 11029L")]
    public const int WSA_QOS_ESDMODEOBJ = 11029;
    [NativeTypeName("#define WSA_QOS_ESHAPERATEOBJ 11030L")]
    public const int WSA_QOS_ESHAPERATEOBJ = 11030;
    [NativeTypeName("#define WSA_QOS_RESERVED_PETYPE 11031L")]
    public const int WSA_QOS_RESERVED_PETYPE = 11031;
    [NativeTypeName("#define WSA_SECURE_HOST_NOT_FOUND 11032L")]
    public const int WSA_SECURE_HOST_NOT_FOUND = 11032;
    [NativeTypeName("#define WSA_IPSEC_NAME_POLICY_ERROR 11033L")]
    public const int WSA_IPSEC_NAME_POLICY_ERROR = 11033;
}