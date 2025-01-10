// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DEFAULT_FOLDER_MENU_RESTRICTIONS
{
    DFMR_DEFAULT = 0,
    DFMR_NO_STATIC_VERBS = 0x8,
    DFMR_STATIC_VERBS_ONLY = 0x10,
    DFMR_NO_RESOURCE_VERBS = 0x20,
    DFMR_OPTIN_HANDLERS_ONLY = 0x40,
    DFMR_RESOURCE_AND_FOLDER_VERBS_ONLY = 0x80,
    DFMR_USE_SPECIFIED_HANDLERS = 0x100,
    DFMR_USE_SPECIFIED_VERBS = 0x200,
    DFMR_NO_ASYNC_VERBS = 0x400,
    DFMR_NO_NATIVECPU_VERBS = 0x800,
    DFMR_NO_NONWOW_VERBS = 0x1000,
}
