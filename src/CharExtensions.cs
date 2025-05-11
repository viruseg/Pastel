using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Pastel;

public static class CharExtensions
{
    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.Drawing.Color)"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, Color color)
    {
        return value.ToString().Pastel(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.ConsoleColor)"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, ConsoleColor color)
    {
        return value.ToString().Pastel(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in string)"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, in string hexColor)
    {
        return value.ToString().Pastel(hexColor);
    }

    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in ReadOnlySpan{char})"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, in ReadOnlySpan<char> hexColor)
    {
        return value.ToString().Pastel(hexColor);
    }



    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.Drawing.Color)"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, Color color, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.ConsoleColor)"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, ConsoleColor color, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in string)"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, in string hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(hexColor);
    }

    /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in ReadOnlySpan{char})"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string Pastel(this char value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).Pastel(hexColor);
    }



    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.Drawing.Color)"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, Color color)
    {
        return value.ToString().PastelBg(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.ConsoleColor)"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, ConsoleColor color)
    {
        return value.ToString().PastelBg(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,string)"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, in string hexColor)
    {
        return value.ToString().PastelBg(hexColor);
    }

    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,in ReadOnlySpan{char})"/>
    /// <inheritdoc cref="char.ToString()"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, in ReadOnlySpan<char> hexColor)
    {
        return value.ToString().PastelBg(hexColor);
    }



    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.Drawing.Color)"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, Color color, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.ConsoleColor)"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, ConsoleColor color, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(color);
    }

    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,string)"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, in string hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(hexColor);
    }

    /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,in ReadOnlySpan{char})"/>
    /// <inheritdoc cref="char.ToString(IFormatProvider?)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string PastelBg(this char value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
    {
        return value.ToString(provider).PastelBg(hexColor);
    }
}