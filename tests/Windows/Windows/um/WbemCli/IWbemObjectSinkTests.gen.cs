// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IWbemObjectSink"/> struct.</summary>
public static unsafe partial class IWbemObjectSinkTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IWbemObjectSink"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWbemObjectSink).GUID, Is.EqualTo(IID_IWbemObjectSink));
    }

    /// <summary>Validates that the <see cref = "IWbemObjectSink"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWbemObjectSink>(), Is.EqualTo(sizeof(IWbemObjectSink)));
    }

    /// <summary>Validates that the <see cref = "IWbemObjectSink"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWbemObjectSink).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IWbemObjectSink"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWbemObjectSink), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWbemObjectSink), Is.EqualTo(4));
        }
    }
}