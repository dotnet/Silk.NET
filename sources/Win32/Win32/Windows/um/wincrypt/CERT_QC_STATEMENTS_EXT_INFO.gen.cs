// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_QC_STATEMENTS_EXT_INFO
{
    [NativeTypeName("DWORD")]
    public uint cStatement;

    [NativeTypeName("PCERT_QC_STATEMENT")]
    public CERT_QC_STATEMENT* rgStatement;
}
