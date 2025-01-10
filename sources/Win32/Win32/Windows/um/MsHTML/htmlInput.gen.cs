// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum htmlInput
{
    htmlInputNotSet = 0,
    htmlInputButton = 1,
    htmlInputCheckbox = 2,
    htmlInputFile = 3,
    htmlInputHidden = 4,
    htmlInputImage = 5,
    htmlInputPassword = 6,
    htmlInputRadio = 7,
    htmlInputReset = 8,
    htmlInputSelectOne = 9,
    htmlInputSelectMultiple = 10,
    htmlInputSubmit = 11,
    htmlInputText = 12,
    htmlInputTextarea = 13,
    htmlInputRichtext = 14,
    htmlInputRange = 15,
    htmlInputUrl = 16,
    htmlInputEmail = 17,
    htmlInputNumber = 18,
    htmlInputTel = 19,
    htmlInputSearch = 20,
    htmlInput_Max = 2147483647,
}
