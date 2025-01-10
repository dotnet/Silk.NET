// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct CLAIM_SECURITY_ATTRIBUTES_INFORMATION
{
    [NativeTypeName("WORD")]
    public ushort Version;

    [NativeTypeName("WORD")]
    public ushort Reserved;

    [NativeTypeName("DWORD")]
    public uint AttributeCount;

    [NativeTypeName("__AnonymousRecord_winnt_L12562_C5")]
    public _Attribute_e__Union Attribute;

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Attribute_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTE_V1")]
        public CLAIM_SECURITY_ATTRIBUTE_V1* pAttributeV1;
    }
}
