using System.Collections.Generic;

namespace WindowsFormsApp1.Interfaces
{
    public interface ICalcModel
    {
        decimal Total { get; }
        decimal RunningTotal { get; }
        void CalculateTotal(List<decimal> numbers);
    }
}
