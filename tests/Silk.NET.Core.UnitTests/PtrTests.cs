using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Pointers;

namespace Silk.NET.Core.UnitTests;

public class PtrTests
{
    [Test]
    public void SingleStringUtf8()
    {
        Ptr<byte> thing = STR_1;
        string thingBack = thing.ReadToString();
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16()
    {
        Ptr<char> thing = STR_1;
        string thingBack = thing.ReadToString();
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32()
    {
        Ptr<uint> thing = STR_1;
        string thingBack = thing.ReadToString();
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromByteArray()
    {
        Ptr<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromSpan()
    {
        Ptr<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0").AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromReadOnlySpan()
    {
        Ptr<byte> thing = (ReadOnlySpan<byte>) Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf8FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            Ptr<byte> thing = ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf16FromByteArray()
    {
        Ptr<char> thing = STR_1.ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromSpan()
    {
        Ptr<char> thing = STR_1.AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromReadOnlySpan()
    {
        Ptr<char> thing = (ReadOnlySpan<char>) STR_1;
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf16FromRawPointer()
    {
        fixed (byte* ptr = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            Ptr<char> thing = (char*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf32FromByteArray()
    {
        Ptr<uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0")).ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromSpan()
    {
        Ptr<uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromReadOnlySpan()
    {
        Ptr<uint> thing = (ReadOnlySpan<uint>)MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf32FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            Ptr<uint> thing = (uint*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void StringWithNonStringPointer()
    {
        nint dummy = 0x12345678;
        Assert.Throws<InvalidCastException>(() => _ = (Ptr<nint>)"Hello");
        Assert.Throws<InvalidCastException>(() => _ = (string)dummy.AsPtr());
    }

    [Test]
    public unsafe void NullIsNull()
    {
        Ptr<nint> ptr = nullptr;
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.Ref)));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr[0])));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.GetPinnableReference())));
        Assert.True((nint*) ptr is null);
        Assert.True((void*) ptr is null);
    }
}
