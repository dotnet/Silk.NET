// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_TIME_STAMP_REQUEST_INFO
{
    [NativeTypeName("LPSTR")]
    public sbyte* pszTimeStampAlgorithm;

    [NativeTypeName("LPSTR")]
    public sbyte* pszContentType;

    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Content;

    [NativeTypeName("DWORD")]
    public uint cAttribute;

    [NativeTypeName("PCRYPT_ATTRIBUTE")]
    public CRYPT_ATTRIBUTE* rgAttribute;
}
