// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CREDENTIAL_PROVIDER_FIELD_TYPE
{
    CPFT_INVALID = 0,
    CPFT_LARGE_TEXT = (CPFT_INVALID + 1),
    CPFT_SMALL_TEXT = (CPFT_LARGE_TEXT + 1),
    CPFT_COMMAND_LINK = (CPFT_SMALL_TEXT + 1),
    CPFT_EDIT_TEXT = (CPFT_COMMAND_LINK + 1),
    CPFT_PASSWORD_TEXT = (CPFT_EDIT_TEXT + 1),
    CPFT_TILE_IMAGE = (CPFT_PASSWORD_TEXT + 1),
    CPFT_CHECKBOX = (CPFT_TILE_IMAGE + 1),
    CPFT_COMBOBOX = (CPFT_CHECKBOX + 1),
    CPFT_SUBMIT_BUTTON = (CPFT_COMBOBOX + 1),
}
