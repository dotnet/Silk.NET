// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ATTACHMENT_PROMPT.xml' path='doc/member[@name="ATTACHMENT_PROMPT"]/*' />
public enum ATTACHMENT_PROMPT
{
    /// <include file='ATTACHMENT_PROMPT.xml' path='doc/member[@name="ATTACHMENT_PROMPT.ATTACHMENT_PROMPT_NONE"]/*' />
    ATTACHMENT_PROMPT_NONE = 0,

    /// <include file='ATTACHMENT_PROMPT.xml' path='doc/member[@name="ATTACHMENT_PROMPT.ATTACHMENT_PROMPT_SAVE"]/*' />
    ATTACHMENT_PROMPT_SAVE = 0x1,

    /// <include file='ATTACHMENT_PROMPT.xml' path='doc/member[@name="ATTACHMENT_PROMPT.ATTACHMENT_PROMPT_EXEC"]/*' />
    ATTACHMENT_PROMPT_EXEC = 0x2,

    /// <include file='ATTACHMENT_PROMPT.xml' path='doc/member[@name="ATTACHMENT_PROMPT.ATTACHMENT_PROMPT_EXEC_OR_SAVE"]/*' />
    ATTACHMENT_PROMPT_EXEC_OR_SAVE = 0x3,
}
