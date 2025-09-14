// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Silk.NET.Input;

/// <summary>
/// A simple interface for an implementation that converts keyboard input into characters for text entry
/// </summary>
public interface ICharacterConverter
{
    public bool TryConvert(KeyName key, KeyModifiers modifiers, [NotNullWhen(true)] out char? c);
}


internal class DummyCharConverter: ICharacterConverter
{
    public bool TryConvert(KeyName key, KeyModifiers modifiers, [NotNullWhen(true)] out char? c)
    {
        if (!key.IsChar())
        {
            c = null;
            return false;
        }

        var isShifted = modifiers.IsShift();
        const char a = 'a';
        //const char A = 'A';
        const int aCode = (int)KeyName.A;
        const int max = (int)KeyName.Z - (int)KeyName.A;
        var diff = (int)key - aCode;
        if (diff is >= 0 and <= max)
        {
            var baseChar = a;
            c = (char)(baseChar + diff);
            if (isShifted)
            {
                c = CultureInfo.CurrentCulture.TextInfo.ToUpper(c.Value);
            }

            return true;
        }

        c = null;
        return false;
    }
}
