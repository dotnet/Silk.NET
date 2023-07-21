// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS"]/*' />
public enum FILETYPEATTRIBUTEFLAGS
{
    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_None"]/*' />
    FTA_None = 0x00000000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_Exclude"]/*' />
    FTA_Exclude = 0x00000001,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_Show"]/*' />
    FTA_Show = 0x00000002,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_HasExtension"]/*' />
    FTA_HasExtension = 0x00000004,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEdit"]/*' />
    FTA_NoEdit = 0x00000008,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoRemove"]/*' />
    FTA_NoRemove = 0x00000010,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoNewVerb"]/*' />
    FTA_NoNewVerb = 0x00000020,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditVerb"]/*' />
    FTA_NoEditVerb = 0x00000040,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoRemoveVerb"]/*' />
    FTA_NoRemoveVerb = 0x00000080,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditDesc"]/*' />
    FTA_NoEditDesc = 0x00000100,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditIcon"]/*' />
    FTA_NoEditIcon = 0x00000200,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditDflt"]/*' />
    FTA_NoEditDflt = 0x00000400,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditVerbCmd"]/*' />
    FTA_NoEditVerbCmd = 0x00000800,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditVerbExe"]/*' />
    FTA_NoEditVerbExe = 0x00001000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoDDE"]/*' />
    FTA_NoDDE = 0x00002000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoEditMIME"]/*' />
    FTA_NoEditMIME = 0x00008000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_OpenIsSafe"]/*' />
    FTA_OpenIsSafe = 0x00010000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_AlwaysUnsafe"]/*' />
    FTA_AlwaysUnsafe = 0x00020000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_NoRecentDocs"]/*' />
    FTA_NoRecentDocs = 0x00100000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_SafeForElevation"]/*' />
    FTA_SafeForElevation = 0x00200000,

    /// <include file='FILETYPEATTRIBUTEFLAGS.xml' path='doc/member[@name="FILETYPEATTRIBUTEFLAGS.FTA_AlwaysUseDirectInvoke"]/*' />
    FTA_AlwaysUseDirectInvoke = 0x00400000,
}
