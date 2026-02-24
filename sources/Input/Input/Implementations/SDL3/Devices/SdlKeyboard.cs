// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Silk.NET.Input.KeyHandling;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal class SdlKeyboard : SdlDevice, IKeyboard, ISdlDevice<SdlKeyboard>
{
    public KeyboardState State { get; }
    public override string Name => NativeBackend.GetKeyboardNameForID((uint)SdlDeviceId).ReadToString();
    public string? ClipboardText
    {
        get => NativeBackend.HasClipboardText() ? NativeBackend.GetClipboardText().ReadToString() : null;
        set => NativeBackend.SetClipboardText(value);
    }

    private bool _hasUpdates;

    public static SdlKeyboard CreateDevice(ulong sdlDeviceId, SdlInputBackend backend)
    {
        var namePtr = backend.Sdl.GetKeyboardNameForID((uint)sdlDeviceId);
        nint uniqueId = 0;
        if (backend.AttemptUniqueId(namePtr, ref uniqueId))
        {
            return new SdlKeyboard(sdlDeviceId, uniqueId, backend);
        }

        uniqueId = SdlInputBackend.FallbackUniqueId(sdlDeviceId, uniqueId);
        return new SdlKeyboard(sdlDeviceId, uniqueId, backend);
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

    public override void Initialize()
    {

    }

    protected override void Release()
    {
    }

    public bool TryGetKeyName(KeyName key, [NotNullWhen(true)] out string? name)
    {
        // todo: should 'asKeyEvent' be true?
        var sdlKey = SdlKeyConversions.KeyNameToSdl(key, NativeBackend, true, _modState);
        var namePtr = NativeBackend.GetKeyName(sdlKey);
        name = namePtr.ReadToString();
        return !string.IsNullOrWhiteSpace(name);
    }


    // todo - there should be a backend-independent way to do this text input handling via KeyboardState?
    public void BeginInput()
    {
        var sdlWindow = Backend.FocusedWindow;
        if (sdlWindow != null && NativeBackend.StartTextInput(sdlWindow.Value))
        {
            BeginRecordingSdl(sdlWindow.Value);
        }
        else
        {
            _textIsRecording = TextRecorderState.RecordingNoSdl;
        }
    }

    private void BeginRecordingSdl(WindowHandle sdlWindow)
    {
        _textIsRecording = TextRecorderState.RecordingSdl;
        _textEntryWindow = sdlWindow;
    }

    public string? EndInput()
    {
        switch (_textIsRecording)
        {
            case TextRecorderState.None:
                return null;
            case TextRecorderState.RecordingNoSdl:
                _textIsRecording = TextRecorderState.None;
                break;
            case TextRecorderState.RecordingSdl:
                _textIsRecording = TextRecorderState.None;
                var sdlWindow = _textEntryWindow;
                if (sdlWindow != null)
                {
                    NativeBackend.StopTextInput(sdlWindow.Value);
                }
                break;
        }
        _textIsRecording = TextRecorderState.None;
        return _textRecorder?.ConsumeInput();
    }

    public override void FinalizeUpdate(SdlInputBackend.SilkEventQueues queues)
    {
        if (_hasUpdates)
        {
            // This should be called every frame the keyboard is updated in <see cref="SdlInputBackend"/>.
            // This mod state is purely used for sdl-related calls and modifiers that are independent of key state (e.g. numlock, caps lock)
            // - otherwise, we handle the modifier states with our standard key handling logic
            _modState = NativeBackend.GetModState();
        }

        while (_keyChangedEvents.TryDequeue(out var evt))
        {
            queues.KeyChangedEvents.Enqueue(evt);
        }

        while (_keyCharEvents.TryDequeue(out var evt))
        {
            queues.KeyCharEvents.Enqueue(evt);
        }
    }

    public void AddKeyEvent(in KeyboardEvent key)
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

            var shouldRecord = _textIsRecording == TextRecorderState.RecordingNoSdl && ((stateChanged && isDown) ||
                                                                                        (!stateChanged && isRepeat));
            if (shouldRecord)
            {
                _textRecorder ??= new TextRecorder(null);
                if(_textRecorder.AddKeyStroke(keyName, this, out var newChar))
                {
                    _keyCharEvents.Enqueue(new KeyCharEvent(this, Stopwatch.GetTimestamp(), newChar.Value));
                }
            }
            else
            {
                _keyChangedEvents.Enqueue(new KeyChangedEvent(
                    Keyboard: this,
                    Timestamp: Stopwatch.GetTimestamp(),
                    Key: _keyStates[keyName],
                    Previous: button,
                    Modifiers: State.Modifiers,
                    IsRepeat: isRepeat));
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
                Console.Out.WriteLine("Unexpected text editing event");
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
                Console.Out.WriteLine("Unexpected text input event");
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
    private TextRecorderState _textIsRecording;
    private ushort _modState;
    private const float _pressureMultiplier = 1f / 255f;
    private readonly ButtonStates _keyStates;
    private readonly Queue<KeyChangedEvent> _keyChangedEvents = new();
    private readonly Queue<KeyCharEvent> _keyCharEvents = new();

    private class ButtonStates : IReadOnlyList<Button<KeyName>>
    {
        private static readonly int _keyCount;
        private readonly byte[] _keyPressures = new byte[_keyCount];
        private static readonly int[] _indices;

        static ButtonStates()
        {
            _indices = new int[512];
            for (var i = 0; i < 512; i++)
            {
                _indices[i] = Enum.IsDefined((KeyName)i) ? _keyCount++ : -1;
            }
        }

        public int SetKeyState(KeyName key, byte pressure) => _keyPressures[_indices[(int)key]] = pressure;

        public IEnumerator<Button<KeyName>> GetEnumerator()
        {
            for (var i = 0; i < _keyCount; i++)
            {
                var index = _indices[i];
                if(index != -1)
                {
                    yield return GetButton(index);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => _keyCount;

        public Button<KeyName> this[int index] => GetButton(index);
        public Button<KeyName> this[KeyName key] => GetButton((int)key);

        private Button<KeyName> GetButton(KeyName key) => GetButton((int)key);
        private Button<KeyName> GetButton(int key)
        {
            var keyIdx = _indices[key];
            return CreateButton((KeyName)key, _keyPressures[keyIdx]);
        }

        private Button<KeyName> CreateButton(KeyName key, byte pressure) => new(key, pressure > 0, pressure * _pressureMultiplier);

        public static bool IsDefined(KeyName keyName) => _indices[(int)keyName] >= 0;
    }
}
