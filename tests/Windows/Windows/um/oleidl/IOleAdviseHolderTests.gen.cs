// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IOleAdviseHolder"/> struct.</summary>
public static unsafe partial class IOleAdviseHolderTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IOleAdviseHolder"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IOleAdviseHolder).GUID, Is.EqualTo(IID_IOleAdviseHolder));
    }

    /// <summary>Validates that the <see cref = "IOleAdviseHolder"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IOleAdviseHolder>(), Is.EqualTo(sizeof(IOleAdviseHolder)));
    }

    /// <summary>Validates that the <see cref = "IOleAdviseHolder"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IOleAdviseHolder).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IOleAdviseHolder"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IOleAdviseHolder), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IOleAdviseHolder), Is.EqualTo(4));
        }
    }
}