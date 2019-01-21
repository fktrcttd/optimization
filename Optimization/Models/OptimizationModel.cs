using System.Collections.Generic;

namespace Optimization.Models
{
    public class OptimizationModel
    {
        /// <summary>
        /// Список доменных печей
        /// </summary>
        public List<BlastFurnace> Furnaces { get; set; }

        /// <summary>
        /// Стоимость кокса, руб/(кг кокса)
        /// </summary>
        public double CoxCost { get; set; }

        /// <summary>
        /// Стоимость природного газа, руб/(м3 ПГ)
        /// </summary>
        public double GasCost { get; set; }

        /// <summary>
        /// Резерв по расходу природного газа в целом по цеху, м3/ч 
        /// </summary>
        public int GasSupply { get; set; }

        /// <summary>
        /// Запасы кокса по цеху, т/ч
        /// </summary>
        public int CoxSupply { get; set; }

        /// <summary>
        /// Требуемое производство чугуна в цехе, т/ч
        /// </summary>
        public int RequiredIronPerformance { get; set; }

        /// <summary>
        /// Результат оптимизации. Рассчитанная целевая функция
        /// </summary>
        public double OptimizedFunctionResult { get; set; }
    }
}