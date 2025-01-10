// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mferror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class FACILITY
{
    [NativeTypeName("#define FACILITY_MF 0xD")]
    public const int FACILITY_MF = 0xD;

    [NativeTypeName("#define FACILITY_MF_WIN32 0x7")]
    public const int FACILITY_MF_WIN32 = 0x7;
}
