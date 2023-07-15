// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='ColorBalanceParams.xml' path='doc/member[@name="ColorBalanceParams"]/*'/>
public partial struct ColorBalanceParams
{
    /// <include file='ColorBalanceParams.xml' path='doc/member[@name="ColorBalanceParams.cyanRed"]/*'/>
    public int cyanRed;
    /// <include file='ColorBalanceParams.xml' path='doc/member[@name="ColorBalanceParams.magentaGreen"]/*'/>
    public int magentaGreen;
    /// <include file='ColorBalanceParams.xml' path='doc/member[@name="ColorBalanceParams.yellowBlue"]/*'/>
    public int yellowBlue;
}