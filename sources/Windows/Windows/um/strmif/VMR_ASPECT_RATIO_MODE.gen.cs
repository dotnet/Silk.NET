// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VMR_ASPECT_RATIO_MODE.xml' path='doc/member[@name="VMR_ASPECT_RATIO_MODE"]/*'/>
public enum VMR_ASPECT_RATIO_MODE
{
    /// <include file='VMR_ASPECT_RATIO_MODE.xml' path='doc/member[@name="VMR_ASPECT_RATIO_MODE.VMR_ARMODE_NONE"]/*'/>
    VMR_ARMODE_NONE = 0,
    /// <include file='VMR_ASPECT_RATIO_MODE.xml' path='doc/member[@name="VMR_ASPECT_RATIO_MODE.VMR_ARMODE_LETTER_BOX"]/*'/>
    VMR_ARMODE_LETTER_BOX = (VMR_ARMODE_NONE + 1),
}