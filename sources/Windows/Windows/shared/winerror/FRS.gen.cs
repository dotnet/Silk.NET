// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class FRS
{
    [NativeTypeName("#define FRS_ERR_INVALID_API_SEQUENCE 8001L")]
    public const int FRS_ERR_INVALID_API_SEQUENCE = 8001;
    [NativeTypeName("#define FRS_ERR_STARTING_SERVICE 8002L")]
    public const int FRS_ERR_STARTING_SERVICE = 8002;
    [NativeTypeName("#define FRS_ERR_STOPPING_SERVICE 8003L")]
    public const int FRS_ERR_STOPPING_SERVICE = 8003;
    [NativeTypeName("#define FRS_ERR_INTERNAL_API 8004L")]
    public const int FRS_ERR_INTERNAL_API = 8004;
    [NativeTypeName("#define FRS_ERR_INTERNAL 8005L")]
    public const int FRS_ERR_INTERNAL = 8005;
    [NativeTypeName("#define FRS_ERR_SERVICE_COMM 8006L")]
    public const int FRS_ERR_SERVICE_COMM = 8006;
    [NativeTypeName("#define FRS_ERR_INSUFFICIENT_PRIV 8007L")]
    public const int FRS_ERR_INSUFFICIENT_PRIV = 8007;
    [NativeTypeName("#define FRS_ERR_AUTHENTICATION 8008L")]
    public const int FRS_ERR_AUTHENTICATION = 8008;
    [NativeTypeName("#define FRS_ERR_PARENT_INSUFFICIENT_PRIV 8009L")]
    public const int FRS_ERR_PARENT_INSUFFICIENT_PRIV = 8009;
    [NativeTypeName("#define FRS_ERR_PARENT_AUTHENTICATION 8010L")]
    public const int FRS_ERR_PARENT_AUTHENTICATION = 8010;
    [NativeTypeName("#define FRS_ERR_CHILD_TO_PARENT_COMM 8011L")]
    public const int FRS_ERR_CHILD_TO_PARENT_COMM = 8011;
    [NativeTypeName("#define FRS_ERR_PARENT_TO_CHILD_COMM 8012L")]
    public const int FRS_ERR_PARENT_TO_CHILD_COMM = 8012;
    [NativeTypeName("#define FRS_ERR_SYSVOL_POPULATE 8013L")]
    public const int FRS_ERR_SYSVOL_POPULATE = 8013;
    [NativeTypeName("#define FRS_ERR_SYSVOL_POPULATE_TIMEOUT 8014L")]
    public const int FRS_ERR_SYSVOL_POPULATE_TIMEOUT = 8014;
    [NativeTypeName("#define FRS_ERR_SYSVOL_IS_BUSY 8015L")]
    public const int FRS_ERR_SYSVOL_IS_BUSY = 8015;
    [NativeTypeName("#define FRS_ERR_SYSVOL_DEMOTE 8016L")]
    public const int FRS_ERR_SYSVOL_DEMOTE = 8016;
    [NativeTypeName("#define FRS_ERR_INVALID_SERVICE_PARAMETER 8017L")]
    public const int FRS_ERR_INVALID_SERVICE_PARAMETER = 8017;
}