// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY 0x00000001")]
    public const int CRM_PROTOCOL_EXPLICIT_MARSHAL_ONLY = 0x00000001;
    [NativeTypeName("#define CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO 0x00000002")]
    public const int CRM_PROTOCOL_DYNAMIC_MARSHAL_INFO = 0x00000002;
    [NativeTypeName("#define CRM_PROTOCOL_MAXIMUM_OPTION 0x00000003")]
    public const int CRM_PROTOCOL_MAXIMUM_OPTION = 0x00000003;
    [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MAJOR 1")]
    public const int KTM_MARSHAL_BLOB_VERSION_MAJOR = 1;
    [NativeTypeName("#define KTM_MARSHAL_BLOB_VERSION_MINOR 1")]
    public const int KTM_MARSHAL_BLOB_VERSION_MINOR = 1;
}