// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='INPUT_RECORD.xml' path='doc/member[@name="INPUT_RECORD"]/*' />
public partial struct INPUT_RECORD
{
    /// <include file='INPUT_RECORD.xml' path='doc/member[@name="INPUT_RECORD.EventType"]/*' />
    [NativeTypeName("WORD")]
    public ushort EventType;

    /// <include file='INPUT_RECORD.xml' path='doc/member[@name="INPUT_RECORD.Event"]/*' />
    [NativeTypeName("__AnonymousRecord_wincontypes_L124_C5")]
    public _Event_e__Union Event;

    /// <include file='_Event_e__Union.xml' path='doc/member[@name="_Event_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Event_e__Union
    {
        /// <include file='_Event_e__Union.xml' path='doc/member[@name="_Event_e__Union.KeyEvent"]/*' />
        [FieldOffset(0)]
        public KEY_EVENT_RECORD KeyEvent;

        /// <include file='_Event_e__Union.xml' path='doc/member[@name="_Event_e__Union.MouseEvent"]/*' />
        [FieldOffset(0)]
        public MOUSE_EVENT_RECORD MouseEvent;

        /// <include file='_Event_e__Union.xml' path='doc/member[@name="_Event_e__Union.WindowBufferSizeEvent"]/*' />
        [FieldOffset(0)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        /// <include file='_Event_e__Union.xml' path='doc/member[@name="_Event_e__Union.MenuEvent"]/*' />
        [FieldOffset(0)]
        public MENU_EVENT_RECORD MenuEvent;

        /// <include file='_Event_e__Union.xml' path='doc/member[@name="_Event_e__Union.FocusEvent"]/*' />
        [FieldOffset(0)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }
}
