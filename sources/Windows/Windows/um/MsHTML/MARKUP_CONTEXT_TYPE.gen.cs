// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE"]/*'/>
public enum MARKUP_CONTEXT_TYPE
{
    /// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE.CONTEXT_TYPE_None"]/*'/>
    CONTEXT_TYPE_None = 0,
    /// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE.CONTEXT_TYPE_Text"]/*'/>
    CONTEXT_TYPE_Text = 1,
    /// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE.CONTEXT_TYPE_EnterScope"]/*'/>
    CONTEXT_TYPE_EnterScope = 2,
    /// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE.CONTEXT_TYPE_ExitScope"]/*'/>
    CONTEXT_TYPE_ExitScope = 3,
    /// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE.CONTEXT_TYPE_NoScope"]/*'/>
    CONTEXT_TYPE_NoScope = 4,
    /// <include file='MARKUP_CONTEXT_TYPE.xml' path='doc/member[@name="MARKUP_CONTEXT_TYPE.MARKUP_CONTEXT_TYPE_Max"]/*'/>
    MARKUP_CONTEXT_TYPE_Max = 2147483647,
}