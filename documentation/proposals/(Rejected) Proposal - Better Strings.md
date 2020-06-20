# Summary
A rich, more well-defined native string API.

- Written against Silk.NET **1.0.2**.
- Slated for Silk.NET **2.0.0**.

# Contributors
- Dylan P, Ultz Limited

# Current Status
- [x] Proposed
- [ ] Discussed with API Review Board (ARB)
- [ ] Approved
- [ ] Implemented

# Design Decisions
Currently, the representation of native strings in Silk.NET (and C# as a whole) is an utter mess.
At the moment we're using `char*` everywhere which isn't technically correct, as a number of users
have pointed out. This discussion aims to create a richer set of native string APIs to combine
technical correctness, ease of marshalling, and ease of use.

This is in the form of Char8, Char16, and Char32 which represent the various lengths of characters
in various encodings. These CharXXs can be combined into a StringXX. All types can be implicitly
converted to and from their existing C#/.NET types, so that the user doesn't have to deal with much

# Proposed API
Proposed Silk.NET.Core additions:
```cs
public struct Char8
{
    private byte _value; // 8-bit character
    public Char8(byte v) => _value = v;
    public static explicit operator Char8(char c);
    public static implicit operator Char8(byte c);
    // and vice versa
    public char ToChar();
    public byte ToByte();
    public uint ToUInt32();
}

public struct Char16
{
    private char _value; // 16-bit character
    public Char16(char v) => _value = v;
    // insert appropriate operators and methods here as seen in Char8
}

public struct Char32
{
    private uint _value; // 32-bit character
    public Char32(char hi, char lo) => _value = unchecked((uint) char.ConvertToUtf32(hi, lo));
    // insert appropriate operators and methods here as seen in Char8
}

public ref struct String8
{
    private Span<Char8> _value;
    public String8(Span<Char8> v) => _value = v;
    public static implicit operator String8(Span<Char8> v);
    public static implicit operator String8(string x); // not recommended for use, as we'll have to assume the encoding the user wants is UTF8.
    public static implicit operator String8(Char8* v); // treat the Char8* as null-terminated
    public static implicit operator String8(byte* v); // cast to Char8*, pass to the above.
    public static explicit operator String8(char* v); // cast to byte*, pass to the above. for maintaining back-compat with Silk.NET 1.0.
    // and vice versa
    public override string ToString();
    public ref readonly Char8 GetPinnableReference();
}

public ref struct String16
{
    private Span<Char16> _value;
    public String16(Span<Char16> v) => _value = v;
    // insert appropriate methods and operators here as seen in String8
    public override string ToString();
    public ref readonly Char16 GetPinnableReference();
}

public ref struct String32
{
    private Span<Char32> _value;
    public String16(Span<Char32> v) => _value = v;
    // insert appropriate methods and operators here as seen in String8
    public override string ToString();
    public ref readonly Char32 GetPinnableReference();
}
```

Proposed binder output:
```cs
delegate cdecl*<GLEnum, Char8*> _glGetString;
public String8 GetString(GLEnum name) => (String8) _glGetString(name);
// No need for a string overload, as you can implicitly cast String8 to string.
// Users migrating to 2.0 will simply have to cast the String8 to string (better than them having to marshal it!)
```

Proposed GLFW changes:
```cs
delegate cdecl*<WindowHandle*, Char8*, void> _glfwSetWindowTitle;
public void SetWindowTitle(WindowHandle* h, String8 t);
```

You kinda get the gist from here...
