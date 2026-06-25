using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input;

/// <summary>
/// Contains user input received from an <see cref="IKeyboard"/>.
/// </summary>
public class KeyboardState
{
    /// <summary>
    /// Gets the text that has been typed since <see cref="IKeyboard.BeginInput"/> has been called. This will be cleared
    /// when <see cref="IKeyboard.EndInput"/> is called.
    /// </summary>
    public InputReadOnlyList<char>? Text { get; }

    /// <summary>
    /// Gets the key state, denoting which keys are pressed on the keyboard.
    /// </summary>
    public ButtonReadOnlyList<KeyName> Keys { get; }

    /// <summary>
    /// Gets the active modifier keys.
    /// </summary>
    public KeyModifiers Modifiers
    {
        get
        {
            var state = KeyModifiers.None;

            Debug.Assert(_modifierIndices.Length == _modifierValues.Length && _modifierValues.Length == _modifierCount);
            for (var i = 0; i < _modifierCount; ++i)
            {
                if(_rawKeys[_modifierIndices[i]].IsDown)
                {
                    state |= _modifierValues[i];
                }
            }

            if(_capsLockActive())
            {
                state |= KeyModifiers.CapsLock;
            }

            if(_numLockActive())
            {
                state |= KeyModifiers.NumLock;
            }

            return state;
        }
    }

    /// <summary>
    /// Constructor for the keyboard state - the provided button list should be continuously updated by the
    /// implementation
    /// </summary>
    /// <param name="keys">The collection of keys that are modified at runtime to give the current keyboard its state</param>
    /// <param name="capsLockActive">Return true if caps lock is currently active, irrespective of pressed status</param>
    /// <param name="numLockActive">Return true if num lock is currently active, irrespective of pressed status</param>
    public KeyboardState(IReadOnlyList<Button<KeyName>> keys, Func<bool> capsLockActive, Func<bool> numLockActive)
    {
        Keys = new ButtonReadOnlyList<KeyName>(keys);
        _rawKeys = keys;
        _capsLockActive = capsLockActive;
        _numLockActive = numLockActive;
    }

    private const int _modifierCount = 8;
    private static readonly int[] _modifierIndices = [
        KeyName.ControlLeft.Index(), KeyName.ControlRight.Index(), KeyName.AltLeft.Index(), KeyName.AltRight.Index(),
        KeyName.ShiftLeft.Index(), KeyName.ShiftRight.Index(), KeyName.SuperLeft.Index(), KeyName.SuperRight.Index()
    ];

    private static readonly KeyModifiers[] _modifierValues = [
        KeyModifiers.ControlLeft, KeyModifiers.ControlRight, KeyModifiers.AltLeft, KeyModifiers.AltRight,
        KeyModifiers.ShiftLeft, KeyModifiers.ShiftRight, KeyModifiers.SuperLeft, KeyModifiers.SuperRight
    ];

    private IReadOnlyList<Button<KeyName>> _rawKeys;
    private readonly Func<bool> _numLockActive;
    private readonly Func<bool> _capsLockActive;
}
