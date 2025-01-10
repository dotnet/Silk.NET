// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DISPID
{
    [NativeTypeName("#define DISPID_DFILESYSTEMIMAGEEVENTS_UPDATE 0x100")]
    public const int DISPID_DFILESYSTEMIMAGEEVENTS_UPDATE = 0x100;

    [NativeTypeName("#define DISPID_DFILESYSTEMIMAGEIMPORTEVENTS_UPDATEIMPORT 0x101")]
    public const int DISPID_DFILESYSTEMIMAGEIMPORTEVENTS_UPDATEIMPORT = 0x101;
}
