namespace Opc.Ua.Server.Functions;

using System.Text;
using Opc.Ua;

/// <summary>
///
/// </summary>
public static class EventFilterFuncs
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public static string EventFilterSelects(EventFilter filter)
    {
        var sb = new StringBuilder();
        foreach (var item in filter.SelectClauses)
        {
            sb.AppendLine(item.ToString());
        }
        return sb.ToString();
    }
}
