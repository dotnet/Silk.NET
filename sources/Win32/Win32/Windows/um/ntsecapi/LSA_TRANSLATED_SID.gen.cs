// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct LSA_TRANSLATED_SID
{
    public SID_NAME_USE Use;

    [NativeTypeName("ULONG")]
    public uint RelativeId;

    [NativeTypeName("LONG")]
    public int DomainIndex;
}
