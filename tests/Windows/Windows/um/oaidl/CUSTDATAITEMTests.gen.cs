// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CUSTDATAITEM"/> struct.</summary>
public static unsafe partial class CUSTDATAITEMTests
{
    /// <summary>Validates that the <see cref = "CUSTDATAITEM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CUSTDATAITEM>(), Is.EqualTo(sizeof(CUSTDATAITEM)));
    }

    /// <summary>Validates that the <see cref = "CUSTDATAITEM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CUSTDATAITEM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CUSTDATAITEM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CUSTDATAITEM), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(CUSTDATAITEM), Is.EqualTo(32));
        }
    }
}