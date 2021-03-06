﻿#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
[Equals(DoNotAddEquals = true, DoNotAddGetHashCode = true)]
public struct StructWithOnlyOperator
{
    public int Value { get; set; }

    public override bool Equals(object obj)
    {
        var second = (StructWithOnlyOperator) obj;

        return Value == 1 && second.Value == 2 || Value == 2 && second.Value == 1;
    }
}