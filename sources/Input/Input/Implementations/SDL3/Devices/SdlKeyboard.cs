// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.KeyHandling;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlKeyboard : SdlDevice, IKeyboard, ISdlDevice<SdlKeyboard>, INeedFinalizationEachFrame
{
    public KeyboardState State { get; }
    public override string Name => NativeBackend.GetKeyboardNameForID((uint)SdlDeviceId).ReadToString();
    public string? ClipboardText
    {
        get => NativeBackend.HasClipboardText() ? NativeBackend.GetClipboardText().ReadToString() : null;
        set => NativeBackend.SetClipboardText(value);
    }

    private bool _hasUpdates;

    public static SdlKeyboard CreateDevice(ulong sdlDeviceId, long timestamp, ulong sdlTimestamp, SdlInputBackend backend, SilkEventContext silkEvents)
    {
        var namePtr = backend.Sdl.GetKeyboardNameForID((uint)sdlDeviceId);

        var uniqueId = (nint)sdlDeviceId;
        if (namePtr == nullptr)
        {
            InputLog.Warn($"Failed to get keyboard name for device {sdlDeviceId}.");
        }
        else
        {
            if (backend.AttemptUniqueId(namePtr, ref uniqueId))
            {
                return new SdlKeyboard(sdlDeviceId, uniqueId, backend) {
                    KeyChangedEvents = silkEvents.KeyChangedSdlEvents, KeyCharEvents = silkEvents.KeyCharSdlEvents
                };
            }
        }

        uniqueId = SdlInputBackend.FallbackUniqueId<SdlKeyboard>(sdlDeviceId, uniqueId);
        return new SdlKeyboard(sdlDeviceId, uniqueId, backend) {
            KeyChangedEvents = silkEvents.KeyChangedSdlEvents, KeyCharEvents = silkEvents.KeyCharSdlEvents
        };
    }

    private SdlKeyboard(ulong sdlDeviceId, nint uniqueId, SdlInputBackend backend) : base(backend, uniqueId, sdlDeviceId)
    {
        _modState = NativeBackend.GetModState();
        _keyStates = new ButtonStates();

        State = new KeyboardState(
            keys: _keyStates,
            capsLockActive: () => (_modState & Sdl.KmodCaps) == Sdl.KmodCaps,
            numLockActive: () => (_modState & Sdl.KmodNum) == Sdl.KmodNum);
    }

    protected internal override void Initialize(long timestamp, ulong sdlTimestamp)
    {

    }

    protected override void Release()
    {
    }

    public bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name)
    {
        var sdlKey = SdlKeyConversions.KeyNameToSdl(key, NativeBackend, true, _modState);
        var namePtr = NativeBackend.GetKeyName(sdlKey);
        name = namePtr.ReadToString();
        return !string.IsNullOrWhiteSpace(name);
    }

    // todo (LOW PRIO) - there should be a backend-independent way to do this text input
    //  handling via KeyboardState events? see TextRecorder class
    public void BeginInput()
    {
        var sdlWindow = Backend.FocusedWindow;
        if (sdlWindow != null && NativeBackend.StartTextInput(sdlWindow.Value))
        {
            BeginRecordingSdl(sdlWindow.Value);
        }
        else
        {
            _textRecordState = TextRecorderState.RecordingNoSdl;
        }

        InputLog.Debug($"BeginInput {_textRecordState.ToString()}");
    }

    private void BeginRecordingSdl(WindowHandle sdlWindow)
    {
        _textRecordState = TextRecorderState.RecordingSdl;
        _textEntryWindow = sdlWindow;
    }

    public string? EndInput()
    {
        InputLog.Debug($"EndInput {_textRecordState.ToString()}");
        switch (_textRecordState)
        {
            case TextRecorderState.None:
                return null;
            case TextRecorderState.RecordingNoSdl:
                _textRecordState = TextRecorderState.None;
                break;
            case TextRecorderState.RecordingSdl:
                _textRecordState = TextRecorderState.None;
                var sdlWindow = _textEntryWindow;
                if (sdlWindow != null)
                {
                    NativeBackend.StopTextInput(sdlWindow.Value);
                }
                break;
        }
        _textRecordState = TextRecorderState.None;
        return _textRecorder?.ConsumeInput();
    }

    public void FinalizeUpdate()
    {
        if (_hasUpdates)
        {
            // This should be called every frame the keyboard is updated in <see cref="SdlInputBackend"/>.
            // This mod state is purely used for sdl-related calls and modifiers that are independent of key state (e.g. numlock, caps lock)
            // - otherwise, we handle the modifier states with our standard key handling logic
            _modState = NativeBackend.GetModState();
        }
    }

    public void AddKeyEvent(in KeyboardEvent key, long timestamp)
    {
        _hasUpdates = true;
        var keyName = SdlKeyConversions.ScancodeToKeyName(key.Scancode); // SdlToKeyName(key.Which);

        if (ButtonStates.IsDefined(keyName))
        {
            var isDown = key.Down != 0;
            var button = _keyStates[keyName];
            var stateChanged = button.IsDown != isDown;
            var isRepeat = key.Repeat != 0;
            _keyStates.SetKeyState(keyName, key.Down);

            var shouldRecord = _textRecordState != TextRecorderState.None &&
                               ((stateChanged && isDown) || (!stateChanged && isRepeat));
            if (shouldRecord)
            {
                _textRecorder ??= new TextRecorder(null);
                if(_textRecorder.AddKeyStroke(keyName, this, out var newChar))
                {
                    KeyCharEvents.Enqueue(new KeyCharEvent(this, timestamp, newChar.Value), key.Timestamp);
                }
                else
                {
                    KeyChangedEvents.Enqueue(new KeyChangedEvent(
                        Keyboard: this,
                        Timestamp: timestamp,
                        Key: _keyStates[keyName],
                        Previous: button,
                        Modifiers: State.Modifiers,
                        IsRepeat: isRepeat), key.Timestamp);
                }
            }
            else
            {
                KeyChangedEvents.Enqueue(new KeyChangedEvent(
                    Keyboard: this,
                    Timestamp: timestamp,
                    Key: _keyStates[keyName],
                    Previous: button,
                    Modifiers: State.Modifiers,
                    IsRepeat: isRepeat), key.Timestamp);
            }
        }
    }

    public unsafe void AddTextEditingEvent(in TextEditingEvent evt)
    {
        _hasUpdates = true;
        if (_textEntryWindow == null)
        {
            var windowHandle = NativeBackend.GetWindowFromID(evt.WindowID);
            if (windowHandle.Handle != null)
            {
                InputLog.Warn("Unexpected text editing event");
                BeginRecordingSdl(windowHandle);
            }
        }
        else if (evt.WindowID != NativeBackend.GetWindowID(_textEntryWindow.Value))
        {
            InputLog.Error("Received text editing event for a different window than the " +
                                    "one we're recording text for.");
        }

        _textRecorder ??= new TextRecorder(null);

        if (evt.Length == 0)
        {
            _textRecorder.SetSelection(evt.Start, 0);
        }
        else
        {
            if (evt.Text == null)
            {
                return;
            }

            _textRecorder.InsertTextAt(evt.Text, evt.Start, evt.Length);
        }
    }

    public unsafe void AddTextCandidatesEvent(in TextEditingCandidatesEvent evt)
    {
        _hasUpdates = true;
        if (evt.SelectedCandidate == -1 || evt.NumCandidates == 0)
        {
            return;
        }

        Debug.Assert(evt.NumCandidates > evt.SelectedCandidate);

        var candidate = new Ptr<sbyte>(evt.Candidates[evt.SelectedCandidate]);
        var str = candidate.ReadToString();
        _textRecorder ??= new TextRecorder(null);
        _textRecorder.InsertText(str);
    }

    public unsafe void AddTextInputEvent(in TextInputEvent evt)
    {
        _hasUpdates = true;
        if (_textEntryWindow == null)
        {
            var windowHandle = NativeBackend.GetWindowFromID(evt.WindowID);
            if (windowHandle.Handle != null)
            {
                InputLog.Warn("Unexpected text input event");
                BeginRecordingSdl(windowHandle);
            }
        }
        else if (evt.WindowID != NativeBackend.GetWindowID(_textEntryWindow.Value))
        {
            InputLog.Error("Received text input event for a different window than the " +
                                    "one we're recording text for.");
        }


        var str = evt.Text == null ? "" : new Ptr<sbyte>(evt.Text).ReadToString();

        _textRecorder ??= new TextRecorder(null);
        _textRecorder.InsertText(str);
    }


    private WindowHandle? _textEntryWindow;
    private TextRecorder? _textRecorder;
    private enum TextRecorderState {None, RecordingNoSdl, RecordingSdl}
    private TextRecorderState _textRecordState;
    private ushort _modState;
    private const float _pressureMultiplier = 1f / 255f;
    private readonly ButtonStates _keyStates;
    internal required ISdlEventQueue<KeyChangedEvent> KeyChangedEvents;
    internal required ISdlEventQueue<KeyCharEvent> KeyCharEvents;

    private class ButtonStates : IReadOnlyList<Button<KeyName>>
    {
        private byte[] _keyPressures = new byte[EnumInfo<KeyName>.MaxValue.Index() + 1];

        static ButtonStates()
        {

        }

        public void SetKeyState(KeyName key, byte pressure)
        {
            var idx = EnumInfo<KeyName>.ValueIndexOf(key);
            if (idx == -1)
                throw new InvalidOperationException("No key index found?? this is a bug");

            if (_keyPressures.Length <= idx)
            {
                Array.Resize(ref _keyPressures, idx + 1);
            }

            _keyPressures[idx] = pressure;
        }

        public IEnumerator<Button<KeyName>> GetEnumerator()
        {
            for (var i = 0; i < _keyPressures.Length; i++)
            {
                yield return GetButton(EnumInfo<KeyName>.ValueOfIndex(i), i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _keyPressures.Length;
        }

        public Button<KeyName> this[int index] => GetButton(EnumInfo<KeyName>.ValueOfIndex(index), index);

        public Button<KeyName> this[KeyName key] => GetButton(key, EnumInfo<KeyName>.ValueIndexOf(key));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Button<KeyName> GetButton(KeyName key, int index)
        {
            var pressureInt = index < _keyPressures.Length ? _keyPressures[index] : 0u;
            return new Button<KeyName>(key, pressureInt > 0, pressureInt * _pressureMultiplier);
        }

        public static bool IsDefined(KeyName keyName) => true;
    }
}
