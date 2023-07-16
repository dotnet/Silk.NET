// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDiscFormat2RawCDEventArgs"/> struct.</summary>
public static unsafe partial class IDiscFormat2RawCDEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiscFormat2RawCDEventArgs"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiscFormat2RawCDEventArgs).GUID, Is.EqualTo(IID_IDiscFormat2RawCDEventArgs));
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2RawCDEventArgs"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiscFormat2RawCDEventArgs>(), Is.EqualTo(sizeof(IDiscFormat2RawCDEventArgs)));
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2RawCDEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiscFormat2RawCDEventArgs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2RawCDEventArgs"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiscFormat2RawCDEventArgs), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiscFormat2RawCDEventArgs), Is.EqualTo(4));
        }
    }
}