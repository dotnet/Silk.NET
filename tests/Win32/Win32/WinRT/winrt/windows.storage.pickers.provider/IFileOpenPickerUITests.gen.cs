// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.pickers.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IFileOpenPickerUI"/> struct.</summary>
public static unsafe partial class IFileOpenPickerUITests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFileOpenPickerUI"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFileOpenPickerUI).GUID, Is.EqualTo(IID_IFileOpenPickerUI));
    }

    /// <summary>Validates that the <see cref = "IFileOpenPickerUI"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFileOpenPickerUI>(), Is.EqualTo(sizeof(IFileOpenPickerUI)));
    }

    /// <summary>Validates that the <see cref = "IFileOpenPickerUI"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFileOpenPickerUI).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFileOpenPickerUI"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFileOpenPickerUI), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFileOpenPickerUI), Is.EqualTo(4));
        }
    }
}
