using System.Globalization;

namespace TecnoStore.Helpers;

public static class Money
{
    public static string Fmt(this decimal value) =>
        "S/ " + value.ToString("N2", CultureInfo.InvariantCulture);
}