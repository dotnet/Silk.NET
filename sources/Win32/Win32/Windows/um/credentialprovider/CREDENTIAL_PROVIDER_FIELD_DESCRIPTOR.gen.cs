// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CREDENTIAL_PROVIDER_FIELD_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint dwFieldID;
    public CREDENTIAL_PROVIDER_FIELD_TYPE cpft;

    [NativeTypeName("LPWSTR")]
    public ushort* pszLabel;
    public Guid guidFieldType;
}
