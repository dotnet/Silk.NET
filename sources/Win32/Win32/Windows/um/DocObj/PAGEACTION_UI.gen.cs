// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PAGEACTION_UI
{
    PAGEACTION_UI_DEFAULT = 0,
    PAGEACTION_UI_MODAL = 1,
    PAGEACTION_UI_MODELESS = 2,
    PAGEACTION_UI_SILENT = 3,
}
