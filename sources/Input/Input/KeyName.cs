namespace Silk.NET.Input;

/// <summary>
/// Enumerates names for physical key positions as defined by the
/// <see href="https://www.usb.org/sites/default/files/documents/hut1_12v2.pdf">USB HID Usage Tables</see> published by
/// the USB-IF. Note that these denote an en-US-centric definition of the keys that reside at each physical position,
/// and does not take account of keyboard layout. That is, <see cref="Q"/> represents the <c>Q</c> key on a QWERTY
/// keyboard but represents the <c>"</c> key on a Dvorak keyboard. Use <see cref="IKeyboard.TryGetKeyName"/> to
/// determine the localised name of a physical key position name (<see cref="KeyName"/>) when taking account of the
/// user's selected keyboard layout.
/// </summary>
public enum KeyName
{
    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES

    // These values are from usage page 0x07 (USB keyboard page).
    /// <summary>
    /// A key that was not recognised.
    /// </summary>
    Unknown = 0,

    /// <summary>The "A" key.</summary>
    A = 4,

    /// <summary>The "B" key.</summary>
    B = 5,

    /// <summary>The "C" key.</summary>
    C = 6,

    /// <summary>The "D" key.</summary>
    D = 7,

    /// <summary>The "E" key.</summary>
    E = 8,

    /// <summary>The "F" key.</summary>
    F = 9,

    /// <summary>The "G" key.</summary>
    G = 10,

    /// <summary>The "H" key.</summary>
    H = 11,

    /// <summary>The "I" key.</summary>
    I = 12,

    /// <summary>The "J" key.</summary>
    J = 13,

    /// <summary>The "K" key.</summary>
    K = 14,

    /// <summary>The "L" key.</summary>
    L = 15,

    /// <summary>The "M" key.</summary>
    M = 16,

    /// <summary>The "N" key.</summary>
    N = 17,

    /// <summary>The "O" key.</summary>
    O = 18,

    /// <summary>The "P" key.</summary>
    P = 19,

    /// <summary>The "Q" key.</summary>
    Q = 20,

    /// <summary>The "R" key.</summary>
    R = 21,

    /// <summary>The "S" key.</summary>
    S = 22,

    /// <summary>The "T" key.</summary>
    T = 23,

    /// <summary>The "U" key.</summary>
    U = 24,

    /// <summary>The "V" key.</summary>
    V = 25,

    /// <summary>The "W" key.</summary>
    W = 26,

    /// <summary>The "X" key.</summary>
    X = 27,

    /// <summary>The "Y" key.</summary>
    Y = 28,

    /// <summary>The "Z" key.</summary>
    Z = 29,

    /// <summary>The "1" key.</summary>
    Number1 = 30,

    /// <summary>The "2" key.</summary>
    Number2 = 31,

    /// <summary>The "3" key.</summary>
    Number3 = 32,

    /// <summary>The "4" key.</summary>
    Number4 = 33,

    /// <summary>The "5" key.</summary>
    Number5 = 34,

    /// <summary>The "6" key.</summary>
    Number6 = 35,

    /// <summary>The "7" key.</summary>
    Number7 = 36,

    /// <summary>The "8" key.</summary>
    Number8 = 37,

    /// <summary>The "9" key.</summary>
    Number9 = 38,

    /// <summary>The "0" key.</summary>
    Number0 = 39,

    /// <summary>The "return" key.</summary>
    Return = 40,

    /// <summary>The "escape" key.</summary>
    Escape = 41,

    /// <summary>The "backspace" key.</summary>
    Backspace = 42,

    /// <summary>The "tab" key.</summary>
    Tab = 43,

    /// <summary>The "space" key.</summary>
    Space = 44,

    /// <summary>The "minus" key.</summary>
    Minus = 45,

    /// <summary>The "equals" key.</summary>
    Equals = 46,

    /// <summary>The "left bracket" key.</summary>
    LeftBracket = 47,

    /// <summary>The "right bracket" key.</summary>
    RightBracket = 48,

    /// <summary>The "backslash" key.</summary>
    Backslash = 49,

    /// <summary>
    /// A key with region-specific meanings.
    /// </summary>
    /// <remarks>
    /// <list type="bullet">
    /// <item><term>American</term><description> \|</description></item>
    /// <item><term>Belgium</term><description> µ`£</description></item>
    /// <item><term>Canadian-French</term><description> &lt;}&gt;</description></item>
    /// <item><term>Danish</term><description>’*</description></item>
    /// <item><term>Dutch</term><description> &lt;&gt;</description></item>
    /// <item><term>French</term><description>*µ</description></item>
    /// <item><term>German</term><description> #’</description></item>
    /// <item><term>Italian</term><description> ù§</description></item>
    /// <item><term>Latin-American</term><description> }`]</description></item>
    /// <item><term>Norwegian</term><description>,*</description></item>
    /// <item><term>Spanish</term><description> }Ç</description></item>
    /// <item><term>Swedish</term><description> , *</description></item>
    /// <item><term>Swiss</term><description> $£</description></item>
    /// <item><term>British</term><description> #~.</description></item>
    /// </list>
    /// </remarks>
    NonUs1 = 50,

    /// <summary>The "semicolon" key.</summary>
    Semicolon = 51,

    /// <summary>The "apostrophe" key.</summary>
    Apostrophe = 52,

    /// <summary>The "grave" key.</summary>
    Grave = 53,

    /// <summary>The "comma" key.</summary>
    Comma = 54,

    /// <summary>The "period" key.</summary>
    Period = 55,

    /// <summary>The "slash" key.</summary>
    Slash = 56,

    /// <summary>The "caps lock" key.</summary>
    CapsLock = 57,

    /// <summary>The first function key.</summary>
    F1 = 58,

    /// <summary>The second function key.</summary>
    F2 = 59,

    /// <summary>The third function key.</summary>
    F3 = 60,

    /// <summary>The fourth function key.</summary>
    F4 = 61,

    /// <summary>The fifth function key.</summary>
    F5 = 62,

    /// <summary>The sixth function key.</summary>
    F6 = 63,

    /// <summary>The seventh function key.</summary>
    F7 = 64,

    /// <summary>The eighth function key.</summary>
    F8 = 65,

    /// <summary>The ninth function key.</summary>
    F9 = 66,

    /// <summary>The tenth function key.</summary>
    F10 = 67,

    /// <summary>The eleventh function key.</summary>
    F11 = 68,

    /// <summary>The twelfth function key.</summary>
    F12 = 69,

    /// <summary>The "print screen" key.</summary>
    PrintScreen = 70,

    /// <summary>The "scroll lock" key.</summary>
    ScrollLock = 71,

    /// <summary>The "pause" key.</summary>
    Pause = 72,

    /// <summary>The "insert" key.</summary>
    Insert = 73,

    /// <summary>The "home" key.</summary>
    Home = 74,

    /// <summary>The "page up" key.</summary>
    PageUp = 75,

    /// <summary>The "delete" key.</summary>
    Delete = 76,

    /// <summary>The "end" key.</summary>
    End = 77,

    /// <summary>The "page down" key.</summary>
    PageDown = 78,

    /// <summary>The "right" key.</summary>
    Right = 79,

    /// <summary>The "left" key.</summary>
    Left = 80,

    /// <summary>The "down" key.</summary>
    Down = 81,

    /// <summary>The "up" key.</summary>
    Up = 82,

    /// <summary>The "num lock clear" key.</summary>
    NumLockClear = 83,

    /// <summary>The "divide" key on the keypad.</summary>
    KeypadDivide = 84,

    /// <summary>The "multiply" key on the keypad.</summary>
    KeypadMultiply = 85,

    /// <summary>The "minus" key on the keypad.</summary>
    KeypadMinus = 86,

    /// <summary>The "plus" key on the keypad.</summary>
    KeypadPlus = 87,

    /// <summary>The "enter" key on the keypad.</summary>
    KeypadEnter = 88,

    /// <summary>The "1" key on the keypad.</summary>
    Keypad1 = 89,

    /// <summary>The "2" key on the keypad.</summary>
    Keypad2 = 90,

    /// <summary>The "3" key on the keypad.</summary>
    Keypad3 = 91,

    /// <summary>The "4" key on the keypad.</summary>
    Keypad4 = 92,

    /// <summary>The "5" key on the keypad.</summary>
    Keypad5 = 93,

    /// <summary>The "6" key on the keypad.</summary>
    Keypad6 = 94,

    /// <summary>The "7" key on the keypad.</summary>
    Keypad7 = 95,

    /// <summary>The "8" key on the keypad.</summary>
    Keypad8 = 96,

    /// <summary>The "9" key on the keypad.</summary>
    Keypad9 = 97,

    /// <summary>The "0" key on the keypad.</summary>
    Keypad0 = 98,

    /// <summary>The "period" key on the keypad.</summary>
    KeypadPeriod = 99,

    /// <summary>
    /// A key with region-specific meanings, typically near the Left-Shift key in AT-102 implementations.
    /// </summary>
    /// <remarks>
    /// <item><term>Belg</term><description>&lt;\&gt;</description></item>
    /// <item><term>FrCa</term><description>«°»</description></item>
    /// <item><term>Dan</term><description>&lt;\&gt;</description></item>
    /// <item><term>Dutch</term><description>]|[</description></item>
    /// <item><term>Fren</term><description>&lt;&gt;</description></item>
    /// <item><term>Ger</term><description>&lt;|&gt;</description></item>
    /// <item><term>Ital</term><description>&lt;&gt;</description></item>
    /// <item><term>LatAm</term><description>&lt;&gt;</description></item>
    /// <item><term>Nor</term><description>&lt;&gt;</description></item>
    /// <item><term>Span</term><description>&lt;&gt;</description></item>
    /// <item><term>Swed</term><description>&lt;|&gt;</description></item>
    /// <item><term>Swiss</term><description>&lt;\&gt;</description></item>
    /// <item><term>UK</term><description>\|</description></item>
    /// <item><term>Brazil</term><description>\|</description></item>
    /// </remarks>
    NonUs2 = 100,

    /// <summary>A key for application-defined functions.</summary>
    Application = 101,

    /// <summary>The "power" key.</summary>
    Power = 102,

    /// <summary>The "equals" key on the keypad.</summary>
    KeypadEquals = 103,

    /// <summary>The thirteenth function key.</summary>
    F13 = 104,

    /// <summary>The fourteenth function key.</summary>
    F14 = 105,

    /// <summary>The fifteenth function key.</summary>
    F15 = 106,

    /// <summary>The sixteenth function key.</summary>
    F16 = 107,

    /// <summary>The seventeenth function key.</summary>
    F17 = 108,

    /// <summary>The eighteenth function key.</summary>
    F18 = 109,

    /// <summary>The nineteenth function key.</summary>
    F19 = 110,

    /// <summary>The twentieth function key.</summary>
    F20 = 111,

    /// <summary>The twenty-first function key.</summary>
    F21 = 112,

    /// <summary>The twenty-second function key.</summary>
    F22 = 113,

    /// <summary>The twenty-third function key.</summary>
    F23 = 114,

    /// <summary>The twenty-fourth function key.</summary>
    F24 = 115,

    /// <summary>The "execute" key.</summary>
    Execute = 116,

    /// <summary>The "help" key.</summary>
    Help = 117,

    /// <summary>The "menu" key.</summary>
    Menu = 118,

    /// <summary>The "select" key.</summary>
    Select = 119,

    /// <summary>The "stop" key.</summary>
    Stop = 120,

    /// <summary>The "again" key.</summary>
    Again = 121,

    /// <summary>The "undo" key.</summary>
    Undo = 122,

    /// <summary>The "cut" key.</summary>
    Cut = 123,

    /// <summary>The "copy" key.</summary>
    Copy = 124,

    /// <summary>The "paste" key.</summary>
    Paste = 125,

    /// <summary>The "find" key.</summary>
    Find = 126,

    /// <summary>The "mute" key.</summary>
    Mute = 127,

    /// <summary>The "volume up" key.</summary>
    VolumeUp = 128,

    /// <summary>The "volume down" key.</summary>
    VolumeDown = 129,

    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES

    /// <summary>The "comma" key on the keypad.</summary>
    KeypadComma = 133,

    /// <summary>The alternative "equals" key on the keypad as typically found on AS-400 keyboards.</summary>
    OtherKeypadEquals = 134,

    /// <summary>The first international key.</summary>
    International1 = 135,

    /// <summary>The second international key.</summary>
    International2 = 136,

    /// <summary>The third international key.</summary>
    International3 = 137,

    /// <summary>The fourth international key.</summary>
    International4 = 138,

    /// <summary>The fifth international key.</summary>
    International5 = 139,

    /// <summary>The sixth international key.</summary>
    International6 = 140,

    /// <summary>The seventh international key.</summary>
    International7 = 141,

    /// <summary>The eighth international key.</summary>
    International8 = 142,

    /// <summary>The ninth international key.</summary>
    International9 = 143,

    /// <summary>The first language key.</summary>
    Lang1 = 144,

    /// <summary>The second language key.</summary>
    Lang2 = 145,

    /// <summary>The third language key.</summary>
    Lang3 = 146,

    /// <summary>The fourth language key.</summary>
    Lang4 = 147,

    /// <summary>The fifth language key.</summary>
    Lang5 = 148,

    /// <summary>The sixth language key.</summary>
    Lang6 = 149,

    /// <summary>The seventh language key.</summary>
    Lang7 = 150,

    /// <summary>The eighth language key.</summary>
    Lang8 = 151,

    /// <summary>The ninth language key.</summary>
    Lang9 = 152,

    /// <summary>The alternative "erase" key, for example an Erase-Eaze™ key.</summary>
    AlternativeErase = 153,

    /// <summary>The "system request" key.</summary>
    SystemRequest = 154,

    /// <summary>The "cancel" key.</summary>
    Cancel = 155,

    /// <summary>The "clear" key.</summary>
    Clear = 156,

    /// <summary>The "prior" key.</summary>
    Prior = 157,

    /// <summary>An alternative "return" key.</summary>
    Return2 = 158,

    /// <summary>The "separator" key.</summary>
    Separator = 159,

    /// <summary>The "out" key.</summary>
    Out = 160,

    /// <summary>The "operation" key.</summary>
    Oper = 161,

    /// <summary>The "clear again" key.</summary>
    ClearAgain = 162,

    /// <summary>The "cursor select" key.</summary>
    /// <remarks>
    /// For more information consult IBM's "3174 Establishment Controller - Terminal User's Reference for Expanded
    /// Functions" (GA23-03320-02, May 1989)
    /// </remarks>
    CursorSelect = 163,

    /// <summary>The "extend select" key.</summary>
    /// <remarks>
    /// For more information consult IBM's "3174 Establishment Controller - Terminal User's Reference for Expanded
    /// Functions" (GA23-03320-02, May 1989)
    /// </remarks>
    ExtendSelect = 164,

    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES

    /// <summary>The "00" key on the keypad.</summary>
    Keypad00 = 176,

    /// <summary>The "000" key on the keypad.</summary>
    Keypad000 = 177,

    /// <summary>The "thousands separator" key.</summary>
    /// <remarks>Interpreted as a comma for en-US.</remarks>
    ThousandsSeparator = 178,

    /// <summary>The "decimal separator" key.</summary>
    /// <remarks>Interpreted as a period for en-US.</remarks>
    DecimalSeparator = 179,

    /// <summary>The "currency unit" key.</summary>
    /// <remarks>Interpreted as a dollar sign for en-US.</remarks>
    CurrencyUnit = 180,

    /// <summary>The "currencySubunit" key.</summary>
    /// <remarks>Interpreted as a cents symbol for en-US.</remarks>
    CurrencySubunit = 181,

    /// <summary>The "leftParenthesis" key on the keypad.</summary>
    KeypadLeftParenthesis = 182,

    /// <summary>The "rightParenthesis" key on the keypad.</summary>
    KeypadRightParenthesis = 183,

    /// <summary>The "leftBrace" key on the keypad.</summary>
    KeypadLeftBrace = 184,

    /// <summary>The "rightBrace" key on the keypad.</summary>
    KeypadRightBrace = 185,

    /// <summary>The "tab" key on the keypad.</summary>
    KeypadTab = 186,

    /// <summary>The "backspace" key on the keypad.</summary>
    KeypadBackspace = 187,

    /// <summary>The "a" key on the keypad.</summary>
    KeypadA = 188,

    /// <summary>The "b" key on the keypad.</summary>
    KeypadB = 189,

    /// <summary>The "c" key on the keypad.</summary>
    KeypadC = 190,

    /// <summary>The "d" key on the keypad.</summary>
    KeypadD = 191,

    /// <summary>The "e" key on the keypad.</summary>
    KeypadE = 192,

    /// <summary>The "f" key on the keypad.</summary>
    KeypadF = 193,

    /// <summary>The "xor" key on the keypad.</summary>
    KeypadXor = 194,

    /// <summary>The "power" key on the keypad.</summary>
    KeypadPower = 195,

    /// <summary>The "percent" key on the keypad.</summary>
    KeypadPercent = 196,

    /// <summary>The "less" key on the keypad.</summary>
    KeypadLess = 197,

    /// <summary>The "greater" key on the keypad.</summary>
    KeypadGreater = 198,

    /// <summary>The "ampersand" key on the keypad.</summary>
    KeypadAmpersand = 199,

    /// <summary>The "doubleAmpersand" key on the keypad.</summary>
    KeypadDoubleAmpersand = 200,

    /// <summary>The "vertical bar" key on the keypad.</summary>
    KeypadVerticalBar = 201,

    /// <summary>The "double vertical bar" key on the keypad.</summary>
    KeypadDoubleVerticalBar = 202,

    /// <summary>The "colon" key on the keypad.</summary>
    KeypadColon = 203,

    /// <summary>The "hash" key on the keypad.</summary>
    KeypadHash = 204,

    /// <summary>The "space" key on the keypad.</summary>
    KeypadSpace = 205,

    /// <summary>The "@" key on the keypad.</summary>
    KeypadAt = 206,

    /// <summary>The "exclamation" key on the keypad.</summary>
    KeypadExclamation = 207,

    /// <summary>The "memory store" key on the keypad.</summary>
    KeypadMemoryStore = 208,

    /// <summary>The "memory recall" key on the keypad.</summary>
    KeypadMemoryRecall = 209,

    /// <summary>The "memory clear" key on the keypad.</summary>
    KeypadMemoryClear = 210,

    /// <summary>The "memory add" key on the keypad.</summary>
    KeypadMemoryAdd = 211,

    /// <summary>The "memory subtract" key on the keypad.</summary>
    KeypadMemorySubtract = 212,

    /// <summary>The "memory multiply" key on the keypad.</summary>
    KeypadMemoryMultiply = 213,

    /// <summary>The "memory divide" key on the keypad.</summary>
    KeypadMemoryDivide = 214,

    /// <summary>The "plus/minus" key on the keypad.</summary>
    KeypadPlusMinus = 215,

    /// <summary>The "clear" key on the keypad.</summary>
    KeypadClear = 216,

    /// <summary>The "clear entry" key on the keypad.</summary>
    KeypadClearEntry = 217,

    /// <summary>The "binary" key on the keypad.</summary>
    KeypadBinary = 218,

    /// <summary>The "octal" key on the keypad.</summary>
    KeypadOctal = 219,

    /// <summary>The "decimal" key on the keypad.</summary>
    KeypadDecimal = 220,

    /// <summary>The "hexadecimal" key on the keypad.</summary>
    KeypadHexadecimal = 221,

    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES

    /// <summary>The left "control" key.</summary>
    ControlLeft = 224,

    /// <summary>The left "shift" key.</summary>
    ShiftLeft = 225,

    /// <summary>The left "alt" key.</summary>
    AltLeft = 226,

    /// <summary>The left "super" (e.g. Windows/Start) key.</summary>
    SuperLeft = 227,

    /// <summary>The right "control" key.</summary>
    ControlRight = 228,

    /// <summary>The right "shift" key.</summary>
    ShiftRight = 229,

    /// <summary>The right "alt" key.</summary>
    AltRight = 230,

    /// <summary>The right "super" (e.g. Windows/Start) key.</summary>
    SuperRight = 231,

    // 232-256..... wtf?
    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES

    /// <summary>The "mode" key.</summary>
    Mode = 257,

    // These values are mapped from usage page 0x0C (USB consumer page).
    /// <summary>The "sleep" key.</summary>
    Sleep = 258,

    /// <summary>The "wake" key.</summary>
    Wake = 259,

    /// <summary>The "channel increment" key.</summary>
    ChannelIncrement = 260,

    /// <summary>The "channel decrement" key.</summary>
    ChannelDecrement = 261,

    /// <summary>The "play" media key.</summary>
    MediaPlay = 262,

    /// <summary>The "pause" media key.</summary>
    MediaPause = 263,

    /// <summary>The "record" media key.</summary>
    MediaRecord = 264,

    /// <summary>The "fast forward" media key.</summary>
    MediaFastForward = 265,

    /// <summary>The "rewind" media key.</summary>
    MediaRewind = 266,

    /// <summary>The "next track" media key.</summary>
    MediaNextTrack = 267,

    /// <summary>The "previous track" media key.</summary>
    MediaPreviousTrack = 268,

    /// <summary>The "stop" media key.</summary>
    MediaStop = 269,

    /// <summary>The "eject" media key.</summary>
    MediaEject = 270,

    /// <summary>The "play/pause" media key.</summary>
    MediaPlayPause = 271,

    /// <summary>The "select" media key.</summary>
    MediaSelect = 272,

    /// <summary>The "new" application key.</summary>
    ApplicationNew = 273,

    /// <summary>The "open" application key.</summary>
    ApplicationOpen = 274,

    /// <summary>The "close" application key.</summary>
    ApplicationClose = 275,

    /// <summary>The "exit" application key.</summary>
    ApplicationExit = 276,

    /// <summary>The "save" application key.</summary>
    ApplicationSave = 277,

    /// <summary>The "print" application key.</summary>
    ApplicationPrint = 278,

    /// <summary>The "properties" application key.</summary>
    ApplicationProperties = 279,

    /// <summary>The "search" application key.</summary>
    ApplicationSearch = 280,

    /// <summary>The "home" application key.</summary>
    ApplicationHome = 281,

    /// <summary>The "back" application key.</summary>
    ApplicationBack = 282,

    /// <summary>The "forward" application key.</summary>
    ApplicationForward = 283,

    /// <summary>The "stop" application key.</summary>
    ApplicationStop = 284,

    /// <summary>The "refresh" application key.</summary>
    ApplicationRefresh = 285,

    /// <summary>The "bookmarks" application key.</summary>
    ApplicationBookmarks = 286,

    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES

    // 501-512 is reserved for non-standard (i.e. not from an industry-standard HID page) keys.
    /// <summary>The left soft key e.g. the left button on a mobile phone.</summary>
    /// <remarks>This is not from an industry-standard HID page.</remarks>
    SoftLeft = 501,

    /// <summary>The right soft key e.g. the right button on a mobile phone.</summary>
    /// <remarks>This is not from an industry-standard HID page.</remarks>
    SoftRight = 502,

    /// <summary>The "call" key.</summary>
    /// <remarks>This is not from an industry-standard HID page.</remarks>
    Call = 503,

    /// <summary>The "end call" key.</summary>
    /// <remarks>This is not from an industry-standard HID page.</remarks>
    EndCall = 504,

    // BEFORE ADDING ANYTHING TO THIS FILE MAKE SURE YOU REALISE THAT InputMarshal RELIES ON ASSUMPTIONS ON THE VALUES
}
