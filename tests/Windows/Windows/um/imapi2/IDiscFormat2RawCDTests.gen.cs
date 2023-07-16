// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDiscFormat2RawCD"/> struct.</summary>
public static unsafe partial class IDiscFormat2RawCDTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDiscFormat2RawCD"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiscFormat2RawCD).GUID, Is.EqualTo(IID_IDiscFormat2RawCD));
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2RawCD"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiscFormat2RawCD>(), Is.EqualTo(sizeof(IDiscFormat2RawCD)));
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2RawCD"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiscFormat2RawCD).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDiscFormat2RawCD"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiscFormat2RawCD), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiscFormat2RawCD), Is.EqualTo(4));
        }
    }
}