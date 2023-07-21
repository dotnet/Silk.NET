// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='htmlInput.xml' path='doc/member[@name="htmlInput"]/*' />
public enum htmlInput
{
    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputNotSet"]/*' />
    htmlInputNotSet = 0,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputButton"]/*' />
    htmlInputButton = 1,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputCheckbox"]/*' />
    htmlInputCheckbox = 2,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputFile"]/*' />
    htmlInputFile = 3,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputHidden"]/*' />
    htmlInputHidden = 4,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputImage"]/*' />
    htmlInputImage = 5,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputPassword"]/*' />
    htmlInputPassword = 6,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputRadio"]/*' />
    htmlInputRadio = 7,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputReset"]/*' />
    htmlInputReset = 8,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputSelectOne"]/*' />
    htmlInputSelectOne = 9,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputSelectMultiple"]/*' />
    htmlInputSelectMultiple = 10,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputSubmit"]/*' />
    htmlInputSubmit = 11,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputText"]/*' />
    htmlInputText = 12,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputTextarea"]/*' />
    htmlInputTextarea = 13,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputRichtext"]/*' />
    htmlInputRichtext = 14,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputRange"]/*' />
    htmlInputRange = 15,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputUrl"]/*' />
    htmlInputUrl = 16,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputEmail"]/*' />
    htmlInputEmail = 17,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputNumber"]/*' />
    htmlInputNumber = 18,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputTel"]/*' />
    htmlInputTel = 19,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInputSearch"]/*' />
    htmlInputSearch = 20,

    /// <include file='htmlInput.xml' path='doc/member[@name="htmlInput.htmlInput_Max"]/*' />
    htmlInput_Max = 2147483647,
}
