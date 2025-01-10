// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum msidbComponentAttributes
{
    msidbComponentAttributesLocalOnly = 0x00000000,
    msidbComponentAttributesSourceOnly = 0x00000001,
    msidbComponentAttributesOptional = 0x00000002,
    msidbComponentAttributesRegistryKeyPath = 0x00000004,
    msidbComponentAttributesSharedDllRefCount = 0x00000008,
    msidbComponentAttributesPermanent = 0x00000010,
    msidbComponentAttributesODBCDataSource = 0x00000020,
    msidbComponentAttributesTransitive = 0x00000040,
    msidbComponentAttributesNeverOverwrite = 0x00000080,
    msidbComponentAttributes64bit = 0x00000100,
    msidbComponentAttributesDisableRegistryReflection = 0x00000200,
    msidbComponentAttributesUninstallOnSupersedence = 0x00000400,
    msidbComponentAttributesShared = 0x00000800,
}
