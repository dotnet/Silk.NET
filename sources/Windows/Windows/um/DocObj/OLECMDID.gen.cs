// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID"]/*' />
public enum OLECMDID
{
    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_OPEN"]/*' />
    OLECMDID_OPEN = 1,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_NEW"]/*' />
    OLECMDID_NEW = 2,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SAVE"]/*' />
    OLECMDID_SAVE = 3,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SAVEAS"]/*' />
    OLECMDID_SAVEAS = 4,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SAVECOPYAS"]/*' />
    OLECMDID_SAVECOPYAS = 5,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PRINT"]/*' />
    OLECMDID_PRINT = 6,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PRINTPREVIEW"]/*' />
    OLECMDID_PRINTPREVIEW = 7,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PAGESETUP"]/*' />
    OLECMDID_PAGESETUP = 8,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SPELL"]/*' />
    OLECMDID_SPELL = 9,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PROPERTIES"]/*' />
    OLECMDID_PROPERTIES = 10,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_CUT"]/*' />
    OLECMDID_CUT = 11,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_COPY"]/*' />
    OLECMDID_COPY = 12,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PASTE"]/*' />
    OLECMDID_PASTE = 13,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PASTESPECIAL"]/*' />
    OLECMDID_PASTESPECIAL = 14,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UNDO"]/*' />
    OLECMDID_UNDO = 15,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_REDO"]/*' />
    OLECMDID_REDO = 16,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SELECTALL"]/*' />
    OLECMDID_SELECTALL = 17,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_CLEARSELECTION"]/*' />
    OLECMDID_CLEARSELECTION = 18,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ZOOM"]/*' />
    OLECMDID_ZOOM = 19,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_GETZOOMRANGE"]/*' />
    OLECMDID_GETZOOMRANGE = 20,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UPDATECOMMANDS"]/*' />
    OLECMDID_UPDATECOMMANDS = 21,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_REFRESH"]/*' />
    OLECMDID_REFRESH = 22,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_STOP"]/*' />
    OLECMDID_STOP = 23,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_HIDETOOLBARS"]/*' />
    OLECMDID_HIDETOOLBARS = 24,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETPROGRESSMAX"]/*' />
    OLECMDID_SETPROGRESSMAX = 25,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETPROGRESSPOS"]/*' />
    OLECMDID_SETPROGRESSPOS = 26,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETPROGRESSTEXT"]/*' />
    OLECMDID_SETPROGRESSTEXT = 27,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETTITLE"]/*' />
    OLECMDID_SETTITLE = 28,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETDOWNLOADSTATE"]/*' />
    OLECMDID_SETDOWNLOADSTATE = 29,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_STOPDOWNLOAD"]/*' />
    OLECMDID_STOPDOWNLOAD = 30,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ONTOOLBARACTIVATED"]/*' />
    OLECMDID_ONTOOLBARACTIVATED = 31,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_FIND"]/*' />
    OLECMDID_FIND = 32,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_DELETE"]/*' />
    OLECMDID_DELETE = 33,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_HTTPEQUIV"]/*' />
    OLECMDID_HTTPEQUIV = 34,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_HTTPEQUIV_DONE"]/*' />
    OLECMDID_HTTPEQUIV_DONE = 35,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ENABLE_INTERACTION"]/*' />
    OLECMDID_ENABLE_INTERACTION = 36,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ONUNLOAD"]/*' />
    OLECMDID_ONUNLOAD = 37,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PROPERTYBAG2"]/*' />
    OLECMDID_PROPERTYBAG2 = 38,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PREREFRESH"]/*' />
    OLECMDID_PREREFRESH = 39,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWSCRIPTERROR"]/*' />
    OLECMDID_SHOWSCRIPTERROR = 40,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWMESSAGE"]/*' />
    OLECMDID_SHOWMESSAGE = 41,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWFIND"]/*' />
    OLECMDID_SHOWFIND = 42,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWPAGESETUP"]/*' />
    OLECMDID_SHOWPAGESETUP = 43,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWPRINT"]/*' />
    OLECMDID_SHOWPRINT = 44,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_CLOSE"]/*' />
    OLECMDID_CLOSE = 45,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ALLOWUILESSSAVEAS"]/*' />
    OLECMDID_ALLOWUILESSSAVEAS = 46,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_DONTDOWNLOADCSS"]/*' />
    OLECMDID_DONTDOWNLOADCSS = 47,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UPDATEPAGESTATUS"]/*' />
    OLECMDID_UPDATEPAGESTATUS = 48,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PRINT2"]/*' />
    OLECMDID_PRINT2 = 49,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PRINTPREVIEW2"]/*' />
    OLECMDID_PRINTPREVIEW2 = 50,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETPRINTTEMPLATE"]/*' />
    OLECMDID_SETPRINTTEMPLATE = 51,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_GETPRINTTEMPLATE"]/*' />
    OLECMDID_GETPRINTTEMPLATE = 52,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PAGEACTIONBLOCKED"]/*' />
    OLECMDID_PAGEACTIONBLOCKED = 55,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PAGEACTIONUIQUERY"]/*' />
    OLECMDID_PAGEACTIONUIQUERY = 56,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_FOCUSVIEWCONTROLS"]/*' />
    OLECMDID_FOCUSVIEWCONTROLS = 57,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_FOCUSVIEWCONTROLSQUERY"]/*' />
    OLECMDID_FOCUSVIEWCONTROLSQUERY = 58,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWPAGEACTIONMENU"]/*' />
    OLECMDID_SHOWPAGEACTIONMENU = 59,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ADDTRAVELENTRY"]/*' />
    OLECMDID_ADDTRAVELENTRY = 60,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UPDATETRAVELENTRY"]/*' />
    OLECMDID_UPDATETRAVELENTRY = 61,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UPDATEBACKFORWARDSTATE"]/*' />
    OLECMDID_UPDATEBACKFORWARDSTATE = 62,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_OPTICAL_ZOOM"]/*' />
    OLECMDID_OPTICAL_ZOOM = 63,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_OPTICAL_GETZOOMRANGE"]/*' />
    OLECMDID_OPTICAL_GETZOOMRANGE = 64,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_WINDOWSTATECHANGED"]/*' />
    OLECMDID_WINDOWSTATECHANGED = 65,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ACTIVEXINSTALLSCOPE"]/*' />
    OLECMDID_ACTIVEXINSTALLSCOPE = 66,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UPDATETRAVELENTRY_DATARECOVERY"]/*' />
    OLECMDID_UPDATETRAVELENTRY_DATARECOVERY = 67,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWTASKDLG"]/*' />
    OLECMDID_SHOWTASKDLG = 68,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_POPSTATEEVENT"]/*' />
    OLECMDID_POPSTATEEVENT = 69,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_VIEWPORT_MODE"]/*' />
    OLECMDID_VIEWPORT_MODE = 70,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_LAYOUT_VIEWPORT_WIDTH"]/*' />
    OLECMDID_LAYOUT_VIEWPORT_WIDTH = 71,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_VISUAL_VIEWPORT_EXCLUDE_BOTTOM"]/*' />
    OLECMDID_VISUAL_VIEWPORT_EXCLUDE_BOTTOM = 72,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_USER_OPTICAL_ZOOM"]/*' />
    OLECMDID_USER_OPTICAL_ZOOM = 73,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_PAGEAVAILABLE"]/*' />
    OLECMDID_PAGEAVAILABLE = 74,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_GETUSERSCALABLE"]/*' />
    OLECMDID_GETUSERSCALABLE = 75,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_UPDATE_CARET"]/*' />
    OLECMDID_UPDATE_CARET = 76,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ENABLE_VISIBILITY"]/*' />
    OLECMDID_ENABLE_VISIBILITY = 77,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_MEDIA_PLAYBACK"]/*' />
    OLECMDID_MEDIA_PLAYBACK = 78,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SETFAVICON"]/*' />
    OLECMDID_SETFAVICON = 79,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SET_HOST_FULLSCREENMODE"]/*' />
    OLECMDID_SET_HOST_FULLSCREENMODE = 80,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_EXITFULLSCREEN"]/*' />
    OLECMDID_EXITFULLSCREEN = 81,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SCROLLCOMPLETE"]/*' />
    OLECMDID_SCROLLCOMPLETE = 82,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_ONBEFOREUNLOAD"]/*' />
    OLECMDID_ONBEFOREUNLOAD = 83,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWMESSAGE_BLOCKABLE"]/*' />
    OLECMDID_SHOWMESSAGE_BLOCKABLE = 84,

    /// <include file='OLECMDID.xml' path='doc/member[@name="OLECMDID.OLECMDID_SHOWTASKDLG_BLOCKABLE"]/*' />
    OLECMDID_SHOWTASKDLG_BLOCKABLE = 85,
}
