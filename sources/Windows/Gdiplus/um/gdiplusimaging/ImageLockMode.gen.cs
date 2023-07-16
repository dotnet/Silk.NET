// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Gdiplus;
/// <include file='ImageLockMode.xml' path='doc/member[@name="ImageLockMode"]/*'/>
public enum ImageLockMode
{
    /// <include file='ImageLockMode.xml' path='doc/member[@name="ImageLockMode.ImageLockModeRead"]/*'/>
    ImageLockModeRead = 0x0001,
    /// <include file='ImageLockMode.xml' path='doc/member[@name="ImageLockMode.ImageLockModeWrite"]/*'/>
    ImageLockModeWrite = 0x0002,
    /// <include file='ImageLockMode.xml' path='doc/member[@name="ImageLockMode.ImageLockModeUserInputBuf"]/*'/>
    ImageLockModeUserInputBuf = 0x0004,
}