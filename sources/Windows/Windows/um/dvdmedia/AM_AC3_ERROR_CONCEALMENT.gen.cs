// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AM_AC3_ERROR_CONCEALMENT.xml' path='doc/member[@name="AM_AC3_ERROR_CONCEALMENT"]/*'/>
public partial struct AM_AC3_ERROR_CONCEALMENT
{
    /// <include file='AM_AC3_ERROR_CONCEALMENT.xml' path='doc/member[@name="AM_AC3_ERROR_CONCEALMENT.fRepeatPreviousBlock"]/*'/>
    public BOOL fRepeatPreviousBlock;
    /// <include file='AM_AC3_ERROR_CONCEALMENT.xml' path='doc/member[@name="AM_AC3_ERROR_CONCEALMENT.fErrorInCurrentBlock"]/*'/>
    public BOOL fErrorInCurrentBlock;
}