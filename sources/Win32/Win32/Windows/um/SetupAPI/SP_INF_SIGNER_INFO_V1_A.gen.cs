// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_INF_SIGNER_INFO_V1_A
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("CHAR[260]")]
    public _CatalogFile_e__FixedBuffer CatalogFile;

    [NativeTypeName("CHAR[260]")]
    public _DigitalSigner_e__FixedBuffer DigitalSigner;

    [NativeTypeName("CHAR[260]")]
    public _DigitalSignerVersion_e__FixedBuffer DigitalSignerVersion;

    [InlineArray(260)]
    public partial struct _CatalogFile_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(260)]
    public partial struct _DigitalSigner_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(260)]
    public partial struct _DigitalSignerVersion_e__FixedBuffer
    {
        public sbyte e0;
    }
}
