# Summary
- Make the windowing API return the key actually pressed, or any other key for that matter, instead of the key that is at
the same location on a US-Keyboard.

# Contributors
- Matija Brown, None

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decissions
- The main aspect is to change the original API as little as possible and also make the region-adapting
toggleable / add the abillity to manually set a keyboard layout. To achieve this diversity,
new layouts can be imported from an external file, but the included ones are hard coded. This way one can easilly switch between
layouts and / or import a new, custome one while the rest of the input API remains unchanged. Due to the fact this is toggleable,
it will also work the same way as before. The layout is saved in the IInputContext, as it is not possible to have different
keyboard layouts on different keyboards at the same time, so it needn't be saved in every keyboard instance. If writing custom layouts
turns out to be a common thing, there will be a layout generator created as well. For now key modifiers such as SHIFT will not be
considered, but that might be implemented at a later time.

# Proposed API

## KeyboardLayout
```cs
public class KeyboardLayout
{

    /// <summary>
    /// The different included layouts.
    /// </summary>
    public enum Layouts
    {
        /// <summary>
        /// Automatically detect layout and use.
        /// Works slightly differently to the hard-coded ones.
        /// </summary>
        Auto,

        /// <summary>
        /// The QWERTY layout
        /// </summary>
        QWERTY,
        QÜERTY,
        ÄWERTY,
        QERTZ,
        ...

        NoLayout,
        LastLayout
    }

    /// <summary>
    /// The name of the Layout.
    /// </summary>
    public static string Name { get; }

    /// <summary>
    /// Get an included layout by name.
    /// </summary>
    public static KeyboardLayout Get(Layouts.Path);

    /// <summary>
    /// Get a custom keyboard layout by path to the specifications file.
    /// </summary>
    public static KeyboardLayout Get(string path);
}
```

## IInputContext
```diff
+ KeyboardLayout Layout { get; set } = KeyboardLayout.Get(KeyboardLayout.Layouts.Auto)
```

## Layout File
// Original Value In QWERTY -> New Value In Your Layout
// Obviously this is only done for the keys included in GLFW, but as they
// are close to ASCII it should be simple to write. No lowercase letters
// as they only exist on the char callbacks, not the key callbacks.
65 -> 68 // A will be D
// alternatively, as char and int are interchangeable in c# :) :
A->D

## Example Usage
```cs
class ExampleUsage
{
    // ... the hello window example here ...
    private static void OnLoad()
    {
        var input = window.CreateInput();
        input.Layout = KeyboardLayout.Get(KeyboardLayout.Layouts.QWERTZ);
        // alternatively: input.Layout = KeyboardLayout.Get("layouts/mySpecialAndGreatLayoutThatCuresCancer.txtOrWhateverIdontKnowYet");
        foreach (var keyboard in input.Keyboards)
        {
            keyboard.KeyDown += KeyDown;
        }
    }
    // ... goes on here ...
}
```