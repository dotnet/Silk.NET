// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FILETYPEATTRIBUTEFLAGS
{
    FTA_None = 0x00000000,
    FTA_Exclude = 0x00000001,
    FTA_Show = 0x00000002,
    FTA_HasExtension = 0x00000004,
    FTA_NoEdit = 0x00000008,
    FTA_NoRemove = 0x00000010,
    FTA_NoNewVerb = 0x00000020,
    FTA_NoEditVerb = 0x00000040,
    FTA_NoRemoveVerb = 0x00000080,
    FTA_NoEditDesc = 0x00000100,
    FTA_NoEditIcon = 0x00000200,
    FTA_NoEditDflt = 0x00000400,
    FTA_NoEditVerbCmd = 0x00000800,
    FTA_NoEditVerbExe = 0x00001000,
    FTA_NoDDE = 0x00002000,
    FTA_NoEditMIME = 0x00008000,
    FTA_OpenIsSafe = 0x00010000,
    FTA_AlwaysUnsafe = 0x00020000,
    FTA_NoRecentDocs = 0x00100000,
    FTA_SafeForElevation = 0x00200000,
    FTA_AlwaysUseDirectInvoke = 0x00400000,
}
