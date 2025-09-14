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


public class DummyCharConverter: ICharacterConverter
{
    private static CultureInfo Culture => CultureInfo.CurrentUICulture;
    private static int Layout => Culture.KeyboardLayoutId;
    public bool TryConvert(KeyName key, KeyModifiers modifiers, [NotNullWhen(true)] out char? c)
    {
        if (!key.IsChar())
        {
            c = null;
            return false;
        }

        char resultBeforeProcessing = '\0';
        bool isLetter = false;
        var isShifted = modifiers.IsShift();
        switch (key)
        {
            case KeyName.A:

        }
    }
}
