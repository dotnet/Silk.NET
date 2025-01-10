// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MSISOURCETYPE
{
    MSISOURCETYPE_UNKNOWN = 0x00000000,
    MSISOURCETYPE_NETWORK = 0x00000001,
    MSISOURCETYPE_URL = 0x00000002,
    MSISOURCETYPE_MEDIA = 0x00000004,
}
