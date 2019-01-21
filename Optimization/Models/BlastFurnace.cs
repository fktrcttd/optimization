using System;

namespace Optimization.Models
{
    public class BlastFurnace
    {

        
        public Int32 FurnanceId { get; set; }
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary>
        public double GasExpenseBasePeriod { get; set; }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary>
        public double MinGasExpense { get; set; }
        
        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary>
        public double MaxGasExpense { get; set; }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary>
        public double CoxExpenseBasePeriod { get; set; }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary>
        public double CoxReplacementEquivalent { get; set; }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary>
        public double IronPerformance { get; set; }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary>
        public int TheoreticTemperatureBasePeriod { get; set; }
        
        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary>
        public double MinTemperature { get; set; }
        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary>
        public double MaxTemperature { get; set; }

        /// <summary>
        /// РАсход газа. Его необходимо подбирать
        /// </summary>
        public double GasExpenseToReadjust { get; set; }

        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary>
        public double DeltaIronPerformanceGasChanged { get; set; }
        
        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary>
        public double DeltaIronPerformanceCoxChanged { get; set; }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 1 м3/ч
        /// </summary>
        public double DeltaTemperatureGasChanged { get; set; }



    }
}