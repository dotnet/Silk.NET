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

## IKeyboardLayout
```cs
internal interface IKeyboardLayout
{

    /// <summary>
    /// Gets the name from an instance.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Called from GlfwKeyboard.ConvertKey, easy place to get the keys,
    /// and no use converting to Silk.NET keys and then swap them arround again.
    /// </summary>
    Key MapKey(Keys glfwKey);

}
```

## QWERTYLayout
```cs
/// <summary>
/// Example class for all layouts.
/// </summary>
public sealed class QWERTYLayout : IKeyboardLayout
{

    /// <summary>
    /// The name of the layout.
    /// </summary>
    public const string NAME = "QWERTY";

    /// <summary>
    /// Non-Static name.
    /// </summary>
    public string Name { get } = NAME;

}
```

## CustomLayout
```cs
/// <summary>
/// The implementation of custom, file-read layouts.
/// </summary>
public sealed class CustomLayout : IKeyboardLayout
{

    /// <summary>
    /// Get the name. No static name here because it changes with each file.
    /// </summary>
    public string Name { get => _name }

    /// <summary>
    /// Loads the file and uses the contained layout as the keyboard layout.
    /// </summary>
    public CustomLayout(string file);

}
```

## KeyboardLayout
```cs
public static class LayoutManager
{

    /// <summary>
    /// The QWERTY layout.
    /// </summary>
    public static readonly IKeyboardLayout QWERTY;
    ...

    /// <summary>
    /// Automatically gets the keyboard layout set on the device.
    /// </summary>
    public static IKeyboardLayout GetDeviceLayout();

}
```

## IInputContext
```diff
+ IKeyboardLayout Layout { get; set } = LayoutManager.GetDeviceLayout();
```

## Layout File
```
// Original Value In QWERTY -> New Value In Your Layout
// Obviously this is only done for the keys included in GLFW, but as they
// are close to ASCII it should be simple to write. No lowercase letters
// as they only exist on the char callbacks, not the key callbacks.
// The line in double quotes in the beginning of the file is the name.
"ExampleLayout"
65->68 // A will be D
// alternatively, as char and int are interchangeable in c# :) :
A->D
```

## Example Usage
```cs
class ExampleUsage
{
    // ... the hello window example here ...
    private static void OnLoad()
    {
        var input = window.CreateInput();
        input.Layout = LayoutManager.QWERTY;
        // alternatively: input.Layout = new CustomLayout("exampleLayout.layout");
        foreach (var keyboard in input.Keyboards)
        {
            keyboard.KeyDown += KeyDown;
        }
    }
    // ... goes on here ...
}
```