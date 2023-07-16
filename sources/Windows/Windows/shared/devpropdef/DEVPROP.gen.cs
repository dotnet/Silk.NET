// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/devpropdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class DEVPROP
{
    [NativeTypeName("#define DEVPROP_TYPEMOD_ARRAY 0x00001000")]
    public const int DEVPROP_TYPEMOD_ARRAY = 0x00001000;
    [NativeTypeName("#define DEVPROP_TYPEMOD_LIST 0x00002000")]
    public const int DEVPROP_TYPEMOD_LIST = 0x00002000;
    [NativeTypeName("#define DEVPROP_TYPE_EMPTY 0x00000000")]
    public const int DEVPROP_TYPE_EMPTY = 0x00000000;
    [NativeTypeName("#define DEVPROP_TYPE_NULL 0x00000001")]
    public const int DEVPROP_TYPE_NULL = 0x00000001;
    [NativeTypeName("#define DEVPROP_TYPE_SBYTE 0x00000002")]
    public const int DEVPROP_TYPE_SBYTE = 0x00000002;
    [NativeTypeName("#define DEVPROP_TYPE_BYTE 0x00000003")]
    public const int DEVPROP_TYPE_BYTE = 0x00000003;
    [NativeTypeName("#define DEVPROP_TYPE_INT16 0x00000004")]
    public const int DEVPROP_TYPE_INT16 = 0x00000004;
    [NativeTypeName("#define DEVPROP_TYPE_UINT16 0x00000005")]
    public const int DEVPROP_TYPE_UINT16 = 0x00000005;
    [NativeTypeName("#define DEVPROP_TYPE_INT32 0x00000006")]
    public const int DEVPROP_TYPE_INT32 = 0x00000006;
    [NativeTypeName("#define DEVPROP_TYPE_UINT32 0x00000007")]
    public const int DEVPROP_TYPE_UINT32 = 0x00000007;
    [NativeTypeName("#define DEVPROP_TYPE_INT64 0x00000008")]
    public const int DEVPROP_TYPE_INT64 = 0x00000008;
    [NativeTypeName("#define DEVPROP_TYPE_UINT64 0x00000009")]
    public const int DEVPROP_TYPE_UINT64 = 0x00000009;
    [NativeTypeName("#define DEVPROP_TYPE_FLOAT 0x0000000A")]
    public const int DEVPROP_TYPE_FLOAT = 0x0000000A;
    [NativeTypeName("#define DEVPROP_TYPE_DOUBLE 0x0000000B")]
    public const int DEVPROP_TYPE_DOUBLE = 0x0000000B;
    [NativeTypeName("#define DEVPROP_TYPE_DECIMAL 0x0000000C")]
    public const int DEVPROP_TYPE_DECIMAL = 0x0000000C;
    [NativeTypeName("#define DEVPROP_TYPE_GUID 0x0000000D")]
    public const int DEVPROP_TYPE_GUID = 0x0000000D;
    [NativeTypeName("#define DEVPROP_TYPE_CURRENCY 0x0000000E")]
    public const int DEVPROP_TYPE_CURRENCY = 0x0000000E;
    [NativeTypeName("#define DEVPROP_TYPE_DATE 0x0000000F")]
    public const int DEVPROP_TYPE_DATE = 0x0000000F;
    [NativeTypeName("#define DEVPROP_TYPE_FILETIME 0x00000010")]
    public const int DEVPROP_TYPE_FILETIME = 0x00000010;
    [NativeTypeName("#define DEVPROP_TYPE_BOOLEAN 0x00000011")]
    public const int DEVPROP_TYPE_BOOLEAN = 0x00000011;
    [NativeTypeName("#define DEVPROP_TYPE_STRING 0x00000012")]
    public const int DEVPROP_TYPE_STRING = 0x00000012;
    [NativeTypeName("#define DEVPROP_TYPE_STRING_LIST (DEVPROP_TYPE_STRING|DEVPROP_TYPEMOD_LIST)")]
    public const int DEVPROP_TYPE_STRING_LIST = (0x00000012 | 0x00002000);
    [NativeTypeName("#define DEVPROP_TYPE_SECURITY_DESCRIPTOR 0x00000013")]
    public const int DEVPROP_TYPE_SECURITY_DESCRIPTOR = 0x00000013;
    [NativeTypeName("#define DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING 0x00000014")]
    public const int DEVPROP_TYPE_SECURITY_DESCRIPTOR_STRING = 0x00000014;
    [NativeTypeName("#define DEVPROP_TYPE_DEVPROPKEY 0x00000015")]
    public const int DEVPROP_TYPE_DEVPROPKEY = 0x00000015;
    [NativeTypeName("#define DEVPROP_TYPE_DEVPROPTYPE 0x00000016")]
    public const int DEVPROP_TYPE_DEVPROPTYPE = 0x00000016;
    [NativeTypeName("#define DEVPROP_TYPE_BINARY (DEVPROP_TYPE_BYTE|DEVPROP_TYPEMOD_ARRAY)")]
    public const int DEVPROP_TYPE_BINARY = (0x00000003 | 0x00001000);
    [NativeTypeName("#define DEVPROP_TYPE_ERROR 0x00000017")]
    public const int DEVPROP_TYPE_ERROR = 0x00000017;
    [NativeTypeName("#define DEVPROP_TYPE_NTSTATUS 0x00000018")]
    public const int DEVPROP_TYPE_NTSTATUS = 0x00000018;
    [NativeTypeName("#define DEVPROP_TYPE_STRING_INDIRECT 0x00000019")]
    public const int DEVPROP_TYPE_STRING_INDIRECT = 0x00000019;
    [NativeTypeName("#define DEVPROP_MASK_TYPE 0x00000FFF")]
    public const int DEVPROP_MASK_TYPE = 0x00000FFF;
    [NativeTypeName("#define DEVPROP_MASK_TYPEMOD 0x0000F000")]
    public const int DEVPROP_MASK_TYPEMOD = 0x0000F000;
    [NativeTypeName("#define DEVPROP_TRUE ((DEVPROP_BOOLEAN)-1)")]
    public const sbyte DEVPROP_TRUE = ((sbyte)(-1));
    [NativeTypeName("#define DEVPROP_FALSE ((DEVPROP_BOOLEAN) 0)")]
    public const sbyte DEVPROP_FALSE = ((sbyte)(0));
}