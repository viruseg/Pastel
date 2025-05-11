using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Pastel
{
    public static class FloatExtensions
    {
        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, Color color)
        {
            return value.ToString().Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, ConsoleColor color)
        {
            return value.ToString().Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in string)"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in string hexColor)
        {
            return value.ToString().Pastel(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in ReadOnlySpan<char> hexColor)
        {
            return value.ToString().Pastel(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, Color color, IFormatProvider? provider)
        {
            return value.ToString(provider).Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, ConsoleColor color, IFormatProvider? provider)
        {
            return value.ToString(provider).Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in string)"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in string hexColor, IFormatProvider? provider)
        {
            return value.ToString(provider).Pastel(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
        {
            return value.ToString(provider).Pastel(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, Color color, string? format)
        {
            return value.ToString(format).Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, ConsoleColor color, string? format)
        {
            return value.ToString(format).Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in string)"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in string hexColor, string? format)
        {
            return value.ToString(format).Pastel(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in ReadOnlySpan<char> hexColor, string? format)
        {
            return value.ToString(format).Pastel(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, Color color, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, ConsoleColor color, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).Pastel(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in string)"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in string hexColor, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).Pastel(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.Pastel(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Pastel(this float value, in ReadOnlySpan<char> hexColor, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).Pastel(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, Color color)
        {
            return value.ToString().PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, ConsoleColor color)
        {
            return value.ToString().PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,string)"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in string hexColor)
        {
            return value.ToString().PastelBg(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString()"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in ReadOnlySpan<char> hexColor)
        {
            return value.ToString().PastelBg(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, Color color, IFormatProvider? provider)
        {
            return value.ToString(provider).PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, ConsoleColor color, IFormatProvider? provider)
        {
            return value.ToString(provider).PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,string)"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in string hexColor, IFormatProvider? provider)
        {
            return value.ToString(provider).PastelBg(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString(IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in ReadOnlySpan<char> hexColor, IFormatProvider? provider)
        {
            return value.ToString(provider).PastelBg(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, Color color, string? format)
        {
            return value.ToString(format).PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, ConsoleColor color, string? format)
        {
            return value.ToString(format).PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,string)"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in string hexColor, string? format)
        {
            return value.ToString(format).PastelBg(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString(string?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in ReadOnlySpan<char> hexColor, string? format)
        {
            return value.ToString(format).PastelBg(hexColor);
        }



        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.Drawing.Color)"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, Color color, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,System.ConsoleColor)"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, ConsoleColor color, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).PastelBg(color);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,string)"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in string hexColor, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).PastelBg(hexColor);
        }

        /// <inheritdoc cref="ConsoleExtensions.PastelBg(string,in ReadOnlySpan{char})"/>
        /// <inheritdoc cref="float.ToString(string?,IFormatProvider?)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string PastelBg(this float value, in ReadOnlySpan<char> hexColor, string? format, IFormatProvider? provider)
        {
            return value.ToString(format, provider).PastelBg(hexColor);
        }
    }
}