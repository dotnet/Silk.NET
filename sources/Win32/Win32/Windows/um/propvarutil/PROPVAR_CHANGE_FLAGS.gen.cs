// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PROPVAR_CHANGE_FLAGS
{
    PVCHF_DEFAULT = 0x00000000,
    PVCHF_NOVALUEPROP = 0x00000001,
    PVCHF_ALPHABOOL = 0x00000002,
    PVCHF_NOUSEROVERRIDE = 0x00000004,
    PVCHF_LOCALBOOL = 0x00000008,
    PVCHF_NOHEXSTRING = 0x00000010,
}
