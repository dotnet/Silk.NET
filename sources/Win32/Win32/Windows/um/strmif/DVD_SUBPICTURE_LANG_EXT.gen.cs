// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_SUBPICTURE_LANG_EXT
{
    DVD_SP_EXT_NotSpecified = 0,
    DVD_SP_EXT_Caption_Normal = 1,
    DVD_SP_EXT_Caption_Big = 2,
    DVD_SP_EXT_Caption_Children = 3,
    DVD_SP_EXT_CC_Normal = 5,
    DVD_SP_EXT_CC_Big = 6,
    DVD_SP_EXT_CC_Children = 7,
    DVD_SP_EXT_Forced = 9,
    DVD_SP_EXT_DirectorComments_Normal = 13,
    DVD_SP_EXT_DirectorComments_Big = 14,
    DVD_SP_EXT_DirectorComments_Children = 15,
}
