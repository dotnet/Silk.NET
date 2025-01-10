// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TYPEKIND
{
    TKIND_ENUM = 0,
    TKIND_RECORD = (TKIND_ENUM + 1),
    TKIND_MODULE = (TKIND_RECORD + 1),
    TKIND_INTERFACE = (TKIND_MODULE + 1),
    TKIND_DISPATCH = (TKIND_INTERFACE + 1),
    TKIND_COCLASS = (TKIND_DISPATCH + 1),
    TKIND_ALIAS = (TKIND_COCLASS + 1),
    TKIND_UNION = (TKIND_ALIAS + 1),
    TKIND_MAX = (TKIND_UNION + 1),
}
