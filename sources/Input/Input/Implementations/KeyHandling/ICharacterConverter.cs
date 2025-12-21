// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Silk.NET.Input.KeyHandling;

/// <summary>
/// A simple interface for an implementation that converts keyboard input into characters for text entry
/// </summary>
internal interface ICharacterConverter
{
    public bool TryConvert(KeyName key, KeyModifiers modifiers, [NotNullWhen(true)] out char? c);
}

internal class DummyCharConverter : ICharacterConverter
{
    // todo - proper VK key support for various languages and layouts
    public bool TryConvert(KeyName key, KeyModifiers modifiers, [NotNullWhen(true)] out char? c)
    {
        if (!key.IsChar())
        {
            c = null;
            return false;
        }

        if (key is >= KeyName.A and <= KeyName.Z)
        {
            var diff = (int)key - (int)KeyName.A;
            c = (char)('a' + diff);
            if (modifiers.ShouldCapitalize())
            {
                c = CultureInfo.CurrentCulture.TextInfo.ToUpper(c.Value);
            }

            return true;
        }

        var isShifted = modifiers.IsShift();
        switch (key)
        {
            case KeyName.Number1:
                c = isShifted ? '!' : '1';
                return true;
            case KeyName.Keypad1:
                c = '1';
                return true;
            case KeyName.Number2:
                c = isShifted ? '@' : '2';
                return true;
            case KeyName.Keypad2:
                c = '2';
                return true;
            case KeyName.Number3:
                c = isShifted ? '#' : '3';
                return true;
            case KeyName.Keypad3:
                c = '3';
                return true;
            case KeyName.Number4:
                c = isShifted ? '$' : '4';
                return true;
            case KeyName.Keypad4:
                c = '4';
                return true;
            case KeyName.Number5:
                c = isShifted ? '%' : '5';
                return true;
            case KeyName.Keypad5:
                c = '5';
                return true;
            case KeyName.Number6:
                c = isShifted ? '^' : '6';
                return true;
            case KeyName.Keypad6:
                c = '6';
                return true;
            case KeyName.Number7:
                c = isShifted ? '&' : '7';
                return true;
            case KeyName.Keypad7:
                c = '7';
                return true;
            case KeyName.Number8:
                c = isShifted ? '*' : '8';
                return true;
            case KeyName.Keypad8:
                c = '8';
                return true;
            case KeyName.Number9:
                c = isShifted ? '(' : '9';
                return true;
            case KeyName.Keypad9:
                c = '9';
                return true;
            case KeyName.Number0:
                c = isShifted ? ')' : '0';
                return true;
            case KeyName.Keypad0:
                c = '0';
                return true;
            case KeyName.Minus:
                c = isShifted ? '_' : '-';
                return true;
            case KeyName.Equals:
                c = isShifted ? '+' : '=';
                return true;
            case KeyName.Tab:
                c = '\t';
                return true;
            case KeyName.Apostrophe:
                c = isShifted ? '\"' : '\'';
                return true;
            case KeyName.Backslash:
                c = isShifted ? '|' : '\\';
                return true;
            case KeyName.Semicolon:
                c = isShifted ? ':' : ';';
                return true;
            case KeyName.Comma:
                c = isShifted ? '<' : ',';
                return true;
            case KeyName.Period:
                c = isShifted ? '>' : '.';
                return true;
            case KeyName.Slash:
                c = isShifted ? '?' : '/';
                return true;
            case KeyName.Space:
                c = ' ';
                return true;
            case KeyName.KeypadAmpersand:
                c = '&';
                return true;
            case KeyName.KeypadPercent:
                c = '%';
                return true;
            case KeyName.KeypadColon:
                c = ':';
                return true;
            case KeyName.KeypadLeftParenthesis:
                c = '(';
                return true;
            case KeyName.KeypadRightParenthesis:
                c = ')';
                return true;
            case KeyName.KeypadPlus:
                c = '+';
                return true;
            case KeyName.KeypadComma:
                c = ',';
                return true;
            case KeyName.KeypadMinus:
                c = '-';
                return true;
            case KeyName.KeypadPeriod:
                c = '.';
                return true;
            case KeyName.KeypadDivide:
                c = '/';
                return true;
            case KeyName.KeypadEquals:
                c = '=';
                return true;
            case KeyName.KeypadEnter:
            case KeyName.Return:
            case KeyName.Return2:
                c = '\n';
                return true;
            case KeyName.KeypadExclamation:
                c = '!';
                return true;
            case KeyName.KeypadMultiply:
                c = '*';
                return true;
            case KeyName.Grave:
                c = '`';
                return true;
            case KeyName.CurrencyUnit:
                c = RegionInfo.CurrentRegion.CurrencySymbol[0];
                return true;
        }

        c = null;
        return false;
    }
}
