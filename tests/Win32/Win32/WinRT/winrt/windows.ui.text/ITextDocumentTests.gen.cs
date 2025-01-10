// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ITextDocument"/> struct.</summary>
public static unsafe partial class ITextDocumentTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITextDocument"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITextDocument).GUID, Is.EqualTo(IID_ITextDocument));
    }

    /// <summary>Validates that the <see cref = "ITextDocument"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITextDocument>(), Is.EqualTo(sizeof(ITextDocument)));
    }

    /// <summary>Validates that the <see cref = "ITextDocument"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITextDocument).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITextDocument"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITextDocument), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITextDocument), Is.EqualTo(4));
        }
    }
}
