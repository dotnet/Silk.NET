// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS"]/*'/>
public enum WINDOWPARTS
{
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_CAPTION"]/*'/>
    WP_CAPTION = 1,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLCAPTION"]/*'/>
    WP_SMALLCAPTION = 2,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MINCAPTION"]/*'/>
    WP_MINCAPTION = 3,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLMINCAPTION"]/*'/>
    WP_SMALLMINCAPTION = 4,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MAXCAPTION"]/*'/>
    WP_MAXCAPTION = 5,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLMAXCAPTION"]/*'/>
    WP_SMALLMAXCAPTION = 6,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAMELEFT"]/*'/>
    WP_FRAMELEFT = 7,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAMERIGHT"]/*'/>
    WP_FRAMERIGHT = 8,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAMEBOTTOM"]/*'/>
    WP_FRAMEBOTTOM = 9,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLFRAMELEFT"]/*'/>
    WP_SMALLFRAMELEFT = 10,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLFRAMERIGHT"]/*'/>
    WP_SMALLFRAMERIGHT = 11,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLFRAMEBOTTOM"]/*'/>
    WP_SMALLFRAMEBOTTOM = 12,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SYSBUTTON"]/*'/>
    WP_SYSBUTTON = 13,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MDISYSBUTTON"]/*'/>
    WP_MDISYSBUTTON = 14,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MINBUTTON"]/*'/>
    WP_MINBUTTON = 15,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MDIMINBUTTON"]/*'/>
    WP_MDIMINBUTTON = 16,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MAXBUTTON"]/*'/>
    WP_MAXBUTTON = 17,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_CLOSEBUTTON"]/*'/>
    WP_CLOSEBUTTON = 18,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLCLOSEBUTTON"]/*'/>
    WP_SMALLCLOSEBUTTON = 19,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MDICLOSEBUTTON"]/*'/>
    WP_MDICLOSEBUTTON = 20,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_RESTOREBUTTON"]/*'/>
    WP_RESTOREBUTTON = 21,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MDIRESTOREBUTTON"]/*'/>
    WP_MDIRESTOREBUTTON = 22,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_HELPBUTTON"]/*'/>
    WP_HELPBUTTON = 23,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_MDIHELPBUTTON"]/*'/>
    WP_MDIHELPBUTTON = 24,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_HORZSCROLL"]/*'/>
    WP_HORZSCROLL = 25,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_HORZTHUMB"]/*'/>
    WP_HORZTHUMB = 26,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_VERTSCROLL"]/*'/>
    WP_VERTSCROLL = 27,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_VERTTHUMB"]/*'/>
    WP_VERTTHUMB = 28,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_DIALOG"]/*'/>
    WP_DIALOG = 29,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_CAPTIONSIZINGTEMPLATE"]/*'/>
    WP_CAPTIONSIZINGTEMPLATE = 30,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLCAPTIONSIZINGTEMPLATE"]/*'/>
    WP_SMALLCAPTIONSIZINGTEMPLATE = 31,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAMELEFTSIZINGTEMPLATE"]/*'/>
    WP_FRAMELEFTSIZINGTEMPLATE = 32,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLFRAMELEFTSIZINGTEMPLATE"]/*'/>
    WP_SMALLFRAMELEFTSIZINGTEMPLATE = 33,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAMERIGHTSIZINGTEMPLATE"]/*'/>
    WP_FRAMERIGHTSIZINGTEMPLATE = 34,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLFRAMERIGHTSIZINGTEMPLATE"]/*'/>
    WP_SMALLFRAMERIGHTSIZINGTEMPLATE = 35,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAMEBOTTOMSIZINGTEMPLATE"]/*'/>
    WP_FRAMEBOTTOMSIZINGTEMPLATE = 36,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_SMALLFRAMEBOTTOMSIZINGTEMPLATE"]/*'/>
    WP_SMALLFRAMEBOTTOMSIZINGTEMPLATE = 37,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_FRAME"]/*'/>
    WP_FRAME = 38,
    /// <include file='WINDOWPARTS.xml' path='doc/member[@name="WINDOWPARTS.WP_BORDER"]/*'/>
    WP_BORDER = 39,
}