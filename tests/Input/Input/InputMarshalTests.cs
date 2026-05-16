// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Reflection;
using NUnit.Framework;

namespace Silk.NET.Input.UnitTests;

[TestFixture]
public class InputMarshalTests
{
    [TestCase(TypeArgs = [typeof(PointerButton)])]
    [TestCase(TypeArgs = [typeof(JoystickButton)])]
    [TestCase(TypeArgs = [typeof(KeyName)])]
    public void GetButtonCount<T>()
        where T : unmanaged, Enum
    {
        // This is to determine the gaps in KeyName.
        var prev = -1;
        foreach (var @enum in Enum.GetValues<T>().Order())
        {
            var val = SilkMarshal.ConstCast<T, int>(@enum);
            if (val - 1 != prev)
            {
                Console.WriteLine(
                    $"{prev} ({SilkMarshal.ConstCast<int, T>(prev)}), {val} ({@enum})"
                );
            }

            prev = val;
        }
    }

    [TestCase(TypeArgs = [typeof(PointerButton)])]
    [TestCase(TypeArgs = [typeof(JoystickButton)])]
    [TestCase(TypeArgs = [typeof(KeyName)])]
    public void EnumerateButtonList<T>()
        where T : unmanaged, Enum
    {
        var list = InputMarshal.CreateList<Button<T>>();
        var expectedCount = Enum.GetNames(typeof(T))
            .DistinctBy(Enum.Parse<T>)
            .Count(x => x != "Unknown");
        Assert.That(list.List, Has.Count.EqualTo(expectedCount));
        var encountered = 0;
        var values = Enum.GetValues<T>()
            .Where(x => x.ToString() != "Unknown")
            .Distinct()
            .Order()
            .GetEnumerator();
        foreach (var btn in list.List)
        {
            encountered++;
            Assert.Multiple(() =>
            {
                Assert.That(values.MoveNext(), Is.True);
                Assert.That(btn.Name, Is.EqualTo(values.Current));
                Assert.That(btn.Pressure, Is.EqualTo(0));
                Assert.That(btn.IsDown, Is.False);
            });
        }

        Assert.That(encountered, Is.EqualTo(expectedCount));
    }

    [TestCase(TypeArgs = [typeof(PointerButton)])]
    [TestCase(TypeArgs = [typeof(JoystickButton)])]
    [TestCase(TypeArgs = [typeof(KeyName)])]
    public void IndexButtonList<T>()
        where T : unmanaged, Enum
    {
        var list = InputMarshal.CreateList<Button<T>>();
        var idx = 0;
        foreach (
            var name in Enum.GetValues<T>().Where(x => x.ToString() != "Unknown").Distinct().Order()
        )
        {
            var btn = list.List[idx++];
            Assert.Multiple(() =>
            {
                Assert.That(btn.Name, Is.EqualTo(name));
                Assert.That(btn.Pressure, Is.EqualTo(0));
                Assert.That(btn.IsDown, Is.False);
            });
        }
    }

    [TestCase(TypeArgs = [typeof(PointerButton)])]
    [TestCase(TypeArgs = [typeof(JoystickButton)])]
    [TestCase(TypeArgs = [typeof(KeyName)])]
    public void GetButtonState<T>()
        where T : unmanaged, Enum
    {
        var list = InputMarshal.CreateList<Button<T>>().List.AsButtonList();
        foreach (
            var name in Enum.GetValues<T>().Where(x => x.ToString() != "Unknown").Distinct().Order()
        )
        {
            var btn = list[name];
            Assert.Multiple(() =>
            {
                Assert.That(btn.Name, Is.EqualTo(name));
                Assert.That(btn.Pressure, Is.EqualTo(0));
                Assert.That(btn.IsDown, Is.False);
            });
        }
    }

    [TestCase(TypeArgs = [typeof(PointerButton)])]
    [TestCase(TypeArgs = [typeof(JoystickButton)])]
    [TestCase(TypeArgs = [typeof(KeyName)])]
    public void IndexNameTranslationRoundTrip<T>()
        where T : unmanaged, Enum
    {
        var values = Enum.GetValues<T>()
            .Where(x => x.ToString() != "Unknown")
            .Distinct()
            .Order()
            .GetEnumerator();
        for (var i = 0; i < InputMarshal.GetButtonListCount<T>(); i++)
        {
            Assert.That(values.MoveNext(), Is.True);
            var name = InputMarshal.ButtonList<T>.IndexName(i);
            Assert.Multiple(() =>
            {
                Assert.That(name, Is.EqualTo(values.Current));
                Assert.That(InputMarshal.ButtonList<T>.NameIndex(name), Is.EqualTo(i));
            });
        }
    }

    [TestCase(TypeArgs = [typeof(PointerButton)])]
    [TestCase(TypeArgs = [typeof(JoystickButton)])]
    [TestCase(TypeArgs = [typeof(KeyName)])]
    public void SetGetBinaryButtonState<T>()
        where T : unmanaged, Enum
    {
        var arr = Enum.GetValues<T>()
            .Where(x => x.ToString() != "Unknown")
            .Distinct()
            .Order()
            .ToArray();
        foreach (var name in arr)
        {
            var list = InputMarshal.CreateList<Button<T>>();
            InputMarshal.SetButtonState(list, new Button<T>(name, true, 1), true);
            foreach (var testName in arr)
            {
                var btn = list.List.AsButtonList()[testName];
                Assert.Multiple(() =>
                {
                    Assert.That(btn.Name, Is.EqualTo(testName));
                    Assert.That(btn.Pressure, Is.EqualTo(testName.Equals(name) ? 1 : 0));
                    Assert.That(btn.IsDown, Is.EqualTo(testName.Equals(name)));
                });
            }
        }
    }
}
