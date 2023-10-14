using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.UnitTests;

public class Ptr2DTests
{
    [Test]
    public void SingleStringPtrUtf8()
    {
        Ptr<byte> thing = STR_1;
        var thingPtr = thing.AsPtrMut2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf16()
    {
        Ptr<char> thing = STR_1;
        var thingPtr = thing.AsPtrMut2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringPtrUtf32()
    {
        Ptr<uint> thing = STR_1;
        var thingPtr = thing.AsPtrMut2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF32.GetString(
                MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
            Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringPtrUtf8FromSpan()
    {
        Span<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0");
        var thingPtr = thing.AsPtrMut2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromSpan()
    {
        var thing = MemoryMarshal.Cast<byte, char>(Encoding.Unicode.GetBytes(STR_1 + "\0"));
        var thingPtr = thing.AsPtrMut2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringPtrUtf32FromSpan()
    {
        var thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        var thingPtr = thing.AsPtrMut2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF32.GetString(
                MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
            Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf8FromPointerArray()
    {
        fixed (byte* thing = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            Ptr2D<byte> thingPtr = new[] { thing };
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
                Is.EqualTo(STR_1));
            Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromPointerArray()
    {
        fixed (byte* thing = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            Ptr2D<char> thingPtr = new[] { (char*)thing };
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
            Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf32FromPointerArray()
    {
        fixed (byte* thing = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            Ptr2D<uint> thingPtr = new[] { (uint*)thing };
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(
                Encoding.UTF32.GetString(
                    MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
                Is.EqualTo(STR_1));
            Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf8FromJaggedArray()
    {
        Ptr2D<byte> thingPtr = new[] { Encoding.UTF8.GetBytes(STR_1 + "\0") };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
            Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromJaggedArray()
    {
        Ptr2D<char> thingPtr = new[] {
            MemoryMarshal.Cast<byte, char>(Encoding.Unicode.GetBytes(STR_1 + "\0")).ToArray()
        };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf32FromJaggedArray()
    {
        Ptr2D<uint> thingPtr =
            new[] { MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0")).ToArray() };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF32.GetString(
                MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
            Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf8FromRawPointer()
    {
        fixed (byte* thing = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            Ptr2D<byte> thingPtr = &thing;
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
                Is.EqualTo(STR_1));
            Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromRawPointer()
    {
        fixed (byte* thing = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            Ptr2D<char> thingPtr = (char**)&thing;
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
            Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf32FromRawPointer()
    {
        fixed (byte* thing = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            Ptr2D<uint> thingPtr = (uint**)&thing;
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(
                Encoding.UTF32.GetString(
                    MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
                Is.EqualTo(STR_1));
            Assert.That(thingPtr.ToStringSpan(length: 1)[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void DoubleStringUtf8()
    {
        Ptr2D<byte> thingPtr = new[] { STR_1, STR_2 };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[1], Is.EqualTo(STR_2));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[1][0], Is.EqualTo(STR_2[0]));
        Assert.That(
            Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1) )),
            Is.EqualTo(STR_1));
        Assert.That(
            Encoding.UTF8.GetString(thingPtr[1].AsSpan(Encoding.UTF8.GetByteCount(STR_2) )),
            Is.EqualTo(STR_2));
        Assert.That(thingPtr.ToStringSpan(length: 2)[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 2)[1], Is.EqualTo(STR_2));
    }

    [Test]
    public void DoubleStringUtf16()
    {
        Ptr2D<char> thingPtr = new[] { STR_1, STR_2 };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[1], Is.EqualTo(STR_2));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[1][0], Is.EqualTo(STR_2[0]));
        Assert.That(
            Encoding.Unicode.GetString(MemoryMarshal.Cast<char, byte>(thingPtr[0].AsSpan(Encoding.Unicode.GetByteCount(STR_1) / 2))),
            Is.EqualTo(STR_1));
        Assert.That(
            Encoding.Unicode.GetString(MemoryMarshal.Cast<char, byte>(thingPtr[1].AsSpan(Encoding.Unicode.GetByteCount(STR_2) / 2))),
            Is.EqualTo(STR_2));
        Assert.That(thingPtr.ToStringSpan(length: 2)[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 2)[1], Is.EqualTo(STR_2));
    }

    [Test]
    public void DoubleStringUtf32()
    {
        Ptr2D<uint> thingPtr = new[] { STR_1, STR_2 };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[1], Is.EqualTo(STR_2));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[1][0], Is.EqualTo(STR_2[0]));
        Assert.That(
            Encoding.UTF32.GetString(MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
            Is.EqualTo(STR_1));
        Assert.That(
            Encoding.UTF32.GetString(MemoryMarshal.Cast<uint, byte>(thingPtr[1].AsSpan(Encoding.UTF32.GetByteCount(STR_2) / 4))),
            Is.EqualTo(STR_2));
        Assert.That(thingPtr.ToStringSpan(length: 2)[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 2)[1], Is.EqualTo(STR_2));
    }

    [Test]
    public void DoubleStringUtf8FromSpan()
    {
        Ptr2D<byte> thingPtr = new[] { STR_1, STR_2 }.AsSpan();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[1], Is.EqualTo(STR_2));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[1][0], Is.EqualTo(STR_2[0]));
        Assert.That(
            Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1) )),
            Is.EqualTo(STR_1));
        Assert.That(
            Encoding.UTF8.GetString(thingPtr[1].AsSpan(Encoding.UTF8.GetByteCount(STR_2) )),
            Is.EqualTo(STR_2));
        Assert.That(thingPtr.ToStringSpan(length: 2)[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 2)[1], Is.EqualTo(STR_2));
    }

    [Test]
    public void DoubleStringUtf16FromSpan()
    {
        Ptr2D<char> thingPtr = new[] { STR_1, STR_2 }.AsSpan();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[1], Is.EqualTo(STR_2));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[1][0], Is.EqualTo(STR_2[0]));
        Assert.That(
            Encoding.Unicode.GetString(MemoryMarshal.Cast<char, byte>(thingPtr[0].AsSpan(Encoding.Unicode.GetByteCount(STR_1) / 2))),
            Is.EqualTo(STR_1));
        Assert.That(
            Encoding.Unicode.GetString(MemoryMarshal.Cast<char, byte>(thingPtr[1].AsSpan(Encoding.Unicode.GetByteCount(STR_2) / 2))),
            Is.EqualTo(STR_2));
        Assert.That(thingPtr.ToStringSpan(length: 2)[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 2)[1], Is.EqualTo(STR_2));
    }

    [Test]
    public void DoubleStringUtf32FromSpan()
    {
        Ptr2D<uint> thingPtr = new[] { STR_1, STR_2 }.AsSpan();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[1], Is.EqualTo(STR_2));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[1][0], Is.EqualTo(STR_2[0]));
        Assert.That(
            Encoding.UTF32.GetString(MemoryMarshal.Cast<uint, byte>(thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4))),
            Is.EqualTo(STR_1));
        Assert.That(
            Encoding.UTF32.GetString(MemoryMarshal.Cast<uint, byte>(thingPtr[1].AsSpan(Encoding.UTF32.GetByteCount(STR_2) / 4))),
            Is.EqualTo(STR_2));
        Assert.That(thingPtr.ToStringSpan(length: 2)[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr.ToStringSpan(length: 2)[1], Is.EqualTo(STR_2));
    }

    [Test]
    public unsafe void NullIsNull()
    {
        Ptr2D<nint> ptr = nullptr;
        Assert.True(((delegate*<ref Ptr<nint>, bool>)(delegate*<ref readonly int, bool>)&Unsafe.IsNullRef<int>)(
            ref ((delegate*<in Ptr<nint>, ref Ptr<nint>>)(delegate*<ref readonly int, ref int>)&Unsafe.AsRef<int>)(
                in ptr.Ref)));
        Assert.True(((delegate*<ref Ptr<nint>, bool>)(delegate*<ref readonly int, bool>)&Unsafe.IsNullRef<int>)(
            ref ((delegate*<in Ptr<nint>, ref Ptr<nint>>)(delegate*<ref readonly int, ref int>)&Unsafe.AsRef<int>)(
                in ptr[0])));
        Assert.True(((delegate*<ref nint*, bool>)(delegate*<ref readonly int, bool>)&Unsafe.IsNullRef<int>)(
            ref ((delegate*<in nint*, ref nint*>)(delegate*<ref readonly int, ref int>)&Unsafe.AsRef<int>)(
                in ptr.GetPinnableReference())));
        Assert.True((nint**) ptr is null);
        Assert.True((void**) ptr is null);
    }
}
